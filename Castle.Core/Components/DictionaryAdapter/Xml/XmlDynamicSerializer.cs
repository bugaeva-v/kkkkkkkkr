using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000192 RID: 402
	public class XmlDynamicSerializer : XmlTypeSerializer
	{
		// Token: 0x06000CA7 RID: 3239 RVA: 0x0001E996 File Offset: 0x0001CB96
		protected XmlDynamicSerializer()
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0001E99E File Offset: 0x0001CB9E
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Simple;
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0001E9A1 File Offset: 0x0001CBA1
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			if (!(node.ClrType == typeof(object)))
			{
				return XmlTypeSerializer.For(node.ClrType).GetValue(node, parent, accessor);
			}
			return new object();
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0001E9D3 File Offset: 0x0001CBD3
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			if (node.ClrType != typeof(object))
			{
				XmlTypeSerializer.For(node.ClrType).SetValue(node, parent, accessor, oldValue, ref value);
				return;
			}
			node.Clear();
		}

		// Token: 0x040002AF RID: 687
		public static readonly XmlDynamicSerializer Instance = new XmlDynamicSerializer();
	}
}
