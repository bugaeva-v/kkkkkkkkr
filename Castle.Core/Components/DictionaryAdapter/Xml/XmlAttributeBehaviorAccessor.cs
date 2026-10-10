using System;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200015F RID: 351
	public class XmlAttributeBehaviorAccessor : XmlNodeAccessor, IConfigurable<XmlAttributeAttribute>
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x00019C05 File Offset: 0x00017E05
		public XmlAttributeBehaviorAccessor(string name, Type type, IXmlContext context) : base(name, type, context)
		{
			if (base.Serializer.Kind != XmlTypeKind.Simple)
			{
				throw Error.NotSupported();
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00019C23 File Offset: 0x00017E23
		public void Configure(XmlAttributeAttribute attribute)
		{
			base.ConfigureLocalName(attribute.AttributeName);
			base.ConfigureNamespaceUri(attribute.Namespace);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00019C3D File Offset: 0x00017E3D
		public override void ConfigureNillable(bool nillable)
		{
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00019C3F File Offset: 0x00017E3F
		public override void ConfigureReference(bool isReference)
		{
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00019C41 File Offset: 0x00017E41
		public override IXmlCollectionAccessor GetCollectionAccessor(Type itemType)
		{
			throw Error.NotSupported();
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00019C48 File Offset: 0x00017E48
		public override IXmlCursor SelectPropertyNode(IXmlNode node, bool mutable)
		{
			return node.SelectChildren(this, base.Context, CursorFlags.Attributes.MutableIf(mutable));
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00019C5E File Offset: 0x00017E5E
		public override IXmlCursor SelectCollectionNode(IXmlNode node, bool mutable)
		{
			throw Error.NotSupported();
		}

		// Token: 0x0400023D RID: 573
		internal static readonly XmlAccessorFactory<XmlAttributeBehaviorAccessor> Factory = (string name, Type type, IXmlContext context) => new XmlAttributeBehaviorAccessor(name, type, context);
	}
}
