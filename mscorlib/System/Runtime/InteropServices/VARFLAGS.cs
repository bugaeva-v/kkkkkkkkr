using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.VARFLAGS" />.</summary>
	// Token: 0x02000735 RID: 1845
	[Flags]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.VARFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Serializable]
	public enum VARFLAGS : short
	{
		/// <summary>Не следует разрешать присвоение значений этой переменной.</summary>
		// Token: 0x04002B9C RID: 11164
		VARFLAG_FREADONLY = 1,
		/// <summary>Переменная возвращает объект, являющийся источником событий.</summary>
		// Token: 0x04002B9D RID: 11165
		VARFLAG_FSOURCE = 2,
		/// <summary>Переменная поддерживает привязку данных.</summary>
		// Token: 0x04002B9E RID: 11166
		VARFLAG_FBINDABLE = 4,
		/// <summary>При установке все попытки прямого изменения свойства приводят к вызову <see langword="IPropertyNotifySink::OnRequestEdit" />. Реализация <see langword="OnRequestEdit" /> определяет, принято ли изменение.</summary>
		// Token: 0x04002B9F RID: 11167
		VARFLAG_FREQUESTEDIT = 8,
		/// <summary>Переменная, отображаемая пользователю как связываемая. <see cref="F:System.Runtime.InteropServices.VARFLAGS.VARFLAG_FBINDABLE" /> также следует задать.</summary>
		// Token: 0x04002BA0 RID: 11168
		VARFLAG_FDISPLAYBIND = 16,
		/// <summary>Переменная является единственным свойством, представляющим объект наилучшим образом. Только одна переменная в сведениях о типе может содержать этот атрибут.</summary>
		// Token: 0x04002BA1 RID: 11169
		VARFLAG_FDEFAULTBIND = 32,
		/// <summary>Эту переменную не следует показывать пользователю в браузере, хотя она существует и является связываемой.</summary>
		// Token: 0x04002BA2 RID: 11170
		VARFLAG_FHIDDEN = 64,
		/// <summary>Переменную следует сделать недоступной из макроязыков. Этот флаг предназначен для переменных уровня системы или для переменных, которые не нужно отображать в обозревателях типов.</summary>
		// Token: 0x04002BA3 RID: 11171
		VARFLAG_FRESTRICTED = 128,
		/// <summary>Допускает оптимизацию, в процессе которой компилятор ищет элемент с именем xyz типа abc. Если такой элемент обнаружен и помечен как функция доступа к элементу коллекции, заданной по умолчанию, то создается вызов этой функции-элемента. Разрешается для членов диспетчерских и обычных интерфейсов, но запрещен для модулей.</summary>
		// Token: 0x04002BA4 RID: 11172
		VARFLAG_FDEFAULTCOLLELEM = 256,
		/// <summary>Переменная отображается по умолчанию в пользовательском интерфейсе.</summary>
		// Token: 0x04002BA5 RID: 11173
		VARFLAG_FUIDEFAULT = 512,
		/// <summary>Переменная появляется в обозревателе объектов, но не отображается в обозревателе свойств.</summary>
		// Token: 0x04002BA6 RID: 11174
		VARFLAG_FNONBROWSABLE = 1024,
		/// <summary>Помечает интерфейс как обладающий заданным по умолчанию поведением.</summary>
		// Token: 0x04002BA7 RID: 11175
		VARFLAG_FREPLACEABLE = 2048,
		/// <summary>Переменная сопоставляется так же, как собственные связываемые свойства.</summary>
		// Token: 0x04002BA8 RID: 11176
		VARFLAG_FIMMEDIATEBIND = 4096
	}
}
