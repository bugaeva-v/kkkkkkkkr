using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.FUNCFLAGS" />.</summary>
	// Token: 0x02000734 RID: 1844
	[Flags]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.FUNCFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Serializable]
	public enum FUNCFLAGS : short
	{
		/// <summary>Функция не должна быть доступной для макроязыков. Этот флаг предназначен для функций системного уровня или функций, которые не должны отображаться обозревателями типов.</summary>
		// Token: 0x04002B8E RID: 11150
		FUNCFLAG_FRESTRICTED = 1,
		/// <summary>Функция возвращает объект, являющийся источником событий.</summary>
		// Token: 0x04002B8F RID: 11151
		FUNCFLAG_FSOURCE = 2,
		/// <summary>Функция, поддерживающая привязку данных.</summary>
		// Token: 0x04002B90 RID: 11152
		FUNCFLAG_FBINDABLE = 4,
		/// <summary>Если задано, любой вызов метод, задающего это свойство, сначала приводит к вызову <see langword="IPropertyNotifySink::OnRequestEdit" />. Реализация <see langword="OnRequestEdit" /> определяет, разрешено ли вызову задавать данное свойство.</summary>
		// Token: 0x04002B91 RID: 11153
		FUNCFLAG_FREQUESTEDIT = 8,
		/// <summary>Функция, отображаемая пользователю как связываемая. <see cref="F:System.Runtime.InteropServices.FUNCFLAGS.FUNCFLAG_FBINDABLE" /> также следует задать.</summary>
		// Token: 0x04002B92 RID: 11154
		FUNCFLAG_FDISPLAYBIND = 16,
		/// <summary>Функция, предоставляющая объект наилучшим образом. Этот атрибут в сведениях о типе может быть только у одной функции.</summary>
		// Token: 0x04002B93 RID: 11155
		FUNCFLAG_FDEFAULTBIND = 32,
		/// <summary>Эту функцию не следует показывать пользователю, хотя она существует и является связываемой.</summary>
		// Token: 0x04002B94 RID: 11156
		FUNCFLAG_FHIDDEN = 64,
		/// <summary>Функция поддерживает <see langword="GetLastError" />. Если в процессе выполнения функции возникает ошибка, вызывающий объект может вызвать <see langword="GetLastError" />, чтобы извлечь код ошибки.</summary>
		// Token: 0x04002B95 RID: 11157
		FUNCFLAG_FUSESGETLASTERROR = 128,
		/// <summary>Допускает оптимизацию, в процессе которой компилятор ищет элемент с именем xyz типа abc. Если такой член обнаружен и помечен как функция доступа к элементу коллекции, заданной по умолчанию, то создается вызов этой функции-члена. Разрешается для членов диспетчерских и обычных интерфейсов, но запрещен для модулей.</summary>
		// Token: 0x04002B96 RID: 11158
		FUNCFLAG_FDEFAULTCOLLELEM = 256,
		/// <summary>Член сведений о типе является членом по умолчанию для отображения в пользовательском интерфейсе.</summary>
		// Token: 0x04002B97 RID: 11159
		FUNCFLAG_FUIDEFAULT = 512,
		/// <summary>Это свойство отображается в обозревателе объектов и не отображается в обозревателе свойств.</summary>
		// Token: 0x04002B98 RID: 11160
		FUNCFLAG_FNONBROWSABLE = 1024,
		/// <summary>Помечает интерфейс как обладающий заданным по умолчанию поведением.</summary>
		// Token: 0x04002B99 RID: 11161
		FUNCFLAG_FREPLACEABLE = 2048,
		/// <summary>Отображаются как отдельные связываемые свойства.</summary>
		// Token: 0x04002B9A RID: 11162
		FUNCFLAG_FIMMEDIATEBIND = 4096
	}
}
