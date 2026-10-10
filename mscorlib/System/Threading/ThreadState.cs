using System;

namespace System.Threading
{
	/// <summary>Задает состояния выполнения объекта <see cref="T:System.Threading.Thread" />.</summary>
	// Token: 0x02000299 RID: 665
	[Flags]
	public enum ThreadState
	{
		/// <summary>Поток был запущен, но не останавливался.</summary>
		// Token: 0x04001A45 RID: 6725
		Running = 0,
		/// <summary>Поток получает запрос на остановку. Предназначено только для внутреннего использования.</summary>
		// Token: 0x04001A46 RID: 6726
		StopRequested = 1,
		/// <summary>Запрашивается приостановка работы потока.</summary>
		// Token: 0x04001A47 RID: 6727
		SuspendRequested = 2,
		/// <summary>Поток выполняется как фоновый поток, в противоположность потокам переднего плана. Это состояние управляется заданием свойства <see cref="P:System.Threading.Thread.IsBackground" />.</summary>
		// Token: 0x04001A48 RID: 6728
		Background = 4,
		/// <summary>Метод <see cref="M:System.Threading.Thread.Start" /> не был вызван для потока.</summary>
		// Token: 0x04001A49 RID: 6729
		Unstarted = 8,
		/// <summary>Поток был остановлен.</summary>
		// Token: 0x04001A4A RID: 6730
		Stopped = 16,
		/// <summary>Поток заблокирован. Это может произойти в результате вызова метода <see cref="M:System.Threading.Thread.Sleep(System.Int32)" /> или метода <see cref="M:System.Threading.Thread.Join" />, в результате запроса блокировки, например при вызове метода <see cref="M:System.Threading.Monitor.Enter(System.Object)" /> или <see cref="M:System.Threading.Monitor.Wait(System.Object,System.Int32,System.Boolean)" /> или в результате ожидания объекта синхронизации потока, такого как <see cref="T:System.Threading.ManualResetEvent" />.</summary>
		// Token: 0x04001A4B RID: 6731
		WaitSleepJoin = 32,
		/// <summary>Поток был приостановлен.</summary>
		// Token: 0x04001A4C RID: 6732
		Suspended = 64,
		/// <summary>Метод <see cref="M:System.Threading.Thread.Abort(System.Object)" /> был вызван для потока, но поток еще не получил исключение <see cref="T:System.Threading.ThreadAbortException" />, которое попытается завершить его.</summary>
		// Token: 0x04001A4D RID: 6733
		AbortRequested = 128,
		/// <summary>Состояние потока включает в себя значение <see cref="F:System.Threading.ThreadState.AbortRequested" />, и поток теперь не выполняет работу, но его состояние еще не изменилось на <see cref="F:System.Threading.ThreadState.Stopped" />.</summary>
		// Token: 0x04001A4E RID: 6734
		Aborted = 256
	}
}
