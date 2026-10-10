using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000103 RID: 259
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false)]
	public class NewGuidAttribute : DictionaryBehaviorAttribute, IDictionaryPropertyGetter, IDictionaryBehavior
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x0001317A File Offset: 0x0001137A
		public object GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor property, bool ifExists)
		{
			if (storedValue == null || storedValue.Equals(NewGuidAttribute.UnassignedGuid))
			{
				storedValue = Guid.NewGuid();
				property.SetPropertyValue(dictionaryAdapter, key, ref storedValue, dictionaryAdapter.This.Descriptor);
			}
			return storedValue;
		}

		// Token: 0x0400019D RID: 413
		private static readonly Guid UnassignedGuid;
	}
}
