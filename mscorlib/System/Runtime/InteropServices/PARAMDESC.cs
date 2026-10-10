using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.PARAMDESC" />.</summary>
	// Token: 0x02000729 RID: 1833
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.PARAMDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct PARAMDESC
	{
		/// <summary>Представляет указатель на значение, передаваемое между процессами.</summary>
		// Token: 0x04002B5C RID: 11100
		public IntPtr lpVarValue;

		/// <summary>Представляет значения битовой маски, описывающие элемент структуры, параметр или возвращаемое значение.</summary>
		// Token: 0x04002B5D RID: 11101
		public PARAMFLAG wParamFlags;
	}
}
