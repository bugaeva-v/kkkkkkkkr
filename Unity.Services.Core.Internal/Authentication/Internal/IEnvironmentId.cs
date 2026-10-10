using System;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Authentication.Internal
{
	// Token: 0x0200000F RID: 15
	[RequireImplementors]
	public interface IEnvironmentId : IServiceComponent
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21
		string EnvironmentId { get; }
	}
}
