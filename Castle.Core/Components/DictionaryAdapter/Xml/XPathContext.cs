using System;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000183 RID: 387
	internal class XPathContext : XsltContext
	{
		// Token: 0x06000C0E RID: 3086 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		public XPathContext(XsltContext xpathContext)
		{
			this.context = xpathContext;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0001D2D7 File Offset: 0x0001B4D7
		public override string DefaultNamespace
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0001D2DE File Offset: 0x0001B4DE
		public override string LookupNamespace(string prefix)
		{
			if (!string.IsNullOrEmpty(prefix))
			{
				return this.context.LookupNamespace(prefix);
			}
			return string.Empty;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0001D2FA File Offset: 0x0001B4FA
		public override bool Whitespace
		{
			get
			{
				return this.context.Whitespace;
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0001D307 File Offset: 0x0001B507
		public override bool PreserveWhitespace(XPathNavigator node)
		{
			return this.context.PreserveWhitespace(node);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0001D315 File Offset: 0x0001B515
		public override int CompareDocument(string baseUri, string nextbaseUri)
		{
			return this.context.CompareDocument(baseUri, nextbaseUri);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0001D324 File Offset: 0x0001B524
		public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] argTypes)
		{
			return this.context.ResolveFunction(prefix, name, argTypes);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0001D334 File Offset: 0x0001B534
		public override IXsltContextVariable ResolveVariable(string prefix, string name)
		{
			return this.context.ResolveVariable(prefix, name);
		}

		// Token: 0x0400028B RID: 651
		private readonly XsltContext context;
	}
}
