using System;

namespace System.Runtime.ConstrainedExecution
{
	/// <summary>Указывает контракт о надежности.</summary>
	// Token: 0x020007D4 RID: 2004
	public enum Consistency
	{
		/// <summary>При возникновении исключительных условий среда CLR не обеспечивает согласованности состояний, то есть исключительное условие может повредить процесс.</summary>
		// Token: 0x04002D1B RID: 11547
		MayCorruptProcess,
		/// <summary>При возникновении исключительных условий среда CLR не обеспечивает согласованности состояний в текущем домене приложений.</summary>
		// Token: 0x04002D1C RID: 11548
		MayCorruptAppDomain,
		/// <summary>При возникновении исключительных условий гарантируется, что метод ограничит повреждения состояний текущим экземпляром.</summary>
		// Token: 0x04002D1D RID: 11549
		MayCorruptInstance,
		/// <summary>При возникновении исключительных условий, гарантируется, что метод не повредит состояние.</summary>
		// Token: 0x04002D1E RID: 11550
		WillNotCorruptState
	}
}
