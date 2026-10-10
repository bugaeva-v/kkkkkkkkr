using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000B1 RID: 177
	[Serializable]
	public class StoreID
	{
		// Token: 0x06000327 RID: 807 RVA: 0x0000787C File Offset: 0x00005A7C
		public StoreID(string store_, string id_)
		{
			this.store = store_;
			this.id = id_;
		}

		// Token: 0x040000F0 RID: 240
		public string store;

		// Token: 0x040000F1 RID: 241
		public string id;
	}
}
