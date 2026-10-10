using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Представляет метод, который вызывается при получении объектом <see cref="T:System.Threading.WaitHandle" /> сигнала или истечении времени ожидания.</summary>
	/// <param name="state">Объект, содержащий информацию, используемую всякий раз методом обратного вызова при каждом выполнении.</param>
	/// <param name="timedOut">Значение <see langword="true" />, если истекло время ожидания объекта <see cref="T:System.Threading.WaitHandle" />; <see langword="false" />, если объект получил сигнал.</param>
	// Token: 0x020002DB RID: 731
	// (Invoke) Token: 0x06002003 RID: 8195
	[ComVisible(true)]
	public delegate void WaitOrTimerCallback(object state, bool timedOut);
}
