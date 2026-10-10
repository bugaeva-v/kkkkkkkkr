using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000245 RID: 581
	[Serializable]
	public class DynamicAtlasSettings
	{
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x000454E4 File Offset: 0x000436E4
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x000454EC File Offset: 0x000436EC
		public int minAtlasSize
		{
			get
			{
				return this.m_MinAtlasSize;
			}
			set
			{
				this.m_MinAtlasSize = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000454F5 File Offset: 0x000436F5
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x000454FD File Offset: 0x000436FD
		public int maxAtlasSize
		{
			get
			{
				return this.m_MaxAtlasSize;
			}
			set
			{
				this.m_MaxAtlasSize = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00045506 File Offset: 0x00043706
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0004550E File Offset: 0x0004370E
		public int maxSubTextureSize
		{
			get
			{
				return this.m_MaxSubTextureSize;
			}
			set
			{
				this.m_MaxSubTextureSize = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00045517 File Offset: 0x00043717
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0004551F File Offset: 0x0004371F
		public DynamicAtlasFilters activeFilters
		{
			get
			{
				return (DynamicAtlasFilters)this.m_ActiveFilters;
			}
			set
			{
				this.m_ActiveFilters = (DynamicAtlasFiltersInternal)value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00045528 File Offset: 0x00043728
		public static DynamicAtlasFilters defaultFilters
		{
			get
			{
				return DynamicAtlas.defaultFilters;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0004552F File Offset: 0x0004372F
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x00045537 File Offset: 0x00043737
		public DynamicAtlasCustomFilter customFilter
		{
			get
			{
				return this.m_CustomFilter;
			}
			set
			{
				this.m_CustomFilter = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00045540 File Offset: 0x00043740
		public static DynamicAtlasSettings defaults
		{
			get
			{
				return new DynamicAtlasSettings
				{
					minAtlasSize = 64,
					maxAtlasSize = 4096,
					maxSubTextureSize = 64,
					activeFilters = DynamicAtlasSettings.defaultFilters,
					customFilter = null
				};
			}
		}

		// Token: 0x040007D0 RID: 2000
		[SerializeField]
		[HideInInspector]
		private int m_MinAtlasSize;

		// Token: 0x040007D1 RID: 2001
		[HideInInspector]
		[SerializeField]
		private int m_MaxAtlasSize;

		// Token: 0x040007D2 RID: 2002
		[SerializeField]
		[HideInInspector]
		private int m_MaxSubTextureSize;

		// Token: 0x040007D3 RID: 2003
		[SerializeField]
		[HideInInspector]
		private DynamicAtlasFiltersInternal m_ActiveFilters;

		// Token: 0x040007D4 RID: 2004
		private DynamicAtlasCustomFilter m_CustomFilter;
	}
}
