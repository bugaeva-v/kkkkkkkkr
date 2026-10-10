using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.VARDESC" />.</summary>
	// Token: 0x0200072D RID: 1837
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.VARDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct VARDESC
	{
		/// <summary>Показывает идентификатор ID элемента переменной.</summary>
		// Token: 0x04002B64 RID: 11108
		public int memid;

		/// <summary>Это поле зарезервировано для использования в будущем.</summary>
		// Token: 0x04002B65 RID: 11109
		public string lpstrSchema;

		/// <summary>Содержит тип переменной.</summary>
		// Token: 0x04002B66 RID: 11110
		public ELEMDESC elemdescVar;

		/// <summary>Определяет свойства переменной.</summary>
		// Token: 0x04002B67 RID: 11111
		public short wVarFlags;

		/// <summary>Определяет способ маршалинга переменной.</summary>
		// Token: 0x04002B68 RID: 11112
		public VarEnum varkind;

		/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.VARDESC.DESCUNION" />.</summary>
		// Token: 0x0200072E RID: 1838
		[ComVisible(false)]
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct DESCUNION
		{
			/// <summary>Показывает смещение переменной внутри экземпляра.</summary>
			// Token: 0x04002B69 RID: 11113
			[FieldOffset(0)]
			public int oInst;

			/// <summary>Описывает символьную константу.</summary>
			// Token: 0x04002B6A RID: 11114
			[FieldOffset(0)]
			public IntPtr lpvarValue;
		}
	}
}
