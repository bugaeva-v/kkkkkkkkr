using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000C RID: 12
	public class BindableElement : VisualElement, IBindable
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002B27 File Offset: 0x00000D27
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002B2F File Offset: 0x00000D2F
		public IBinding binding { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002B38 File Offset: 0x00000D38
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002B40 File Offset: 0x00000D40
		public string bindingPath { get; set; }

		// Token: 0x0200000D RID: 13
		public new class UxmlFactory : UxmlFactory<BindableElement, BindableElement.UxmlTraits>
		{
		}

		// Token: 0x0200000E RID: 14
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x06000042 RID: 66 RVA: 0x00002B5B File Offset: 0x00000D5B
			public UxmlTraits()
			{
				this.m_PropertyPath = new UxmlStringAttributeDescription
				{
					name = "binding-path"
				};
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00002B7C File Offset: 0x00000D7C
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				string valueFromBag = this.m_PropertyPath.GetValueFromBag(bag, cc);
				bool flag = !string.IsNullOrEmpty(valueFromBag);
				if (flag)
				{
					IBindable bindable = ve as IBindable;
					bool flag2 = bindable != null;
					if (flag2)
					{
						bindable.bindingPath = valueFromBag;
					}
				}
			}

			// Token: 0x0400001C RID: 28
			private UxmlStringAttributeDescription m_PropertyPath;
		}
	}
}
