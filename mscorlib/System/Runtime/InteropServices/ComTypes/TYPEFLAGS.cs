using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет свойства и атрибуты описания типа.</summary>
	// Token: 0x020007B4 RID: 1972
	[Flags]
	[Serializable]
	public enum TYPEFLAGS : short
	{
		/// <summary>Описание типа, описывающее объект <see langword="Application" />.</summary>
		// Token: 0x04002C6B RID: 11371
		TYPEFLAG_FAPPOBJECT = 1,
		/// <summary>Экземпляры этого типа могут быть созданы при помощи <see langword="ITypeInfo::CreateInstance" />.</summary>
		// Token: 0x04002C6C RID: 11372
		TYPEFLAG_FCANCREATE = 2,
		/// <summary>Этот тип лицензирован.</summary>
		// Token: 0x04002C6D RID: 11373
		TYPEFLAG_FLICENSED = 4,
		/// <summary>Этот тип определен заранее. Клиентское приложение должно автоматически создать единственный экземпляр объекта с данным атрибутом. Имя переменной, указывающей на данный объект, совпадает с именем класса объекта.</summary>
		// Token: 0x04002C6E RID: 11374
		TYPEFLAG_FPREDECLID = 8,
		/// <summary>Этот тип не должен отображаться для браузеров.</summary>
		// Token: 0x04002C6F RID: 11375
		TYPEFLAG_FHIDDEN = 16,
		/// <summary>Этот тип является элементом управления, из которого производятся другие типы. Он не должен отображаться для пользователей.</summary>
		// Token: 0x04002C70 RID: 11376
		TYPEFLAG_FCONTROL = 32,
		/// <summary>Интерфейс поддерживает и <see langword="IDispatch" />, и привязку VTBL.</summary>
		// Token: 0x04002C71 RID: 11377
		TYPEFLAG_FDUAL = 64,
		/// <summary>Интерфейс не может добавлять члены в процессе выполнения.</summary>
		// Token: 0x04002C72 RID: 11378
		TYPEFLAG_FNONEXTENSIBLE = 128,
		/// <summary>Типы, используемые в данном интерфейсе, полностью совместимы с автоматизацией, включая поддержку привязки VTBL. Установка двойного интерфейса задает и этот флаг, и <see cref="F:System.Runtime.InteropServices.TYPEFLAGS.TYPEFLAG_FDUAL" />. Этот флаг не разрешен на диспетчерских интерфейсах.</summary>
		// Token: 0x04002C73 RID: 11379
		TYPEFLAG_FOLEAUTOMATION = 256,
		/// <summary>Следует исключить доступность из макроязыков. Этот флаг предназначен для типов уровня системы или типов, которые не должны отображаться обозревателями типов.</summary>
		// Token: 0x04002C74 RID: 11380
		TYPEFLAG_FRESTRICTED = 512,
		/// <summary>Класс поддерживает агрегирование.</summary>
		// Token: 0x04002C75 RID: 11381
		TYPEFLAG_FAGGREGATABLE = 1024,
		/// <summary>Объект поддерживает <see langword="IConnectionPointWithDefault" />, и для него задано поведение по умолчанию.</summary>
		// Token: 0x04002C76 RID: 11382
		TYPEFLAG_FREPLACEABLE = 2048,
		/// <summary>Показывает, что интерфейс является производным от <see langword="IDispatch" />, прямо или косвенно. Этот флаг вычисляется: для него не существует языка описания объекта.</summary>
		// Token: 0x04002C77 RID: 11383
		TYPEFLAG_FDISPATCHABLE = 4096,
		/// <summary>Показывает, что расширения имен основных интерфейсов должны проверяться перед проверкой дочерних элементов, в отличие от поведения по умолчанию.</summary>
		// Token: 0x04002C78 RID: 11384
		TYPEFLAG_FREVERSEBIND = 8192,
		/// <summary>Показывает, что интерфейс будет использовать динамическую библиотеку заглушки/прокси-сервера. Этот флаг показывает, что, если регистрация библиотеки типов удалена, не следует удалять регистрацию для прокси-сервера библиотеки типов.</summary>
		// Token: 0x04002C79 RID: 11385
		TYPEFLAG_FPROXY = 16384
	}
}
