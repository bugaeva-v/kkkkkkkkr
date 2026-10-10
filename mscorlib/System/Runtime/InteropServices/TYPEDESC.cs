using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.TYPEDESC" />.</summary>
	// Token: 0x0200072A RID: 1834
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.TYPEDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPEDESC
	{
		/// <summary>Если переменная равна <see langword="VT_SAFEARRAY" /> или <see langword="VT_PTR" />, то поле <see cref="F:System.Runtime.InteropServices.TYPEDESC.lpValue" /> содержит указатель на <see langword="TYPEDESC" />, показывающий тип элемента.</summary>
		// Token: 0x04002B5E RID: 11102
		public IntPtr lpValue;

		/// <summary>Показывает тип variant элемента, описанного при помощи <see langword="TYPEDESC" />.</summary>
		// Token: 0x04002B5F RID: 11103
		public short vt;
	}
}
