using System;
using System.Collections.Generic;

// Token: 0x020001B9 RID: 441
[Serializable]
public class LoadingEnvironmentRegistryData
{
	// Token: 0x0400104E RID: 4174
	public int version;

	// Token: 0x0400104F RID: 4175
	public List<LoadingEnvironmentRegistryEntry> entries = new List<LoadingEnvironmentRegistryEntry>();

	// Token: 0x04001050 RID: 4176
	public bool active = true;

	// Token: 0x04001051 RID: 4177
	public bool crashParked;

	// Token: 0x04001052 RID: 4178
	public bool liteParked;

	// Token: 0x04001053 RID: 4179
	public bool liteParkNotice;
}
