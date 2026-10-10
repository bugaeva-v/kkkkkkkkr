using System;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000474 RID: 1140
	[RequiredByNativeCode]
	internal class ScriptableRuntimeReflectionSystemWrapper
	{
		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x00043087 File Offset: 0x00041287
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x0004308F File Offset: 0x0004128F
		internal IScriptableRuntimeReflectionSystem implementation { get; set; }

		// Token: 0x0600283F RID: 10303 RVA: 0x00043098 File Offset: 0x00041298
		[RequiredByNativeCode]
		private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result)
		{
			result = (this.implementation != null && this.implementation.TickRealtimeProbes());
		}
	}
}
