using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine.Assertions;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019D RID: 413
	internal class InternalTreeView : VisualElement
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00038A00 File Offset: 0x00036C00
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00038A18 File Offset: 0x00036C18
		public Func<VisualElement> makeItem
		{
			get
			{
				return this.m_MakeItem;
			}
			set
			{
				bool flag = this.m_MakeItem == value;
				if (!flag)
				{
					this.m_MakeItem = value;
					this.m_ListView.Rebuild();
				}
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000D7C RID: 3452 RVA: 0x00038A4C File Offset: 0x00036C4C
		// (remove) Token: 0x06000D7D RID: 3453 RVA: 0x00038A84 File Offset: 0x00036C84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<IEnumerable<ITreeViewItem>> onItemsChosen;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000D7E RID: 3454 RVA: 0x00038ABC File Offset: 0x00036CBC
		// (remove) Token: 0x06000D7F RID: 3455 RVA: 0x00038AF4 File Offset: 0x00036CF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<IEnumerable<ITreeViewItem>> onSelectionChange;

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00038B29 File Offset: 0x00036D29
		public ITreeViewItem selectedItem
		{
			get
			{
				return (this.m_SelectedItems.Count == 0) ? null : this.m_SelectedItems.First<ITreeViewItem>();
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00038B48 File Offset: 0x00036D48
		public IEnumerable<ITreeViewItem> selectedItems
		{
			get
			{
				bool flag = this.m_SelectedItems != null;
				IEnumerable<ITreeViewItem> selectedItems;
				if (flag)
				{
					selectedItems = this.m_SelectedItems;
				}
				else
				{
					this.m_SelectedItems = new List<ITreeViewItem>();
					foreach (ITreeViewItem treeViewItem in this.items)
					{
						foreach (int num in this.m_ListView.selectedIds)
						{
							bool flag2 = treeViewItem.id == num;
							if (flag2)
							{
								this.m_SelectedItems.Add(treeViewItem);
							}
						}
					}
					selectedItems = this.m_SelectedItems;
				}
				return selectedItems;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00038C24 File Offset: 0x00036E24
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00038C3C File Offset: 0x00036E3C
		public Action<VisualElement, ITreeViewItem> bindItem
		{
			get
			{
				return this.m_BindItem;
			}
			set
			{
				this.m_BindItem = value;
				this.ListViewRefresh();
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00038C4D File Offset: 0x00036E4D
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00038C55 File Offset: 0x00036E55
		public Action<VisualElement, ITreeViewItem> unbindItem { get; set; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00038C60 File Offset: 0x00036E60
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00038C78 File Offset: 0x00036E78
		public IList<ITreeViewItem> rootItems
		{
			get
			{
				return this.m_RootItems;
			}
			set
			{
				this.m_RootItems = value;
				this.Rebuild();
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00038C89 File Offset: 0x00036E89
		public IEnumerable<ITreeViewItem> items
		{
			get
			{
				return InternalTreeView.GetAllItems(this.m_RootItems);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00038C96 File Offset: 0x00036E96
		public float resolvedItemHeight
		{
			get
			{
				return this.m_ListView.ResolveItemHeight(-1f);
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00038CA8 File Offset: 0x00036EA8
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00038CC6 File Offset: 0x00036EC6
		public int itemHeight
		{
			get
			{
				return (int)this.m_ListView.fixedItemHeight;
			}
			set
			{
				this.m_ListView.fixedItemHeight = (float)value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00038CD8 File Offset: 0x00036ED8
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x00038CF5 File Offset: 0x00036EF5
		public bool horizontalScrollingEnabled
		{
			get
			{
				return this.m_ListView.horizontalScrollingEnabled;
			}
			set
			{
				this.m_ListView.horizontalScrollingEnabled = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00038D08 File Offset: 0x00036F08
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00038D25 File Offset: 0x00036F25
		public bool showBorder
		{
			get
			{
				return this.m_ListView.showBorder;
			}
			set
			{
				this.m_ListView.showBorder = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00038D38 File Offset: 0x00036F38
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00038D55 File Offset: 0x00036F55
		public SelectionType selectionType
		{
			get
			{
				return this.m_ListView.selectionType;
			}
			set
			{
				this.m_ListView.selectionType = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00038D68 File Offset: 0x00036F68
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00038D85 File Offset: 0x00036F85
		public AlternatingRowBackground showAlternatingRowBackgrounds
		{
			get
			{
				return this.m_ListView.showAlternatingRowBackgrounds;
			}
			set
			{
				this.m_ListView.showAlternatingRowBackgrounds = value;
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00038D98 File Offset: 0x00036F98
		public InternalTreeView()
		{
			this.m_SelectedItems = null;
			this.m_ExpandedItemIds = new List<int>();
			this.m_ItemWrappers = new List<InternalTreeView.TreeViewItemWrapper>();
			this.m_ListView = new ListView();
			this.m_ListView.name = InternalTreeView.s_ListViewName;
			this.m_ListView.itemsSource = this.m_ItemWrappers;
			this.m_ListView.viewDataKey = InternalTreeView.s_ListViewName;
			this.m_ListView.AddToClassList(InternalTreeView.s_ListViewName);
			base.hierarchy.Add(this.m_ListView);
			this.m_ListView.makeItem = new Func<VisualElement>(this.MakeTreeItem);
			this.m_ListView.bindItem = new Action<VisualElement, int>(this.BindTreeItem);
			this.m_ListView.unbindItem = new Action<VisualElement, int>(this.UnbindTreeItem);
			this.m_ListView.getItemId = new Func<int, int>(this.GetItemId);
			this.m_ListView.onItemsChosen += this.OnItemsChosen;
			this.m_ListView.onSelectionChange += this.OnSelectionChange;
			this.m_ScrollView = this.m_ListView.scrollView;
			this.m_ScrollView.contentContainer.RegisterCallback<KeyDownEvent>(new EventCallback<KeyDownEvent>(this.OnKeyDown), TrickleDown.NoTrickleDown);
			base.RegisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnTreeViewMouseUp), TrickleDown.TrickleDown);
			base.RegisterCallback<CustomStyleResolvedEvent>(new EventCallback<CustomStyleResolvedEvent>(this.OnCustomStyleResolved), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00038F16 File Offset: 0x00037116
		public InternalTreeView(IList<ITreeViewItem> items, int fixedItemHeight, Func<VisualElement> makeItem, Action<VisualElement, ITreeViewItem> bindItem) : this()
		{
			this.m_ListView.fixedItemHeight = (float)fixedItemHeight;
			this.m_MakeItem = makeItem;
			this.m_BindItem = bindItem;
			this.m_RootItems = items;
			this.Rebuild();
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00038F4B File Offset: 0x0003714B
		public void RefreshItems()
		{
			this.RegenerateWrappers();
			this.ListViewRefresh();
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00038F5C File Offset: 0x0003715C
		public void Rebuild()
		{
			this.RegenerateWrappers();
			this.m_ListView.Rebuild();
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00038F74 File Offset: 0x00037174
		internal override void OnViewDataReady()
		{
			base.OnViewDataReady();
			string fullHierarchicalViewDataKey = base.GetFullHierarchicalViewDataKey();
			base.OverwriteFromViewData(this, fullHierarchicalViewDataKey);
			this.Rebuild();
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00038FA0 File Offset: 0x000371A0
		public static IEnumerable<ITreeViewItem> GetAllItems(IEnumerable<ITreeViewItem> rootItems)
		{
			bool flag = rootItems == null;
			if (flag)
			{
				yield break;
			}
			Stack<IEnumerator<ITreeViewItem>> iteratorStack = new Stack<IEnumerator<ITreeViewItem>>();
			IEnumerator<ITreeViewItem> currentIterator = rootItems.GetEnumerator();
			for (;;)
			{
				bool hasNext = currentIterator.MoveNext();
				bool flag2 = !hasNext;
				if (flag2)
				{
					bool flag3 = iteratorStack.Count > 0;
					if (!flag3)
					{
						break;
					}
					currentIterator = iteratorStack.Pop();
				}
				else
				{
					ITreeViewItem currentItem = currentIterator.Current;
					yield return currentItem;
					bool hasChildren = currentItem.hasChildren;
					if (hasChildren)
					{
						iteratorStack.Push(currentIterator);
						currentIterator = currentItem.children.GetEnumerator();
					}
					currentItem = null;
				}
			}
			yield break;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00038FB0 File Offset: 0x000371B0
		public void OnKeyDown(KeyDownEvent evt)
		{
			int selectedIndex = this.m_ListView.selectedIndex;
			bool flag = true;
			KeyCode keyCode = evt.keyCode;
			KeyCode keyCode2 = keyCode;
			if (keyCode2 != KeyCode.RightArrow)
			{
				if (keyCode2 != KeyCode.LeftArrow)
				{
					flag = false;
				}
				else
				{
					bool flag2 = this.IsExpandedByIndex(selectedIndex);
					if (flag2)
					{
						this.CollapseItemByIndex(selectedIndex);
					}
				}
			}
			else
			{
				bool flag3 = !this.IsExpandedByIndex(selectedIndex);
				if (flag3)
				{
					this.ExpandItemByIndex(selectedIndex);
				}
			}
			bool flag4 = flag;
			if (flag4)
			{
				evt.StopPropagation();
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0003902C File Offset: 0x0003722C
		public void SetSelection(int id)
		{
			this.SetSelection(new int[]
			{
				id
			});
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00039040 File Offset: 0x00037240
		public void SetSelection(IEnumerable<int> ids)
		{
			this.SetSelectionInternal(ids, true);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0003904C File Offset: 0x0003724C
		public void SetSelectionWithoutNotify(IEnumerable<int> ids)
		{
			this.SetSelectionInternal(ids, false);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00039058 File Offset: 0x00037258
		internal void SetSelectionInternal(IEnumerable<int> ids, bool sendNotification)
		{
			bool flag = ids == null;
			if (!flag)
			{
				List<int> indices = (from id in ids
				select this.GetItemIndex(id, true)).ToList<int>();
				this.ListViewRefresh();
				this.m_ListView.SetSelectionInternal(indices, sendNotification);
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000390A0 File Offset: 0x000372A0
		internal void SetSelectionByIndices(IEnumerable<int> indexes, bool sendNotification)
		{
			bool flag = indexes == null;
			if (!flag)
			{
				this.ListViewRefresh();
				this.m_ListView.SetSelectionInternal(indexes, sendNotification);
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000390D0 File Offset: 0x000372D0
		public void AddToSelection(int id)
		{
			int itemIndex = this.GetItemIndex(id, true);
			this.ListViewRefresh();
			this.m_ListView.AddToSelection(itemIndex);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000390FC File Offset: 0x000372FC
		public void RemoveFromSelection(int id)
		{
			int itemIndex = this.GetItemIndex(id, false);
			this.m_ListView.RemoveFromSelection(itemIndex);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00039120 File Offset: 0x00037320
		internal int GetItemIndex(int id, bool expand = false)
		{
			ITreeViewItem treeViewItem = this.FindItem(id);
			bool flag = treeViewItem == null;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("id", id, "InternalTreeView: Item id not found.");
			}
			if (expand)
			{
				bool flag2 = false;
				for (ITreeViewItem parent = treeViewItem.parent; parent != null; parent = parent.parent)
				{
					bool flag3 = !this.m_ExpandedItemIds.Contains(parent.id);
					if (flag3)
					{
						this.m_ExpandedItemIds.Add(parent.id);
						flag2 = true;
					}
				}
				bool flag4 = flag2;
				if (flag4)
				{
					this.RegenerateWrappers();
				}
			}
			int i;
			for (i = 0; i < this.m_ItemWrappers.Count; i++)
			{
				bool flag5 = this.m_ItemWrappers[i].id == id;
				if (flag5)
				{
					break;
				}
			}
			return i;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00039203 File Offset: 0x00037403
		public void ClearSelection()
		{
			this.m_ListView.ClearSelection();
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00039212 File Offset: 0x00037412
		public void ScrollTo(VisualElement visualElement)
		{
			this.m_ListView.ScrollTo(visualElement);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00039224 File Offset: 0x00037424
		public void ScrollToItem(int id)
		{
			int itemIndex = this.GetItemIndex(id, true);
			this.RefreshItems();
			this.m_ListView.ScrollToItem(itemIndex);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00039250 File Offset: 0x00037450
		internal void CopyExpandedStates(ITreeViewItem source, ITreeViewItem target)
		{
			bool flag = this.IsExpanded(source.id);
			if (flag)
			{
				this.ExpandItem(target.id);
				bool flag2 = source.children != null && source.children.Count<ITreeViewItem>() > 0;
				if (flag2)
				{
					bool flag3 = target.children == null || source.children.Count<ITreeViewItem>() != target.children.Count<ITreeViewItem>();
					if (flag3)
					{
						Debug.LogWarning("Source and target hierarchies are not the same");
					}
					else
					{
						for (int i = 0; i < source.children.Count<ITreeViewItem>(); i++)
						{
							ITreeViewItem source2 = source.children.ElementAt(i);
							ITreeViewItem target2 = target.children.ElementAt(i);
							this.CopyExpandedStates(source2, target2);
						}
					}
				}
			}
			else
			{
				this.CollapseItem(target.id);
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00039330 File Offset: 0x00037530
		public bool IsExpanded(int id)
		{
			return this.m_ExpandedItemIds.Contains(id);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00039350 File Offset: 0x00037550
		public void CollapseItem(int id)
		{
			bool flag = this.FindItem(id) == null;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("id", id, "InternalTreeView: Item id not found.");
			}
			for (int i = 0; i < this.m_ItemWrappers.Count; i++)
			{
				bool flag2 = this.m_ItemWrappers[i].item.id == id;
				if (flag2)
				{
					bool flag3 = this.IsExpandedByIndex(i);
					if (flag3)
					{
						this.CollapseItemByIndex(i);
						return;
					}
				}
			}
			bool flag4 = !this.m_ExpandedItemIds.Contains(id);
			if (flag4)
			{
				return;
			}
			this.m_ExpandedItemIds.Remove(id);
			this.RefreshItems();
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000393FC File Offset: 0x000375FC
		public void ExpandItem(int id)
		{
			bool flag = this.FindItem(id) == null;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("id", id, "InternalTreeView: Item id not found.");
			}
			for (int i = 0; i < this.m_ItemWrappers.Count; i++)
			{
				bool flag2 = this.m_ItemWrappers[i].item.id == id;
				if (flag2)
				{
					bool flag3 = !this.IsExpandedByIndex(i);
					if (flag3)
					{
						this.ExpandItemByIndex(i);
						return;
					}
				}
			}
			bool flag4 = this.m_ExpandedItemIds.Contains(id);
			if (flag4)
			{
				return;
			}
			this.m_ExpandedItemIds.Add(id);
			this.RefreshItems();
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000394A8 File Offset: 0x000376A8
		public ITreeViewItem FindItem(int id)
		{
			foreach (ITreeViewItem treeViewItem in this.items)
			{
				bool flag = treeViewItem.id == id;
				if (flag)
				{
					return treeViewItem;
				}
			}
			return null;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00039508 File Offset: 0x00037708
		private void ListViewRefresh()
		{
			this.m_ListView.RefreshItems();
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00039518 File Offset: 0x00037718
		private void OnItemsChosen(IEnumerable<object> chosenItems)
		{
			bool flag = this.onItemsChosen == null;
			if (!flag)
			{
				List<ITreeViewItem> list = new List<ITreeViewItem>();
				foreach (object obj in chosenItems)
				{
					InternalTreeView.TreeViewItemWrapper treeViewItemWrapper = (InternalTreeView.TreeViewItemWrapper)obj;
					list.Add(treeViewItemWrapper.item);
				}
				this.onItemsChosen(list);
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00039598 File Offset: 0x00037798
		private void OnSelectionChange(IEnumerable<object> selectedListItems)
		{
			bool flag = this.m_SelectedItems == null;
			if (flag)
			{
				this.m_SelectedItems = new List<ITreeViewItem>();
			}
			this.m_SelectedItems.Clear();
			foreach (object obj in selectedListItems)
			{
				this.m_SelectedItems.Add(((InternalTreeView.TreeViewItemWrapper)obj).item);
			}
			Action<IEnumerable<ITreeViewItem>> action = this.onSelectionChange;
			if (action != null)
			{
				action(this.m_SelectedItems);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00039630 File Offset: 0x00037830
		private void OnTreeViewMouseUp(MouseUpEvent evt)
		{
			this.m_ScrollView.contentContainer.Focus();
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00039644 File Offset: 0x00037844
		private void OnItemMouseUp(MouseUpEvent evt)
		{
			bool flag = (evt.modifiers & EventModifiers.Alt) == EventModifiers.None;
			if (!flag)
			{
				VisualElement e = evt.currentTarget as VisualElement;
				Toggle toggle = e.Q(InternalTreeView.s_ItemToggleName, null);
				int index = (int)toggle.userData;
				ITreeViewItem item = this.m_ItemWrappers[index].item;
				bool flag2 = this.IsExpandedByIndex(index);
				bool flag3 = !item.hasChildren;
				if (!flag3)
				{
					HashSet<int> hashSet = new HashSet<int>(this.m_ExpandedItemIds);
					bool flag4 = flag2;
					if (flag4)
					{
						hashSet.Remove(item.id);
					}
					else
					{
						hashSet.Add(item.id);
					}
					foreach (ITreeViewItem treeViewItem in InternalTreeView.GetAllItems(item.children))
					{
						bool hasChildren = treeViewItem.hasChildren;
						if (hasChildren)
						{
							bool flag5 = flag2;
							if (flag5)
							{
								hashSet.Remove(treeViewItem.id);
							}
							else
							{
								hashSet.Add(treeViewItem.id);
							}
						}
					}
					this.m_ExpandedItemIds = hashSet.ToList<int>();
					this.RefreshItems();
					evt.StopPropagation();
				}
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0003978C File Offset: 0x0003798C
		private VisualElement MakeTreeItem()
		{
			VisualElement visualElement = new VisualElement
			{
				name = InternalTreeView.itemUssClassName,
				style = 
				{
					flexDirection = FlexDirection.Row
				}
			};
			visualElement.AddToClassList(InternalTreeView.itemUssClassName);
			visualElement.RegisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnItemMouseUp), TrickleDown.NoTrickleDown);
			VisualElement visualElement2 = new VisualElement
			{
				name = InternalTreeView.s_ItemIndentsContainerName,
				style = 
				{
					flexDirection = FlexDirection.Row
				}
			};
			visualElement2.AddToClassList(InternalTreeView.s_ItemIndentsContainerName);
			visualElement.hierarchy.Add(visualElement2);
			Toggle toggle = new Toggle
			{
				name = InternalTreeView.s_ItemToggleName
			};
			toggle.AddToClassList(Foldout.toggleUssClassName);
			toggle.RegisterValueChangedCallback(new EventCallback<ChangeEvent<bool>>(this.ToggleExpandedState));
			visualElement.hierarchy.Add(toggle);
			VisualElement visualElement3 = new VisualElement
			{
				name = InternalTreeView.s_ItemContentContainerName,
				style = 
				{
					flexGrow = 1f
				}
			};
			visualElement3.AddToClassList(InternalTreeView.s_ItemContentContainerName);
			visualElement.Add(visualElement3);
			bool flag = this.m_MakeItem != null;
			if (flag)
			{
				visualElement3.Add(this.m_MakeItem());
			}
			return visualElement;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000398C8 File Offset: 0x00037AC8
		private void UnbindTreeItem(VisualElement element, int index)
		{
			bool flag = this.unbindItem == null;
			if (!flag)
			{
				ITreeViewItem arg = (this.m_ItemWrappers.Count > index) ? this.m_ItemWrappers[index].item : null;
				VisualElement arg2 = element.Q(InternalTreeView.s_ItemContentContainerName, null).ElementAt(0);
				this.unbindItem(arg2, arg);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0003992C File Offset: 0x00037B2C
		private void BindTreeItem(VisualElement element, int index)
		{
			ITreeViewItem item = this.m_ItemWrappers[index].item;
			VisualElement visualElement = element.Q(InternalTreeView.s_ItemIndentsContainerName, null);
			visualElement.Clear();
			for (int i = 0; i < this.m_ItemWrappers[index].depth; i++)
			{
				VisualElement visualElement2 = new VisualElement();
				visualElement2.AddToClassList(InternalTreeView.s_ItemIndentName);
				visualElement.Add(visualElement2);
			}
			Toggle toggle = element.Q(InternalTreeView.s_ItemToggleName, null);
			toggle.SetValueWithoutNotify(this.IsExpandedByIndex(index));
			toggle.userData = index;
			bool hasChildren = item.hasChildren;
			if (hasChildren)
			{
				toggle.visible = true;
			}
			else
			{
				toggle.visible = false;
			}
			bool flag = this.m_BindItem == null;
			if (!flag)
			{
				VisualElement arg = element.Q(InternalTreeView.s_ItemContentContainerName, null).ElementAt(0);
				this.m_BindItem(arg, item);
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00039A20 File Offset: 0x00037C20
		internal int GetItemId(int index)
		{
			return this.m_ItemWrappers[index].id;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00039A48 File Offset: 0x00037C48
		private bool IsExpandedByIndex(int index)
		{
			return this.m_ExpandedItemIds.Contains(this.m_ItemWrappers[index].id);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00039A7C File Offset: 0x00037C7C
		private void CollapseItemByIndex(int index)
		{
			bool flag = !this.m_ItemWrappers[index].item.hasChildren;
			if (!flag)
			{
				this.m_ExpandedItemIds.Remove(this.m_ItemWrappers[index].item.id);
				int num = 0;
				int num2 = index + 1;
				int depth = this.m_ItemWrappers[index].depth;
				while (num2 < this.m_ItemWrappers.Count && this.m_ItemWrappers[num2].depth > depth)
				{
					num++;
					num2++;
				}
				this.m_ItemWrappers.RemoveRange(index + 1, num);
				this.ListViewRefresh();
				base.SaveViewData();
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00039B3C File Offset: 0x00037D3C
		private void ExpandItemByIndex(int index)
		{
			bool flag = !this.m_ItemWrappers[index].item.hasChildren;
			if (!flag)
			{
				List<InternalTreeView.TreeViewItemWrapper> collection = new List<InternalTreeView.TreeViewItemWrapper>();
				this.CreateWrappers(this.m_ItemWrappers[index].item.children, this.m_ItemWrappers[index].depth + 1, ref collection);
				this.m_ItemWrappers.InsertRange(index + 1, collection);
				this.m_ExpandedItemIds.Add(this.m_ItemWrappers[index].item.id);
				this.ListViewRefresh();
				base.SaveViewData();
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00039BE4 File Offset: 0x00037DE4
		private void ToggleExpandedState(ChangeEvent<bool> evt)
		{
			Toggle toggle = evt.target as Toggle;
			int index = (int)toggle.userData;
			bool flag = this.IsExpandedByIndex(index);
			Assert.AreNotEqual<bool>(flag, evt.newValue);
			bool flag2 = flag;
			if (flag2)
			{
				this.CollapseItemByIndex(index);
			}
			else
			{
				this.ExpandItemByIndex(index);
			}
			this.m_ScrollView.contentContainer.Focus();
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00039C48 File Offset: 0x00037E48
		private void CreateWrappers(IEnumerable<ITreeViewItem> treeViewItems, int depth, ref List<InternalTreeView.TreeViewItemWrapper> wrappers)
		{
			foreach (ITreeViewItem treeViewItem in treeViewItems)
			{
				InternalTreeView.TreeViewItemWrapper item = new InternalTreeView.TreeViewItemWrapper
				{
					depth = depth,
					item = treeViewItem
				};
				wrappers.Add(item);
				bool flag = this.m_ExpandedItemIds.Contains(treeViewItem.id) && treeViewItem.hasChildren;
				if (flag)
				{
					this.CreateWrappers(treeViewItem.children, depth + 1, ref wrappers);
				}
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00039CE4 File Offset: 0x00037EE4
		public void CollapseAll()
		{
			bool flag = this.m_ExpandedItemIds.Count == 0;
			if (!flag)
			{
				this.m_ExpandedItemIds.Clear();
				this.RegenerateWrappers();
				this.RefreshItems();
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00039D20 File Offset: 0x00037F20
		private void RegenerateWrappers()
		{
			this.m_ItemWrappers.Clear();
			bool flag = this.m_RootItems == null;
			if (!flag)
			{
				this.CreateWrappers(this.m_RootItems, 0, ref this.m_ItemWrappers);
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00039D60 File Offset: 0x00037F60
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			float fixedItemHeight = this.m_ListView.fixedItemHeight;
			int num;
			bool flag = !this.m_ListView.m_ItemHeightIsInline && e.customStyle.TryGetValue(BaseVerticalCollectionView.s_ItemHeightProperty, out num);
			if (flag)
			{
				this.m_ListView.m_FixedItemHeight = (float)num;
			}
			bool flag2 = this.m_ListView.m_FixedItemHeight != fixedItemHeight;
			if (flag2)
			{
				this.m_ListView.RefreshItems();
			}
		}

		// Token: 0x04000653 RID: 1619
		private static readonly string s_ListViewName = "unity-tree-view__list-view";

		// Token: 0x04000654 RID: 1620
		private static readonly string s_ItemToggleName = "unity-tree-view__item-toggle";

		// Token: 0x04000655 RID: 1621
		private static readonly string s_ItemIndentsContainerName = "unity-tree-view__item-indents";

		// Token: 0x04000656 RID: 1622
		private static readonly string s_ItemIndentName = "unity-tree-view__item-indent";

		// Token: 0x04000657 RID: 1623
		private static readonly string s_ItemContentContainerName = "unity-tree-view__item-content";

		// Token: 0x04000658 RID: 1624
		public static readonly string itemUssClassName = "unity-tree-view__item";

		// Token: 0x04000659 RID: 1625
		private Func<VisualElement> m_MakeItem;

		// Token: 0x0400065C RID: 1628
		private List<ITreeViewItem> m_SelectedItems;

		// Token: 0x0400065D RID: 1629
		private Action<VisualElement, ITreeViewItem> m_BindItem;

		// Token: 0x0400065F RID: 1631
		private IList<ITreeViewItem> m_RootItems;

		// Token: 0x04000660 RID: 1632
		[SerializeField]
		private List<int> m_ExpandedItemIds;

		// Token: 0x04000661 RID: 1633
		private List<InternalTreeView.TreeViewItemWrapper> m_ItemWrappers;

		// Token: 0x04000662 RID: 1634
		private readonly ListView m_ListView;

		// Token: 0x04000663 RID: 1635
		internal readonly ScrollView m_ScrollView;

		// Token: 0x0200019E RID: 414
		public new class UxmlFactory : UxmlFactory<InternalTreeView, InternalTreeView.UxmlTraits>
		{
		}

		// Token: 0x0200019F RID: 415
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x170002CF RID: 719
			// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00039E20 File Offset: 0x00038020
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get
				{
					yield break;
				}
			}

			// Token: 0x06000DC0 RID: 3520 RVA: 0x00039E40 File Offset: 0x00038040
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				int itemHeight = 0;
				bool flag = this.m_ItemHeight.TryGetValueFromBag(bag, cc, ref itemHeight);
				if (flag)
				{
					((InternalTreeView)ve).itemHeight = itemHeight;
				}
				((InternalTreeView)ve).showBorder = this.m_ShowBorder.GetValueFromBag(bag, cc);
				((InternalTreeView)ve).selectionType = this.m_SelectionType.GetValueFromBag(bag, cc);
				((InternalTreeView)ve).showAlternatingRowBackgrounds = this.m_ShowAlternatingRowBackgrounds.GetValueFromBag(bag, cc);
			}

			// Token: 0x04000664 RID: 1636
			private readonly UxmlIntAttributeDescription m_ItemHeight = new UxmlIntAttributeDescription
			{
				name = "item-height",
				defaultValue = BaseVerticalCollectionView.s_DefaultItemHeight
			};

			// Token: 0x04000665 RID: 1637
			private readonly UxmlBoolAttributeDescription m_ShowBorder = new UxmlBoolAttributeDescription
			{
				name = "show-border",
				defaultValue = false
			};

			// Token: 0x04000666 RID: 1638
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType = new UxmlEnumAttributeDescription<SelectionType>
			{
				name = "selection-type",
				defaultValue = SelectionType.Single
			};

			// Token: 0x04000667 RID: 1639
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds = new UxmlEnumAttributeDescription<AlternatingRowBackground>
			{
				name = "show-alternating-row-backgrounds",
				defaultValue = AlternatingRowBackground.None
			};
		}

		// Token: 0x020001A1 RID: 417
		private struct TreeViewItemWrapper
		{
			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00039FFC File Offset: 0x000381FC
			public int id
			{
				get
				{
					return this.item.id;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0003A009 File Offset: 0x00038209
			public bool hasChildren
			{
				get
				{
					return this.item.hasChildren;
				}
			}

			// Token: 0x0400066C RID: 1644
			public int depth;

			// Token: 0x0400066D RID: 1645
			public ITreeViewItem item;
		}
	}
}
