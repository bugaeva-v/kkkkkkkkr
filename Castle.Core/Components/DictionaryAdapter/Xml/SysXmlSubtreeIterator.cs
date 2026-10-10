using System;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200017D RID: 381
	public class SysXmlSubtreeIterator : SysXmlNode, IXmlIterator, IXmlNode, IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual
	{
		// Token: 0x06000BC5 RID: 3013 RVA: 0x0001C950 File Offset: 0x0001AB50
		public SysXmlSubtreeIterator(IXmlNode parent, IXmlNamespaceSource namespaces) : base(namespaces, parent)
		{
			if (parent == null)
			{
				throw Error.ArgumentNull("parent");
			}
			IRealizable<XmlNode> realizable = parent.RequireRealizable<XmlNode>();
			if (realizable.IsReal)
			{
				this.node = realizable.Value;
			}
			this.type = typeof(object);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0001C9A0 File Offset: 0x0001ABA0
		public bool MoveNext()
		{
			SysXmlSubtreeIterator.State state = this.state;
			if (state != SysXmlSubtreeIterator.State.Initial)
			{
				return state == SysXmlSubtreeIterator.State.Current && this.MoveToSubsequent();
			}
			return this.MoveToInitial();
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0001C9CC File Offset: 0x0001ABCC
		private bool MoveToInitial()
		{
			if (this.node == null)
			{
				return false;
			}
			this.state = SysXmlSubtreeIterator.State.Current;
			return true;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		private bool MoveToSubsequent()
		{
			if (this.MoveToElement(this.node.FirstChild))
			{
				return true;
			}
			while (this.node != null)
			{
				if (this.MoveToElement(this.node.NextSibling))
				{
					return true;
				}
				this.node = this.node.ParentNode;
			}
			this.state = SysXmlSubtreeIterator.State.End;
			return false;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0001CA38 File Offset: 0x0001AC38
		private bool MoveToElement(XmlNode node)
		{
			while (node != null)
			{
				if (node.NodeType == XmlNodeType.Element)
				{
					return this.SetNext(node);
				}
				node = node.NextSibling;
			}
			return false;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0001CA59 File Offset: 0x0001AC59
		private bool SetNext(XmlNode node)
		{
			this.node = node;
			return true;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0001CA63 File Offset: 0x0001AC63
		public override IXmlNode Save()
		{
			return new SysXmlNode(this.node, this.type, base.Namespaces);
		}

		// Token: 0x0400027A RID: 634
		private SysXmlSubtreeIterator.State state;

		// Token: 0x02000222 RID: 546
		private enum State
		{
			// Token: 0x04000432 RID: 1074
			Initial,
			// Token: 0x04000433 RID: 1075
			Current,
			// Token: 0x04000434 RID: 1076
			End
		}
	}
}
