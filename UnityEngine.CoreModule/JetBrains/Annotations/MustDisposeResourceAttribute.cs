using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000C9 RID: 201
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class MustDisposeResourceAttribute : Attribute
	{
		// Token: 0x06000367 RID: 871 RVA: 0x00005E1C File Offset: 0x0000401C
		public MustDisposeResourceAttribute()
		{
			this.Value = 1;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00005E2D File Offset: 0x0000402D
		public MustDisposeResourceAttribute(bool value)
		{
			this.Value = value;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00005E3E File Offset: 0x0000403E
		public bool Value { get; }
	}
}
