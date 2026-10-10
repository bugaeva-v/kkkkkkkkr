using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000122 RID: 290
	public interface IDictionaryCopyStrategy
	{
		// Token: 0x060007F0 RID: 2032
		bool Copy(IDictionaryAdapter source, IDictionaryAdapter target, ref Func<PropertyDescriptor, bool> selector);
	}
}
