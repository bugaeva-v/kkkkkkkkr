using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000164 RID: 356
	public class XmlSelfAccessor : XmlAccessor
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x0001A316 File Offset: 0x00018516
		public XmlSelfAccessor(Type clrType, IXmlContext context) : base(clrType, context)
		{
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0001A320 File Offset: 0x00018520
		public override void ConfigureNillable(bool nillable)
		{
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0001A322 File Offset: 0x00018522
		public override IXmlCursor SelectPropertyNode(IXmlNode parentNode, bool mutable)
		{
			return parentNode.SelectSelf(base.ClrType);
		}

		// Token: 0x04000247 RID: 583
		internal static readonly XmlAccessorFactory<XmlSelfAccessor> Factory = (string name, Type type, IXmlContext context) => new XmlSelfAccessor(type, context);
	}
}
