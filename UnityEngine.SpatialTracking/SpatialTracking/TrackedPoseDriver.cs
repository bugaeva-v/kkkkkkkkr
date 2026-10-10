using System;
using UnityEngine.Experimental.XR.Interaction;

namespace UnityEngine.SpatialTracking
{
	// Token: 0x02000005 RID: 5
	[DefaultExecutionOrder(-30000)]
	[AddComponentMenu("XR/Tracked Pose Driver")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.legacyinputhelpers@2.1/manual/index.html")]
	[Serializable]
	public class TrackedPoseDriver : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022E6 File Offset: 0x000004E6
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000022EE File Offset: 0x000004EE
		public TrackedPoseDriver.DeviceType deviceType
		{
			get
			{
				return this.m_Device;
			}
			internal set
			{
				this.m_Device = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000022F7 File Offset: 0x000004F7
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000022FF File Offset: 0x000004FF
		public TrackedPoseDriver.TrackedPose poseSource
		{
			get
			{
				return this.m_PoseSource;
			}
			internal set
			{
				this.m_PoseSource = value;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002308 File Offset: 0x00000508
		public bool SetPoseSource(TrackedPoseDriver.DeviceType deviceType, TrackedPoseDriver.TrackedPose pose)
		{
			if (deviceType < (TrackedPoseDriver.DeviceType)TrackedPoseDriverDataDescription.DeviceData.Count)
			{
				TrackedPoseDriverDataDescription.PoseData poseData = TrackedPoseDriverDataDescription.DeviceData[(int)deviceType];
				for (int i = 0; i < poseData.Poses.Count; i++)
				{
					if (poseData.Poses[i] == pose)
					{
						this.deviceType = deviceType;
						this.poseSource = pose;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002364 File Offset: 0x00000564
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000236C File Offset: 0x0000056C
		public BasePoseProvider poseProviderComponent
		{
			get
			{
				return this.m_PoseProviderComponent;
			}
			set
			{
				this.m_PoseProviderComponent = value;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002375 File Offset: 0x00000575
		private PoseDataFlags GetPoseData(TrackedPoseDriver.DeviceType device, TrackedPoseDriver.TrackedPose poseSource, out Pose resultPose)
		{
			if (!(this.m_PoseProviderComponent != null))
			{
				return PoseDataSource.GetDataFromSource(poseSource, out resultPose);
			}
			return this.m_PoseProviderComponent.GetPoseFromProvider(out resultPose);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002399 File Offset: 0x00000599
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000023A1 File Offset: 0x000005A1
		public TrackedPoseDriver.TrackingType trackingType
		{
			get
			{
				return this.m_TrackingType;
			}
			set
			{
				this.m_TrackingType = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000023AA File Offset: 0x000005AA
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000023B2 File Offset: 0x000005B2
		public TrackedPoseDriver.UpdateType updateType
		{
			get
			{
				return this.m_UpdateType;
			}
			set
			{
				this.m_UpdateType = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000023BB File Offset: 0x000005BB
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000023C3 File Offset: 0x000005C3
		public bool UseRelativeTransform
		{
			get
			{
				return this.m_UseRelativeTransform;
			}
			set
			{
				this.m_UseRelativeTransform = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000023CC File Offset: 0x000005CC
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000023D4 File Offset: 0x000005D4
		public Pose originPose
		{
			get
			{
				return this.m_OriginPose;
			}
			set
			{
				this.m_OriginPose = value;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023DD File Offset: 0x000005DD
		private void CacheLocalPosition()
		{
			this.m_OriginPose.position = base.transform.localPosition;
			this.m_OriginPose.rotation = base.transform.localRotation;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000240B File Offset: 0x0000060B
		private void ResetToCachedLocalPosition()
		{
			this.SetLocalTransform(this.m_OriginPose.position, this.m_OriginPose.rotation, PoseDataFlags.Position | PoseDataFlags.Rotation);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000242A File Offset: 0x0000062A
		protected virtual void Awake()
		{
			this.CacheLocalPosition();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002432 File Offset: 0x00000632
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002434 File Offset: 0x00000634
		protected virtual void OnEnable()
		{
			Application.onBeforeRender += this.OnBeforeRender;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002448 File Offset: 0x00000648
		protected virtual void OnDisable()
		{
			this.ResetToCachedLocalPosition();
			Application.onBeforeRender -= this.OnBeforeRender;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002462 File Offset: 0x00000662
		protected virtual void FixedUpdate()
		{
			if (this.m_UpdateType == TrackedPoseDriver.UpdateType.Update || this.m_UpdateType == TrackedPoseDriver.UpdateType.UpdateAndBeforeRender)
			{
				this.PerformUpdate();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000247B File Offset: 0x0000067B
		protected virtual void Update()
		{
			if (this.m_UpdateType == TrackedPoseDriver.UpdateType.Update || this.m_UpdateType == TrackedPoseDriver.UpdateType.UpdateAndBeforeRender)
			{
				this.PerformUpdate();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002494 File Offset: 0x00000694
		[BeforeRenderOrder(-30000)]
		protected virtual void OnBeforeRender()
		{
			if (this.m_UpdateType == TrackedPoseDriver.UpdateType.BeforeRender || this.m_UpdateType == TrackedPoseDriver.UpdateType.UpdateAndBeforeRender)
			{
				this.PerformUpdate();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000024B0 File Offset: 0x000006B0
		protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation, PoseDataFlags poseFlags)
		{
			if ((this.m_TrackingType == TrackedPoseDriver.TrackingType.RotationAndPosition || this.m_TrackingType == TrackedPoseDriver.TrackingType.RotationOnly) && (poseFlags & PoseDataFlags.Rotation) > PoseDataFlags.NoData)
			{
				base.transform.localRotation = newRotation;
			}
			if ((this.m_TrackingType == TrackedPoseDriver.TrackingType.RotationAndPosition || this.m_TrackingType == TrackedPoseDriver.TrackingType.PositionOnly) && (poseFlags & PoseDataFlags.Position) > PoseDataFlags.NoData)
			{
				base.transform.localPosition = newPosition;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002503 File Offset: 0x00000703
		protected Pose TransformPoseByOriginIfNeeded(Pose pose)
		{
			if (this.m_UseRelativeTransform)
			{
				return pose.GetTransformedBy(this.m_OriginPose);
			}
			return pose;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000251C File Offset: 0x0000071C
		private bool HasStereoCamera()
		{
			Camera component = base.GetComponent<Camera>();
			return component != null && component.stereoEnabled;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002544 File Offset: 0x00000744
		protected virtual void PerformUpdate()
		{
			if (!base.enabled)
			{
				return;
			}
			Pose pose;
			PoseDataFlags poseData = this.GetPoseData(this.m_Device, this.m_PoseSource, out pose);
			if (poseData != PoseDataFlags.NoData)
			{
				Pose pose2 = this.TransformPoseByOriginIfNeeded(pose);
				this.SetLocalTransform(pose2.position, pose2.rotation, poseData);
			}
		}

		// Token: 0x04000007 RID: 7
		[SerializeField]
		private TrackedPoseDriver.DeviceType m_Device;

		// Token: 0x04000008 RID: 8
		[SerializeField]
		private TrackedPoseDriver.TrackedPose m_PoseSource = TrackedPoseDriver.TrackedPose.Center;

		// Token: 0x04000009 RID: 9
		[SerializeField]
		private BasePoseProvider m_PoseProviderComponent;

		// Token: 0x0400000A RID: 10
		[SerializeField]
		private TrackedPoseDriver.TrackingType m_TrackingType;

		// Token: 0x0400000B RID: 11
		[SerializeField]
		private TrackedPoseDriver.UpdateType m_UpdateType;

		// Token: 0x0400000C RID: 12
		[SerializeField]
		private bool m_UseRelativeTransform;

		// Token: 0x0400000D RID: 13
		protected Pose m_OriginPose;

		// Token: 0x02000008 RID: 8
		public enum DeviceType
		{
			// Token: 0x04000011 RID: 17
			GenericXRDevice,
			// Token: 0x04000012 RID: 18
			GenericXRController,
			// Token: 0x04000013 RID: 19
			GenericXRRemote
		}

		// Token: 0x02000009 RID: 9
		public enum TrackedPose
		{
			// Token: 0x04000015 RID: 21
			LeftEye,
			// Token: 0x04000016 RID: 22
			RightEye,
			// Token: 0x04000017 RID: 23
			Center,
			// Token: 0x04000018 RID: 24
			Head,
			// Token: 0x04000019 RID: 25
			LeftPose,
			// Token: 0x0400001A RID: 26
			RightPose,
			// Token: 0x0400001B RID: 27
			ColorCamera,
			// Token: 0x0400001C RID: 28
			DepthCameraDeprecated,
			// Token: 0x0400001D RID: 29
			FisheyeCameraDeprected,
			// Token: 0x0400001E RID: 30
			DeviceDeprecated,
			// Token: 0x0400001F RID: 31
			RemotePose
		}

		// Token: 0x0200000A RID: 10
		public enum TrackingType
		{
			// Token: 0x04000021 RID: 33
			RotationAndPosition,
			// Token: 0x04000022 RID: 34
			RotationOnly,
			// Token: 0x04000023 RID: 35
			PositionOnly
		}

		// Token: 0x0200000B RID: 11
		public enum UpdateType
		{
			// Token: 0x04000025 RID: 37
			UpdateAndBeforeRender,
			// Token: 0x04000026 RID: 38
			Update,
			// Token: 0x04000027 RID: 39
			BeforeRender
		}
	}
}
