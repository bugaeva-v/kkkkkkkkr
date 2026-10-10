using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200012F RID: 303
	public interface IDictionaryValidator
	{
		// Token: 0x06000815 RID: 2069
		bool IsValid(IDictionaryAdapter dictionaryAdapter);

		// Token: 0x06000816 RID: 2070
		string Validate(IDictionaryAdapter dictionaryAdapter);

		// Token: 0x06000817 RID: 2071
		string Validate(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property);

		// Token: 0x06000818 RID: 2072
		void Invalidate(IDictionaryAdapter dictionaryAdapter);
	}
}
