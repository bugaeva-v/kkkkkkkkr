using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Содержит информацию, необходимую для передачи элемента структуры, параметра или возвращаемого функцией значения из одного процесса в другой.</summary>
	// Token: 0x020007B9 RID: 1977
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct IDLDESC
	{
		/// <summary>Зарезервировано, равно <see langword="null" />.</summary>
		// Token: 0x04002CA4 RID: 11428
		public IntPtr dwReserved;

		/// <summary>Показывает значение <see cref="T:System.Runtime.InteropServices.IDLFLAG" />, описывающее тип.</summary>
		// Token: 0x04002CA5 RID: 11429
		public IDLFLAG wIDLFlags;
	}
}
