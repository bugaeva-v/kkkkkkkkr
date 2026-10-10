using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000173 RID: 371
	public class XmlContextBase : XsltContext, IXmlNamespaceSource
	{
		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001AD7D File Offset: 0x00018F7D
		public XmlContextBase() : base(new NameTable())
		{
			this.AddNamespace(Xsd.Namespace);
			this.AddNamespace(Xsi.Namespace);
			this.AddNamespace(Wsdl.Namespace);
			this.AddNamespace(XRef.Namespace);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0001ADB6 File Offset: 0x00018FB6
		protected XmlContextBase(XmlContextBase parent) : base(XmlContextBase.GetNameTable(parent))
		{
			this.parent = parent;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0001ADCB File Offset: 0x00018FCB
		private static NameTable GetNameTable(XmlContextBase parent)
		{
			return (parent.NameTable as NameTable) ?? new NameTable();
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0001ADE4 File Offset: 0x00018FE4
		public void AddNamespace(XmlNamespaceAttribute attribute)
		{
			string prefix = attribute.Prefix;
			string namespaceUri = attribute.NamespaceUri;
			if (string.IsNullOrEmpty(namespaceUri))
			{
				throw Error.InvalidNamespaceUri();
			}
			if (attribute.Default)
			{
				this.AddNamespace(string.Empty, namespaceUri);
			}
			if (string.IsNullOrEmpty(prefix))
			{
				return;
			}
			this.AddNamespace(prefix, namespaceUri);
			if (attribute.Root)
			{
				this.EnsureRootNamespaces().Add(prefix, namespaceUri);
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0001AE47 File Offset: 0x00019047
		public override void AddNamespace(string prefix, string uri)
		{
			base.AddNamespace(prefix, uri);
			this.hasNamespaces = true;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0001AE58 File Offset: 0x00019058
		private Dictionary<string, string> EnsureRootNamespaces()
		{
			Dictionary<string, string> result;
			if ((result = this.rootNamespaces) == null)
			{
				result = (this.rootNamespaces = ((this.parent != null) ? new Dictionary<string, string>(this.parent.EnsureRootNamespaces()) : new Dictionary<string, string>()));
			}
			return result;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0001AE97 File Offset: 0x00019097
		public override string LookupNamespace(string prefix)
		{
			if (!this.hasNamespaces)
			{
				return this.parent.LookupNamespace(prefix);
			}
			return base.LookupNamespace(prefix);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0001AEB5 File Offset: 0x000190B5
		public override string LookupPrefix(string uri)
		{
			if (!this.hasNamespaces)
			{
				return this.parent.LookupPrefix(uri);
			}
			return base.LookupPrefix(uri);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0001AED4 File Offset: 0x000190D4
		public string GetElementPrefix(IXmlNode node, string namespaceUri)
		{
			if (namespaceUri == node.LookupNamespaceUri(string.Empty))
			{
				return string.Empty;
			}
			string text;
			if (XmlContextBase.TryGetDefinedPrefix(node, namespaceUri, out text))
			{
				return text;
			}
			if (!this.TryGetPreferredPrefix(node, namespaceUri, out text))
			{
				return string.Empty;
			}
			if (!this.ShouldDefineOnRoot(text, namespaceUri))
			{
				return string.Empty;
			}
			node.DefineNamespace(text, namespaceUri, true);
			return text;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0001AF34 File Offset: 0x00019134
		public string GetAttributePrefix(IXmlNode node, string namespaceUri)
		{
			if (string.IsNullOrEmpty(namespaceUri))
			{
				return string.Empty;
			}
			string text;
			if (XmlContextBase.TryGetDefinedPrefix(node, namespaceUri, out text))
			{
				return text;
			}
			if (!this.TryGetPreferredPrefix(node, namespaceUri, out text))
			{
				text = XmlContextBase.GeneratePrefix(node);
			}
			bool root = this.ShouldDefineOnRoot(text, namespaceUri);
			node.DefineNamespace(text, namespaceUri, root);
			return text;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0001AF84 File Offset: 0x00019184
		private static bool TryGetDefinedPrefix(IXmlNode node, string namespaceUri, out string prefix)
		{
			string value = node.LookupPrefix(namespaceUri);
			if (!string.IsNullOrEmpty(value))
			{
				return Try.Success<string>(out prefix, value);
			}
			return Try.Failure<string>(out prefix);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0001AFAF File Offset: 0x000191AF
		private bool TryGetPreferredPrefix(IXmlNode node, string namespaceUri, out string prefix)
		{
			prefix = this.LookupPrefix(namespaceUri);
			if (string.IsNullOrEmpty(prefix))
			{
				return Try.Failure<string>(out prefix);
			}
			namespaceUri = node.LookupNamespaceUri(prefix);
			return string.IsNullOrEmpty(namespaceUri) || Try.Failure<string>(out prefix);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001AFE4 File Offset: 0x000191E4
		private static string GeneratePrefix(IXmlNode node)
		{
			int num = 0;
			string text;
			for (;;)
			{
				text = "p" + num;
				if (string.IsNullOrEmpty(node.LookupNamespaceUri(text)))
				{
					break;
				}
				num++;
			}
			return text;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0001B019 File Offset: 0x00019219
		private bool ShouldDefineOnRoot(string prefix, string uri)
		{
			if (this.rootNamespaces == null)
			{
				return this.parent.ShouldDefineOnRoot(prefix, uri);
			}
			return this.ShouldDefineOnRootCore(prefix, uri);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0001B03C File Offset: 0x0001923C
		private bool ShouldDefineOnRootCore(string prefix, string uri)
		{
			string a;
			return this.rootNamespaces.TryGetValue(prefix, out a) && a == uri;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0001B064 File Offset: 0x00019264
		private XPathContext XPathContext
		{
			get
			{
				XPathContext result;
				if ((result = this.xPathContext) == null)
				{
					result = (this.xPathContext = new XPathContext(this));
				}
				return result;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0001B08A File Offset: 0x0001928A
		public override bool Whitespace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0001B08D File Offset: 0x0001928D
		public override bool PreserveWhitespace(XPathNavigator node)
		{
			return true;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0001B090 File Offset: 0x00019290
		public override int CompareDocument(string baseUriA, string baseUriB)
		{
			return StringComparer.Ordinal.Compare(baseUriA, baseUriB);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0001B0A0 File Offset: 0x000192A0
		public void AddVariable(string prefix, string name, IXsltContextVariable variable)
		{
			XmlName name2 = new XmlName(name, prefix ?? string.Empty);
			this.AddVariable(name2, variable);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0001B0C8 File Offset: 0x000192C8
		public void AddFunction(string prefix, string name, IXsltContextFunction function)
		{
			XmlName name2 = new XmlName(name, prefix ?? string.Empty);
			this.AddFunction(name2, function);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001B0EF File Offset: 0x000192EF
		public void AddVariable(XPathVariableAttribute attribute)
		{
			this.AddVariable(attribute.Name, attribute);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0001B0FE File Offset: 0x000192FE
		public void AddFunction(XPathFunctionAttribute attribute)
		{
			this.AddFunction(attribute.Name, attribute);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0001B10D File Offset: 0x0001930D
		public void AddVariable(XmlName name, IXsltContextVariable variable)
		{
			this.EnsureVariables()[name] = variable;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0001B11C File Offset: 0x0001931C
		public void AddFunction(XmlName name, IXsltContextFunction function)
		{
			this.EnsureFunctions()[name] = function;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0001B12C File Offset: 0x0001932C
		private Dictionary<XmlName, IXsltContextVariable> EnsureVariables()
		{
			Dictionary<XmlName, IXsltContextVariable> result;
			if ((result = this.variables) == null)
			{
				result = (this.variables = ((this.parent != null) ? new Dictionary<XmlName, IXsltContextVariable>(this.parent.EnsureVariables()) : new Dictionary<XmlName, IXsltContextVariable>()));
			}
			return result;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001B16C File Offset: 0x0001936C
		private Dictionary<XmlName, IXsltContextFunction> EnsureFunctions()
		{
			Dictionary<XmlName, IXsltContextFunction> result;
			if ((result = this.functions) == null)
			{
				result = (this.functions = ((this.parent != null) ? new Dictionary<XmlName, IXsltContextFunction>(this.parent.EnsureFunctions()) : new Dictionary<XmlName, IXsltContextFunction>()));
			}
			return result;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0001B1AB File Offset: 0x000193AB
		public override IXsltContextVariable ResolveVariable(string prefix, string name)
		{
			if (this.variables != null)
			{
				return this.ResolveVariableCore(prefix, name);
			}
			if (this.parent == null)
			{
				return null;
			}
			return this.parent.ResolveVariable(prefix, name);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0001B1D5 File Offset: 0x000193D5
		public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] argTypes)
		{
			if (this.functions != null)
			{
				return this.ResolveFunctionCore(prefix, name, argTypes);
			}
			if (this.parent == null)
			{
				return null;
			}
			return this.parent.ResolveFunction(prefix, name, argTypes);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0001B204 File Offset: 0x00019404
		private IXsltContextVariable ResolveVariableCore(string prefix, string name)
		{
			XmlName key = new XmlName(name, prefix ?? string.Empty);
			IXsltContextVariable result;
			this.variables.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0001B234 File Offset: 0x00019434
		private IXsltContextFunction ResolveFunctionCore(string prefix, string name, XPathResultType[] argTypes)
		{
			XmlName key = new XmlName(name, prefix ?? string.Empty);
			IXsltContextFunction result;
			this.functions.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0001B263 File Offset: 0x00019463
		public void Enlist(CompiledXPath path)
		{
			path.SetContext(this.XPathContext);
		}

		// Token: 0x04000260 RID: 608
		private readonly XmlContextBase parent;

		// Token: 0x04000261 RID: 609
		private Dictionary<string, string> rootNamespaces;

		// Token: 0x04000262 RID: 610
		private bool hasNamespaces;

		// Token: 0x04000263 RID: 611
		private XPathContext xPathContext;

		// Token: 0x04000264 RID: 612
		private Dictionary<XmlName, IXsltContextVariable> variables;

		// Token: 0x04000265 RID: 613
		private Dictionary<XmlName, IXsltContextFunction> functions;
	}
}
