using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020002CC RID: 716
	public class UxmlAttributeOverridesTraits : UxmlTraits
	{
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00064324 File Offset: 0x00062524
		public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				yield break;
			}
		}

		// Token: 0x04000A64 RID: 2660
		internal const string k_ElementNameAttributeName = "element-name";

		// Token: 0x04000A65 RID: 2661
		private UxmlStringAttributeDescription m_ElementName = new UxmlStringAttributeDescription
		{
			name = "element-name",
			use = UxmlAttributeDescription.Use.Required
		};
	}
}
