using System;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Authentication.Internal
{
	// Token: 0x02000010 RID: 16
	[RequireImplementors]
	public interface IPlayerId : IServiceComponent
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22
		string PlayerId { get; }

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000017 RID: 23
		// (remove) Token: 0x06000018 RID: 24
		event Action<string> PlayerIdChanged;
	}
}
