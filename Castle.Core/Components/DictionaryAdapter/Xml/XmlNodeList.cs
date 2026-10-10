using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000168 RID: 360
	internal class XmlNodeList<T> : ListProjection<T>, IXmlNodeSource
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0001AC9E File Offset: 0x00018E9E
		public XmlNodeList(IXmlNode parentNode, IDictionaryAdapter parentObject, IXmlCollectionAccessor accessor) : base(new XmlCollectionAdapter<T>(parentNode, parentObject, accessor))
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0001ACAE File Offset: 0x00018EAE
		public IXmlNode Node
		{
			get
			{
				return ((IXmlNodeSource)base.Adapter).Node;
			}
		}
	}
}
