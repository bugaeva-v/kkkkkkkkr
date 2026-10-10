using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200016F RID: 367
	public interface IXmlNamespaceSource
	{
		// Token: 0x06000ACF RID: 2767
		string GetElementPrefix(IXmlNode node, string namespaceUri);

		// Token: 0x06000AD0 RID: 2768
		string GetAttributePrefix(IXmlNode node, string namespaceUri);
	}
}
