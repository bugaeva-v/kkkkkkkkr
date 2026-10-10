using System;
using UnityEngine.Purchasing.MiniJSON;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000D RID: 13
	public class MiniJson
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00002324 File Offset: 0x00000524
		public static string JsonEncode(object json)
		{
			return Json.Serialize(json);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000232C File Offset: 0x0000052C
		public static object JsonDecode(string json)
		{
			return Json.Deserialize(json);
		}
	}
}
