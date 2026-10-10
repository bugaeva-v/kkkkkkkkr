using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Описывает исходные параметры флагов <see cref="T:System.Runtime.InteropServices.TYPEFLAGS" /> в библиотеке типов COM, из которой был импортирован данный тип.</summary>
	// Token: 0x020006F6 RID: 1782
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum TypeLibTypeFlags
	{
		/// <summary>Описание типа, описывающее объект <see langword="Application" />.</summary>
		// Token: 0x04002A46 RID: 10822
		FAppObject = 1,
		/// <summary>Экземпляры этого типа могут быть созданы при помощи <see langword="ITypeInfo::CreateInstance" />.</summary>
		// Token: 0x04002A47 RID: 10823
		FCanCreate = 2,
		/// <summary>Этот тип лицензирован.</summary>
		// Token: 0x04002A48 RID: 10824
		FLicensed = 4,
		/// <summary>Этот тип определен заранее. Клиентское приложение должно автоматически создать единственный экземпляр объекта с данным атрибутом. Имя переменной, указывающей на данный объект, совпадает с именем класса объекта.</summary>
		// Token: 0x04002A49 RID: 10825
		FPreDeclId = 8,
		/// <summary>Этот тип не должен отображаться для браузеров.</summary>
		// Token: 0x04002A4A RID: 10826
		FHidden = 16,
		/// <summary>Этот тип является элементом управления, из которого производятся другие типы. Он не должен отображаться для пользователей.</summary>
		// Token: 0x04002A4B RID: 10827
		FControl = 32,
		/// <summary>Интерфейс поддерживает и <see langword="IDispatch" />, и привязку v-таблицы.</summary>
		// Token: 0x04002A4C RID: 10828
		FDual = 64,
		/// <summary>Интерфейс не может добавлять члены в процессе выполнения.</summary>
		// Token: 0x04002A4D RID: 10829
		FNonExtensible = 128,
		/// <summary>Типы, используемые в данном интерфейсе полностью совместимы с Automation, включая поддержку привязки v-таблицы.</summary>
		// Token: 0x04002A4E RID: 10830
		FOleAutomation = 256,
		/// <summary>Этот флаг предназначен для типов уровня системы или типов, которые не должны отображаться обозревателями типов.</summary>
		// Token: 0x04002A4F RID: 10831
		FRestricted = 512,
		/// <summary>Класс поддерживает агрегирование.</summary>
		// Token: 0x04002A50 RID: 10832
		FAggregatable = 1024,
		/// <summary>Объект поддерживает <see langword="IConnectionPointWithDefault" />, и для него задано поведение по умолчанию.</summary>
		// Token: 0x04002A51 RID: 10833
		FReplaceable = 2048,
		/// <summary>Показывает, что интерфейс является производным от <see langword="IDispatch" />, прямо или косвенно.</summary>
		// Token: 0x04002A52 RID: 10834
		FDispatchable = 4096,
		/// <summary>Показывает, что расширения имен основных интерфейсов должны проверяться до проверки дочерних интерфейсов. Этот порядок проверки является обратным относительно поведения по умолчанию.</summary>
		// Token: 0x04002A53 RID: 10835
		FReverseBind = 8192
	}
}
