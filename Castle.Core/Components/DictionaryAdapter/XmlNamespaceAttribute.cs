using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000110 RID: 272
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = true)]
	public class XmlNamespaceAttribute : Attribute
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x00013B5C File Offset: 0x00011D5C
		public XmlNamespaceAttribute(string namespaceUri, string prefix)
		{
			this.NamespaceUri = namespaceUri;
			this.Prefix = prefix;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00013B72 File Offset: 0x00011D72
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00013B7A File Offset: 0x00011D7A
		public bool Root { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00013B83 File Offset: 0x00011D83
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00013B8B File Offset: 0x00011D8B
		public bool Default { get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00013B94 File Offset: 0x00011D94
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00013B9C File Offset: 0x00011D9C
		public string NamespaceUri { get; private set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00013BA5 File Offset: 0x00011DA5
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00013BAD File Offset: 0x00011DAD
		public string Prefix { get; private set; }
	}
}
