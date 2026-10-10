using System;
using System.Collections.Generic;
using UnityEngine.XR;

namespace UnityEngine.SpatialTracking
{
	// Token: 0x02000004 RID: 4
	public static class PoseDataSource
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002178 File Offset: 0x00000378
		internal static PoseDataFlags GetNodePoseData(XRNode node, out Pose resultPose)
		{
			PoseDataFlags poseDataFlags = PoseDataFlags.NoData;
			InputTracking.GetNodeStates(PoseDataSource.nodeStates);
			foreach (XRNodeState xrnodeState in PoseDataSource.nodeStates)
			{
				if (xrnodeState.nodeType == node)
				{
					if (xrnodeState.TryGetPosition(out resultPose.position))
					{
						poseDataFlags |= PoseDataFlags.Position;
					}
					if (xrnodeState.TryGetRotation(out resultPose.rotation))
					{
						poseDataFlags |= PoseDataFlags.Rotation;
					}
					return poseDataFlags;
				}
			}
			resultPose = Pose.identity;
			return poseDataFlags;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002214 File Offset: 0x00000414
		public static bool TryGetDataFromSource(TrackedPoseDriver.TrackedPose poseSource, out Pose resultPose)
		{
			return PoseDataSource.GetDataFromSource(poseSource, out resultPose) == (PoseDataFlags.Position | PoseDataFlags.Rotation);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002220 File Offset: 0x00000420
		public static PoseDataFlags GetDataFromSource(TrackedPoseDriver.TrackedPose poseSource, out Pose resultPose)
		{
			switch (poseSource)
			{
			case TrackedPoseDriver.TrackedPose.LeftEye:
				return PoseDataSource.GetNodePoseData(XRNode.LeftEye, out resultPose);
			case TrackedPoseDriver.TrackedPose.RightEye:
				return PoseDataSource.GetNodePoseData(XRNode.RightEye, out resultPose);
			case TrackedPoseDriver.TrackedPose.Center:
				return PoseDataSource.GetNodePoseData(XRNode.CenterEye, out resultPose);
			case TrackedPoseDriver.TrackedPose.Head:
				return PoseDataSource.GetNodePoseData(XRNode.Head, out resultPose);
			case TrackedPoseDriver.TrackedPose.LeftPose:
				return PoseDataSource.GetNodePoseData(XRNode.LeftHand, out resultPose);
			case TrackedPoseDriver.TrackedPose.RightPose:
				return PoseDataSource.GetNodePoseData(XRNode.RightHand, out resultPose);
			case TrackedPoseDriver.TrackedPose.ColorCamera:
				return PoseDataSource.GetNodePoseData(XRNode.CenterEye, out resultPose);
			case TrackedPoseDriver.TrackedPose.RemotePose:
			{
				PoseDataFlags nodePoseData = PoseDataSource.GetNodePoseData(XRNode.RightHand, out resultPose);
				if (nodePoseData == PoseDataFlags.NoData)
				{
					return PoseDataSource.GetNodePoseData(XRNode.LeftHand, out resultPose);
				}
				return nodePoseData;
			}
			}
			Debug.LogWarningFormat("Unable to retrieve pose data for poseSource: {0}", new object[]
			{
				poseSource.ToString()
			});
			resultPose = Pose.identity;
			return PoseDataFlags.NoData;
		}

		// Token: 0x04000006 RID: 6
		internal static List<XRNodeState> nodeStates = new List<XRNodeState>();
	}
}
