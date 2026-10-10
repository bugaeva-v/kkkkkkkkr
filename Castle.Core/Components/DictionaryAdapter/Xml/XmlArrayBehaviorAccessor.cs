using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200015E RID: 350
	public class XmlArrayBehaviorAccessor : XmlNodeAccessor, IConfigurable<XmlArrayAttribute>, IConfigurable<XmlArrayItemAttribute>
	{
		// Token: 0x06000A3D RID: 2621 RVA: 0x00019B52 File Offset: 0x00017D52
		public XmlArrayBehaviorAccessor(string name, Type type, IXmlContext context) : base(name, type, context)
		{
			if (base.Serializer.Kind != XmlTypeKind.Collection)
			{
				throw Error.AttributeConflict(name);
			}
			this.itemAccessor = new XmlArrayBehaviorAccessor.ItemAccessor(base.ClrType.GetCollectionItemType(), this);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00019B89 File Offset: 0x00017D89
		public void Configure(XmlArrayAttribute attribute)
		{
			base.ConfigureLocalName(attribute.ElementName);
			base.ConfigureNamespaceUri(attribute.Namespace);
			this.ConfigureNillable(attribute.IsNullable);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00019BAF File Offset: 0x00017DAF
		public void Configure(XmlArrayItemAttribute attribute)
		{
			this.itemAccessor.Configure(attribute);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00019BBD File Offset: 0x00017DBD
		public override void Prepare()
		{
			base.Prepare();
			this.itemAccessor.Prepare();
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00019BD0 File Offset: 0x00017DD0
		public override IXmlCollectionAccessor GetCollectionAccessor(Type itemType)
		{
			return this.itemAccessor;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00019BD8 File Offset: 0x00017DD8
		public override IXmlCursor SelectPropertyNode(IXmlNode node, bool mutable)
		{
			return node.SelectChildren(this, base.Context, CursorFlags.Elements.MutableIf(mutable));
		}

		// Token: 0x04000239 RID: 569
		private readonly XmlArrayBehaviorAccessor.ItemAccessor itemAccessor;

		// Token: 0x0400023A RID: 570
		internal static readonly XmlAccessorFactory<XmlArrayBehaviorAccessor> Factory = (string name, Type type, IXmlContext context) => new XmlArrayBehaviorAccessor(name, type, context);

		// Token: 0x0400023B RID: 571
		private const CursorFlags PropertyFlags = CursorFlags.Elements;

		// Token: 0x0400023C RID: 572
		private const CursorFlags CollectionItemFlags = CursorFlags.Elements | CursorFlags.Multiple;

		// Token: 0x02000215 RID: 533
		private class ItemAccessor : XmlNodeAccessor, IConfigurable<XmlArrayItemAttribute>, IXmlBehaviorSemantics<XmlArrayItemAttribute>
		{
			// Token: 0x06000F04 RID: 3844 RVA: 0x00023A6D File Offset: 0x00021C6D
			public ItemAccessor(Type itemClrType, XmlNodeAccessor accessor) : base(itemClrType, accessor.Context)
			{
				this.ConfigureNillable(true);
				this.ConfigureReference(accessor.IsReference);
			}

			// Token: 0x06000F05 RID: 3845 RVA: 0x00023A90 File Offset: 0x00021C90
			public void Configure(XmlArrayItemAttribute attribute)
			{
				if (attribute.Type == null)
				{
					base.ConfigureLocalName(attribute.ElementName);
					base.ConfigureNamespaceUri(attribute.Namespace);
					this.ConfigureNillable(attribute.IsNullable);
					return;
				}
				if (this.attributes == null)
				{
					this.attributes = new List<XmlArrayItemAttribute>();
				}
				this.attributes.Add(attribute);
			}

			// Token: 0x06000F06 RID: 3846 RVA: 0x00023AEF File Offset: 0x00021CEF
			public override void Prepare()
			{
				if (this.attributes != null)
				{
					base.ConfigureKnownTypesFromAttributes<XmlArrayItemAttribute>(this.attributes, this);
					this.attributes = null;
				}
				base.Prepare();
			}

			// Token: 0x06000F07 RID: 3847 RVA: 0x00023B13 File Offset: 0x00021D13
			public override IXmlCursor SelectCollectionItems(IXmlNode node, bool mutable)
			{
				return node.SelectChildren(base.KnownTypes, base.Context, (CursorFlags.Elements | CursorFlags.Multiple).MutableIf(mutable));
			}

			// Token: 0x06000F08 RID: 3848 RVA: 0x00023B2E File Offset: 0x00021D2E
			public string GetLocalName(XmlArrayItemAttribute attribute)
			{
				return attribute.ElementName;
			}

			// Token: 0x06000F09 RID: 3849 RVA: 0x00023B36 File Offset: 0x00021D36
			public string GetNamespaceUri(XmlArrayItemAttribute attribute)
			{
				return attribute.Namespace;
			}

			// Token: 0x06000F0A RID: 3850 RVA: 0x00023B3E File Offset: 0x00021D3E
			public Type GetClrType(XmlArrayItemAttribute attribute)
			{
				return attribute.Type;
			}

			// Token: 0x0400041D RID: 1053
			private List<XmlArrayItemAttribute> attributes;
		}
	}
}
