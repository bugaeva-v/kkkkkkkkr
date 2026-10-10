using System;

namespace UnityEngine.Pool
{
	// Token: 0x02000386 RID: 902
	public static class UnsafeGenericPool<T> where T : class, new()
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x000320CF File Offset: 0x000302CF
		public static T Get()
		{
			return UnsafeGenericPool<T>.s_Pool.Get();
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x000320DB File Offset: 0x000302DB
		public static PooledObject<T> Get(out T value)
		{
			return UnsafeGenericPool<T>.s_Pool.Get(out value);
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000320E8 File Offset: 0x000302E8
		public static void Release(T toRelease)
		{
			UnsafeGenericPool<T>.s_Pool.Release(toRelease);
		}

		// Token: 0x04000A1C RID: 2588
		internal static readonly ObjectPool<T> s_Pool = new ObjectPool<T>(() => Activator.CreateInstance<T>(), null, null, null, false, 10, 10000);
	}
}
