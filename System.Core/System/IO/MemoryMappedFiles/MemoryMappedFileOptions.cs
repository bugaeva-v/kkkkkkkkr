using System;

namespace System.IO.MemoryMappedFiles
{
	/// <summary>
	///         Предоставляет параметры выделения памяти файлы памяти.
	///       </summary>
	// Token: 0x02000335 RID: 821
	[Flags]
	[Serializable]
	public enum MemoryMappedFileOptions
	{
		/// <summary>
		///         Применяются никакие параметры выделения памяти.
		///       </summary>
		// Token: 0x04000BF6 RID: 3062
		None = 0,
		/// <summary>
		///         Выделение памяти откладывается, пока не будет создано представление с помощью <see cref="M:System.IO.MemoryMappedFiles.MemoryMappedFile.CreateViewAccessor" /> или <see cref="M:System.IO.MemoryMappedFiles.MemoryMappedFile.CreateViewStream" /> метод.
		///       </summary>
		// Token: 0x04000BF7 RID: 3063
		DelayAllocatePages = 67108864
	}
}
