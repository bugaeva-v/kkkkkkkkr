using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Определяет способ реализации метода.</summary>
	// Token: 0x02000844 RID: 2116
	[ComVisible(true)]
	[Serializable]
	public enum MethodCodeType
	{
		/// <summary>Указывает, что метод реализуется на языке MSIL.</summary>
		// Token: 0x04002D89 RID: 11657
		IL,
		/// <summary>Указывает, что метод реализуется в машинном коде.</summary>
		// Token: 0x04002D8A RID: 11658
		Native,
		/// <summary>Указывает, что метод реализуется на оптимизированном промежуточном языке (OPTIL).</summary>
		// Token: 0x04002D8B RID: 11659
		OPTIL,
		/// <summary>Указывает, что реализация метода предоставляется средой выполнения.</summary>
		// Token: 0x04002D8C RID: 11660
		Runtime
	}
}
