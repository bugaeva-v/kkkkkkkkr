using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.UIElements
{
	// Token: 0x02000194 RID: 404
	internal readonly struct TreeItem
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000373C4 File Offset: 0x000355C4
		public int id { get; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x000373CC File Offset: 0x000355CC
		public int parentId { get; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000373D4 File Offset: 0x000355D4
		public IEnumerable<int> childrenIds { get; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x000373DC File Offset: 0x000355DC
		public bool hasChildren
		{
			get
			{
				return this.childrenIds != null && this.childrenIds.Any<int>();
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000373F4 File Offset: 0x000355F4
		public TreeItem(int id, int parentId = -1, IEnumerable<int> childrenIds = null)
		{
			this.id = id;
			this.parentId = parentId;
			this.childrenIds = childrenIds;
		}

		// Token: 0x04000624 RID: 1572
		public const int invalidId = -1;
	}
}
