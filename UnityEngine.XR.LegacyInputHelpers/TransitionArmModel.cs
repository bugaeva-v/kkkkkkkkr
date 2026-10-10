using System;
using System.Collections.Generic;
using UnityEngine.SpatialTracking;

namespace UnityEngine.XR.LegacyInputHelpers
{
	// Token: 0x02000007 RID: 7
	public class TransitionArmModel : ArmModel
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002F87 File Offset: 0x00001187
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002F8F File Offset: 0x0000118F
		public ArmModel currentArmModelComponent
		{
			get
			{
				return this.m_CurrentArmModelComponent;
			}
			set
			{
				this.m_CurrentArmModelComponent = value;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002F98 File Offset: 0x00001198
		public bool Queue(string key)
		{
			foreach (ArmModelTransition armModelTransition in this.m_ArmModelTransitions)
			{
				if (armModelTransition.transitionKeyName == key)
				{
					this.Queue(armModelTransition.armModel);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003008 File Offset: 0x00001208
		public void Queue(ArmModel newArmModel)
		{
			if (newArmModel == null)
			{
				return;
			}
			if (this.m_CurrentArmModelComponent == null)
			{
				this.m_CurrentArmModelComponent = newArmModel;
			}
			this.RemoveJustStartingTransitions();
			if (this.armModelBlendData.Count == 10)
			{
				this.RemoveOldestTransition();
			}
			TransitionArmModel.ArmModelBlendData item = default(TransitionArmModel.ArmModelBlendData);
			item.armModel = newArmModel;
			item.currentBlendAmount = 0f;
			this.armModelBlendData.Add(item);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003078 File Offset: 0x00001278
		private void RemoveJustStartingTransitions()
		{
			for (int i = 0; i < this.armModelBlendData.Count; i++)
			{
				if (this.armModelBlendData[i].currentBlendAmount < 0.035f)
				{
					this.armModelBlendData.RemoveAt(i);
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000030BF File Offset: 0x000012BF
		private void RemoveOldestTransition()
		{
			this.armModelBlendData.RemoveAt(0);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000030CD File Offset: 0x000012CD
		public override PoseDataFlags GetPoseFromProvider(out Pose output)
		{
			if (this.UpdateBlends())
			{
				output = base.finalPose;
				return PoseDataFlags.Position | PoseDataFlags.Rotation;
			}
			output = Pose.identity;
			return PoseDataFlags.NoData;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000030F4 File Offset: 0x000012F4
		private bool UpdateBlends()
		{
			if (this.currentArmModelComponent == null)
			{
				return false;
			}
			if (this.m_CurrentArmModelComponent.OnControllerInputUpdated())
			{
				this.m_NeckPosition = this.m_CurrentArmModelComponent.neckPosition;
				this.m_ElbowPosition = this.m_CurrentArmModelComponent.elbowPosition;
				this.m_WristPosition = this.m_CurrentArmModelComponent.wristPosition;
				this.m_ControllerPosition = this.m_CurrentArmModelComponent.controllerPosition;
				this.m_ElbowRotation = this.m_CurrentArmModelComponent.elbowRotation;
				this.m_WristRotation = this.m_CurrentArmModelComponent.wristRotation;
				this.m_ControllerRotation = this.m_CurrentArmModelComponent.controllerRotation;
				Vector3 vector;
				if (base.TryGetAngularVelocity(base.poseSource, out vector) && this.armModelBlendData.Count > 0)
				{
					float t = Mathf.Clamp((vector.magnitude - 0.2f) / 45f, 0f, 0.1f);
					for (int i = 0; i < this.armModelBlendData.Count; i++)
					{
						TransitionArmModel.ArmModelBlendData armModelBlendData = this.armModelBlendData[i];
						armModelBlendData.currentBlendAmount = Mathf.Lerp(armModelBlendData.currentBlendAmount, 1f, t);
						if (armModelBlendData.currentBlendAmount > 0.95f)
						{
							armModelBlendData.currentBlendAmount = 1f;
						}
						else
						{
							armModelBlendData.armModel.OnControllerInputUpdated();
							this.m_NeckPosition = Vector3.Slerp(base.neckPosition, armModelBlendData.armModel.neckPosition, armModelBlendData.currentBlendAmount);
							this.m_ElbowPosition = Vector3.Slerp(base.elbowPosition, armModelBlendData.armModel.elbowPosition, armModelBlendData.currentBlendAmount);
							this.m_WristPosition = Vector3.Slerp(base.wristPosition, armModelBlendData.armModel.wristPosition, armModelBlendData.currentBlendAmount);
							this.m_ControllerPosition = Vector3.Slerp(base.controllerPosition, armModelBlendData.armModel.controllerPosition, armModelBlendData.currentBlendAmount);
							this.m_ElbowRotation = Quaternion.Slerp(base.elbowRotation, armModelBlendData.armModel.elbowRotation, armModelBlendData.currentBlendAmount);
							this.m_WristRotation = Quaternion.Slerp(base.wristRotation, armModelBlendData.armModel.wristRotation, armModelBlendData.currentBlendAmount);
							this.m_ControllerRotation = Quaternion.Slerp(base.controllerRotation, armModelBlendData.armModel.controllerRotation, armModelBlendData.currentBlendAmount);
						}
						this.armModelBlendData[i] = armModelBlendData;
						if (armModelBlendData.currentBlendAmount >= 1f)
						{
							this.m_CurrentArmModelComponent = armModelBlendData.armModel;
							this.armModelBlendData.RemoveRange(0, i + 1);
						}
					}
				}
				else if (this.armModelBlendData.Count > 0)
				{
					Debug.LogErrorFormat(base.gameObject, "Unable to get angular acceleration for node", Array.Empty<object>());
					return false;
				}
				base.finalPose = new Pose(base.controllerPosition, base.controllerRotation);
				return true;
			}
			return false;
		}

		// Token: 0x04000039 RID: 57
		[SerializeField]
		private ArmModel m_CurrentArmModelComponent;

		// Token: 0x0400003A RID: 58
		[SerializeField]
		public List<ArmModelTransition> m_ArmModelTransitions = new List<ArmModelTransition>();

		// Token: 0x0400003B RID: 59
		private const int MAX_ACTIVE_TRANSITIONS = 10;

		// Token: 0x0400003C RID: 60
		private const float DROP_TRANSITION_THRESHOLD = 0.035f;

		// Token: 0x0400003D RID: 61
		private const float LERP_CLAMP_THRESHOLD = 0.95f;

		// Token: 0x0400003E RID: 62
		private const float MIN_ANGULAR_VELOCITY = 0.2f;

		// Token: 0x0400003F RID: 63
		private const float ANGULAR_VELOCITY_DIVISOR = 45f;

		// Token: 0x04000040 RID: 64
		internal List<TransitionArmModel.ArmModelBlendData> armModelBlendData = new List<TransitionArmModel.ArmModelBlendData>(10);

		// Token: 0x04000041 RID: 65
		private TransitionArmModel.ArmModelBlendData currentBlendingArmModel;

		// Token: 0x02000009 RID: 9
		internal struct ArmModelBlendData
		{
			// Token: 0x04000045 RID: 69
			public ArmModel armModel;

			// Token: 0x04000046 RID: 70
			public float currentBlendAmount;
		}
	}
}
