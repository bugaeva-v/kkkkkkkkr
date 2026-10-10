using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002D2 RID: 722
	public abstract class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription
	{
		// Token: 0x06001850 RID: 6224
		public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x0006487B File Offset: 0x00062A7B
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x00064883 File Offset: 0x00062A83
		public T defaultValue { get; set; }

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x0006488C File Offset: 0x00062A8C
		public override string defaultValueAsString
		{
			get
			{
				T defaultValue = this.defaultValue;
				return defaultValue.ToString();
			}
		}
	}
}
