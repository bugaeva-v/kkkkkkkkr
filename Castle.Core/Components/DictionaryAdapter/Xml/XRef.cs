using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200018A RID: 394
	public static class XRef
	{
		// Token: 0x06000C7B RID: 3195 RVA: 0x0001E2D1 File Offset: 0x0001C4D1
		public static string GetId(this IXmlNode node)
		{
			return node.GetAttribute(XRef.Id);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0001E2DE File Offset: 0x0001C4DE
		public static void SetId(this IXmlCursor node, string id)
		{
			node.SetAttribute(XRef.Id, id);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0001E2EC File Offset: 0x0001C4EC
		public static string GetReference(this IXmlNode node)
		{
			return node.GetAttribute(XRef.Ref);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0001E2F9 File Offset: 0x0001C4F9
		public static void SetReference(this IXmlCursor cursor, string id)
		{
			cursor.SetAttribute(XRef.Ref, id);
		}

		// Token: 0x0400029C RID: 668
		public const string Prefix = "x";

		// Token: 0x0400029D RID: 669
		public const string NamespaceUri = "urn:schemas-castle-org:xml-reference";

		// Token: 0x0400029E RID: 670
		public static readonly XmlName Id = new XmlName("id", "urn:schemas-castle-org:xml-reference");

		// Token: 0x0400029F RID: 671
		public static readonly XmlName Ref = new XmlName("ref", "urn:schemas-castle-org:xml-reference");

		// Token: 0x040002A0 RID: 672
		internal static readonly XmlNamespaceAttribute Namespace = new XmlNamespaceAttribute("urn:schemas-castle-org:xml-reference", "x")
		{
			Root = true
		};
	}
}
