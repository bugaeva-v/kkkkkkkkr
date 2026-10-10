using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E6 RID: 742
	public class UxmlChildElementDescription
	{
		// Token: 0x060018AB RID: 6315 RVA: 0x000654C4 File Offset: 0x000636C4
		public UxmlChildElementDescription(Type t)
		{
			bool flag = t == null;
			if (flag)
			{
				throw new ArgumentNullException("t");
			}
			this.elementName = t.Name;
			this.elementNamespace = t.Namespace;
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x00065507 File Offset: 0x00063707
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x0006550F File Offset: 0x0006370F
		public string elementName { get; protected set; }

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00065518 File Offset: 0x00063718
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x00065520 File Offset: 0x00063720
		public string elementNamespace { get; protected set; }
	}
}
