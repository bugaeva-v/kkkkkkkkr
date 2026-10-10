using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000178 RID: 376
	public class XmlPositionComparer
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x0001B574 File Offset: 0x00019774
		public bool Equals(IXmlNode nodeA, IXmlNode nodeB)
		{
			XmlNameComparer @default = XmlNameComparer.Default;
			XmlPositionComparer.ComparandIterator comparandIterator = new XmlPositionComparer.ComparandIterator
			{
				Node = nodeA
			};
			XmlPositionComparer.ComparandIterator comparandIterator2 = new XmlPositionComparer.ComparandIterator
			{
				Node = nodeB
			};
			while (!comparandIterator.Node.IsReal || !comparandIterator2.Node.IsReal)
			{
				if (!comparandIterator.MoveNext() || !comparandIterator2.MoveNext())
				{
					return false;
				}
				if (!@default.Equals(comparandIterator.Name, comparandIterator2.Name))
				{
					return false;
				}
			}
			return comparandIterator.Node.UnderlyingPositionEquals(comparandIterator2.Node);
		}

		// Token: 0x0400026F RID: 623
		public static readonly XmlPositionComparer Instance = new XmlPositionComparer();

		// Token: 0x02000220 RID: 544
		private struct ComparandIterator
		{
			// Token: 0x06000F30 RID: 3888 RVA: 0x00023D67 File Offset: 0x00021F67
			public bool MoveNext()
			{
				if (this.Step != null)
				{
					return this.ConsumeStep();
				}
				if (this.Node == null)
				{
					return this.Stop();
				}
				return this.ConsumeNode();
			}

			// Token: 0x06000F31 RID: 3889 RVA: 0x00023D90 File Offset: 0x00021F90
			private bool ConsumeNode()
			{
				bool result = true;
				CompiledXPath path = this.Node.Path;
				if (path != null)
				{
					result = this.ConsumeFirstStep(path);
				}
				else
				{
					this.Name = this.Node.Name;
				}
				this.Node = this.Node.Parent;
				return result;
			}

			// Token: 0x06000F32 RID: 3890 RVA: 0x00023DDB File Offset: 0x00021FDB
			private bool Stop()
			{
				this.Name = XmlName.Empty;
				return false;
			}

			// Token: 0x06000F33 RID: 3891 RVA: 0x00023DE9 File Offset: 0x00021FE9
			private bool ConsumeFirstStep(CompiledXPath path)
			{
				if (!path.IsCreatable)
				{
					return false;
				}
				this.Step = path.LastStep;
				return this.ConsumeStep();
			}

			// Token: 0x06000F34 RID: 3892 RVA: 0x00023E07 File Offset: 0x00022007
			private bool ConsumeStep()
			{
				this.Name = new XmlName(this.Step.LocalName, this.Node.LookupNamespaceUri(this.Step.Prefix));
				this.Step = this.Step.PreviousNode;
				return true;
			}

			// Token: 0x04000426 RID: 1062
			public IXmlNode Node;

			// Token: 0x04000427 RID: 1063
			public XmlName Name;

			// Token: 0x04000428 RID: 1064
			public CompiledXPathNode Step;
		}
	}
}
