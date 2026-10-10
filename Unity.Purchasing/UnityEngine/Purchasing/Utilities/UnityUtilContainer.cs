using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Utilities
{
	// Token: 0x02000108 RID: 264
	internal static class UnityUtilContainer
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x0000B522 File Offset: 0x00009722
		[NullableContext(1)]
		internal static UnityUtil Instance()
		{
			if (UnityUtilContainer.s_UnityUtilInstance == null)
			{
				UnityUtilContainer.s_UnityUtilInstance = UnityUtilDependencyInjector.CreateUnityUtils();
			}
			return UnityUtilContainer.s_UnityUtilInstance;
		}

		// Token: 0x0400022B RID: 555
		[Nullable(2)]
		private static UnityUtil s_UnityUtilInstance;
	}
}
