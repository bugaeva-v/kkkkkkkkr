using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Представляет количество 100-наносекундных интервалов с 10 января 1601 года. Эта структура представляет собой 64-разрядное значение.</summary>
	// Token: 0x020007A9 RID: 1961
	public struct FILETIME
	{
		/// <summary>Задает младшие 32 бита структуры <see langword="FILETIME" />.</summary>
		// Token: 0x04002C49 RID: 11337
		public int dwLowDateTime;

		/// <summary>Задает старшие 32 бита структуры <see langword="FILETIME" />.</summary>
		// Token: 0x04002C4A RID: 11338
		public int dwHighDateTime;
	}
}
