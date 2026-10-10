using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200012C RID: 300
	public interface IDictionaryPropertySetter : IDictionaryBehavior
	{
		// Token: 0x0600080B RID: 2059
		bool SetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, ref object value, PropertyDescriptor property);
	}
}
