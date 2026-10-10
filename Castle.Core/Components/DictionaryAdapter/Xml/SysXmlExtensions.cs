using System;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200017B RID: 379
	public static class SysXmlExtensions
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
		public static void DefineNamespace(this XmlElement node, string prefix, string namespaceUri)
		{
			XmlAttribute xmlAttribute = node.OwnerDocument.CreateAttribute("xmlns", prefix, "http://www.w3.org/2000/xmlns/");
			xmlAttribute.Value = namespaceUri;
			node.SetAttributeNode(xmlAttribute);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0001C427 File Offset: 0x0001A627
		public static bool IsNamespace(this XmlAttribute attribute)
		{
			return attribute.Prefix == "xmlns" || (string.IsNullOrEmpty(attribute.Prefix) && attribute.LocalName == "xmlns");
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0001C45C File Offset: 0x0001A65C
		public static XmlElement FindRoot(this XmlElement node)
		{
			for (;;)
			{
				XmlElement xmlElement = node.ParentNode as XmlElement;
				if (xmlElement == null)
				{
					break;
				}
				node = xmlElement;
			}
			return node;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0001C480 File Offset: 0x0001A680
		public static bool IsXsiType(this XmlAttribute attribute)
		{
			return attribute.LocalName == Xsi.Type.LocalName && attribute.NamespaceURI == "http://www.w3.org/2001/XMLSchema-instance";
		}
	}
}
