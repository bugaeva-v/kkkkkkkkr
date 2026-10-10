using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Содержит аргументы, передаваемые методу или свойству <see langword="IDispatch::Invoke" />.</summary>
	// Token: 0x020007C2 RID: 1986
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DISPPARAMS
	{
		/// <summary>Представляет ссылку на массив аргументов.</summary>
		// Token: 0x04002CC4 RID: 11460
		public IntPtr rgvarg;

		/// <summary>Представляет диспетчерские идентификаторы именованных аргументов.</summary>
		// Token: 0x04002CC5 RID: 11461
		public IntPtr rgdispidNamedArgs;

		/// <summary>Предоставляет число аргументов.</summary>
		// Token: 0x04002CC6 RID: 11462
		public int cArgs;

		/// <summary>Представляет число именованных аргументов.</summary>
		// Token: 0x04002CC7 RID: 11463
		public int cNamedArgs;
	}
}
