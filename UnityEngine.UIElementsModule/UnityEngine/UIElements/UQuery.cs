using System;
using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C7 RID: 199
	public static class UQuery
	{
		// Token: 0x020000C8 RID: 200
		internal interface IVisualPredicateWrapper
		{
			// Token: 0x060006AA RID: 1706
			bool Predicate(object e);
		}

		// Token: 0x020000C9 RID: 201
		internal class IsOfType<T> : UQuery.IVisualPredicateWrapper where T : VisualElement
		{
			// Token: 0x060006AB RID: 1707 RVA: 0x000190D0 File Offset: 0x000172D0
			public bool Predicate(object e)
			{
				return e is T;
			}

			// Token: 0x040002A0 RID: 672
			public static UQuery.IsOfType<T> s_Instance = new UQuery.IsOfType<T>();
		}

		// Token: 0x020000CA RID: 202
		internal class PredicateWrapper<T> : UQuery.IVisualPredicateWrapper where T : VisualElement
		{
			// Token: 0x060006AE RID: 1710 RVA: 0x000190F7 File Offset: 0x000172F7
			public PredicateWrapper(Func<T, bool> p)
			{
				this.predicate = p;
			}

			// Token: 0x060006AF RID: 1711 RVA: 0x00019108 File Offset: 0x00017308
			public bool Predicate(object e)
			{
				T t = e as T;
				bool flag = t != null;
				return flag && this.predicate(t);
			}

			// Token: 0x040002A1 RID: 673
			private Func<T, bool> predicate;
		}

		// Token: 0x020000CB RID: 203
		internal abstract class UQueryMatcher : HierarchyTraversal
		{
			// Token: 0x060006B1 RID: 1713 RVA: 0x0001914E File Offset: 0x0001734E
			public override void Traverse(VisualElement element)
			{
				base.Traverse(element);
			}

			// Token: 0x060006B2 RID: 1714 RVA: 0x0001915C File Offset: 0x0001735C
			protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				return false;
			}

			// Token: 0x060006B3 RID: 1715 RVA: 0x00002166 File Offset: 0x00000366
			private static void NoProcessResult(VisualElement e, MatchResultInfo i)
			{
			}

			// Token: 0x060006B4 RID: 1716 RVA: 0x00019170 File Offset: 0x00017370
			public override void TraverseRecursive(VisualElement element, int depth)
			{
				int count = this.m_Matchers.Count;
				int count2 = this.m_Matchers.Count;
				for (int j = 0; j < count2; j++)
				{
					RuleMatcher ruleMatcher = this.m_Matchers[j];
					bool flag = StyleSelectorHelper.MatchRightToLeft(element, ruleMatcher.complexSelector, delegate(VisualElement e, MatchResultInfo i)
					{
						UQuery.UQueryMatcher.NoProcessResult(e, i);
					});
					if (flag)
					{
						bool flag2 = this.OnRuleMatchedElement(ruleMatcher, element);
						if (flag2)
						{
							return;
						}
					}
				}
				base.Recurse(element, depth);
				bool flag3 = this.m_Matchers.Count > count;
				if (flag3)
				{
					this.m_Matchers.RemoveRange(count, this.m_Matchers.Count - count);
					return;
				}
			}

			// Token: 0x060006B5 RID: 1717 RVA: 0x00019234 File Offset: 0x00017434
			public virtual void Run(VisualElement root, List<RuleMatcher> matchers)
			{
				this.m_Matchers = matchers;
				this.Traverse(root);
			}

			// Token: 0x040002A2 RID: 674
			internal List<RuleMatcher> m_Matchers;
		}

		// Token: 0x020000CD RID: 205
		internal abstract class SingleQueryMatcher : UQuery.UQueryMatcher
		{
			// Token: 0x17000173 RID: 371
			// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0001925C File Offset: 0x0001745C
			// (set) Token: 0x060006BA RID: 1722 RVA: 0x00019264 File Offset: 0x00017464
			public VisualElement match { get; set; }

			// Token: 0x060006BB RID: 1723 RVA: 0x0001926D File Offset: 0x0001746D
			public override void Run(VisualElement root, List<RuleMatcher> matchers)
			{
				this.match = null;
				base.Run(root, matchers);
				this.m_Matchers = null;
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x00019288 File Offset: 0x00017488
			public bool IsInUse()
			{
				return this.m_Matchers != null;
			}

			// Token: 0x060006BD RID: 1725
			public abstract UQuery.SingleQueryMatcher CreateNew();
		}

		// Token: 0x020000CE RID: 206
		internal class FirstQueryMatcher : UQuery.SingleQueryMatcher
		{
			// Token: 0x060006BF RID: 1727 RVA: 0x000192AC File Offset: 0x000174AC
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				bool flag = base.match == null;
				if (flag)
				{
					base.match = element;
				}
				return true;
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x000192D4 File Offset: 0x000174D4
			public override UQuery.SingleQueryMatcher CreateNew()
			{
				return new UQuery.FirstQueryMatcher();
			}

			// Token: 0x040002A6 RID: 678
			public static readonly UQuery.FirstQueryMatcher Instance = new UQuery.FirstQueryMatcher();
		}

		// Token: 0x020000CF RID: 207
		internal class LastQueryMatcher : UQuery.SingleQueryMatcher
		{
			// Token: 0x060006C3 RID: 1731 RVA: 0x000192F0 File Offset: 0x000174F0
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				base.match = element;
				return false;
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x0001930B File Offset: 0x0001750B
			public override UQuery.SingleQueryMatcher CreateNew()
			{
				return new UQuery.LastQueryMatcher();
			}

			// Token: 0x040002A7 RID: 679
			public static readonly UQuery.LastQueryMatcher Instance = new UQuery.LastQueryMatcher();
		}

		// Token: 0x020000D0 RID: 208
		internal class IndexQueryMatcher : UQuery.SingleQueryMatcher
		{
			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00019320 File Offset: 0x00017520
			// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00019338 File Offset: 0x00017538
			public int matchIndex
			{
				get
				{
					return this._matchIndex;
				}
				set
				{
					this.matchCount = -1;
					this._matchIndex = value;
				}
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x00019349 File Offset: 0x00017549
			public override void Run(VisualElement root, List<RuleMatcher> matchers)
			{
				this.matchCount = -1;
				base.Run(root, matchers);
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x0001935C File Offset: 0x0001755C
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				this.matchCount++;
				bool flag = this.matchCount == this._matchIndex;
				if (flag)
				{
					base.match = element;
				}
				return this.matchCount >= this._matchIndex;
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x000193A9 File Offset: 0x000175A9
			public override UQuery.SingleQueryMatcher CreateNew()
			{
				return new UQuery.IndexQueryMatcher();
			}

			// Token: 0x040002A8 RID: 680
			public static readonly UQuery.IndexQueryMatcher Instance = new UQuery.IndexQueryMatcher();

			// Token: 0x040002A9 RID: 681
			private int matchCount = -1;

			// Token: 0x040002AA RID: 682
			private int _matchIndex;
		}
	}
}
