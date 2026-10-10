using System;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000191 RID: 401
	public class XmlDefaultSerializer : XmlTypeSerializer
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x0001E8C4 File Offset: 0x0001CAC4
		public XmlDefaultSerializer(Type type)
		{
			this.serializer = new XmlSerializer(type, XmlDefaultSerializer.Root);
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0001E8DD File Offset: 0x0001CADD
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Complex;
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0001E8E0 File Offset: 0x0001CAE0
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			object result;
			using (XmlSubtreeReader xmlSubtreeReader = new XmlSubtreeReader(node, XmlDefaultSerializer.Root))
			{
				result = (this.serializer.CanDeserialize(xmlSubtreeReader) ? this.serializer.Deserialize(xmlSubtreeReader) : null);
			}
			return result;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0001E934 File Offset: 0x0001CB34
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			using (XmlSubtreeWriter xmlSubtreeWriter = new XmlSubtreeWriter(node))
			{
				this.serializer.Serialize(xmlSubtreeWriter, value);
			}
		}

		// Token: 0x040002AD RID: 685
		private readonly XmlSerializer serializer;

		// Token: 0x040002AE RID: 686
		public static readonly XmlRootAttribute Root = new XmlRootAttribute
		{
			ElementName = "Root",
			Namespace = string.Empty
		};
	}
}
