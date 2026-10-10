using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200017F RID: 383
	public class CompiledXPathNode
	{
		// Token: 0x06000BD8 RID: 3032 RVA: 0x0001CB30 File Offset: 0x0001AD30
		internal CompiledXPathNode()
		{
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0001CB38 File Offset: 0x0001AD38
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x0001CB40 File Offset: 0x0001AD40
		public string Prefix
		{
			get
			{
				return this.prefix;
			}
			internal set
			{
				this.prefix = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0001CB49 File Offset: 0x0001AD49
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x0001CB51 File Offset: 0x0001AD51
		public string LocalName
		{
			get
			{
				return this.localName;
			}
			internal set
			{
				this.localName = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0001CB5A File Offset: 0x0001AD5A
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x0001CB62 File Offset: 0x0001AD62
		public bool IsAttribute
		{
			get
			{
				return this.isAttribute;
			}
			internal set
			{
				this.isAttribute = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0001CB6B File Offset: 0x0001AD6B
		public bool IsSelfReference
		{
			get
			{
				return this.localName == null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0001CB76 File Offset: 0x0001AD76
		public bool IsSimple
		{
			get
			{
				return this.next == null && this.HasNoRealDependencies();
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0001CB88 File Offset: 0x0001AD88
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0001CB9A File Offset: 0x0001AD9A
		public XPathExpression Value
		{
			get
			{
				return this.value ?? this.GetSelfReferenceValue();
			}
			internal set
			{
				this.value = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0001CBA3 File Offset: 0x0001ADA3
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x0001CBAB File Offset: 0x0001ADAB
		public CompiledXPathNode NextNode
		{
			get
			{
				return this.next;
			}
			internal set
			{
				this.next = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0001CBB4 File Offset: 0x0001ADB4
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0001CBBC File Offset: 0x0001ADBC
		public CompiledXPathNode PreviousNode
		{
			get
			{
				return this.previous;
			}
			internal set
			{
				this.previous = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0001CBC8 File Offset: 0x0001ADC8
		public IList<CompiledXPathNode> Dependencies
		{
			get
			{
				IList<CompiledXPathNode> result;
				if ((result = this.dependencies) == null)
				{
					result = (this.dependencies = new List<CompiledXPathNode>());
				}
				return result;
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0001CBED File Offset: 0x0001ADED
		private bool HasNoRealDependencies()
		{
			return this.dependencies == null || this.dependencies.Count == 0 || (this.dependencies.Count == 1 && this.dependencies[0].IsSelfReference);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0001CC27 File Offset: 0x0001AE27
		private XPathExpression GetSelfReferenceValue()
		{
			if (this.dependencies == null || this.dependencies.Count != 1 || !this.dependencies[0].IsSelfReference)
			{
				return null;
			}
			return this.dependencies[0].value;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0001CC68 File Offset: 0x0001AE68
		internal virtual void Prepare()
		{
			IList<CompiledXPathNode> list;
			if (this.dependencies == null)
			{
				list = CompiledXPathNode.NoDependencies;
			}
			else
			{
				IList<CompiledXPathNode> list2 = Array.AsReadOnly<CompiledXPathNode>(this.dependencies.ToArray<CompiledXPathNode>());
				list = list2;
			}
			this.dependencies = list;
			foreach (CompiledXPathNode compiledXPathNode in this.dependencies)
			{
				compiledXPathNode.Prepare();
			}
			if (this.next != null)
			{
				this.next.Prepare();
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0001CCEC File Offset: 0x0001AEEC
		internal virtual void SetContext(XsltContext context)
		{
			if (this.value != null)
			{
				this.value.SetContext(context);
			}
			foreach (CompiledXPathNode compiledXPathNode in this.dependencies)
			{
				compiledXPathNode.SetContext(context);
			}
			if (this.next != null)
			{
				this.next.SetContext(context);
			}
		}

		// Token: 0x0400027E RID: 638
		private string prefix;

		// Token: 0x0400027F RID: 639
		private string localName;

		// Token: 0x04000280 RID: 640
		private bool isAttribute;

		// Token: 0x04000281 RID: 641
		private XPathExpression value;

		// Token: 0x04000282 RID: 642
		private CompiledXPathNode next;

		// Token: 0x04000283 RID: 643
		private CompiledXPathNode previous;

		// Token: 0x04000284 RID: 644
		private IList<CompiledXPathNode> dependencies;

		// Token: 0x04000285 RID: 645
		private static readonly IList<CompiledXPathNode> NoDependencies = Array.AsReadOnly<CompiledXPathNode>(new CompiledXPathNode[0]);
	}
}
