using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace UnityEngine.UIElements
{
	// Token: 0x02000252 RID: 594
	[HelpURL("UIE-get-started-with-runtime-ui")]
	[AddComponentMenu("UI Toolkit/UI Document")]
	[DefaultExecutionOrder(-100)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public sealed class UIDocument : MonoBehaviour
	{
		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00046CF0 File Offset: 0x00044EF0
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00046D08 File Offset: 0x00044F08
		public PanelSettings panelSettings
		{
			get
			{
				return this.m_PanelSettings;
			}
			set
			{
				bool flag = this.parentUI == null;
				if (flag)
				{
					bool flag2 = this.m_PanelSettings == value;
					if (flag2)
					{
						this.m_PreviousPanelSettings = this.m_PanelSettings;
						return;
					}
					bool flag3 = this.m_PanelSettings != null;
					if (flag3)
					{
						this.m_PanelSettings.DetachUIDocument(this);
					}
					this.m_PanelSettings = value;
					bool flag4 = this.m_PanelSettings != null;
					if (flag4)
					{
						this.m_PanelSettings.AttachAndInsertUIDocumentToVisualTree(this);
					}
				}
				else
				{
					Assert.AreEqual<PanelSettings>(this.parentUI.m_PanelSettings, value);
					this.m_PanelSettings = this.parentUI.m_PanelSettings;
				}
				bool flag5 = this.m_ChildrenContent != null;
				if (flag5)
				{
					foreach (UIDocument uidocument in this.m_ChildrenContent.m_AttachedUIDocuments)
					{
						uidocument.panelSettings = this.m_PanelSettings;
					}
				}
				this.m_PreviousPanelSettings = this.m_PanelSettings;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00046E2C File Offset: 0x0004502C
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x00046E34 File Offset: 0x00045034
		public UIDocument parentUI
		{
			get
			{
				return this.m_ParentUI;
			}
			private set
			{
				this.m_ParentUI = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x00046E40 File Offset: 0x00045040
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x00046E58 File Offset: 0x00045058
		public VisualTreeAsset visualTreeAsset
		{
			get
			{
				return this.sourceAsset;
			}
			set
			{
				this.sourceAsset = value;
				this.RecreateUI();
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x00046E6C File Offset: 0x0004506C
		public VisualElement rootVisualElement
		{
			get
			{
				return this.m_RootVisualElement;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x00046E84 File Offset: 0x00045084
		internal int firstChildInserIndex
		{
			get
			{
				return this.m_FirstChildInsertIndex;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00046E8C File Offset: 0x0004508C
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x00046E94 File Offset: 0x00045094
		public float sortingOrder
		{
			get
			{
				return this.m_SortingOrder;
			}
			set
			{
				bool flag = this.m_SortingOrder == value;
				if (!flag)
				{
					this.m_SortingOrder = value;
					this.ApplySortingOrder();
				}
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00046EC0 File Offset: 0x000450C0
		internal void ApplySortingOrder()
		{
			this.AddRootVisualElementToTree();
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00046ECA File Offset: 0x000450CA
		private UIDocument()
		{
			this.m_UIDocumentCreationIndex = UIDocument.s_CurrentUIDocumentCounter++;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00046F07 File Offset: 0x00045107
		private void Awake()
		{
			this.SetupFromHierarchy();
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00046F14 File Offset: 0x00045114
		private void OnEnable()
		{
			bool flag = this.parentUI != null && this.m_PanelSettings == null;
			if (flag)
			{
				this.m_PanelSettings = this.parentUI.m_PanelSettings;
			}
			bool flag2 = this.m_RootVisualElement == null;
			if (flag2)
			{
				this.RecreateUI();
			}
			else
			{
				this.AddRootVisualElementToTree();
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00046F78 File Offset: 0x00045178
		private void SetupFromHierarchy()
		{
			bool flag = this.parentUI != null;
			if (flag)
			{
				this.parentUI.RemoveChild(this);
			}
			this.parentUI = this.FindUIDocumentParent();
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00046FB4 File Offset: 0x000451B4
		private UIDocument FindUIDocumentParent()
		{
			Transform transform = base.transform;
			Transform parent = transform.parent;
			bool flag = parent != null;
			if (flag)
			{
				UIDocument[] componentsInParent = parent.GetComponentsInParent<UIDocument>(true);
				bool flag2 = componentsInParent != null && componentsInParent.Length != 0;
				if (flag2)
				{
					return componentsInParent[0];
				}
			}
			return null;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00047008 File Offset: 0x00045208
		internal void Reset()
		{
			bool flag = this.parentUI == null;
			if (flag)
			{
				PanelSettings previousPanelSettings = this.m_PreviousPanelSettings;
				if (previousPanelSettings != null)
				{
					previousPanelSettings.DetachUIDocument(this);
				}
				this.panelSettings = null;
			}
			this.SetupFromHierarchy();
			bool flag2 = this.parentUI != null;
			if (flag2)
			{
				this.m_PanelSettings = this.parentUI.m_PanelSettings;
				this.AddRootVisualElementToTree();
			}
			else
			{
				bool flag3 = this.m_PanelSettings != null;
				if (flag3)
				{
					this.AddRootVisualElementToTree();
				}
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00047090 File Offset: 0x00045290
		private void AddChildAndInsertContentToVisualTree(UIDocument child)
		{
			bool flag = this.m_ChildrenContent == null;
			if (flag)
			{
				this.m_ChildrenContent = new UIDocumentList();
			}
			else
			{
				this.m_ChildrenContent.RemoveFromListAndFromVisualTree(child);
			}
			this.m_ChildrenContent.AddToListAndToVisualTree(child, this.m_RootVisualElement, this.m_FirstChildInsertIndex);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000470E2 File Offset: 0x000452E2
		private void RemoveChild(UIDocument child)
		{
			UIDocumentList childrenContent = this.m_ChildrenContent;
			if (childrenContent != null)
			{
				childrenContent.RemoveFromListAndFromVisualTree(child);
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000470F8 File Offset: 0x000452F8
		private void RecreateUI()
		{
			bool flag = this.m_RootVisualElement != null;
			if (flag)
			{
				this.RemoveFromHierarchy();
				this.m_RootVisualElement = null;
			}
			bool flag2 = this.sourceAsset != null;
			if (flag2)
			{
				this.m_RootVisualElement = this.sourceAsset.Instantiate();
				bool flag3 = this.m_RootVisualElement == null;
				if (flag3)
				{
					Debug.LogError("The UXML file set for the UIDocument could not be cloned.");
				}
			}
			bool flag4 = this.m_RootVisualElement == null;
			if (flag4)
			{
				this.m_RootVisualElement = new TemplateContainer
				{
					name = base.gameObject.name + "-container"
				};
			}
			else
			{
				this.m_RootVisualElement.name = base.gameObject.name + "-container";
			}
			this.m_RootVisualElement.pickingMode = PickingMode.Ignore;
			bool isActiveAndEnabled = base.isActiveAndEnabled;
			if (isActiveAndEnabled)
			{
				this.AddRootVisualElementToTree();
			}
			this.m_FirstChildInsertIndex = this.m_RootVisualElement.childCount;
			bool flag5 = this.m_ChildrenContent != null;
			if (flag5)
			{
				bool flag6 = this.m_ChildrenContentCopy == null;
				if (flag6)
				{
					this.m_ChildrenContentCopy = new List<UIDocument>(this.m_ChildrenContent.m_AttachedUIDocuments);
				}
				else
				{
					this.m_ChildrenContentCopy.AddRange(this.m_ChildrenContent.m_AttachedUIDocuments);
				}
				foreach (UIDocument uidocument in this.m_ChildrenContentCopy)
				{
					bool isActiveAndEnabled2 = uidocument.isActiveAndEnabled;
					if (isActiveAndEnabled2)
					{
						bool flag7 = uidocument.m_RootVisualElement == null;
						if (flag7)
						{
							uidocument.RecreateUI();
						}
						else
						{
							this.AddChildAndInsertContentToVisualTree(uidocument);
						}
					}
				}
				this.m_ChildrenContentCopy.Clear();
			}
			this.SetupRootClassList();
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000472D4 File Offset: 0x000454D4
		private void SetupRootClassList()
		{
			VisualElement rootVisualElement = this.m_RootVisualElement;
			if (rootVisualElement != null)
			{
				rootVisualElement.EnableInClassList("unity-ui-document__root", this.parentUI == null);
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x000472FC File Offset: 0x000454FC
		private void AddRootVisualElementToTree()
		{
			bool flag = !base.enabled;
			if (!flag)
			{
				bool flag2 = this.parentUI != null;
				if (flag2)
				{
					this.parentUI.AddChildAndInsertContentToVisualTree(this);
				}
				else
				{
					bool flag3 = this.m_PanelSettings != null;
					if (flag3)
					{
						this.m_PanelSettings.AttachAndInsertUIDocumentToVisualTree(this);
					}
				}
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0004735C File Offset: 0x0004555C
		private void RemoveFromHierarchy()
		{
			bool flag = this.parentUI != null;
			if (flag)
			{
				this.parentUI.RemoveChild(this);
			}
			else
			{
				bool flag2 = this.m_PanelSettings != null;
				if (flag2)
				{
					this.m_PanelSettings.DetachUIDocument(this);
				}
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000473AC File Offset: 0x000455AC
		private void OnDisable()
		{
			bool flag = this.m_RootVisualElement != null;
			if (flag)
			{
				this.RemoveFromHierarchy();
				this.m_RootVisualElement = null;
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000473D8 File Offset: 0x000455D8
		private void OnTransformChildrenChanged()
		{
			bool flag = this.m_ChildrenContent != null;
			if (flag)
			{
				bool flag2 = this.m_ChildrenContentCopy == null;
				if (flag2)
				{
					this.m_ChildrenContentCopy = new List<UIDocument>(this.m_ChildrenContent.m_AttachedUIDocuments);
				}
				else
				{
					this.m_ChildrenContentCopy.AddRange(this.m_ChildrenContent.m_AttachedUIDocuments);
				}
				foreach (UIDocument uidocument in this.m_ChildrenContentCopy)
				{
					uidocument.ReactToHierarchyChanged();
				}
				this.m_ChildrenContentCopy.Clear();
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00047490 File Offset: 0x00045690
		private void OnTransformParentChanged()
		{
			this.ReactToHierarchyChanged();
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0004749C File Offset: 0x0004569C
		internal void ReactToHierarchyChanged()
		{
			this.SetupFromHierarchy();
			bool flag = this.parentUI != null;
			if (flag)
			{
				this.panelSettings = this.parentUI.m_PanelSettings;
			}
			VisualElement rootVisualElement = this.m_RootVisualElement;
			if (rootVisualElement != null)
			{
				rootVisualElement.RemoveFromHierarchy();
			}
			this.AddRootVisualElementToTree();
			this.SetupRootClassList();
		}

		// Token: 0x0400080D RID: 2061
		internal const string k_RootStyleClassName = "unity-ui-document__root";

		// Token: 0x0400080E RID: 2062
		internal const string k_VisualElementNameSuffix = "-container";

		// Token: 0x0400080F RID: 2063
		private const int k_DefaultSortingOrder = 0;

		// Token: 0x04000810 RID: 2064
		private static int s_CurrentUIDocumentCounter;

		// Token: 0x04000811 RID: 2065
		internal readonly int m_UIDocumentCreationIndex;

		// Token: 0x04000812 RID: 2066
		[SerializeField]
		private PanelSettings m_PanelSettings;

		// Token: 0x04000813 RID: 2067
		private PanelSettings m_PreviousPanelSettings = null;

		// Token: 0x04000814 RID: 2068
		[SerializeField]
		private UIDocument m_ParentUI;

		// Token: 0x04000815 RID: 2069
		private UIDocumentList m_ChildrenContent = null;

		// Token: 0x04000816 RID: 2070
		private List<UIDocument> m_ChildrenContentCopy = null;

		// Token: 0x04000817 RID: 2071
		[SerializeField]
		private VisualTreeAsset sourceAsset;

		// Token: 0x04000818 RID: 2072
		private VisualElement m_RootVisualElement;

		// Token: 0x04000819 RID: 2073
		private int m_FirstChildInsertIndex;

		// Token: 0x0400081A RID: 2074
		[SerializeField]
		private float m_SortingOrder = 0f;
	}
}
