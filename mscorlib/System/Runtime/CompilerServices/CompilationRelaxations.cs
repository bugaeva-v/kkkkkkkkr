using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает параметры, контролирующие точность кода, создаваемого JIT-компилятором среды CLR.</summary>
	// Token: 0x02000830 RID: 2096
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum CompilationRelaxations
	{
		/// <summary>Помечает сборку как не требующую интернирования строковых литералов.</summary>
		// Token: 0x04002D7A RID: 11642
		NoStringInterning = 8
	}
}
