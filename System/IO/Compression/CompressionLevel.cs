using System;

namespace System.IO.Compression
{
	/// <summary>Задает значения, показывающие, выделяет ли операция сжатия скорость или размер сжатого файла.</summary>
	// Token: 0x02000543 RID: 1347
	public enum CompressionLevel
	{
		/// <summary>При операции сжатия должно применяться оптимальное сжатие, даже если это увеличивает длительность ее выполнения.</summary>
		// Token: 0x040017A5 RID: 6053
		Optimal,
		/// <summary>Операция сжатия должна завершиться как можно быстрее, даже если результирующий файл не будет сжат оптимально.</summary>
		// Token: 0x040017A6 RID: 6054
		Fastest,
		/// <summary>Файл не требуется сжимать.</summary>
		// Token: 0x040017A7 RID: 6055
		NoCompression
	}
}
