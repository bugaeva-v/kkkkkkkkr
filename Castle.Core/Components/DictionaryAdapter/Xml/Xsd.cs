using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200018B RID: 395
	public static class Xsd
	{
		// Token: 0x040002A1 RID: 673
		public const string Prefix = "xsd";

		// Token: 0x040002A2 RID: 674
		public const string NamespaceUri = "http://www.w3.org/2001/XMLSchema";

		// Token: 0x040002A3 RID: 675
		internal static readonly XmlNamespaceAttribute Namespace = new XmlNamespaceAttribute("http://www.w3.org/2001/XMLSchema", "xsd")
		{
			Root = true
		};
	}
}
