using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000036 RID: 54
	internal interface IServiceDebug
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000175 RID: 373
		bool IsActive { get; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000176 RID: 374
		IIdentityManager UserIdentity { get; }
	}
}
