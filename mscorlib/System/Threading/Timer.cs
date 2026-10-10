using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Threading
{
	/// <summary>Предоставляет механизм для выполнения метода в потоке пула с заданными интервалами. Этот класс не наследуется.</summary>
	// Token: 0x020002F9 RID: 761
	[ComVisible(true)]
	public sealed class Timer : MarshalByRefObject, IDisposable, IAsyncDisposable
	{
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x00077BF7 File Offset: 0x00075DF7
		private static Timer.Scheduler scheduler
		{
			get
			{
				return Timer.Scheduler.Instance;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="Timer" />, используя указанное 32-разрядное знаковое целое число для задания временного интервала.</summary>
		/// <param name="callback">Делегат <see cref="T:System.Threading.TimerCallback" />, представляющий выполняемый метод.</param>
		/// <param name="state">Объект, содержащий информацию, используемую методом ответного вызова или значение <see langword="null" />.</param>
		/// <param name="dueTime">Количество времени до начала использования параметра <paramref name="callback" />, в миллисекундах. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для того, чтобы не допустить запуск таймера. Задайте значение ноль (0) для немедленного запуска таймера.</param>
		/// <param name="period">Временной интервал между вызовами параметра <paramref name="callback" />, в миллисекундах. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для отключения периодической сигнализации.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> отрицательно, и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="callback" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002128 RID: 8488 RVA: 0x00077BFE File Offset: 0x00075DFE
		public Timer(TimerCallback callback, object state, int dueTime, int period)
		{
			this.Init(callback, state, (long)dueTime, (long)period);
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="Timer" />, используя указанное 64-разрядное знаковое целое число для измерения временных интервалов.</summary>
		/// <param name="callback">Делегат <see cref="T:System.Threading.TimerCallback" />, представляющий выполняемый метод.</param>
		/// <param name="state">Объект, содержащий информацию, используемую методом ответного вызова или значение <see langword="null" />.</param>
		/// <param name="dueTime">Количество времени до начала использования параметра <paramref name="callback" />, в миллисекундах. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для того, чтобы не допустить запуск таймера. Задайте значение ноль (0) для немедленного запуска таймера.</param>
		/// <param name="period">Временной интервал между вызовами параметра <paramref name="callback" />, в миллисекундах. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для отключения периодической сигнализации.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> отрицательно, и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> больше 4294967294.</exception>
		// Token: 0x06002129 RID: 8489 RVA: 0x00077C13 File Offset: 0x00075E13
		public Timer(TimerCallback callback, object state, long dueTime, long period)
		{
			this.Init(callback, state, dueTime, period);
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="Timer" />, используя значения объекта <see cref="T:System.TimeSpan" /> для измерения временных интервалов.</summary>
		/// <param name="callback">Делегат, представляющий выполняемый метод.</param>
		/// <param name="state">Объект, содержащий информацию, используемую методом ответного вызова или значение <see langword="null" />.</param>
		/// <param name="dueTime">Количество времени, которое следует подождать до того, как параметр <paramref name="callback" /> вызовет свои методы. Следует задать минус одну (-1) миллисекунду для того, чтобы не допустить запуск таймера. Задайте значение ноль (0) для немедленного запуска таймера.</param>
		/// <param name="period">Временной интервал между вызовами методов, на которые ссылается параметр <paramref name="callback" />. Следует задать минус одну (-1) миллисекунду для отключения периодической сигнализации.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число миллисекунд, заданное значением поля <paramref name="dueTime" /> или <paramref name="period" />, отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" />, или больше, чем <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="callback" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600212A RID: 8490 RVA: 0x00077C26 File Offset: 0x00075E26
		public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
		{
			this.Init(callback, state, (long)dueTime.TotalMilliseconds, (long)period.TotalMilliseconds);
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="Timer" />, используя указанное 32-разрядное незнаковое целое число для измерения временных интервалов.</summary>
		/// <param name="callback">Делегат, представляющий выполняемый метод.</param>
		/// <param name="state">Объект, содержащий информацию, используемую методом ответного вызова или значение <see langword="null" />.</param>
		/// <param name="dueTime">Количество времени до начала использования параметра <paramref name="callback" />, в миллисекундах. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для того, чтобы не допустить запуск таймера. Задайте значение ноль (0) для немедленного запуска таймера.</param>
		/// <param name="period">Временной интервал между вызовами параметра <paramref name="callback" />, в миллисекундах. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для отключения периодической сигнализации.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> отрицательно, и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="callback" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600212B RID: 8491 RVA: 0x00077C48 File Offset: 0x00075E48
		[CLSCompliant(false)]
		public Timer(TimerCallback callback, object state, uint dueTime, uint period)
		{
			long dueTime2 = (long)((dueTime == uint.MaxValue) ? ulong.MaxValue : ((ulong)dueTime));
			long period2 = (long)((period == uint.MaxValue) ? ulong.MaxValue : ((ulong)period));
			this.Init(callback, state, dueTime2, period2);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Timer" /> с бесконечным периодом и бесконечным временем действия, используя созданный объект <see cref="T:System.Threading.Timer" /> в качестве объекта состояния.</summary>
		/// <param name="callback">Делегат <see cref="T:System.Threading.TimerCallback" />, представляющий выполняемый метод.</param>
		// Token: 0x0600212C RID: 8492 RVA: 0x00077C7D File Offset: 0x00075E7D
		public Timer(TimerCallback callback)
		{
			this.Init(callback, this, -1L, -1L);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00077C91 File Offset: 0x00075E91
		private void Init(TimerCallback callback, object state, long dueTime, long period)
		{
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			this.callback = callback;
			this.state = state;
			this.is_dead = false;
			this.is_added = false;
			this.Change(dueTime, period, true);
		}

		/// <summary>Меняет время запуска и интервал между вызовами метода таймера, используя 32-разрядные знаковые целые числа для измерения временных интервалов.</summary>
		/// <param name="dueTime">Количество времени, в миллисекундах, которое должно пройти до вызова метода ответного вызова при создании объекта <see cref="T:System.Threading.Timer" />. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для того, чтобы не допустить повторный запуск таймера. Задайте значение ноль (0) для немедленного перезапуска таймера.</param>
		/// <param name="period">Временной интервал в миллисекундах между вызовами метода обратного вызова, определенный в конструкторе объекта <see cref="T:System.Threading.Timer" />. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для отключения периодической сигнализации.</param>
		/// <returns>Значение <see langword="true" />, если таймер успешно обновлен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Timer" /> уже был удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> отрицательно, и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x0600212E RID: 8494 RVA: 0x00077CC8 File Offset: 0x00075EC8
		public bool Change(int dueTime, int period)
		{
			return this.Change((long)dueTime, (long)period, false);
		}

		/// <summary>Меняет время запуска и интервал межу вызовами метода таймера, используя значения объекта <see cref="T:System.TimeSpan" /> для измерения временных интервалов.</summary>
		/// <param name="dueTime">Объект <see cref="T:System.TimeSpan" />, представляющий количество времени, в миллисекундах, которое должно пройти до вызова метода ответного вызова при создании объекта <see cref="T:System.Threading.Timer" />. Следует задать минус одну (-1) миллисекунду для того, чтобы не допустить повторный запуск таймера. Задайте значение ноль (0) для немедленного перезапуска таймера.</param>
		/// <param name="period">Временной интервал между вызовами метода обратного вызова, определенный в конструкторе объекта <see cref="T:System.Threading.Timer" />. Следует задать минус одну (-1) миллисекунду для отключения периодической сигнализации.</param>
		/// <returns>Значение <see langword="true" />, если таймер успешно обновлен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Timer" /> уже был удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> в миллисекундах меньше -1.</exception>
		/// <exception cref="T:System.NotSupportedException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> в миллисекундах больше 4294967294.</exception>
		// Token: 0x0600212F RID: 8495 RVA: 0x00077CD5 File Offset: 0x00075ED5
		public bool Change(TimeSpan dueTime, TimeSpan period)
		{
			return this.Change((long)dueTime.TotalMilliseconds, (long)period.TotalMilliseconds, false);
		}

		/// <summary>Меняет время запуска и интервал между вызовами метода таймера, используя 32-разрядные целые числа без знака для измерения временных интервалов.</summary>
		/// <param name="dueTime">Количество времени, в миллисекундах, которое должно пройти до вызова метода ответного вызова при создании объекта <see cref="T:System.Threading.Timer" />. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для того, чтобы не допустить повторный запуск таймера. Задайте значение ноль (0) для немедленного перезапуска таймера.</param>
		/// <param name="period">Временной интервал в миллисекундах между вызовами метода обратного вызова, определенный в конструкторе объекта <see cref="T:System.Threading.Timer" />. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для отключения периодической сигнализации.</param>
		/// <returns>Значение <see langword="true" />, если таймер успешно обновлен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Timer" /> уже был удален.</exception>
		// Token: 0x06002130 RID: 8496 RVA: 0x00077CF0 File Offset: 0x00075EF0
		[CLSCompliant(false)]
		public bool Change(uint dueTime, uint period)
		{
			long dueTime2 = (long)((dueTime == uint.MaxValue) ? ulong.MaxValue : ((ulong)dueTime));
			long period2 = (long)((period == uint.MaxValue) ? ulong.MaxValue : ((ulong)period));
			return this.Change(dueTime2, period2, false);
		}

		/// <summary>Освобождает все ресурсы, используемые экземпляром класса <see cref="T:System.Threading.Timer" />.</summary>
		// Token: 0x06002131 RID: 8497 RVA: 0x00077D1C File Offset: 0x00075F1C
		public void Dispose()
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			Timer.scheduler.Remove(this);
		}

		/// <summary>Меняет время запуска и интервал между вызовами метода таймера, используя 64-разрядные знаковые целые числа для измерения временных интервалов.</summary>
		/// <param name="dueTime">Количество времени, в миллисекундах, которое должно пройти до вызова метода ответного вызова при создании объекта <see cref="T:System.Threading.Timer" />. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для того, чтобы не допустить повторный запуск таймера. Задайте значение ноль (0) для немедленного перезапуска таймера.</param>
		/// <param name="period">Временной интервал в миллисекундах между вызовами метода обратного вызова, определенный в конструкторе объекта <see cref="T:System.Threading.Timer" />. Следует задать поле <see cref="F:System.Threading.Timeout.Infinite" /> для отключения периодической сигнализации.</param>
		/// <returns>Значение <see langword="true" />, если таймер успешно обновлен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Timer" /> уже был удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> меньше -1.</exception>
		/// <exception cref="T:System.NotSupportedException">Значение параметра <paramref name="dueTime" /> или <paramref name="period" /> больше 4294967294.</exception>
		// Token: 0x06002132 RID: 8498 RVA: 0x00077D39 File Offset: 0x00075F39
		public bool Change(long dueTime, long period)
		{
			return this.Change(dueTime, period, false);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00077D44 File Offset: 0x00075F44
		private bool Change(long dueTime, long period, bool first)
		{
			if (dueTime > (long)((ulong)-2))
			{
				throw new ArgumentOutOfRangeException("dueTime", "Due time too large");
			}
			if (period > (long)((ulong)-2))
			{
				throw new ArgumentOutOfRangeException("period", "Period too large");
			}
			if (dueTime < -1L)
			{
				throw new ArgumentOutOfRangeException("dueTime");
			}
			if (period < -1L)
			{
				throw new ArgumentOutOfRangeException("period");
			}
			if (this.disposed)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a disposed object."));
			}
			this.due_time_ms = dueTime;
			this.period_ms = period;
			long new_next_run;
			if (dueTime == 0L)
			{
				new_next_run = 0L;
			}
			else if (dueTime < 0L)
			{
				new_next_run = long.MaxValue;
				if (first)
				{
					this.next_run = new_next_run;
					return true;
				}
			}
			else
			{
				new_next_run = dueTime * 10000L + Timer.GetTimeMonotonic();
			}
			Timer.scheduler.Change(this, new_next_run);
			return true;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Threading.Timer" /> и передает сигнал, когда таймер удаляется.</summary>
		/// <param name="notifyObject">Объект <see cref="T:System.Threading.WaitHandle" />, который должен получить сигнал при удалении объекта <see langword="Timer" />.</param>
		/// <returns>
		///   <see langword="true" />, если функция выполнилась успешно; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="notifyObject" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002134 RID: 8500 RVA: 0x00077E03 File Offset: 0x00076003
		public bool Dispose(WaitHandle notifyObject)
		{
			if (notifyObject == null)
			{
				throw new ArgumentNullException("notifyObject");
			}
			this.Dispose();
			NativeEventCalls.SetEvent(notifyObject.SafeWaitHandle);
			return true;
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00077E26 File Offset: 0x00076026
		public ValueTask DisposeAsync()
		{
			this.Dispose();
			return new ValueTask(Task.FromResult<object>(null));
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00004BF9 File Offset: 0x00002DF9
		internal void KeepRootedWhileScheduled()
		{
		}

		// Token: 0x06002137 RID: 8503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long GetTimeMonotonic();

		// Token: 0x04001BAE RID: 7086
		private TimerCallback callback;

		// Token: 0x04001BAF RID: 7087
		private object state;

		// Token: 0x04001BB0 RID: 7088
		private long due_time_ms;

		// Token: 0x04001BB1 RID: 7089
		private long period_ms;

		// Token: 0x04001BB2 RID: 7090
		private long next_run;

		// Token: 0x04001BB3 RID: 7091
		private bool disposed;

		// Token: 0x04001BB4 RID: 7092
		private bool is_dead;

		// Token: 0x04001BB5 RID: 7093
		private bool is_added;

		// Token: 0x04001BB6 RID: 7094
		private const long MaxValue = 4294967294L;

		// Token: 0x020002FA RID: 762
		private struct TimerComparer : IComparer, IComparer<Timer>
		{
			// Token: 0x06002138 RID: 8504 RVA: 0x00077E3C File Offset: 0x0007603C
			int IComparer.Compare(object x, object y)
			{
				if (x == y)
				{
					return 0;
				}
				Timer timer = x as Timer;
				if (timer == null)
				{
					return -1;
				}
				Timer timer2 = y as Timer;
				if (timer2 == null)
				{
					return 1;
				}
				return this.Compare(timer, timer2);
			}

			// Token: 0x06002139 RID: 8505 RVA: 0x00077E6F File Offset: 0x0007606F
			public int Compare(Timer tx, Timer ty)
			{
				return Math.Sign(tx.next_run - ty.next_run);
			}
		}

		// Token: 0x020002FB RID: 763
		private sealed class Scheduler
		{
			// Token: 0x0600213A RID: 8506 RVA: 0x00077E83 File Offset: 0x00076083
			private void InitScheduler()
			{
				this.changed = new ManualResetEvent(false);
				new Thread(new ThreadStart(this.SchedulerThread))
				{
					IsBackground = true
				}.Start();
			}

			// Token: 0x0600213B RID: 8507 RVA: 0x00077EAE File Offset: 0x000760AE
			private void WakeupScheduler()
			{
				this.changed.Set();
			}

			// Token: 0x0600213C RID: 8508 RVA: 0x00077EBC File Offset: 0x000760BC
			private void SchedulerThread()
			{
				Thread.CurrentThread.Name = "Timer-Scheduler";
				for (;;)
				{
					int millisecondsTimeout = -1;
					lock (this)
					{
						this.changed.Reset();
						millisecondsTimeout = this.RunSchedulerLoop();
					}
					this.changed.WaitOne(millisecondsTimeout);
				}
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x0600213D RID: 8509 RVA: 0x00077F24 File Offset: 0x00076124
			public static Timer.Scheduler Instance
			{
				get
				{
					return Timer.Scheduler.instance;
				}
			}

			// Token: 0x0600213E RID: 8510 RVA: 0x00077F2B File Offset: 0x0007612B
			private Scheduler()
			{
				this.list = new List<Timer>(1024);
				this.InitScheduler();
			}

			// Token: 0x0600213F RID: 8511 RVA: 0x00077F64 File Offset: 0x00076164
			public void Remove(Timer timer)
			{
				lock (this)
				{
					this.InternalRemove(timer);
				}
			}

			// Token: 0x06002140 RID: 8512 RVA: 0x00077FA0 File Offset: 0x000761A0
			public void Change(Timer timer, long new_next_run)
			{
				if (timer.is_dead)
				{
					timer.is_dead = false;
				}
				bool flag = false;
				lock (this)
				{
					this.needReSort = true;
					if (!timer.is_added)
					{
						timer.next_run = new_next_run;
						this.Add(timer);
						flag = (this.current_next_run > new_next_run);
					}
					else
					{
						if (new_next_run == 9223372036854775807L)
						{
							timer.next_run = new_next_run;
							this.InternalRemove(timer);
							return;
						}
						if (!timer.disposed)
						{
							timer.next_run = new_next_run;
							flag = (this.current_next_run > new_next_run);
						}
					}
				}
				if (flag)
				{
					this.WakeupScheduler();
				}
			}

			// Token: 0x06002141 RID: 8513 RVA: 0x00078050 File Offset: 0x00076250
			private void Add(Timer timer)
			{
				timer.is_added = true;
				this.needReSort = true;
				this.list.Add(timer);
				if (this.list.Count == 1)
				{
					this.WakeupScheduler();
				}
			}

			// Token: 0x06002142 RID: 8514 RVA: 0x00078082 File Offset: 0x00076282
			private void InternalRemove(Timer timer)
			{
				timer.is_dead = true;
				this.needReSort = true;
			}

			// Token: 0x06002143 RID: 8515 RVA: 0x00078094 File Offset: 0x00076294
			private static void TimerCB(object o)
			{
				Timer timer = (Timer)o;
				timer.callback(timer.state);
			}

			// Token: 0x06002144 RID: 8516 RVA: 0x000780BC File Offset: 0x000762BC
			private void FireTimer(Timer timer)
			{
				long period_ms = timer.period_ms;
				long due_time_ms = timer.due_time_ms;
				if (period_ms == -1L || ((period_ms == 0L || period_ms == -1L) && due_time_ms != -1L))
				{
					timer.next_run = long.MaxValue;
					timer.is_dead = true;
				}
				else
				{
					timer.next_run = Timer.GetTimeMonotonic() + 10000L * timer.period_ms;
					timer.is_dead = false;
				}
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(Timer.Scheduler.TimerCB), timer);
			}

			// Token: 0x06002145 RID: 8517 RVA: 0x00078140 File Offset: 0x00076340
			private int RunSchedulerLoop()
			{
				long timeMonotonic = Timer.GetTimeMonotonic();
				Timer.TimerComparer timerComparer = default(Timer.TimerComparer);
				if (this.needReSort)
				{
					this.list.Sort(new Comparison<Timer>(timerComparer.Compare));
					this.needReSort = false;
				}
				long num = long.MaxValue;
				for (int i = 0; i < this.list.Count; i++)
				{
					Timer timer = this.list[i];
					if (!timer.is_dead)
					{
						if (timer.next_run <= timeMonotonic)
						{
							this.FireTimer(timer);
						}
						num = Math.Min(num, timer.next_run);
						if (timer.next_run > timeMonotonic && timer.next_run < 9223372036854775807L)
						{
							timer.is_dead = false;
						}
					}
				}
				for (int i = 0; i < this.list.Count; i++)
				{
					Timer timer2 = this.list[i];
					if (timer2.is_dead)
					{
						timer2.is_added = false;
						this.needReSort = true;
						this.list[i] = this.list[this.list.Count - 1];
						i--;
						this.list.RemoveAt(this.list.Count - 1);
						if (this.list.Count == 0)
						{
							break;
						}
					}
				}
				if (this.needReSort)
				{
					this.list.Sort(new Comparison<Timer>(timerComparer.Compare));
					this.needReSort = false;
				}
				int num2 = -1;
				this.current_next_run = num;
				if (num != 9223372036854775807L)
				{
					long num3 = (num - Timer.GetTimeMonotonic()) / 10000L;
					if (num3 > 2147483647L)
					{
						num2 = 2147483646;
					}
					else
					{
						num2 = (int)num3;
						if (num2 < 0)
						{
							num2 = 0;
						}
					}
				}
				return num2;
			}

			// Token: 0x04001BB7 RID: 7095
			private static readonly Timer.Scheduler instance = new Timer.Scheduler();

			// Token: 0x04001BB8 RID: 7096
			private volatile bool needReSort = true;

			// Token: 0x04001BB9 RID: 7097
			private List<Timer> list;

			// Token: 0x04001BBA RID: 7098
			private long current_next_run = long.MaxValue;

			// Token: 0x04001BBB RID: 7099
			private ManualResetEvent changed;
		}
	}
}
