using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200011E RID: 286
	public interface IDictionaryAdapterVisitor
	{
		// Token: 0x060007E7 RID: 2023
		bool VisitDictionaryAdapter(IDictionaryAdapter dictionaryAdapter, object state);

		// Token: 0x060007E8 RID: 2024
		bool VisitDictionaryAdapter(IDictionaryAdapter dictionaryAdapter, Func<PropertyDescriptor, bool> selector, object state);

		// Token: 0x060007E9 RID: 2025
		void VisitProperty(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, object state);

		// Token: 0x060007EA RID: 2026
		void VisitInterface(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, object state);

		// Token: 0x060007EB RID: 2027
		void VisitCollection(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, Type collectionItemType, object state);
	}
}
