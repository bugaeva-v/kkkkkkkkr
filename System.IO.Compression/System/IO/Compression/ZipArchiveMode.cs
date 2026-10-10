using System;

namespace System.IO.Compression
{
	/// <summary>
	///         Задает значения для взаимодействия с записями в ZIP-архиве.
	///       </summary>
	// Token: 0x0200002F RID: 47
	public enum ZipArchiveMode
	{
		/// <summary>
		///         Разрешается только чтение записей архива.
		///       </summary>
		// Token: 0x040001AE RID: 430
		Read,
		/// <summary>
		///         Допускается только создание новых записей в архиве.
		///       </summary>
		// Token: 0x040001AF RID: 431
		Create,
		/// <summary>
		///         Чтения и записи архива разрешены операции записи.
		///       </summary>
		// Token: 0x040001B0 RID: 432
		Update
	}
}
