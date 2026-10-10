using System;
using UnityEngine.SpatialTracking;

namespace UnityEngine.Experimental.XR.Interaction
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public abstract class BasePoseProvider : MonoBehaviour
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0000259C File Offset: 0x0000079C
		public virtual PoseDataFlags GetPoseFromProvider(out Pose output)
		{
			if (this.TryGetPoseFromProvider(out output))
			{
				return PoseDataFlags.Position | PoseDataFlags.Rotation;
			}
			return PoseDataFlags.NoData;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000025AA File Offset: 0x000007AA
		[Obsolete("This function is provided for backwards compatibility with the BasePoseProvider found in com.unity.xr.legacyinputhelpers v1.3.X. Please do not implement this function, instead use the new API via GetPoseFromProvider", false)]
		public virtual bool TryGetPoseFromProvider(out Pose output)
		{
			output = Pose.identity;
			return false;
		}
	}
}
