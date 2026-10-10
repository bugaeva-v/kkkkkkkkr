using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000100 RID: 256
	[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public class KeyPrefixAttribute : DictionaryBehaviorAttribute, IDictionaryKeyBuilder, IDictionaryBehavior
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x00013109 File Offset: 0x00011309
		public KeyPrefixAttribute()
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00013111 File Offset: 0x00011311
		public KeyPrefixAttribute(string keyPrefix)
		{
			this.KeyPrefix = keyPrefix;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00013120 File Offset: 0x00011320
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00013128 File Offset: 0x00011328
		public string KeyPrefix { get; set; }

		// Token: 0x060006CF RID: 1743 RVA: 0x00013131 File Offset: 0x00011331
		string IDictionaryKeyBuilder.GetKey(IDictionaryAdapter dictionaryAdapter, string key, PropertyDescriptor property)
		{
			return this.KeyPrefix + key;
		}
	}
}
