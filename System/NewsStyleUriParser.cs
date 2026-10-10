using System;

namespace System
{
	/// <summary>Настраиваемое средство анализа, основанное на схеме новостей, используемой протоколом NNTP.</summary>
	// Token: 0x02000161 RID: 353
	public class NewsStyleUriParser : UriParser
	{
		/// <summary>Создайте настраиваемое средство анализа, основанное на схеме новостей, используемой протоколом NNTP.</summary>
		// Token: 0x0600098E RID: 2446 RVA: 0x0002A2E3 File Offset: 0x000284E3
		public NewsStyleUriParser() : base(UriParser.NewsUri.Flags)
		{
		}
	}
}
