using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200018C RID: 396
	public static class Xsi
	{
		// Token: 0x06000C81 RID: 3201 RVA: 0x0001E378 File Offset: 0x0001C578
		public static XmlName GetXsiType(this IXmlNode node)
		{
			string attribute = node.GetAttribute(Xsi.Type);
			if (attribute == null)
			{
				return XmlName.Empty;
			}
			XmlName result = XmlName.ParseQName(attribute);
			if (result.NamespaceUri != null)
			{
				string namespaceUri = node.LookupNamespaceUri(result.NamespaceUri);
				result = result.WithNamespaceUri(namespaceUri);
			}
			return result;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0001E3C4 File Offset: 0x0001C5C4
		public static void SetXsiType(this IXmlNode node, XmlName xsiType)
		{
			if (xsiType.NamespaceUri != null)
			{
				string attributePrefix = node.Namespaces.GetAttributePrefix(node, xsiType.NamespaceUri);
				xsiType = xsiType.WithNamespaceUri(attributePrefix);
			}
			node.SetAttribute(Xsi.Type, xsiType.ToString());
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0001E410 File Offset: 0x0001C610
		public static bool IsXsiNil(this IXmlNode node)
		{
			return node.GetAttribute(Xsi.Nil) == "true";
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0001E428 File Offset: 0x0001C628
		public static void SetXsiNil(this IXmlNode node, bool nil)
		{
			string value;
			if (nil)
			{
				node.Clear();
				value = "true";
			}
			else
			{
				value = null;
			}
			node.SetAttribute(Xsi.Nil, value);
		}

		// Token: 0x040002A4 RID: 676
		public const string Prefix = "xsi";

		// Token: 0x040002A5 RID: 677
		public const string NamespaceUri = "http://www.w3.org/2001/XMLSchema-instance";

		// Token: 0x040002A6 RID: 678
		public const string NilValue = "true";

		// Token: 0x040002A7 RID: 679
		public static readonly XmlName Type = new XmlName("type", "http://www.w3.org/2001/XMLSchema-instance");

		// Token: 0x040002A8 RID: 680
		public static readonly XmlName Nil = new XmlName("nil", "http://www.w3.org/2001/XMLSchema-instance");

		// Token: 0x040002A9 RID: 681
		internal static readonly XmlNamespaceAttribute Namespace = new XmlNamespaceAttribute("http://www.w3.org/2001/XMLSchema-instance", "xsi")
		{
			Root = true
		};
	}
}
