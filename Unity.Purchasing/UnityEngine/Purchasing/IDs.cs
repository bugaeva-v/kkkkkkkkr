using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000BB RID: 187
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class IDs : IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		// Token: 0x0600035F RID: 863 RVA: 0x00008480 File Offset: 0x00006680
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.m_Dic.GetEnumerator();
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00008494 File Offset: 0x00006694
		public void Add(string id, params string[] stores)
		{
			foreach (string key in stores)
			{
				this.m_Dic[key] = id;
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000084C4 File Offset: 0x000066C4
		public void Add(string id, params object[] stores)
		{
			foreach (object obj in stores)
			{
				this.m_Dic[obj.ToString()] = id;
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000084F7 File Offset: 0x000066F7
		internal string SpecificIDForStore(string store, string defaultValue)
		{
			if (this.m_Dic.ContainsKey(store))
			{
				return this.m_Dic[store];
			}
			return defaultValue;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00008515 File Offset: 0x00006715
		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return this.m_Dic.GetEnumerator();
		}

		// Token: 0x0400016B RID: 363
		private readonly Dictionary<string, string> m_Dic = new Dictionary<string, string>();
	}
}
