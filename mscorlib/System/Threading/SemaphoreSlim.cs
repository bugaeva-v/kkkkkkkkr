using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace System.Threading
{
	/// <summary>Представляет упрощенную альтернативу семафору <see cref="T:System.Threading.Semaphore" />, ограничивающему количество потоков, которые могут параллельно обращаться к ресурсу или пулу ресурсов.</summary>
	// Token: 0x020002BB RID: 699
	[ComVisible(false)]
	[DebuggerDisplay("Current Count = {m_currentCount}")]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public class SemaphoreSlim : IDisposable
	{
		/// <summary>Возвращает количество оставшихся потоков, которым разрешено входить в объект <see cref="T:System.Threading.SemaphoreSlim" />.</summary>
		/// <returns>Количество оставшихся потоков, которым разрешено входить в семафор.</returns>
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x00070DA5 File Offset: 0x0006EFA5
		public int CurrentCount
		{
			get
			{
				return this.m_currentCount;
			}
		}

		/// <summary>Возвращает дескриптор <see cref="T:System.Threading.WaitHandle" />, который можно использовать для ожидания семафора.</summary>
		/// <returns>Дескриптор <see cref="T:System.Threading.WaitHandle" />, который можно использовать для ожидания семафора.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.SemaphoreSlim" /> удален.</exception>
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00070DB0 File Offset: 0x0006EFB0
		public WaitHandle AvailableWaitHandle
		{
			get
			{
				this.CheckDispose();
				if (this.m_waitHandle != null)
				{
					return this.m_waitHandle;
				}
				object lockObj = this.m_lockObj;
				lock (lockObj)
				{
					if (this.m_waitHandle == null)
					{
						this.m_waitHandle = new ManualResetEvent(this.m_currentCount != 0);
					}
				}
				return this.m_waitHandle;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SemaphoreSlim" />, указывая первоначальное число запросов, которые могут выполняться одновременно.</summary>
		/// <param name="initialCount">Начальное количество запросов для семафора, которое может быть обеспечено одновременно.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="initialCount" /> меньше 0.</exception>
		// Token: 0x06001E7C RID: 7804 RVA: 0x00070E30 File Offset: 0x0006F030
		public SemaphoreSlim(int initialCount) : this(initialCount, int.MaxValue)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SemaphoreSlim" />, указывая изначальное и максимальное число запросов, которые могут выполняться одновременно.</summary>
		/// <param name="initialCount">Начальное количество запросов для семафора, которое может быть обеспечено одновременно.</param>
		/// <param name="maxCount">Максимальное количество запросов семафора, которое может быть обеспеченно одновременно.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="initialCount" /> меньше 0 или <paramref name="initialCount" /> больше, чем <paramref name="maxCount" />, или <paramref name="maxCount" /> меньше или равен 0.</exception>
		// Token: 0x06001E7D RID: 7805 RVA: 0x00070E40 File Offset: 0x0006F040
		public SemaphoreSlim(int initialCount, int maxCount)
		{
			if (initialCount < 0 || initialCount > maxCount)
			{
				throw new ArgumentOutOfRangeException("initialCount", initialCount, SemaphoreSlim.GetResourceString("The initialCount argument must be non-negative and less than or equal to the maximumCount."));
			}
			if (maxCount <= 0)
			{
				throw new ArgumentOutOfRangeException("maxCount", maxCount, SemaphoreSlim.GetResourceString("The maximumCount argument must be a positive number. If a maximum is not required, use the constructor without a maxCount parameter."));
			}
			this.m_maxCount = maxCount;
			this.m_lockObj = new object();
			this.m_currentCount = initialCount;
		}

		/// <summary>Блокирует текущий поток, пока он не сможет войти в <see cref="T:System.Threading.SemaphoreSlim" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		// Token: 0x06001E7E RID: 7806 RVA: 0x00070EB0 File Offset: 0x0006F0B0
		public void Wait()
		{
			this.Wait(-1, default(CancellationToken));
		}

		/// <summary>Блокирует текущий поток до тех пор, пока он не сможет войти в <see cref="T:System.Threading.SemaphoreSlim" />, и контролирует токен <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		// Token: 0x06001E7F RID: 7807 RVA: 0x00070ECE File Offset: 0x0006F0CE
		public void Wait(CancellationToken cancellationToken)
		{
			this.Wait(-1, cancellationToken);
		}

		/// <summary>Блокирует текущий поток до тех пор, пока он не сможет войти в <see cref="T:System.Threading.SemaphoreSlim" />, используя значение <see cref="T:System.TimeSpan" /> для определения времени ожидания.</summary>
		/// <param name="timeout">
		///   <see cref="T:System.TimeSpan" />, представляющий количество миллисекунд для ожидания, <see cref="T:System.TimeSpan" />, представляющий –1 миллисекунду для неопределенного ожидания, или <see cref="T:System.TimeSpan" />, представляющий 0 миллисекунд, чтобы протестировать дескриптор ожидания и выполнить немедленный возврат.</param>
		/// <returns>Значение <see langword="true" />, если текущий поток успешно передан в объект <see cref="T:System.Threading.SemaphoreSlim" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от значения –1, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Экземпляр semaphoreSlim был уничтожен <paramref name="." /></exception>
		// Token: 0x06001E80 RID: 7808 RVA: 0x00070EDC File Offset: 0x0006F0DC
		public bool Wait(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SemaphoreSlim.GetResourceString("The timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			return this.Wait((int)timeout.TotalMilliseconds, default(CancellationToken));
		}

		/// <summary>Блокирует текущий поток до тех пор, пока он не сможет войти в <see cref="T:System.Threading.SemaphoreSlim" />, используя значение <see cref="T:System.TimeSpan" />, которое определяет время ожидания, и контролирует токен <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="timeout">
		///   <see cref="T:System.TimeSpan" />, представляющий количество миллисекунд для ожидания, <see cref="T:System.TimeSpan" />, представляющий –1 миллисекунду для неопределенного ожидания, или <see cref="T:System.TimeSpan" />, представляющий 0 миллисекунд, чтобы протестировать дескриптор ожидания и выполнить немедленный возврат.</param>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Значение <see langword="true" />, если текущий поток успешно передан в объект <see cref="T:System.Threading.SemaphoreSlim" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от значения –1, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Экземпляр semaphoreSlim был уничтожен <paramref name="." /><paramref name="-or-" />  
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		// Token: 0x06001E81 RID: 7809 RVA: 0x00070F34 File Offset: 0x0006F134
		public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SemaphoreSlim.GetResourceString("The timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			return this.Wait((int)timeout.TotalMilliseconds, cancellationToken);
		}

		/// <summary>Блокирует текущий поток до тех пор, пока он не сможет войти в <see cref="T:System.Threading.SemaphoreSlim" />, используя 32-разрядное целое число со знаком, которое определяет время ожидания.</summary>
		/// <param name="millisecondsTimeout">Количество миллисекунд ожидания, <see cref="F:System.Threading.Timeout.Infinite" />(–1) для неограниченного времени ожидания, или нуль, чтобы проверить состояние дескриптора ожидания и выполнить немедленный возврат.</param>
		/// <returns>Значение <see langword="true" />, если текущий поток успешно передан в объект <see cref="T:System.Threading.SemaphoreSlim" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от значения –1, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.SemaphoreSlim" /> удален.</exception>
		// Token: 0x06001E82 RID: 7810 RVA: 0x00070F84 File Offset: 0x0006F184
		public bool Wait(int millisecondsTimeout)
		{
			return this.Wait(millisecondsTimeout, default(CancellationToken));
		}

		/// <summary>Блокирует текущий поток до тех пор, пока он не сможет войти в <see cref="T:System.Threading.SemaphoreSlim" />, используя 32-разрядное целое число со знаком, которое определяет время ожидания, и контролирует токен <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="millisecondsTimeout">Количество миллисекунд ожидания, <see cref="F:System.Threading.Timeout.Infinite" />(–1) для неограниченного времени ожидания, или нуль, чтобы проверить состояние дескриптора ожидания и выполнить немедленный возврат.</param>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Значение <see langword="true" />, если текущий поток успешно передан в объект <see cref="T:System.Threading.SemaphoreSlim" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от значения –1, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Экземпляр <see cref="T:System.Threading.SemaphoreSlim" /> был удален, или объект <see cref="T:System.Threading.CancellationTokenSource" />, создавший<paramref name="cancellationToken" />, был удален.</exception>
		// Token: 0x06001E83 RID: 7811 RVA: 0x00070FA4 File Offset: 0x0006F1A4
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.CheckDispose();
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("totalMilliSeconds", millisecondsTimeout, SemaphoreSlim.GetResourceString("The timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			cancellationToken.ThrowIfCancellationRequested();
			if (millisecondsTimeout == 0 && this.m_currentCount == 0)
			{
				return false;
			}
			uint startTime = 0U;
			if (millisecondsTimeout != -1 && millisecondsTimeout > 0)
			{
				startTime = TimeoutHelper.GetTime();
			}
			bool result = false;
			Task<bool> task = null;
			bool flag = false;
			CancellationTokenRegistration cancellationTokenRegistration = cancellationToken.InternalRegisterWithoutEC(SemaphoreSlim.s_cancellationTokenCanceledEventHandler, this);
			try
			{
				SpinWait spinWait = default(SpinWait);
				while (this.m_currentCount == 0 && !spinWait.NextSpinWillYield)
				{
					spinWait.SpinOnce();
				}
				try
				{
				}
				finally
				{
					Monitor.Enter(this.m_lockObj, ref flag);
					if (flag)
					{
						this.m_waitCount++;
					}
				}
				if (this.m_asyncHead != null)
				{
					task = this.WaitAsync(millisecondsTimeout, cancellationToken);
				}
				else
				{
					OperationCanceledException ex = null;
					if (this.m_currentCount == 0)
					{
						if (millisecondsTimeout == 0)
						{
							return false;
						}
						try
						{
							result = this.WaitUntilCountOrTimeout(millisecondsTimeout, startTime, cancellationToken);
						}
						catch (OperationCanceledException ex)
						{
						}
					}
					if (this.m_currentCount > 0)
					{
						result = true;
						this.m_currentCount--;
					}
					else if (ex != null)
					{
						throw ex;
					}
					if (this.m_waitHandle != null && this.m_currentCount == 0)
					{
						this.m_waitHandle.Reset();
					}
				}
			}
			finally
			{
				if (flag)
				{
					this.m_waitCount--;
					Monitor.Exit(this.m_lockObj);
				}
				cancellationTokenRegistration.Dispose();
			}
			if (task == null)
			{
				return result;
			}
			return task.GetAwaiter().GetResult();
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00071150 File Offset: 0x0006F350
		private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			int num = -1;
			while (this.m_currentCount == 0)
			{
				cancellationToken.ThrowIfCancellationRequested();
				if (millisecondsTimeout != -1)
				{
					num = TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout);
					if (num <= 0)
					{
						return false;
					}
				}
				if (!Monitor.Wait(this.m_lockObj, num))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Асинхронно ожидает входа в <see cref="T:System.Threading.SemaphoreSlim" />.</summary>
		/// <returns>Задача, которая завершается при входе в семафор.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.SemaphoreSlim" /> удален.</exception>
		// Token: 0x06001E85 RID: 7813 RVA: 0x00071198 File Offset: 0x0006F398
		public Task WaitAsync()
		{
			return this.WaitAsync(-1, default(CancellationToken));
		}

		/// <summary>Асинхронно ожидает входа в <see cref="T:System.Threading.SemaphoreSlim" />, контролируя <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Задача, которая завершается при входе в семафор.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		// Token: 0x06001E86 RID: 7814 RVA: 0x000711B5 File Offset: 0x0006F3B5
		public Task WaitAsync(CancellationToken cancellationToken)
		{
			return this.WaitAsync(-1, cancellationToken);
		}

		/// <summary>Асинхронно ожидает входа в <see cref="T:System.Threading.SemaphoreSlim" />, используя 32-разрядное целое число со знаком для измерения интервала времени.</summary>
		/// <param name="millisecondsTimeout">Количество миллисекунд ожидания, <see cref="F:System.Threading.Timeout.Infinite" /> (–1) для неограниченного времени ожидания, или нуль, чтобы проверить состояние дескриптора ожидания и выполнить немедленный возврат.</param>
		/// <returns>Задача, которая будет завершаться с результатом <see langword="true" />, если текущий поток успешно вошел в <see cref="T:System.Threading.SemaphoreSlim" />, и с результатом <see langword="false" /> в противном случае.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от значения –1, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001E87 RID: 7815 RVA: 0x000711C0 File Offset: 0x0006F3C0
		public Task<bool> WaitAsync(int millisecondsTimeout)
		{
			return this.WaitAsync(millisecondsTimeout, default(CancellationToken));
		}

		/// <summary>Асинхронно ожидает входа в <see cref="T:System.Threading.SemaphoreSlim" />, используя <see cref="T:System.TimeSpan" /> для измерения интервала времени.</summary>
		/// <param name="timeout">
		///   <see cref="T:System.TimeSpan" />, представляющий количество миллисекунд для ожидания, <see cref="T:System.TimeSpan" />, представляющий –1 миллисекунду для неопределенного ожидания, или <see cref="T:System.TimeSpan" />, представляющий 0 миллисекунд, чтобы протестировать дескриптор ожидания и выполнить немедленный возврат.</param>
		/// <returns>Задача, которая будет завершаться с результатом <see langword="true" />, если текущий поток успешно вошел в <see cref="T:System.Threading.SemaphoreSlim" />, и с результатом <see langword="false" /> в противном случае.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от значения –1, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001E88 RID: 7816 RVA: 0x000711E0 File Offset: 0x0006F3E0
		public Task<bool> WaitAsync(TimeSpan timeout)
		{
			return this.WaitAsync(timeout, default(CancellationToken));
		}

		/// <summary>Асинхронно ожидает входа в <see cref="T:System.Threading.SemaphoreSlim" />, используя <see cref="T:System.TimeSpan" /> для измерения интервала времени и контролируя <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="timeout">
		///   <see cref="T:System.TimeSpan" />, представляющий количество миллисекунд для ожидания, <see cref="T:System.TimeSpan" />, представляющий –1 миллисекунду для неопределенного ожидания, или <see cref="T:System.TimeSpan" />, представляющий 0 миллисекунд, чтобы протестировать дескриптор ожидания и выполнить немедленный возврат.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Задача, которая будет завершаться с результатом <see langword="true" />, если текущий поток успешно вошел в <see cref="T:System.Threading.SemaphoreSlim" />, и с результатом <see langword="false" /> в противном случае.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от значения –1, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.SemaphoreSlim" /> удален.</exception>
		// Token: 0x06001E89 RID: 7817 RVA: 0x00071200 File Offset: 0x0006F400
		public Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SemaphoreSlim.GetResourceString("The timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			return this.WaitAsync((int)timeout.TotalMilliseconds, cancellationToken);
		}

		/// <summary>Асинхронно ожидает входа в <see cref="T:System.Threading.SemaphoreSlim" />, используя 32-разрядное целое число со знаком для измерения интервала времени, контролируя <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="millisecondsTimeout">Количество миллисекунд ожидания, <see cref="F:System.Threading.Timeout.Infinite" /> (–1) для неограниченного времени ожидания, или нуль, чтобы проверить состояние дескриптора ожидания и выполнить немедленный возврат.</param>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Задача, которая будет завершаться с результатом <see langword="true" />, если текущий поток успешно вошел в <see cref="T:System.Threading.SemaphoreSlim" />, и с результатом <see langword="false" /> в противном случае.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> является числом, отличным от значения –1, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		// Token: 0x06001E8A RID: 7818 RVA: 0x00071250 File Offset: 0x0006F450
		public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.CheckDispose();
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("totalMilliSeconds", millisecondsTimeout, SemaphoreSlim.GetResourceString("The timeout must represent a value between -1 and Int32.MaxValue, inclusive."));
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCancellation<bool>(cancellationToken);
			}
			object lockObj = this.m_lockObj;
			Task<bool> result;
			lock (lockObj)
			{
				if (this.m_currentCount > 0)
				{
					this.m_currentCount--;
					if (this.m_waitHandle != null && this.m_currentCount == 0)
					{
						this.m_waitHandle.Reset();
					}
					result = SemaphoreSlim.s_trueTask;
				}
				else if (millisecondsTimeout == 0)
				{
					result = SemaphoreSlim.s_falseTask;
				}
				else
				{
					SemaphoreSlim.TaskNode taskNode = this.CreateAndAddAsyncWaiter();
					result = ((millisecondsTimeout == -1 && !cancellationToken.CanBeCanceled) ? taskNode : this.WaitUntilCountOrTimeoutAsync(taskNode, millisecondsTimeout, cancellationToken));
				}
			}
			return result;
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00071334 File Offset: 0x0006F534
		private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			SemaphoreSlim.TaskNode taskNode = new SemaphoreSlim.TaskNode();
			if (this.m_asyncHead == null)
			{
				this.m_asyncHead = taskNode;
				this.m_asyncTail = taskNode;
			}
			else
			{
				this.m_asyncTail.Next = taskNode;
				taskNode.Prev = this.m_asyncTail;
				this.m_asyncTail = taskNode;
			}
			return taskNode;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00071380 File Offset: 0x0006F580
		private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			bool result = this.m_asyncHead == task || task.Prev != null;
			if (task.Next != null)
			{
				task.Next.Prev = task.Prev;
			}
			if (task.Prev != null)
			{
				task.Prev.Next = task.Next;
			}
			if (this.m_asyncHead == task)
			{
				this.m_asyncHead = task.Next;
			}
			if (this.m_asyncTail == task)
			{
				this.m_asyncTail = task.Prev;
			}
			task.Next = (task.Prev = null);
			return result;
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00071410 File Offset: 0x0006F610
		private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32 <WaitUntilCountOrTimeoutAsync>d__;
			<WaitUntilCountOrTimeoutAsync>d__.<>4__this = this;
			<WaitUntilCountOrTimeoutAsync>d__.asyncWaiter = asyncWaiter;
			<WaitUntilCountOrTimeoutAsync>d__.millisecondsTimeout = millisecondsTimeout;
			<WaitUntilCountOrTimeoutAsync>d__.cancellationToken = cancellationToken;
			<WaitUntilCountOrTimeoutAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<WaitUntilCountOrTimeoutAsync>d__.<>1__state = -1;
			<WaitUntilCountOrTimeoutAsync>d__.<>t__builder.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>(ref <WaitUntilCountOrTimeoutAsync>d__);
			return <WaitUntilCountOrTimeoutAsync>d__.<>t__builder.Task;
		}

		/// <summary>Освобождает объект <see cref="T:System.Threading.SemaphoreSlim" /> один раз.</summary>
		/// <returns>Предыдущее количество в семафоре <see cref="T:System.Threading.SemaphoreSlim" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.Threading.SemaphoreFullException">
		///   <see cref="T:System.Threading.SemaphoreSlim" /> уже достиг максимального размера.</exception>
		// Token: 0x06001E8E RID: 7822 RVA: 0x0007146B File Offset: 0x0006F66B
		public int Release()
		{
			return this.Release(1);
		}

		/// <summary>Освобождает объект <see cref="T:System.Threading.SemaphoreSlim" /> указанное число раз.</summary>
		/// <param name="releaseCount">Количество требуемых выходов из семафора.</param>
		/// <returns>Предыдущее количество в семафоре <see cref="T:System.Threading.SemaphoreSlim" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="releaseCount" /> меньше 1.</exception>
		/// <exception cref="T:System.Threading.SemaphoreFullException">
		///   <see cref="T:System.Threading.SemaphoreSlim" /> уже достиг максимального размера.</exception>
		// Token: 0x06001E8F RID: 7823 RVA: 0x00071474 File Offset: 0x0006F674
		public int Release(int releaseCount)
		{
			this.CheckDispose();
			if (releaseCount < 1)
			{
				throw new ArgumentOutOfRangeException("releaseCount", releaseCount, SemaphoreSlim.GetResourceString("The releaseCount argument must be greater than zero."));
			}
			object lockObj = this.m_lockObj;
			int num2;
			lock (lockObj)
			{
				int num = this.m_currentCount;
				num2 = num;
				if (this.m_maxCount - num < releaseCount)
				{
					throw new SemaphoreFullException();
				}
				num += releaseCount;
				int waitCount = this.m_waitCount;
				if (num == 1 || waitCount == 1)
				{
					Monitor.Pulse(this.m_lockObj);
				}
				else if (waitCount > 1)
				{
					Monitor.PulseAll(this.m_lockObj);
				}
				if (this.m_asyncHead != null)
				{
					int num3 = num - waitCount;
					while (num3 > 0 && this.m_asyncHead != null)
					{
						num--;
						num3--;
						SemaphoreSlim.TaskNode asyncHead = this.m_asyncHead;
						this.RemoveAsyncWaiter(asyncHead);
						SemaphoreSlim.QueueWaiterTask(asyncHead);
					}
				}
				this.m_currentCount = num;
				if (this.m_waitHandle != null && num2 == 0 && num > 0)
				{
					this.m_waitHandle.Set();
				}
			}
			return num2;
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0007158C File Offset: 0x0006F78C
		[SecuritySafeCritical]
		private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask)
		{
			ThreadPool.UnsafeQueueCustomWorkItem(waiterTask, false);
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Threading.SemaphoreSlim" />.</summary>
		// Token: 0x06001E91 RID: 7825 RVA: 0x00071595 File Offset: 0x0006F795
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые журналом <see cref="T:System.Threading.SemaphoreSlim" />, и при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06001E92 RID: 7826 RVA: 0x000715A4 File Offset: 0x0006F7A4
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.m_waitHandle != null)
				{
					this.m_waitHandle.Close();
					this.m_waitHandle = null;
				}
				this.m_lockObj = null;
				this.m_asyncHead = null;
				this.m_asyncTail = null;
			}
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000715E0 File Offset: 0x0006F7E0
		private static void CancellationTokenCanceledEventHandler(object obj)
		{
			SemaphoreSlim semaphoreSlim = obj as SemaphoreSlim;
			object lockObj = semaphoreSlim.m_lockObj;
			lock (lockObj)
			{
				Monitor.PulseAll(semaphoreSlim.m_lockObj);
			}
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x0007162C File Offset: 0x0006F82C
		private void CheckDispose()
		{
			if (this.m_lockObj == null)
			{
				throw new ObjectDisposedException(null, SemaphoreSlim.GetResourceString("The semaphore has been disposed."));
			}
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00071647 File Offset: 0x0006F847
		private static string GetResourceString(string str)
		{
			return Environment.GetResourceString(str);
		}

		// Token: 0x04001AB9 RID: 6841
		private volatile int m_currentCount;

		// Token: 0x04001ABA RID: 6842
		private readonly int m_maxCount;

		// Token: 0x04001ABB RID: 6843
		private volatile int m_waitCount;

		// Token: 0x04001ABC RID: 6844
		private object m_lockObj;

		// Token: 0x04001ABD RID: 6845
		private volatile ManualResetEvent m_waitHandle;

		// Token: 0x04001ABE RID: 6846
		private SemaphoreSlim.TaskNode m_asyncHead;

		// Token: 0x04001ABF RID: 6847
		private SemaphoreSlim.TaskNode m_asyncTail;

		// Token: 0x04001AC0 RID: 6848
		private static readonly Task<bool> s_trueTask = new Task<bool>(false, true, (TaskCreationOptions)16384, default(CancellationToken));

		// Token: 0x04001AC1 RID: 6849
		private static readonly Task<bool> s_falseTask = new Task<bool>(false, false, (TaskCreationOptions)16384, default(CancellationToken));

		// Token: 0x04001AC2 RID: 6850
		private const int NO_MAXIMUM = 2147483647;

		// Token: 0x04001AC3 RID: 6851
		private static Action<object> s_cancellationTokenCanceledEventHandler = new Action<object>(SemaphoreSlim.CancellationTokenCanceledEventHandler);

		// Token: 0x020002BC RID: 700
		private sealed class TaskNode : Task<bool>, IThreadPoolWorkItem
		{
			// Token: 0x06001E97 RID: 7831 RVA: 0x000716A2 File Offset: 0x0006F8A2
			internal TaskNode()
			{
			}

			// Token: 0x06001E98 RID: 7832 RVA: 0x000716AA File Offset: 0x0006F8AA
			[SecurityCritical]
			void IThreadPoolWorkItem.ExecuteWorkItem()
			{
				base.TrySetResult(true);
			}

			// Token: 0x06001E99 RID: 7833 RVA: 0x00004BF9 File Offset: 0x00002DF9
			[SecurityCritical]
			void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
			{
			}

			// Token: 0x04001AC4 RID: 6852
			internal SemaphoreSlim.TaskNode Prev;

			// Token: 0x04001AC5 RID: 6853
			internal SemaphoreSlim.TaskNode Next;
		}
	}
}
