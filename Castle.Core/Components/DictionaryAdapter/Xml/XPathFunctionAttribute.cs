using System;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000150 RID: 336
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = true)]
	public abstract class XPathFunctionAttribute : Attribute, IXsltContextFunction
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600097E RID: 2430
		public abstract XmlName Name { get; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600097F RID: 2431
		public abstract XPathResultType ReturnType { get; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00017BBB File Offset: 0x00015DBB
		public virtual XPathResultType[] ArgTypes
		{
			get
			{
				return XPathFunctionAttribute.NoArgs;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00017BC2 File Offset: 0x00015DC2
		public virtual int Maxargs
		{
			get
			{
				return this.ArgTypes.Length;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00017BCC File Offset: 0x00015DCC
		public virtual int Minargs
		{
			get
			{
				return this.ArgTypes.Length;
			}
		}

		// Token: 0x06000983 RID: 2435
		public abstract object Invoke(XsltContext context, object[] args, XPathNavigator node);

		// Token: 0x04000210 RID: 528
		public static readonly XPathResultType[] NoArgs = new XPathResultType[0];
	}
}
