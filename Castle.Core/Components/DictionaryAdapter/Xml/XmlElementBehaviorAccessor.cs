using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000161 RID: 353
	public class XmlElementBehaviorAccessor : XmlNodeAccessor, IConfigurable<XmlElementAttribute>, IXmlBehaviorSemantics<XmlElementAttribute>
	{
		// Token: 0x06000A52 RID: 2642 RVA: 0x00019D17 File Offset: 0x00017F17
		public XmlElementBehaviorAccessor(string name, Type type, IXmlContext context) : base(name, type, context)
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00019D24 File Offset: 0x00017F24
		public void Configure(XmlElementAttribute attribute)
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
				this.attributes = new List<XmlElementAttribute>();
			}
			this.attributes.Add(attribute);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00019D83 File Offset: 0x00017F83
		public override void Prepare()
		{
			if (this.attributes != null)
			{
				base.ConfigureKnownTypesFromAttributes<XmlElementAttribute>(this.attributes, this);
				this.attributes = null;
			}
			base.Prepare();
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00019DA7 File Offset: 0x00017FA7
		public override void SetValue(IXmlCursor cursor, IDictionaryAdapter parentObject, XmlReferenceManager references, bool hasCurrent, object oldValue, ref object newValue)
		{
			if (newValue == null && base.IsCollection)
			{
				base.RemoveCollectionItems(cursor, references, oldValue);
				return;
			}
			base.SetValue(cursor, parentObject, references, hasCurrent, oldValue, ref newValue);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00019DD0 File Offset: 0x00017FD0
		public override IXmlCollectionAccessor GetCollectionAccessor(Type itemType)
		{
			XmlElementBehaviorAccessor.ItemAccessor result;
			if ((result = this.itemAccessor) == null)
			{
				result = (this.itemAccessor = new XmlElementBehaviorAccessor.ItemAccessor(this));
			}
			return result;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00019DF6 File Offset: 0x00017FF6
		public override IXmlCursor SelectPropertyNode(IXmlNode node, bool mutable)
		{
			return node.SelectChildren(base.KnownTypes, base.Context, CursorFlags.Elements.MutableIf(mutable));
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00019E11 File Offset: 0x00018011
		public override IXmlCursor SelectCollectionNode(IXmlNode node, bool mutable)
		{
			return node.SelectSelf(base.ClrType);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00019E1F File Offset: 0x0001801F
		public string GetLocalName(XmlElementAttribute attribute)
		{
			return attribute.ElementName;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00019E27 File Offset: 0x00018027
		public string GetNamespaceUri(XmlElementAttribute attribute)
		{
			return attribute.Namespace;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00019E2F File Offset: 0x0001802F
		public Type GetClrType(XmlElementAttribute attribute)
		{
			return attribute.Type;
		}

		// Token: 0x0400023F RID: 575
		private XmlElementBehaviorAccessor.ItemAccessor itemAccessor;

		// Token: 0x04000240 RID: 576
		private List<XmlElementAttribute> attributes;

		// Token: 0x04000241 RID: 577
		internal static readonly XmlAccessorFactory<XmlElementBehaviorAccessor> Factory = (string name, Type type, IXmlContext context) => new XmlElementBehaviorAccessor(name, type, context);

		// Token: 0x02000219 RID: 537
		private class ItemAccessor : XmlNodeAccessor
		{
			// Token: 0x06000F14 RID: 3860 RVA: 0x00023BA0 File Offset: 0x00021DA0
			public ItemAccessor(XmlNodeAccessor parent) : base(parent.ClrType.GetCollectionItemType(), parent.Context)
			{
				base.ConfigureLocalName(parent.Name.LocalName);
				base.ConfigureNamespaceUri(parent.Name.NamespaceUri);
				this.ConfigureNillable(parent.IsNillable);
				this.ConfigureReference(parent.IsReference);
				base.ConfigureKnownTypesFromParent(parent);
			}

			// Token: 0x06000F15 RID: 3861 RVA: 0x00023C0B File Offset: 0x00021E0B
			public override void Prepare()
			{
			}

			// Token: 0x06000F16 RID: 3862 RVA: 0x00023C0D File Offset: 0x00021E0D
			public override IXmlCursor SelectCollectionItems(IXmlNode node, bool mutable)
			{
				return node.SelectChildren(base.KnownTypes, base.Context, CursorFlags.Elements.MutableIf(mutable) | CursorFlags.Multiple);
			}
		}
	}
}
