using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.TYPEFLAGS" />.</summary>
	// Token: 0x02000722 RID: 1826
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.TYPEFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Flags]
	[Serializable]
	public enum TYPEFLAGS : short
	{
		/// <summary>Описание типа, которое описывает объект приложения.</summary>
		// Token: 0x04002B18 RID: 11032
		TYPEFLAG_FAPPOBJECT = 1,
		/// <summary>Экземпляры этого типа могут быть созданы при помощи <see langword="ITypeInfo::CreateInstance" />.</summary>
		// Token: 0x04002B19 RID: 11033
		TYPEFLAG_FCANCREATE = 2,
		/// <summary>Этот тип лицензирован.</summary>
		// Token: 0x04002B1A RID: 11034
		TYPEFLAG_FLICENSED = 4,
		/// <summary>Этот тип определен заранее. Клиентское приложение должно автоматически создать единственный экземпляр объекта с данным атрибутом. Имя переменной, указывающей на данный объект, совпадает с именем класса объекта.</summary>
		// Token: 0x04002B1B RID: 11035
		TYPEFLAG_FPREDECLID = 8,
		/// <summary>Этот тип не должен отображаться для браузеров.</summary>
		// Token: 0x04002B1C RID: 11036
		TYPEFLAG_FHIDDEN = 16,
		/// <summary>Этот тип является элементом управления, из которого производятся другие типы. Он не должен отображаться для пользователей.</summary>
		// Token: 0x04002B1D RID: 11037
		TYPEFLAG_FCONTROL = 32,
		/// <summary>Интерфейс поддерживает и <see langword="IDispatch" />, и привязку VTBL.</summary>
		// Token: 0x04002B1E RID: 11038
		TYPEFLAG_FDUAL = 64,
		/// <summary>Интерфейс не может добавлять члены в процессе выполнения.</summary>
		// Token: 0x04002B1F RID: 11039
		TYPEFLAG_FNONEXTENSIBLE = 128,
		/// <summary>Типы, используемые в данном интерфейсе, полностью совместимы с автоматизацией, включая поддержку привязки VTBL. Задание двойного интерфейса устанавливает этот флаг в добавление к флагам <see cref="F:System.Runtime.InteropServices.TYPEFLAGS.TYPEFLAG_FDUAL" />. Недопустимо для диспетчерских интерфейсов.</summary>
		// Token: 0x04002B20 RID: 11040
		TYPEFLAG_FOLEAUTOMATION = 256,
		/// <summary>Следует исключить доступность из макроязыков. Этот флаг предназначен для типов уровня системы или типов, которые не должны отображаться обозревателями типов.</summary>
		// Token: 0x04002B21 RID: 11041
		TYPEFLAG_FRESTRICTED = 512,
		/// <summary>Класс поддерживает агрегирование.</summary>
		// Token: 0x04002B22 RID: 11042
		TYPEFLAG_FAGGREGATABLE = 1024,
		/// <summary>Объект поддерживает <see langword="IConnectionPointWithDefault" />, и для него задано поведение по умолчанию.</summary>
		// Token: 0x04002B23 RID: 11043
		TYPEFLAG_FREPLACEABLE = 2048,
		/// <summary>Показывает, что интерфейс является производным от <see langword="IDispatch" />, прямо или косвенно. Этот флаг вычисляется: для него не существует языка описания объекта.</summary>
		// Token: 0x04002B24 RID: 11044
		TYPEFLAG_FDISPATCHABLE = 4096,
		/// <summary>Показывает, что расширения имен основных интерфейсов должны проверяться перед проверкой дочерних элементов, в отличие от поведения по умолчанию.</summary>
		// Token: 0x04002B25 RID: 11045
		TYPEFLAG_FREVERSEBIND = 8192,
		/// <summary>Показывает, что интерфейс будет использовать динамическую библиотеку заглушки/прокси-сервера. Этот флаг показывает, что, если регистрация библиотеки типов удалена, не следует удалять регистрацию для прокси-сервера библиотеки типов.</summary>
		// Token: 0x04002B26 RID: 11046
		TYPEFLAG_FPROXY = 16384
	}
}
