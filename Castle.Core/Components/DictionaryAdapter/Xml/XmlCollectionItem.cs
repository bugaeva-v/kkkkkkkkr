using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000167 RID: 359
	internal struct XmlCollectionItem<T>
	{
		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001AC50 File Offset: 0x00018E50
		public XmlCollectionItem(IXmlNode node)
		{
			this = new XmlCollectionItem<T>(node, default(T), false);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001AC6E File Offset: 0x00018E6E
		public XmlCollectionItem(IXmlNode node, T value)
		{
			this = new XmlCollectionItem<T>(node, value, true);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0001AC79 File Offset: 0x00018E79
		private XmlCollectionItem(IXmlNode node, T value, bool hasValue)
		{
			this.Node = node;
			this.Value = value;
			this.HasValue = hasValue;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001AC90 File Offset: 0x00018E90
		public XmlCollectionItem<T> WithValue(T value)
		{
			return new XmlCollectionItem<T>(this.Node, value);
		}

		// Token: 0x04000255 RID: 597
		public readonly IXmlNode Node;

		// Token: 0x04000256 RID: 598
		public readonly T Value;

		// Token: 0x04000257 RID: 599
		public readonly bool HasValue;
	}
}
