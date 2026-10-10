using System;

namespace System.IO.Compression
{
	/// <summary>Указывает, нужно ли сжимать и распаковывать основной поток.</summary>
	// Token: 0x02000544 RID: 1348
	public enum CompressionMode
	{
		/// <summary>Распаковывает основной поток.</summary>
		// Token: 0x040017A9 RID: 6057
		Decompress,
		/// <summary>Сжимает основной поток.</summary>
		// Token: 0x040017AA RID: 6058
		Compress
	}
}
