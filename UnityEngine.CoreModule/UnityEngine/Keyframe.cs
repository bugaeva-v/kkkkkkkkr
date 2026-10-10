using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E2 RID: 226
	[RequiredByNativeCode]
	public struct Keyframe
	{
		// Token: 0x0600038A RID: 906 RVA: 0x00005F64 File Offset: 0x00004164
		public Keyframe(float time, float value)
		{
			this.m_Time = time;
			this.m_Value = value;
			this.m_InTangent = 0f;
			this.m_OutTangent = 0f;
			this.m_WeightedMode = 0;
			this.m_InWeight = 0f;
			this.m_OutWeight = 0f;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00005FB3 File Offset: 0x000041B3
		public Keyframe(float time, float value, float inTangent, float outTangent)
		{
			this.m_Time = time;
			this.m_Value = value;
			this.m_InTangent = inTangent;
			this.m_OutTangent = outTangent;
			this.m_WeightedMode = 0;
			this.m_InWeight = 0f;
			this.m_OutWeight = 0f;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00005FF0 File Offset: 0x000041F0
		public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight)
		{
			this.m_Time = time;
			this.m_Value = value;
			this.m_InTangent = inTangent;
			this.m_OutTangent = outTangent;
			this.m_WeightedMode = 3;
			this.m_InWeight = inWeight;
			this.m_OutWeight = outWeight;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00006028 File Offset: 0x00004228
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00006040 File Offset: 0x00004240
		public float time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000604C File Offset: 0x0000424C
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00006064 File Offset: 0x00004264
		public float value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00006070 File Offset: 0x00004270
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00006088 File Offset: 0x00004288
		public float inTangent
		{
			get
			{
				return this.m_InTangent;
			}
			set
			{
				this.m_InTangent = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00006094 File Offset: 0x00004294
		// (set) Token: 0x06000394 RID: 916 RVA: 0x000060AC File Offset: 0x000042AC
		public float outTangent
		{
			get
			{
				return this.m_OutTangent;
			}
			set
			{
				this.m_OutTangent = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000060B8 File Offset: 0x000042B8
		// (set) Token: 0x06000396 RID: 918 RVA: 0x000060D0 File Offset: 0x000042D0
		public float inWeight
		{
			get
			{
				return this.m_InWeight;
			}
			set
			{
				this.m_InWeight = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000397 RID: 919 RVA: 0x000060DC File Offset: 0x000042DC
		// (set) Token: 0x06000398 RID: 920 RVA: 0x000060F4 File Offset: 0x000042F4
		public float outWeight
		{
			get
			{
				return this.m_OutWeight;
			}
			set
			{
				this.m_OutWeight = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00006100 File Offset: 0x00004300
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00006118 File Offset: 0x00004318
		public WeightedMode weightedMode
		{
			get
			{
				return (WeightedMode)this.m_WeightedMode;
			}
			set
			{
				this.m_WeightedMode = (int)value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00006124 File Offset: 0x00004324
		// (set) Token: 0x0600039C RID: 924 RVA: 0x0000613C File Offset: 0x0000433C
		[Obsolete("Use AnimationUtility.SetKeyLeftTangentMode, AnimationUtility.SetKeyRightTangentMode, AnimationUtility.GetKeyLeftTangentMode or AnimationUtility.GetKeyRightTangentMode instead.")]
		public int tangentMode
		{
			get
			{
				return this.tangentModeInternal;
			}
			set
			{
				this.tangentModeInternal = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00006148 File Offset: 0x00004348
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00004563 File Offset: 0x00002763
		internal int tangentModeInternal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x040002E9 RID: 745
		private float m_Time;

		// Token: 0x040002EA RID: 746
		private float m_Value;

		// Token: 0x040002EB RID: 747
		private float m_InTangent;

		// Token: 0x040002EC RID: 748
		private float m_OutTangent;

		// Token: 0x040002ED RID: 749
		private int m_WeightedMode;

		// Token: 0x040002EE RID: 750
		private float m_InWeight;

		// Token: 0x040002EF RID: 751
		private float m_OutWeight;
	}
}
