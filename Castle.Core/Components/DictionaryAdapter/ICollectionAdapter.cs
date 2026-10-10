using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200013F RID: 319
	public interface ICollectionAdapter<T>
	{
		// Token: 0x060008BE RID: 2238
		void Initialize(ICollectionAdapterObserver<T> advisor);

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060008BF RID: 2239
		IEqualityComparer<T> Comparer { get; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060008C0 RID: 2240
		int Count { get; }

		// Token: 0x1700018A RID: 394
		T this[int index]
		{
			get;
			set;
		}

		// Token: 0x060008C3 RID: 2243
		T AddNew();

		// Token: 0x060008C4 RID: 2244
		bool Add(T value);

		// Token: 0x060008C5 RID: 2245
		bool Insert(int index, T value);

		// Token: 0x060008C6 RID: 2246
		void Remove(int index);

		// Token: 0x060008C7 RID: 2247
		void Clear();

		// Token: 0x060008C8 RID: 2248
		void ClearReferences();

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060008C9 RID: 2249
		bool HasSnapshot { get; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060008CA RID: 2250
		int SnapshotCount { get; }

		// Token: 0x060008CB RID: 2251
		T GetCurrentItem(int index);

		// Token: 0x060008CC RID: 2252
		T GetSnapshotItem(int index);

		// Token: 0x060008CD RID: 2253
		void SaveSnapshot();

		// Token: 0x060008CE RID: 2254
		void LoadSnapshot();

		// Token: 0x060008CF RID: 2255
		void DropSnapshot();
	}
}
