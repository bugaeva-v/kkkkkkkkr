using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000389 RID: 905
	[MovedFrom("UnityEngine.Experimental.Networking.PlayerConnection")]
	public interface IConnectionState : IDisposable
	{
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001ECC RID: 7884
		ConnectionTarget connectedToTarget { get; }

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001ECD RID: 7885
		string connectionName { get; }
	}
}
