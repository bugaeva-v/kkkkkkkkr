using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000045 RID: 69
	internal class DialogRequest
	{
		// Token: 0x0400009D RID: 157
		public string QueryText;

		// Token: 0x0400009E RID: 158
		public string OkayButtonText;

		// Token: 0x0400009F RID: 159
		public string CancelButtonText;

		// Token: 0x040000A0 RID: 160
		public List<string> Options;

		// Token: 0x040000A1 RID: 161
		public Action<bool, int> Callback;
	}
}
