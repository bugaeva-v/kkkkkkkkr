using System;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Authentication.Internal
{
	// Token: 0x0200000E RID: 14
	[RequireImplementors]
	public interface IAccessTokenObserver : IServiceComponent
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000013 RID: 19
		// (remove) Token: 0x06000014 RID: 20
		event Action<string> AccessTokenChanged;
	}
}
