using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002C5 RID: 709
	public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits>
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x00063FF4 File Offset: 0x000621F4
		public override string uxmlName
		{
			get
			{
				return "Style";
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00063FFB File Offset: 0x000621FB
		public override string uxmlQualifiedName
		{
			get
			{
				return this.uxmlNamespace + "." + this.uxmlName;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00064013 File Offset: 0x00062213
		public override string substituteForTypeName
		{
			get
			{
				return typeof(VisualElement).Name;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00064024 File Offset: 0x00062224
		public override string substituteForTypeNamespace
		{
			get
			{
				return typeof(VisualElement).Namespace ?? string.Empty;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x0006403E File Offset: 0x0006223E
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return typeof(VisualElement).FullName;
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00064050 File Offset: 0x00062250
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}

		// Token: 0x04000A53 RID: 2643
		internal const string k_ElementName = "Style";
	}
}
