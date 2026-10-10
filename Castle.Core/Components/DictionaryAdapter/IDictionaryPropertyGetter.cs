using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200012B RID: 299
	public interface IDictionaryPropertyGetter : IDictionaryBehavior
	{
		// Token: 0x0600080A RID: 2058
		object GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor property, bool ifExists);
	}
}
