using System;

namespace UnityEngine
{
	// Token: 0x020001D8 RID: 472
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class InspectorNameAttribute : PropertyAttribute
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x000231BE File Offset: 0x000213BE
		public InspectorNameAttribute(string displayName)
		{
			this.displayName = displayName;
		}

		// Token: 0x040007B2 RID: 1970
		public readonly string displayName;
	}
}
