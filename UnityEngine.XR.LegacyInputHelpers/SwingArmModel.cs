using System;

namespace UnityEngine.XR.LegacyInputHelpers
{
	// Token: 0x02000005 RID: 5
	public class SwingArmModel : ArmModel
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002D4B File Offset: 0x00000F4B
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002D53 File Offset: 0x00000F53
		public float shoulderRotationRatio
		{
			get
			{
				return this.m_ShoulderRotationRatio;
			}
			set
			{
				this.m_ShoulderRotationRatio = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002D5C File Offset: 0x00000F5C
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002D64 File Offset: 0x00000F64
		public float elbowRotationRatio
		{
			get
			{
				return this.m_ElbowRotationRatio;
			}
			set
			{
				this.m_ElbowRotationRatio = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002D6D File Offset: 0x00000F6D
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002D75 File Offset: 0x00000F75
		public float wristRotationRatio
		{
			get
			{
				return this.m_WristRotationRatio;
			}
			set
			{
				this.m_WristRotationRatio = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002D7E File Offset: 0x00000F7E
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002D8B File Offset: 0x00000F8B
		public float minJointShiftAngle
		{
			get
			{
				return this.m_JointShiftAngle.x;
			}
			set
			{
				this.m_JointShiftAngle.x = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002D99 File Offset: 0x00000F99
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002DA6 File Offset: 0x00000FA6
		public float maxJointShiftAngle
		{
			get
			{
				return this.m_JointShiftAngle.y;
			}
			set
			{
				this.m_JointShiftAngle.y = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002DB4 File Offset: 0x00000FB4
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002DBC File Offset: 0x00000FBC
		public float jointShiftExponent
		{
			get
			{
				return this.m_JointShiftExponent;
			}
			set
			{
				this.m_JointShiftExponent = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002DC5 File Offset: 0x00000FC5
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002DCD File Offset: 0x00000FCD
		public float shiftedShoulderRotationRatio
		{
			get
			{
				return this.m_ShiftedShoulderRotationRatio;
			}
			set
			{
				this.m_ShiftedShoulderRotationRatio = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002DD6 File Offset: 0x00000FD6
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002DDE File Offset: 0x00000FDE
		public float shiftedElbowRotationRatio
		{
			get
			{
				return this.m_ShiftedElbowRotationRatio;
			}
			set
			{
				this.m_ShiftedElbowRotationRatio = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002DE7 File Offset: 0x00000FE7
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002DEF File Offset: 0x00000FEF
		public float shiftedWristRotationRatio
		{
			get
			{
				return this.m_ShiftedWristRotationRatio;
			}
			set
			{
				this.m_ShiftedWristRotationRatio = value;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002DF8 File Offset: 0x00000FF8
		protected override void CalculateFinalJointRotations(Quaternion controllerOrientation, Quaternion xyRotation, Quaternion lerpRotation)
		{
			float num = Quaternion.Angle(xyRotation, Quaternion.identity);
			float num2 = this.maxJointShiftAngle - this.minJointShiftAngle;
			float t = Mathf.Pow(Mathf.Clamp01((num - this.minJointShiftAngle) / num2), this.m_JointShiftExponent);
			float t2 = Mathf.Lerp(this.m_ShoulderRotationRatio, this.m_ShiftedShoulderRotationRatio, t);
			float t3 = Mathf.Lerp(this.m_ElbowRotationRatio, this.m_ShiftedElbowRotationRatio, t);
			float t4 = Mathf.Lerp(this.m_WristRotationRatio, this.m_ShiftedWristRotationRatio, t);
			Quaternion rhs = Quaternion.Lerp(Quaternion.identity, xyRotation, t2);
			Quaternion rhs2 = Quaternion.Lerp(Quaternion.identity, xyRotation, t3);
			Quaternion rhs3 = Quaternion.Lerp(Quaternion.identity, xyRotation, t4);
			Quaternion quaternion = this.m_TorsoRotation * rhs;
			this.m_ElbowRotation = quaternion * rhs2;
			this.m_WristRotation = base.elbowRotation * rhs3;
			this.m_ControllerRotation = this.m_TorsoRotation * controllerOrientation;
			this.m_TorsoRotation = quaternion;
		}

		// Token: 0x0400002F RID: 47
		[Tooltip("Portion of controller rotation applied to the shoulder joint.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_ShoulderRotationRatio = 0.5f;

		// Token: 0x04000030 RID: 48
		[Tooltip("Portion of controller rotation applied to the elbow joint.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ElbowRotationRatio = 0.3f;

		// Token: 0x04000031 RID: 49
		[Tooltip("Portion of controller rotation applied to the wrist joint.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_WristRotationRatio = 0.2f;

		// Token: 0x04000032 RID: 50
		[SerializeField]
		private Vector2 m_JointShiftAngle = new Vector2(160f, 180f);

		// Token: 0x04000033 RID: 51
		[Tooltip("Exponent applied to the joint shift ratio to control the curve of the shift.")]
		[Range(1f, 20f)]
		[SerializeField]
		private float m_JointShiftExponent = 6f;

		// Token: 0x04000034 RID: 52
		[Tooltip("Portion of controller rotation applied to the shoulder joint when the controller is backwards.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ShiftedShoulderRotationRatio = 0.1f;

		// Token: 0x04000035 RID: 53
		[Tooltip("Portion of controller rotation applied to the elbow joint when the controller is backwards.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ShiftedElbowRotationRatio = 0.4f;

		// Token: 0x04000036 RID: 54
		[Tooltip("Portion of controller rotation applied to the wrist joint when the controller is backwards.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_ShiftedWristRotationRatio = 0.5f;
	}
}
