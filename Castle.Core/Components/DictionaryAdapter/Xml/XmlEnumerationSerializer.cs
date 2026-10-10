using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000193 RID: 403
	public class XmlEnumerationSerializer : XmlStringSerializer
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x0001EA16 File Offset: 0x0001CC16
		protected XmlEnumerationSerializer()
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0001EA1E File Offset: 0x0001CC1E
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Simple;
			}
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0001EA21 File Offset: 0x0001CC21
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			return Enum.Parse(node.ClrType, node.Value, true);
		}

		// Token: 0x040002B0 RID: 688
		public new static readonly XmlEnumerationSerializer Instance = new XmlEnumerationSerializer();
	}
}
