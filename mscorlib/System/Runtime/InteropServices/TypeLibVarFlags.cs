using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Описывает исходные параметры <see cref="T:System.Runtime.InteropServices.VARFLAGS" /> в библиотеке COM-типов, из которой была импортирована эта переменная.</summary>
	// Token: 0x020006F8 RID: 1784
	[Flags]
	[ComVisible(true)]
	[Serializable]
	public enum TypeLibVarFlags
	{
		/// <summary>Не следует разрешать присвоение значений этой переменной.</summary>
		// Token: 0x04002A63 RID: 10851
		FReadOnly = 1,
		/// <summary>Переменная возвращает объект, являющийся источником событий.</summary>
		// Token: 0x04002A64 RID: 10852
		FSource = 2,
		/// <summary>Переменная поддерживает привязку данных.</summary>
		// Token: 0x04002A65 RID: 10853
		FBindable = 4,
		/// <summary>Показывает, что свойство поддерживает уведомление COM <see langword="OnRequestEdit" />.</summary>
		// Token: 0x04002A66 RID: 10854
		FRequestEdit = 8,
		/// <summary>Переменная отображается как связываемая. <see cref="F:System.Runtime.InteropServices.TypeLibVarFlags.FBindable" /> также следует задать.</summary>
		// Token: 0x04002A67 RID: 10855
		FDisplayBind = 16,
		/// <summary>Переменная является единственным свойством, представляющим объект наилучшим образом. Только одна переменная в сведениях о типе может иметь это значение.</summary>
		// Token: 0x04002A68 RID: 10856
		FDefaultBind = 32,
		/// <summary>Не следует отображать ту переменную в браузере, даже если она существует и является связываемой.</summary>
		// Token: 0x04002A69 RID: 10857
		FHidden = 64,
		/// <summary>Этот флаг предназначен для функций системного уровня или функций, которые не должны отображаться обозревателями типов.</summary>
		// Token: 0x04002A6A RID: 10858
		FRestricted = 128,
		/// <summary>Допускает оптимизацию, в процессе которой компилятор ищет элемент с именем xyz типа abc. Если такой элемент обнаружен и помечен как функция доступа к элементу коллекции, заданной по умолчанию, то создается вызов этой функции-элемента.</summary>
		// Token: 0x04002A6B RID: 10859
		FDefaultCollelem = 256,
		/// <summary>Отображение по умолчанию в интерфейсе пользователя.</summary>
		// Token: 0x04002A6C RID: 10860
		FUiDefault = 512,
		/// <summary>Переменная появляется в обозревателе объектов, но не отображается в обозревателе свойств.</summary>
		// Token: 0x04002A6D RID: 10861
		FNonBrowsable = 1024,
		/// <summary>Помечает интерфейс как обладающий заданным по умолчанию поведением.</summary>
		// Token: 0x04002A6E RID: 10862
		FReplaceable = 2048,
		/// <summary>Переменная сопоставляется так же, как собственные связываемые свойства.</summary>
		// Token: 0x04002A6F RID: 10863
		FImmediateBind = 4096
	}
}
