using System;

namespace UnityEngine
{
	// Token: 0x020001F2 RID: 498
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class CreateAssetMenuAttribute : Attribute
	{
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x00023F2C File Offset: 0x0002212C
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x00023F34 File Offset: 0x00022134
		public string menuName { get; set; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00023F3D File Offset: 0x0002213D
		// (set) Token: 0x06001666 RID: 5734 RVA: 0x00023F45 File Offset: 0x00022145
		public string fileName { get; set; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00023F4E File Offset: 0x0002214E
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x00023F56 File Offset: 0x00022156
		public int order { get; set; }
	}
}
