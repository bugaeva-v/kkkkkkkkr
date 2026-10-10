using System;

namespace UnityEngine
{
	// Token: 0x020001DA RID: 474
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x060015E1 RID: 5601 RVA: 0x000231E0 File Offset: 0x000213E0
		public SpaceAttribute()
		{
			this.height = 8f;
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000231F5 File Offset: 0x000213F5
		public SpaceAttribute(float height)
		{
			this.height = height;
		}

		// Token: 0x040007B4 RID: 1972
		public readonly float height;
	}
}
