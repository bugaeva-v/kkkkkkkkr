using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020002C6 RID: 710
	public class UxmlStyleTraits : UxmlTraits
	{
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x0006406C File Offset: 0x0006226C
		public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				yield break;
			}
		}

		// Token: 0x04000A54 RID: 2644
		private UxmlStringAttributeDescription m_Name = new UxmlStringAttributeDescription
		{
			name = "name"
		};

		// Token: 0x04000A55 RID: 2645
		private UxmlStringAttributeDescription m_Path = new UxmlStringAttributeDescription
		{
			name = "path"
		};

		// Token: 0x04000A56 RID: 2646
		private UxmlStringAttributeDescription m_Src = new UxmlStringAttributeDescription
		{
			name = "src"
		};
	}
}
