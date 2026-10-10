using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A5 RID: 421
	internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController, IDragAndDropController<IListDragAndDropArgs>, IReorderable
	{
		// Token: 0x06000DE6 RID: 3558 RVA: 0x0003A36B File Offset: 0x0003856B
		public IEnumerable<int> GetSortedSelectedIds()
		{
			return this.m_SortedSelectedIds;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0003A373 File Offset: 0x00038573
		public BaseReorderableDragAndDropController(BaseVerticalCollectionView view)
		{
			this.m_View = view;
			this.enableReordering = true;
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0003A397 File Offset: 0x00038597
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0003A39F File Offset: 0x0003859F
		public virtual bool enableReordering { get; set; }

		// Token: 0x06000DEA RID: 3562 RVA: 0x0003A3A8 File Offset: 0x000385A8
		public virtual bool CanStartDrag(IEnumerable<int> itemIndices)
		{
			return this.enableReordering;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0003A3C0 File Offset: 0x000385C0
		public virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
		{
			this.m_SortedSelectedIds.Clear();
			string text = string.Empty;
			bool flag = itemIds != null;
			if (flag)
			{
				foreach (int num in itemIds)
				{
					this.m_SortedSelectedIds.Add(num);
					bool flag2 = skipText;
					if (!flag2)
					{
						bool flag3 = string.IsNullOrEmpty(text);
						if (flag3)
						{
							ReusableCollectionItem recycledItemFromId = this.m_View.GetRecycledItemFromId(num);
							Label label = (recycledItemFromId != null) ? recycledItemFromId.rootElement.Q(null, null) : null;
							text = ((label != null) ? label.text : string.Format("Item {0}", num));
						}
						else
						{
							text = "<Multiple>";
							skipText = true;
						}
					}
				}
			}
			this.m_SortedSelectedIds.Sort(new Comparison<int>(this.CompareId));
			return new StartDragArgs(text, DragVisualMode.Move);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0003A4C0 File Offset: 0x000386C0
		protected virtual int CompareId(int id1, int id2)
		{
			return id1.CompareTo(id2);
		}

		// Token: 0x06000DED RID: 3565
		public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args);

		// Token: 0x06000DEE RID: 3566
		public abstract void OnDrop(IListDragAndDropArgs args);

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002166 File Offset: 0x00000366
		public virtual void DragCleanup()
		{
		}

		// Token: 0x0400067B RID: 1659
		protected readonly BaseVerticalCollectionView m_View;

		// Token: 0x0400067C RID: 1660
		protected List<int> m_SortedSelectedIds = new List<int>();
	}
}
