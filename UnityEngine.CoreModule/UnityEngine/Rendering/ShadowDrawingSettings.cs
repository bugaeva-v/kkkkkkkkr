using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000412 RID: 1042
	[UsedByNativeCode]
	public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings>
	{
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x0003C9C0 File Offset: 0x0003ABC0
		public CullingResults cullingResults
		{
			get
			{
				return this.m_CullingResults;
			}
			set
			{
				this.m_CullingResults = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x0003C9CC File Offset: 0x0003ABCC
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x0003C9E4 File Offset: 0x0003ABE4
		public int lightIndex
		{
			get
			{
				return this.m_LightIndex;
			}
			set
			{
				this.m_LightIndex = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x0003CA0B File Offset: 0x0003AC0B
		public bool useRenderingLayerMaskTest
		{
			get
			{
				return this.m_UseRenderingLayerMaskTest != 0;
			}
			set
			{
				this.m_UseRenderingLayerMaskTest = (value ? 1 : 0);
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x0003CA1C File Offset: 0x0003AC1C
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x0003CA34 File Offset: 0x0003AC34
		public ShadowSplitData splitData
		{
			get
			{
				return this.m_SplitData;
			}
			set
			{
				this.m_SplitData = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0003CA40 File Offset: 0x0003AC40
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x0003CA58 File Offset: 0x0003AC58
		public ShadowObjectsFilter objectsFilter
		{
			get
			{
				return this.m_ObjectsFilter;
			}
			set
			{
				this.m_ObjectsFilter = value;
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x0003CA62 File Offset: 0x0003AC62
		public ShadowDrawingSettings(CullingResults cullingResults, int lightIndex)
		{
			this.m_CullingResults = cullingResults;
			this.m_LightIndex = lightIndex;
			this.m_UseRenderingLayerMaskTest = 0;
			this.m_SplitData = default(ShadowSplitData);
			this.m_SplitData.shadowCascadeBlendCullingFactor = 1f;
			this.m_ObjectsFilter = ShadowObjectsFilter.AllObjects;
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0003CAA0 File Offset: 0x0003ACA0
		public bool Equals(ShadowDrawingSettings other)
		{
			return this.m_CullingResults.Equals(other.m_CullingResults) && this.m_LightIndex == other.m_LightIndex && this.m_SplitData.Equals(other.m_SplitData) && this.m_UseRenderingLayerMaskTest.Equals(other.m_UseRenderingLayerMaskTest) && this.m_ObjectsFilter.Equals(other.m_ObjectsFilter);
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0003CB18 File Offset: 0x0003AD18
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is ShadowDrawingSettings && this.Equals((ShadowDrawingSettings)obj);
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0003CB50 File Offset: 0x0003AD50
		public override int GetHashCode()
		{
			int num = this.m_CullingResults.GetHashCode();
			num = (num * 397 ^ this.m_LightIndex);
			num = (num * 397 ^ this.m_UseRenderingLayerMaskTest);
			num = (num * 397 ^ this.m_SplitData.GetHashCode());
			return num * 397 ^ (int)this.m_ObjectsFilter;
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0003CBC0 File Offset: 0x0003ADC0
		public static bool operator ==(ShadowDrawingSettings left, ShadowDrawingSettings right)
		{
			return left.Equals(right);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0003CBDC File Offset: 0x0003ADDC
		public static bool operator !=(ShadowDrawingSettings left, ShadowDrawingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000D3C RID: 3388
		private CullingResults m_CullingResults;

		// Token: 0x04000D3D RID: 3389
		private int m_LightIndex;

		// Token: 0x04000D3E RID: 3390
		private int m_UseRenderingLayerMaskTest;

		// Token: 0x04000D3F RID: 3391
		private ShadowSplitData m_SplitData;

		// Token: 0x04000D40 RID: 3392
		private ShadowObjectsFilter m_ObjectsFilter;
	}
}
