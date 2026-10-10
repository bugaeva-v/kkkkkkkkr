using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200012D RID: 301
	public interface IDictionaryReferenceManager
	{
		// Token: 0x0600080C RID: 2060
		bool IsReferenceProperty(IDictionaryAdapter dictionaryAdapter, string propertyName);

		// Token: 0x0600080D RID: 2061
		bool TryGetReference(object keyObject, out object inGraphObject);

		// Token: 0x0600080E RID: 2062
		void AddReference(object keyObject, object relatedObject, bool isInGraph);
	}
}
