using System;
using System.Linq;

namespace UnityEngine.UIElements
{
	// Token: 0x020002A7 RID: 679
	[Serializable]
	internal class StyleSelector
	{
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00061728 File Offset: 0x0005F928
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x00061740 File Offset: 0x0005F940
		public StyleSelectorPart[] parts
		{
			get
			{
				return this.m_Parts;
			}
			internal set
			{
				this.m_Parts = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x0006174C File Offset: 0x0005F94C
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x00061764 File Offset: 0x0005F964
		public StyleSelectorRelationship previousRelationship
		{
			get
			{
				return this.m_PreviousRelationship;
			}
			internal set
			{
				this.m_PreviousRelationship = value;
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00061770 File Offset: 0x0005F970
		public override string ToString()
		{
			return string.Join(", ", (from p in this.parts
			select p.ToString()).ToArray<string>());
		}

		// Token: 0x040009D6 RID: 2518
		[SerializeField]
		private StyleSelectorPart[] m_Parts;

		// Token: 0x040009D7 RID: 2519
		[SerializeField]
		private StyleSelectorRelationship m_PreviousRelationship;

		// Token: 0x040009D8 RID: 2520
		internal int pseudoStateMask = -1;

		// Token: 0x040009D9 RID: 2521
		internal int negatedPseudoStateMask = -1;
	}
}
