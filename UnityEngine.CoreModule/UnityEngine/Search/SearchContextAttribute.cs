using System;

namespace UnityEngine.Search
{
	// Token: 0x020002D4 RID: 724
	[AttributeUsage(AttributeTargets.Field)]
	public class SearchContextAttribute : PropertyAttribute
	{
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00030B6A File Offset: 0x0002ED6A
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00030B72 File Offset: 0x0002ED72
		public string query { get; private set; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x00030B7B File Offset: 0x0002ED7B
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00030B83 File Offset: 0x0002ED83
		public string[] providerIds { get; private set; }

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00030B8C File Offset: 0x0002ED8C
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x00030B94 File Offset: 0x0002ED94
		public Type[] instantiableProviders { get; private set; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x00030B9D File Offset: 0x0002ED9D
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x00030BA5 File Offset: 0x0002EDA5
		public SearchViewFlags flags { get; private set; }

		// Token: 0x06001DEC RID: 7660 RVA: 0x00030BAE File Offset: 0x0002EDAE
		public SearchContextAttribute(string query) : this(query, null, SearchViewFlags.None)
		{
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00030BBB File Offset: 0x0002EDBB
		public SearchContextAttribute(string query, SearchViewFlags flags) : this(query, null, flags)
		{
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00030BC8 File Offset: 0x0002EDC8
		public SearchContextAttribute(string query, string providerIdsCommaSeparated) : this(query, providerIdsCommaSeparated, SearchViewFlags.None)
		{
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00030BD5 File Offset: 0x0002EDD5
		public SearchContextAttribute(string query, string providerIdsCommaSeparated, SearchViewFlags flags) : this(query, flags, providerIdsCommaSeparated, null)
		{
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00030BE3 File Offset: 0x0002EDE3
		public SearchContextAttribute(string query, params Type[] instantiableProviders) : this(query, SearchViewFlags.None, null, instantiableProviders)
		{
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00030BF1 File Offset: 0x0002EDF1
		public SearchContextAttribute(string query, SearchViewFlags flags, params Type[] instantiableProviders) : this(query, flags, null, instantiableProviders)
		{
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00030C00 File Offset: 0x0002EE00
		public SearchContextAttribute(string query, SearchViewFlags flags, string providerIdsCommaSeparated, params Type[] instantiableProviders)
		{
			this.query = ((string.IsNullOrEmpty(query) || query.EndsWith(" ")) ? query : (query + " "));
			this.providerIds = (((providerIdsCommaSeparated != null) ? providerIdsCommaSeparated.Split(new char[]
			{
				',',
				';'
			}) : null) ?? new string[0]);
			this.instantiableProviders = (instantiableProviders ?? new Type[0]);
			this.flags = flags;
		}
	}
}
