using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Представляет метод обратного вызова, выполняющегося потоком из пула потоков.</summary>
	/// <param name="state">Объект, содержащий информацию, используемую методом обратного вызова.</param>
	// Token: 0x020002DA RID: 730
	// (Invoke) Token: 0x06001FFF RID: 8191
	[ComVisible(true)]
	public delegate void WaitCallback(object state);
}
