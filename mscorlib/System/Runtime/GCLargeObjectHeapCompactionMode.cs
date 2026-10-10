using System;

namespace System.Runtime
{
	/// <summary>Указывает, будет ли Куча больших объектов (LOH) сжата во время следующей блокирующей сборки мусора.</summary>
	// Token: 0x02000550 RID: 1360
	public enum GCLargeObjectHeapCompactionMode
	{
		/// <summary>Куча больших объектов (LOH) не уплотняется.</summary>
		// Token: 0x04002506 RID: 9478
		Default = 1,
		/// <summary>Куча больших объектов (LOH) будет сжата во время следующей блокирующей сборки мусора второго поколения.</summary>
		// Token: 0x04002507 RID: 9479
		CompactOnce
	}
}
