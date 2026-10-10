using System;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Указывает, что строка содержит имя журнала событий или путь к файлу журнала событий.
	///       </summary>
	// Token: 0x0200039D RID: 925
	public enum PathType
	{
		/// <summary>
		///         Параметр пути содержит путь к файлу журнала событий.
		///       </summary>
		// Token: 0x04000D48 RID: 3400
		FilePath = 2,
		/// <summary>
		///         Параметр пути содержит имя журнала событий.
		///       </summary>
		// Token: 0x04000D49 RID: 3401
		LogName = 1
	}
}
