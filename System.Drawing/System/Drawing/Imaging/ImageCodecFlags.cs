using System;

namespace System.Drawing.Imaging
{
	/// <summary>Предоставляет атрибуты кодировщика или декодера изображения (кодека).</summary>
	// Token: 0x02000108 RID: 264
	[Flags]
	public enum ImageCodecFlags
	{
		/// <summary>Кодек поддерживает кодирование (сохранение).</summary>
		// Token: 0x040009AC RID: 2476
		Encoder = 1,
		/// <summary>Кодек поддерживает декодирование (чтение).</summary>
		// Token: 0x040009AD RID: 2477
		Decoder = 2,
		/// <summary>Кодек поддерживает растровые изображения (точечные рисунки).</summary>
		// Token: 0x040009AE RID: 2478
		SupportBitmap = 4,
		/// <summary>Кодек поддерживает векторные изображения (метафайлы).</summary>
		// Token: 0x040009AF RID: 2479
		SupportVector = 8,
		/// <summary>Кодировщику требуется поток вывода с возможностью поиска.</summary>
		// Token: 0x040009B0 RID: 2480
		SeekableEncode = 16,
		/// <summary>В процессе декодирования декодер выполняет блокировку.</summary>
		// Token: 0x040009B1 RID: 2481
		BlockingDecode = 32,
		/// <summary>Кодек встроен в GDI+.</summary>
		// Token: 0x040009B2 RID: 2482
		Builtin = 65536,
		/// <summary>Не используется.</summary>
		// Token: 0x040009B3 RID: 2483
		System = 131072,
		/// <summary>Не используется.</summary>
		// Token: 0x040009B4 RID: 2484
		User = 262144
	}
}
