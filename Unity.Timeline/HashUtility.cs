using System;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004B RID: 75
	internal static class HashUtility
	{
		// Token: 0x060002CE RID: 718 RVA: 0x0000A22C File Offset: 0x0000842C
		public static int CombineHash(this int h1, int h2)
		{
			return h1 ^ (int)((long)h2 + (long)((ulong)-1640531527) + (long)((long)h1 << 6) + (long)(h1 >> 2));
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000A244 File Offset: 0x00008444
		public static int CombineHash(int h1, int h2, int h3)
		{
			return h1.CombineHash(h2).CombineHash(h3);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000A253 File Offset: 0x00008453
		public static int CombineHash(int h1, int h2, int h3, int h4)
		{
			return HashUtility.CombineHash(h1, h2, h3).CombineHash(h4);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000A263 File Offset: 0x00008463
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5)
		{
			return HashUtility.CombineHash(h1, h2, h3, h4).CombineHash(h5);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000A275 File Offset: 0x00008475
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6)
		{
			return HashUtility.CombineHash(h1, h2, h3, h4, h5).CombineHash(h6);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000A289 File Offset: 0x00008489
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
		{
			return HashUtility.CombineHash(h1, h2, h3, h4, h5, h6).CombineHash(h7);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000A2A0 File Offset: 0x000084A0
		public static int CombineHash(int[] hashes)
		{
			if (hashes == null || hashes.Length == 0)
			{
				return 0;
			}
			int num = hashes[0];
			for (int i = 1; i < hashes.Length; i++)
			{
				num = num.CombineHash(hashes[i]);
			}
			return num;
		}
	}
}
