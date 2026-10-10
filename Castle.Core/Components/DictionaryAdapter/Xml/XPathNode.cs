using System;
using System.Xml;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000186 RID: 390
	public class XPathNode : XmlNodeBase, IXmlNode, IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual, IRealizable<XPathNavigator>, IRealizable<XmlNode>
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x0001DCEB File Offset: 0x0001BEEB
		protected XPathNode(CompiledXPath path, IXmlNamespaceSource namespaces, IXmlNode parent) : base(namespaces, parent)
		{
			this.xpath = path;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0001DCFC File Offset: 0x0001BEFC
		public XPathNode(XPathNavigator node, Type type, IXmlNamespaceSource namespaces) : this(null, namespaces, null)
		{
			if (node == null)
			{
				throw Error.ArgumentNull("node");
			}
			if (type == null)
			{
				throw Error.ArgumentNull("type");
			}
			this.node = node;
			this.type = type;
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0001DD37 File Offset: 0x0001BF37
		public object UnderlyingObject
		{
			get
			{
				return this.node;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0001DD3F File Offset: 0x0001BF3F
		XPathNavigator IRealizable<XPathNavigator>.Value
		{
			get
			{
				this.Realize();
				return this.node;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0001DD4D File Offset: 0x0001BF4D
		XmlNode IRealizable<XmlNode>.Value
		{
			get
			{
				this.Realize();
				return (XmlNode)this.node.UnderlyingObject;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0001DD65 File Offset: 0x0001BF65
		public override CompiledXPath Path
		{
			get
			{
				return this.xpath;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0001DD6D File Offset: 0x0001BF6D
		public virtual XmlName Name
		{
			get
			{
				return new XmlName(this.node.LocalName, this.node.NamespaceURI);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0001DD8A File Offset: 0x0001BF8A
		public virtual XmlName XsiType
		{
			get
			{
				return this.GetXsiType();
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0001DD92 File Offset: 0x0001BF92
		public virtual bool IsElement
		{
			get
			{
				return this.node.NodeType == XPathNodeType.Element;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0001DDA2 File Offset: 0x0001BFA2
		public virtual bool IsAttribute
		{
			get
			{
				return this.node.NodeType == XPathNodeType.Attribute;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0001DDB2 File Offset: 0x0001BFB2
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0001DDBA File Offset: 0x0001BFBA
		public virtual bool IsNil
		{
			get
			{
				return this.IsXsiNil();
			}
			set
			{
				this.SetXsiNil(value);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0001DDC3 File Offset: 0x0001BFC3
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0001DDD0 File Offset: 0x0001BFD0
		public virtual string Value
		{
			get
			{
				return this.node.Value;
			}
			set
			{
				bool flag = value == null;
				this.IsNil = flag;
				if (!flag)
				{
					this.node.SetValue(value);
				}
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0001DDF8 File Offset: 0x0001BFF8
		public virtual string Xml
		{
			get
			{
				return this.node.OuterXml;
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0001DE08 File Offset: 0x0001C008
		public string GetAttribute(XmlName name)
		{
			if (!this.IsReal || !this.node.MoveToAttribute(name.LocalName, name.NamespaceUri))
			{
				return null;
			}
			string value = this.node.Value;
			this.node.MoveToParent();
			if (!string.IsNullOrEmpty(value))
			{
				return value;
			}
			return null;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0001DE5D File Offset: 0x0001C05D
		public void SetAttribute(XmlName name, string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				this.ClearAttribute(name);
				return;
			}
			this.SetAttributeCore(name, value);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0001DE78 File Offset: 0x0001C078
		private void SetAttributeCore(XmlName name, string value)
		{
			if (!this.IsElement)
			{
				throw Error.CannotSetAttribute(this);
			}
			this.Realize();
			if (this.node.MoveToAttribute(name.LocalName, name.NamespaceUri))
			{
				this.node.SetValue(value);
				this.node.MoveToParent();
				return;
			}
			string attributePrefix = base.Namespaces.GetAttributePrefix(this, name.NamespaceUri);
			this.node.CreateAttribute(attributePrefix, name.LocalName, name.NamespaceUri, value);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0001DEFD File Offset: 0x0001C0FD
		private void ClearAttribute(XmlName name)
		{
			if (this.IsReal && this.node.MoveToAttribute(name.LocalName, name.NamespaceUri))
			{
				this.node.DeleteSelf();
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0001DF2D File Offset: 0x0001C12D
		public string LookupPrefix(string namespaceUri)
		{
			return this.node.LookupPrefix(namespaceUri);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0001DF3B File Offset: 0x0001C13B
		public string LookupNamespaceUri(string prefix)
		{
			return this.node.LookupNamespace(prefix);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0001DF4C File Offset: 0x0001C14C
		public void DefineNamespace(string prefix, string namespaceUri, bool root)
		{
			(root ? this.node.GetRootElement() : (this.IsElement ? this.node : (this.IsAttribute ? this.node.GetParent() : this.node.GetRootElement()))).CreateAttribute("xmlns", prefix, "http://www.w3.org/2000/xmlns/", namespaceUri);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0001DFAC File Offset: 0x0001C1AC
		public bool UnderlyingPositionEquals(IXmlNode node)
		{
			IRealizable<XmlNode> realizable = node.AsRealizable<XmlNode>();
			if (realizable != null)
			{
				return realizable.IsReal && realizable.Value == this.node.UnderlyingObject;
			}
			IRealizable<XPathNavigator> realizable2 = node.AsRealizable<XPathNavigator>();
			return realizable2 != null && realizable2.IsReal && realizable2.Value.IsSamePosition(this.node);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0001E008 File Offset: 0x0001C208
		public virtual IXmlNode Save()
		{
			return this;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0001E00B File Offset: 0x0001C20B
		public IXmlCursor SelectSelf(Type clrType)
		{
			return new XmlSelfCursor(this, clrType);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0001E014 File Offset: 0x0001C214
		public IXmlCursor SelectChildren(IXmlKnownTypeMap knownTypes, IXmlNamespaceSource namespaces, CursorFlags flags)
		{
			return new SysXmlCursor(this, knownTypes, namespaces, flags);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0001E01F File Offset: 0x0001C21F
		public IXmlIterator SelectSubtree()
		{
			return new SysXmlSubtreeIterator(this, base.Namespaces);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0001E030 File Offset: 0x0001C230
		public IXmlCursor Select(CompiledXPath path, IXmlIncludedTypeMap includedTypes, IXmlNamespaceSource namespaces, CursorFlags flags)
		{
			if (!flags.SupportsMutation())
			{
				return new XPathReadOnlyCursor(this, path, includedTypes, namespaces, flags);
			}
			return new XPathMutableCursor(this, path, includedTypes, namespaces, flags);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0001E061 File Offset: 0x0001C261
		public virtual object Evaluate(CompiledXPath path)
		{
			return this.node.Evaluate(path.Path);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0001E074 File Offset: 0x0001C274
		public virtual XmlReader ReadSubtree()
		{
			return this.node.ReadSubtree();
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0001E081 File Offset: 0x0001C281
		public virtual XmlWriter WriteAttributes()
		{
			return this.node.CreateAttributes();
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0001E08E File Offset: 0x0001C28E
		public virtual XmlWriter WriteChildren()
		{
			return this.node.AppendChild();
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0001E09B File Offset: 0x0001C29B
		public virtual void Clear()
		{
			this.node.DeleteChildren();
		}

		// Token: 0x04000292 RID: 658
		protected XPathNavigator node;

		// Token: 0x04000293 RID: 659
		protected readonly CompiledXPath xpath;
	}
}
