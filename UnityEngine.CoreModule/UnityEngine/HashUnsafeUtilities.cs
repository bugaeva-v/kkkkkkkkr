using System;

namespace UnityEngine
{
	// Token: 0x020001B1 RID: 433
	public static class HashUnsafeUtilities
	{
		// Token: 0x0600132B RID: 4907 RVA: 0x0001A29F File Offset: 0x0001849F
		public unsafe static void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2)
		{
			SpookyHash.Hash(data, dataSize, hash1, hash2);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0001A2AC File Offset: 0x000184AC
		public unsafe static void ComputeHash128(void* data, ulong dataSize, Hash128* hash)
		{
			ulong u64_ = hash->u64_0;
			ulong u64_2 = hash->u64_1;
			HashUnsafeUtilities.ComputeHash128(data, dataSize, &u64_, &u64_2);
			*hash = new Hash128(u64_, u64_2);
		}
	}
}
