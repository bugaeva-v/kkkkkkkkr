using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200010D RID: 269
	[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public class TypeKeyPrefixAttribute : DictionaryBehaviorAttribute, IDictionaryKeyBuilder, IDictionaryBehavior
	{
		// Token: 0x06000704 RID: 1796 RVA: 0x00013B05 File Offset: 0x00011D05
		string IDictionaryKeyBuilder.GetKey(IDictionaryAdapter dictionaryAdapter, string key, PropertyDescriptor property)
		{
			return string.Format("{0}#{1}", property.Property.DeclaringType.FullName, key);
		}
	}
}
