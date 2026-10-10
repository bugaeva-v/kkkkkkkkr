using System;

namespace System.IO.MemoryMappedFiles
{
	/// <summary>
	///         Задает возможности доступа и ограничения для размещенного в памяти файла или представления.
	///       </summary>
	// Token: 0x02000334 RID: 820
	[Serializable]
	public enum MemoryMappedFileAccess
	{
		/// <summary>
		///         Чтение и запись в файл.
		///       </summary>
		// Token: 0x04000BEF RID: 3055
		ReadWrite,
		/// <summary>
		///         Доступ только для чтения к файлу.
		///       </summary>
		// Token: 0x04000BF0 RID: 3056
		Read,
		/// <summary>
		///         Доступ только для записи в файл.
		///       </summary>
		// Token: 0x04000BF1 RID: 3057
		Write,
		/// <summary>
		///         Чтение и запись к файлу с тем ограничением, что все операции записи не будет виден другим процессам.
		///       </summary>
		// Token: 0x04000BF2 RID: 3058
		CopyOnWrite,
		/// <summary>
		///         Доступ для чтения к файлу, можно хранить и запускать выполняемый код.
		///       </summary>
		// Token: 0x04000BF3 RID: 3059
		ReadExecute,
		/// <summary>
		///         Чтение и запись в файл, который может хранить и запускать выполняемый код.
		///       </summary>
		// Token: 0x04000BF4 RID: 3060
		ReadWriteExecute
	}
}
