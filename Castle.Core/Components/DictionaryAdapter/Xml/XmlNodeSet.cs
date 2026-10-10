using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000169 RID: 361
	internal class XmlNodeSet<T> : SetProjection<T>, IXmlNodeSource
	{
		// Token: 0x06000AB8 RID: 2744 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		public XmlNodeSet(IXmlNode parentNode, IDictionaryAdapter parentObject, IXmlCollectionAccessor accessor) : base(new XmlCollectionAdapter<T>(parentNode, parentObject, accessor))
		{
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		public IXmlNode Node
		{
			get
			{
				return ((IXmlNodeSource)base.Adapter).Node;
			}
		}
	}
}
