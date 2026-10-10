using System;

namespace UnityEngine.Pool
{
	// Token: 0x0200037F RID: 895
	public class GenericPool<T> where T : class, new()
	{
		// Token: 0x06001EA3 RID: 7843 RVA: 0x00031B86 File Offset: 0x0002FD86
		public static T Get()
		{
			return GenericPool<T>.s_Pool.Get();
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00031B92 File Offset: 0x0002FD92
		public static PooledObject<T> Get(out T value)
		{
			return GenericPool<T>.s_Pool.Get(out value);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00031B9F File Offset: 0x0002FD9F
		public static void Release(T toRelease)
		{
			GenericPool<T>.s_Pool.Release(toRelease);
		}

		// Token: 0x04000A05 RID: 2565
		internal static readonly ObjectPool<T> s_Pool = new ObjectPool<T>(() => Activator.CreateInstance<T>(), null, null, null, true, 10, 10000);
	}
}
