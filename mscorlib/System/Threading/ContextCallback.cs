using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Представляет метод, вызываемый в новом контексте.</summary>
	/// <param name="state">Объект, содержащий информацию, используемую всякий раз методом обратного вызова при каждом выполнении.</param>
	// Token: 0x020002C7 RID: 711
	// (Invoke) Token: 0x06001EDF RID: 7903
	[ComVisible(true)]
	public delegate void ContextCallback(object state);
}
