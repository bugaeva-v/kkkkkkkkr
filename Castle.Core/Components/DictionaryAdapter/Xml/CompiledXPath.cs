using System;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200017E RID: 382
	public class CompiledXPath
	{
		// Token: 0x06000BCC RID: 3020 RVA: 0x0001CA7C File Offset: 0x0001AC7C
		internal CompiledXPath()
		{
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0001CA84 File Offset: 0x0001AC84
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0001CA8C File Offset: 0x0001AC8C
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

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0001CA95 File Offset: 0x0001AC95
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0001CA9D File Offset: 0x0001AC9D
		public CompiledXPathStep FirstStep
		{
			get
			{
				return this.firstStep;
			}
			internal set
			{
				this.firstStep = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
		public CompiledXPathStep LastStep
		{
			get
			{
				CompiledXPathStep compiledXPathStep = null;
				for (CompiledXPathStep nextStep = this.firstStep; nextStep != null; nextStep = compiledXPathStep.NextStep)
				{
					compiledXPathStep = nextStep;
				}
				return compiledXPathStep;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0001CACD File Offset: 0x0001ACCD
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0001CAD5 File Offset: 0x0001ACD5
		public int Depth
		{
			get
			{
				return this.depth;
			}
			internal set
			{
				this.depth = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0001CADE File Offset: 0x0001ACDE
		public bool IsCreatable
		{
			get
			{
				return this.firstStep != null;
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0001CAE9 File Offset: 0x0001ACE9
		internal void MakeNotCreatable()
		{
			this.firstStep = null;
			this.depth = 0;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0001CAF9 File Offset: 0x0001ACF9
		internal void Prepare()
		{
			if (this.firstStep != null)
			{
				this.firstStep.Prepare();
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0001CB0E File Offset: 0x0001AD0E
		public void SetContext(XsltContext context)
		{
			this.path.SetContext(context);
			if (this.firstStep != null)
			{
				this.firstStep.SetContext(context);
			}
		}

		// Token: 0x0400027B RID: 635
		private XPathExpression path;

		// Token: 0x0400027C RID: 636
		private CompiledXPathStep firstStep;

		// Token: 0x0400027D RID: 637
		private int depth;
	}
}
