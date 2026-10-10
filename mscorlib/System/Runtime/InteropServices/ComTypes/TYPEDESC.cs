using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Описывает тип переменной, тип возвращаемого значения функции или тип параметра функции.</summary>
	// Token: 0x020007BC RID: 1980
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPEDESC
	{
		/// <summary>Если переменная равна <see langword="VT_SAFEARRAY" /> или <see langword="VT_PTR" />, то поле <see langword="lpValue" /> содержит указатель на <see langword="TYPEDESC" />, показывающий тип элемента.</summary>
		// Token: 0x04002CB1 RID: 11441
		public IntPtr lpValue;

		/// <summary>Показывает тип variant элемента, описанного при помощи <see langword="TYPEDESC" />.</summary>
		// Token: 0x04002CB2 RID: 11442
		public short vt;
	}
}
