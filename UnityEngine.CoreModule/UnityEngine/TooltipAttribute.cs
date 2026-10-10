using System;

namespace UnityEngine
{
	// Token: 0x020001D9 RID: 473
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public class TooltipAttribute : PropertyAttribute
	{
		// Token: 0x060015E0 RID: 5600 RVA: 0x000231CF File Offset: 0x000213CF
		public TooltipAttribute(string tooltip)
		{
			this.tooltip = tooltip;
		}

		// Token: 0x040007B3 RID: 1971
		public readonly string tooltip;
	}
}
