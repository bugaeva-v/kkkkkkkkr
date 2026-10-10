using System;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000190 RID: 400
	public class XmlCustomSerializer : XmlTypeSerializer
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x0001E7F7 File Offset: 0x0001C9F7
		private XmlCustomSerializer()
		{
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0001E7FF File Offset: 0x0001C9FF
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Complex;
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0001E804 File Offset: 0x0001CA04
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			IXmlSerializable xmlSerializable = (IXmlSerializable)Activator.CreateInstance(node.ClrType);
			using (XmlSubtreeReader xmlSubtreeReader = new XmlSubtreeReader(node, XmlDefaultSerializer.Root))
			{
				xmlSerializable.ReadXml(xmlSubtreeReader);
			}
			return xmlSerializable;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0001E854 File Offset: 0x0001CA54
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			IXmlSerializable xmlSerializable = (IXmlSerializable)value;
			XmlRootAttribute root = XmlDefaultSerializer.Root;
			using (XmlSubtreeWriter xmlSubtreeWriter = new XmlSubtreeWriter(node))
			{
				xmlSubtreeWriter.WriteStartElement(string.Empty, root.ElementName, root.Namespace);
				xmlSerializable.WriteXml(xmlSubtreeWriter);
				xmlSubtreeWriter.WriteEndElement();
			}
		}

		// Token: 0x040002AC RID: 684
		public static readonly XmlCustomSerializer Instance = new XmlCustomSerializer();
	}
}
