using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200015A RID: 346
	public interface IXmlCollectionAccessor : IXmlAccessor
	{
		// Token: 0x06000A16 RID: 2582
		IXmlCursor SelectCollectionItems(IXmlNode parentNode, bool mutable);

		// Token: 0x06000A17 RID: 2583
		void GetCollectionItems(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, IList values);
	}
}
