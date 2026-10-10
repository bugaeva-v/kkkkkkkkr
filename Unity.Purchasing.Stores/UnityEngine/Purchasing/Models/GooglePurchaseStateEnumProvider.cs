using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000057 RID: 87
	[Preserve]
	internal class GooglePurchaseStateEnumProvider : IGooglePurchaseStateEnumProvider
	{
		// Token: 0x0600022B RID: 555 RVA: 0x000092D4 File Offset: 0x000074D4
		public int Purchased()
		{
			return GooglePurchaseStateEnum.Purchased();
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000092DB File Offset: 0x000074DB
		public int Pending()
		{
			return GooglePurchaseStateEnum.Pending();
		}
	}
}
