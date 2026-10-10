using System;
using System.Runtime.CompilerServices;
using Purchasing.Extension;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000A2 RID: 162
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreWrapper : IStoreWrapper
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00006BB8 File Offset: 0x00004DB8
		public string name { get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00006BC0 File Offset: 0x00004DC0
		public Store instance
		{
			get
			{
				return this.m_InternalStore;
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00006BC8 File Offset: 0x00004DC8
		public ConnectionState GetStoreConnectionState()
		{
			return this.m_InternalStore.GetStoreConnectionState();
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00006BD5 File Offset: 0x00004DD5
		public StoreWrapper(string name, InternalStore instance)
		{
			this.name = name;
			this.m_InternalStore = instance;
		}

		// Token: 0x040000D9 RID: 217
		private InternalStore m_InternalStore;
	}
}
