using System;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000187 RID: 391
	public class XPathReadOnlyCursor : XPathNode, IXmlCursor, IXmlIterator, IXmlNode, IXmlKnownType, IXmlIdentity, IRealizableSource, IVirtual
	{
		// Token: 0x06000C6D RID: 3181 RVA: 0x0001E0A8 File Offset: 0x0001C2A8
		public XPathReadOnlyCursor(IXmlNode parent, CompiledXPath path, IXmlIncludedTypeMap includedTypes, IXmlNamespaceSource namespaces, CursorFlags flags) : base(path, namespaces, parent)
		{
			if (parent == null)
			{
				throw Error.ArgumentNull("parent");
			}
			if (path == null)
			{
				throw Error.ArgumentNull("path");
			}
			if (includedTypes == null)
			{
				throw Error.ArgumentNull("includedTypes");
			}
			this.includedTypes = includedTypes;
			this.flags = flags;
			this.Reset();
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0001E100 File Offset: 0x0001C300
		public void Reset()
		{
			IRealizable<XPathNavigator> realizable = base.Parent.RequireRealizable<XPathNavigator>();
			if (realizable.IsReal)
			{
				this.iterator = realizable.Value.Select(this.xpath.Path);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0001E140 File Offset: 0x0001C340
		public bool MoveNext()
		{
			while (this.iterator != null && this.iterator.MoveNext() && (this.flags.AllowsMultipleItems() || !this.iterator.MoveNext()))
			{
				if (this.SetAtNext())
				{
					return true;
				}
			}
			return this.SetAtEnd();
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0001E195 File Offset: 0x0001C395
		private bool SetAtEnd()
		{
			this.node = null;
			this.type = null;
			return false;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
		private bool SetAtNext()
		{
			this.node = this.iterator.Current;
			IXmlIncludedType xmlIncludedType;
			if (!this.includedTypes.TryGet(this.XsiType, out xmlIncludedType))
			{
				return false;
			}
			this.type = xmlIncludedType.ClrType;
			return true;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0001E1EC File Offset: 0x0001C3EC
		public void MoveTo(IXmlNode position)
		{
			IRealizable<XPathNavigator> realizable = position.AsRealizable<XPathNavigator>();
			if (realizable == null || !realizable.IsReal)
			{
				throw Error.CursorCannotMoveToGivenNode();
			}
			XPathNavigator value = realizable.Value;
			this.Reset();
			if (this.iterator != null)
			{
				while (this.iterator.MoveNext())
				{
					if (this.iterator.Current.IsSamePosition(value))
					{
						this.SetAtNext();
						return;
					}
				}
			}
			throw Error.CursorCannotMoveToGivenNode();
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0001E255 File Offset: 0x0001C455
		public void MoveToEnd()
		{
			if (this.iterator != null)
			{
				while (this.iterator.MoveNext())
				{
				}
			}
			this.SetAtEnd();
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0001E273 File Offset: 0x0001C473
		public void MakeNext(Type type)
		{
			throw Error.CursorNotMutable();
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0001E27A File Offset: 0x0001C47A
		public void Create(Type type)
		{
			throw Error.CursorNotMutable();
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0001E281 File Offset: 0x0001C481
		public void Coerce(Type type)
		{
			throw Error.CursorNotMutable();
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0001E288 File Offset: 0x0001C488
		public void Remove()
		{
			throw Error.CursorNotMutable();
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0001E28F File Offset: 0x0001C48F
		public void RemoveAllNext()
		{
			throw Error.CursorNotMutable();
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0001E296 File Offset: 0x0001C496
		public override IXmlNode Save()
		{
			return new XPathNode(this.node.Clone(), this.type, base.Namespaces);
		}

		// Token: 0x04000294 RID: 660
		private XPathNodeIterator iterator;

		// Token: 0x04000295 RID: 661
		private readonly IXmlIncludedTypeMap includedTypes;

		// Token: 0x04000296 RID: 662
		private readonly CursorFlags flags;
	}
}
