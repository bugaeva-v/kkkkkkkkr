using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200018F RID: 399
	public class XmlComponentSerializer : XmlTypeSerializer
	{
		// Token: 0x06000C96 RID: 3222 RVA: 0x0001E6F5 File Offset: 0x0001C8F5
		protected XmlComponentSerializer()
		{
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0001E6FD File Offset: 0x0001C8FD
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Complex;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0001E700 File Offset: 0x0001C900
		public override bool CanGetStub
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0001E704 File Offset: 0x0001C904
		public override object GetStub(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			XmlAdapter adapter = new XmlAdapter(node, XmlAdapter.For(parent).References);
			return parent.CreateChildAdapter(accessor.ClrType, adapter);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0001E730 File Offset: 0x0001C930
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			XmlAdapter adapter = new XmlAdapter(node.Save(), XmlAdapter.For(parent).References);
			return parent.CreateChildAdapter(node.ClrType, adapter);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0001E764 File Offset: 0x0001C964
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			IDictionaryAdapter dictionaryAdapter = value as IDictionaryAdapter;
			if (dictionaryAdapter == null)
			{
				throw Error.NotDictionaryAdapter("value");
			}
			XmlAdapter xmlAdapter = XmlAdapter.For(dictionaryAdapter, false);
			if (xmlAdapter != null && node.PositionEquals(xmlAdapter.Node))
			{
				return;
			}
			XmlAdapter xmlAdapter2 = new XmlAdapter(node.Save(), XmlAdapter.For(parent).References);
			if (xmlAdapter != null)
			{
				xmlAdapter2.References.UnionWith(xmlAdapter.References);
			}
			IDictionaryAdapter dictionaryAdapter2 = (IDictionaryAdapter)parent.CreateChildAdapter(node.ClrType, xmlAdapter2);
			dictionaryAdapter.CopyTo(dictionaryAdapter2);
			value = dictionaryAdapter2;
		}

		// Token: 0x040002AB RID: 683
		public static readonly XmlComponentSerializer Instance = new XmlComponentSerializer();
	}
}
