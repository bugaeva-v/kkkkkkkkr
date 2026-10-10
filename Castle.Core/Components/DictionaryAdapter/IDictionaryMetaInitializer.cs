using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000129 RID: 297
	public interface IDictionaryMetaInitializer : IDictionaryBehavior
	{
		// Token: 0x06000803 RID: 2051
		void Initialize(IDictionaryAdapterFactory factory, DictionaryAdapterMeta dictionaryMeta);

		// Token: 0x06000804 RID: 2052
		bool ShouldHaveBehavior(object behavior);
	}
}
