using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Содержит указатель на связанную структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />, структуру <see cref="T:System.Runtime.InteropServices.VARDESC" /> или интерфейс <see langword="ITypeComp" />.</summary>
	// Token: 0x020007B1 RID: 1969
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public struct BINDPTR
	{
		/// <summary>Представляет указатель на структуру <see cref="T:System.Runtime.InteropServices.FUNCDESC" />.</summary>
		// Token: 0x04002C5D RID: 11357
		[FieldOffset(0)]
		public IntPtr lpfuncdesc;

		/// <summary>Представляет указатель на структуру <see cref="T:System.Runtime.InteropServices.VARDESC" />.</summary>
		// Token: 0x04002C5E RID: 11358
		[FieldOffset(0)]
		public IntPtr lpvardesc;

		/// <summary>Представляет указатель на интерфейс <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeComp" />.</summary>
		// Token: 0x04002C5F RID: 11359
		[FieldOffset(0)]
		public IntPtr lptcomp;
	}
}
