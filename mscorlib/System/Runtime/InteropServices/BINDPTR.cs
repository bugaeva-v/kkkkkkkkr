using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.BINDPTR" />.</summary>
	// Token: 0x02000738 RID: 1848
	[Obsolete]
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public struct BINDPTR
	{
		/// <summary>Представляет указатель на структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />.</summary>
		// Token: 0x04002BAC RID: 11180
		[FieldOffset(0)]
		public IntPtr lpfuncdesc;

		/// <summary>Представляет указатель на интерфейс <see cref="F:System.Runtime.InteropServices.BINDPTR.lptcomp" />.</summary>
		// Token: 0x04002BAD RID: 11181
		[FieldOffset(0)]
		public IntPtr lptcomp;

		/// <summary>Представляет указатель на структуру <see cref="T:System.Runtime.InteropServices.VARDESC" />.</summary>
		// Token: 0x04002BAE RID: 11182
		[FieldOffset(0)]
		public IntPtr lpvardesc;
	}
}
