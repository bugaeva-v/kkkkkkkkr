using System;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Core.Configuration.Internal
{
	// Token: 0x02000023 RID: 35
	[RequireImplementors]
	public interface IExternalUserId : IServiceComponent
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000062 RID: 98
		string UserId { get; }

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000063 RID: 99
		// (remove) Token: 0x06000064 RID: 100
		event Action<string> UserIdChanged;
	}
}
