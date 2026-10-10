using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020003F1 RID: 1009
	[UsedByNativeCode]
	internal struct CoreCameraValues : IEquatable<CoreCameraValues>
	{
		// Token: 0x06002241 RID: 8769 RVA: 0x00038C04 File Offset: 0x00036E04
		public bool Equals(CoreCameraValues other)
		{
			return this.filterMode == other.filterMode && this.cullingMask == other.cullingMask && this.instanceID == other.instanceID;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00038C44 File Offset: 0x00036E44
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is CoreCameraValues && this.Equals((CoreCameraValues)obj);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00038C7C File Offset: 0x00036E7C
		public override int GetHashCode()
		{
			int num = this.filterMode;
			num = (num * 397 ^ (int)this.cullingMask);
			return num * 397 ^ this.instanceID;
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00038CB8 File Offset: 0x00036EB8
		public static bool operator ==(CoreCameraValues left, CoreCameraValues right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00038CD4 File Offset: 0x00036ED4
		public static bool operator !=(CoreCameraValues left, CoreCameraValues right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000C7B RID: 3195
		private int filterMode;

		// Token: 0x04000C7C RID: 3196
		private uint cullingMask;

		// Token: 0x04000C7D RID: 3197
		private int instanceID;
	}
}
