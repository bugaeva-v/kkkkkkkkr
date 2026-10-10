using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B4 RID: 180
	public class TemplateContainer : BindableElement
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00016AEC File Offset: 0x00014CEC
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00016AF4 File Offset: 0x00014CF4
		public string templateId { get; private set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00016AFD File Offset: 0x00014CFD
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00016B05 File Offset: 0x00014D05
		public VisualTreeAsset templateSource
		{
			get
			{
				return this.m_TemplateSource;
			}
			internal set
			{
				this.m_TemplateSource = value;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00016B0E File Offset: 0x00014D0E
		public TemplateContainer() : this(null)
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00016B19 File Offset: 0x00014D19
		public TemplateContainer(string templateId)
		{
			this.templateId = templateId;
			this.m_ContentContainer = this;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00016B34 File Offset: 0x00014D34
		public override VisualElement contentContainer
		{
			get
			{
				return this.m_ContentContainer;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00016B4C File Offset: 0x00014D4C
		internal void SetContentContainer(VisualElement content)
		{
			this.m_ContentContainer = content;
		}

		// Token: 0x04000262 RID: 610
		private VisualElement m_ContentContainer;

		// Token: 0x04000263 RID: 611
		private VisualTreeAsset m_TemplateSource;

		// Token: 0x020000B5 RID: 181
		public new class UxmlFactory : UxmlFactory<TemplateContainer, TemplateContainer.UxmlTraits>
		{
			// Token: 0x17000161 RID: 353
			// (get) Token: 0x0600060A RID: 1546 RVA: 0x00016B56 File Offset: 0x00014D56
			public override string uxmlName
			{
				get
				{
					return "Instance";
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x0600060B RID: 1547 RVA: 0x00016B5D File Offset: 0x00014D5D
			public override string uxmlQualifiedName
			{
				get
				{
					return this.uxmlNamespace + "." + this.uxmlName;
				}
			}

			// Token: 0x04000264 RID: 612
			internal const string k_ElementName = "Instance";
		}

		// Token: 0x020000B6 RID: 182
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x17000163 RID: 355
			// (get) Token: 0x0600060D RID: 1549 RVA: 0x00016B80 File Offset: 0x00014D80
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get
				{
					yield break;
				}
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x00016BA0 File Offset: 0x00014DA0
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				TemplateContainer templateContainer = (TemplateContainer)ve;
				templateContainer.templateId = this.m_Template.GetValueFromBag(bag, cc);
				VisualTreeAsset visualTreeAsset = cc.visualTreeAsset;
				VisualTreeAsset visualTreeAsset2 = (visualTreeAsset != null) ? visualTreeAsset.ResolveTemplate(templateContainer.templateId) : null;
				bool flag = visualTreeAsset2 == null;
				if (flag)
				{
					templateContainer.Add(new Label(string.Format("Unknown Template: '{0}'", templateContainer.templateId)));
				}
				else
				{
					TemplateAsset templateAsset = bag as TemplateAsset;
					List<TemplateAsset.AttributeOverride> list = (templateAsset != null) ? templateAsset.attributeOverrides : null;
					List<TemplateAsset.AttributeOverride> attributeOverrides = cc.attributeOverrides;
					List<TemplateAsset.AttributeOverride> list2 = null;
					bool flag2 = list != null || attributeOverrides != null;
					if (flag2)
					{
						list2 = new List<TemplateAsset.AttributeOverride>();
						bool flag3 = attributeOverrides != null;
						if (flag3)
						{
							list2.AddRange(attributeOverrides);
						}
						bool flag4 = list != null;
						if (flag4)
						{
							list2.AddRange(list);
						}
					}
					visualTreeAsset2.CloneTree(ve, cc.slotInsertionPoints, list2);
				}
				bool flag5 = visualTreeAsset2 == null;
				if (flag5)
				{
					Debug.LogErrorFormat("Could not resolve template with name '{0}'", new object[]
					{
						templateContainer.templateId
					});
				}
			}

			// Token: 0x04000265 RID: 613
			internal const string k_TemplateAttributeName = "template";

			// Token: 0x04000266 RID: 614
			private UxmlStringAttributeDescription m_Template = new UxmlStringAttributeDescription
			{
				name = "template",
				use = UxmlAttributeDescription.Use.Required
			};
		}
	}
}
