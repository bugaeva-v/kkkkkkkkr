using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.FUNCDESC" />.</summary>
	// Token: 0x02000725 RID: 1829
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.FUNCDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	public struct FUNCDESC
	{
		/// <summary>Определяет идентификатор члена функции.</summary>
		// Token: 0x04002B3F RID: 11071
		public int memid;

		/// <summary>Хранит число ошибок, которое функция может возвратить в 16-разрядной системе.</summary>
		// Token: 0x04002B40 RID: 11072
		public IntPtr lprgscode;

		/// <summary>Показывает размер <see cref="F:System.Runtime.InteropServices.FUNCDESC.cParams" />.</summary>
		// Token: 0x04002B41 RID: 11073
		public IntPtr lprgelemdescParam;

		/// <summary>Показывает, является функция виртуальной, статической или диспетчерской.</summary>
		// Token: 0x04002B42 RID: 11074
		public FUNCKIND funckind;

		/// <summary>Задает тип функции свойства.</summary>
		// Token: 0x04002B43 RID: 11075
		public INVOKEKIND invkind;

		/// <summary>Определяет для функции соглашение о вызове.</summary>
		// Token: 0x04002B44 RID: 11076
		public CALLCONV callconv;

		/// <summary>Подсчитывает полное число параметров.</summary>
		// Token: 0x04002B45 RID: 11077
		public short cParams;

		/// <summary>Подсчитывает число дополнительных параметров.</summary>
		// Token: 0x04002B46 RID: 11078
		public short cParamsOpt;

		/// <summary>Определяет смещение в VTBL для <see cref="F:System.Runtime.InteropServices.FUNCKIND.FUNC_VIRTUAL" />.</summary>
		// Token: 0x04002B47 RID: 11079
		public short oVft;

		/// <summary>Подсчитывает число разрешенных возвращенных значений.</summary>
		// Token: 0x04002B48 RID: 11080
		public short cScodes;

		/// <summary>Содержит возвращаемый функцией тип.</summary>
		// Token: 0x04002B49 RID: 11081
		public ELEMDESC elemdescFunc;

		/// <summary>Показывает флаги <see cref="T:System.Runtime.InteropServices.FUNCFLAGS" /> функции.</summary>
		// Token: 0x04002B4A RID: 11082
		public short wFuncFlags;
	}
}
