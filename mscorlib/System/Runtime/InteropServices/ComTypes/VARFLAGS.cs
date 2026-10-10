using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Указывает константы, определяющие свойства переменной.</summary>
	// Token: 0x020007C8 RID: 1992
	[Flags]
	[Serializable]
	public enum VARFLAGS : short
	{
		/// <summary>Не следует разрешать присвоение значений этой переменной.</summary>
		// Token: 0x04002CF6 RID: 11510
		VARFLAG_FREADONLY = 1,
		/// <summary>Переменная возвращает объект, являющийся источником событий.</summary>
		// Token: 0x04002CF7 RID: 11511
		VARFLAG_FSOURCE = 2,
		/// <summary>Переменная поддерживает привязку данных.</summary>
		// Token: 0x04002CF8 RID: 11512
		VARFLAG_FBINDABLE = 4,
		/// <summary>При установке все попытки прямого изменения свойства приводят к вызову <see langword="IPropertyNotifySink::OnRequestEdit" />. Реализация <see langword="OnRequestEdit" /> определяет, принято ли изменение.</summary>
		// Token: 0x04002CF9 RID: 11513
		VARFLAG_FREQUESTEDIT = 8,
		/// <summary>Переменная, отображаемая пользователю как связываемая. <see cref="F:System.Runtime.InteropServices.VARFLAGS.VARFLAG_FBINDABLE" /> также следует задать.</summary>
		// Token: 0x04002CFA RID: 11514
		VARFLAG_FDISPLAYBIND = 16,
		/// <summary>Переменная является единственным свойством, представляющим объект наилучшим образом. Только одна переменная в сведениях о типе может содержать этот атрибут.</summary>
		// Token: 0x04002CFB RID: 11515
		VARFLAG_FDEFAULTBIND = 32,
		/// <summary>Эту переменную не следует показывать пользователю в браузере, хотя она существует и является связываемой.</summary>
		// Token: 0x04002CFC RID: 11516
		VARFLAG_FHIDDEN = 64,
		/// <summary>Переменную следует сделать недоступной из макроязыков. Этот флаг предназначен для переменных уровня системы или для переменных, которые не нужно отображать в обозревателях типов.</summary>
		// Token: 0x04002CFD RID: 11517
		VARFLAG_FRESTRICTED = 128,
		/// <summary>Допускает оптимизацию, в процессе которой компилятор ищет элемент с именем xyz типа abc. Если такой элемент обнаружен и помечен как функция доступа к элементу коллекции, заданной по умолчанию, то создается вызов этой функции-элемента. Разрешается для членов диспетчерских и обычных интерфейсов, но запрещен для модулей.</summary>
		// Token: 0x04002CFE RID: 11518
		VARFLAG_FDEFAULTCOLLELEM = 256,
		/// <summary>Переменная отображается по умолчанию в пользовательском интерфейсе.</summary>
		// Token: 0x04002CFF RID: 11519
		VARFLAG_FUIDEFAULT = 512,
		/// <summary>Переменная появляется в обозревателе объектов, но не отображается в обозревателе свойств.</summary>
		// Token: 0x04002D00 RID: 11520
		VARFLAG_FNONBROWSABLE = 1024,
		/// <summary>Помечает интерфейс как обладающий заданным по умолчанию поведением.</summary>
		// Token: 0x04002D01 RID: 11521
		VARFLAG_FREPLACEABLE = 2048,
		/// <summary>Переменная сопоставляется так же, как собственные связываемые свойства.</summary>
		// Token: 0x04002D02 RID: 11522
		VARFLAG_FIMMEDIATEBIND = 4096
	}
}
