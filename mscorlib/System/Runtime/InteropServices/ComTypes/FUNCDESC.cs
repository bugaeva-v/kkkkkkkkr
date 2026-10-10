using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Содержит описание функции.</summary>
	// Token: 0x020007B7 RID: 1975
	public struct FUNCDESC
	{
		/// <summary>Определяет идентификатор члена функции.</summary>
		// Token: 0x04002C92 RID: 11410
		public int memid;

		/// <summary>Хранит число ошибок, которое функция может возвратить в 16-разрядной системе.</summary>
		// Token: 0x04002C93 RID: 11411
		public IntPtr lprgscode;

		/// <summary>Показывает размер <see cref="F:System.Runtime.InteropServices.FUNCDESC.cParams" />.</summary>
		// Token: 0x04002C94 RID: 11412
		public IntPtr lprgelemdescParam;

		/// <summary>Показывает, является функция виртуальной, статической или диспетчерской.</summary>
		// Token: 0x04002C95 RID: 11413
		public FUNCKIND funckind;

		/// <summary>Задает тип функции свойства.</summary>
		// Token: 0x04002C96 RID: 11414
		public INVOKEKIND invkind;

		/// <summary>Определяет для функции соглашение о вызове.</summary>
		// Token: 0x04002C97 RID: 11415
		public CALLCONV callconv;

		/// <summary>Подсчитывает полное число параметров.</summary>
		// Token: 0x04002C98 RID: 11416
		public short cParams;

		/// <summary>Подсчитывает число дополнительных параметров.</summary>
		// Token: 0x04002C99 RID: 11417
		public short cParamsOpt;

		/// <summary>Определяет смещение в VTBL для <see cref="F:System.Runtime.InteropServices.FUNCKIND.FUNC_VIRTUAL" />.</summary>
		// Token: 0x04002C9A RID: 11418
		public short oVft;

		/// <summary>Подсчитывает число разрешенных возвращенных значений.</summary>
		// Token: 0x04002C9B RID: 11419
		public short cScodes;

		/// <summary>Содержит возвращаемый функцией тип.</summary>
		// Token: 0x04002C9C RID: 11420
		public ELEMDESC elemdescFunc;

		/// <summary>Показывает флаги <see cref="T:System.Runtime.InteropServices.FUNCFLAGS" /> функции.</summary>
		// Token: 0x04002C9D RID: 11421
		public short wFuncFlags;
	}
}
