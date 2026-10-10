using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000057 RID: 87
	internal class RepaintData
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00008C50 File Offset: 0x00006E50
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00008C58 File Offset: 0x00006E58
		public Matrix4x4 currentOffset { get; set; } = Matrix4x4.identity;

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00008C61 File Offset: 0x00006E61
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00008C69 File Offset: 0x00006E69
		public Vector2 mousePosition { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00008C72 File Offset: 0x00006E72
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00008C7A File Offset: 0x00006E7A
		public Rect currentWorldClip { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00008C83 File Offset: 0x00006E83
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00008C8B File Offset: 0x00006E8B
		public Event repaintEvent { get; set; }
	}
}
