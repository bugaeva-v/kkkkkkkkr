using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A4 RID: 420
	internal class TreeViewItem<T> : ITreeViewItem
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0003A1B4 File Offset: 0x000383B4
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x0003A1BC File Offset: 0x000383BC
		public int id { get; private set; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0003A1C5 File Offset: 0x000383C5
		public ITreeViewItem parent
		{
			get
			{
				return this.m_Parent;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0003A1D0 File Offset: 0x000383D0
		public IEnumerable<ITreeViewItem> children
		{
			get
			{
				return this.m_Children;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0003A1E8 File Offset: 0x000383E8
		public bool hasChildren
		{
			get
			{
				return this.m_Children != null && this.m_Children.Count > 0;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0003A213 File Offset: 0x00038413
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0003A21B File Offset: 0x0003841B
		public T data { get; private set; }

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0003A224 File Offset: 0x00038424
		public TreeViewItem(int id, T data, List<TreeViewItem<T>> children = null)
		{
			this.id = id;
			this.data = data;
			bool flag = children != null;
			if (flag)
			{
				foreach (TreeViewItem<T> child in children)
				{
					this.AddChild(child);
				}
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0003A298 File Offset: 0x00038498
		public void AddChild(ITreeViewItem child)
		{
			TreeViewItem<T> treeViewItem = child as TreeViewItem<T>;
			bool flag = treeViewItem == null;
			if (!flag)
			{
				bool flag2 = this.m_Children == null;
				if (flag2)
				{
					this.m_Children = new List<ITreeViewItem>();
				}
				this.m_Children.Add(treeViewItem);
				treeViewItem.m_Parent = this;
			}
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0003A2E4 File Offset: 0x000384E4
		public void AddChildren(IList<ITreeViewItem> children)
		{
			foreach (ITreeViewItem child in children)
			{
				this.AddChild(child);
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0003A330 File Offset: 0x00038530
		public void RemoveChild(ITreeViewItem child)
		{
			bool flag = this.m_Children == null;
			if (!flag)
			{
				TreeViewItem<T> treeViewItem = child as TreeViewItem<T>;
				bool flag2 = treeViewItem == null;
				if (!flag2)
				{
					this.m_Children.Remove(treeViewItem);
				}
			}
		}

		// Token: 0x04000678 RID: 1656
		internal TreeViewItem<T> m_Parent;

		// Token: 0x04000679 RID: 1657
		private List<ITreeViewItem> m_Children;
	}
}
