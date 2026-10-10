using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200036B RID: 875
	internal static class StyleSheetCache
	{
		// Token: 0x06001C4B RID: 7243 RVA: 0x00085831 File Offset: 0x00083A31
		internal static void ClearCaches()
		{
			StyleSheetCache.s_RulePropertyIdsCache.Clear();
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00085840 File Offset: 0x00083A40
		internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex)
		{
			StyleSheetCache.SheetHandleKey key = new StyleSheetCache.SheetHandleKey(sheet, ruleIndex);
			StylePropertyId[] array;
			bool flag = !StyleSheetCache.s_RulePropertyIdsCache.TryGetValue(key, out array);
			if (flag)
			{
				StyleRule styleRule = sheet.rules[ruleIndex];
				array = new StylePropertyId[styleRule.properties.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = StyleSheetCache.GetPropertyId(styleRule, i);
				}
				StyleSheetCache.s_RulePropertyIdsCache.Add(key, array);
			}
			return array;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x000858C0 File Offset: 0x00083AC0
		internal static StylePropertyId[] GetPropertyIds(StyleRule rule)
		{
			StylePropertyId[] array = new StylePropertyId[rule.properties.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = StyleSheetCache.GetPropertyId(rule, i);
			}
			return array;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00085900 File Offset: 0x00083B00
		private static StylePropertyId GetPropertyId(StyleRule rule, int index)
		{
			StyleProperty styleProperty = rule.properties[index];
			string name = styleProperty.name;
			StylePropertyId result;
			bool flag = !StylePropertyUtil.s_NameToId.TryGetValue(name, out result);
			if (flag)
			{
				result = (styleProperty.isCustomProperty ? StylePropertyId.Custom : StylePropertyId.Unknown);
			}
			return result;
		}

		// Token: 0x04000E1F RID: 3615
		private static StyleSheetCache.SheetHandleKeyComparer s_Comparer = new StyleSheetCache.SheetHandleKeyComparer();

		// Token: 0x04000E20 RID: 3616
		private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache = new Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyId[]>(StyleSheetCache.s_Comparer);

		// Token: 0x0200036C RID: 876
		private struct SheetHandleKey
		{
			// Token: 0x06001C50 RID: 7248 RVA: 0x00085963 File Offset: 0x00083B63
			public SheetHandleKey(StyleSheet sheet, int index)
			{
				this.sheetInstanceID = sheet.GetInstanceID();
				this.index = index;
			}

			// Token: 0x04000E21 RID: 3617
			public readonly int sheetInstanceID;

			// Token: 0x04000E22 RID: 3618
			public readonly int index;
		}

		// Token: 0x0200036D RID: 877
		private class SheetHandleKeyComparer : IEqualityComparer<StyleSheetCache.SheetHandleKey>
		{
			// Token: 0x06001C51 RID: 7249 RVA: 0x0008597C File Offset: 0x00083B7C
			public bool Equals(StyleSheetCache.SheetHandleKey x, StyleSheetCache.SheetHandleKey y)
			{
				return x.sheetInstanceID == y.sheetInstanceID && x.index == y.index;
			}

			// Token: 0x06001C52 RID: 7250 RVA: 0x000859B0 File Offset: 0x00083BB0
			public int GetHashCode(StyleSheetCache.SheetHandleKey key)
			{
				return key.sheetInstanceID.GetHashCode() ^ key.index.GetHashCode();
			}
		}
	}
}
