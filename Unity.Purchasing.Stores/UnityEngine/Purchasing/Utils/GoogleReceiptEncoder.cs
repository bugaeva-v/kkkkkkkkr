using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.Utils
{
	// Token: 0x0200004F RID: 79
	internal static class GoogleReceiptEncoder
	{
		// Token: 0x060001ED RID: 493 RVA: 0x00007FB8 File Offset: 0x000061B8
		internal static string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, List<string> productDetailsJson)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["json"] = purchaseOriginalJson;
			dictionary["signature"] = purchaseSignature;
			dictionary["skuDetails"] = productDetailsJson;
			return MiniJson.JsonEncode(dictionary);
		}
	}
}
