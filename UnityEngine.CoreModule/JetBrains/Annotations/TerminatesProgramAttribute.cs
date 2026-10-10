using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000D3 RID: 211
	[AttributeUsage(AttributeTargets.Method)]
	[Obsolete("Use [ContractAnnotation('=> halt')] instead")]
	public sealed class TerminatesProgramAttribute : Attribute
	{
	}
}
