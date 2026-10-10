using System;

namespace UnityEngine.Pool
{
	// Token: 0x02000381 RID: 897
	public interface IObjectPool<T> where T : class
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001EAB RID: 7851
		int CountInactive { get; }

		// Token: 0x06001EAC RID: 7852
		T Get();

		// Token: 0x06001EAD RID: 7853
		PooledObject<T> Get(out T v);

		// Token: 0x06001EAE RID: 7854
		void Release(T element);

		// Token: 0x06001EAF RID: 7855
		void Clear();
	}
}
