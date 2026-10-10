using System;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Authentication.Internal
{
	// Token: 0x02000011 RID: 17
	[RequireImplementors]
	public interface IPlayerNameComponent : IServiceComponent
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25
		string PlayerName { get; }

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600001A RID: 26
		// (remove) Token: 0x0600001B RID: 27
		event Action<string> PlayerNameChanged;
	}
}
