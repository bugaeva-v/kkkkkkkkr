using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace UnityEditor.XR.LegacyInputHelpers
{
	// Token: 0x02000003 RID: 3
	[AddComponentMenu("XR/Camera Offset")]
	public class CameraOffset : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public GameObject cameraFloorOffsetObject
		{
			get
			{
				return this.m_CameraFloorOffsetObject;
			}
			set
			{
				this.m_CameraFloorOffsetObject = value;
				this.UpdateTrackingOrigin(this.m_TrackingOriginMode);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000206D File Offset: 0x0000026D
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002075 File Offset: 0x00000275
		public UserRequestedTrackingMode requestedTrackingMode
		{
			get
			{
				return this.m_RequestedTrackingMode;
			}
			set
			{
				this.m_RequestedTrackingMode = value;
				this.TryInitializeCamera();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002084 File Offset: 0x00000284
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000208C File Offset: 0x0000028C
		public TrackingOriginModeFlags TrackingOriginMode
		{
			get
			{
				return this.m_TrackingOriginMode;
			}
			set
			{
				this.m_TrackingOriginMode = value;
				this.TryInitializeCamera();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000209B File Offset: 0x0000029B
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020A3 File Offset: 0x000002A3
		[Obsolete("CameraOffset.trackingSpace is obsolete.  Please use CameraOffset.trackingOriginMode.")]
		public TrackingSpaceType trackingSpace
		{
			get
			{
				return this.m_TrackingSpace;
			}
			set
			{
				this.m_TrackingSpace = value;
				this.TryInitializeCamera();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020BA File Offset: 0x000002BA
		public float cameraYOffset
		{
			get
			{
				return this.m_CameraYOffset;
			}
			set
			{
				this.m_CameraYOffset = value;
				this.UpdateTrackingOrigin(this.m_TrackingOriginMode);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020D0 File Offset: 0x000002D0
		private void UpgradeTrackingSpaceToTrackingOriginMode()
		{
			if (this.m_TrackingOriginMode == TrackingOriginModeFlags.Unknown && this.m_TrackingSpace <= TrackingSpaceType.RoomScale)
			{
				TrackingSpaceType trackingSpace = this.m_TrackingSpace;
				if (trackingSpace != TrackingSpaceType.Stationary)
				{
					if (trackingSpace == TrackingSpaceType.RoomScale)
					{
						this.m_TrackingOriginMode = TrackingOriginModeFlags.Floor;
					}
				}
				else
				{
					this.m_TrackingOriginMode = TrackingOriginModeFlags.Device;
				}
				this.m_TrackingSpace = (TrackingSpaceType)3;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002113 File Offset: 0x00000313
		private void Awake()
		{
			if (!this.m_CameraFloorOffsetObject)
			{
				Debug.LogWarning("No camera container specified for XR Rig, using attached GameObject");
				this.m_CameraFloorOffsetObject = base.gameObject;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002138 File Offset: 0x00000338
		private void Start()
		{
			this.TryInitializeCamera();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002140 File Offset: 0x00000340
		private void OnValidate()
		{
			this.UpgradeTrackingSpaceToTrackingOriginMode();
			this.TryInitializeCamera();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000214E File Offset: 0x0000034E
		private void TryInitializeCamera()
		{
			this.m_CameraInitialized = this.SetupCamera();
			if (!this.m_CameraInitialized & !this.m_CameraInitializing)
			{
				base.StartCoroutine(this.RepeatInitializeCamera());
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000217E File Offset: 0x0000037E
		private IEnumerator RepeatInitializeCamera()
		{
			this.m_CameraInitializing = true;
			yield return null;
			while (!this.m_CameraInitialized)
			{
				this.m_CameraInitialized = this.SetupCamera();
				yield return null;
			}
			this.m_CameraInitializing = false;
			yield break;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002190 File Offset: 0x00000390
		private bool SetupCamera()
		{
			SubsystemManager.GetInstances<XRInputSubsystem>(CameraOffset.s_InputSubsystems);
			bool flag = true;
			if (CameraOffset.s_InputSubsystems.Count != 0)
			{
				for (int i = 0; i < CameraOffset.s_InputSubsystems.Count; i++)
				{
					bool flag2 = this.SetupCamera(CameraOffset.s_InputSubsystems[i]);
					if (flag2)
					{
						CameraOffset.s_InputSubsystems[i].trackingOriginUpdated -= this.OnTrackingOriginUpdated;
						CameraOffset.s_InputSubsystems[i].trackingOriginUpdated += this.OnTrackingOriginUpdated;
					}
					flag = (flag && flag2);
				}
			}
			else if (this.m_RequestedTrackingMode == UserRequestedTrackingMode.Floor)
			{
				this.SetupCameraLegacy(TrackingSpaceType.RoomScale);
			}
			else
			{
				this.SetupCameraLegacy(TrackingSpaceType.Stationary);
			}
			return flag;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002238 File Offset: 0x00000438
		private bool SetupCamera(XRInputSubsystem subsystem)
		{
			if (subsystem == null)
			{
				return false;
			}
			bool flag = false;
			TrackingOriginModeFlags trackingOriginMode = subsystem.GetTrackingOriginMode();
			TrackingOriginModeFlags supportedTrackingOriginModes = subsystem.GetSupportedTrackingOriginModes();
			TrackingOriginModeFlags trackingOriginModeFlags = TrackingOriginModeFlags.Unknown;
			if (this.m_RequestedTrackingMode == UserRequestedTrackingMode.Default)
			{
				trackingOriginModeFlags = trackingOriginMode;
			}
			else if (this.m_RequestedTrackingMode == UserRequestedTrackingMode.Device)
			{
				trackingOriginModeFlags = TrackingOriginModeFlags.Device;
			}
			else if (this.m_RequestedTrackingMode == UserRequestedTrackingMode.Floor)
			{
				trackingOriginModeFlags = TrackingOriginModeFlags.Floor;
			}
			else
			{
				Debug.LogWarning("Unknown Requested Tracking Mode");
			}
			if (trackingOriginModeFlags == TrackingOriginModeFlags.Floor)
			{
				if ((supportedTrackingOriginModes & TrackingOriginModeFlags.Floor) == TrackingOriginModeFlags.Unknown)
				{
					Debug.LogWarning("CameraOffset.SetupCamera: Attempting to set the tracking space to Floor, but that is not supported by the SDK.");
				}
				else
				{
					flag = subsystem.TrySetTrackingOriginMode(trackingOriginModeFlags);
				}
			}
			else if (trackingOriginModeFlags == TrackingOriginModeFlags.Device)
			{
				if ((supportedTrackingOriginModes & TrackingOriginModeFlags.Device) == TrackingOriginModeFlags.Unknown)
				{
					Debug.LogWarning("CameraOffset.SetupCamera: Attempting to set the tracking space to Device, but that is not supported by the SDK.");
				}
				else
				{
					flag = (subsystem.TrySetTrackingOriginMode(trackingOriginModeFlags) && subsystem.TryRecenter());
				}
			}
			if (flag)
			{
				this.UpdateTrackingOrigin(subsystem.GetTrackingOriginMode());
			}
			return flag;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022E4 File Offset: 0x000004E4
		private void UpdateTrackingOrigin(TrackingOriginModeFlags trackingOriginModeFlags)
		{
			this.m_TrackingOriginMode = trackingOriginModeFlags;
			if (this.m_CameraFloorOffsetObject != null)
			{
				this.m_CameraFloorOffsetObject.transform.localPosition = new Vector3(this.m_CameraFloorOffsetObject.transform.localPosition.x, (this.m_TrackingOriginMode == TrackingOriginModeFlags.Device) ? this.cameraYOffset : 0f, this.m_CameraFloorOffsetObject.transform.localPosition.z);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000235B File Offset: 0x0000055B
		private void OnTrackingOriginUpdated(XRInputSubsystem subsystem)
		{
			this.UpdateTrackingOrigin(subsystem.GetTrackingOriginMode());
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000236C File Offset: 0x0000056C
		private void OnDestroy()
		{
			SubsystemManager.GetInstances<XRInputSubsystem>(CameraOffset.s_InputSubsystems);
			foreach (XRInputSubsystem xrinputSubsystem in CameraOffset.s_InputSubsystems)
			{
				xrinputSubsystem.trackingOriginUpdated -= this.OnTrackingOriginUpdated;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023D4 File Offset: 0x000005D4
		private void SetupCameraLegacy(TrackingSpaceType trackingSpace)
		{
			float y = this.m_CameraYOffset;
			XRDevice.SetTrackingSpaceType(trackingSpace);
			if (trackingSpace == TrackingSpaceType.Stationary)
			{
				InputTracking.Recenter();
			}
			else if (trackingSpace == TrackingSpaceType.RoomScale)
			{
				y = 0f;
			}
			this.m_TrackingSpace = trackingSpace;
			if (this.m_CameraFloorOffsetObject)
			{
				this.m_CameraFloorOffsetObject.transform.localPosition = new Vector3(this.m_CameraFloorOffsetObject.transform.localPosition.x, y, this.m_CameraFloorOffsetObject.transform.localPosition.z);
			}
		}

		// Token: 0x04000005 RID: 5
		private const float k_DefaultCameraYOffset = 1.36144f;

		// Token: 0x04000006 RID: 6
		[SerializeField]
		[Tooltip("GameObject to move to desired height off the floor (defaults to this object if none provided).")]
		private GameObject m_CameraFloorOffsetObject;

		// Token: 0x04000007 RID: 7
		[SerializeField]
		[Tooltip("What the user wants the tracking origin mode to be")]
		private UserRequestedTrackingMode m_RequestedTrackingMode;

		// Token: 0x04000008 RID: 8
		[SerializeField]
		[Tooltip("Sets the type of tracking origin to use for this Rig. Tracking origins identify where 0,0,0 is in the world of tracking.")]
		private TrackingOriginModeFlags m_TrackingOriginMode;

		// Token: 0x04000009 RID: 9
		[SerializeField]
		[Tooltip("Set if the XR experience is Room Scale or Stationary.")]
		private TrackingSpaceType m_TrackingSpace;

		// Token: 0x0400000A RID: 10
		[SerializeField]
		[Tooltip("Camera Height to be used when in Device tracking space.")]
		private float m_CameraYOffset = 1.36144f;

		// Token: 0x0400000B RID: 11
		private bool m_CameraInitialized;

		// Token: 0x0400000C RID: 12
		private bool m_CameraInitializing;

		// Token: 0x0400000D RID: 13
		private static List<XRInputSubsystem> s_InputSubsystems = new List<XRInputSubsystem>();
	}
}
