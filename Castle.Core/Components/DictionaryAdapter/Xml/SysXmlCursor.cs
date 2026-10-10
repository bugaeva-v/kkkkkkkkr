using System;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200017A RID: 378
	public class SysXmlCursor : SysXmlNode, IXmlCursor, IXmlIterator, IXmlNode, IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x0001B8A4 File Offset: 0x00019AA4
		public SysXmlCursor(IXmlNode parent, IXmlKnownTypeMap knownTypes, IXmlNamespaceSource namespaces, CursorFlags flags) : base(namespaces, parent)
		{
			if (parent == null)
			{
				throw Error.ArgumentNull("parent");
			}
			if (knownTypes == null)
			{
				throw Error.ArgumentNull("knownTypes");
			}
			this.knownTypes = knownTypes;
			this.flags = flags;
			this.index = -1;
			IRealizable<XmlNode> realizable = parent.RequireRealizable<XmlNode>();
			if (realizable.IsReal)
			{
				this.node = realizable.Value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0001B906 File Offset: 0x00019B06
		public override bool IsReal
		{
			get
			{
				return this.HasCurrent;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0001B90E File Offset: 0x00019B0E
		public bool HasCurrent
		{
			get
			{
				return this.state > SysXmlCursor.State.Initial;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0001B919 File Offset: 0x00019B19
		public override Type ClrType
		{
			get
			{
				if (!this.HasCurrent)
				{
					return this.knownTypes.Default.ClrType;
				}
				return base.ClrType;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0001B93A File Offset: 0x00019B3A
		public override XmlName Name
		{
			get
			{
				if (!this.HasCurrent)
				{
					return this.GetEffectiveName(this.knownTypes.Default, this.node);
				}
				return base.Name;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0001B962 File Offset: 0x00019B62
		public override XmlName XsiType
		{
			get
			{
				if (!this.HasCurrent)
				{
					return this.knownTypes.Default.XsiType;
				}
				return base.XsiType;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0001B983 File Offset: 0x00019B83
		public override bool IsElement
		{
			get
			{
				if (!this.HasCurrent)
				{
					return this.flags.IncludesElements();
				}
				return base.IsElement;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0001B99F File Offset: 0x00019B9F
		public override bool IsAttribute
		{
			get
			{
				if (!this.HasCurrent)
				{
					return !this.flags.IncludesElements();
				}
				return base.IsAttribute;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0001B9BE File Offset: 0x00019BBE
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x0001B9D0 File Offset: 0x00019BD0
		public override bool IsNil
		{
			get
			{
				return this.HasCurrent && base.IsNil;
			}
			set
			{
				this.Realize();
				base.IsNil = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0001B9DF File Offset: 0x00019BDF
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0001B9F5 File Offset: 0x00019BF5
		public override string Value
		{
			get
			{
				if (!this.HasCurrent)
				{
					return string.Empty;
				}
				return base.Value;
			}
			set
			{
				base.Value = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0001B9FE File Offset: 0x00019BFE
		public override string Xml
		{
			get
			{
				if (!this.HasCurrent)
				{
					return null;
				}
				return base.Xml;
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0001BA10 File Offset: 0x00019C10
		public override object Evaluate(CompiledXPath path)
		{
			if (!this.HasCurrent)
			{
				return null;
			}
			return base.Evaluate(path);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0001BA24 File Offset: 0x00019C24
		public bool MoveNext()
		{
			bool hasCurrent = this.HasCurrent;
			bool flag = this.MoveNextCore() && (this.flags.AllowsMultipleItems() || this.IsAtEnd());
			if (!flag && !hasCurrent)
			{
				this.state = SysXmlCursor.State.Empty;
			}
			return flag;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0001BA67 File Offset: 0x00019C67
		private bool MoveNextCore()
		{
			while (this.Advance())
			{
				if (this.IsMatch())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0001BA80 File Offset: 0x00019C80
		private bool IsMatch()
		{
			IXmlKnownType xmlKnownType;
			if (!this.knownTypes.TryGet(this, out xmlKnownType))
			{
				return Try.Failure<Type>(out this.type);
			}
			return Try.Success<Type>(out this.type, xmlKnownType.ClrType);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0001BABC File Offset: 0x00019CBC
		private bool Advance()
		{
			for (;;)
			{
				switch (this.state)
				{
				case SysXmlCursor.State.Empty:
					return false;
				case SysXmlCursor.State.End:
					return false;
				case SysXmlCursor.State.AttributePrimed:
					goto IL_7F;
				case SysXmlCursor.State.ElementPrimed:
					goto IL_77;
				case SysXmlCursor.State.Initial:
					goto IL_2E;
				case SysXmlCursor.State.Element:
					goto IL_49;
				case SysXmlCursor.State.Attribute:
					goto IL_64;
				}
			}
			IL_2E:
			return this.AdvanceToFirstElement() || this.AdvanceToFirstAttribute() || this.Fail(SysXmlCursor.State.End);
			IL_49:
			return this.AdvanceToNextElement() || this.AdvanceToFirstAttribute() || this.Fail(SysXmlCursor.State.End);
			IL_64:
			return this.AdvanceToNextAttribute() || this.Fail(SysXmlCursor.State.End);
			IL_77:
			return this.Succeed(SysXmlCursor.State.Element);
			IL_7F:
			return this.Succeed(SysXmlCursor.State.Attribute);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0001BB53 File Offset: 0x00019D53
		protected virtual bool AdvanceToFirstElement()
		{
			if (!this.flags.IncludesElements() || this.node == null)
			{
				return false;
			}
			if (!this.AdvanceElement(this.node.FirstChild))
			{
				return false;
			}
			this.state = SysXmlCursor.State.Element;
			return true;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0001BB89 File Offset: 0x00019D89
		private bool AdvanceToNextElement()
		{
			if (this.AdvanceElement(this.node.NextSibling))
			{
				return true;
			}
			this.MoveToParentOfElement();
			return false;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0001BBA7 File Offset: 0x00019DA7
		protected virtual bool AdvanceToFirstAttribute()
		{
			if (!this.flags.IncludesAttributes() || this.node == null)
			{
				return false;
			}
			if (!this.AdvanceAttribute(this.node))
			{
				return false;
			}
			this.state = SysXmlCursor.State.Attribute;
			return true;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0001BBD8 File Offset: 0x00019DD8
		private bool AdvanceToNextAttribute()
		{
			if (this.AdvanceAttribute(((XmlAttribute)this.node).OwnerElement))
			{
				return true;
			}
			this.MoveToParentOfAttribute();
			return false;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0001BBFB File Offset: 0x00019DFB
		private bool AdvanceElement(XmlNode next)
		{
			while (next != null)
			{
				if (next.NodeType == XmlNodeType.Element)
				{
					this.node = next;
					return true;
				}
				next = next.NextSibling;
			}
			return false;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0001BC20 File Offset: 0x00019E20
		private bool AdvanceAttribute(XmlNode parent)
		{
			XmlAttributeCollection attributes = parent.Attributes;
			XmlAttribute xmlAttribute;
			for (;;)
			{
				this.index++;
				if (this.index >= attributes.Count)
				{
					break;
				}
				xmlAttribute = attributes[this.index];
				if (!xmlAttribute.IsNamespace())
				{
					goto Block_2;
				}
			}
			return false;
			Block_2:
			this.node = xmlAttribute;
			return true;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0001BC6F File Offset: 0x00019E6F
		private bool Succeed(SysXmlCursor.State state)
		{
			this.state = state;
			return true;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0001BC79 File Offset: 0x00019E79
		private bool Fail(SysXmlCursor.State state)
		{
			this.state = state;
			return false;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0001BC84 File Offset: 0x00019E84
		private bool IsAtEnd()
		{
			XmlNode node = this.node;
			Type type = this.type;
			SysXmlCursor.State state = this.state;
			int num = this.index;
			int num2 = this.MoveNextCore() ? 1 : 0;
			this.node = node;
			this.type = type;
			this.state = state;
			this.index = num;
			return num2 == 0;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0001BCD4 File Offset: 0x00019ED4
		public void MoveTo(IXmlNode position)
		{
			IRealizable<XmlNode> realizable = position.AsRealizable<XmlNode>();
			if (realizable == null || !realizable.IsReal)
			{
				throw Error.CursorCannotMoveToGivenNode();
			}
			IXmlKnownType xmlKnownType;
			if (!this.knownTypes.TryGet(position, out xmlKnownType))
			{
				throw Error.CursorCannotMoveToGivenNode();
			}
			this.node = realizable.Value;
			this.type = xmlKnownType.ClrType;
			if (this.IsElement)
			{
				this.SetMovedToElement();
				return;
			}
			this.SetMovedToAttribute();
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0001BD3C File Offset: 0x00019F3C
		private void SetMovedToElement()
		{
			this.state = SysXmlCursor.State.Element;
			this.index = -1;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0001BD4C File Offset: 0x00019F4C
		private void SetMovedToAttribute()
		{
			this.state = SysXmlCursor.State.Attribute;
			XmlAttributeCollection attributes = ((XmlAttribute)this.node).OwnerElement.Attributes;
			this.index = 0;
			while (this.index < attributes.Count && attributes[this.index] != this.node)
			{
				this.index++;
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		public void MoveToEnd()
		{
			switch (this.state)
			{
			case SysXmlCursor.State.AttributePrimed:
			case SysXmlCursor.State.Attribute:
				this.MoveToParentOfAttribute();
				this.state = SysXmlCursor.State.End;
				return;
			case SysXmlCursor.State.ElementPrimed:
			case SysXmlCursor.State.Element:
				this.MoveToParentOfElement();
				this.state = SysXmlCursor.State.End;
				return;
			case SysXmlCursor.State.Initial:
				this.state = (this.IsAtEnd() ? SysXmlCursor.State.Empty : SysXmlCursor.State.End);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0001BE14 File Offset: 0x0001A014
		public void Reset()
		{
			this.MoveToEnd();
			this.state = SysXmlCursor.State.Initial;
			this.index = -1;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0001BE2A File Offset: 0x0001A02A
		private void MoveToParentOfElement()
		{
			this.node = this.node.ParentNode;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001BE3D File Offset: 0x0001A03D
		private void MoveToParentOfAttribute()
		{
			this.node = ((XmlAttribute)this.node).OwnerElement;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001BE58 File Offset: 0x0001A058
		private void MoveToRealizedParent()
		{
			IXmlNode parent = base.Parent;
			this.node = parent.AsRealizable<XmlNode>().Value;
			parent.IsNil = false;
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000B85 RID: 2949 RVA: 0x0001BE84 File Offset: 0x0001A084
		// (remove) Token: 0x06000B86 RID: 2950 RVA: 0x0001BEBC File Offset: 0x0001A0BC
		public override event EventHandler Realized;

		// Token: 0x06000B87 RID: 2951 RVA: 0x0001BEF1 File Offset: 0x0001A0F1
		protected virtual void OnRealized()
		{
			if (this.Realized != null)
			{
				this.Realized(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0001BF0C File Offset: 0x0001A10C
		protected override void Realize()
		{
			if (this.HasCurrent)
			{
				return;
			}
			if (this.state != SysXmlCursor.State.Empty)
			{
				throw Error.CursorNotInRealizableState();
			}
			if (!this.flags.SupportsMutation())
			{
				throw Error.CursorNotMutable();
			}
			this.Create(this.knownTypes.Default.ClrType);
			this.OnRealized();
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0001BF61 File Offset: 0x0001A161
		public void MakeNext(Type clrType)
		{
			if (this.MoveNext())
			{
				this.Coerce(clrType);
				return;
			}
			this.Create(clrType);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0001BF7C File Offset: 0x0001A17C
		public void Coerce(Type clrType)
		{
			this.RequireCoercible();
			IXmlKnownType xmlKnownType = this.knownTypes.Require(clrType);
			if (this.IsElement)
			{
				this.CoerceElement(xmlKnownType);
			}
			else
			{
				this.CoerceAttribute(xmlKnownType);
			}
			this.type = xmlKnownType.ClrType;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		private void CoerceElement(IXmlKnownType knownType)
		{
			XmlElement xmlElement = (XmlElement)this.node;
			XmlNode parentNode = xmlElement.ParentNode;
			XmlName effectiveName = this.GetEffectiveName(knownType, parentNode);
			if (!XmlNameComparer.Default.Equals(this.Name, effectiveName))
			{
				XmlElement newChild = this.CreateElementCore(parentNode, effectiveName);
				parentNode.ReplaceChild(newChild, xmlElement);
				if (knownType.XsiType != XmlName.Empty)
				{
					this.SetXsiType(knownType.XsiType);
					return;
				}
			}
			else
			{
				this.SetXsiType(knownType.XsiType);
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0001C03C File Offset: 0x0001A23C
		private void CoerceAttribute(IXmlKnownType knownType)
		{
			this.RequireNoXsiType(knownType);
			XmlAttribute xmlAttribute = (XmlAttribute)this.node;
			XmlElement ownerElement = xmlAttribute.OwnerElement;
			XmlName effectiveName = this.GetEffectiveName(knownType, ownerElement);
			if (!XmlNameComparer.Default.Equals(this.Name, effectiveName))
			{
				XmlAttribute xmlAttribute2 = this.CreateAttributeCore(ownerElement, effectiveName);
				XmlAttributeCollection attributes = ownerElement.Attributes;
				attributes.RemoveNamedItem(xmlAttribute2.LocalName, xmlAttribute2.NamespaceURI);
				attributes.InsertBefore(xmlAttribute2, xmlAttribute);
				attributes.Remove(xmlAttribute);
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
		public void Create(Type type)
		{
			IXmlKnownType xmlKnownType = this.knownTypes.Require(type);
			XmlNode position = this.RequireCreatable();
			if (this.flags.IncludesElements())
			{
				this.CreateElement(xmlKnownType, position);
			}
			else
			{
				this.CreateAttribute(xmlKnownType, position);
			}
			this.type = xmlKnownType.ClrType;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0001C100 File Offset: 0x0001A300
		private void CreateElement(IXmlKnownType knownType, XmlNode position)
		{
			XmlNode node = this.node;
			XmlName effectiveName = this.GetEffectiveName(knownType, node);
			XmlElement newChild = this.CreateElementCore(node, effectiveName);
			node.InsertBefore(newChild, position);
			this.state = SysXmlCursor.State.Element;
			if (knownType.XsiType != XmlName.Empty)
			{
				this.SetXsiType(knownType.XsiType);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0001C154 File Offset: 0x0001A354
		private void CreateAttribute(IXmlKnownType knownType, XmlNode position)
		{
			this.RequireNoXsiType(knownType);
			XmlNode node = this.node;
			XmlName effectiveName = this.GetEffectiveName(knownType, node);
			XmlAttribute newNode = this.CreateAttributeCore(node, effectiveName);
			node.Attributes.InsertBefore(newNode, (XmlAttribute)position);
			this.state = SysXmlCursor.State.Attribute;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0001C19C File Offset: 0x0001A39C
		private XmlElement CreateElementCore(XmlNode parent, XmlName name)
		{
			XmlDocument xmlDocument = parent.OwnerDocument ?? ((XmlDocument)parent);
			string elementPrefix = base.Namespaces.GetElementPrefix(this, name.NamespaceUri);
			XmlElement xmlElement = xmlDocument.CreateElement(elementPrefix, name.LocalName, name.NamespaceUri);
			this.node = xmlElement;
			return xmlElement;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		private XmlAttribute CreateAttributeCore(XmlNode parent, XmlName name)
		{
			XmlDocument xmlDocument = parent.OwnerDocument ?? ((XmlDocument)parent);
			string attributePrefix = base.Namespaces.GetAttributePrefix(this, name.NamespaceUri);
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute(attributePrefix, name.LocalName, name.NamespaceUri);
			this.node = xmlAttribute;
			return xmlAttribute;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0001C23A File Offset: 0x0001A43A
		private void RequireNoXsiType(IXmlKnownType knownType)
		{
			if (knownType.XsiType != XmlName.Empty)
			{
				throw Error.CannotSetAttribute(this);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0001C258 File Offset: 0x0001A458
		private XmlName GetEffectiveName(IXmlKnownType knownType, XmlNode parent)
		{
			XmlName name = knownType.Name;
			if (name.NamespaceUri == null)
			{
				return name.WithNamespaceUri((parent != null) ? parent.NamespaceURI : string.Empty);
			}
			return name;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0001C28E File Offset: 0x0001A48E
		public void RemoveAllNext()
		{
			while (this.MoveNext())
			{
				this.Remove();
			}
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0001C2A0 File Offset: 0x0001A4A0
		public void Remove()
		{
			this.RequireRemovable();
			XmlNode node = this.node;
			bool isElement = this.IsElement;
			this.MoveNext();
			SysXmlCursor.State state = this.state;
			if (state != SysXmlCursor.State.Element)
			{
				if (state == SysXmlCursor.State.Attribute)
				{
					this.state = SysXmlCursor.State.AttributePrimed;
				}
			}
			else
			{
				this.state = SysXmlCursor.State.ElementPrimed;
			}
			if (isElement)
			{
				this.RemoveElement(node);
				return;
			}
			this.RemoveAttribute(node);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0001C2FA File Offset: 0x0001A4FA
		private void RemoveElement(XmlNode node)
		{
			node.ParentNode.RemoveChild(node);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0001C30C File Offset: 0x0001A50C
		private void RemoveAttribute(XmlNode node)
		{
			XmlAttribute xmlAttribute = (XmlAttribute)node;
			xmlAttribute.OwnerElement.Attributes.Remove(xmlAttribute);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0001C332 File Offset: 0x0001A532
		public override IXmlNode Save()
		{
			if (!this.HasCurrent)
			{
				return this;
			}
			return new SysXmlNode(this.node, this.type, base.Namespaces);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0001C358 File Offset: 0x0001A558
		private XmlNode RequireCreatable()
		{
			switch (this.state)
			{
			case SysXmlCursor.State.Empty:
			{
				XmlNode result = null;
				this.MoveToRealizedParent();
				return result;
			}
			case SysXmlCursor.State.End:
				return null;
			case SysXmlCursor.State.Element:
			{
				XmlNode result = this.node;
				this.MoveToParentOfElement();
				return result;
			}
			case SysXmlCursor.State.Attribute:
			{
				XmlNode result = this.node;
				this.MoveToParentOfAttribute();
				return result;
			}
			}
			throw Error.CursorNotInCreatableState();
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0001C3C6 File Offset: 0x0001A5C6
		private void RequireCoercible()
		{
			if (this.state <= SysXmlCursor.State.Initial)
			{
				throw Error.CursorNotInCoercibleState();
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0001C3D7 File Offset: 0x0001A5D7
		private void RequireRemovable()
		{
			if (this.state <= SysXmlCursor.State.Initial)
			{
				throw Error.CursorNotInRemovableState();
			}
		}

		// Token: 0x04000273 RID: 627
		private SysXmlCursor.State state;

		// Token: 0x04000274 RID: 628
		private int index;

		// Token: 0x04000275 RID: 629
		private readonly IXmlKnownTypeMap knownTypes;

		// Token: 0x04000276 RID: 630
		private readonly CursorFlags flags;

		// Token: 0x04000278 RID: 632
		protected static readonly StringComparer DefaultComparer = StringComparer.OrdinalIgnoreCase;

		// Token: 0x02000221 RID: 545
		protected enum State
		{
			// Token: 0x0400042A RID: 1066
			Empty = -4,
			// Token: 0x0400042B RID: 1067
			End,
			// Token: 0x0400042C RID: 1068
			AttributePrimed,
			// Token: 0x0400042D RID: 1069
			ElementPrimed,
			// Token: 0x0400042E RID: 1070
			Initial,
			// Token: 0x0400042F RID: 1071
			Element,
			// Token: 0x04000430 RID: 1072
			Attribute
		}
	}
}
