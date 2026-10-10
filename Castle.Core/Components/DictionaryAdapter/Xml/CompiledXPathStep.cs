using System;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000180 RID: 384
	public class CompiledXPathStep : CompiledXPathNode
	{
		// Token: 0x06000BED RID: 3053 RVA: 0x0001CD72 File Offset: 0x0001AF72
		internal CompiledXPathStep()
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0001CD7A File Offset: 0x0001AF7A
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0001CD82 File Offset: 0x0001AF82
		public XPathExpression Path
		{
			get
			{
				return this.path;
			}
			internal set
			{
				this.path = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0001CD8B File Offset: 0x0001AF8B
		public CompiledXPathStep NextStep
		{
			get
			{
				return (CompiledXPathStep)base.NextNode;
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0001CD98 File Offset: 0x0001AF98
		internal override void SetContext(XsltContext context)
		{
			this.path.SetContext(context);
			base.SetContext(context);
		}

		// Token: 0x04000286 RID: 646
		private XPathExpression path;
	}
}
