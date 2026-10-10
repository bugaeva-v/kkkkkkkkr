using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010B RID: 267
	internal sealed class DefaultTreeViewController<T> : TreeViewController
	{
		// Token: 0x06000879 RID: 2169 RVA: 0x0001FEBF File Offset: 0x0001E0BF
		public void SetRootItems(IList<TreeViewItemData<T>> items)
		{
			this.m_TreeData = new TreeData<T>(items);
			base.RebuildTree();
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0001FED8 File Offset: 0x0001E0D8
		public void AddItem(in TreeViewItemData<T> item, int parentId, int childIndex, bool rebuildTree = true)
		{
			this.m_TreeData.AddItem(item, parentId, childIndex);
			if (rebuildTree)
			{
				base.RebuildTree();
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0001FF08 File Offset: 0x0001E108
		public override bool TryRemoveItem(int id, bool rebuildTree = true)
		{
			bool flag = this.m_TreeData.TryRemove(id);
			bool result;
			if (flag)
			{
				if (rebuildTree)
				{
					base.RebuildTree();
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0001FF3C File Offset: 0x0001E13C
		public T GetDataForId(int id)
		{
			return this.m_TreeData.GetDataForId(id).data;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0001FF64 File Offset: 0x0001E164
		public T GetDataForIndex(int index)
		{
			int idForIndex = this.GetIdForIndex(index);
			return this.GetDataForId(idForIndex);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0001FF88 File Offset: 0x0001E188
		public override object GetItemForIndex(int index)
		{
			return this.GetDataForIndex(index);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0001FFA8 File Offset: 0x0001E1A8
		public override int GetParentId(int id)
		{
			return this.m_TreeData.GetParentId(id);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		public override bool HasChildren(int id)
		{
			return this.m_TreeData.GetDataForId(id).hasChildren;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0001FFEE File Offset: 0x0001E1EE
		private static IEnumerable<int> GetItemIds(IEnumerable<TreeViewItemData<T>> items)
		{
			bool flag = items == null;
			if (flag)
			{
				yield break;
			}
			foreach (TreeViewItemData<T> item in items)
			{
				yield return item.id;
				item = default(TreeViewItemData<T>);
			}
			IEnumerator<TreeViewItemData<T>> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00020000 File Offset: 0x0001E200
		public override IEnumerable<int> GetChildrenIds(int id)
		{
			return DefaultTreeViewController<T>.GetItemIds(this.m_TreeData.GetDataForId(id).children);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0002002C File Offset: 0x0001E22C
		public override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true)
		{
			bool flag = id == newParentId;
			if (!flag)
			{
				bool flag2 = this.IsChildOf(newParentId, id);
				if (!flag2)
				{
					this.m_TreeData.Move(id, newParentId, childIndex);
					if (rebuildTree)
					{
						base.RebuildTree();
						base.RaiseItemParentChanged(id, newParentId);
					}
				}
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0002007C File Offset: 0x0001E27C
		private bool IsChildOf(int childId, int id)
		{
			return this.m_TreeData.GetDataForId(id).HasChildRecursive(childId);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000200AC File Offset: 0x0001E2AC
		public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null)
		{
			bool flag = rootIds == null;
			if (flag)
			{
				bool flag2 = this.m_TreeData.rootItemIds == null;
				if (flag2)
				{
					yield break;
				}
				rootIds = this.m_TreeData.rootItemIds;
			}
			IEnumerator<int> currentIterator = rootIds.GetEnumerator();
			for (;;)
			{
				bool hasNext = currentIterator.MoveNext();
				bool flag3 = !hasNext;
				if (flag3)
				{
					bool flag4 = this.m_IteratorStack.Count > 0;
					if (!flag4)
					{
						break;
					}
					currentIterator = this.m_IteratorStack.Pop();
				}
				else
				{
					int currentItemId = currentIterator.Current;
					yield return currentItemId;
					bool flag5 = this.HasChildren(currentItemId);
					if (flag5)
					{
						this.m_IteratorStack.Push(currentIterator);
						currentIterator = this.GetChildrenIds(currentItemId).GetEnumerator();
					}
				}
			}
			yield break;
		}

		// Token: 0x04000374 RID: 884
		private TreeData<T> m_TreeData;

		// Token: 0x04000375 RID: 885
		private Stack<IEnumerator<int>> m_IteratorStack = new Stack<IEnumerator<int>>();
	}
}
