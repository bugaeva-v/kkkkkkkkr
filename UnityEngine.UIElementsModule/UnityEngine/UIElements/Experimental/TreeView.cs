using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x0200038D RID: 909
	internal class TreeView : BaseVerticalCollectionView
	{
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0008A951 File Offset: 0x00088B51
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x000267EA File Offset: 0x000249EA
		public new IList itemsSource
		{
			get
			{
				return this.viewController.itemsSource;
			}
			internal set
			{
				base.GetOrCreateViewController().itemsSource = value;
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0008A960 File Offset: 0x00088B60
		public void SetRootItems<T>(IList<TreeViewItemData<T>> rootItems)
		{
			DefaultTreeViewController<T> defaultTreeViewController = base.viewController as DefaultTreeViewController<T>;
			bool flag = defaultTreeViewController != null;
			if (flag)
			{
				defaultTreeViewController.SetRootItems(rootItems);
			}
			else
			{
				DefaultTreeViewController<T> defaultTreeViewController2 = new DefaultTreeViewController<T>();
				this.SetViewController(defaultTreeViewController2);
				defaultTreeViewController2.SetRootItems(rootItems);
			}
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0008A9A8 File Offset: 0x00088BA8
		public IEnumerable<int> GetRootIds()
		{
			return this.viewController.GetRootItemIds();
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0008A9C8 File Offset: 0x00088BC8
		public int GetTreeCount()
		{
			return this.viewController.GetTreeCount();
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0008A9E5 File Offset: 0x00088BE5
		internal new TreeViewController viewController
		{
			get
			{
				return base.viewController as TreeViewController;
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x0008A9F2 File Offset: 0x00088BF2
		private protected override void CreateVirtualizationController()
		{
			base.CreateVirtualizationController<ReusableTreeViewItem>();
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0008A9FC File Offset: 0x00088BFC
		private protected override void CreateViewController()
		{
			this.SetViewController(new DefaultTreeViewController<object>());
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0008AA0C File Offset: 0x00088C0C
		internal void SetViewController(TreeViewController controller)
		{
			bool flag = this.viewController != null;
			if (flag)
			{
				controller.itemIndexChanged -= this.OnItemIndexChanged;
			}
			base.SetViewController(controller);
			bool flag2 = controller != null;
			if (flag2)
			{
				controller.itemIndexChanged += this.OnItemIndexChanged;
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0002844B File Offset: 0x0002664B
		private void OnItemIndexChanged(int srcIndex, int dstIndex)
		{
			base.RefreshItems();
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0008AA61 File Offset: 0x00088C61
		internal override ICollectionDragAndDropController CreateDragAndDropController()
		{
			return new TreeViewReorderableDragAndDropController(this);
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0008AA69 File Offset: 0x00088C69
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0008AA71 File Offset: 0x00088C71
		public bool autoExpand
		{
			get
			{
				return this.m_AutoExpand;
			}
			set
			{
				this.m_AutoExpand = value;
				TreeViewController viewController = this.viewController;
				if (viewController != null)
				{
					viewController.RegenerateWrappers();
				}
				base.RefreshItems();
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0008AA94 File Offset: 0x00088C94
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0008AA9C File Offset: 0x00088C9C
		internal List<int> expandedItemIds
		{
			get
			{
				return this.m_ExpandedItemIds;
			}
			set
			{
				this.m_ExpandedItemIds = value;
			}
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0008AAA8 File Offset: 0x00088CA8
		public TreeView()
		{
			this.m_ExpandedItemIds = new List<int>();
			base.name = TreeView.ussClassName;
			base.viewDataKey = TreeView.ussClassName;
			base.AddToClassList(TreeView.ussClassName);
			base.scrollView.contentContainer.RegisterCallback<KeyDownEvent>(new EventCallback<KeyDownEvent>(this.OnScrollViewKeyDown), TrickleDown.NoTrickleDown);
			base.RegisterCallback<MouseUpEvent>(new EventCallback<MouseUpEvent>(this.OnTreeViewMouseUp), TrickleDown.TrickleDown);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0008AB20 File Offset: 0x00088D20
		public int GetIdForIndex(int index)
		{
			return this.viewController.GetIdForIndex(index);
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0008AB40 File Offset: 0x00088D40
		public int GetParentIdForIndex(int index)
		{
			return this.viewController.GetParentId(this.GetIdForIndex(index));
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0008AB64 File Offset: 0x00088D64
		public IEnumerable<int> GetChildrenIdsForIndex(int index)
		{
			return this.viewController.GetChildrenIdsByIndex(index);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0008AB84 File Offset: 0x00088D84
		public T GetItemDataForIndex<T>(int index)
		{
			DefaultTreeViewController<T> defaultTreeViewController = this.viewController as DefaultTreeViewController<T>;
			bool flag = defaultTreeViewController != null;
			T result;
			if (flag)
			{
				result = defaultTreeViewController.GetDataForIndex(index);
			}
			else
			{
				TreeViewController viewController = this.viewController;
				object obj = (viewController != null) ? viewController.GetItemForIndex(index) : null;
				Type type = (obj != null) ? obj.GetType() : null;
				bool flag2 = type == typeof(T);
				if (!flag2)
				{
					bool flag3;
					if (type == null)
					{
						TreeViewController viewController2 = this.viewController;
						flag3 = (((viewController2 != null) ? viewController2.GetType().GetGenericTypeDefinition() : null) == typeof(DefaultTreeViewController<>));
					}
					else
					{
						flag3 = false;
					}
					bool flag4 = flag3;
					if (flag4)
					{
						type = this.viewController.GetType().GetGenericArguments()[0];
					}
					throw new ArgumentException(string.Format("Type parameter ({0}) differs from data source ({1}) and is not recognized by the controller.", typeof(T), type));
				}
				result = (T)((object)obj);
			}
			return result;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0008AC54 File Offset: 0x00088E54
		public T GetItemDataForId<T>(int id)
		{
			DefaultTreeViewController<T> defaultTreeViewController = this.viewController as DefaultTreeViewController<T>;
			bool flag = defaultTreeViewController != null;
			T result;
			if (flag)
			{
				result = defaultTreeViewController.GetDataForId(id);
			}
			else
			{
				TreeViewController viewController = this.viewController;
				object obj = (viewController != null) ? viewController.GetItemForIndex(this.viewController.GetIndexForId(id)) : null;
				Type type = (obj != null) ? obj.GetType() : null;
				bool flag2 = type == typeof(T);
				if (!flag2)
				{
					bool flag3;
					if (type == null)
					{
						TreeViewController viewController2 = this.viewController;
						flag3 = (((viewController2 != null) ? viewController2.GetType().GetGenericTypeDefinition() : null) == typeof(DefaultTreeViewController<>));
					}
					else
					{
						flag3 = false;
					}
					bool flag4 = flag3;
					if (flag4)
					{
						type = this.viewController.GetType().GetGenericArguments()[0];
					}
					throw new ArgumentException(string.Format("Type parameter ({0}) differs from data source ({1}) and is not recognized by the controller.", typeof(T), type));
				}
				result = (T)((object)obj);
			}
			return result;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0008AD30 File Offset: 0x00088F30
		public void AddItem<T>(TreeViewItemData<T> item, int parentId = -1, int childIndex = -1, bool rebuildTree = true)
		{
			DefaultTreeViewController<T> defaultTreeViewController = this.viewController as DefaultTreeViewController<T>;
			bool flag = defaultTreeViewController != null;
			if (flag)
			{
				defaultTreeViewController.AddItem(item, parentId, childIndex, rebuildTree);
				if (rebuildTree)
				{
					base.RefreshItems();
				}
				return;
			}
			Type arg = null;
			TreeViewController viewController = this.viewController;
			bool flag2 = ((viewController != null) ? viewController.GetType().GetGenericTypeDefinition() : null) == typeof(DefaultTreeViewController<>);
			if (flag2)
			{
				arg = this.viewController.GetType().GetGenericArguments()[0];
			}
			throw new ArgumentException(string.Format("Type parameter ({0}) differs from data source ({1})and is not recognized by the controller.", typeof(T), arg));
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0008ADCC File Offset: 0x00088FCC
		public bool TryRemoveItem(int id)
		{
			bool flag = this.viewController.TryRemoveItem(id, true);
			bool result;
			if (flag)
			{
				base.RefreshItems();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0008ADFC File Offset: 0x00088FFC
		internal override void OnViewDataReady()
		{
			base.OnViewDataReady();
			bool flag = this.viewController != null;
			if (flag)
			{
				this.viewController.RebuildTree();
				base.RefreshItems();
			}
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0008AE34 File Offset: 0x00089034
		private void OnScrollViewKeyDown(KeyDownEvent evt)
		{
			int selectedIndex = base.selectedIndex;
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
					bool flag2 = evt.altKey || this.IsExpandedByIndex(selectedIndex);
					if (flag2)
					{
						this.CollapseItemByIndex(selectedIndex, evt.altKey);
					}
				}
			}
			else
			{
				bool flag3 = evt.altKey || !this.IsExpandedByIndex(selectedIndex);
				if (flag3)
				{
					this.ExpandItemByIndex(selectedIndex, evt.altKey);
				}
			}
			bool flag4 = flag;
			if (flag4)
			{
				evt.StopPropagation();
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0008AECD File Offset: 0x000890CD
		public void SetSelectionById(int id)
		{
			this.SetSelectionById(new int[]
			{
				id
			});
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x0008AEE1 File Offset: 0x000890E1
		public void SetSelectionById(IEnumerable<int> ids)
		{
			this.SetSelectionInternalById(ids, true);
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0008AEED File Offset: 0x000890ED
		public void SetSelectionByIdWithoutNotify(IEnumerable<int> ids)
		{
			this.SetSelectionInternalById(ids, false);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0008AEFC File Offset: 0x000890FC
		internal void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification)
		{
			bool flag = ids == null;
			if (!flag)
			{
				List<int> indices = ids.Select(delegate(int id)
				{
					this.viewController.ExpandItem(id, false, true);
					return this.viewController.GetIndexForId(id);
				}).ToList<int>();
				base.SetSelectionInternal(indices, sendNotification);
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0008AF38 File Offset: 0x00089138
		internal void CopyExpandedStates(ITreeViewItem source, ITreeViewItem target)
		{
			bool flag = this.IsExpanded(source.id);
			if (flag)
			{
				this.ExpandItem(target.id, false);
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
				this.CollapseItem(target.id, false);
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0008B018 File Offset: 0x00089218
		public bool IsExpanded(int id)
		{
			return this.viewController.IsExpanded(id);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0008B036 File Offset: 0x00089236
		public void CollapseItem(int id, bool collapseAllChildren = false)
		{
			this.viewController.CollapseItem(id, collapseAllChildren);
			base.RefreshItems();
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0008B04E File Offset: 0x0008924E
		public void ExpandItem(int id, bool expandAllChildren = false)
		{
			this.viewController.ExpandItem(id, expandAllChildren, true);
			base.RefreshItems();
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0008B068 File Offset: 0x00089268
		public void ExpandRootItems()
		{
			foreach (int id in this.viewController.GetRootItemIds())
			{
				this.viewController.ExpandItem(id, false, true);
			}
			base.RefreshItems();
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0008B0CC File Offset: 0x000892CC
		public void ExpandAll()
		{
			this.viewController.ExpandAll();
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x0008B0DB File Offset: 0x000892DB
		public void CollapseAll()
		{
			this.viewController.CollapseAll();
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0008B0EA File Offset: 0x000892EA
		private void OnTreeViewMouseUp(MouseUpEvent evt)
		{
			base.scrollView.contentContainer.Focus();
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0008B100 File Offset: 0x00089300
		private bool IsExpandedByIndex(int index)
		{
			return this.viewController.IsExpandedByIndex(index);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0008B120 File Offset: 0x00089320
		private void CollapseItemByIndex(int index, bool collapseAll)
		{
			bool flag = !this.viewController.HasChildrenByIndex(index);
			if (!flag)
			{
				this.viewController.CollapseItemByIndex(index, collapseAll);
				base.RefreshItems();
				base.SaveViewData();
			}
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0008B160 File Offset: 0x00089360
		private void ExpandItemByIndex(int index, bool expandAll)
		{
			bool flag = !this.viewController.HasChildrenByIndex(index);
			if (!flag)
			{
				this.viewController.ExpandItemByIndex(index, expandAll, true);
				base.RefreshItems();
				base.SaveViewData();
			}
		}

		// Token: 0x04000EB3 RID: 3763
		public new static readonly string ussClassName = "unity-tree-view";

		// Token: 0x04000EB4 RID: 3764
		public new static readonly string itemUssClassName = TreeView.ussClassName + "__item";

		// Token: 0x04000EB5 RID: 3765
		public static readonly string itemToggleUssClassName = TreeView.ussClassName + "__item-toggle";

		// Token: 0x04000EB6 RID: 3766
		public static readonly string itemIndentsContainerUssClassName = TreeView.ussClassName + "__item-indents";

		// Token: 0x04000EB7 RID: 3767
		public static readonly string itemIndentUssClassName = TreeView.ussClassName + "__item-indent";

		// Token: 0x04000EB8 RID: 3768
		public static readonly string itemContentContainerUssClassName = TreeView.ussClassName + "__item-content";

		// Token: 0x04000EB9 RID: 3769
		private bool m_AutoExpand;

		// Token: 0x04000EBA RID: 3770
		[SerializeField]
		private List<int> m_ExpandedItemIds;

		// Token: 0x0200038E RID: 910
		public new class UxmlFactory : UxmlFactory<TreeView, TreeView.UxmlTraits>
		{
		}

		// Token: 0x0200038F RID: 911
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0008B254 File Offset: 0x00089454
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get
				{
					yield break;
				}
			}

			// Token: 0x06001D9F RID: 7583 RVA: 0x0008B274 File Offset: 0x00089474
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				int num = 0;
				bool flag = this.m_FixedItemHeight.TryGetValueFromBag(bag, cc, ref num);
				if (flag)
				{
					((TreeView)ve).fixedItemHeight = (float)num;
				}
				((TreeView)ve).virtualizationMethod = this.m_VirtualizationMethod.GetValueFromBag(bag, cc);
				((TreeView)ve).autoExpand = this.m_AutoExpand.GetValueFromBag(bag, cc);
				((TreeView)ve).showBorder = this.m_ShowBorder.GetValueFromBag(bag, cc);
				((TreeView)ve).selectionType = this.m_SelectionType.GetValueFromBag(bag, cc);
				((TreeView)ve).showAlternatingRowBackgrounds = this.m_ShowAlternatingRowBackgrounds.GetValueFromBag(bag, cc);
			}

			// Token: 0x04000EBB RID: 3771
			private readonly UxmlIntAttributeDescription m_FixedItemHeight = new UxmlIntAttributeDescription
			{
				name = "fixed-item-height",
				obsoleteNames = new string[]
				{
					"item-height"
				},
				defaultValue = BaseVerticalCollectionView.s_DefaultItemHeight
			};

			// Token: 0x04000EBC RID: 3772
			private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod = new UxmlEnumAttributeDescription<CollectionVirtualizationMethod>
			{
				name = "virtualization-method",
				defaultValue = CollectionVirtualizationMethod.FixedHeight
			};

			// Token: 0x04000EBD RID: 3773
			private readonly UxmlBoolAttributeDescription m_ShowBorder = new UxmlBoolAttributeDescription
			{
				name = "show-border",
				defaultValue = false
			};

			// Token: 0x04000EBE RID: 3774
			private readonly UxmlBoolAttributeDescription m_AutoExpand = new UxmlBoolAttributeDescription
			{
				name = "auto-expand",
				defaultValue = false
			};

			// Token: 0x04000EBF RID: 3775
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType = new UxmlEnumAttributeDescription<SelectionType>
			{
				name = "selection-type",
				defaultValue = SelectionType.Single
			};

			// Token: 0x04000EC0 RID: 3776
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds = new UxmlEnumAttributeDescription<AlternatingRowBackground>
			{
				name = "show-alternating-row-backgrounds",
				defaultValue = AlternatingRowBackground.None
			};
		}
	}
}
