using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002A9 RID: 681
	[Serializable]
	internal struct StyleSelectorPart
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x000617F0 File Offset: 0x0005F9F0
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x00061808 File Offset: 0x0005FA08
		public string value
		{
			get
			{
				return this.m_Value;
			}
			internal set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00061814 File Offset: 0x0005FA14
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x0006182C File Offset: 0x0005FA2C
		public StyleSelectorType type
		{
			get
			{
				return this.m_Type;
			}
			internal set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00061838 File Offset: 0x0005FA38
		public override string ToString()
		{
			return UnityString.Format("[StyleSelectorPart: value={0}, type={1}]", new object[]
			{
				this.value,
				this.type
			});
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00061874 File Offset: 0x0005FA74
		public static StyleSelectorPart CreateClass(string className)
		{
			return new StyleSelectorPart
			{
				m_Type = StyleSelectorType.Class,
				m_Value = className
			};
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000618A0 File Offset: 0x0005FAA0
		public static StyleSelectorPart CreatePseudoClass(string className)
		{
			return new StyleSelectorPart
			{
				m_Type = StyleSelectorType.PseudoClass,
				m_Value = className
			};
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000618CC File Offset: 0x0005FACC
		public static StyleSelectorPart CreateId(string Id)
		{
			return new StyleSelectorPart
			{
				m_Type = StyleSelectorType.ID,
				m_Value = Id
			};
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000618F8 File Offset: 0x0005FAF8
		public static StyleSelectorPart CreateType(Type t)
		{
			return new StyleSelectorPart
			{
				m_Type = StyleSelectorType.Type,
				m_Value = t.Name
			};
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00061928 File Offset: 0x0005FB28
		public static StyleSelectorPart CreateType(string typeName)
		{
			return new StyleSelectorPart
			{
				m_Type = StyleSelectorType.Type,
				m_Value = typeName
			};
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00061954 File Offset: 0x0005FB54
		public static StyleSelectorPart CreatePredicate(object predicate)
		{
			return new StyleSelectorPart
			{
				m_Type = StyleSelectorType.Predicate,
				tempData = predicate
			};
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00061980 File Offset: 0x0005FB80
		public static StyleSelectorPart CreateWildCard()
		{
			return new StyleSelectorPart
			{
				m_Type = StyleSelectorType.Wildcard
			};
		}

		// Token: 0x040009DC RID: 2524
		[SerializeField]
		private string m_Value;

		// Token: 0x040009DD RID: 2525
		[SerializeField]
		private StyleSelectorType m_Type;

		// Token: 0x040009DE RID: 2526
		internal object tempData;
	}
}
