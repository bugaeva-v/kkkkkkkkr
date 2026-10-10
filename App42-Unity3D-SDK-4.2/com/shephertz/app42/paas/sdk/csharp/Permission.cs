using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x0200000C RID: 12
	public sealed class Permission
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000039C6 File Offset: 0x00001BC6
		private Permission(string value)
		{
			this.value = value;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000039D5 File Offset: 0x00001BD5
		public string GetValue()
		{
			return this.value;
		}

		// Token: 0x04000024 RID: 36
		public static readonly string READ = "R";

		// Token: 0x04000025 RID: 37
		public static readonly string WRITE = "W";

		// Token: 0x04000026 RID: 38
		private string value;
	}
}
