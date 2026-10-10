using System;
using System.Diagnostics;

namespace System.Threading
{
	/// <summary>Представляет примитив синхронизации, которому отправляется сигнал при достижении счетчиком нуля.</summary>
	// Token: 0x0200029D RID: 669
	[DebuggerDisplay("Initial Count={InitialCount}, Current Count={CurrentCount}")]
	public class CountdownEvent : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.CountdownEvent" /> указанным количеством.</summary>
		/// <param name="initialCount">Количество сигналов, первоначально необходимое для задания объекта <see cref="T:System.Threading.CountdownEvent" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="initialCount" /> меньше 0.</exception>
		// Token: 0x06001DAB RID: 7595 RVA: 0x0006E7C7 File Offset: 0x0006C9C7
		public CountdownEvent(int initialCount)
		{
			if (initialCount < 0)
			{
				throw new ArgumentOutOfRangeException("initialCount");
			}
			this._initialCount = initialCount;
			this._currentCount = initialCount;
			this._event = new ManualResetEventSlim();
			if (initialCount == 0)
			{
				this._event.Set();
			}
		}

		/// <summary>Получает количество сигналов, оставшееся до установки события.</summary>
		/// <returns>Количество сигналов, оставшееся до установки события.</returns>
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0006E808 File Offset: 0x0006CA08
		public int CurrentCount
		{
			get
			{
				int currentCount = this._currentCount;
				if (currentCount >= 0)
				{
					return currentCount;
				}
				return 0;
			}
		}

		/// <summary>Получает количество сигналов, изначально нужное для установки события.</summary>
		/// <returns>Количество сигналов, изначально нужное для установки события.</returns>
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0006E825 File Offset: 0x0006CA25
		public int InitialCount
		{
			get
			{
				return this._initialCount;
			}
		}

		/// <summary>Указывает, достиг ли текущий счетчик объекта <see cref="T:System.Threading.CountdownEvent" /> нуля.</summary>
		/// <returns>
		///   <see langword="true" />, если текущее значение счетчика равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x0006E82D File Offset: 0x0006CA2D
		public bool IsSet
		{
			get
			{
				return this._currentCount <= 0;
			}
		}

		/// <summary>Получает дескриптор <see cref="T:System.Threading.WaitHandle" />, используемый для ожидания установки события.</summary>
		/// <returns>Дескриптор <see cref="T:System.Threading.WaitHandle" />, используемый для ожидания установки события.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0006E83D File Offset: 0x0006CA3D
		public WaitHandle WaitHandle
		{
			get
			{
				this.ThrowIfDisposed();
				return this._event.WaitHandle;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Threading.CountdownEvent" />.</summary>
		// Token: 0x06001DB0 RID: 7600 RVA: 0x0006E850 File Offset: 0x0006CA50
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые журналом <see cref="T:System.Threading.CountdownEvent" />, и при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение true, чтобы освободить управляемые и неуправляемые ресурсы; значение false, чтобы освободить только неуправляемые ресурсы.</param>
		// Token: 0x06001DB1 RID: 7601 RVA: 0x0006E85F File Offset: 0x0006CA5F
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._event.Dispose();
				this._disposed = true;
			}
		}

		/// <summary>Регистрирует сигнал с событием <see cref="T:System.Threading.CountdownEvent" />, уменьшая значение свойства <see cref="P:System.Threading.CountdownEvent.CurrentCount" />.</summary>
		/// <returns>Значение true, если после сигнала подсчет стал равен нулю и было создано событие; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр уже задан.</exception>
		// Token: 0x06001DB2 RID: 7602 RVA: 0x0006E878 File Offset: 0x0006CA78
		public bool Signal()
		{
			this.ThrowIfDisposed();
			if (this._currentCount <= 0)
			{
				throw new InvalidOperationException("Invalid attempt made to decrement the event's count below zero.");
			}
			int num = Interlocked.Decrement(ref this._currentCount);
			if (num == 0)
			{
				this._event.Set();
				return true;
			}
			if (num < 0)
			{
				throw new InvalidOperationException("Invalid attempt made to decrement the event's count below zero.");
			}
			return false;
		}

		/// <summary>Регистрирует несколько сигналов с объектом <see cref="T:System.Threading.CountdownEvent" />, уменьшая значение свойства <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> на указанное число.</summary>
		/// <param name="signalCount">Количество сигналов, которое необходимо зарегистрировать.</param>
		/// <returns>Значение true, если после сигналов подсчет стал равен нулю и было создано событие; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="signalCount" /> меньше 1.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр уже задан. - или- Или значение <paramref name="signalCount" /> больше <see cref="P:System.Threading.CountdownEvent.CurrentCount" />.</exception>
		// Token: 0x06001DB3 RID: 7603 RVA: 0x0006E8D0 File Offset: 0x0006CAD0
		public bool Signal(int signalCount)
		{
			if (signalCount <= 0)
			{
				throw new ArgumentOutOfRangeException("signalCount");
			}
			this.ThrowIfDisposed();
			SpinWait spinWait = default(SpinWait);
			int currentCount;
			for (;;)
			{
				currentCount = this._currentCount;
				if (currentCount < signalCount)
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this._currentCount, currentCount - signalCount, currentCount) == currentCount)
				{
					goto IL_50;
				}
				spinWait.SpinOnce();
			}
			throw new InvalidOperationException("Invalid attempt made to decrement the event's count below zero.");
			IL_50:
			if (currentCount == signalCount)
			{
				this._event.Set();
				return true;
			}
			return false;
		}

		/// <summary>Увеличивает текущий подсчет <see cref="T:System.Threading.CountdownEvent" /> на один.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр уже задан.  
		/// -или- 
		///  Значение параметра <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> больше или равно значению свойства <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001DB4 RID: 7604 RVA: 0x0006E93F File Offset: 0x0006CB3F
		public void AddCount()
		{
			this.AddCount(1);
		}

		/// <summary>Попытка увеличить <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> на единицу.</summary>
		/// <returns>Значение true, если увеличение выполнено успешно; в противном случае — значение false. Если значение свойства <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> уже равно нулю, метод возвращает значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> равно <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001DB5 RID: 7605 RVA: 0x0006E948 File Offset: 0x0006CB48
		public bool TryAddCount()
		{
			return this.TryAddCount(1);
		}

		/// <summary>Увеличивает текущее количество в объекте <see cref="T:System.Threading.CountdownEvent" /> на указанное значение.</summary>
		/// <param name="signalCount">Значение, на которое нужно увеличить <see cref="P:System.Threading.CountdownEvent.CurrentCount" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="signalCount" /> меньше или равно 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр уже задан.  
		/// -или- 
		///  <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> равно или больше <see cref="F:System.Int32.MaxValue" /> после увеличения счета параметром <paramref name="signalCount." /></exception>
		// Token: 0x06001DB6 RID: 7606 RVA: 0x0006E951 File Offset: 0x0006CB51
		public void AddCount(int signalCount)
		{
			if (!this.TryAddCount(signalCount))
			{
				throw new InvalidOperationException("The event is already signaled and cannot be incremented.");
			}
		}

		/// <summary>Пытается увеличить <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> на указанное значение.</summary>
		/// <param name="signalCount">Значение, на которое нужно увеличить <see cref="P:System.Threading.CountdownEvent.CurrentCount" />.</param>
		/// <returns>Значение true, если увеличение выполнено успешно; в противном случае — значение false. Если значение свойства <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> уже равно нулю, возвращается значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="signalCount" /> меньше или равно 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">Значение параметра <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> + <paramref name="signalCount" /> больше или равно значению свойства <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001DB7 RID: 7607 RVA: 0x0006E968 File Offset: 0x0006CB68
		public bool TryAddCount(int signalCount)
		{
			if (signalCount <= 0)
			{
				throw new ArgumentOutOfRangeException("signalCount");
			}
			this.ThrowIfDisposed();
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int currentCount = this._currentCount;
				if (currentCount <= 0)
				{
					break;
				}
				if (currentCount > 2147483647 - signalCount)
				{
					goto Block_3;
				}
				if (Interlocked.CompareExchange(ref this._currentCount, currentCount + signalCount, currentCount) == currentCount)
				{
					return true;
				}
				spinWait.SpinOnce();
			}
			return false;
			Block_3:
			throw new InvalidOperationException("The increment operation would cause the CurrentCount to overflow.");
		}

		/// <summary>Сбрасывает свойство <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> на значение свойства <see cref="P:System.Threading.CountdownEvent.InitialCount" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		// Token: 0x06001DB8 RID: 7608 RVA: 0x0006E9D2 File Offset: 0x0006CBD2
		public void Reset()
		{
			this.Reset(this._initialCount);
		}

		/// <summary>Присваивает свойству <see cref="P:System.Threading.CountdownEvent.InitialCount" /> заданное значение.</summary>
		/// <param name="count">Количество сигналов, необходимое для установки объекта <see cref="T:System.Threading.CountdownEvent" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже был удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше 0.</exception>
		// Token: 0x06001DB9 RID: 7609 RVA: 0x0006E9E0 File Offset: 0x0006CBE0
		public void Reset(int count)
		{
			this.ThrowIfDisposed();
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this._currentCount = count;
			this._initialCount = count;
			if (count == 0)
			{
				this._event.Set();
				return;
			}
			this._event.Reset();
		}

		/// <summary>Блокирует текущий поток до установки <see cref="T:System.Threading.CountdownEvent" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		// Token: 0x06001DBA RID: 7610 RVA: 0x0006EA2C File Offset: 0x0006CC2C
		public void Wait()
		{
			this.Wait(-1, default(CancellationToken));
		}

		/// <summary>Блокирует текущий поток, пока не будет установлено <see cref="T:System.Threading.CountdownEvent" />, в то же время контролируя <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален. — или — <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, был удален.</exception>
		// Token: 0x06001DBB RID: 7611 RVA: 0x0006EA4A File Offset: 0x0006CC4A
		public void Wait(CancellationToken cancellationToken)
		{
			this.Wait(-1, cancellationToken);
		}

		/// <summary>Блокирует текущий поток до тех пор, пока не будет установлен объект <see cref="T:System.Threading.CountdownEvent" />, используя значение <see cref="T:System.TimeSpan" /> для измерения времени ожидания.</summary>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Значение true, если установлено событие <see cref="T:System.Threading.CountdownEvent" />; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от значения -1 миллисекунда, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001DBC RID: 7612 RVA: 0x0006EA58 File Offset: 0x0006CC58
		public bool Wait(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout");
			}
			return this.Wait((int)num, default(CancellationToken));
		}

		/// <summary>Блокирует текущий поток, пока не будет установлен объект <see cref="T:System.Threading.CountdownEvent" />, используя значение <see cref="T:System.TimeSpan" /> для измерения времени ожидания. Кроме того, метод контролирует токен <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Значение true, если установлено событие <see cref="T:System.Threading.CountdownEvent" />; в противном случае — значение false.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален. — или — <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, был удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от значения -1 миллисекунда, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001DBD RID: 7613 RVA: 0x0006EA98 File Offset: 0x0006CC98
		public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout");
			}
			return this.Wait((int)num, cancellationToken);
		}

		/// <summary>Блокирует текущий поток до тех пор, пока не установлен объект <see cref="T:System.Threading.CountdownEvent" />, используя 32-разрядное знаковое целое число для измерения времени ожидания.</summary>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или <see cref="F:System.Threading.Timeout.Infinite" /> (-1) для неограниченного времени ожидания.</param>
		/// <returns>Значение true, если установлено событие <see cref="T:System.Threading.CountdownEvent" />; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		// Token: 0x06001DBE RID: 7614 RVA: 0x0006EAD0 File Offset: 0x0006CCD0
		public bool Wait(int millisecondsTimeout)
		{
			return this.Wait(millisecondsTimeout, default(CancellationToken));
		}

		/// <summary>Блокирует текущий поток до тех пор, пока не будет установлен объект <see cref="T:System.Threading.CountdownEvent" />, используя 32-разрядное знаковое целое число для измерения времени ожидания. Кроме того, метод контролирует токен <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или <see cref="F:System.Threading.Timeout.Infinite" /> (-1) для неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Токен отмены <see cref="T:System.Threading.CancellationToken" />, который следует контролировать.</param>
		/// <returns>Значение true, если установлено событие <see cref="T:System.Threading.CountdownEvent" />; в противном случае — значение false.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///   <paramref name="cancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален. — или — <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, был удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		// Token: 0x06001DBF RID: 7615 RVA: 0x0006EAF0 File Offset: 0x0006CCF0
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			this.ThrowIfDisposed();
			cancellationToken.ThrowIfCancellationRequested();
			bool flag = this.IsSet;
			if (!flag)
			{
				flag = this._event.Wait(millisecondsTimeout, cancellationToken);
			}
			return flag;
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0006EB32 File Offset: 0x0006CD32
		private void ThrowIfDisposed()
		{
			if (this._disposed)
			{
				throw new ObjectDisposedException("CountdownEvent");
			}
		}

		// Token: 0x04001A52 RID: 6738
		private int _initialCount;

		// Token: 0x04001A53 RID: 6739
		private volatile int _currentCount;

		// Token: 0x04001A54 RID: 6740
		private ManualResetEventSlim _event;

		// Token: 0x04001A55 RID: 6741
		private volatile bool _disposed;
	}
}
