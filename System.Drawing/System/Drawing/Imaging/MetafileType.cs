using System;

namespace System.Drawing.Imaging
{
	/// <summary>Указывает типы метафайлов. Свойство <see cref="P:System.Drawing.Imaging.MetafileHeader.Type" /> возвращает члена данного перечисления.</summary>
	// Token: 0x02000110 RID: 272
	public enum MetafileType
	{
		/// <summary>Указывает, что формат метафайла не распознается в GDI+.</summary>
		// Token: 0x04000A15 RID: 2581
		Invalid,
		/// <summary>Указывает WMF-файл (Windows Metafile). Такой файл содержит только записи GDI.</summary>
		// Token: 0x04000A16 RID: 2582
		Wmf,
		/// <summary>Указывает WMF-файл (Windows Metafile), имеющий заголовок размещаемого метафайла.</summary>
		// Token: 0x04000A17 RID: 2583
		WmfPlaceable,
		/// <summary>Указывает EMF-файл. Такой файл содержит только записи GDI.</summary>
		// Token: 0x04000A18 RID: 2584
		Emf,
		/// <summary>Указывает файл EMF+. Такой файл содержит только записи GDI+ и должен отображаться с помощью GDI+. Отображение записей с помощью GDI может привести к непредсказуемым результатам.</summary>
		// Token: 0x04000A19 RID: 2585
		EmfPlusOnly,
		/// <summary>Указывает файл EMF+ Dual. Такой файл содержит кроме записей GDI+ также и альтернативные записи GDI и может быть отображен как с помощью GDI, так и с помощью GDI+. Отображение записей при помощи GDI может вызвать некоторые потери качества.</summary>
		// Token: 0x04000A1A RID: 2586
		EmfPlusDual
	}
}
