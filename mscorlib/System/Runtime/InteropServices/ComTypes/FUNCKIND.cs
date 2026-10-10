using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет способ доступа к функции.</summary>
	// Token: 0x020007C4 RID: 1988
	[Serializable]
	public enum FUNCKIND
	{
		/// <summary>Функция доступна таким же образом, как и <see cref="F:System.Runtime.InteropServices.FUNCKIND.FUNC_PUREVIRTUAL" />, за исключением того, что для этой функции существует реализация.</summary>
		// Token: 0x04002CD2 RID: 11474
		FUNC_VIRTUAL,
		/// <summary>Функция доступна при помощи таблицы виртуальных функций (VTBL) и принимает неявный указатель <see langword="this" />.</summary>
		// Token: 0x04002CD3 RID: 11475
		FUNC_PUREVIRTUAL,
		/// <summary>Функция доступна по статическому (<see langword="static" />) адресу и принимает неявный указатель <see langword="this" />.</summary>
		// Token: 0x04002CD4 RID: 11476
		FUNC_NONVIRTUAL,
		/// <summary>Функция доступна по статическому (<see langword="static" />) адресу и не принимает неявный указатель <see langword="this" />.</summary>
		// Token: 0x04002CD5 RID: 11477
		FUNC_STATIC,
		/// <summary>Доступ к функции может быть получен только при помощи <see langword="IDispatch" />.</summary>
		// Token: 0x04002CD6 RID: 11478
		FUNC_DISPATCH
	}
}
