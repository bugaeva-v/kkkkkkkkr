using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.CALLCONV" />.</summary>
	// Token: 0x02000733 RID: 1843
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.CALLCONV instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Serializable]
	public enum CALLCONV
	{
		/// <summary>Указывает на использование для данного метода соглашения о вызове Cdecl.</summary>
		// Token: 0x04002B83 RID: 11139
		CC_CDECL = 1,
		/// <summary>Указывает на использование для данного метода соглашения о вызове Mscpascal.</summary>
		// Token: 0x04002B84 RID: 11140
		CC_MSCPASCAL,
		/// <summary>Указывает на использование для метода соглашения о вызове языка Pascal.</summary>
		// Token: 0x04002B85 RID: 11141
		CC_PASCAL = 2,
		/// <summary>Указывает на использование для данного метода соглашения о вызове Macpascal.</summary>
		// Token: 0x04002B86 RID: 11142
		CC_MACPASCAL,
		/// <summary>Указывает на использование для данного метода соглашения о вызове Stdcall.</summary>
		// Token: 0x04002B87 RID: 11143
		CC_STDCALL,
		/// <summary>Это значение зарезервировано для использования в будущем.</summary>
		// Token: 0x04002B88 RID: 11144
		CC_RESERVED,
		/// <summary>Указывает на использование для данного метода соглашения о вызове Syscall.</summary>
		// Token: 0x04002B89 RID: 11145
		CC_SYSCALL,
		/// <summary>Указывает на использование для данного метода соглашения о вызове Mpwcdecl.</summary>
		// Token: 0x04002B8A RID: 11146
		CC_MPWCDECL,
		/// <summary>Указывает на использование для данного метода соглашения о вызове Mpwpascal.</summary>
		// Token: 0x04002B8B RID: 11147
		CC_MPWPASCAL,
		/// <summary>Указывает на конец перечисления <see cref="T:System.Runtime.InteropServices.CALLCONV" />.</summary>
		// Token: 0x04002B8C RID: 11148
		CC_MAX
	}
}
