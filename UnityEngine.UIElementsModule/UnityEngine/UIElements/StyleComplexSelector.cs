using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.UIElements
{
	// Token: 0x020002A2 RID: 674
	[Serializable]
	internal class StyleComplexSelector
	{
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x000613A4 File Offset: 0x0005F5A4
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x000613BC File Offset: 0x0005F5BC
		public int specificity
		{
			get
			{
				return this.m_Specificity;
			}
			internal set
			{
				this.m_Specificity = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x000613C6 File Offset: 0x0005F5C6
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x000613CE File Offset: 0x0005F5CE
		public StyleRule rule { get; internal set; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x000613D8 File Offset: 0x0005F5D8
		public bool isSimple
		{
			get
			{
				return this.selectors.Length == 1;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x000613F8 File Offset: 0x0005F5F8
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x00061410 File Offset: 0x0005F610
		public StyleSelector[] selectors
		{
			get
			{
				return this.m_Selectors;
			}
			internal set
			{
				this.m_Selectors = value;
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0006141C File Offset: 0x0005F61C
		internal void CachePseudoStateMasks()
		{
			bool flag = StyleComplexSelector.s_PseudoStates == null;
			if (flag)
			{
				StyleComplexSelector.s_PseudoStates = new Dictionary<string, StyleComplexSelector.PseudoStateData>();
				StyleComplexSelector.s_PseudoStates["active"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Active, false);
				StyleComplexSelector.s_PseudoStates["hover"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Hover, false);
				StyleComplexSelector.s_PseudoStates["checked"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Checked, false);
				StyleComplexSelector.s_PseudoStates["selected"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Checked, false);
				StyleComplexSelector.s_PseudoStates["disabled"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Disabled, false);
				StyleComplexSelector.s_PseudoStates["focus"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Focus, false);
				StyleComplexSelector.s_PseudoStates["root"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Root, false);
				StyleComplexSelector.s_PseudoStates["inactive"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Active, true);
				StyleComplexSelector.s_PseudoStates["enabled"] = new StyleComplexSelector.PseudoStateData(PseudoStates.Disabled, true);
			}
			int i = 0;
			int num = this.selectors.Length;
			while (i < num)
			{
				StyleSelector styleSelector = this.selectors[i];
				StyleSelectorPart[] parts = styleSelector.parts;
				PseudoStates pseudoStates = (PseudoStates)0;
				PseudoStates pseudoStates2 = (PseudoStates)0;
				for (int j = 0; j < styleSelector.parts.Length; j++)
				{
					bool flag2 = styleSelector.parts[j].type == StyleSelectorType.PseudoClass;
					if (flag2)
					{
						StyleComplexSelector.PseudoStateData pseudoStateData;
						bool flag3 = StyleComplexSelector.s_PseudoStates.TryGetValue(parts[j].value, out pseudoStateData);
						if (flag3)
						{
							bool flag4 = !pseudoStateData.negate;
							if (flag4)
							{
								pseudoStates |= pseudoStateData.state;
							}
							else
							{
								pseudoStates2 |= pseudoStateData.state;
							}
						}
						else
						{
							Debug.LogWarningFormat("Unknown pseudo class \"{0}\"", new object[]
							{
								parts[j].value
							});
						}
					}
				}
				styleSelector.pseudoStateMask = (int)pseudoStates;
				styleSelector.negatedPseudoStateMask = (int)pseudoStates2;
				i++;
			}
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0006161C File Offset: 0x0005F81C
		public override string ToString()
		{
			return string.Format("[{0}]", string.Join(", ", (from x in this.m_Selectors
			select x.ToString()).ToArray<string>()));
		}

		// Token: 0x040009C3 RID: 2499
		[SerializeField]
		private int m_Specificity;

		// Token: 0x040009C5 RID: 2501
		[SerializeField]
		private StyleSelector[] m_Selectors;

		// Token: 0x040009C6 RID: 2502
		[SerializeField]
		internal int ruleIndex;

		// Token: 0x040009C7 RID: 2503
		[NonSerialized]
		internal StyleComplexSelector nextInTable;

		// Token: 0x040009C8 RID: 2504
		[NonSerialized]
		internal int orderInStyleSheet;

		// Token: 0x040009C9 RID: 2505
		private static Dictionary<string, StyleComplexSelector.PseudoStateData> s_PseudoStates;

		// Token: 0x020002A3 RID: 675
		private struct PseudoStateData
		{
			// Token: 0x0600172D RID: 5933 RVA: 0x00061671 File Offset: 0x0005F871
			public PseudoStateData(PseudoStates state, bool negate)
			{
				this.state = state;
				this.negate = negate;
			}

			// Token: 0x040009CA RID: 2506
			public readonly PseudoStates state;

			// Token: 0x040009CB RID: 2507
			public readonly bool negate;
		}
	}
}
