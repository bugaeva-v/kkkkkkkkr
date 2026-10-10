using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Содержит описание типа и сведения о процессе передачи для переменной, функции или параметра функции.</summary>
	// Token: 0x020007BD RID: 1981
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ELEMDESC
	{
		/// <summary>Определяет тип элемента.</summary>
		// Token: 0x04002CB3 RID: 11443
		public TYPEDESC tdesc;

		/// <summary>Содержит сведения об элементе.</summary>
		// Token: 0x04002CB4 RID: 11444
		public ELEMDESC.DESCUNION desc;

		/// <summary>Содержит сведения об элементе.</summary>
		// Token: 0x020007BE RID: 1982
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct DESCUNION
		{
			/// <summary>Содержит сведения для удаленного взаимодействия с элементом.</summary>
			// Token: 0x04002CB5 RID: 11445
			[FieldOffset(0)]
			public IDLDESC idldesc;

			/// <summary>Содержит сведения о параметре.</summary>
			// Token: 0x04002CB6 RID: 11446
			[FieldOffset(0)]
			public PARAMDESC paramdesc;
		}
	}
}
