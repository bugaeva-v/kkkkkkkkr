using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000146 RID: 326
	public interface IVirtual
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060008DD RID: 2269
		bool IsReal { get; }

		// Token: 0x060008DE RID: 2270
		void Realize();

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060008DF RID: 2271
		// (remove) Token: 0x060008E0 RID: 2272
		event EventHandler Realized;
	}
}
