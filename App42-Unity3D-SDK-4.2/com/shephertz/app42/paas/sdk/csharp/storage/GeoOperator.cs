using System;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x02000085 RID: 133
	public sealed class GeoOperator
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x0001F22A File Offset: 0x0001D42A
		private GeoOperator(string value)
		{
			this.value = value;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001F239 File Offset: 0x0001D439
		public string GetValue()
		{
			return this.value;
		}

		// Token: 0x04000247 RID: 583
		public static readonly string NEAR = "$near";

		// Token: 0x04000248 RID: 584
		public static readonly string WITHIN = "$within";

		// Token: 0x04000249 RID: 585
		private string value;
	}
}
