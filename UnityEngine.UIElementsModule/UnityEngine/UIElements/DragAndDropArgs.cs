using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B2 RID: 434
	internal struct DragAndDropArgs : IListDragAndDropArgs
	{
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0003AE6D File Offset: 0x0003906D
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x0003AE75 File Offset: 0x00039075
		public object target { readonly get; set; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x0003AE7E File Offset: 0x0003907E
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x0003AE86 File Offset: 0x00039086
		public int insertAtIndex { readonly get; set; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x0003AE8F File Offset: 0x0003908F
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x0003AE97 File Offset: 0x00039097
		public int parentId { readonly get; set; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0003AEA0 File Offset: 0x000390A0
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x0003AEA8 File Offset: 0x000390A8
		public int childIndex { readonly get; set; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0003AEB1 File Offset: 0x000390B1
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x0003AEB9 File Offset: 0x000390B9
		public DragAndDropPosition dragAndDropPosition { readonly get; set; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0003AEC2 File Offset: 0x000390C2
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0003AECA File Offset: 0x000390CA
		public IDragAndDropData dragAndDropData { readonly get; set; }
	}
}
