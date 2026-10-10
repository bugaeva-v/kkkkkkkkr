using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000188 RID: 392
	public static class Wsdl
	{
		// Token: 0x04000297 RID: 663
		public const string Prefix = "wsdl";

		// Token: 0x04000298 RID: 664
		public const string NamespaceUri = "http://microsoft.com/wsdl/types/";

		// Token: 0x04000299 RID: 665
		internal static readonly XmlNamespaceAttribute Namespace = new XmlNamespaceAttribute("http://microsoft.com/wsdl/types/", "wsdl")
		{
			Root = true
		};
	}
}
