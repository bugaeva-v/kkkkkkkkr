using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Указывает различные типы данных и функций.</summary>
	// Token: 0x020007B3 RID: 1971
	[Serializable]
	public enum TYPEKIND
	{
		/// <summary>Набор перечислителей.</summary>
		// Token: 0x04002C61 RID: 11361
		TKIND_ENUM,
		/// <summary>Структура без методов.</summary>
		// Token: 0x04002C62 RID: 11362
		TKIND_RECORD,
		/// <summary>Модуль, который может содержать только статические функции и данные (например, динамическая библиотека DLL).</summary>
		// Token: 0x04002C63 RID: 11363
		TKIND_MODULE,
		/// <summary>Тип, содержащий виртуальные функции, каждая из которых — чистая.</summary>
		// Token: 0x04002C64 RID: 11364
		TKIND_INTERFACE,
		/// <summary>Набор методов и свойств, доступных с помощью <see langword="IDispatch::Invoke" />. По умолчанию двойные интерфейсы возвращают значение <see langword="TKIND_DISPATCH" />.</summary>
		// Token: 0x04002C65 RID: 11365
		TKIND_DISPATCH,
		/// <summary>Набор реализованных интерфейсов компонентов.</summary>
		// Token: 0x04002C66 RID: 11366
		TKIND_COCLASS,
		/// <summary>Тип, являющийся псевдонимом для другого типа.</summary>
		// Token: 0x04002C67 RID: 11367
		TKIND_ALIAS,
		/// <summary>Объединение всех методов, смещение которых равно нулю.</summary>
		// Token: 0x04002C68 RID: 11368
		TKIND_UNION,
		/// <summary>Метка окончания перечисления.</summary>
		// Token: 0x04002C69 RID: 11369
		TKIND_MAX
	}
}
