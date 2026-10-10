using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000127 RID: 295
	public interface IDictionaryInitializer : IDictionaryBehavior
	{
		// Token: 0x06000801 RID: 2049
		void Initialize(IDictionaryAdapter dictionaryAdapter, object[] behaviors);
	}
}
