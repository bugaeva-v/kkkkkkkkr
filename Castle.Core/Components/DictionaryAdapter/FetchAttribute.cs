using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x020000FC RID: 252
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false)]
	public class FetchAttribute : Attribute
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x0001305F File Offset: 0x0001125F
		public FetchAttribute() : this(true)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00013068 File Offset: 0x00011268
		public FetchAttribute(bool fetch)
		{
			this.Fetch = fetch;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00013077 File Offset: 0x00011277
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x0001307F File Offset: 0x0001127F
		public bool Fetch { get; private set; }
	}
}
