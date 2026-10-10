using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200010A RID: 266
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false)]
	public class StringStorageAttribute : DictionaryBehaviorAttribute, IDictionaryPropertySetter, IDictionaryBehavior
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x00013A4C File Offset: 0x00011C4C
		public bool SetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, ref object value, PropertyDescriptor property)
		{
			value = ((value != null) ? value.ToString() : null);
			return true;
		}
	}
}
