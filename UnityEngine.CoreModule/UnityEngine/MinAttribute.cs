using System;

namespace UnityEngine
{
	// Token: 0x020001DD RID: 477
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x060015E5 RID: 5605 RVA: 0x0002322F File Offset: 0x0002142F
		public MinAttribute(float min)
		{
			this.min = min;
		}

		// Token: 0x040007B8 RID: 1976
		public readonly float min;
	}
}
