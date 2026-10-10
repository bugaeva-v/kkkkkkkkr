using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200015D RID: 349
	// (Invoke) Token: 0x06000A3A RID: 2618
	public delegate TAccessor XmlAccessorFactory<TAccessor>(string name, Type type, IXmlContext context) where TAccessor : XmlAccessor;
}
