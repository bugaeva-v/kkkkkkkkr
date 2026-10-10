using System;

namespace UnityEngine
{
	// Token: 0x020001D7 RID: 471
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class ContextMenuItemAttribute : PropertyAttribute
	{
		// Token: 0x060015DE RID: 5598 RVA: 0x000231A6 File Offset: 0x000213A6
		public ContextMenuItemAttribute(string name, string function)
		{
			this.name = name;
			this.function = function;
		}

		// Token: 0x040007B0 RID: 1968
		public readonly string name;

		// Token: 0x040007B1 RID: 1969
		public readonly string function;
	}
}
