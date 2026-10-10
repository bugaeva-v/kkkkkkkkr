using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Указывает, как обрабатываются нестандартные ошибки.</summary>
	// Token: 0x0200055A RID: 1370
	[ComVisible(true)]
	public enum CustomErrorsModes
	{
		/// <summary>Все вызывающие объекты получают фильтрованные сведения об исключении.</summary>
		// Token: 0x04002517 RID: 9495
		On,
		/// <summary>Все вызывающие объекты получают полные сведения об исключении.</summary>
		// Token: 0x04002518 RID: 9496
		Off,
		/// <summary>Локальные вызывающие объекты получают полные сведения об исключении. Удаленные вызывающие объекты получают фильтрованные сведения об исключении.</summary>
		// Token: 0x04002519 RID: 9497
		RemoteOnly
	}
}
