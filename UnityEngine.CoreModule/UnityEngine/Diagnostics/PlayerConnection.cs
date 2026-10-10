using System;
using System.ComponentModel;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.Diagnostics
{
	// Token: 0x02000451 RID: 1105
	public static class PlayerConnection
	{
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00041160 File Offset: 0x0003F360
		[Obsolete("Use UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.isConnected instead.")]
		public static bool connected
		{
			get
			{
				return PlayerConnection.instance.isConnected;
			}
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00004563 File Offset: 0x00002763
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("PlayerConnection.SendFile is no longer supported.", true)]
		public static void SendFile(string remoteFilePath, byte[] data)
		{
		}
	}
}
