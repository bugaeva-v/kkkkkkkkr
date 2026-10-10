using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет соглашение о вызовах, используемое методом, описанным в структуре METHODDATA.</summary>
	// Token: 0x020007C6 RID: 1990
	[Serializable]
	public enum CALLCONV
	{
		/// <summary>Указывает на использование для метода соглашения о вызове языка C (CDECL).</summary>
		// Token: 0x04002CDD RID: 11485
		CC_CDECL = 1,
		/// <summary>Указывает на использование для метода соглашения о вызове языка MSC Pascal (MSCPASCAL).</summary>
		// Token: 0x04002CDE RID: 11486
		CC_MSCPASCAL,
		/// <summary>Указывает на использование для метода соглашения о вызове языка Pascal.</summary>
		// Token: 0x04002CDF RID: 11487
		CC_PASCAL = 2,
		/// <summary>Указывает на использование для метода соглашения о вызове языка Macintosh Pascal (MACPASCAL).</summary>
		// Token: 0x04002CE0 RID: 11488
		CC_MACPASCAL,
		/// <summary>Указывает на использование для метода стандартного соглашения о вызове (STDCALL).</summary>
		// Token: 0x04002CE1 RID: 11489
		CC_STDCALL,
		/// <summary>Это значение зарезервировано для использования в будущем.</summary>
		// Token: 0x04002CE2 RID: 11490
		CC_RESERVED,
		/// <summary>Указывает на использование для метода стандартного соглашения о вызове SYSCALL.</summary>
		// Token: 0x04002CE3 RID: 11491
		CC_SYSCALL,
		/// <summary>Указывает на использование для метода соглашения о вызове Macintosh Programmers' Workbench (MPW) CDECL.</summary>
		// Token: 0x04002CE4 RID: 11492
		CC_MPWCDECL,
		/// <summary>Указывает на использование для метода соглашения о вызове Macintosh Programmers' Workbench (MPW) PASCAL.</summary>
		// Token: 0x04002CE5 RID: 11493
		CC_MPWPASCAL,
		/// <summary>Указывает на конец перечисления <see cref="T:System.Runtime.InteropServices.ComTypes.CALLCONV" />.</summary>
		// Token: 0x04002CE6 RID: 11494
		CC_MAX
	}
}
