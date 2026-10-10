using System;
using System.Xml;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200017C RID: 380
	public class SysXmlNode : XmlNodeBase, IXmlNode, IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual, IRealizable<XmlNode>, IRealizable<XPathNavigator>
	{
		// Token: 0x06000BA1 RID: 2977 RVA: 0x0001C4B9 File Offset: 0x0001A6B9
		protected SysXmlNode(IXmlNamespaceSource namespaces, IXmlNode parent) : base(namespaces, parent)
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0001C4C3 File Offset: 0x0001A6C3
		public SysXmlNode(XmlNode node, Type type, IXmlNamespaceSource namespaces) : base(namespaces, null)
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0001C4FD File Offset: 0x0001A6FD
		public object UnderlyingObject
		{
			get
			{
				return this.node;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0001C505 File Offset: 0x0001A705
		XmlNode IRealizable<XmlNode>.Value
		{
			get
			{
				this.Realize();
				return this.node;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0001C513 File Offset: 0x0001A713
		XPathNavigator IRealizable<XPathNavigator>.Value
		{
			get
			{
				this.Realize();
				return this.node.CreateNavigator();
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0001C526 File Offset: 0x0001A726
		public virtual XmlName Name
		{
			get
			{
				return new XmlName(this.node.LocalName, this.node.NamespaceURI);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0001C543 File Offset: 0x0001A743
		public virtual XmlName XsiType
		{
			get
			{
				return this.GetXsiType();
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0001C54B File Offset: 0x0001A74B
		public virtual bool IsElement
		{
			get
			{
				return this.node.NodeType == XmlNodeType.Element;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0001C55B File Offset: 0x0001A75B
		public virtual bool IsAttribute
		{
			get
			{
				return this.node.NodeType == XmlNodeType.Attribute;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0001C56B File Offset: 0x0001A76B
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0001C573 File Offset: 0x0001A773
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0001C57C File Offset: 0x0001A77C
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0001C58C File Offset: 0x0001A78C
		public virtual string Value
		{
			get
			{
				return this.node.InnerText;
			}
			set
			{
				bool flag = value == null;
				this.IsNil = flag;
				if (!flag)
				{
					this.node.InnerText = value;
				}
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
		public virtual string Xml
		{
			get
			{
				return this.node.OuterXml;
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
		public bool UnderlyingPositionEquals(IXmlNode node)
		{
			IRealizable<XmlNode> realizable = node.AsRealizable<XmlNode>();
			if (realizable != null)
			{
				return realizable.IsReal && realizable.Value == this.node;
			}
			IRealizable<XPathNavigator> realizable2 = node.AsRealizable<XPathNavigator>();
			return realizable2 != null && realizable2.IsReal && realizable2.Value.UnderlyingObject == this.node;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0001C620 File Offset: 0x0001A820
		public string GetAttribute(XmlName name)
		{
			if (!this.IsReal)
			{
				return null;
			}
			XmlElement xmlElement = this.node as XmlElement;
			if (xmlElement == null)
			{
				return null;
			}
			XmlAttribute attributeNode = xmlElement.GetAttributeNode(name.LocalName, name.NamespaceUri);
			if (attributeNode == null)
			{
				return null;
			}
			string value = attributeNode.Value;
			if (string.IsNullOrEmpty(value))
			{
				return null;
			}
			return value;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0001C674 File Offset: 0x0001A874
		public void SetAttribute(XmlName name, string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				this.ClearAttribute(name);
				return;
			}
			this.SetAttributeCore(name, value);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0001C690 File Offset: 0x0001A890
		private void SetAttributeCore(XmlName name, string value)
		{
			if (!this.IsElement)
			{
				throw Error.CannotSetAttribute(this);
			}
			this.Realize();
			XmlElement xmlElement = this.node as XmlElement;
			if (xmlElement == null)
			{
				throw Error.CannotSetAttribute(this);
			}
			XmlAttribute xmlAttribute = xmlElement.GetAttributeNode(name.LocalName, name.NamespaceUri);
			if (xmlAttribute == null)
			{
				string attributePrefix = base.Namespaces.GetAttributePrefix(this, name.NamespaceUri);
				xmlAttribute = xmlElement.OwnerDocument.CreateAttribute(attributePrefix, name.LocalName, name.NamespaceUri);
				xmlElement.SetAttributeNode(xmlAttribute);
			}
			xmlAttribute.Value = value;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0001C720 File Offset: 0x0001A920
		private void ClearAttribute(XmlName name)
		{
			if (!this.IsReal)
			{
				return;
			}
			XmlElement xmlElement = this.node as XmlElement;
			if (xmlElement == null)
			{
				return;
			}
			xmlElement.RemoveAttribute(name.LocalName, name.NamespaceUri);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0001C75A File Offset: 0x0001A95A
		public string LookupPrefix(string namespaceUri)
		{
			return this.node.GetPrefixOfNamespace(namespaceUri);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0001C768 File Offset: 0x0001A968
		public string LookupNamespaceUri(string prefix)
		{
			return this.node.GetNamespaceOfPrefix(prefix);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0001C778 File Offset: 0x0001A978
		public void DefineNamespace(string prefix, string namespaceUri, bool root)
		{
			XmlElement xmlElement = this.GetNamespaceTargetElement();
			if (xmlElement == null)
			{
				throw Error.InvalidOperation();
			}
			if (root)
			{
				xmlElement = xmlElement.FindRoot();
			}
			xmlElement.DefineNamespace(prefix, namespaceUri);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
		private XmlElement GetNamespaceTargetElement()
		{
			XmlElement xmlElement = this.node as XmlElement;
			if (xmlElement != null)
			{
				return xmlElement;
			}
			XmlAttribute xmlAttribute = this.node as XmlAttribute;
			if (xmlAttribute != null)
			{
				return xmlAttribute.OwnerElement;
			}
			XmlDocument xmlDocument = this.node as XmlDocument;
			if (xmlDocument != null)
			{
				return xmlDocument.DocumentElement;
			}
			return null;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0001C7F3 File Offset: 0x0001A9F3
		public virtual IXmlNode Save()
		{
			return this;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0001C7F6 File Offset: 0x0001A9F6
		public IXmlCursor SelectSelf(Type clrType)
		{
			return new XmlSelfCursor(this, clrType);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0001C7FF File Offset: 0x0001A9FF
		public IXmlCursor SelectChildren(IXmlKnownTypeMap knownTypes, IXmlNamespaceSource namespaces, CursorFlags flags)
		{
			return new SysXmlCursor(this, knownTypes, namespaces, flags);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0001C80A File Offset: 0x0001AA0A
		public IXmlIterator SelectSubtree()
		{
			return new SysXmlSubtreeIterator(this, base.Namespaces);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0001C818 File Offset: 0x0001AA18
		public XmlReader ReadSubtree()
		{
			return this.node.CreateNavigator().ReadSubtree();
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0001C82A File Offset: 0x0001AA2A
		public XmlWriter WriteAttributes()
		{
			return this.node.CreateNavigator().CreateAttributes();
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0001C83C File Offset: 0x0001AA3C
		public XmlWriter WriteChildren()
		{
			return this.node.CreateNavigator().AppendChild();
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0001C850 File Offset: 0x0001AA50
		public IXmlCursor Select(CompiledXPath path, IXmlIncludedTypeMap includedTypes, IXmlNamespaceSource namespaces, CursorFlags flags)
		{
			if (!flags.SupportsMutation())
			{
				return new XPathReadOnlyCursor(this, path, includedTypes, namespaces, flags);
			}
			return new XPathMutableCursor(this, path, includedTypes, namespaces, flags);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0001C881 File Offset: 0x0001AA81
		public virtual object Evaluate(CompiledXPath path)
		{
			return this.node.CreateNavigator().Evaluate(path.Path);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0001C899 File Offset: 0x0001AA99
		public XmlNode GetNode()
		{
			return this.node;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0001C8A1 File Offset: 0x0001AAA1
		public void Clear()
		{
			if (this.IsElement)
			{
				this.ClearAttributes();
			}
			else if (this.IsAttribute)
			{
				this.Value = string.Empty;
				return;
			}
			this.ClearChildren();
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
		private void ClearAttributes()
		{
			XmlAttributeCollection attributes = this.node.Attributes;
			int i = attributes.Count;
			while (i > 0)
			{
				XmlAttribute attribute = attributes[--i];
				if (!attribute.IsNamespace() && !attribute.IsXsiType())
				{
					attributes.RemoveAt(i);
				}
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0001C91C File Offset: 0x0001AB1C
		private void ClearChildren()
		{
			XmlNode nextSibling;
			for (XmlNode xmlNode = this.node.FirstChild; xmlNode != null; xmlNode = nextSibling)
			{
				nextSibling = xmlNode.NextSibling;
				this.node.RemoveChild(xmlNode);
			}
		}

		// Token: 0x04000279 RID: 633
		protected XmlNode node;
	}
}
