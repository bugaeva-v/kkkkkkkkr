using System;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000024 RID: 36
	internal class GooglePlayCartValidator : StoreCartValidator
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00002F12 File Offset: 0x00001112
		[Preserve]
		internal GooglePlayCartValidator() : base("Google Play", new SingleProductSingleQuantityCartValidator())
		{
		}
	}
}
