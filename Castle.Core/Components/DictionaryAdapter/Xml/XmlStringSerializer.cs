using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000198 RID: 408
	public class XmlStringSerializer : XmlTypeSerializer
	{
		// Token: 0x06000CBD RID: 3261 RVA: 0x0001ED7B File Offset: 0x0001CF7B
		protected XmlStringSerializer()
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0001ED83 File Offset: 0x0001CF83
		public override XmlTypeKind Kind
		{
			get
			{
				return XmlTypeKind.Simple;
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0001ED86 File Offset: 0x0001CF86
		public override object GetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor)
		{
			return node.Value;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0001ED8E File Offset: 0x0001CF8E
		public override void SetValue(IXmlNode node, IDictionaryAdapter parent, IXmlAccessor accessor, object oldValue, ref object value)
		{
			node.Value = value.ToString();
		}

		// Token: 0x040002C8 RID: 712
		public static readonly XmlStringSerializer Instance = new XmlStringSerializer();
	}
}
