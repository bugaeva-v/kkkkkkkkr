using System;
using UnityEngine.Scripting;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x020000A5 RID: 165
	[RequiredByNativeCode]
	[Obsolete("Use NativeSetThreadIndexAttribute instead")]
	[AttributeUsage(AttributeTargets.Struct)]
	public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute
	{
	}
}
