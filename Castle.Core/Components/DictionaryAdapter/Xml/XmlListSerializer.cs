using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000194 RID: 404
	public class XmlListSerializer : XmlCollectionSerializer
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x0001EA41 File Offset: 0x0001CC41
		protected XmlListSerializer()
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0001EA49 File Offset: 0x0001CC49
		public override Type ListTypeConstructor
		{
			get
			{
				return typeof(XmlNodeList<>);
			}
		}

		// Token: 0x040002B1 RID: 689
		public static readonly XmlListSerializer Instance = new XmlListSerializer();
	}
}
