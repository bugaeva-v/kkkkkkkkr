using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает архитектуру процессора.</summary>
	// Token: 0x020006CB RID: 1739
	public enum Architecture
	{
		/// <summary>Архитектура 32-разрядного процессора Intel.</summary>
		// Token: 0x04002A00 RID: 10752
		X86,
		/// <summary>Архитектура 64-разрядного процессора Intel.</summary>
		// Token: 0x04002A01 RID: 10753
		X64,
		/// <summary>Архитектура 32-разрядного процессора ARM.</summary>
		// Token: 0x04002A02 RID: 10754
		Arm,
		/// <summary>64-разрядный процессор с архитектурой ARM.</summary>
		// Token: 0x04002A03 RID: 10755
		Arm64
	}
}
