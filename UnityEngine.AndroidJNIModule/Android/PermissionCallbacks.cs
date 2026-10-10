using System;
using System.Diagnostics;

namespace UnityEngine.Android
{
	// Token: 0x0200001D RID: 29
	public class PermissionCallbacks : AndroidJavaProxy
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001C1 RID: 449 RVA: 0x000085A8 File Offset: 0x000067A8
		// (remove) Token: 0x060001C2 RID: 450 RVA: 0x000085E0 File Offset: 0x000067E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<string> PermissionGranted;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001C3 RID: 451 RVA: 0x00008618 File Offset: 0x00006818
		// (remove) Token: 0x060001C4 RID: 452 RVA: 0x00008650 File Offset: 0x00006850
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<string> PermissionDenied;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001C5 RID: 453 RVA: 0x00008688 File Offset: 0x00006888
		// (remove) Token: 0x060001C6 RID: 454 RVA: 0x000086C0 File Offset: 0x000068C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<string> PermissionDeniedAndDontAskAgain;

		// Token: 0x060001C7 RID: 455 RVA: 0x000086F5 File Offset: 0x000068F5
		public PermissionCallbacks() : base("com.unity3d.player.IPermissionRequestCallbacks")
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00008704 File Offset: 0x00006904
		private void onPermissionGranted(string permissionName)
		{
			Action<string> permissionGranted = this.PermissionGranted;
			if (permissionGranted != null)
			{
				permissionGranted(permissionName);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000871A File Offset: 0x0000691A
		private void onPermissionDenied(string permissionName)
		{
			Action<string> permissionDenied = this.PermissionDenied;
			if (permissionDenied != null)
			{
				permissionDenied(permissionName);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00008730 File Offset: 0x00006930
		private void onPermissionDeniedAndDontAskAgain(string permissionName)
		{
			bool flag = this.PermissionDeniedAndDontAskAgain != null;
			if (flag)
			{
				this.PermissionDeniedAndDontAskAgain(permissionName);
			}
			else
			{
				Action<string> permissionDenied = this.PermissionDenied;
				if (permissionDenied != null)
				{
					permissionDenied(permissionName);
				}
			}
		}
	}
}
