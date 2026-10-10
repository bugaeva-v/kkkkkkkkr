using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Threading
{
	/// <summary>Позволяет нескольким задачам параллельно работать с алгоритмом, используя несколько фаз.</summary>
	// Token: 0x0200017D RID: 381
	[ComVisible(false)]
	[DebuggerDisplay("Participant Count={ParticipantCount},Participants Remaining={ParticipantsRemaining}")]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public class Barrier : IDisposable
	{
		/// <summary>Получает количество участников в барьере, которые еще не создали сигнал в текущей фазе.</summary>
		/// <returns>Возвращает количество участников в барьере, которые еще не создали сигнал на текущем этапе.</returns>
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0002C438 File Offset: 0x0002A638
		public int ParticipantsRemaining
		{
			get
			{
				int currentTotalCount = this.m_currentTotalCount;
				int num = currentTotalCount & 32767;
				int num2 = (currentTotalCount & 2147418112) >> 16;
				return num - num2;
			}
		}

		/// <summary>Получает общее количество участников в барьере.</summary>
		/// <returns>Возвращает общее количество участников в барьере.</returns>
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002C462 File Offset: 0x0002A662
		public int ParticipantCount
		{
			get
			{
				return this.m_currentTotalCount & 32767;
			}
		}

		/// <summary>Получает номер текущей фазы барьера.</summary>
		/// <returns>Возвращает номер текущего этапа барьера.</returns>
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0002C472 File Offset: 0x0002A672
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0002C47F File Offset: 0x0002A67F
		public long CurrentPhaseNumber
		{
			get
			{
				return Volatile.Read(ref this.m_currentPhase);
			}
			internal set
			{
				Volatile.Write(ref this.m_currentPhase, value);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Barrier" />.</summary>
		/// <param name="participantCount">Количество участвующих потоков.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="participantCount" /> имеет значение меньше 0 или больше 32 767.</exception>
		// Token: 0x06000A29 RID: 2601 RVA: 0x0002C48D File Offset: 0x0002A68D
		public Barrier(int participantCount) : this(participantCount, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Barrier" />.</summary>
		/// <param name="participantCount">Количество участвующих потоков.</param>
		/// <param name="postPhaseAction">Действие <see cref="T:System.Action`1" />, выполняемое после каждой фазы. Чтобы указать на отсутствие действия, можно передать значение NULL (Nothing в Visual Basic).</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="participantCount" /> имеет значение меньше 0 или больше 32 767.</exception>
		// Token: 0x06000A2A RID: 2602 RVA: 0x0002C498 File Offset: 0x0002A698
		public Barrier(int participantCount, Action<Barrier> postPhaseAction)
		{
			if (participantCount < 0 || participantCount > 32767)
			{
				throw new ArgumentOutOfRangeException("participantCount", participantCount, SR.GetString("The participantCount argument must be non-negative and less than or equal to 32767."));
			}
			this.m_currentTotalCount = participantCount;
			this.m_postPhaseAction = postPhaseAction;
			this.m_oddEvent = new ManualResetEventSlim(true);
			this.m_evenEvent = new ManualResetEventSlim(false);
			if (postPhaseAction != null && !ExecutionContext.IsFlowSuppressed())
			{
				this.m_ownerThreadContext = ExecutionContext.Capture();
			}
			this.m_actionCallerID = 0;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0002C516 File Offset: 0x0002A716
		private void GetCurrentTotal(int currentTotal, out int current, out int total, out bool sense)
		{
			total = (currentTotal & 32767);
			current = (currentTotal & 2147418112) >> 16;
			sense = ((currentTotal & int.MinValue) == 0);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002C540 File Offset: 0x0002A740
		private bool SetCurrentTotal(int currentTotal, int current, int total, bool sense)
		{
			int num = current << 16 | total;
			if (!sense)
			{
				num |= int.MinValue;
			}
			return Interlocked.CompareExchange(ref this.m_currentTotalCount, num, currentTotal) == currentTotal;
		}

		/// <summary>Уведомляет <see cref="T:System.Threading.Barrier" /> о добавлении дополнительного участника.</summary>
		/// <returns>Номер фазы барьера, в которой сначала участвуют новые участники.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Добавление участника приведет к превышению 32 767 счетчиком участников барьера.  
		///
		/// или - 
		/// Метод был вызван из действия после этапа.</exception>
		// Token: 0x06000A2D RID: 2605 RVA: 0x0002C570 File Offset: 0x0002A770
		public long AddParticipant()
		{
			long result;
			try
			{
				result = this.AddParticipants(1);
			}
			catch (ArgumentOutOfRangeException)
			{
				throw new InvalidOperationException(SR.GetString("Adding participantCount participants would result in the number of participants exceeding the maximum number allowed."));
			}
			return result;
		}

		/// <summary>Уведомляет барьер <see cref="T:System.Threading.Barrier" /> о добавлении дополнительных участников.</summary>
		/// <param name="participantCount">Число дополнительных участников, которых необходимо добавить в барьер.</param>
		/// <returns>Номер фазы барьера, в которой сначала участвуют новые участники.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="participantCount" /> меньше 0.  
		///
		/// или - 
		/// Добавление участников <paramref name="participantCount" /> приведет к превышению 32 767 счетчиком участников барьера.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод был вызван из действия после этапа.</exception>
		// Token: 0x06000A2E RID: 2606 RVA: 0x0002C5AC File Offset: 0x0002A7AC
		public long AddParticipants(int participantCount)
		{
			this.ThrowIfDisposed();
			if (participantCount < 1)
			{
				throw new ArgumentOutOfRangeException("participantCount", participantCount, SR.GetString("The participantCount argument must be a positive value."));
			}
			if (participantCount > 32767)
			{
				throw new ArgumentOutOfRangeException("participantCount", SR.GetString("Adding participantCount participants would result in the number of participants exceeding the maximum number allowed."));
			}
			if (this.m_actionCallerID != 0 && Thread.CurrentThread.ManagedThreadId == this.m_actionCallerID)
			{
				throw new InvalidOperationException(SR.GetString("This method may not be called from within the postPhaseAction."));
			}
			SpinWait spinWait = default(SpinWait);
			bool flag;
			for (;;)
			{
				int currentTotalCount = this.m_currentTotalCount;
				int current;
				int num;
				this.GetCurrentTotal(currentTotalCount, out current, out num, out flag);
				if (participantCount + num > 32767)
				{
					break;
				}
				if (this.SetCurrentTotal(currentTotalCount, current, num + participantCount, flag))
				{
					goto Block_6;
				}
				spinWait.SpinOnce();
			}
			throw new ArgumentOutOfRangeException("participantCount", SR.GetString("Adding participantCount participants would result in the number of participants exceeding the maximum number allowed."));
			Block_6:
			long currentPhaseNumber = this.CurrentPhaseNumber;
			long num2 = (flag != (currentPhaseNumber % 2L == 0L)) ? (currentPhaseNumber + 1L) : currentPhaseNumber;
			if (num2 != currentPhaseNumber)
			{
				if (flag)
				{
					this.m_oddEvent.Wait();
				}
				else
				{
					this.m_evenEvent.Wait();
				}
			}
			else if (flag && this.m_evenEvent.IsSet)
			{
				this.m_evenEvent.Reset();
			}
			else if (!flag && this.m_oddEvent.IsSet)
			{
				this.m_oddEvent.Reset();
			}
			return num2;
		}

		/// <summary>Уведомляет <see cref="T:System.Threading.Barrier" /> о удалении одного участника.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Барьер уже содержит 0 участников.  
		///
		/// или - 
		/// Метод был вызван из действия после этапа.</exception>
		// Token: 0x06000A2F RID: 2607 RVA: 0x0002C700 File Offset: 0x0002A900
		public void RemoveParticipant()
		{
			this.RemoveParticipants(1);
		}

		/// <summary>Уведомляет барьер <see cref="T:System.Threading.Barrier" /> об удалении нескольких участников.</summary>
		/// <param name="participantCount">Число дополнительных участников, которых необходимо удалить из барьера.</param>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Общее число участников меньше указанного <paramref name="participantCount" /></exception>
		/// <exception cref="T:System.InvalidOperationException">Барьер уже содержит 0 участников.  
		///
		/// или - 
		/// Метод был вызван из действия после этапа.  
		///
		/// или - 
		/// текущее количество участников меньше указанного participantCount</exception>
		// Token: 0x06000A30 RID: 2608 RVA: 0x0002C70C File Offset: 0x0002A90C
		public void RemoveParticipants(int participantCount)
		{
			this.ThrowIfDisposed();
			if (participantCount < 1)
			{
				throw new ArgumentOutOfRangeException("participantCount", participantCount, SR.GetString("The participantCount argument must be a positive value."));
			}
			if (this.m_actionCallerID != 0 && Thread.CurrentThread.ManagedThreadId == this.m_actionCallerID)
			{
				throw new InvalidOperationException(SR.GetString("This method may not be called from within the postPhaseAction."));
			}
			SpinWait spinWait = default(SpinWait);
			bool flag;
			for (;;)
			{
				int currentTotalCount = this.m_currentTotalCount;
				int num;
				int num2;
				this.GetCurrentTotal(currentTotalCount, out num, out num2, out flag);
				if (num2 < participantCount)
				{
					break;
				}
				if (num2 - participantCount < num)
				{
					goto Block_5;
				}
				int num3 = num2 - participantCount;
				if (num3 > 0 && num == num3)
				{
					if (this.SetCurrentTotal(currentTotalCount, 0, num2 - participantCount, !flag))
					{
						goto Block_8;
					}
				}
				else if (this.SetCurrentTotal(currentTotalCount, num, num2 - participantCount, flag))
				{
					return;
				}
				spinWait.SpinOnce();
			}
			throw new ArgumentOutOfRangeException("participantCount", SR.GetString("The participantCount argument must be less than or equal the number of participants."));
			Block_5:
			throw new InvalidOperationException(SR.GetString("The participantCount argument is greater than the number of participants that haven't yet arrived at the barrier in this phase."));
			Block_8:
			this.FinishPhase(flag);
		}

		/// <summary>Сообщает, что участник достиг барьера  и ожидает достижения барьера другими участниками.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод был вызван из действия после этапа, барьер в настоящий момент имеет 0 участников или барьер получает сигналы от большего числа потоков, чем зарегистрировано участников.</exception>
		/// <exception cref="T:System.Threading.BarrierPostPhaseException">Если создается исключение из действия следующего этапа барьера после того, как все участвующие потоки вызвали SignalAndWait, исключение будет вставлено в BarrierPostPhaseException и создано для всех участвующих потоков.</exception>
		// Token: 0x06000A31 RID: 2609 RVA: 0x0002C7FC File Offset: 0x0002A9FC
		public void SignalAndWait()
		{
			this.SignalAndWait(default(CancellationToken));
		}

		/// <summary>Сообщает, что участник достиг барьера  и ожидает достижения барьера всеми другими участниками. Кроме того, метод контролирует токен отмены.</summary>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод был вызван из действия после этапа, барьер в настоящий момент имеет 0 участников или барьер получает сигналы от большего числа потоков, чем зарегистрировано участников.</exception>
		// Token: 0x06000A32 RID: 2610 RVA: 0x0002C818 File Offset: 0x0002AA18
		public void SignalAndWait(CancellationToken cancellationToken)
		{
			this.SignalAndWait(-1, cancellationToken);
		}

		/// <summary>Сообщает, что участник достиг барьера и ожидает достижения барьера всеми другими участниками, используя объект <see cref="T:System.TimeSpan" /> для измерения интервала времени.</summary>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Значение true, если все остальные участники достигли барьера; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от значения –1 миллисекунды, которое представляет неограниченное время ожидания, или превышает 32 767.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод был вызван из действия после этапа, барьер в настоящий момент имеет 0 участников или барьер получает сигналы от большего числа потоков, чем зарегистрировано участников.</exception>
		// Token: 0x06000A33 RID: 2611 RVA: 0x0002C824 File Offset: 0x0002AA24
		public bool SignalAndWait(TimeSpan timeout)
		{
			return this.SignalAndWait(timeout, default(CancellationToken));
		}

		/// <summary>Сообщает, что участник достиг барьера и ожидает достижения барьера всеми другими участниками, используя объект <see cref="T:System.TimeSpan" /> для измерения интервала времени. Кроме того, метод контролирует токен отмены.</summary>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Значение true, если все остальные участники достигли барьера; в противном случае — значение false.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод был вызван из действия после этапа, барьер в настоящий момент имеет 0 участников или барьер получает сигналы от большего числа потоков, чем зарегистрировано участников.</exception>
		// Token: 0x06000A34 RID: 2612 RVA: 0x0002C844 File Offset: 0x0002AA44
		public bool SignalAndWait(TimeSpan timeout, CancellationToken cancellationToken)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SR.GetString("The specified timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			return this.SignalAndWait((int)timeout.TotalMilliseconds, cancellationToken);
		}

		/// <summary>Сообщает, что участник достиг барьера  и ожидает достижения барьера всеми другими участниками, используя 32-разрядное знаковое целое число для измерения времени ожидания.</summary>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или <see cref="F:System.Threading.Timeout.Infinite" /> (-1) для неограниченного времени ожидания.</param>
		/// <returns>Значение true, если все участники достигли барьера за указанное время; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод был вызван из действия после этапа, барьер в настоящий момент имеет 0 участников или барьер получает сигналы от большего числа потоков, чем зарегистрировано участников.</exception>
		/// <exception cref="T:System.Threading.BarrierPostPhaseException">Если создается исключение из действия следующего этапа барьера после того, как все участвующие потоки вызвали SignalAndWait, исключение будет вставлено в BarrierPostPhaseException и создано для всех участвующих потоков.</exception>
		// Token: 0x06000A35 RID: 2613 RVA: 0x0002C894 File Offset: 0x0002AA94
		public bool SignalAndWait(int millisecondsTimeout)
		{
			return this.SignalAndWait(millisecondsTimeout, default(CancellationToken));
		}

		/// <summary>Сообщает, что участник достиг барьера и ожидает достижения барьера всеми другими участниками, используя 32-разрядное знаковое целое число для измерения времени ожидания. Кроме того, метод контролирует токен отмены.</summary>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или <see cref="F:System.Threading.Timeout.Infinite" /> (-1) для неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Значение true, если все участники достигли барьера за указанное время; в противном случае — значение false</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод был вызван из действия после этапа, барьер в настоящий момент имеет 0 участников или барьер получает сигналы от большего числа потоков, чем зарегистрировано участников.</exception>
		// Token: 0x06000A36 RID: 2614 RVA: 0x0002C8B4 File Offset: 0x0002AAB4
		public bool SignalAndWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.ThrowIfDisposed();
			cancellationToken.ThrowIfCancellationRequested();
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, SR.GetString("The specified timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			if (this.m_actionCallerID != 0 && Thread.CurrentThread.ManagedThreadId == this.m_actionCallerID)
			{
				throw new InvalidOperationException(SR.GetString("This method may not be called from within the postPhaseAction."));
			}
			SpinWait spinWait = default(SpinWait);
			bool flag;
			long currentPhaseNumber;
			for (;;)
			{
				int currentTotalCount = this.m_currentTotalCount;
				int num;
				int num2;
				this.GetCurrentTotal(currentTotalCount, out num, out num2, out flag);
				currentPhaseNumber = this.CurrentPhaseNumber;
				if (num2 == 0)
				{
					break;
				}
				if (num == 0 && flag != (this.CurrentPhaseNumber % 2L == 0L))
				{
					goto Block_6;
				}
				if (num + 1 == num2)
				{
					if (this.SetCurrentTotal(currentTotalCount, 0, num2, !flag))
					{
						goto Block_8;
					}
				}
				else if (this.SetCurrentTotal(currentTotalCount, num + 1, num2, flag))
				{
					goto IL_EA;
				}
				spinWait.SpinOnce();
			}
			throw new InvalidOperationException(SR.GetString("The barrier has no registered participants."));
			Block_6:
			throw new InvalidOperationException(SR.GetString("The number of threads using the barrier exceeded the total number of registered participants."));
			Block_8:
			this.FinishPhase(flag);
			return true;
			IL_EA:
			ManualResetEventSlim currentPhaseEvent = flag ? this.m_evenEvent : this.m_oddEvent;
			bool flag2 = false;
			bool flag3 = false;
			try
			{
				flag3 = this.DiscontinuousWait(currentPhaseEvent, millisecondsTimeout, cancellationToken, currentPhaseNumber);
			}
			catch (OperationCanceledException)
			{
				flag2 = true;
			}
			catch (ObjectDisposedException)
			{
				if (currentPhaseNumber >= this.CurrentPhaseNumber)
				{
					throw;
				}
				flag3 = true;
			}
			if (!flag3)
			{
				spinWait.Reset();
				for (;;)
				{
					int currentTotalCount = this.m_currentTotalCount;
					int num;
					int num2;
					bool flag4;
					this.GetCurrentTotal(currentTotalCount, out num, out num2, out flag4);
					if (currentPhaseNumber < this.CurrentPhaseNumber || flag != flag4)
					{
						break;
					}
					if (this.SetCurrentTotal(currentTotalCount, num - 1, num2, flag))
					{
						goto Block_13;
					}
					spinWait.SpinOnce();
				}
				this.WaitCurrentPhase(currentPhaseEvent, currentPhaseNumber);
				goto IL_197;
				Block_13:
				if (flag2)
				{
					throw new OperationCanceledException(SR.GetString("The operation was canceled."), cancellationToken);
				}
				return false;
			}
			IL_197:
			if (this.m_exception != null)
			{
				throw new BarrierPostPhaseException(this.m_exception);
			}
			return true;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		[SecuritySafeCritical]
		private void FinishPhase(bool observedSense)
		{
			if (this.m_postPhaseAction != null)
			{
				try
				{
					this.m_actionCallerID = Thread.CurrentThread.ManagedThreadId;
					if (this.m_ownerThreadContext != null)
					{
						ExecutionContext ownerThreadContext = this.m_ownerThreadContext;
						this.m_ownerThreadContext = this.m_ownerThreadContext.CreateCopy();
						ContextCallback contextCallback = Barrier.s_invokePostPhaseAction;
						if (contextCallback == null)
						{
							contextCallback = (Barrier.s_invokePostPhaseAction = new ContextCallback(Barrier.InvokePostPhaseAction));
						}
						ExecutionContext.Run(ownerThreadContext, contextCallback, this);
						ownerThreadContext.Dispose();
					}
					else
					{
						this.m_postPhaseAction(this);
					}
					this.m_exception = null;
					return;
				}
				catch (Exception exception)
				{
					this.m_exception = exception;
					return;
				}
				finally
				{
					this.m_actionCallerID = 0;
					this.SetResetEvents(observedSense);
					if (this.m_exception != null)
					{
						throw new BarrierPostPhaseException(this.m_exception);
					}
				}
			}
			this.SetResetEvents(observedSense);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002CB64 File Offset: 0x0002AD64
		[SecurityCritical]
		private static void InvokePostPhaseAction(object obj)
		{
			Barrier barrier = (Barrier)obj;
			barrier.m_postPhaseAction(barrier);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002CB84 File Offset: 0x0002AD84
		private void SetResetEvents(bool observedSense)
		{
			this.CurrentPhaseNumber += 1L;
			if (observedSense)
			{
				this.m_oddEvent.Reset();
				this.m_evenEvent.Set();
				return;
			}
			this.m_evenEvent.Reset();
			this.m_oddEvent.Set();
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002CBD0 File Offset: 0x0002ADD0
		private void WaitCurrentPhase(ManualResetEventSlim currentPhaseEvent, long observedPhase)
		{
			SpinWait spinWait = default(SpinWait);
			while (!currentPhaseEvent.IsSet && this.CurrentPhaseNumber - observedPhase <= 1L)
			{
				spinWait.SpinOnce();
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0002CC04 File Offset: 0x0002AE04
		private bool DiscontinuousWait(ManualResetEventSlim currentPhaseEvent, int totalTimeout, CancellationToken token, long observedPhase)
		{
			int num = 100;
			int num2 = 10000;
			while (observedPhase == this.CurrentPhaseNumber)
			{
				int num3 = (totalTimeout == -1) ? num : Math.Min(num, totalTimeout);
				if (currentPhaseEvent.Wait(num3, token))
				{
					return true;
				}
				if (totalTimeout != -1)
				{
					totalTimeout -= num3;
					if (totalTimeout <= 0)
					{
						return false;
					}
				}
				num = ((num >= num2) ? num2 : Math.Min(num << 1, num2));
			}
			this.WaitCurrentPhase(currentPhaseEvent, observedPhase);
			return true;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Threading.Barrier" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Метод был вызван из действия после этапа.</exception>
		// Token: 0x06000A3C RID: 2620 RVA: 0x0002CC6B File Offset: 0x0002AE6B
		public void Dispose()
		{
			if (this.m_actionCallerID != 0 && Thread.CurrentThread.ManagedThreadId == this.m_actionCallerID)
			{
				throw new InvalidOperationException(SR.GetString("This method may not be called from within the postPhaseAction."));
			}
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые журналом <see cref="T:System.Threading.Barrier" />, и при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение true, чтобы освободить управляемые и неуправляемые ресурсы; значение false, чтобы освободить только неуправляемые ресурсы.</param>
		// Token: 0x06000A3D RID: 2621 RVA: 0x0002CCA4 File Offset: 0x0002AEA4
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				if (disposing)
				{
					this.m_oddEvent.Dispose();
					this.m_evenEvent.Dispose();
					if (this.m_ownerThreadContext != null)
					{
						this.m_ownerThreadContext.Dispose();
						this.m_ownerThreadContext = null;
					}
				}
				this.m_disposed = true;
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002CCF3 File Offset: 0x0002AEF3
		private void ThrowIfDisposed()
		{
			if (this.m_disposed)
			{
				throw new ObjectDisposedException("Barrier", SR.GetString("The barrier has been disposed."));
			}
		}

		// Token: 0x040006C8 RID: 1736
		private volatile int m_currentTotalCount;

		// Token: 0x040006C9 RID: 1737
		private const int CURRENT_MASK = 2147418112;

		// Token: 0x040006CA RID: 1738
		private const int TOTAL_MASK = 32767;

		// Token: 0x040006CB RID: 1739
		private const int SENSE_MASK = -2147483648;

		// Token: 0x040006CC RID: 1740
		private const int MAX_PARTICIPANTS = 32767;

		// Token: 0x040006CD RID: 1741
		private long m_currentPhase;

		// Token: 0x040006CE RID: 1742
		private bool m_disposed;

		// Token: 0x040006CF RID: 1743
		private ManualResetEventSlim m_oddEvent;

		// Token: 0x040006D0 RID: 1744
		private ManualResetEventSlim m_evenEvent;

		// Token: 0x040006D1 RID: 1745
		private ExecutionContext m_ownerThreadContext;

		// Token: 0x040006D2 RID: 1746
		[SecurityCritical]
		private static ContextCallback s_invokePostPhaseAction;

		// Token: 0x040006D3 RID: 1747
		private Action<Barrier> m_postPhaseAction;

		// Token: 0x040006D4 RID: 1748
		private Exception m_exception;

		// Token: 0x040006D5 RID: 1749
		private int m_actionCallerID;
	}
}
