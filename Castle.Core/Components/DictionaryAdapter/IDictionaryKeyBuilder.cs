using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000128 RID: 296
	public interface IDictionaryKeyBuilder : IDictionaryBehavior
	{
		// Token: 0x06000802 RID: 2050
		string GetKey(IDictionaryAdapter dictionaryAdapter, string key, PropertyDescriptor property);
	}
}
