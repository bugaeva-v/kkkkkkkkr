using System;

namespace UnityEngine
{
	// Token: 0x020001A2 RID: 418
	public struct CombineInstance
	{
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x000160A4 File Offset: 0x000142A4
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x000160C1 File Offset: 0x000142C1
		public Mesh mesh
		{
			get
			{
				return Mesh.FromInstanceID(this.m_MeshInstanceID);
			}
			set
			{
				this.m_MeshInstanceID = ((value != null) ? value.GetInstanceID() : 0);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x000160DC File Offset: 0x000142DC
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x000160F4 File Offset: 0x000142F4
		public int subMeshIndex
		{
			get
			{
				return this.m_SubMeshIndex;
			}
			set
			{
				this.m_SubMeshIndex = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00016100 File Offset: 0x00014300
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00016118 File Offset: 0x00014318
		public Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			set
			{
				this.m_Transform = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00016124 File Offset: 0x00014324
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x0001613C File Offset: 0x0001433C
		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.m_LightmapScaleOffset;
			}
			set
			{
				this.m_LightmapScaleOffset = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00016148 File Offset: 0x00014348
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x00016160 File Offset: 0x00014360
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.m_RealtimeLightmapScaleOffset;
			}
			set
			{
				this.m_RealtimeLightmapScaleOffset = value;
			}
		}

		// Token: 0x040005B9 RID: 1465
		private int m_MeshInstanceID;

		// Token: 0x040005BA RID: 1466
		private int m_SubMeshIndex;

		// Token: 0x040005BB RID: 1467
		private Matrix4x4 m_Transform;

		// Token: 0x040005BC RID: 1468
		private Vector4 m_LightmapScaleOffset;

		// Token: 0x040005BD RID: 1469
		private Vector4 m_RealtimeLightmapScaleOffset;
	}
}
