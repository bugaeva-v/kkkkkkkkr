using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Показывает способ создания библиотеки типов.</summary>
	// Token: 0x02000753 RID: 1875
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum TypeLibExporterFlags
	{
		/// <summary>Экспортирует ссылки на типы, импортированные из COM, как <see langword="IUnknown" />, если для типа отсутствует зарегистрированная библиотека типов. Этот флаг можно установить, если нужно, чтобы программа экспортирования библиотеки типов искала зависимые типы в реестре, а не в каталоге входной сборки.</summary>
		// Token: 0x04002C08 RID: 11272
		OnlyReferenceRegistered = 1,
		/// <summary>Не задает флагов. Это значение по умолчанию.</summary>
		// Token: 0x04002C09 RID: 11273
		None = 0,
		/// <summary>Позволяет вызывающему объекту явно разрешать ссылки библиотеки типов, не обращаясь к реестру.</summary>
		// Token: 0x04002C0A RID: 11274
		CallerResolvedReferences = 2,
		/// <summary>При экспорте библиотек типов платформа .NET Framework разрешает конфликты типов имен, дополняя тип именем пространства имен; например, <see langword="System.Windows.Forms.HorizontalAlignment" /> экспортируется как <see langword="System_Windows_Forms_HorizontalAlignment" />. Когда возникает конфликт с именем типа, не доступного из COM, платформа .NET Framework экспортирует имя без дополнения. Чтобы заставить платформу .NET Framework экспортировать дополненное имя, можно установить флаг <see cref="F:System.Runtime.InteropServices.TypeLibExporterFlags.OldNames" /> или использовать параметр <see langword="/oldnames" /> программы экспортирования библиотеки типов (Tlbexp.exe). Обратите внимание, что экспорт дополненного имени является поведением по умолчанию в версиях платформы .NET Framework, предшествующих версии 2.0.</summary>
		// Token: 0x04002C0B RID: 11275
		OldNames = 4,
		/// <summary>При компиляции на 64-разрядном компьютере определяет, что средство экспортирования библиотеки типов (Tlbexp.exe) создает 32-разрядную библиотеку типов. Все типы данных преобразовываются соответствующим образом.</summary>
		// Token: 0x04002C0C RID: 11276
		ExportAs32Bit = 16,
		/// <summary>При компиляции на 32-разрядном компьютере определяет, что средство экспорта библиотек типов (Tlbexp.exe) создает 64-разрядную библиотеку типов. Все типы данных преобразовываются соответствующим образом.</summary>
		// Token: 0x04002C0D RID: 11277
		ExportAs64Bit = 32
	}
}
