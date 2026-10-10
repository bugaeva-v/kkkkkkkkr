using System;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200019C RID: 412
	public class XmlXmlNodeSerializer : XmlTypeSerializer
	{
		// Token: 0x06000CCC RID: 3276 RVA: 0x0001F175 File Offset: 0x0001D375
		private XmlXmlNodeSerializer()
		{
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x0001F17D File Offset: 0x0001D37D
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Complex;
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0001F180 File Offset: 0x0001D380
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			IRealizable<XmlNode> realizable = node.AsRealizable<XmlNode>();
			if (realizable == null || !realizable.IsReal)
			{
				return null;
			}
			return realizable.Value;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			XmlNode xmlNode = (XmlNode)value;
			using (XmlSubtreeWriter xmlSubtreeWriter = new XmlSubtreeWriter(node))
			{
				xmlNode.WriteTo(xmlSubtreeWriter);
			}
		}

		// Token: 0x040002CE RID: 718
		public static readonly XmlXmlNodeSerializer Instance = new XmlXmlNodeSerializer();
	}
}
