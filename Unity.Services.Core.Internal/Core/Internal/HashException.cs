using System;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000043 RID: 67
	internal class HashException : Exception
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000370E File Offset: 0x0000190E
		public int Hash { get; }

		// Token: 0x0600012E RID: 302 RVA: 0x00003716 File Offset: 0x00001916
		public HashException(int hash)
		{
			this.Hash = hash;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003725 File Offset: 0x00001925
		public HashException(int hash, string message)
		{
			this.Hash = hash;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003734 File Offset: 0x00001934
		public HashException(int hash, string message, Exception inner) : base(message, inner)
		{
			this.Hash = hash;
		}
	}
}
