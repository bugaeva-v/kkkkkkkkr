using System;

namespace UnityEngine
{
	// Token: 0x020001D6 RID: 470
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public abstract class PropertyAttribute : Attribute
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00023195 File Offset: 0x00021395
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x0002319D File Offset: 0x0002139D
		public int order { get; set; }
	}
}
