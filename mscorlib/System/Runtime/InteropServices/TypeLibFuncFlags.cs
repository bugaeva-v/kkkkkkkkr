using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Описывает исходные параметры <see langword="FUNCFLAGS" /> в библиотеке типов COM, из которой был импортирован данный метод.</summary>
	// Token: 0x020006F7 RID: 1783
	[Flags]
	[ComVisible(true)]
	[Serializable]
	public enum TypeLibFuncFlags
	{
		/// <summary>Этот флаг предназначен для функций системного уровня или функций, которые не должны отображаться обозревателями типов.</summary>
		// Token: 0x04002A55 RID: 10837
		FRestricted = 1,
		/// <summary>Функция возвращает объект, являющийся источником событий.</summary>
		// Token: 0x04002A56 RID: 10838
		FSource = 2,
		/// <summary>Функция, поддерживающая привязку данных.</summary>
		// Token: 0x04002A57 RID: 10839
		FBindable = 4,
		/// <summary>Если задано, любой вызов метод, задающего это свойство, сначала приводит к вызову <see langword="IPropertyNotifySink::OnRequestEdit" />.</summary>
		// Token: 0x04002A58 RID: 10840
		FRequestEdit = 8,
		/// <summary>Функция, отображаемая пользователю как связываемая. <see cref="F:System.Runtime.InteropServices.TypeLibFuncFlags.FBindable" /> также следует задать.</summary>
		// Token: 0x04002A59 RID: 10841
		FDisplayBind = 16,
		/// <summary>Функция, предоставляющая объект наилучшим образом. Этот атрибут в сведениях о типе может быть только у одной функции.</summary>
		// Token: 0x04002A5A RID: 10842
		FDefaultBind = 32,
		/// <summary>Эту функцию не следует показывать пользователю, хотя она существует и является связываемой.</summary>
		// Token: 0x04002A5B RID: 10843
		FHidden = 64,
		/// <summary>Функция поддерживает <see langword="GetLastError" />.</summary>
		// Token: 0x04002A5C RID: 10844
		FUsesGetLastError = 128,
		/// <summary>Допускает оптимизацию, в процессе которой компилятор ищет элемент с именем xyz типа abc. Если такой элемент обнаружен и помечен как функция доступа к элементу коллекции, заданной по умолчанию, то создается вызов этой функции-элемента.</summary>
		// Token: 0x04002A5D RID: 10845
		FDefaultCollelem = 256,
		/// <summary>Член сведений о типе является членом по умолчанию для отображения в пользовательском интерфейсе.</summary>
		// Token: 0x04002A5E RID: 10846
		FUiDefault = 512,
		/// <summary>Это свойство отображается в обозревателе объектов и не отображается в обозревателе свойств.</summary>
		// Token: 0x04002A5F RID: 10847
		FNonBrowsable = 1024,
		/// <summary>Помечает интерфейс как обладающий заданным по умолчанию поведением.</summary>
		// Token: 0x04002A60 RID: 10848
		FReplaceable = 2048,
		/// <summary>Функция сопоставляется так же, как отдельные связываемые свойства.</summary>
		// Token: 0x04002A61 RID: 10849
		FImmediateBind = 4096
	}
}
