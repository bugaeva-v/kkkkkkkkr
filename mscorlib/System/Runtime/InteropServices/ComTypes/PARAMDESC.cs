using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Содержит информацию о порядке передачи элемента структуры, параметра или возвращаемого функцией значения из одного процесса в другой.</summary>
	// Token: 0x020007BB RID: 1979
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct PARAMDESC
	{
		/// <summary>Представляет указатель на значение, передаваемое между процессами.</summary>
		// Token: 0x04002CAF RID: 11439
		public IntPtr lpVarValue;

		/// <summary>Представляет значения битовой маски, описывающие элемент структуры, параметр или возвращаемое значение.</summary>
		// Token: 0x04002CB0 RID: 11440
		public PARAMFLAG wParamFlags;
	}
}
