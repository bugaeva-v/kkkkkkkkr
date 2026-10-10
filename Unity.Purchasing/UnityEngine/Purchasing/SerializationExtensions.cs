using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000103 RID: 259
	internal static class SerializationExtensions
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x0000A656 File Offset: 0x00008856
		public static string TryGetString(this Dictionary<string, object> dic, string key)
		{
			if (dic.ContainsKey(key) && dic[key] != null)
			{
				return dic[key].ToString();
			}
			return null;
		}
	}
}
