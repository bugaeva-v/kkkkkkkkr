using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.FUNCKIND" />.</summary>
	// Token: 0x02000731 RID: 1841
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.FUNCKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Serializable]
	public enum FUNCKIND
	{
		/// <summary>Функция доступна так же, как и <see cref="F:System.Runtime.InteropServices.FUNCKIND.FUNC_PUREVIRTUAL" />, за исключением того, что для этой функции существует реализация.</summary>
		// Token: 0x04002B78 RID: 11128
		FUNC_VIRTUAL,
		/// <summary>Функция доступна при помощи таблицы виртуальных функций (VTBL) и принимает неявный указатель <see langword="this" />.</summary>
		// Token: 0x04002B79 RID: 11129
		FUNC_PUREVIRTUAL,
		/// <summary>Функция доступна по статическому (<see langword="static" />) адресу и принимает неявный указатель <see langword="this" />.</summary>
		// Token: 0x04002B7A RID: 11130
		FUNC_NONVIRTUAL,
		/// <summary>Функция доступна по статическому (<see langword="static" />) адресу и не принимает неявный указатель <see langword="this" />.</summary>
		// Token: 0x04002B7B RID: 11131
		FUNC_STATIC,
		/// <summary>Доступ к функции может быть получен только при помощи <see langword="IDispatch" />.</summary>
		// Token: 0x04002B7C RID: 11132
		FUNC_DISPATCH
	}
}
