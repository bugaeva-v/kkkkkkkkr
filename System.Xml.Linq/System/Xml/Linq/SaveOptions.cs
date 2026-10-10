using System;

namespace System.Xml.Linq
{
	/// <summary>Указывает параметры сериализации.</summary>
	// Token: 0x0200004B RID: 75
	[Flags]
	public enum SaveOptions
	{
		/// <summary>Форматирование (отступ) XML при сериализации.</summary>
		// Token: 0x0400017C RID: 380
		None = 0,
		/// <summary>Сохранение всех незначительных пробелов при сериализации.</summary>
		// Token: 0x0400017D RID: 381
		DisableFormatting = 1,
		/// <summary>Удаление дубликатов объявлений пространств имен при сериализации.</summary>
		// Token: 0x0400017E RID: 382
		OmitDuplicateNamespaces = 2
	}
}
