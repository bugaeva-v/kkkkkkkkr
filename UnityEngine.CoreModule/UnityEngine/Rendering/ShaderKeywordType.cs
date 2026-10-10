using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000425 RID: 1061
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	public enum ShaderKeywordType
	{
		// Token: 0x04000DB0 RID: 3504
		None,
		// Token: 0x04000DB1 RID: 3505
		BuiltinDefault = 2,
		// Token: 0x04000DB2 RID: 3506
		[Obsolete("Shader keyword type BuiltinExtra is no longer used. Use BuiltinDefault instead. (UnityUpgradable) -> BuiltinDefault")]
		BuiltinExtra = 6,
		// Token: 0x04000DB3 RID: 3507
		[Obsolete("Shader keyword type BuiltinAutoStripped is no longer used. Use BuiltinDefault instead. (UnityUpgradable) -> BuiltinDefault")]
		BuiltinAutoStripped = 10,
		// Token: 0x04000DB4 RID: 3508
		UserDefined = 16,
		// Token: 0x04000DB5 RID: 3509
		Plugin = 32
	}
}
