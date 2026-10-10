using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002C8 RID: 712
	public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
	{
		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x00064188 File Offset: 0x00062388
		public override string uxmlName
		{
			get
			{
				return "Template";
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0006418F File Offset: 0x0006238F
		public override string uxmlQualifiedName
		{
			get
			{
				return this.uxmlNamespace + "." + this.uxmlName;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00064013 File Offset: 0x00062213
		public override string substituteForTypeName
		{
			get
			{
				return typeof(VisualElement).Name;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x00064024 File Offset: 0x00062224
		public override string substituteForTypeNamespace
		{
			get
			{
				return typeof(VisualElement).Namespace ?? string.Empty;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x0006403E File Offset: 0x0006223E
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return typeof(VisualElement).FullName;
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000641A8 File Offset: 0x000623A8
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}

		// Token: 0x04000A5B RID: 2651
		internal const string k_ElementName = "Template";
	}
}
