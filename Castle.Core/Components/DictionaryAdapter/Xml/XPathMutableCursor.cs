using System;
using System.Xml;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000185 RID: 389
	internal class XPathMutableCursor : XPathNode, IXmlCursor, IXmlIterator, IXmlNode, IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		public XPathMutableCursor(IXmlNode parent, CompiledXPath path, IXmlIncludedTypeMap knownTypes, IXmlNamespaceSource namespaces, CursorFlags flags) : base(path, namespaces, parent)
		{
			if (parent == null)
			{
				throw Error.ArgumentNull("parent");
			}
			if (path == null)
			{
				throw Error.ArgumentNull("path");
			}
			if (knownTypes == null)
			{
				throw Error.ArgumentNull("knownTypes");
			}
			if (!path.IsCreatable)
			{
				throw Error.XPathNotCreatable(path);
			}
			this.step = path.FirstStep;
			this.knownTypes = knownTypes;
			this.flags = flags;
			IRealizable<XPathNavigator> realizable = parent.RequireRealizable<XPathNavigator>();
			if (realizable.IsReal)
			{
				this.iterator = new XPathBufferedNodeIterator(realizable.Value.Select(path.FirstStep.Path));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0001D483 File Offset: 0x0001B683
		public override bool IsReal
		{
			get
			{
				return this.HasCurrent;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0001D48B File Offset: 0x0001B68B
		public bool HasCurrent
		{
			get
			{
				return this.depth == this.xpath.Depth;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0001D4A0 File Offset: 0x0001B6A0
		public bool HasPartialOrCurrent
		{
			get
			{
				return this.node != null;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0001D4AB File Offset: 0x0001B6AB
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		public override XmlName Name
		{
			get
			{
				if (!this.HasCurrent)
				{
					return XmlName.Empty;
				}
				return base.Name;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0001D4E2 File Offset: 0x0001B6E2
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x0001D503 File Offset: 0x0001B703
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0001D51F File Offset: 0x0001B71F
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

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0001D53E File Offset: 0x0001B73E
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0001D550 File Offset: 0x0001B750
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0001D55F File Offset: 0x0001B75F
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0001D575 File Offset: 0x0001B775
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0001D57E File Offset: 0x0001B77E
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

		// Token: 0x06000C2A RID: 3114 RVA: 0x0001D590 File Offset: 0x0001B790
		public override object Evaluate(CompiledXPath path)
		{
			if (!this.HasCurrent)
			{
				return null;
			}
			return base.Evaluate(path);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
		public bool MoveNext()
		{
			this.ResetCurrent();
			while (this.iterator != null && this.iterator.MoveNext() && this.Consume(this.iterator, this.flags.AllowsMultipleItems()))
			{
				if (this.SeekCurrent())
				{
					return true;
				}
			}
			return this.SetAtEnd();
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		private bool SeekCurrent()
		{
			while (this.depth < this.xpath.Depth)
			{
				XPathNodeIterator xpathNodeIterator = this.node.Select(this.step.Path);
				if (!xpathNodeIterator.MoveNext())
				{
					return true;
				}
				if (!this.Consume(xpathNodeIterator, false))
				{
					return false;
				}
			}
			IXmlIncludedType xmlIncludedType;
			if (!this.knownTypes.TryGet(this.XsiType, out xmlIncludedType))
			{
				return false;
			}
			this.type = xmlIncludedType.ClrType;
			return true;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0001D66C File Offset: 0x0001B86C
		private bool Consume(XPathNodeIterator iterator, bool multiple)
		{
			XPathNavigator node = iterator.Current;
			if (!multiple && iterator.MoveNext())
			{
				return false;
			}
			this.node = node;
			this.Descend();
			return true;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0001D69C File Offset: 0x0001B89C
		private bool SetAtEnd()
		{
			this.ResetCurrent();
			return false;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0001D6A5 File Offset: 0x0001B8A5
		public void Reset()
		{
			this.ResetCurrent();
			this.iterator.Reset();
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0001D6B8 File Offset: 0x0001B8B8
		public void MoveToEnd()
		{
			this.ResetCurrent();
			this.iterator.MoveToEnd();
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0001D6CB File Offset: 0x0001B8CB
		private void ResetCurrent()
		{
			this.node = null;
			this.type = null;
			this.ResetDepth();
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0001D6E1 File Offset: 0x0001B8E1
		private void ResetDepth()
		{
			this.step = this.xpath.FirstStep;
			this.depth = 0;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0001D6FC File Offset: 0x0001B8FC
		private int Descend()
		{
			this.step = this.step.NextStep;
			int result = this.depth + 1;
			this.depth = result;
			return result;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0001D72C File Offset: 0x0001B92C
		public void MoveTo(IXmlNode position)
		{
			IRealizable<XPathNavigator> realizable = position.AsRealizable<XPathNavigator>();
			if (realizable == null || !realizable.IsReal)
			{
				throw Error.CursorCannotMoveToGivenNode();
			}
			XPathNavigator value = realizable.Value;
			this.Reset();
			while (this.MoveNext())
			{
				if (this.HasCurrent && this.node.IsSamePosition(value))
				{
					return;
				}
			}
			throw Error.CursorCannotMoveToGivenNode();
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000C35 RID: 3125 RVA: 0x0001D784 File Offset: 0x0001B984
		// (remove) Token: 0x06000C36 RID: 3126 RVA: 0x0001D7BC File Offset: 0x0001B9BC
		public override event EventHandler Realized;

		// Token: 0x06000C37 RID: 3127 RVA: 0x0001D7F1 File Offset: 0x0001B9F1
		protected virtual void OnRealized()
		{
			if (this.Realized != null)
			{
				this.Realized(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0001D80C File Offset: 0x0001BA0C
		protected override void Realize()
		{
			if (this.HasCurrent)
			{
				return;
			}
			if (this.iterator != null && !this.iterator.IsEmpty && !this.HasPartialOrCurrent)
			{
				throw Error.CursorNotInRealizableState();
			}
			this.Create(this.knownTypes.Default.ClrType);
			this.OnRealized();
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0001D861 File Offset: 0x0001BA61
		public void MakeNext(Type clrType)
		{
			if (this.MoveNext())
			{
				this.Coerce(clrType);
				return;
			}
			this.Create(clrType);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0001D87C File Offset: 0x0001BA7C
		public void Coerce(Type clrType)
		{
			IXmlIncludedType xmlIncludedType = this.knownTypes.Require(clrType);
			this.SetXsiType(xmlIncludedType.XsiType);
			this.type = clrType;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0001D8A9 File Offset: 0x0001BAA9
		public void Create(Type type)
		{
			if (this.HasCurrent)
			{
				this.Insert();
			}
			else if (this.HasPartialOrCurrent)
			{
				this.Complete();
			}
			else
			{
				this.Append();
			}
			this.Coerce(type);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0001D8D8 File Offset: 0x0001BAD8
		private void Insert()
		{
			for (;;)
			{
				int num = this.depth - 1;
				this.depth = num;
				if (num <= 0)
				{
					break;
				}
				this.node.MoveToParent();
			}
			this.ResetDepth();
			using (XmlWriter xmlWriter = this.node.InsertBefore())
			{
				this.WriteNode(this.step, xmlWriter);
			}
			bool moved = this.node.MoveToPrevious();
			this.SeekCurrentAfterCreate(moved);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0001D958 File Offset: 0x0001BB58
		private void Append()
		{
			this.node = base.Parent.AsRealizable<XPathNavigator>().Value.Clone();
			base.Parent.IsNil = false;
			this.Complete();
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0001D988 File Offset: 0x0001BB88
		private void Complete()
		{
			using (XmlWriter xmlWriter = this.CreateWriterForAppend())
			{
				this.WriteNode(this.step, xmlWriter);
			}
			bool moved = this.step.IsAttribute ? this.node.MoveToLastAttribute() : this.node.MoveToLastChild();
			this.SeekCurrentAfterCreate(moved);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
		private XmlWriter CreateWriterForAppend()
		{
			if (!this.step.IsAttribute)
			{
				return this.node.AppendChild();
			}
			return this.node.CreateAttributes();
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0001DA1A File Offset: 0x0001BC1A
		private void WriteNode(CompiledXPathNode node, XmlWriter writer)
		{
			if (node.IsAttribute)
			{
				this.WriteAttribute(node, writer);
				return;
			}
			if (node.IsSimple)
			{
				this.WriteSimpleElement(node, writer);
				return;
			}
			this.WriteComplexElement(node, writer);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0001DA46 File Offset: 0x0001BC46
		private void WriteAttribute(CompiledXPathNode node, XmlWriter writer)
		{
			writer.WriteStartAttribute(node.Prefix, node.LocalName, null);
			this.WriteValue(node, writer);
			writer.WriteEndAttribute();
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0001DA69 File Offset: 0x0001BC69
		private void WriteSimpleElement(CompiledXPathNode node, XmlWriter writer)
		{
			writer.WriteStartElement(node.Prefix, node.LocalName, null);
			this.WriteValue(node, writer);
			writer.WriteEndElement();
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0001DA8C File Offset: 0x0001BC8C
		private void WriteComplexElement(CompiledXPathNode node, XmlWriter writer)
		{
			writer.WriteStartElement(node.Prefix, node.LocalName, null);
			this.WriteSubnodes(node, writer, true);
			this.WriteSubnodes(node, writer, false);
			writer.WriteEndElement();
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0001DABC File Offset: 0x0001BCBC
		private void WriteSubnodes(CompiledXPathNode parent, XmlWriter writer, bool attributes)
		{
			CompiledXPathNode nextNode = parent.NextNode;
			if (nextNode != null && nextNode.IsAttribute == attributes)
			{
				this.WriteNode(nextNode, writer);
			}
			foreach (CompiledXPathNode compiledXPathNode in parent.Dependencies)
			{
				if (compiledXPathNode.IsAttribute == attributes)
				{
					this.WriteNode(compiledXPathNode, writer);
				}
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0001DB30 File Offset: 0x0001BD30
		private void WriteValue(CompiledXPathNode node, XmlWriter writer)
		{
			if (node.Value == null)
			{
				return;
			}
			object value = base.Parent.AsRealizable<XPathNavigator>().Value.Evaluate(node.Value);
			writer.WriteValue(value);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0001DB6C File Offset: 0x0001BD6C
		private void SeekCurrentAfterCreate(bool moved)
		{
			this.RequireMoved(moved);
			if (this.Descend() == this.xpath.Depth)
			{
				return;
			}
			do
			{
				moved = (this.step.IsAttribute ? this.node.MoveToFirstAttribute() : this.node.MoveToFirstChild());
				this.RequireMoved(moved);
			}
			while (this.Descend() < this.xpath.Depth);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0001DBD5 File Offset: 0x0001BDD5
		public void RemoveAllNext()
		{
			while (this.MoveNext())
			{
				this.Remove();
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
		public void Remove()
		{
			this.RequireRemovable();
			XmlName empty = XmlName.Empty;
			if (!this.HasCurrent)
			{
				string namespaceUri = base.LookupNamespaceUri(this.step.Prefix) ?? this.node.NamespaceURI;
				empty = new XmlName(this.step.LocalName, namespaceUri);
			}
			while (!this.node.MoveToChild(empty.LocalName, empty.NamespaceUri))
			{
				empty = new XmlName(this.node.LocalName, this.node.NamespaceURI);
				this.node.DeleteSelf();
				this.depth--;
				if (this.depth <= 0)
				{
					break;
				}
			}
			this.ResetCurrent();
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0001DC9D File Offset: 0x0001BE9D
		public override IXmlNode Save()
		{
			if (!this.HasCurrent)
			{
				return this;
			}
			return new XPathNode(this.node.Clone(), this.type, base.Namespaces);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0001DCC5 File Offset: 0x0001BEC5
		private void RequireRemovable()
		{
			if (!this.HasPartialOrCurrent)
			{
				throw Error.CursorNotInRemovableState();
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0001DCD5 File Offset: 0x0001BED5
		private void RequireMoved(bool result)
		{
			if (!result)
			{
				throw Error.XPathNavigationFailed(this.step.Path);
			}
		}

		// Token: 0x0400028C RID: 652
		private XPathBufferedNodeIterator iterator;

		// Token: 0x0400028D RID: 653
		private CompiledXPathStep step;

		// Token: 0x0400028E RID: 654
		private int depth;

		// Token: 0x0400028F RID: 655
		private readonly IXmlIncludedTypeMap knownTypes;

		// Token: 0x04000290 RID: 656
		private readonly CursorFlags flags;
	}
}
