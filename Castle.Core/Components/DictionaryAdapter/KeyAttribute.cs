using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x020000FF RID: 255
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public class KeyAttribute : DictionaryBehaviorAttribute, IDictionaryKeyBuilder, IDictionaryBehavior
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x000130C8 File Offset: 0x000112C8
		public KeyAttribute(string key)
		{
			this.Key = key;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000130D7 File Offset: 0x000112D7
		public KeyAttribute(string[] keys)
		{
			this.Key = string.Join(",", keys);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x000130F0 File Offset: 0x000112F0
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x000130F8 File Offset: 0x000112F8
		public string Key { get; private set; }

		// Token: 0x060006CA RID: 1738 RVA: 0x00013101 File Offset: 0x00011301
		string IDictionaryKeyBuilder.GetKey(IDictionaryAdapter dictionaryAdapter, string key, PropertyDescriptor property)
		{
			return this.Key;
		}
	}
}
