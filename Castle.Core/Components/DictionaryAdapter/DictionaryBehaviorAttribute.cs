using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x020000FB RID: 251
	public abstract class DictionaryBehaviorAttribute : Attribute, IDictionaryBehavior
	{
		// Token: 0x060006B9 RID: 1721 RVA: 0x00013038 File Offset: 0x00011238
		public DictionaryBehaviorAttribute()
		{
			this.ExecutionOrder = 1073741823;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0001304B File Offset: 0x0001124B
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x00013053 File Offset: 0x00011253
		public int ExecutionOrder { get; set; }

		// Token: 0x060006BC RID: 1724 RVA: 0x0001305C File Offset: 0x0001125C
		public virtual IDictionaryBehavior Copy()
		{
			return this;
		}

		// Token: 0x04000193 RID: 403
		public const int FirstExecutionOrder = 0;

		// Token: 0x04000194 RID: 404
		public const int DefaultExecutionOrder = 1073741823;

		// Token: 0x04000195 RID: 405
		public const int LastExecutionOrder = 2147483647;
	}
}
