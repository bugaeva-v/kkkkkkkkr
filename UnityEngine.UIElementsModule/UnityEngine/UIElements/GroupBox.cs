using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013F RID: 319
	public class GroupBox : BindableElement, IGroupBox
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0002A6ED File Offset: 0x000288ED
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x0002A704 File Offset: 0x00028904
		public string text
		{
			get
			{
				Label titleLabel = this.m_TitleLabel;
				return (titleLabel != null) ? titleLabel.text : null;
			}
			set
			{
				bool flag = !string.IsNullOrEmpty(value);
				if (flag)
				{
					bool flag2 = this.m_TitleLabel == null;
					if (flag2)
					{
						this.m_TitleLabel = new Label(value);
						this.m_TitleLabel.AddToClassList(GroupBox.labelUssClassName);
						base.Insert(0, this.m_TitleLabel);
					}
					this.m_TitleLabel.text = value;
				}
				else
				{
					bool flag3 = this.m_TitleLabel != null;
					if (flag3)
					{
						this.m_TitleLabel.RemoveFromHierarchy();
						this.m_TitleLabel = null;
					}
				}
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0002A78C File Offset: 0x0002898C
		public GroupBox() : this(null)
		{
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0002A797 File Offset: 0x00028997
		public GroupBox(string text)
		{
			base.AddToClassList(GroupBox.ussClassName);
			this.text = text;
		}

		// Token: 0x04000491 RID: 1169
		public static readonly string ussClassName = "unity-group-box";

		// Token: 0x04000492 RID: 1170
		public static readonly string labelUssClassName = GroupBox.ussClassName + "__label";

		// Token: 0x04000493 RID: 1171
		private Label m_TitleLabel;

		// Token: 0x02000140 RID: 320
		public new class UxmlFactory : UxmlFactory<GroupBox, GroupBox.UxmlTraits>
		{
		}

		// Token: 0x02000141 RID: 321
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x06000A8F RID: 2703 RVA: 0x0002A7DE File Offset: 0x000289DE
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				((GroupBox)ve).text = this.m_Text.GetValueFromBag(bag, cc);
			}

			// Token: 0x04000494 RID: 1172
			private UxmlStringAttributeDescription m_Text = new UxmlStringAttributeDescription
			{
				name = "text"
			};
		}
	}
}
