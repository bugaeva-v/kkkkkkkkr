using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000141 RID: 321
	public interface ICollectionProjection : ICollection, IEnumerable
	{
		// Token: 0x060008D6 RID: 2262
		void Replace(IEnumerable source);

		// Token: 0x060008D7 RID: 2263
		void Clear();

		// Token: 0x060008D8 RID: 2264
		void ClearReferences();
	}
}
