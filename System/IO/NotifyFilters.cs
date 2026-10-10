using System;

namespace System.IO
{
	/// <summary>Задает изменения, наблюдаемые в файле или папке.</summary>
	// Token: 0x02000523 RID: 1315
	[Flags]
	public enum NotifyFilters
	{
		/// <summary>Атрибуты файла или папки.</summary>
		// Token: 0x040016E6 RID: 5862
		Attributes = 4,
		/// <summary>Время создания файла или папки.</summary>
		// Token: 0x040016E7 RID: 5863
		CreationTime = 64,
		/// <summary>Имя каталога.</summary>
		// Token: 0x040016E8 RID: 5864
		DirectoryName = 2,
		/// <summary>Имя файла</summary>
		// Token: 0x040016E9 RID: 5865
		FileName = 1,
		/// <summary>Дата последнего открытия файла или папки.</summary>
		// Token: 0x040016EA RID: 5866
		LastAccess = 32,
		/// <summary>Дата последней записи в файл или папку.</summary>
		// Token: 0x040016EB RID: 5867
		LastWrite = 16,
		/// <summary>Параметры безопасности файла или папки.</summary>
		// Token: 0x040016EC RID: 5868
		Security = 256,
		/// <summary>Размер файла или папки.</summary>
		// Token: 0x040016ED RID: 5869
		Size = 8
	}
}
