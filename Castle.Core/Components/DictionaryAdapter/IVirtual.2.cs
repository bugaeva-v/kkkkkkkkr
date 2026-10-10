using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000147 RID: 327
	public interface IVirtual<T> : IVirtual
	{
		// Token: 0x060008E1 RID: 2273
		T Realize();

		// Token: 0x060008E2 RID: 2274
		void AddSite(IVirtualSite<T> site);

		// Token: 0x060008E3 RID: 2275
		void RemoveSite(IVirtualSite<T> site);
	}
}
