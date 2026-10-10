using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000160 RID: 352
	public class XmlDefaultBehaviorAccessor : XmlNodeAccessor
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x00019C7C File Offset: 0x00017E7C
		public XmlDefaultBehaviorAccessor(Type type, IXmlContext context) : base(type, context)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00019C86 File Offset: 0x00017E86
		public XmlDefaultBehaviorAccessor(string name, Type type, IXmlContext context) : base(name, type, context)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00019C94 File Offset: 0x00017E94
		public override IXmlCursor SelectPropertyNode(IXmlNode node, bool mutable)
		{
			CursorFlags flags = (base.Serializer.Kind == XmlTypeKind.Simple) ? CursorFlags.AllNodes : CursorFlags.Elements;
			return node.SelectChildren(base.KnownTypes, base.Context, flags.MutableIf(mutable));
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00019CCC File Offset: 0x00017ECC
		public override IXmlCursor SelectCollectionNode(IXmlNode node, bool mutable)
		{
			return this.SelectPropertyNode(node, mutable);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00019CD8 File Offset: 0x00017ED8
		public override IXmlCursor SelectCollectionItems(IXmlNode node, bool mutable)
		{
			CursorFlags flags = CursorFlags.Elements | CursorFlags.Multiple;
			return node.SelectChildren(base.KnownTypes, base.Context, flags.MutableIf(mutable));
		}

		// Token: 0x0400023E RID: 574
		internal static readonly XmlAccessorFactory<XmlDefaultBehaviorAccessor> Factory = (string name, Type type, IXmlContext context) => new XmlDefaultBehaviorAccessor(name, type, context);
	}
}
