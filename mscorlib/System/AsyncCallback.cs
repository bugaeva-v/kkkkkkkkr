using System;

namespace System
{
	/// <summary>Ссылается на метод, который должен вызываться при завершении соответствующей асинхронной операции.</summary>
	/// <param name="ar">Результат асинхронной операции.</param>
	// Token: 0x020000FC RID: 252
	// (Invoke) Token: 0x0600074E RID: 1870
	[Serializable]
	public delegate void AsyncCallback(IAsyncResult ar);
}
