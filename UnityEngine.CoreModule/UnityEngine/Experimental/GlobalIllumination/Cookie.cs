using System;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000463 RID: 1123
	public struct Cookie
	{
		// Token: 0x060027CE RID: 10190 RVA: 0x00041B94 File Offset: 0x0003FD94
		public static Cookie Defaults()
		{
			Cookie result;
			result.instanceID = 0;
			result.scale = 1f;
			result.sizes = new Vector2(1f, 1f);
			return result;
		}

		// Token: 0x04000EB1 RID: 3761
		public int instanceID;

		// Token: 0x04000EB2 RID: 3762
		public float scale;

		// Token: 0x04000EB3 RID: 3763
		public Vector2 sizes;
	}
}
