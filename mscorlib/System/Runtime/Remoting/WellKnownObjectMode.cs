using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Определяет методы активации хорошо известных объектов.</summary>
	// Token: 0x02000579 RID: 1401
	[ComVisible(true)]
	[Serializable]
	public enum WellKnownObjectMode
	{
		/// <summary>Каждое входящее сообщение обслуживается тем же экземпляром объекта.</summary>
		// Token: 0x04002571 RID: 9585
		Singleton = 1,
		/// <summary>Каждое входящее сообщение обслуживается новым экземпляром объекта.</summary>
		// Token: 0x04002572 RID: 9586
		SingleCall
	}
}
