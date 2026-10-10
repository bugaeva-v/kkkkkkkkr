using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Описывает переменную, константу или данные-член.</summary>
	// Token: 0x020007C0 RID: 1984
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct VARDESC
	{
		/// <summary>Показывает идентификатор ID элемента переменной.</summary>
		// Token: 0x04002CBC RID: 11452
		public int memid;

		/// <summary>Это поле зарезервировано для использования в будущем.</summary>
		// Token: 0x04002CBD RID: 11453
		public string lpstrSchema;

		/// <summary>Содержит сведения о переменной.</summary>
		// Token: 0x04002CBE RID: 11454
		public VARDESC.DESCUNION desc;

		/// <summary>Содержит тип переменной.</summary>
		// Token: 0x04002CBF RID: 11455
		public ELEMDESC elemdescVar;

		/// <summary>Определяет свойства переменной.</summary>
		// Token: 0x04002CC0 RID: 11456
		public short wVarFlags;

		/// <summary>Определяет, как маршалировать переменную.</summary>
		// Token: 0x04002CC1 RID: 11457
		public VARKIND varkind;

		/// <summary>Содержит сведения о переменной.</summary>
		// Token: 0x020007C1 RID: 1985
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct DESCUNION
		{
			/// <summary>Показывает смещение переменной внутри экземпляра.</summary>
			// Token: 0x04002CC2 RID: 11458
			[FieldOffset(0)]
			public int oInst;

			/// <summary>Описывает символьную константу.</summary>
			// Token: 0x04002CC3 RID: 11459
			[FieldOffset(0)]
			public IntPtr lpvarValue;
		}
	}
}
