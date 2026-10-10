using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200011F RID: 287
	public interface IDictionaryBehavior
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060007EC RID: 2028
		int ExecutionOrder { get; }

		// Token: 0x060007ED RID: 2029
		IDictionaryBehavior Copy();
	}
}
