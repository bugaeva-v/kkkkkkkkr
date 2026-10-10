using System;

namespace System.Threading
{
	/// <summary>Указывает метод, вызываемый при отправке сообщения в контекст синхронизации.</summary>
	/// <param name="state">Передаваемый делегату объект.</param>
	// Token: 0x02000294 RID: 660
	// (Invoke) Token: 0x06001D94 RID: 7572
	public delegate void SendOrPostCallback(object state);
}
