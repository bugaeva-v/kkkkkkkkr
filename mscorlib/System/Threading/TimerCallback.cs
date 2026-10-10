using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Представляет метод, обрабатывающий вызовы от события <see cref="T:System.Threading.Timer" />.</summary>
	/// <param name="state">Объект, содержащий информацию о конкретном приложении, существенные для метода, вызванного этим делегатом, или значение <see langword="null" />.</param>
	// Token: 0x020002FC RID: 764
	// (Invoke) Token: 0x06002148 RID: 8520
	[ComVisible(true)]
	public delegate void TimerCallback(object state);
}
