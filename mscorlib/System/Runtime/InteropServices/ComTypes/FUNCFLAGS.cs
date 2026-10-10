using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Указывает константы, определяющие свойства функции.</summary>
	// Token: 0x020007C7 RID: 1991
	[Flags]
	[Serializable]
	public enum FUNCFLAGS : short
	{
		/// <summary>Функция не должна быть доступной для макроязыков. Этот флаг предназначен для функций системного уровня или функций, которые не должны отображаться обозревателями типов.</summary>
		// Token: 0x04002CE8 RID: 11496
		FUNCFLAG_FRESTRICTED = 1,
		/// <summary>Функция возвращает объект, являющийся источником событий.</summary>
		// Token: 0x04002CE9 RID: 11497
		FUNCFLAG_FSOURCE = 2,
		/// <summary>Функция, поддерживающая привязку данных.</summary>
		// Token: 0x04002CEA RID: 11498
		FUNCFLAG_FBINDABLE = 4,
		/// <summary>Если задано, любой вызов метод, задающего это свойство, сначала приводит к вызову <see langword="IPropertyNotifySink::OnRequestEdit" />. Реализация <see langword="OnRequestEdit" /> определяет, разрешено ли вызову задавать данное свойство.</summary>
		// Token: 0x04002CEB RID: 11499
		FUNCFLAG_FREQUESTEDIT = 8,
		/// <summary>Функция, отображаемая пользователю как связываемая. <see cref="F:System.Runtime.InteropServices.FUNCFLAGS.FUNCFLAG_FBINDABLE" /> также следует задать.</summary>
		// Token: 0x04002CEC RID: 11500
		FUNCFLAG_FDISPLAYBIND = 16,
		/// <summary>Функция, предоставляющая объект наилучшим образом. Только одна функция в типе может содержать этот атрибут.</summary>
		// Token: 0x04002CED RID: 11501
		FUNCFLAG_FDEFAULTBIND = 32,
		/// <summary>Эту функцию не следует показывать пользователю, хотя она существует и является связываемой.</summary>
		// Token: 0x04002CEE RID: 11502
		FUNCFLAG_FHIDDEN = 64,
		/// <summary>Функция поддерживает <see langword="GetLastError" />. Если в процессе выполнения функции возникает ошибка, вызывающий объект может вызвать <see langword="GetLastError" />, чтобы извлечь код ошибки.</summary>
		// Token: 0x04002CEF RID: 11503
		FUNCFLAG_FUSESGETLASTERROR = 128,
		/// <summary>Допускает оптимизацию, в процессе которой компилятор ищет элемент с именем xyz типа abc. Если такой член обнаружен и помечен как функция доступа к элементу коллекции, заданной по умолчанию, то создается вызов этой функции-члена. Разрешается для членов диспетчерских и обычных интерфейсов, но запрещен для модулей.</summary>
		// Token: 0x04002CF0 RID: 11504
		FUNCFLAG_FDEFAULTCOLLELEM = 256,
		/// <summary>Член сведений о типе является членом по умолчанию для отображения в пользовательском интерфейсе.</summary>
		// Token: 0x04002CF1 RID: 11505
		FUNCFLAG_FUIDEFAULT = 512,
		/// <summary>Это свойство отображается в обозревателе объектов и не отображается в обозревателе свойств.</summary>
		// Token: 0x04002CF2 RID: 11506
		FUNCFLAG_FNONBROWSABLE = 1024,
		/// <summary>Помечает интерфейс как обладающий заданным по умолчанию поведением.</summary>
		// Token: 0x04002CF3 RID: 11507
		FUNCFLAG_FREPLACEABLE = 2048,
		/// <summary>Отображаются как отдельные связываемые свойства.</summary>
		// Token: 0x04002CF4 RID: 11508
		FUNCFLAG_FIMMEDIATEBIND = 4096
	}
}
