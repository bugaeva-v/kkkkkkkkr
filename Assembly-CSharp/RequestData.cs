using System;
using System.Collections.Generic;

// Token: 0x02000500 RID: 1280
[Serializable]
internal class RequestData
{
	// Token: 0x04002AA9 RID: 10921
	public string timestamp;

	// Token: 0x04002AAA RID: 10922
	public string device_os_version;

	// Token: 0x04002AAB RID: 10923
	public string device_model;

	// Token: 0x04002AAC RID: 10924
	public string app_version;

	// Token: 0x04002AAD RID: 10925
	public DeviceIDs[] device_ids;

	// Token: 0x04002AAE RID: 10926
	public string request_id;

	// Token: 0x04002AAF RID: 10927
	public bool limit_ad_tracking;

	// Token: 0x04002AB0 RID: 10928
	public string event_name;

	// Token: 0x04002AB1 RID: 10929
	public string customer_user_id;

	// Token: 0x04002AB2 RID: 10930
	public Dictionary<string, object> event_parameters;
}
