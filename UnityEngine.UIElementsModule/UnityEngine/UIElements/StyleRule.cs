using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002A6 RID: 678
	[Serializable]
	internal class StyleRule
	{
		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00061704 File Offset: 0x0005F904
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x0006171C File Offset: 0x0005F91C
		public StyleProperty[] properties
		{
			get
			{
				return this.m_Properties;
			}
			internal set
			{
				this.m_Properties = value;
			}
		}

		// Token: 0x040009D3 RID: 2515
		[SerializeField]
		private StyleProperty[] m_Properties;

		// Token: 0x040009D4 RID: 2516
		[SerializeField]
		internal int line;

		// Token: 0x040009D5 RID: 2517
		[NonSerialized]
		internal int customPropertiesCount;
	}
}
