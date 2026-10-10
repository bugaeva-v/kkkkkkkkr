using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.FILETIME" />.</summary>
	// Token: 0x0200073E RID: 1854
	[Obsolete]
	public struct FILETIME
	{
		/// <summary>Задает младшие 32 бита структуры <see langword="FILETIME" />.</summary>
		// Token: 0x04002BBF RID: 11199
		public int dwLowDateTime;

		/// <summary>Задает старшие 32 бита структуры <see langword="FILETIME" />.</summary>
		// Token: 0x04002BC0 RID: 11200
		public int dwHighDateTime;
	}
}
