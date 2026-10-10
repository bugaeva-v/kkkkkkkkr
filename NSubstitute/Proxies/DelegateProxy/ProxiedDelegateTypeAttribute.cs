using System;

namespace NSubstitute.Proxies.DelegateProxy
{
	// Token: 0x0200003E RID: 62
	[Obsolete("This class is deprecated and will be removed in future versions of the product.")]
	[AttributeUsage(AttributeTargets.Method)]
	public class ProxiedDelegateTypeAttribute : Attribute
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00004043 File Offset: 0x00002243
		public Type DelegateType { get; }

		// Token: 0x060000D8 RID: 216 RVA: 0x0000404B File Offset: 0x0000224B
		public ProxiedDelegateTypeAttribute(Type delegateType)
		{
			this.DelegateType = delegateType;
		}
	}
}
