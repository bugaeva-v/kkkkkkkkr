using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020002C3 RID: 707
	public class UxmlRootElementTraits : UxmlTraits
	{
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00063ED0 File Offset: 0x000620D0
		public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				yield return new UxmlChildElementDescription(typeof(VisualElement));
				yield break;
			}
		}

		// Token: 0x04000A4D RID: 2637
		protected UxmlStringAttributeDescription m_Name = new UxmlStringAttributeDescription
		{
			name = "name"
		};

		// Token: 0x04000A4E RID: 2638
		private UxmlStringAttributeDescription m_Class = new UxmlStringAttributeDescription
		{
			name = "class"
		};
	}
}
