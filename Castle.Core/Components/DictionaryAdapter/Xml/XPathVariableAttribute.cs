using System;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000151 RID: 337
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = true)]
	public abstract class XPathVariableAttribute : Attribute, IXsltContextVariable
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000986 RID: 2438
		public abstract XmlName Name { get; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000987 RID: 2439
		public abstract XPathResultType VariableType { get; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00017BEB File Offset: 0x00015DEB
		bool IXsltContextVariable.IsLocal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x00017BEE File Offset: 0x00015DEE
		bool IXsltContextVariable.IsParam
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600098A RID: 2442
		public abstract object Evaluate(XsltContext context);
	}
}
