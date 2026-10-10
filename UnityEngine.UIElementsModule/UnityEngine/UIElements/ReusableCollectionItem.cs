using System;
using System.Diagnostics;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x02000114 RID: 276
	internal class ReusableCollectionItem
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00022BCE File Offset: 0x00020DCE
		public virtual VisualElement rootElement
		{
			get
			{
				return this.bindableElement;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00022BD6 File Offset: 0x00020DD6
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00022BDE File Offset: 0x00020DDE
		public VisualElement bindableElement { get; protected set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00022BE7 File Offset: 0x00020DE7
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00022BEF File Offset: 0x00020DEF
		public ValueAnimation<StyleValues> animator { get; set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00022BF8 File Offset: 0x00020DF8
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00022C00 File Offset: 0x00020E00
		public int index { get; set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00022C09 File Offset: 0x00020E09
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00022C11 File Offset: 0x00020E11
		public int id { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00022C1A File Offset: 0x00020E1A
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00022C22 File Offset: 0x00020E22
		internal bool isDragGhost { get; private set; }

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060008EE RID: 2286 RVA: 0x00022C2C File Offset: 0x00020E2C
		// (remove) Token: 0x060008EF RID: 2287 RVA: 0x00022C64 File Offset: 0x00020E64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<ReusableCollectionItem> onGeometryChanged;

		// Token: 0x060008F0 RID: 2288 RVA: 0x00022C9C File Offset: 0x00020E9C
		public ReusableCollectionItem()
		{
			this.index = (this.id = -1);
			this.m_GeometryChangedEventCallback = new EventCallback<GeometryChangedEvent>(this.OnGeometryChanged);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00022CD5 File Offset: 0x00020ED5
		public virtual void Init(VisualElement item)
		{
			this.bindableElement = item;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00022CE0 File Offset: 0x00020EE0
		public virtual void PreAttachElement()
		{
			this.rootElement.AddToClassList(BaseVerticalCollectionView.itemUssClassName);
			this.rootElement.RegisterCallback<GeometryChangedEvent>(this.m_GeometryChangedEventCallback, TrickleDown.NoTrickleDown);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00022D08 File Offset: 0x00020F08
		public virtual void DetachElement()
		{
			this.rootElement.RemoveFromClassList(BaseVerticalCollectionView.itemUssClassName);
			this.rootElement.UnregisterCallback<GeometryChangedEvent>(this.m_GeometryChangedEventCallback, TrickleDown.NoTrickleDown);
			VisualElement rootElement = this.rootElement;
			if (rootElement != null)
			{
				rootElement.RemoveFromHierarchy();
			}
			this.SetSelected(false);
			this.SetDragGhost(false);
			this.index = (this.id = -1);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00022D70 File Offset: 0x00020F70
		public virtual void SetSelected(bool selected)
		{
			if (selected)
			{
				this.rootElement.AddToClassList(BaseVerticalCollectionView.itemSelectedVariantUssClassName);
				this.rootElement.pseudoStates |= PseudoStates.Checked;
			}
			else
			{
				this.rootElement.RemoveFromClassList(BaseVerticalCollectionView.itemSelectedVariantUssClassName);
				this.rootElement.pseudoStates &= ~PseudoStates.Checked;
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00022DD4 File Offset: 0x00020FD4
		public virtual void SetDragGhost(bool dragGhost)
		{
			this.isDragGhost = dragGhost;
			this.rootElement.style.maxHeight = (this.isDragGhost ? StyleKeyword.Undefined : StyleKeyword.Initial);
			this.bindableElement.style.display = (this.isDragGhost ? DisplayStyle.None : DisplayStyle.Flex);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00022E2E File Offset: 0x0002102E
		protected void OnGeometryChanged(GeometryChangedEvent evt)
		{
			Action<ReusableCollectionItem> action = this.onGeometryChanged;
			if (action != null)
			{
				action(this);
			}
		}

		// Token: 0x040003A6 RID: 934
		public const int UndefinedIndex = -1;

		// Token: 0x040003AD RID: 941
		protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback;
	}
}
