using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Assertions;

namespace UnityEngine.UIElements
{
	// Token: 0x020002F6 RID: 758
	[HelpURL("UIE-VisualTree-landing")]
	[Serializable]
	public class VisualTreeAsset : ScriptableObject
	{
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x00066668 File Offset: 0x00064868
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x00066680 File Offset: 0x00064880
		public bool importedWithErrors
		{
			get
			{
				return this.m_ImportedWithErrors;
			}
			internal set
			{
				this.m_ImportedWithErrors = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0006668C File Offset: 0x0006488C
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x000666A4 File Offset: 0x000648A4
		public bool importedWithWarnings
		{
			get
			{
				return this.m_ImportedWithWarnings;
			}
			internal set
			{
				this.m_ImportedWithWarnings = value;
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x000666B0 File Offset: 0x000648B0
		internal int GetNextChildSerialNumber()
		{
			List<VisualElementAsset> visualElementAssets = this.m_VisualElementAssets;
			int num = (visualElementAssets != null) ? visualElementAssets.Count : 0;
			int num2 = num;
			List<TemplateAsset> templateAssets = this.m_TemplateAssets;
			return num2 + ((templateAssets != null) ? templateAssets.Count : 0);
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x000666EC File Offset: 0x000648EC
		public IEnumerable<VisualTreeAsset> templateDependencies
		{
			get
			{
				bool flag = this.m_Usings == null || this.m_Usings.Count == 0;
				if (flag)
				{
					yield break;
				}
				HashSet<VisualTreeAsset> sent = new HashSet<VisualTreeAsset>();
				foreach (VisualTreeAsset.UsingEntry entry in this.m_Usings)
				{
					bool flag2 = entry.asset != null && !sent.Contains(entry.asset);
					if (flag2)
					{
						sent.Add(entry.asset);
						yield return entry.asset;
					}
					else
					{
						bool flag3 = !string.IsNullOrEmpty(entry.path);
						if (flag3)
						{
							VisualTreeAsset vta = Panel.LoadResource(entry.path, typeof(VisualTreeAsset), GUIUtility.pixelsPerPoint) as VisualTreeAsset;
							bool flag4 = vta != null && !sent.Contains(entry.asset);
							if (flag4)
							{
								sent.Add(entry.asset);
								yield return vta;
							}
							vta = null;
						}
					}
					entry = default(VisualTreeAsset.UsingEntry);
				}
				List<VisualTreeAsset.UsingEntry>.Enumerator enumerator = default(List<VisualTreeAsset.UsingEntry>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0006670C File Offset: 0x0006490C
		public IEnumerable<StyleSheet> stylesheets
		{
			get
			{
				HashSet<StyleSheet> sent = new HashSet<StyleSheet>();
				foreach (VisualElementAsset vea in this.m_VisualElementAssets)
				{
					bool hasStylesheets = vea.hasStylesheets;
					if (hasStylesheets)
					{
						foreach (StyleSheet stylesheet in vea.stylesheets)
						{
							bool flag = !sent.Contains(stylesheet);
							if (flag)
							{
								sent.Add(stylesheet);
								yield return stylesheet;
							}
							stylesheet = null;
						}
						List<StyleSheet>.Enumerator enumerator2 = default(List<StyleSheet>.Enumerator);
					}
					bool hasStylesheetPaths = vea.hasStylesheetPaths;
					if (hasStylesheetPaths)
					{
						foreach (string stylesheetPath in vea.stylesheetPaths)
						{
							StyleSheet stylesheet2 = Panel.LoadResource(stylesheetPath, typeof(StyleSheet), GUIUtility.pixelsPerPoint) as StyleSheet;
							bool flag2 = stylesheet2 != null && !sent.Contains(stylesheet2);
							if (flag2)
							{
								sent.Add(stylesheet2);
								yield return stylesheet2;
							}
							stylesheet2 = null;
							stylesheetPath = null;
						}
						List<string>.Enumerator enumerator3 = default(List<string>.Enumerator);
					}
					vea = null;
				}
				List<VisualElementAsset>.Enumerator enumerator = default(List<VisualElementAsset>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0006672C File Offset: 0x0006492C
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x00066744 File Offset: 0x00064944
		internal List<VisualElementAsset> visualElementAssets
		{
			get
			{
				return this.m_VisualElementAssets;
			}
			set
			{
				this.m_VisualElementAssets = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00066750 File Offset: 0x00064950
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x00066768 File Offset: 0x00064968
		internal List<TemplateAsset> templateAssets
		{
			get
			{
				return this.m_TemplateAssets;
			}
			set
			{
				this.m_TemplateAssets = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00066774 File Offset: 0x00064974
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x0006678C File Offset: 0x0006498C
		internal List<VisualTreeAsset.SlotDefinition> slots
		{
			get
			{
				return this.m_Slots;
			}
			set
			{
				this.m_Slots = value;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00066798 File Offset: 0x00064998
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x000667B0 File Offset: 0x000649B0
		internal int contentContainerId
		{
			get
			{
				return this.m_ContentContainerId;
			}
			set
			{
				this.m_ContentContainerId = value;
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x000667BC File Offset: 0x000649BC
		public TemplateContainer Instantiate()
		{
			TemplateContainer templateContainer = new TemplateContainer(base.name);
			try
			{
				this.CloneTree(templateContainer, VisualTreeAsset.s_TemporarySlotInsertionPoints, null);
			}
			finally
			{
				VisualTreeAsset.s_TemporarySlotInsertionPoints.Clear();
			}
			return templateContainer;
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0006680C File Offset: 0x00064A0C
		public TemplateContainer Instantiate(string bindingPath)
		{
			TemplateContainer templateContainer = this.Instantiate();
			templateContainer.bindingPath = bindingPath;
			return templateContainer;
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00066830 File Offset: 0x00064A30
		public TemplateContainer CloneTree()
		{
			return this.Instantiate();
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00066848 File Offset: 0x00064A48
		public TemplateContainer CloneTree(string bindingPath)
		{
			return this.Instantiate(bindingPath);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00066864 File Offset: 0x00064A64
		public void CloneTree(VisualElement target)
		{
			int num;
			int num2;
			this.CloneTree(target, out num, out num2);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00066880 File Offset: 0x00064A80
		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
		{
			bool flag = target == null;
			if (flag)
			{
				throw new ArgumentNullException("target");
			}
			firstElementIndex = target.childCount;
			try
			{
				this.CloneTree(target, VisualTreeAsset.s_TemporarySlotInsertionPoints, null);
			}
			finally
			{
				elementAddedCount = target.childCount - firstElementIndex;
				VisualTreeAsset.s_TemporarySlotInsertionPoints.Clear();
			}
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000668E4 File Offset: 0x00064AE4
		internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides)
		{
			bool flag = target == null;
			if (flag)
			{
				throw new ArgumentNullException("target");
			}
			bool flag2 = (this.visualElementAssets == null || this.visualElementAssets.Count <= 0) && (this.templateAssets == null || this.templateAssets.Count <= 0);
			if (!flag2)
			{
				TemplateContainer templateContainer = target as TemplateContainer;
				bool flag3 = templateContainer != null;
				if (flag3)
				{
					templateContainer.templateSource = this;
				}
				Dictionary<int, List<VisualElementAsset>> dictionary = new Dictionary<int, List<VisualElementAsset>>();
				int num = (this.visualElementAssets == null) ? 0 : this.visualElementAssets.Count;
				int num2 = (this.templateAssets == null) ? 0 : this.templateAssets.Count;
				for (int i = 0; i < num + num2; i++)
				{
					VisualElementAsset visualElementAsset = (i < num) ? this.visualElementAssets[i] : this.templateAssets[i - num];
					List<VisualElementAsset> list;
					bool flag4 = !dictionary.TryGetValue(visualElementAsset.parentId, out list);
					if (flag4)
					{
						list = new List<VisualElementAsset>();
						dictionary.Add(visualElementAsset.parentId, list);
					}
					list.Add(visualElementAsset);
				}
				List<VisualElementAsset> list2;
				dictionary.TryGetValue(0, out list2);
				bool flag5 = list2 == null || list2.Count == 0;
				if (!flag5)
				{
					Debug.Assert(list2.Count == 1);
					VisualElementAsset visualElementAsset2 = list2[0];
					VisualTreeAsset.AssignClassListFromAssetToElement(visualElementAsset2, target);
					VisualTreeAsset.AssignStyleSheetFromAssetToElement(visualElementAsset2, target);
					list2.Clear();
					dictionary.TryGetValue(visualElementAsset2.id, out list2);
					bool flag6 = list2 == null || list2.Count == 0;
					if (!flag6)
					{
						list2.Sort(new Comparison<VisualElementAsset>(VisualTreeAsset.CompareForOrder));
						foreach (VisualElementAsset visualElementAsset3 in list2)
						{
							Assert.IsNotNull<VisualElementAsset>(visualElementAsset3);
							VisualElement visualElement = this.CloneSetupRecursively(visualElementAsset3, dictionary, new CreationContext(slotInsertionPoints, attributeOverrides, this, target));
							bool flag7 = visualElement != null;
							if (flag7)
							{
								visualElement.visualTreeAssetSource = this;
								target.hierarchy.Add(visualElement);
							}
							else
							{
								bool flag8 = visualElementAsset3.fullTypeName == "Unity.UI.Builder.UnityUIBuilderSelectionMarker";
								if (!flag8)
								{
									Debug.LogWarning("VisualTreeAsset instantiated an empty UI. Check the syntax of your UXML document.");
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00066B60 File Offset: 0x00064D60
		private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context)
		{
			bool skipClone = root.skipClone;
			VisualElement result;
			if (skipClone)
			{
				result = null;
			}
			else
			{
				VisualElement visualElement = VisualTreeAsset.Create(root, context);
				bool flag = visualElement == null;
				if (flag)
				{
					result = null;
				}
				else
				{
					bool flag2 = root.id == context.visualTreeAsset.contentContainerId;
					if (flag2)
					{
						bool flag3 = context.target is TemplateContainer;
						if (flag3)
						{
							((TemplateContainer)context.target).SetContentContainer(visualElement);
						}
						else
						{
							Debug.LogError("Trying to clone a VisualTreeAsset with a custom content container into a element which is not a template container");
						}
					}
					string key;
					bool flag4 = context.slotInsertionPoints != null && this.TryGetSlotInsertionPoint(root.id, out key);
					if (flag4)
					{
						context.slotInsertionPoints.Add(key, visualElement);
					}
					bool flag5 = root.ruleIndex != -1;
					if (flag5)
					{
						bool flag6 = this.inlineSheet == null;
						if (flag6)
						{
							Debug.LogWarning("VisualElementAsset has a RuleIndex but no inlineStyleSheet");
						}
						else
						{
							StyleRule rule = this.inlineSheet.rules[root.ruleIndex];
							visualElement.SetInlineRule(this.inlineSheet, rule);
						}
					}
					TemplateAsset templateAsset = root as TemplateAsset;
					List<VisualElementAsset> list;
					bool flag7 = idToChildren.TryGetValue(root.id, out list);
					if (flag7)
					{
						list.Sort(new Comparison<VisualElementAsset>(VisualTreeAsset.CompareForOrder));
						using (List<VisualElementAsset>.Enumerator enumerator = list.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								VisualElementAsset childVea = enumerator.Current;
								VisualElement visualElement2 = this.CloneSetupRecursively(childVea, idToChildren, context);
								bool flag8 = visualElement2 == null;
								if (!flag8)
								{
									bool flag9 = templateAsset == null;
									if (flag9)
									{
										visualElement.Add(visualElement2);
									}
									else
									{
										int num = (templateAsset.slotUsages == null) ? -1 : templateAsset.slotUsages.FindIndex((VisualTreeAsset.SlotUsageEntry u) => u.assetId == childVea.id);
										bool flag10 = num != -1;
										if (flag10)
										{
											string slotName = templateAsset.slotUsages[num].slotName;
											Assert.IsFalse(string.IsNullOrEmpty(slotName), "a lost name should not be null or empty, this probably points to an importer or serialization bug");
											VisualElement visualElement3;
											bool flag11 = context.slotInsertionPoints == null || !context.slotInsertionPoints.TryGetValue(slotName, out visualElement3);
											if (flag11)
											{
												Debug.LogErrorFormat("Slot '{0}' was not found. Existing slots: {1}", new object[]
												{
													slotName,
													(context.slotInsertionPoints == null) ? string.Empty : string.Join(", ", context.slotInsertionPoints.Keys.ToArray<string>())
												});
												visualElement.Add(visualElement2);
											}
											else
											{
												visualElement3.Add(visualElement2);
											}
										}
										else
										{
											visualElement.Add(visualElement2);
										}
									}
								}
							}
						}
					}
					bool flag12 = templateAsset != null && context.slotInsertionPoints != null;
					if (flag12)
					{
						context.slotInsertionPoints.Clear();
					}
					result = visualElement;
				}
			}
			return result;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00066E58 File Offset: 0x00065058
		private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b)
		{
			return a.orderInDocument.CompareTo(b.orderInDocument);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00066E7C File Offset: 0x0006507C
		internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
		{
			bool flag = this.m_Slots == null;
			bool result;
			if (flag)
			{
				slotName = null;
				result = false;
			}
			else
			{
				for (int i = 0; i < this.m_Slots.Count; i++)
				{
					VisualTreeAsset.SlotDefinition slotDefinition = this.m_Slots[i];
					bool flag2 = slotDefinition.insertionPointId == insertionPointId;
					if (flag2)
					{
						slotName = slotDefinition.name;
						return true;
					}
				}
				slotName = null;
				result = false;
			}
			return result;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00066EF0 File Offset: 0x000650F0
		internal VisualTreeAsset ResolveTemplate(string templateName)
		{
			bool flag = this.m_Usings == null || this.m_Usings.Count == 0;
			VisualTreeAsset result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int num = this.m_Usings.BinarySearch(new VisualTreeAsset.UsingEntry(templateName, string.Empty), VisualTreeAsset.UsingEntry.comparer);
				bool flag2 = num < 0;
				if (flag2)
				{
					result = null;
				}
				else
				{
					bool flag3 = this.m_Usings[num].asset;
					if (flag3)
					{
						result = this.m_Usings[num].asset;
					}
					else
					{
						string path = this.m_Usings[num].path;
						result = (Panel.LoadResource(path, typeof(VisualTreeAsset), GUIUtility.pixelsPerPoint) as VisualTreeAsset);
					}
				}
			}
			return result;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00066FAC File Offset: 0x000651AC
		internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx)
		{
			VisualTreeAsset.<>c__DisplayClass49_0 CS$<>8__locals1;
			CS$<>8__locals1.asset = asset;
			List<IUxmlFactory> list;
			bool flag = !VisualElementFactoryRegistry.TryGetValue(CS$<>8__locals1.asset.fullTypeName, out list);
			if (flag)
			{
				bool flag2 = CS$<>8__locals1.asset.fullTypeName.StartsWith("UnityEngine.Experimental.UIElements.") || CS$<>8__locals1.asset.fullTypeName.StartsWith("UnityEditor.Experimental.UIElements.");
				if (flag2)
				{
					string fullTypeName = CS$<>8__locals1.asset.fullTypeName.Replace(".Experimental.UIElements", ".UIElements");
					bool flag3 = !VisualElementFactoryRegistry.TryGetValue(fullTypeName, out list);
					if (flag3)
					{
						return VisualTreeAsset.<Create>g__CreateError|49_0(ref CS$<>8__locals1);
					}
				}
				else
				{
					bool flag4 = CS$<>8__locals1.asset.fullTypeName == "UnityEditor.UIElements.ProgressBar";
					if (flag4)
					{
						string fullTypeName2 = CS$<>8__locals1.asset.fullTypeName.Replace("UnityEditor", "UnityEngine");
						bool flag5 = !VisualElementFactoryRegistry.TryGetValue(fullTypeName2, out list);
						if (flag5)
						{
							return VisualTreeAsset.<Create>g__CreateError|49_0(ref CS$<>8__locals1);
						}
					}
					else
					{
						bool flag6 = CS$<>8__locals1.asset.fullTypeName == "UXML";
						if (!flag6)
						{
							return VisualTreeAsset.<Create>g__CreateError|49_0(ref CS$<>8__locals1);
						}
						VisualElementFactoryRegistry.TryGetValue(typeof(UxmlRootElementFactory).Namespace + "." + CS$<>8__locals1.asset.fullTypeName, out list);
					}
				}
			}
			IUxmlFactory uxmlFactory = null;
			foreach (IUxmlFactory uxmlFactory2 in list)
			{
				bool flag7 = uxmlFactory2.AcceptsAttributeBag(CS$<>8__locals1.asset, ctx);
				if (flag7)
				{
					uxmlFactory = uxmlFactory2;
					break;
				}
			}
			bool flag8 = uxmlFactory == null;
			VisualElement result;
			if (flag8)
			{
				Debug.LogErrorFormat("Element '{0}' has a no factory that accept the set of XML attributes specified.", new object[]
				{
					CS$<>8__locals1.asset.fullTypeName
				});
				result = new Label(string.Format("Type with no factory: '{0}'", CS$<>8__locals1.asset.fullTypeName));
			}
			else
			{
				VisualElement visualElement = uxmlFactory.Create(CS$<>8__locals1.asset, ctx);
				bool flag9 = visualElement != null;
				if (flag9)
				{
					VisualTreeAsset.AssignClassListFromAssetToElement(CS$<>8__locals1.asset, visualElement);
					VisualTreeAsset.AssignStyleSheetFromAssetToElement(CS$<>8__locals1.asset, visualElement);
				}
				result = visualElement;
			}
			return result;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000671F4 File Offset: 0x000653F4
		private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
			bool flag = asset.classes != null;
			if (flag)
			{
				for (int i = 0; i < asset.classes.Length; i++)
				{
					element.AddToClassList(asset.classes[i]);
				}
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0006723C File Offset: 0x0006543C
		private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
			bool hasStylesheetPaths = asset.hasStylesheetPaths;
			if (hasStylesheetPaths)
			{
				for (int i = 0; i < asset.stylesheetPaths.Count; i++)
				{
					element.AddStyleSheetPath(asset.stylesheetPaths[i]);
				}
			}
			bool hasStylesheets = asset.hasStylesheets;
			if (hasStylesheets)
			{
				for (int j = 0; j < asset.stylesheets.Count; j++)
				{
					bool flag = asset.stylesheets[j] != null;
					if (flag)
					{
						element.styleSheets.Add(asset.stylesheets[j]);
					}
				}
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x000672EC File Offset: 0x000654EC
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x00067304 File Offset: 0x00065504
		public int contentHash
		{
			get
			{
				return this.m_ContentHash;
			}
			set
			{
				this.m_ContentHash = value;
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00067324 File Offset: 0x00065524
		[CompilerGenerated]
		internal static VisualElement <Create>g__CreateError|49_0(ref VisualTreeAsset.<>c__DisplayClass49_0 A_0)
		{
			Debug.LogErrorFormat("Element '{0}' has no registered factory method.", new object[]
			{
				A_0.asset.fullTypeName
			});
			return new Label(string.Format("Unknown type: '{0}'", A_0.asset.fullTypeName));
		}

		// Token: 0x04000AC7 RID: 2759
		internal static string LinkedVEAInTemplatePropertyName = "--unity-linked-vea-in-template";

		// Token: 0x04000AC8 RID: 2760
		[SerializeField]
		private bool m_ImportedWithErrors;

		// Token: 0x04000AC9 RID: 2761
		[SerializeField]
		private bool m_ImportedWithWarnings;

		// Token: 0x04000ACA RID: 2762
		private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints = new Dictionary<string, VisualElement>();

		// Token: 0x04000ACB RID: 2763
		[SerializeField]
		private List<VisualTreeAsset.UsingEntry> m_Usings;

		// Token: 0x04000ACC RID: 2764
		[SerializeField]
		internal StyleSheet inlineSheet;

		// Token: 0x04000ACD RID: 2765
		[SerializeField]
		private List<VisualElementAsset> m_VisualElementAssets;

		// Token: 0x04000ACE RID: 2766
		[SerializeField]
		private List<TemplateAsset> m_TemplateAssets;

		// Token: 0x04000ACF RID: 2767
		[SerializeField]
		private List<VisualTreeAsset.SlotDefinition> m_Slots;

		// Token: 0x04000AD0 RID: 2768
		[SerializeField]
		private int m_ContentContainerId;

		// Token: 0x04000AD1 RID: 2769
		[SerializeField]
		private int m_ContentHash;

		// Token: 0x020002F7 RID: 759
		[Serializable]
		internal struct UsingEntry
		{
			// Token: 0x06001946 RID: 6470 RVA: 0x0006736F File Offset: 0x0006556F
			public UsingEntry(string alias, string path)
			{
				this.alias = alias;
				this.path = path;
				this.asset = null;
			}

			// Token: 0x06001947 RID: 6471 RVA: 0x00067387 File Offset: 0x00065587
			public UsingEntry(string alias, VisualTreeAsset asset)
			{
				this.alias = alias;
				this.path = null;
				this.asset = asset;
			}

			// Token: 0x04000AD2 RID: 2770
			internal static readonly IComparer<VisualTreeAsset.UsingEntry> comparer = new VisualTreeAsset.UsingEntryComparer();

			// Token: 0x04000AD3 RID: 2771
			[SerializeField]
			public string alias;

			// Token: 0x04000AD4 RID: 2772
			[SerializeField]
			public string path;

			// Token: 0x04000AD5 RID: 2773
			[SerializeField]
			public VisualTreeAsset asset;
		}

		// Token: 0x020002F8 RID: 760
		private class UsingEntryComparer : IComparer<VisualTreeAsset.UsingEntry>
		{
			// Token: 0x06001949 RID: 6473 RVA: 0x000673AC File Offset: 0x000655AC
			public int Compare(VisualTreeAsset.UsingEntry x, VisualTreeAsset.UsingEntry y)
			{
				return string.CompareOrdinal(x.alias, y.alias);
			}
		}

		// Token: 0x020002F9 RID: 761
		[Serializable]
		internal struct SlotDefinition
		{
			// Token: 0x04000AD6 RID: 2774
			[SerializeField]
			public string name;

			// Token: 0x04000AD7 RID: 2775
			[SerializeField]
			public int insertionPointId;
		}

		// Token: 0x020002FA RID: 762
		[Serializable]
		internal struct SlotUsageEntry
		{
			// Token: 0x0600194B RID: 6475 RVA: 0x000673CF File Offset: 0x000655CF
			public SlotUsageEntry(string slotName, int assetId)
			{
				this.slotName = slotName;
				this.assetId = assetId;
			}

			// Token: 0x04000AD8 RID: 2776
			[SerializeField]
			public string slotName;

			// Token: 0x04000AD9 RID: 2777
			[SerializeField]
			public int assetId;
		}
	}
}
