using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.DISPPARAMS" />.</summary>
	// Token: 0x0200072F RID: 1839
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.DISPPARAMS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DISPPARAMS
	{
		/// <summary>Представляет ссылку на массив аргументов.</summary>
		// Token: 0x04002B6B RID: 11115
		public IntPtr rgvarg;

		/// <summary>Представляет диспетчерские идентификаторы именованных аргументов.</summary>
		// Token: 0x04002B6C RID: 11116
		public IntPtr rgdispidNamedArgs;

		/// <summary>Предоставляет число аргументов.</summary>
		// Token: 0x04002B6D RID: 11117
		public int cArgs;

		/// <summary>Представляет число именованных аргументов.</summary>
		// Token: 0x04002B6E RID: 11118
		public int cNamedArgs;
	}
}
