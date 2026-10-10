using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	// Token: 0x020002EE RID: 750
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	public struct PlayerLoopSystem
	{
		// Token: 0x06001E89 RID: 7817 RVA: 0x000318C6 File Offset: 0x0002FAC6
		public override string ToString()
		{
			return this.type.Name;
		}

		// Token: 0x040009FE RID: 2558
		public Type type;

		// Token: 0x040009FF RID: 2559
		public PlayerLoopSystem[] subSystemList;

		// Token: 0x04000A00 RID: 2560
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		// Token: 0x04000A01 RID: 2561
		public IntPtr updateFunction;

		// Token: 0x04000A02 RID: 2562
		public IntPtr loopConditionFunction;

		// Token: 0x020002EF RID: 751
		// (Invoke) Token: 0x06001E8B RID: 7819
		public delegate void UpdateFunction();
	}
}
