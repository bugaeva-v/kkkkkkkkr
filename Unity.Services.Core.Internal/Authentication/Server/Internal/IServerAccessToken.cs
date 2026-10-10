using System;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Authentication.Server.Internal
{
	// Token: 0x0200000B RID: 11
	[RequireImplementors]
	public interface IServerAccessToken : IAccessToken, IServiceComponent, IAccessTokenObserver
	{
	}
}
