using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015A RID: 346
	public class PopupWindow : TextElement
	{
		// Token: 0x06000B34 RID: 2868 RVA: 0x0002E22C File Offset: 0x0002C42C
		public PopupWindow()
		{
			base.AddToClassList(PopupWindow.ussClassName);
			this.m_ContentContainer = new VisualElement
			{
				name = "unity-content-container"
			};
			this.m_ContentContainer.AddToClassList(PopupWindow.contentUssClassName);
			base.hierarchy.Add(this.m_ContentContainer);
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0002E28C File Offset: 0x0002C48C
		public override VisualElement contentContainer
		{
			get
			{
				return this.m_ContentContainer;
			}
		}

		// Token: 0x04000515 RID: 1301
		private VisualElement m_ContentContainer;

		// Token: 0x04000516 RID: 1302
		public new static readonly string ussClassName = "unity-popup-window";

		// Token: 0x04000517 RID: 1303
		public static readonly string contentUssClassName = PopupWindow.ussClassName + "__content-container";

		// Token: 0x0200015B RID: 347
		public new class UxmlFactory : UxmlFactory<PopupWindow, PopupWindow.UxmlTraits>
		{
		}

		// Token: 0x0200015C RID: 348
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x1700022D RID: 557
			// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0002E2D0 File Offset: 0x0002C4D0
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get
				{
					yield return new UxmlChildElementDescription(typeof(VisualElement));
					yield break;
				}
			}
		}
	}
}
