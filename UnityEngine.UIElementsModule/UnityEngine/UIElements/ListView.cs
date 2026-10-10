using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnityEngine.UIElements
{
	// Token: 0x02000152 RID: 338
	public class ListView : BaseVerticalCollectionView
	{
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002C405 File Offset: 0x0002A605
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x0002C410 File Offset: 0x0002A610
		public bool showBoundCollectionSize
		{
			get
			{
				return this.m_ShowBoundCollectionSize;
			}
			set
			{
				bool flag = this.m_ShowBoundCollectionSize == value;
				if (!flag)
				{
					this.m_ShowBoundCollectionSize = value;
					this.SetupArraySizeField();
				}
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0002C43B File Offset: 0x0002A63B
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x0002C444 File Offset: 0x0002A644
		public bool showFoldoutHeader
		{
			get
			{
				return this.m_ShowFoldoutHeader;
			}
			set
			{
				bool flag = this.m_ShowFoldoutHeader == value;
				if (!flag)
				{
					this.m_ShowFoldoutHeader = value;
					base.EnableInClassList(ListView.listViewWithHeaderUssClassName, value);
					bool showFoldoutHeader = this.m_ShowFoldoutHeader;
					if (showFoldoutHeader)
					{
						bool flag2 = this.m_Foldout != null;
						if (flag2)
						{
							return;
						}
						this.m_Foldout = new Foldout
						{
							name = ListView.foldoutHeaderUssClassName,
							text = this.m_HeaderTitle
						};
						this.m_Foldout.AddToClassList(ListView.foldoutHeaderUssClassName);
						this.m_Foldout.tabIndex = 1;
						base.hierarchy.Add(this.m_Foldout);
						this.m_Foldout.Add(base.scrollView);
					}
					else
					{
						bool flag3 = this.m_Foldout != null;
						if (flag3)
						{
							Foldout foldout = this.m_Foldout;
							if (foldout != null)
							{
								foldout.RemoveFromHierarchy();
							}
							this.m_Foldout = null;
							base.hierarchy.Add(base.scrollView);
						}
					}
					this.SetupArraySizeField();
					this.UpdateEmpty();
					bool showAddRemoveFooter = this.showAddRemoveFooter;
					if (showAddRemoveFooter)
					{
						this.EnableFooter(true);
					}
				}
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0002C564 File Offset: 0x0002A764
		internal void SetupArraySizeField()
		{
			bool flag = !this.showBoundCollectionSize || (!this.showFoldoutHeader && base.GetProperty("__unity-collection-view-internal-binding") == null);
			if (flag)
			{
				TextField arraySizeField = this.m_ArraySizeField;
				if (arraySizeField != null)
				{
					arraySizeField.RemoveFromHierarchy();
				}
			}
			else
			{
				bool flag2 = this.m_ArraySizeField == null;
				if (flag2)
				{
					this.m_ArraySizeField = new TextField
					{
						name = ListView.arraySizeFieldUssClassName
					};
					this.m_ArraySizeField.AddToClassList(ListView.arraySizeFieldUssClassName);
					this.m_ArraySizeField.RegisterValueChangedCallback(new EventCallback<ChangeEvent<string>>(this.OnArraySizeFieldChanged));
					this.m_ArraySizeField.isDelayed = true;
					this.m_ArraySizeField.focusable = true;
				}
				this.m_ArraySizeField.EnableInClassList(ListView.arraySizeFieldWithFooterUssClassName, this.showAddRemoveFooter);
				this.m_ArraySizeField.EnableInClassList(ListView.arraySizeFieldWithHeaderUssClassName, this.showFoldoutHeader);
				bool showFoldoutHeader = this.showFoldoutHeader;
				if (showFoldoutHeader)
				{
					this.m_ArraySizeField.label = string.Empty;
					base.hierarchy.Add(this.m_ArraySizeField);
				}
				else
				{
					this.m_ArraySizeField.label = ListView.k_SizeFieldLabel;
					base.hierarchy.Insert(0, this.m_ArraySizeField);
				}
				this.UpdateArraySizeField();
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0002C6B2 File Offset: 0x0002A8B2
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0002C6BC File Offset: 0x0002A8BC
		public string headerTitle
		{
			get
			{
				return this.m_HeaderTitle;
			}
			set
			{
				this.m_HeaderTitle = value;
				bool flag = this.m_Foldout != null;
				if (flag)
				{
					this.m_Foldout.text = this.m_HeaderTitle;
				}
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0002C6F0 File Offset: 0x0002A8F0
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0002C6FB File Offset: 0x0002A8FB
		public bool showAddRemoveFooter
		{
			get
			{
				return this.m_Footer != null;
			}
			set
			{
				this.EnableFooter(value);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0002C705 File Offset: 0x0002A905
		internal Foldout headerFoldout
		{
			get
			{
				return this.m_Foldout;
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0002C710 File Offset: 0x0002A910
		private void EnableFooter(bool enabled)
		{
			base.EnableInClassList(ListView.listViewWithFooterUssClassName, enabled);
			base.scrollView.EnableInClassList(ListView.scrollViewWithFooterUssClassName, enabled);
			bool flag = this.m_ArraySizeField != null;
			if (flag)
			{
				this.m_ArraySizeField.EnableInClassList(ListView.arraySizeFieldWithFooterUssClassName, enabled);
			}
			if (enabled)
			{
				bool flag2 = this.m_Footer == null;
				if (flag2)
				{
					this.m_Footer = new VisualElement
					{
						name = ListView.footerUssClassName
					};
					this.m_Footer.AddToClassList(ListView.footerUssClassName);
					this.m_RemoveButton = new Button(new Action(this.OnRemoveClicked))
					{
						name = ListView.footerRemoveButtonName,
						text = "-"
					};
					this.m_Footer.Add(this.m_RemoveButton);
					this.m_AddButton = new Button(new Action(this.OnAddClicked))
					{
						name = ListView.footerAddButtonName,
						text = "+"
					};
					this.m_Footer.Add(this.m_AddButton);
				}
				bool flag3 = this.m_Foldout != null;
				if (flag3)
				{
					this.m_Foldout.contentContainer.Add(this.m_Footer);
				}
				else
				{
					base.hierarchy.Add(this.m_Footer);
				}
			}
			else
			{
				Button removeButton = this.m_RemoveButton;
				if (removeButton != null)
				{
					removeButton.RemoveFromHierarchy();
				}
				Button addButton = this.m_AddButton;
				if (addButton != null)
				{
					addButton.RemoveFromHierarchy();
				}
				VisualElement footer = this.m_Footer;
				if (footer != null)
				{
					footer.RemoveFromHierarchy();
				}
				this.m_RemoveButton = null;
				this.m_AddButton = null;
				this.m_Footer = null;
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000AE7 RID: 2791 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		// (remove) Token: 0x06000AE8 RID: 2792 RVA: 0x0002C8E8 File Offset: 0x0002AAE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<IEnumerable<int>> itemsAdded;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000AE9 RID: 2793 RVA: 0x0002C920 File Offset: 0x0002AB20
		// (remove) Token: 0x06000AEA RID: 2794 RVA: 0x0002C958 File Offset: 0x0002AB58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<IEnumerable<int>> itemsRemoved;

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002C98D File Offset: 0x0002AB8D
		private void AddItems(int itemCount)
		{
			this.viewController.AddItems(itemCount);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0002C99D File Offset: 0x0002AB9D
		private void RemoveItems(List<int> indices)
		{
			this.viewController.RemoveItems(indices);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0002C9B0 File Offset: 0x0002ABB0
		private void OnArraySizeFieldChanged(ChangeEvent<string> evt)
		{
			int num;
			bool flag = !int.TryParse(evt.newValue, out num) || num < 0;
			if (flag)
			{
				this.m_ArraySizeField.SetValueWithoutNotify(evt.previousValue);
			}
			else
			{
				int itemsCount = this.viewController.GetItemsCount();
				bool flag2 = num > itemsCount;
				if (flag2)
				{
					this.viewController.AddItems(num - itemsCount);
				}
				else
				{
					bool flag3 = num < itemsCount;
					if (flag3)
					{
						this.viewController.RemoveItems(itemsCount - num);
					}
				}
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0002CA30 File Offset: 0x0002AC30
		private void UpdateArraySizeField()
		{
			bool flag = !base.HasValidDataAndBindings();
			if (!flag)
			{
				TextField arraySizeField = this.m_ArraySizeField;
				if (arraySizeField != null)
				{
					arraySizeField.SetValueWithoutNotify(this.viewController.GetItemsCount().ToString());
				}
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0002CA74 File Offset: 0x0002AC74
		private void UpdateEmpty()
		{
			bool flag = !base.HasValidDataAndBindings();
			if (!flag)
			{
				bool flag2 = base.itemsSource.Count == 0;
				if (flag2)
				{
					bool flag3 = this.m_EmptyListLabel != null;
					if (!flag3)
					{
						this.m_EmptyListLabel = new Label("List is Empty");
						this.m_EmptyListLabel.AddToClassList(ListView.emptyLabelUssClassName);
						base.scrollView.contentViewport.Add(this.m_EmptyListLabel);
					}
				}
				else
				{
					Label emptyListLabel = this.m_EmptyListLabel;
					if (emptyListLabel != null)
					{
						emptyListLabel.RemoveFromHierarchy();
					}
					this.m_EmptyListLabel = null;
				}
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0002CB0C File Offset: 0x0002AD0C
		private void OnAddClicked()
		{
			this.AddItems(1);
			bool flag = base.binding == null;
			if (flag)
			{
				base.SetSelection(base.itemsSource.Count - 1);
				base.ScrollToItem(-1);
			}
			else
			{
				base.schedule.Execute(delegate()
				{
					base.SetSelection(base.itemsSource.Count - 1);
					base.ScrollToItem(-1);
				}).ExecuteLater(100L);
			}
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0002CB74 File Offset: 0x0002AD74
		private void OnRemoveClicked()
		{
			bool flag = base.selectedIndices.Any<int>();
			if (flag)
			{
				this.viewController.RemoveItems(base.selectedIndices.ToList<int>());
				base.ClearSelection();
			}
			else
			{
				bool flag2 = base.itemsSource.Count > 0;
				if (flag2)
				{
					int index = base.itemsSource.Count - 1;
					this.viewController.RemoveItem(index);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0002CBE2 File Offset: 0x0002ADE2
		internal new ListViewController viewController
		{
			get
			{
				return this.m_ListViewController;
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0002CBEA File Offset: 0x0002ADEA
		private protected override void CreateVirtualizationController()
		{
			base.CreateVirtualizationController<ReusableListViewItem>();
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
		private protected override void CreateViewController()
		{
			this.SetViewController(new ListViewController());
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0002CC04 File Offset: 0x0002AE04
		internal void SetViewController(ListViewController controller)
		{
			if (this.m_ItemAddedCallback == null)
			{
				this.m_ItemAddedCallback = new Action<IEnumerable<int>>(this.OnItemAdded);
			}
			if (this.m_ItemRemovedCallback == null)
			{
				this.m_ItemRemovedCallback = new Action<IEnumerable<int>>(this.OnItemsRemoved);
			}
			if (this.m_ItemsSourceSizeChangedCallback == null)
			{
				this.m_ItemsSourceSizeChangedCallback = new Action(this.OnItemsSourceSizeChanged);
			}
			bool flag = this.m_ListViewController != null;
			if (flag)
			{
				this.m_ListViewController.itemsAdded -= this.m_ItemAddedCallback;
				this.m_ListViewController.itemsRemoved -= this.m_ItemRemovedCallback;
				this.m_ListViewController.itemsSourceSizeChanged -= this.m_ItemsSourceSizeChangedCallback;
			}
			base.SetViewController(controller);
			this.m_ListViewController = controller;
			bool flag2 = this.m_ListViewController != null;
			if (flag2)
			{
				this.m_ListViewController.itemsAdded += this.m_ItemAddedCallback;
				this.m_ListViewController.itemsRemoved += this.m_ItemRemovedCallback;
				this.m_ListViewController.itemsSourceSizeChanged += this.m_ItemsSourceSizeChangedCallback;
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0002CCF9 File Offset: 0x0002AEF9
		private void OnItemAdded(IEnumerable<int> indices)
		{
			Action<IEnumerable<int>> action = this.itemsAdded;
			if (action != null)
			{
				action(indices);
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0002CD0F File Offset: 0x0002AF0F
		private void OnItemsRemoved(IEnumerable<int> indices)
		{
			Action<IEnumerable<int>> action = this.itemsRemoved;
			if (action != null)
			{
				action(indices);
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0002844B File Offset: 0x0002664B
		private void OnItemsSourceSizeChanged()
		{
			base.RefreshItems();
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0002CD25 File Offset: 0x0002AF25
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x0002CD30 File Offset: 0x0002AF30
		public ListViewReorderMode reorderMode
		{
			get
			{
				return this.m_ReorderMode;
			}
			set
			{
				bool flag = value != this.m_ReorderMode;
				if (flag)
				{
					this.m_ReorderMode = value;
					base.InitializeDragAndDropController(base.reorderable);
					base.Rebuild();
				}
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0002CD6C File Offset: 0x0002AF6C
		internal override ListViewDragger CreateDragger()
		{
			bool flag = this.m_ReorderMode == ListViewReorderMode.Simple;
			ListViewDragger result;
			if (flag)
			{
				result = new ListViewDragger(this);
			}
			else
			{
				result = new ListViewDraggerAnimated(this);
			}
			return result;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0002CD9A File Offset: 0x0002AF9A
		internal override ICollectionDragAndDropController CreateDragAndDropController()
		{
			return new ListViewReorderableDragAndDropController(this);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0002CDA2 File Offset: 0x0002AFA2
		public ListView()
		{
			base.AddToClassList(ListView.ussClassName);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0002CDBF File Offset: 0x0002AFBF
		public ListView(IList itemsSource, float itemHeight = -1f, Func<VisualElement> makeItem = null, Action<VisualElement, int> bindItem = null) : base(itemsSource, itemHeight, makeItem, bindItem)
		{
			base.AddToClassList(ListView.ussClassName);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0002CDE1 File Offset: 0x0002AFE1
		private protected override void PostRefresh()
		{
			this.UpdateArraySizeField();
			this.UpdateEmpty();
			base.PostRefresh();
		}

		// Token: 0x040004C6 RID: 1222
		private static readonly string k_SizeFieldLabel = "Size";

		// Token: 0x040004C7 RID: 1223
		private bool m_ShowBoundCollectionSize = true;

		// Token: 0x040004C8 RID: 1224
		private bool m_ShowFoldoutHeader;

		// Token: 0x040004C9 RID: 1225
		private string m_HeaderTitle;

		// Token: 0x040004CC RID: 1228
		private Label m_EmptyListLabel;

		// Token: 0x040004CD RID: 1229
		private Foldout m_Foldout;

		// Token: 0x040004CE RID: 1230
		private TextField m_ArraySizeField;

		// Token: 0x040004CF RID: 1231
		private VisualElement m_Footer;

		// Token: 0x040004D0 RID: 1232
		private Button m_AddButton;

		// Token: 0x040004D1 RID: 1233
		private Button m_RemoveButton;

		// Token: 0x040004D2 RID: 1234
		private Action<IEnumerable<int>> m_ItemAddedCallback;

		// Token: 0x040004D3 RID: 1235
		private Action<IEnumerable<int>> m_ItemRemovedCallback;

		// Token: 0x040004D4 RID: 1236
		private Action m_ItemsSourceSizeChangedCallback;

		// Token: 0x040004D5 RID: 1237
		private ListViewController m_ListViewController;

		// Token: 0x040004D6 RID: 1238
		private ListViewReorderMode m_ReorderMode;

		// Token: 0x040004D7 RID: 1239
		public new static readonly string ussClassName = "unity-list-view";

		// Token: 0x040004D8 RID: 1240
		public new static readonly string itemUssClassName = ListView.ussClassName + "__item";

		// Token: 0x040004D9 RID: 1241
		public static readonly string emptyLabelUssClassName = ListView.ussClassName + "__empty-label";

		// Token: 0x040004DA RID: 1242
		public static readonly string reorderableUssClassName = ListView.ussClassName + "__reorderable";

		// Token: 0x040004DB RID: 1243
		public static readonly string reorderableItemUssClassName = ListView.reorderableUssClassName + "-item";

		// Token: 0x040004DC RID: 1244
		public static readonly string reorderableItemContainerUssClassName = ListView.reorderableItemUssClassName + "__container";

		// Token: 0x040004DD RID: 1245
		public static readonly string reorderableItemHandleUssClassName = ListView.reorderableUssClassName + "-handle";

		// Token: 0x040004DE RID: 1246
		public static readonly string reorderableItemHandleBarUssClassName = ListView.reorderableItemHandleUssClassName + "-bar";

		// Token: 0x040004DF RID: 1247
		public static readonly string footerUssClassName = ListView.ussClassName + "__footer";

		// Token: 0x040004E0 RID: 1248
		public static readonly string foldoutHeaderUssClassName = ListView.ussClassName + "__foldout-header";

		// Token: 0x040004E1 RID: 1249
		public static readonly string arraySizeFieldUssClassName = ListView.ussClassName + "__size-field";

		// Token: 0x040004E2 RID: 1250
		public static readonly string arraySizeFieldWithHeaderUssClassName = ListView.arraySizeFieldUssClassName + "--with-header";

		// Token: 0x040004E3 RID: 1251
		public static readonly string arraySizeFieldWithFooterUssClassName = ListView.arraySizeFieldUssClassName + "--with-footer";

		// Token: 0x040004E4 RID: 1252
		public static readonly string listViewWithHeaderUssClassName = ListView.ussClassName + "--with-header";

		// Token: 0x040004E5 RID: 1253
		public static readonly string listViewWithFooterUssClassName = ListView.ussClassName + "--with-footer";

		// Token: 0x040004E6 RID: 1254
		public static readonly string scrollViewWithFooterUssClassName = ListView.ussClassName + "__scroll-view--with-footer";

		// Token: 0x040004E7 RID: 1255
		internal static readonly string footerAddButtonName = ListView.ussClassName + "__add-button";

		// Token: 0x040004E8 RID: 1256
		internal static readonly string footerRemoveButtonName = ListView.ussClassName + "__remove-button";

		// Token: 0x02000153 RID: 339
		public new class UxmlFactory : UxmlFactory<ListView, ListView.UxmlTraits>
		{
		}

		// Token: 0x02000154 RID: 340
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x1700021F RID: 543
			// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0002CF9C File Offset: 0x0002B19C
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get
				{
					yield break;
				}
			}

			// Token: 0x06000B04 RID: 2820 RVA: 0x0002CFBC File Offset: 0x0002B1BC
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);
				int num = 0;
				ListView listView = (ListView)ve;
				listView.reorderable = this.m_Reorderable.GetValueFromBag(bag, cc);
				bool flag = this.m_FixedItemHeight.TryGetValueFromBag(bag, cc, ref num);
				if (flag)
				{
					listView.fixedItemHeight = (float)num;
				}
				listView.reorderMode = this.m_ReorderMode.GetValueFromBag(bag, cc);
				listView.virtualizationMethod = this.m_VirtualizationMethod.GetValueFromBag(bag, cc);
				listView.showBorder = this.m_ShowBorder.GetValueFromBag(bag, cc);
				listView.selectionType = this.m_SelectionType.GetValueFromBag(bag, cc);
				listView.showAlternatingRowBackgrounds = this.m_ShowAlternatingRowBackgrounds.GetValueFromBag(bag, cc);
				listView.showFoldoutHeader = this.m_ShowFoldoutHeader.GetValueFromBag(bag, cc);
				listView.headerTitle = this.m_HeaderTitle.GetValueFromBag(bag, cc);
				listView.showAddRemoveFooter = this.m_ShowAddRemoveFooter.GetValueFromBag(bag, cc);
				listView.showBoundCollectionSize = this.m_ShowBoundCollectionSize.GetValueFromBag(bag, cc);
				listView.horizontalScrollingEnabled = this.m_HorizontalScrollingEnabled.GetValueFromBag(bag, cc);
			}

			// Token: 0x040004E9 RID: 1257
			private readonly UxmlIntAttributeDescription m_FixedItemHeight = new UxmlIntAttributeDescription
			{
				name = "fixed-item-height",
				obsoleteNames = new string[]
				{
					"itemHeight, item-height"
				},
				defaultValue = BaseVerticalCollectionView.s_DefaultItemHeight
			};

			// Token: 0x040004EA RID: 1258
			private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod = new UxmlEnumAttributeDescription<CollectionVirtualizationMethod>
			{
				name = "virtualization-method",
				defaultValue = CollectionVirtualizationMethod.FixedHeight
			};

			// Token: 0x040004EB RID: 1259
			private readonly UxmlBoolAttributeDescription m_ShowBorder = new UxmlBoolAttributeDescription
			{
				name = "show-border",
				defaultValue = false
			};

			// Token: 0x040004EC RID: 1260
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType = new UxmlEnumAttributeDescription<SelectionType>
			{
				name = "selection-type",
				defaultValue = SelectionType.Single
			};

			// Token: 0x040004ED RID: 1261
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds = new UxmlEnumAttributeDescription<AlternatingRowBackground>
			{
				name = "show-alternating-row-backgrounds",
				defaultValue = AlternatingRowBackground.None
			};

			// Token: 0x040004EE RID: 1262
			private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader = new UxmlBoolAttributeDescription
			{
				name = "show-foldout-header",
				defaultValue = false
			};

			// Token: 0x040004EF RID: 1263
			private readonly UxmlStringAttributeDescription m_HeaderTitle = new UxmlStringAttributeDescription
			{
				name = "header-title",
				defaultValue = string.Empty
			};

			// Token: 0x040004F0 RID: 1264
			private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter = new UxmlBoolAttributeDescription
			{
				name = "show-add-remove-footer",
				defaultValue = false
			};

			// Token: 0x040004F1 RID: 1265
			private readonly UxmlBoolAttributeDescription m_Reorderable = new UxmlBoolAttributeDescription
			{
				name = "reorderable",
				defaultValue = false
			};

			// Token: 0x040004F2 RID: 1266
			private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode = new UxmlEnumAttributeDescription<ListViewReorderMode>
			{
				name = "reorder-mode",
				defaultValue = ListViewReorderMode.Simple
			};

			// Token: 0x040004F3 RID: 1267
			private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize = new UxmlBoolAttributeDescription
			{
				name = "show-bound-collection-size",
				defaultValue = true
			};

			// Token: 0x040004F4 RID: 1268
			private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled = new UxmlBoolAttributeDescription
			{
				name = "horizontal-scrolling",
				defaultValue = false
			};
		}
	}
}
