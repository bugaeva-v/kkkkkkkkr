using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200015B RID: 347
	public interface IXmlPropertyAccessor : IXmlAccessor
	{
		// Token: 0x06000A18 RID: 2584
		object GetPropertyValue(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, bool orStub);

		// Token: 0x06000A19 RID: 2585
		void SetPropertyValue(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, object oldValue, ref object newValue);
	}
}
