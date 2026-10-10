using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020002FF RID: 767
	public struct CreationContext : IEquatable<CreationContext>
	{
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00067AF9 File Offset: 0x00065CF9
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00067B01 File Offset: 0x00065D01
		public VisualElement target { readonly get; private set; }

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00067B0A File Offset: 0x00065D0A
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00067B12 File Offset: 0x00065D12
		public VisualTreeAsset visualTreeAsset { readonly get; private set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00067B1B File Offset: 0x00065D1B
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00067B23 File Offset: 0x00065D23
		public Dictionary<string, VisualElement> slotInsertionPoints { readonly get; private set; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00067B2C File Offset: 0x00065D2C
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00067B34 File Offset: 0x00065D34
		internal List<TemplateAsset.AttributeOverride> attributeOverrides { readonly get; private set; }

		// Token: 0x0600196A RID: 6506 RVA: 0x00067B3D File Offset: 0x00065D3D
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target)
		{
			this = new CreationContext(slotInsertionPoints, null, vta, target);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00067B4B File Offset: 0x00065D4B
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target)
		{
			this.target = target;
			this.slotInsertionPoints = slotInsertionPoints;
			this.attributeOverrides = attributeOverrides;
			this.visualTreeAsset = vta;
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00067B70 File Offset: 0x00065D70
		public override bool Equals(object obj)
		{
			return obj is CreationContext && this.Equals((CreationContext)obj);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00067B9C File Offset: 0x00065D9C
		public bool Equals(CreationContext other)
		{
			return EqualityComparer<VisualElement>.Default.Equals(this.target, other.target) && EqualityComparer<VisualTreeAsset>.Default.Equals(this.visualTreeAsset, other.visualTreeAsset) && EqualityComparer<Dictionary<string, VisualElement>>.Default.Equals(this.slotInsertionPoints, other.slotInsertionPoints);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00067BFC File Offset: 0x00065DFC
		public override int GetHashCode()
		{
			int num = -2123482148;
			num = num * -1521134295 + EqualityComparer<VisualElement>.Default.GetHashCode(this.target);
			num = num * -1521134295 + EqualityComparer<VisualTreeAsset>.Default.GetHashCode(this.visualTreeAsset);
			return num * -1521134295 + EqualityComparer<Dictionary<string, VisualElement>>.Default.GetHashCode(this.slotInsertionPoints);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00067C60 File Offset: 0x00065E60
		public static bool operator ==(CreationContext context1, CreationContext context2)
		{
			return context1.Equals(context2);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00067C7C File Offset: 0x00065E7C
		public static bool operator !=(CreationContext context1, CreationContext context2)
		{
			return !(context1 == context2);
		}

		// Token: 0x04000AF0 RID: 2800
		public static readonly CreationContext Default = default(CreationContext);
	}
}
