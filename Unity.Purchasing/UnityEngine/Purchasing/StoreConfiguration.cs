using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C2 RID: 194
	internal class StoreConfiguration
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00008841 File Offset: 0x00006A41
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00008849 File Offset: 0x00006A49
		public AppStore androidStore { get; private set; }

		// Token: 0x0600038B RID: 907 RVA: 0x00008852 File Offset: 0x00006A52
		public StoreConfiguration(AppStore store)
		{
			this.androidStore = store;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00008864 File Offset: 0x00006A64
		public static string Serialize(StoreConfiguration store)
		{
			return MiniJson.JsonEncode(new Dictionary<string, object>
			{
				{
					"androidStore",
					store.androidStore.ToString()
				}
			});
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000889C File Offset: 0x00006A9C
		public static StoreConfiguration Deserialize(string json)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MiniJson.JsonDecode(json);
			string value = (string)dictionary["androidStore"];
			return new StoreConfiguration((!Enum.IsDefined(typeof(AppStore), value)) ? AppStore.GooglePlay : ((AppStore)Enum.Parse(typeof(AppStore), (string)dictionary["androidStore"], true)));
		}
	}
}
