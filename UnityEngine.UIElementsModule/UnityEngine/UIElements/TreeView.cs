using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine.Assertions;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018D RID: 397
	internal class TreeView : VisualElement
	{
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x000356D0 File Offset: 0x000338D0
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x000356E8 File Offset: 0x000338E8
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

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000CD2 RID: 3282 RVA: 0x0003571C File Offset: 0x0003391C
		// (remove) Token: 0x06000CD3 RID: 3283 RVA: 0x00035754 File Offset: 0x00033954
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<IEnumerable<ITreeViewItem>> onItemsChosen;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000CD4 RID: 3284 RVA: 0x0003578C File Offset: 0x0003398C
		// (remove) Token: 0x06000CD5 RID: 3285 RVA: 0x000357C4 File Offset: 0x000339C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<IEnumerable<ITreeViewItem>> onSelectionChange;

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000357F9 File Offset: 0x000339F9
		public ITreeViewItem selectedItem
		{
			get
			{
				return (this.m_SelectedItems.Count == 0) ? null : this.m_SelectedItems.First<ITreeViewItem>();
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00035818 File Offset: 0x00033A18
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x000358F4 File Offset: 0x00033AF4
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x0003590C File Offset: 0x00033B0C
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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0003591D File Offset: 0x00033B1D
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00035925 File Offset: 0x00033B25
		public Action<VisualElement, ITreeViewItem> unbindItem { get; set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00035930 File Offset: 0x00033B30
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00035948 File Offset: 0x00033B48
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

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00035959 File Offset: 0x00033B59
		public IEnumerable<ITreeViewItem> items
		{
			get
			{
				return TreeView.GetAllItems(this.m_RootItems);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00035966 File Offset: 0x00033B66
		public float resolvedItemHeight
		{
			get
			{
				return this.m_ListView.ResolveItemHeight(-1f);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00035978 File Offset: 0x00033B78
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00035996 File Offset: 0x00033B96
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000359A8 File Offset: 0x00033BA8
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x000359C5 File Offset: 0x00033BC5
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000359D8 File Offset: 0x00033BD8
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x000359F5 File Offset: 0x00033BF5
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

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00035A08 File Offset: 0x00033C08
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00035A25 File Offset: 0x00033C25
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00035A38 File Offset: 0x00033C38
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00035A55 File Offset: 0x00033C55
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

		// Token: 0x06000CEA RID: 3306 RVA: 0x00035A68 File Offset: 0x00033C68
		public TreeView()
		{
			this.m_SelectedItems = null;
			this.m_ExpandedItemIds = new List<int>();
			this.m_ItemWrappers = new List<TreeView.TreeViewItemWrapper>();
			this.m_ListView = new ListView();
			this.m_ListView.name = TreeView.s_ListViewName;
			this.m_ListView.itemsSource = this.m_ItemWrappers;
			this.m_ListView.viewDataKey = TreeView.s_ListViewName;
			this.m_ListView.AddToClassList(TreeView.s_ListViewName);
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

		// Token: 0x06000CEB RID: 3307 RVA: 0x00035BE6 File Offset: 0x00033DE6
		public TreeView(IList<ITreeViewItem> items, int fixedItemHeight, Func<VisualElement> makeItem, Action<VisualElement, ITreeViewItem> bindItem) : this()
		{
			this.m_ListView.fixedItemHeight = (float)fixedItemHeight;
			this.m_MakeItem = makeItem;
			this.m_BindItem = bindItem;
			this.m_RootItems = items;
			this.Rebuild();
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00035C1B File Offset: 0x00033E1B
		public void RefreshItems()
		{
			this.RegenerateWrappers();
			this.ListViewRefresh();
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00035C2C File Offset: 0x00033E2C
		public void Rebuild()
		{
			this.RegenerateWrappers();
			this.m_ListView.Rebuild();
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00035C44 File Offset: 0x00033E44
		internal override void OnViewDataReady()
		{
			base.OnViewDataReady();
			string fullHierarchicalViewDataKey = base.GetFullHierarchicalViewDataKey();
			base.OverwriteFromViewData(this, fullHierarchicalViewDataKey);
			this.Rebuild();
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00035C70 File Offset: 0x00033E70
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

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00035C80 File Offset: 0x00033E80
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

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00035CFC File Offset: 0x00033EFC
		public void SetSelection(int id)
		{
			this.SetSelection(new int[]
			{
				id
			});
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00035D10 File Offset: 0x00033F10
		public void SetSelection(IEnumerable<int> ids)
		{
			this.SetSelectionInternal(ids, true);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00035D1C File Offset: 0x00033F1C
		public void SetSelectionWithoutNotify(IEnumerable<int> ids)
		{
			this.SetSelectionInternal(ids, false);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00035D28 File Offset: 0x00033F28
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

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00035D70 File Offset: 0x00033F70
		public void AddToSelection(int id)
		{
			int itemIndex = this.GetItemIndex(id, true);
			this.ListViewRefresh();
			this.m_ListView.AddToSelection(itemIndex);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00035D9C File Offset: 0x00033F9C
		public void RemoveFromSelection(int id)
		{
			int itemIndex = this.GetItemIndex(id, false);
			this.m_ListView.RemoveFromSelection(itemIndex);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00035DC0 File Offset: 0x00033FC0
		private int GetItemIndex(int id, bool expand = false)
		{
			ITreeViewItem treeViewItem = this.FindItem(id);
			bool flag = treeViewItem == null;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("id", id, "TreeView: Item id not found.");
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

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00035EA3 File Offset: 0x000340A3
		public void ClearSelection()
		{
			this.m_ListView.ClearSelection();
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00035EB2 File Offset: 0x000340B2
		public void ScrollTo(VisualElement visualElement)
		{
			this.m_ListView.ScrollTo(visualElement);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00035EC4 File Offset: 0x000340C4
		public void ScrollToItem(int id)
		{
			int itemIndex = this.GetItemIndex(id, true);
			this.RefreshItems();
			this.m_ListView.ScrollToItem(itemIndex);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00035EF0 File Offset: 0x000340F0
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

		// Token: 0x06000CFC RID: 3324 RVA: 0x00035FD0 File Offset: 0x000341D0
		public bool IsExpanded(int id)
		{
			return this.m_ExpandedItemIds.Contains(id);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00035FF0 File Offset: 0x000341F0
		public void CollapseItem(int id)
		{
			bool flag = this.FindItem(id) == null;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("id", id, "TreeView: Item id not found.");
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

		// Token: 0x06000CFE RID: 3326 RVA: 0x0003609C File Offset: 0x0003429C
		public void ExpandItem(int id)
		{
			bool flag = this.FindItem(id) == null;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("id", id, "TreeView: Item id not found.");
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

		// Token: 0x06000CFF RID: 3327 RVA: 0x00036148 File Offset: 0x00034348
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

		// Token: 0x06000D00 RID: 3328 RVA: 0x000361A8 File Offset: 0x000343A8
		private void ListViewRefresh()
		{
			this.m_ListView.RefreshItems();
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000361B8 File Offset: 0x000343B8
		private void OnItemsChosen(IEnumerable<object> chosenItems)
		{
			bool flag = this.onItemsChosen == null;
			if (!flag)
			{
				List<ITreeViewItem> list = new List<ITreeViewItem>();
				foreach (object obj in chosenItems)
				{
					TreeView.TreeViewItemWrapper treeViewItemWrapper = (TreeView.TreeViewItemWrapper)obj;
					list.Add(treeViewItemWrapper.item);
				}
				this.onItemsChosen(list);
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00036238 File Offset: 0x00034438
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
				this.m_SelectedItems.Add(((TreeView.TreeViewItemWrapper)obj).item);
			}
			Action<IEnumerable<ITreeViewItem>> action = this.onSelectionChange;
			if (action != null)
			{
				action(this.m_SelectedItems);
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000362D0 File Offset: 0x000344D0
		private void OnTreeViewMouseUp(MouseUpEvent evt)
		{
			this.m_ScrollView.contentContainer.Focus();
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000362E4 File Offset: 0x000344E4
		private void OnItemMouseUp(MouseUpEvent evt)
		{
			bool flag = (evt.modifiers & EventModifiers.Alt) == EventModifiers.None;
			if (!flag)
			{
				VisualElement e = evt.currentTarget as VisualElement;
				Toggle toggle = e.Q(TreeView.s_ItemToggleName, null);
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
					foreach (ITreeViewItem treeViewItem in TreeView.GetAllItems(item.children))
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

		// Token: 0x06000D05 RID: 3333 RVA: 0x0003642C File Offset: 0x0003462C
		private VisualElement MakeTreeItem()
		{
			VisualElement visualElement = new VisualElement
			{
				name = TreeView.s_ItemName,
				style = 
				{
					flexDirection = FlexDirection.Row
				}
			};
			visualElement.AddToClassList(TreeView.s_ItemName);
			visualElement.RegisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnItemMouseUp), TrickleDown.NoTrickleDown);
			VisualElement visualElement2 = new VisualElement
			{
				name = TreeView.s_ItemIndentsContainerName,
				style = 
				{
					flexDirection = FlexDirection.Row
				}
			};
			visualElement2.AddToClassList(TreeView.s_ItemIndentsContainerName);
			visualElement.hierarchy.Add(visualElement2);
			Toggle toggle = new Toggle
			{
				name = TreeView.s_ItemToggleName
			};
			toggle.AddToClassList(Foldout.toggleUssClassName);
			toggle.RegisterValueChangedCallback(new EventCallback<ChangeEvent<bool>>(this.ToggleExpandedState));
			visualElement.hierarchy.Add(toggle);
			VisualElement visualElement3 = new VisualElement
			{
				name = TreeView.s_ItemContentContainerName,
				style = 
				{
					flexGrow = 1f
				}
			};
			visualElement3.AddToClassList(TreeView.s_ItemContentContainerName);
			visualElement.Add(visualElement3);
			bool flag = this.m_MakeItem != null;
			if (flag)
			{
				visualElement3.Add(this.m_MakeItem());
			}
			return visualElement;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00036568 File Offset: 0x00034768
		private void UnbindTreeItem(VisualElement element, int index)
		{
			bool flag = this.unbindItem == null;
			if (!flag)
			{
				ITreeViewItem item = this.m_ItemWrappers[index].item;
				VisualElement arg = element.Q(TreeView.s_ItemContentContainerName, null).ElementAt(0);
				this.unbindItem(arg, item);
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000365B8 File Offset: 0x000347B8
		private void BindTreeItem(VisualElement element, int index)
		{
			ITreeViewItem item = this.m_ItemWrappers[index].item;
			VisualElement visualElement = element.Q(TreeView.s_ItemIndentsContainerName, null);
			visualElement.Clear();
			for (int i = 0; i < this.m_ItemWrappers[index].depth; i++)
			{
				VisualElement visualElement2 = new VisualElement();
				visualElement2.AddToClassList(TreeView.s_ItemIndentName);
				visualElement.Add(visualElement2);
			}
			Toggle toggle = element.Q(TreeView.s_ItemToggleName, null);
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
				VisualElement arg = element.Q(TreeView.s_ItemContentContainerName, null).ElementAt(0);
				this.m_BindItem(arg, item);
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x000366AC File Offset: 0x000348AC
		private int GetItemId(int index)
		{
			return this.m_ItemWrappers[index].id;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x000366D4 File Offset: 0x000348D4
		private bool IsExpandedByIndex(int index)
		{
			return this.m_ExpandedItemIds.Contains(this.m_ItemWrappers[index].id);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00036708 File Offset: 0x00034908
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

		// Token: 0x06000D0B RID: 3339 RVA: 0x000367C8 File Offset: 0x000349C8
		private void ExpandItemByIndex(int index)
		{
			bool flag = !this.m_ItemWrappers[index].item.hasChildren;
			if (!flag)
			{
				List<TreeView.TreeViewItemWrapper> collection = new List<TreeView.TreeViewItemWrapper>();
				this.CreateWrappers(this.m_ItemWrappers[index].item.children, this.m_ItemWrappers[index].depth + 1, ref collection);
				this.m_ItemWrappers.InsertRange(index + 1, collection);
				this.m_ExpandedItemIds.Add(this.m_ItemWrappers[index].item.id);
				this.ListViewRefresh();
				base.SaveViewData();
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00036870 File Offset: 0x00034A70
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

		// Token: 0x06000D0D RID: 3341 RVA: 0x000368D4 File Offset: 0x00034AD4
		private void CreateWrappers(IEnumerable<ITreeViewItem> treeViewItems, int depth, ref List<TreeView.TreeViewItemWrapper> wrappers)
		{
			foreach (ITreeViewItem treeViewItem in treeViewItems)
			{
				TreeView.TreeViewItemWrapper item = new TreeView.TreeViewItemWrapper
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

		// Token: 0x06000D0E RID: 3342 RVA: 0x00036970 File Offset: 0x00034B70
		private void RegenerateWrappers()
		{
			this.m_ItemWrappers.Clear();
			bool flag = this.m_RootItems == null;
			if (!flag)
			{
				this.CreateWrappers(this.m_RootItems, 0, ref this.m_ItemWrappers);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x000369B0 File Offset: 0x00034BB0
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

		// Token: 0x040005FC RID: 1532
		private static readonly string s_ListViewName = "unity-tree-view__list-view";

		// Token: 0x040005FD RID: 1533
		private static readonly string s_ItemName = "unity-tree-view__item";

		// Token: 0x040005FE RID: 1534
		private static readonly string s_ItemToggleName = "unity-tree-view__item-toggle";

		// Token: 0x040005FF RID: 1535
		private static readonly string s_ItemIndentsContainerName = "unity-tree-view__item-indents";

		// Token: 0x04000600 RID: 1536
		private static readonly string s_ItemIndentName = "unity-tree-view__item-indent";

		// Token: 0x04000601 RID: 1537
		private static readonly string s_ItemContentContainerName = "unity-tree-view__item-content";

		// Token: 0x04000602 RID: 1538
		private Func<VisualElement> m_MakeItem;

		// Token: 0x04000605 RID: 1541
		private List<ITreeViewItem> m_SelectedItems;

		// Token: 0x04000606 RID: 1542
		private Action<VisualElement, ITreeViewItem> m_BindItem;

		// Token: 0x04000608 RID: 1544
		private IList<ITreeViewItem> m_RootItems;

		// Token: 0x04000609 RID: 1545
		[SerializeField]
		private List<int> m_ExpandedItemIds;

		// Token: 0x0400060A RID: 1546
		private List<TreeView.TreeViewItemWrapper> m_ItemWrappers;

		// Token: 0x0400060B RID: 1547
		private readonly ListView m_ListView;

		// Token: 0x0400060C RID: 1548
		private readonly ScrollView m_ScrollView;

		// Token: 0x0200018E RID: 398
		public new class UxmlFactory : UxmlFactory<TreeView, TreeView.UxmlTraits>
		{
		}

		// Token: 0x0200018F RID: 399
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00036A70 File Offset: 0x00034C70
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get
				{
					yield break;
				}
			}

			// Token: 0x06000D14 RID: 3348 RVA: 0x00036A90 File Offset: 0x00034C90
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				int itemHeight = 0;
				bool flag = this.m_ItemHeight.TryGetValueFromBag(bag, cc, ref itemHeight);
				if (flag)
				{
					((TreeView)ve).itemHeight = itemHeight;
				}
				((TreeView)ve).showBorder = this.m_ShowBorder.GetValueFromBag(bag, cc);
				((TreeView)ve).selectionType = this.m_SelectionType.GetValueFromBag(bag, cc);
				((TreeView)ve).showAlternatingRowBackgrounds = this.m_ShowAlternatingRowBackgrounds.GetValueFromBag(bag, cc);
			}

			// Token: 0x0400060D RID: 1549
			private readonly UxmlIntAttributeDescription m_ItemHeight = new UxmlIntAttributeDescription
			{
				name = "item-height",
				defaultValue = BaseVerticalCollectionView.s_DefaultItemHeight
			};

			// Token: 0x0400060E RID: 1550
			private readonly UxmlBoolAttributeDescription m_ShowBorder = new UxmlBoolAttributeDescription
			{
				name = "show-border",
				defaultValue = false
			};

			// Token: 0x0400060F RID: 1551
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType = new UxmlEnumAttributeDescription<SelectionType>
			{
				name = "selection-type",
				defaultValue = SelectionType.Single
			};

			// Token: 0x04000610 RID: 1552
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds = new UxmlEnumAttributeDescription<AlternatingRowBackground>
			{
				name = "show-alternating-row-backgrounds",
				defaultValue = AlternatingRowBackground.None
			};
		}

		// Token: 0x02000191 RID: 401
		private struct TreeViewItemWrapper
		{
			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00036C4C File Offset: 0x00034E4C
			public int id
			{
				get
				{
					return this.item.id;
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00036C59 File Offset: 0x00034E59
			public bool hasChildren
			{
				get
				{
					return this.item.hasChildren;
				}
			}

			// Token: 0x04000615 RID: 1557
			public int depth;

			// Token: 0x04000616 RID: 1558
			public ITreeViewItem item;
		}
	}
}
