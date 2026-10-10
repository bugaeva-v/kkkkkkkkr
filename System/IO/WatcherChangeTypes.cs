using System;

namespace System.IO
{
	/// <summary>Возможные изменения в файле или каталоге.</summary>
	// Token: 0x02000528 RID: 1320
	[Flags]
	public enum WatcherChangeTypes
	{
		/// <summary>Создание, удаление, изменение или переименование файла или папки.</summary>
		// Token: 0x040016FF RID: 5887
		All = 15,
		/// <summary>Изменение файла или папки. Типы изменений включают: изменение размера, атрибутов, параметров безопасности, времени последней записи и времени последнего доступа.</summary>
		// Token: 0x04001700 RID: 5888
		Changed = 4,
		/// <summary>Создание файла или папки.</summary>
		// Token: 0x04001701 RID: 5889
		Created = 1,
		/// <summary>Удаление файла или папки.</summary>
		// Token: 0x04001702 RID: 5890
		Deleted = 2,
		/// <summary>Переименование файла или папки.</summary>
		// Token: 0x04001703 RID: 5891
		Renamed = 8
	}
}
