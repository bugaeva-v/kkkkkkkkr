using System;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000165 RID: 357
	public class XPathBehaviorAccessor : XmlAccessor, IXmlIncludedType, IXmlIncludedTypeMap, IConfigurable<XPathAttribute>, IConfigurable<XPathVariableAttribute>, IConfigurable<XPathFunctionAttribute>
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x0001A348 File Offset: 0x00018548
		protected XPathBehaviorAccessor(Type type, IXmlContext context) : base(type, context)
		{
			this.includedTypes = new XmlIncludedTypeSet();
			foreach (IXmlIncludedType includedType in context.GetIncludedTypes(base.ClrType))
			{
				this.includedTypes.Add(includedType);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0001A3B4 File Offset: 0x000185B4
		XmlName IXmlIncludedType.XsiType
		{
			get
			{
				return XmlName.Empty;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0001A3BB File Offset: 0x000185BB
		IXmlIncludedType IXmlIncludedTypeMap.Default
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0001A3BE File Offset: 0x000185BE
		private bool SelectsNodes
		{
			get
			{
				return this.path.Path.ReturnType == XPathResultType.NodeSet;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0001A3D4 File Offset: 0x000185D4
		private bool CreatesAttributes
		{
			get
			{
				CompiledXPathStep lastStep = this.path.LastStep;
				return lastStep != null && lastStep.IsAttribute;
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001A3F8 File Offset: 0x000185F8
		public void Configure(XPathAttribute attribute)
		{
			if (this.path != null)
			{
				throw Error.AttributeConflict(this.path.Path.Expression);
			}
			this.path = attribute.SetPath;
			if (this.path == attribute.GetPath)
			{
				return;
			}
			if (base.Serializer.CanGetStub)
			{
				throw Error.SeparateGetterSetterOnComplexType(this.path.Path.Expression);
			}
			this.defaultAccessor = new XPathBehaviorAccessor.DefaultAccessor(this, attribute.GetPath);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001A473 File Offset: 0x00018673
		public void Configure(XPathVariableAttribute attribute)
		{
			base.CloneContext().AddVariable(attribute);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0001A481 File Offset: 0x00018681
		public void Configure(XPathFunctionAttribute attribute)
		{
			base.CloneContext().AddFunction(attribute);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0001A48F File Offset: 0x0001868F
		public override void Prepare()
		{
			if (this.CreatesAttributes)
			{
				this.state &= ~XmlAccessor.States.Nillable;
			}
			base.Context.Enlist(this.path);
			if (this.defaultAccessor != null)
			{
				this.defaultAccessor.Prepare();
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0001A4CC File Offset: 0x000186CC
		public override bool IsPropertyDefined(IXmlNode parentNode)
		{
			return this.SelectsNodes && base.IsPropertyDefined(parentNode);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0001A4DF File Offset: 0x000186DF
		public override object GetPropertyValue(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, bool orStub)
		{
			return this.GetPropertyValueCore(parentNode, parentObject, references, orStub) ?? this.GetDefaultPropertyValue(parentNode, parentObject, references, orStub);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001A4FB File Offset: 0x000186FB
		private object GetPropertyValueCore(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, bool orStub)
		{
			if (!this.SelectsNodes)
			{
				return this.Evaluate(parentNode);
			}
			return base.GetPropertyValue(parentNode, parentObject, references, orStub);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0001A518 File Offset: 0x00018718
		private object GetDefaultPropertyValue(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, bool orStub)
		{
			if (this.defaultAccessor == null)
			{
				return null;
			}
			return this.defaultAccessor.GetPropertyValue(parentNode, parentObject, references, orStub);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0001A534 File Offset: 0x00018734
		private object Evaluate(IXmlNode node)
		{
			object obj = node.Evaluate(this.path);
			if (obj == null)
			{
				return null;
			}
			return Convert.ChangeType(obj, base.ClrType);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0001A55F File Offset: 0x0001875F
		public override void SetPropertyValue(IXmlNode parentNode, IDictionaryAdapter parentObject, XmlReferenceManager references, object oldValue, ref object value)
		{
			if (this.SelectsNodes)
			{
				base.SetPropertyValue(parentNode, parentObject, references, oldValue, ref value);
				return;
			}
			throw Error.XPathNotCreatable(this.path);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0001A584 File Offset: 0x00018784
		public override IXmlCollectionAccessor GetCollectionAccessor(Type itemType)
		{
			XmlAccessor result;
			if ((result = this.itemAccessor) == null)
			{
				result = (this.itemAccessor = new XPathBehaviorAccessor.ItemAccessor(this));
			}
			return result;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0001A5AC File Offset: 0x000187AC
		public override IXmlCursor SelectPropertyNode(IXmlNode node, bool create)
		{
			CursorFlags flags = CursorFlags.AllNodes.MutableIf(create);
			return node.Select(this.path, this, base.Context, flags);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0001A5D5 File Offset: 0x000187D5
		public override IXmlCursor SelectCollectionNode(IXmlNode node, bool create)
		{
			return node.SelectSelf(base.ClrType);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0001A5E4 File Offset: 0x000187E4
		public override IXmlCursor SelectCollectionItems(IXmlNode node, bool create)
		{
			CursorFlags flags = CursorFlags.AllNodes.MutableIf(create) | CursorFlags.Multiple;
			return node.Select(this.path, this, base.Context, flags);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001A610 File Offset: 0x00018810
		public bool TryGet(XmlName xsiType, out IXmlIncludedType includedType)
		{
			if (xsiType == XmlName.Empty || xsiType == base.XsiType)
			{
				return Try.Success<IXmlIncludedType>(out includedType, this);
			}
			return this.includedTypes.TryGet(xsiType, out includedType) && (base.ClrType.IsAssignableFrom(includedType.ClrType) || Try.Failure<IXmlIncludedType>(out includedType));
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0001A66D File Offset: 0x0001886D
		public bool TryGet(Type clrType, out IXmlIncludedType includedType)
		{
			if (!(clrType == base.ClrType))
			{
				return this.includedTypes.TryGet(clrType, out includedType);
			}
			return Try.Success<IXmlIncludedType>(out includedType, this);
		}

		// Token: 0x04000248 RID: 584
		private CompiledXPath path;

		// Token: 0x04000249 RID: 585
		private XmlIncludedTypeSet includedTypes;

		// Token: 0x0400024A RID: 586
		private XmlAccessor defaultAccessor;

		// Token: 0x0400024B RID: 587
		private XmlAccessor itemAccessor;

		// Token: 0x0400024C RID: 588
		internal static readonly XmlAccessorFactory<XPathBehaviorAccessor> Factory = (string name, Type type, IXmlContext context) => new XPathBehaviorAccessor(type, context);

		// Token: 0x0200021D RID: 541
		private class DefaultAccessor : XPathBehaviorAccessor
		{
			// Token: 0x06000F29 RID: 3881 RVA: 0x00023CBD File Offset: 0x00021EBD
			public DefaultAccessor(XPathBehaviorAccessor parent, CompiledXPath path) : base(parent.ClrType, parent.Context)
			{
				this.parent = parent;
				this.path = path;
			}

			// Token: 0x06000F2A RID: 3882 RVA: 0x00023CDF File Offset: 0x00021EDF
			public override void Prepare()
			{
				this.includedTypes = this.parent.includedTypes;
				base.Context = this.parent.Context;
				base.Prepare();
			}

			// Token: 0x04000424 RID: 1060
			private readonly XPathBehaviorAccessor parent;
		}

		// Token: 0x0200021E RID: 542
		private class ItemAccessor : XPathBehaviorAccessor
		{
			// Token: 0x06000F2B RID: 3883 RVA: 0x00023D09 File Offset: 0x00021F09
			public ItemAccessor(XPathBehaviorAccessor parent) : base(parent.ClrType.GetCollectionItemType(), parent.Context)
			{
				this.includedTypes = parent.includedTypes;
				this.path = parent.path;
				this.ConfigureNillable(true);
			}

			// Token: 0x06000F2C RID: 3884 RVA: 0x00023D41 File Offset: 0x00021F41
			public override IXmlCollectionAccessor GetCollectionAccessor(Type itemType)
			{
				return base.GetDefaultCollectionAccessor(itemType);
			}
		}
	}
}
