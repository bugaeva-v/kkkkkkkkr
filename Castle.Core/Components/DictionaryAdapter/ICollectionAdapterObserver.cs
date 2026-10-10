using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000140 RID: 320
	public interface ICollectionAdapterObserver<T>
	{
		// Token: 0x060008D0 RID: 2256
		bool OnInserting(T newValue);

		// Token: 0x060008D1 RID: 2257
		bool OnReplacing(T oldValue, T newValue);

		// Token: 0x060008D2 RID: 2258
		void OnRemoving(T oldValue);

		// Token: 0x060008D3 RID: 2259
		void OnInserted(T newValue, int index);

		// Token: 0x060008D4 RID: 2260
		void OnReplaced(T oldValue, T newValue, int index);

		// Token: 0x060008D5 RID: 2261
		void OnRemoved(T oldValue, int index);
	}
}
