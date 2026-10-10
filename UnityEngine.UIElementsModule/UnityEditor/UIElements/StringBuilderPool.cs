using System;
using System.Text;
using UnityEngine.Pool;

namespace UnityEditor.UIElements
{
	// Token: 0x02000004 RID: 4
	internal static class StringBuilderPool
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002059 File Offset: 0x00000259
		public static StringBuilder Get()
		{
			return StringBuilderPool.s_Pool.Get();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002065 File Offset: 0x00000265
		public static PooledObject<StringBuilder> Get(out StringBuilder value)
		{
			return StringBuilderPool.s_Pool.Get(out value);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		public static void Release(StringBuilder toRelease)
		{
			StringBuilderPool.s_Pool.Release(toRelease);
		}

		// Token: 0x04000001 RID: 1
		internal static readonly ObjectPool<StringBuilder> s_Pool = new ObjectPool<StringBuilder>(() => new StringBuilder(), null, delegate(StringBuilder sb)
		{
			sb.Length = 0;
		}, null, true, 10, 10000);
	}
}
