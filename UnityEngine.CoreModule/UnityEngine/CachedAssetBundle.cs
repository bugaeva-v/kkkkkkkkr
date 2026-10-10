using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000F0 RID: 240
	[UsedByNativeCode]
	public struct CachedAssetBundle
	{
		// Token: 0x0600044C RID: 1100 RVA: 0x00006FD6 File Offset: 0x000051D6
		public CachedAssetBundle(string name, Hash128 hash)
		{
			this.m_Name = name;
			this.m_Hash = hash;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00006FE8 File Offset: 0x000051E8
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00007000 File Offset: 0x00005200
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000700C File Offset: 0x0000520C
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00007024 File Offset: 0x00005224
		public Hash128 hash
		{
			get
			{
				return this.m_Hash;
			}
			set
			{
				this.m_Hash = value;
			}
		}

		// Token: 0x04000328 RID: 808
		private string m_Name;

		// Token: 0x04000329 RID: 809
		private Hash128 m_Hash;
	}
}
