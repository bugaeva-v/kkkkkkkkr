using System;

namespace UnityEngine.Pool
{
	// Token: 0x02000385 RID: 901
	public struct PooledObject<T> : IDisposable where T : class
	{
		// Token: 0x06001EC3 RID: 7875 RVA: 0x000320AA File Offset: 0x000302AA
		public PooledObject(T value, IObjectPool<T> pool)
		{
			this.m_ToReturn = value;
			this.m_Pool = pool;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x000320BB File Offset: 0x000302BB
		void IDisposable.Dispose()
		{
			this.m_Pool.Release(this.m_ToReturn);
		}

		// Token: 0x04000A1A RID: 2586
		private readonly T m_ToReturn;

		// Token: 0x04000A1B RID: 2587
		private readonly IObjectPool<T> m_Pool;
	}
}
