using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000101 RID: 257
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public class KeySubstitutionAttribute : DictionaryBehaviorAttribute, IDictionaryKeyBuilder, IDictionaryBehavior
	{
		// Token: 0x060006D0 RID: 1744 RVA: 0x0001313F File Offset: 0x0001133F
		public KeySubstitutionAttribute(string oldValue, string newValue)
		{
			this.oldValue = oldValue;
			this.newValue = newValue;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00013155 File Offset: 0x00011355
		string IDictionaryKeyBuilder.GetKey(IDictionaryAdapter dictionaryAdapter, string key, PropertyDescriptor property)
		{
			return key.Replace(this.oldValue, this.newValue);
		}

		// Token: 0x0400019B RID: 411
		private readonly string oldValue;

		// Token: 0x0400019C RID: 412
		private readonly string newValue;
	}
}
