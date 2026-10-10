using System;
using UnityEngine.Internal;

namespace UnityEngine.Rendering
{
	// Token: 0x02000400 RID: 1024
	public struct FilteringSettings : IEquatable<FilteringSettings>
	{
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0003A8C6 File Offset: 0x00038AC6
		public static FilteringSettings defaultValue
		{
			get
			{
				return new FilteringSettings(new RenderQueueRange?(RenderQueueRange.all), -1, uint.MaxValue, 0);
			}
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0003A8DC File Offset: 0x00038ADC
		public FilteringSettings([DefaultValue("RenderQueueRange.all")] RenderQueueRange? renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = 4294967295U, int excludeMotionVectorObjects = 0)
		{
			this = default(FilteringSettings);
			this.m_RenderQueueRange = (renderQueueRange ?? RenderQueueRange.all);
			this.m_LayerMask = layerMask;
			this.m_RenderingLayerMask = renderingLayerMask;
			this.m_ExcludeMotionVectorObjects = excludeMotionVectorObjects;
			this.m_SortingLayerRange = SortingLayerRange.all;
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x0003A934 File Offset: 0x00038B34
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x0003A94C File Offset: 0x00038B4C
		public RenderQueueRange renderQueueRange
		{
			get
			{
				return this.m_RenderQueueRange;
			}
			set
			{
				this.m_RenderQueueRange = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x0003A958 File Offset: 0x00038B58
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x0003A970 File Offset: 0x00038B70
		public int layerMask
		{
			get
			{
				return this.m_LayerMask;
			}
			set
			{
				this.m_LayerMask = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x0003A97C File Offset: 0x00038B7C
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x0003A994 File Offset: 0x00038B94
		public uint renderingLayerMask
		{
			get
			{
				return this.m_RenderingLayerMask;
			}
			set
			{
				this.m_RenderingLayerMask = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x0003A9A0 File Offset: 0x00038BA0
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x0003A9BB File Offset: 0x00038BBB
		public bool excludeMotionVectorObjects
		{
			get
			{
				return this.m_ExcludeMotionVectorObjects != 0;
			}
			set
			{
				this.m_ExcludeMotionVectorObjects = (value ? 1 : 0);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x0003A9CC File Offset: 0x00038BCC
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x0003A9E4 File Offset: 0x00038BE4
		public SortingLayerRange sortingLayerRange
		{
			get
			{
				return this.m_SortingLayerRange;
			}
			set
			{
				this.m_SortingLayerRange = value;
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0003A9F0 File Offset: 0x00038BF0
		public bool Equals(FilteringSettings other)
		{
			return this.m_RenderQueueRange.Equals(other.m_RenderQueueRange) && this.m_LayerMask == other.m_LayerMask && this.m_RenderingLayerMask == other.m_RenderingLayerMask && this.m_ExcludeMotionVectorObjects == other.m_ExcludeMotionVectorObjects;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0003AA44 File Offset: 0x00038C44
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is FilteringSettings && this.Equals((FilteringSettings)obj);
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0003AA7C File Offset: 0x00038C7C
		public override int GetHashCode()
		{
			int num = this.m_RenderQueueRange.GetHashCode();
			num = (num * 397 ^ this.m_LayerMask);
			num = (num * 397 ^ (int)this.m_RenderingLayerMask);
			return num * 397 ^ this.m_ExcludeMotionVectorObjects;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0003AAD0 File Offset: 0x00038CD0
		public static bool operator ==(FilteringSettings left, FilteringSettings right)
		{
			return left.Equals(right);
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0003AAEC File Offset: 0x00038CEC
		public static bool operator !=(FilteringSettings left, FilteringSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000CE5 RID: 3301
		private RenderQueueRange m_RenderQueueRange;

		// Token: 0x04000CE6 RID: 3302
		private int m_LayerMask;

		// Token: 0x04000CE7 RID: 3303
		private uint m_RenderingLayerMask;

		// Token: 0x04000CE8 RID: 3304
		private int m_ExcludeMotionVectorObjects;

		// Token: 0x04000CE9 RID: 3305
		private SortingLayerRange m_SortingLayerRange;
	}
}
