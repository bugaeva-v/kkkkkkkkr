using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.TYPEKIND" />.</summary>
	// Token: 0x02000721 RID: 1825
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.TYPEKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Serializable]
	public enum TYPEKIND
	{
		/// <summary>Набор перечислителей.</summary>
		// Token: 0x04002B0E RID: 11022
		TKIND_ENUM,
		/// <summary>Структура без методов.</summary>
		// Token: 0x04002B0F RID: 11023
		TKIND_RECORD,
		/// <summary>Модуль, который может содержать только статические функции и данные (например, динамическая библиотека DLL).</summary>
		// Token: 0x04002B10 RID: 11024
		TKIND_MODULE,
		/// <summary>Тип, содержащий виртуальные функции, каждая из которых — чистая.</summary>
		// Token: 0x04002B11 RID: 11025
		TKIND_INTERFACE,
		/// <summary>Набор методов и свойств, доступных с помощью <see langword="IDispatch::Invoke" />. По умолчанию двойные интерфейсы возвращают значение <see langword="TKIND_DISPATCH" />.</summary>
		// Token: 0x04002B12 RID: 11026
		TKIND_DISPATCH,
		/// <summary>Набор реализованных интерфейсов компонентов.</summary>
		// Token: 0x04002B13 RID: 11027
		TKIND_COCLASS,
		/// <summary>Тип, являющийся псевдонимом для другого типа.</summary>
		// Token: 0x04002B14 RID: 11028
		TKIND_ALIAS,
		/// <summary>Объединение всех методов, смещение которых равно нулю.</summary>
		// Token: 0x04002B15 RID: 11029
		TKIND_UNION,
		/// <summary>Конец маркера перечисления.</summary>
		// Token: 0x04002B16 RID: 11030
		TKIND_MAX
	}
}
