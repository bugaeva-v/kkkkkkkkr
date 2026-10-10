using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x02000279 RID: 633
	internal class InlineStyleAccess : StyleValueCollection, IStyle
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00056485 File Offset: 0x00054685
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x0005648D File Offset: 0x0005468D
		private VisualElement ve { get; set; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00056496 File Offset: 0x00054696
		public InlineStyleAccess.InlineRule inlineRule
		{
			get
			{
				return this.m_InlineRule;
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0005649E File Offset: 0x0005469E
		public InlineStyleAccess(VisualElement ve)
		{
			this.ve = ve;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000564B0 File Offset: 0x000546B0
		protected override void Finalize()
		{
			try
			{
				StyleValue styleValue = default(StyleValue);
				bool flag = base.TryGetStyleValue(StylePropertyId.BackgroundImage, ref styleValue);
				if (flag)
				{
					bool isAllocated = styleValue.resource.IsAllocated;
					if (isAllocated)
					{
						styleValue.resource.Free();
					}
				}
				bool flag2 = base.TryGetStyleValue(StylePropertyId.UnityFont, ref styleValue);
				if (flag2)
				{
					bool isAllocated2 = styleValue.resource.IsAllocated;
					if (isAllocated2)
					{
						styleValue.resource.Free();
					}
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00056544 File Offset: 0x00054744
		public void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
			this.m_InlineRule.sheet = sheet;
			this.m_InlineRule.rule = rule;
			this.m_InlineRule.propertyIds = StyleSheetCache.GetPropertyIds(rule);
			this.ApplyInlineStyles(this.ve.computedStyle);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00056584 File Offset: 0x00054784
		public bool IsValueSet(StylePropertyId id)
		{
			foreach (StyleValue styleValue in this.m_Values)
			{
				bool flag = styleValue.id == id;
				if (flag)
				{
					return true;
				}
			}
			bool flag2 = this.m_ValuesManaged != null;
			if (flag2)
			{
				foreach (StyleValueManaged styleValueManaged in this.m_ValuesManaged)
				{
					bool flag3 = styleValueManaged.id == id;
					if (flag3)
					{
						return true;
					}
				}
			}
			bool result;
			if (id != StylePropertyId.TextShadow)
			{
				if (id != StylePropertyId.Cursor)
				{
					switch (id)
					{
					case StylePropertyId.Rotate:
						result = this.m_HasInlineRotate;
						break;
					case StylePropertyId.Scale:
						result = this.m_HasInlineScale;
						break;
					case StylePropertyId.TransformOrigin:
						result = this.m_HasInlineTransformOrigin;
						break;
					case StylePropertyId.Translate:
						result = this.m_HasInlineTranslate;
						break;
					default:
						result = false;
						break;
					}
				}
				else
				{
					result = this.m_HasInlineCursor;
				}
			}
			else
			{
				result = this.m_HasInlineTextShadow;
			}
			return result;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x000566CC File Offset: 0x000548CC
		public void ApplyInlineStyles(ref ComputedStyle computedStyle)
		{
			VisualElement parent = this.ve.hierarchy.parent;
			ComputedStyle ptr;
			if (parent != null)
			{
				ref ComputedStyle computedStyle2 = ref parent.computedStyle;
				ptr = parent.computedStyle;
			}
			else
			{
				ptr = InitialStyle.Get();
			}
			ref ComputedStyle parentStyle = ref ptr;
			bool flag = this.m_InlineRule.sheet != null;
			if (flag)
			{
				InlineStyleAccess.s_StylePropertyReader.SetInlineContext(this.m_InlineRule.sheet, this.m_InlineRule.rule.properties, this.m_InlineRule.propertyIds, 1f);
				computedStyle.ApplyProperties(InlineStyleAccess.s_StylePropertyReader, ref parentStyle);
			}
			foreach (StyleValue sv in this.m_Values)
			{
				computedStyle.ApplyStyleValue(sv, ref parentStyle);
			}
			bool flag2 = this.m_ValuesManaged != null;
			if (flag2)
			{
				foreach (StyleValueManaged sv2 in this.m_ValuesManaged)
				{
					computedStyle.ApplyStyleValueManaged(sv2, ref parentStyle);
				}
			}
			bool flag3 = this.ve.style.cursor.keyword != StyleKeyword.Null;
			if (flag3)
			{
				computedStyle.ApplyStyleCursor(this.ve.style.cursor.value);
			}
			bool flag4 = this.ve.style.textShadow.keyword != StyleKeyword.Null;
			if (flag4)
			{
				computedStyle.ApplyStyleTextShadow(this.ve.style.textShadow.value);
			}
			bool hasInlineTransformOrigin = this.m_HasInlineTransformOrigin;
			if (hasInlineTransformOrigin)
			{
				computedStyle.ApplyStyleTransformOrigin(this.ve.style.transformOrigin.value);
			}
			bool hasInlineTranslate = this.m_HasInlineTranslate;
			if (hasInlineTranslate)
			{
				computedStyle.ApplyStyleTranslate(this.ve.style.translate.value);
			}
			bool hasInlineScale = this.m_HasInlineScale;
			if (hasInlineScale)
			{
				computedStyle.ApplyStyleScale(this.ve.style.scale.value);
			}
			bool hasInlineRotate = this.m_HasInlineRotate;
			if (hasInlineRotate)
			{
				computedStyle.ApplyStyleRotate(this.ve.style.rotate.value);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x00056954 File Offset: 0x00054B54
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x00056984 File Offset: 0x00054B84
		StyleCursor IStyle.cursor
		{
			get
			{
				StyleCursor styleCursor = default(StyleCursor);
				bool flag = this.TryGetInlineCursor(ref styleCursor);
				StyleCursor result;
				if (flag)
				{
					result = styleCursor;
				}
				else
				{
					result = StyleKeyword.Null;
				}
				return result;
			}
			set
			{
				bool flag = this.SetInlineCursor(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x000569B0 File Offset: 0x00054BB0
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x000569E0 File Offset: 0x00054BE0
		StyleTextShadow IStyle.textShadow
		{
			get
			{
				StyleTextShadow styleTextShadow = default(StyleTextShadow);
				bool flag = this.TryGetInlineTextShadow(ref styleTextShadow);
				StyleTextShadow result;
				if (flag)
				{
					result = styleTextShadow;
				}
				else
				{
					result = StyleKeyword.Null;
				}
				return result;
			}
			set
			{
				bool flag = this.SetInlineTextShadow(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00056A0C File Offset: 0x00054C0C
		private StyleList<T> GetStyleList<T>(StylePropertyId id)
		{
			StyleValueManaged styleValueManaged = default(StyleValueManaged);
			bool flag = this.TryGetStyleValueManaged(id, ref styleValueManaged);
			StyleList<T> result;
			if (flag)
			{
				result = new StyleList<T>(styleValueManaged.value as List<T>, styleValueManaged.keyword);
			}
			else
			{
				result = StyleKeyword.Null;
			}
			return result;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00056A54 File Offset: 0x00054C54
		private void SetStyleValueManaged(StyleValueManaged value)
		{
			bool flag = this.m_ValuesManaged == null;
			if (flag)
			{
				this.m_ValuesManaged = new List<StyleValueManaged>();
			}
			for (int i = 0; i < this.m_ValuesManaged.Count; i++)
			{
				bool flag2 = this.m_ValuesManaged[i].id == value.id;
				if (flag2)
				{
					bool flag3 = value.keyword == StyleKeyword.Null;
					if (flag3)
					{
						this.m_ValuesManaged.RemoveAt(i);
					}
					else
					{
						this.m_ValuesManaged[i] = value;
					}
					return;
				}
			}
			this.m_ValuesManaged.Add(value);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00056AF4 File Offset: 0x00054CF4
		private bool TryGetStyleValueManaged(StylePropertyId id, ref StyleValueManaged value)
		{
			value.id = StylePropertyId.Unknown;
			bool flag = this.m_ValuesManaged == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				foreach (StyleValueManaged styleValueManaged in this.m_ValuesManaged)
				{
					bool flag2 = styleValueManaged.id == id;
					if (flag2)
					{
						value = styleValueManaged;
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00056B80 File Offset: 0x00054D80
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x00056BB0 File Offset: 0x00054DB0
		StyleTransformOrigin IStyle.transformOrigin
		{
			get
			{
				StyleTransformOrigin styleTransformOrigin = default(StyleTransformOrigin);
				bool flag = this.TryGetInlineTransformOrigin(ref styleTransformOrigin);
				StyleTransformOrigin result;
				if (flag)
				{
					result = styleTransformOrigin;
				}
				else
				{
					result = StyleKeyword.Null;
				}
				return result;
			}
			set
			{
				bool flag = this.SetInlineTransformOrigin(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00056BDC File Offset: 0x00054DDC
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x00056C0C File Offset: 0x00054E0C
		StyleTranslate IStyle.translate
		{
			get
			{
				StyleTranslate styleTranslate = default(StyleTranslate);
				bool flag = this.TryGetInlineTranslate(ref styleTranslate);
				StyleTranslate result;
				if (flag)
				{
					result = styleTranslate;
				}
				else
				{
					result = StyleKeyword.Null;
				}
				return result;
			}
			set
			{
				bool flag = this.SetInlineTranslate(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x00056C38 File Offset: 0x00054E38
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00056C68 File Offset: 0x00054E68
		StyleRotate IStyle.rotate
		{
			get
			{
				StyleRotate styleRotate = default(StyleRotate);
				bool flag = this.TryGetInlineRotate(ref styleRotate);
				StyleRotate result;
				if (flag)
				{
					result = styleRotate;
				}
				else
				{
					result = StyleKeyword.Null;
				}
				return result;
			}
			set
			{
				bool flag = this.SetInlineRotate(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00056C94 File Offset: 0x00054E94
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x00056CC4 File Offset: 0x00054EC4
		StyleScale IStyle.scale
		{
			get
			{
				StyleScale styleScale = default(StyleScale);
				bool flag = this.TryGetInlineScale(ref styleScale);
				StyleScale result;
				if (flag)
				{
					result = styleScale;
				}
				else
				{
					result = StyleKeyword.Null;
				}
				return result;
			}
			set
			{
				bool flag = this.SetInlineScale(value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00056CF0 File Offset: 0x00054EF0
		private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue)
		{
			StyleValue styleValue = default(StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.length == inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.length = inlineValue.ToLength();
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00056DAC File Offset: 0x00054FAC
		private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue)
		{
			StyleValue styleValue = default(StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.number == inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.number = inlineValue.value;
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00056E64 File Offset: 0x00055064
		private bool SetStyleValue(StylePropertyId id, StyleInt inlineValue)
		{
			StyleValue styleValue = default(StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.number == (float)inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.number = (float)inlineValue.value;
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00056F20 File Offset: 0x00055120
		private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue)
		{
			StyleValue styleValue = default(StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.color == inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.color = inlineValue.value;
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00056FE0 File Offset: 0x000551E0
		private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue) where T : struct, IConvertible
		{
			StyleValue styleValue = default(StyleValue);
			int num = UnsafeUtility.EnumToInt<T>(inlineValue.value);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.number == (float)num && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.number = (float)num;
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000570A0 File Offset: 0x000552A0
		private bool SetStyleValue(StylePropertyId id, StyleBackground inlineValue)
		{
			StyleValue styleValue = default(StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				VectorImage x = styleValue.resource.IsAllocated ? (styleValue.resource.Target as VectorImage) : null;
				Sprite x2 = styleValue.resource.IsAllocated ? (styleValue.resource.Target as Sprite) : null;
				Texture2D x3 = styleValue.resource.IsAllocated ? (styleValue.resource.Target as Texture2D) : null;
				RenderTexture x4 = styleValue.resource.IsAllocated ? (styleValue.resource.Target as RenderTexture) : null;
				bool flag2 = x == inlineValue.value.vectorImage && x3 == inlineValue.value.texture && x2 == inlineValue.value.sprite && x4 == inlineValue.value.renderTexture && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
				bool isAllocated = styleValue.resource.IsAllocated;
				if (isAllocated)
				{
					styleValue.resource.Free();
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			bool flag4 = inlineValue.value.vectorImage != null;
			if (flag4)
			{
				styleValue.resource = GCHandle.Alloc(inlineValue.value.vectorImage);
			}
			else
			{
				bool flag5 = inlineValue.value.sprite != null;
				if (flag5)
				{
					styleValue.resource = GCHandle.Alloc(inlineValue.value.sprite);
				}
				else
				{
					bool flag6 = inlineValue.value.texture != null;
					if (flag6)
					{
						styleValue.resource = GCHandle.Alloc(inlineValue.value.texture);
					}
					else
					{
						bool flag7 = inlineValue.value.renderTexture != null;
						if (flag7)
						{
							styleValue.resource = GCHandle.Alloc(inlineValue.value.renderTexture);
						}
						else
						{
							styleValue.resource = default(GCHandle);
						}
					}
				}
			}
			base.SetStyleValue(styleValue);
			bool flag8 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag8)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00057358 File Offset: 0x00055558
		private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue)
		{
			StyleValue styleValue = default(StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				Font x = styleValue.resource.IsAllocated ? (styleValue.resource.Target as Font) : null;
				FontAsset x2 = styleValue.resource.IsAllocated ? (styleValue.resource.Target as FontAsset) : null;
				bool flag2 = x == inlineValue.value.font && x2 == inlineValue.value.fontAsset && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
				bool isAllocated = styleValue.resource.IsAllocated;
				if (isAllocated)
				{
					styleValue.resource.Free();
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			bool flag4 = inlineValue.value.font != null;
			if (flag4)
			{
				styleValue.resource = GCHandle.Alloc(inlineValue.value.font);
			}
			else
			{
				bool flag5 = inlineValue.value.fontAsset != null;
				if (flag5)
				{
					styleValue.resource = GCHandle.Alloc(inlineValue.value.fontAsset);
				}
				else
				{
					styleValue.resource = default(GCHandle);
				}
			}
			base.SetStyleValue(styleValue);
			bool flag6 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag6)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0005751C File Offset: 0x0005571C
		private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue)
		{
			StyleValue styleValue = default(StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool isAllocated = styleValue.resource.IsAllocated;
				if (isAllocated)
				{
					Font x = styleValue.resource.IsAllocated ? (styleValue.resource.Target as Font) : null;
					bool flag2 = x == inlineValue.value && styleValue.keyword == inlineValue.keyword;
					if (flag2)
					{
						return false;
					}
					bool isAllocated2 = styleValue.resource.IsAllocated;
					if (isAllocated2)
					{
						styleValue.resource.Free();
					}
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.resource = ((inlineValue.value != null) ? GCHandle.Alloc(inlineValue.value) : default(GCHandle));
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00057658 File Offset: 0x00055858
		private bool SetStyleValue<T>(StylePropertyId id, StyleList<T> inlineValue)
		{
			StyleValueManaged styleValueManaged = default(StyleValueManaged);
			bool flag = this.TryGetStyleValueManaged(id, ref styleValueManaged);
			if (flag)
			{
				List<T> list = styleValueManaged.value as List<T>;
				bool flag2 = list != null && inlineValue.value != null && list.SequenceEqual(inlineValue.value) && styleValueManaged.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValueManaged.id = id;
			styleValueManaged.keyword = inlineValue.keyword;
			bool flag4 = inlineValue.value != null;
			if (flag4)
			{
				bool flag5 = styleValueManaged.value == null;
				if (flag5)
				{
					styleValueManaged.value = new List<T>(inlineValue.value);
				}
				else
				{
					List<T> list2 = (List<T>)styleValueManaged.value;
					list2.Clear();
					list2.AddRange(inlineValue.value);
				}
			}
			else
			{
				styleValueManaged.value = null;
			}
			this.SetStyleValueManaged(styleValueManaged);
			bool flag6 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag6)
			{
				result = this.RemoveInlineStyle(id);
			}
			else
			{
				this.ApplyStyleValue(styleValueManaged);
				result = true;
			}
			return result;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00057790 File Offset: 0x00055990
		private bool SetInlineCursor(StyleCursor inlineValue)
		{
			StyleCursor styleCursor = default(StyleCursor);
			bool flag = this.TryGetInlineCursor(ref styleCursor);
			if (flag)
			{
				bool flag2 = styleCursor.value == inlineValue.value && styleCursor.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleCursor.value = inlineValue.value;
			styleCursor.keyword = inlineValue.keyword;
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				this.m_HasInlineCursor = false;
				result = this.RemoveInlineStyle(StylePropertyId.Cursor);
			}
			else
			{
				this.m_InlineCursor = styleCursor;
				this.m_HasInlineCursor = true;
				this.ApplyStyleCursor(styleCursor);
				result = true;
			}
			return result;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0005785C File Offset: 0x00055A5C
		private void ApplyStyleCursor(StyleCursor cursor)
		{
			this.ve.computedStyle.ApplyStyleCursor(cursor.value);
			BaseVisualElementPanel elementPanel = this.ve.elementPanel;
			bool flag = ((elementPanel != null) ? elementPanel.GetTopElementUnderPointer(PointerId.mousePointerId) : null) == this.ve;
			if (flag)
			{
				this.ve.elementPanel.cursorManager.SetCursor(cursor.value);
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x000578C8 File Offset: 0x00055AC8
		private bool SetInlineTextShadow(StyleTextShadow inlineValue)
		{
			StyleTextShadow styleTextShadow = default(StyleTextShadow);
			bool flag = this.TryGetInlineTextShadow(ref styleTextShadow);
			if (flag)
			{
				bool flag2 = styleTextShadow.value == inlineValue.value && styleTextShadow.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleTextShadow.value = inlineValue.value;
			styleTextShadow.keyword = inlineValue.keyword;
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				this.m_HasInlineTextShadow = false;
				result = this.RemoveInlineStyle(StylePropertyId.TextShadow);
			}
			else
			{
				this.m_InlineTextShadow = styleTextShadow;
				this.m_HasInlineTextShadow = true;
				this.ApplyStyleTextShadow(styleTextShadow);
				result = true;
			}
			return result;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00057994 File Offset: 0x00055B94
		private void ApplyStyleTextShadow(StyleTextShadow textShadow)
		{
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(StylePropertyId.TextShadow, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineTextShadow(this.ve, this.ve.computedStyle, textShadow, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(StylePropertyId.TextShadow);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleTextShadow(textShadow.value);
			}
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00057A5C File Offset: 0x00055C5C
		private bool SetInlineTransformOrigin(StyleTransformOrigin inlineValue)
		{
			StyleTransformOrigin styleTransformOrigin = default(StyleTransformOrigin);
			bool flag = this.TryGetInlineTransformOrigin(ref styleTransformOrigin);
			if (flag)
			{
				bool flag2 = styleTransformOrigin.value == inlineValue.value && styleTransformOrigin.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				this.m_HasInlineTransformOrigin = false;
				result = this.RemoveInlineStyle(StylePropertyId.TransformOrigin);
			}
			else
			{
				this.m_InlineTransformOrigin = inlineValue;
				this.m_HasInlineTransformOrigin = true;
				this.ApplyStyleTransformOrigin(inlineValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00057B08 File Offset: 0x00055D08
		private void ApplyStyleTransformOrigin(StyleTransformOrigin transformOrigin)
		{
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(StylePropertyId.TransformOrigin, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineTransformOrigin(this.ve, this.ve.computedStyle, transformOrigin, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(StylePropertyId.TransformOrigin);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleTransformOrigin(transformOrigin.value);
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00057BD0 File Offset: 0x00055DD0
		private bool SetInlineTranslate(StyleTranslate inlineValue)
		{
			StyleTranslate styleTranslate = default(StyleTranslate);
			bool flag = this.TryGetInlineTranslate(ref styleTranslate);
			if (flag)
			{
				bool flag2 = styleTranslate.value == inlineValue.value && styleTranslate.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				this.m_HasInlineTranslate = false;
				result = this.RemoveInlineStyle(StylePropertyId.Translate);
			}
			else
			{
				this.m_InlineTranslateOperation = inlineValue;
				this.m_HasInlineTranslate = true;
				this.ApplyStyleTranslate(inlineValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00057C7C File Offset: 0x00055E7C
		private void ApplyStyleTranslate(StyleTranslate translate)
		{
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(StylePropertyId.Translate, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineTranslate(this.ve, this.ve.computedStyle, translate, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(StylePropertyId.Translate);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleTranslate(translate.value);
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00057D44 File Offset: 0x00055F44
		private bool SetInlineScale(StyleScale inlineValue)
		{
			StyleScale styleScale = default(StyleScale);
			bool flag = this.TryGetInlineScale(ref styleScale);
			if (flag)
			{
				bool flag2 = styleScale.value == inlineValue.value && styleScale.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				this.m_HasInlineScale = false;
				result = this.RemoveInlineStyle(StylePropertyId.Scale);
			}
			else
			{
				this.m_InlineScale = inlineValue;
				this.m_HasInlineScale = true;
				this.ApplyStyleScale(inlineValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00057DF0 File Offset: 0x00055FF0
		private void ApplyStyleScale(StyleScale scale)
		{
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(StylePropertyId.Scale, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineScale(this.ve, this.ve.computedStyle, scale, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(StylePropertyId.Scale);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleScale(scale.value);
			}
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00057EB8 File Offset: 0x000560B8
		private bool SetInlineRotate(StyleRotate inlineValue)
		{
			StyleRotate styleRotate = default(StyleRotate);
			bool flag = this.TryGetInlineRotate(ref styleRotate);
			if (flag)
			{
				bool flag2 = styleRotate.value == inlineValue.value && styleRotate.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			bool result;
			if (flag4)
			{
				this.m_HasInlineRotate = false;
				result = this.RemoveInlineStyle(StylePropertyId.Rotate);
			}
			else
			{
				this.m_InlineRotateOperation = inlineValue;
				this.m_HasInlineRotate = true;
				this.ApplyStyleRotate(inlineValue);
				result = true;
			}
			return result;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00057F64 File Offset: 0x00056164
		private void ApplyStyleRotate(StyleRotate rotate)
		{
			VisualElement parent = this.ve.hierarchy.parent;
			if (parent != null)
			{
				ref ComputedStyle computedStyle = ref parent.computedStyle;
				ref ComputedStyle computedStyle2 = ref parent.computedStyle;
			}
			else
			{
				InitialStyle.Get();
			}
			ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
			bool flag = false;
			ComputedTransitionProperty computedTransitionProperty;
			bool flag2 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(StylePropertyId.Rotate, out computedTransitionProperty);
			if (flag2)
			{
				flag = ComputedStyle.StartAnimationInlineRotate(this.ve, this.ve.computedStyle, rotate, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
			}
			else
			{
				this.ve.styleAnimation.CancelAnimation(StylePropertyId.Rotate);
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.ve.computedStyle.ApplyStyleRotate(rotate.value);
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00058060 File Offset: 0x00056260
		private void ApplyStyleValue(StyleValue value)
		{
			VisualElement parent = this.ve.hierarchy.parent;
			ComputedStyle ptr;
			if (parent != null)
			{
				ref ComputedStyle computedStyle = ref parent.computedStyle;
				ptr = parent.computedStyle;
			}
			else
			{
				ptr = InitialStyle.Get();
			}
			ref ComputedStyle parentStyle = ref ptr;
			bool flag = false;
			bool flag2 = StylePropertyUtil.IsAnimatable(value.id);
			if (flag2)
			{
				ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
				ComputedTransitionProperty computedTransitionProperty;
				bool flag3 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(value.id, out computedTransitionProperty);
				if (flag3)
				{
					flag = ComputedStyle.StartAnimationInline(this.ve, value.id, this.ve.computedStyle, value, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
				}
				else
				{
					this.ve.styleAnimation.CancelAnimation(value.id);
				}
			}
			bool flag4 = !flag;
			if (flag4)
			{
				this.ve.computedStyle.ApplyStyleValue(value, ref parentStyle);
			}
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00058174 File Offset: 0x00056374
		private void ApplyStyleValue(StyleValueManaged value)
		{
			VisualElement parent = this.ve.hierarchy.parent;
			ComputedStyle ptr;
			if (parent != null)
			{
				ref ComputedStyle computedStyle = ref parent.computedStyle;
				ptr = parent.computedStyle;
			}
			else
			{
				ptr = InitialStyle.Get();
			}
			ref ComputedStyle parentStyle = ref ptr;
			this.ve.computedStyle.ApplyStyleValueManaged(value, ref parentStyle);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x000581C4 File Offset: 0x000563C4
		private bool RemoveInlineStyle(StylePropertyId id)
		{
			long matchingRulesHash = this.ve.computedStyle.matchingRulesHash;
			bool flag = matchingRulesHash == 0L;
			bool result;
			if (flag)
			{
				this.ApplyFromComputedStyle(id, InitialStyle.Get());
				result = true;
			}
			else
			{
				ComputedStyle computedStyle;
				bool flag2 = StyleCache.TryGetValue(matchingRulesHash, out computedStyle);
				if (flag2)
				{
					this.ApplyFromComputedStyle(id, ref computedStyle);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00058220 File Offset: 0x00056420
		private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle)
		{
			bool flag = false;
			bool flag2 = StylePropertyUtil.IsAnimatable(id);
			if (flag2)
			{
				ComputedTransitionUtils.UpdateComputedTransitions(this.ve.computedStyle);
				ComputedTransitionProperty computedTransitionProperty;
				bool flag3 = this.ve.computedStyle.hasTransition && this.ve.styleInitialized && this.ve.computedStyle.GetTransitionProperty(id, out computedTransitionProperty);
				if (flag3)
				{
					flag = ComputedStyle.StartAnimation(this.ve, id, this.ve.computedStyle, ref newStyle, computedTransitionProperty.durationMs, computedTransitionProperty.delayMs, computedTransitionProperty.easingCurve);
				}
				else
				{
					this.ve.styleAnimation.CancelAnimation(id);
				}
			}
			bool flag4 = !flag;
			if (flag4)
			{
				this.ve.computedStyle.ApplyFromComputedStyle(id, ref newStyle);
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000582EC File Offset: 0x000564EC
		public bool TryGetInlineCursor(ref StyleCursor value)
		{
			bool hasInlineCursor = this.m_HasInlineCursor;
			bool result;
			if (hasInlineCursor)
			{
				value = this.m_InlineCursor;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0005831C File Offset: 0x0005651C
		public bool TryGetInlineTextShadow(ref StyleTextShadow value)
		{
			bool hasInlineTextShadow = this.m_HasInlineTextShadow;
			bool result;
			if (hasInlineTextShadow)
			{
				value = this.m_InlineTextShadow;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0005834C File Offset: 0x0005654C
		public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value)
		{
			bool hasInlineTransformOrigin = this.m_HasInlineTransformOrigin;
			bool result;
			if (hasInlineTransformOrigin)
			{
				value = this.m_InlineTransformOrigin;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0005837C File Offset: 0x0005657C
		public bool TryGetInlineTranslate(ref StyleTranslate value)
		{
			bool hasInlineTranslate = this.m_HasInlineTranslate;
			bool result;
			if (hasInlineTranslate)
			{
				value = this.m_InlineTranslateOperation;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x000583AC File Offset: 0x000565AC
		public bool TryGetInlineRotate(ref StyleRotate value)
		{
			bool hasInlineRotate = this.m_HasInlineRotate;
			bool result;
			if (hasInlineRotate)
			{
				value = this.m_InlineRotateOperation;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x000583DC File Offset: 0x000565DC
		public bool TryGetInlineScale(ref StyleScale value)
		{
			bool hasInlineScale = this.m_HasInlineScale;
			bool result;
			if (hasInlineScale)
			{
				value = this.m_InlineScale;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0005840C File Offset: 0x0005660C
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x00058440 File Offset: 0x00056640
		StyleEnum<Align> IStyle.alignContent
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.AlignContent);
				return new StyleEnum<Align>((Align)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Align>(StylePropertyId.AlignContent, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.AlignContent = (YogaAlign)this.ve.computedStyle.alignContent;
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00058490 File Offset: 0x00056690
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x000584C4 File Offset: 0x000566C4
		StyleEnum<Align> IStyle.alignItems
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.AlignItems);
				return new StyleEnum<Align>((Align)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Align>(StylePropertyId.AlignItems, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.AlignItems = (YogaAlign)this.ve.computedStyle.alignItems;
				}
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x00058514 File Offset: 0x00056714
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00058548 File Offset: 0x00056748
		StyleEnum<Align> IStyle.alignSelf
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.AlignSelf);
				return new StyleEnum<Align>((Align)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Align>(StylePropertyId.AlignSelf, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.AlignSelf = (YogaAlign)this.ve.computedStyle.alignSelf;
				}
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00058598 File Offset: 0x00056798
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x000585B8 File Offset: 0x000567B8
		StyleColor IStyle.backgroundColor
		{
			get
			{
				return base.GetStyleColor(StylePropertyId.BackgroundColor);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BackgroundColor, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Color);
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000585EC File Offset: 0x000567EC
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0005860C File Offset: 0x0005680C
		StyleBackground IStyle.backgroundImage
		{
			get
			{
				return base.GetStyleBackground(StylePropertyId.BackgroundImage);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BackgroundImage, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00058640 File Offset: 0x00056840
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x00058660 File Offset: 0x00056860
		StyleColor IStyle.borderBottomColor
		{
			get
			{
				return base.GetStyleColor(StylePropertyId.BorderBottomColor);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderBottomColor, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Color);
				}
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x00058694 File Offset: 0x00056894
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x000586B4 File Offset: 0x000568B4
		StyleLength IStyle.borderBottomLeftRadius
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.BorderBottomLeftRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderBottomLeftRadius, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.BorderRadius | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x000586E8 File Offset: 0x000568E8
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00058708 File Offset: 0x00056908
		StyleLength IStyle.borderBottomRightRadius
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.BorderBottomRightRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderBottomRightRadius, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.BorderRadius | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0005873C File Offset: 0x0005693C
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x0005875C File Offset: 0x0005695C
		StyleFloat IStyle.borderBottomWidth
		{
			get
			{
				return base.GetStyleFloat(StylePropertyId.BorderBottomWidth);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderBottomWidth, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.BorderWidth | VersionChangeType.Repaint);
					this.ve.yogaNode.BorderBottomWidth = this.ve.computedStyle.borderBottomWidth;
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x000587B0 File Offset: 0x000569B0
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x000587D0 File Offset: 0x000569D0
		StyleColor IStyle.borderLeftColor
		{
			get
			{
				return base.GetStyleColor(StylePropertyId.BorderLeftColor);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderLeftColor, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Color);
				}
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00058804 File Offset: 0x00056A04
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x00058824 File Offset: 0x00056A24
		StyleFloat IStyle.borderLeftWidth
		{
			get
			{
				return base.GetStyleFloat(StylePropertyId.BorderLeftWidth);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderLeftWidth, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.BorderWidth | VersionChangeType.Repaint);
					this.ve.yogaNode.BorderLeftWidth = this.ve.computedStyle.borderLeftWidth;
				}
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00058878 File Offset: 0x00056A78
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x00058898 File Offset: 0x00056A98
		StyleColor IStyle.borderRightColor
		{
			get
			{
				return base.GetStyleColor(StylePropertyId.BorderRightColor);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderRightColor, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Color);
				}
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x000588CC File Offset: 0x00056ACC
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x000588EC File Offset: 0x00056AEC
		StyleFloat IStyle.borderRightWidth
		{
			get
			{
				return base.GetStyleFloat(StylePropertyId.BorderRightWidth);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderRightWidth, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.BorderWidth | VersionChangeType.Repaint);
					this.ve.yogaNode.BorderRightWidth = this.ve.computedStyle.borderRightWidth;
				}
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x00058940 File Offset: 0x00056B40
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x00058960 File Offset: 0x00056B60
		StyleColor IStyle.borderTopColor
		{
			get
			{
				return base.GetStyleColor(StylePropertyId.BorderTopColor);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderTopColor, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Color);
				}
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00058994 File Offset: 0x00056B94
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x000589B4 File Offset: 0x00056BB4
		StyleLength IStyle.borderTopLeftRadius
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.BorderTopLeftRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderTopLeftRadius, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.BorderRadius | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x000589E8 File Offset: 0x00056BE8
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x00058A08 File Offset: 0x00056C08
		StyleLength IStyle.borderTopRightRadius
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.BorderTopRightRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderTopRightRadius, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.BorderRadius | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00058A3C File Offset: 0x00056C3C
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x00058A5C File Offset: 0x00056C5C
		StyleFloat IStyle.borderTopWidth
		{
			get
			{
				return base.GetStyleFloat(StylePropertyId.BorderTopWidth);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.BorderTopWidth, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.BorderWidth | VersionChangeType.Repaint);
					this.ve.yogaNode.BorderTopWidth = this.ve.computedStyle.borderTopWidth;
				}
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x00058AB0 File Offset: 0x00056CB0
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x00058AD0 File Offset: 0x00056CD0
		StyleLength IStyle.bottom
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.Bottom);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.Bottom, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.Bottom = this.ve.computedStyle.bottom.ToYogaValue();
				}
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00058B24 File Offset: 0x00056D24
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x00058B44 File Offset: 0x00056D44
		StyleColor IStyle.color
		{
			get
			{
				return base.GetStyleColor(StylePropertyId.Color);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.Color, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00058B78 File Offset: 0x00056D78
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x00058BAC File Offset: 0x00056DAC
		StyleEnum<DisplayStyle> IStyle.display
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.Display);
				return new StyleEnum<DisplayStyle>((DisplayStyle)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<DisplayStyle>(StylePropertyId.Display, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Repaint);
					this.ve.yogaNode.Display = (YogaDisplay)this.ve.computedStyle.display;
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00058C00 File Offset: 0x00056E00
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x00058C20 File Offset: 0x00056E20
		StyleLength IStyle.flexBasis
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.FlexBasis);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.FlexBasis, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.FlexBasis = this.ve.computedStyle.flexBasis.ToYogaValue();
				}
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00058C74 File Offset: 0x00056E74
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x00058CA8 File Offset: 0x00056EA8
		StyleEnum<FlexDirection> IStyle.flexDirection
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.FlexDirection);
				return new StyleEnum<FlexDirection>((FlexDirection)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<FlexDirection>(StylePropertyId.FlexDirection, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.FlexDirection = (YogaFlexDirection)this.ve.computedStyle.flexDirection;
				}
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00058CF8 File Offset: 0x00056EF8
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x00058D18 File Offset: 0x00056F18
		StyleFloat IStyle.flexGrow
		{
			get
			{
				return base.GetStyleFloat(StylePropertyId.FlexGrow);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.FlexGrow, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.FlexGrow = this.ve.computedStyle.flexGrow;
				}
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x00058D68 File Offset: 0x00056F68
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x00058D88 File Offset: 0x00056F88
		StyleFloat IStyle.flexShrink
		{
			get
			{
				return base.GetStyleFloat(StylePropertyId.FlexShrink);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.FlexShrink, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.FlexShrink = this.ve.computedStyle.flexShrink;
				}
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x00058DD8 File Offset: 0x00056FD8
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x00058E0C File Offset: 0x0005700C
		StyleEnum<Wrap> IStyle.flexWrap
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.FlexWrap);
				return new StyleEnum<Wrap>((Wrap)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Wrap>(StylePropertyId.FlexWrap, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.Wrap = (YogaWrap)this.ve.computedStyle.flexWrap;
				}
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00058E5C File Offset: 0x0005705C
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x00058E7C File Offset: 0x0005707C
		StyleLength IStyle.fontSize
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.FontSize);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.FontSize, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00058EAC File Offset: 0x000570AC
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x00058ECC File Offset: 0x000570CC
		StyleLength IStyle.height
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.Height);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.Height, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.Height = this.ve.computedStyle.height.ToYogaValue();
				}
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x00058F20 File Offset: 0x00057120
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x00058F54 File Offset: 0x00057154
		StyleEnum<Justify> IStyle.justifyContent
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.JustifyContent);
				return new StyleEnum<Justify>((Justify)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Justify>(StylePropertyId.JustifyContent, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.JustifyContent = (YogaJustify)this.ve.computedStyle.justifyContent;
				}
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x00058FA4 File Offset: 0x000571A4
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x00058FC4 File Offset: 0x000571C4
		StyleLength IStyle.left
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.Left);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.Left, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.Left = this.ve.computedStyle.left.ToYogaValue();
				}
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00059018 File Offset: 0x00057218
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x00059038 File Offset: 0x00057238
		StyleLength IStyle.letterSpacing
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.LetterSpacing);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.LetterSpacing, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0005906C File Offset: 0x0005726C
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0005908C File Offset: 0x0005728C
		StyleLength IStyle.marginBottom
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.MarginBottom);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.MarginBottom, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MarginBottom = this.ve.computedStyle.marginBottom.ToYogaValue();
				}
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x000590E0 File Offset: 0x000572E0
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x00059100 File Offset: 0x00057300
		StyleLength IStyle.marginLeft
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.MarginLeft);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.MarginLeft, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MarginLeft = this.ve.computedStyle.marginLeft.ToYogaValue();
				}
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00059154 File Offset: 0x00057354
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00059174 File Offset: 0x00057374
		StyleLength IStyle.marginRight
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.MarginRight);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.MarginRight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MarginRight = this.ve.computedStyle.marginRight.ToYogaValue();
				}
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x000591C8 File Offset: 0x000573C8
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x000591E8 File Offset: 0x000573E8
		StyleLength IStyle.marginTop
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.MarginTop);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.MarginTop, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MarginTop = this.ve.computedStyle.marginTop.ToYogaValue();
				}
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0005923C File Offset: 0x0005743C
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0005925C File Offset: 0x0005745C
		StyleLength IStyle.maxHeight
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.MaxHeight);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.MaxHeight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MaxHeight = this.ve.computedStyle.maxHeight.ToYogaValue();
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x000592B0 File Offset: 0x000574B0
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x000592D0 File Offset: 0x000574D0
		StyleLength IStyle.maxWidth
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.MaxWidth);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.MaxWidth, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MaxWidth = this.ve.computedStyle.maxWidth.ToYogaValue();
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00059324 File Offset: 0x00057524
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x00059344 File Offset: 0x00057544
		StyleLength IStyle.minHeight
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.MinHeight);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.MinHeight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MinHeight = this.ve.computedStyle.minHeight.ToYogaValue();
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x00059398 File Offset: 0x00057598
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x000593B8 File Offset: 0x000575B8
		StyleLength IStyle.minWidth
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.MinWidth);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.MinWidth, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.MinWidth = this.ve.computedStyle.minWidth.ToYogaValue();
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0005940C File Offset: 0x0005760C
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0005942C File Offset: 0x0005762C
		StyleFloat IStyle.opacity
		{
			get
			{
				return base.GetStyleFloat(StylePropertyId.Opacity);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.Opacity, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Opacity);
				}
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00059460 File Offset: 0x00057660
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x00059494 File Offset: 0x00057694
		StyleEnum<Overflow> IStyle.overflow
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.Overflow);
				return new StyleEnum<Overflow>((Overflow)styleInt.value, styleInt.keyword);
			}
			set
			{
				StyleEnum<OverflowInternal> inlineValue = new StyleEnum<OverflowInternal>((OverflowInternal)value.value, value.keyword);
				bool flag = this.SetStyleValue<OverflowInternal>(StylePropertyId.Overflow, inlineValue);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Overflow);
					this.ve.yogaNode.Overflow = (YogaOverflow)this.ve.computedStyle.overflow;
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x000594F8 File Offset: 0x000576F8
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00059518 File Offset: 0x00057718
		StyleLength IStyle.paddingBottom
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.PaddingBottom);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.PaddingBottom, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.PaddingBottom = this.ve.computedStyle.paddingBottom.ToYogaValue();
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0005956C File Offset: 0x0005776C
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x0005958C File Offset: 0x0005778C
		StyleLength IStyle.paddingLeft
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.PaddingLeft);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.PaddingLeft, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.PaddingLeft = this.ve.computedStyle.paddingLeft.ToYogaValue();
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x000595E0 File Offset: 0x000577E0
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x00059600 File Offset: 0x00057800
		StyleLength IStyle.paddingRight
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.PaddingRight);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.PaddingRight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.PaddingRight = this.ve.computedStyle.paddingRight.ToYogaValue();
				}
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00059654 File Offset: 0x00057854
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x00059674 File Offset: 0x00057874
		StyleLength IStyle.paddingTop
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.PaddingTop);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.PaddingTop, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.PaddingTop = this.ve.computedStyle.paddingTop.ToYogaValue();
				}
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x000596C8 File Offset: 0x000578C8
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x000596FC File Offset: 0x000578FC
		StyleEnum<Position> IStyle.position
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.Position);
				return new StyleEnum<Position>((Position)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Position>(StylePropertyId.Position, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.PositionType = (YogaPositionType)this.ve.computedStyle.position;
				}
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0005974C File Offset: 0x0005794C
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x0005976C File Offset: 0x0005796C
		StyleLength IStyle.right
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.Right);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.Right, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.Right = this.ve.computedStyle.right.ToYogaValue();
				}
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x000597C0 File Offset: 0x000579C0
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x000597F4 File Offset: 0x000579F4
		StyleEnum<TextOverflow> IStyle.textOverflow
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.TextOverflow);
				return new StyleEnum<TextOverflow>((TextOverflow)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<TextOverflow>(StylePropertyId.TextOverflow, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00059828 File Offset: 0x00057A28
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x00059848 File Offset: 0x00057A48
		StyleLength IStyle.top
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.Top);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.Top, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.Top = this.ve.computedStyle.top.ToYogaValue();
				}
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0005989C File Offset: 0x00057A9C
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x000598BC File Offset: 0x00057ABC
		StyleList<TimeValue> IStyle.transitionDelay
		{
			get
			{
				return this.GetStyleList<TimeValue>(StylePropertyId.TransitionDelay);
			}
			set
			{
				bool flag = this.SetStyleValue<TimeValue>(StylePropertyId.TransitionDelay, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.TransitionProperty);
				}
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x000598F0 File Offset: 0x00057AF0
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x00059910 File Offset: 0x00057B10
		StyleList<TimeValue> IStyle.transitionDuration
		{
			get
			{
				return this.GetStyleList<TimeValue>(StylePropertyId.TransitionDuration);
			}
			set
			{
				bool flag = this.SetStyleValue<TimeValue>(StylePropertyId.TransitionDuration, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.TransitionProperty);
				}
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x00059944 File Offset: 0x00057B44
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x00059964 File Offset: 0x00057B64
		StyleList<StylePropertyName> IStyle.transitionProperty
		{
			get
			{
				return this.GetStyleList<StylePropertyName>(StylePropertyId.TransitionProperty);
			}
			set
			{
				bool flag = this.SetStyleValue<StylePropertyName>(StylePropertyId.TransitionProperty, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.TransitionProperty);
				}
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00059998 File Offset: 0x00057B98
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x000599B8 File Offset: 0x00057BB8
		StyleList<EasingFunction> IStyle.transitionTimingFunction
		{
			get
			{
				return this.GetStyleList<EasingFunction>(StylePropertyId.TransitionTimingFunction);
			}
			set
			{
				bool flag = this.SetStyleValue<EasingFunction>(StylePropertyId.TransitionTimingFunction, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x000599E8 File Offset: 0x00057BE8
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00059A08 File Offset: 0x00057C08
		StyleColor IStyle.unityBackgroundImageTintColor
		{
			get
			{
				return base.GetStyleColor(StylePropertyId.UnityBackgroundImageTintColor);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnityBackgroundImageTintColor, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Color);
				}
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00059A3C File Offset: 0x00057C3C
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00059A70 File Offset: 0x00057C70
		StyleEnum<ScaleMode> IStyle.unityBackgroundScaleMode
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.UnityBackgroundScaleMode);
				return new StyleEnum<ScaleMode>((ScaleMode)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<ScaleMode>(StylePropertyId.UnityBackgroundScaleMode, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00059AA4 File Offset: 0x00057CA4
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00059AC4 File Offset: 0x00057CC4
		StyleFont IStyle.unityFont
		{
			get
			{
				return base.GetStyleFont(StylePropertyId.UnityFont);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnityFont, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x00059AF8 File Offset: 0x00057CF8
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x00059B18 File Offset: 0x00057D18
		StyleFontDefinition IStyle.unityFontDefinition
		{
			get
			{
				return base.GetStyleFontDefinition(StylePropertyId.UnityFontDefinition);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnityFontDefinition, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00059B4C File Offset: 0x00057D4C
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x00059B80 File Offset: 0x00057D80
		StyleEnum<FontStyle> IStyle.unityFontStyleAndWeight
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.UnityFontStyleAndWeight);
				return new StyleEnum<FontStyle>((FontStyle)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<FontStyle>(StylePropertyId.UnityFontStyleAndWeight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00059BB4 File Offset: 0x00057DB4
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00059BE8 File Offset: 0x00057DE8
		StyleEnum<OverflowClipBox> IStyle.unityOverflowClipBox
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.UnityOverflowClipBox);
				return new StyleEnum<OverflowClipBox>((OverflowClipBox)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<OverflowClipBox>(StylePropertyId.UnityOverflowClipBox, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x00059C1C File Offset: 0x00057E1C
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x00059C3C File Offset: 0x00057E3C
		StyleLength IStyle.unityParagraphSpacing
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.UnityParagraphSpacing);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnityParagraphSpacing, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x00059C70 File Offset: 0x00057E70
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x00059C90 File Offset: 0x00057E90
		StyleInt IStyle.unitySliceBottom
		{
			get
			{
				return base.GetStyleInt(StylePropertyId.UnitySliceBottom);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnitySliceBottom, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x00059CC4 File Offset: 0x00057EC4
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x00059CE4 File Offset: 0x00057EE4
		StyleInt IStyle.unitySliceLeft
		{
			get
			{
				return base.GetStyleInt(StylePropertyId.UnitySliceLeft);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnitySliceLeft, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x00059D18 File Offset: 0x00057F18
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x00059D38 File Offset: 0x00057F38
		StyleInt IStyle.unitySliceRight
		{
			get
			{
				return base.GetStyleInt(StylePropertyId.UnitySliceRight);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnitySliceRight, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x00059D6C File Offset: 0x00057F6C
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00059D8C File Offset: 0x00057F8C
		StyleInt IStyle.unitySliceTop
		{
			get
			{
				return base.GetStyleInt(StylePropertyId.UnitySliceTop);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnitySliceTop, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00059DC0 File Offset: 0x00057FC0
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00059DF4 File Offset: 0x00057FF4
		StyleEnum<TextAnchor> IStyle.unityTextAlign
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.UnityTextAlign);
				return new StyleEnum<TextAnchor>((TextAnchor)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<TextAnchor>(StylePropertyId.UnityTextAlign, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x00059E28 File Offset: 0x00058028
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x00059E48 File Offset: 0x00058048
		StyleColor IStyle.unityTextOutlineColor
		{
			get
			{
				return base.GetStyleColor(StylePropertyId.UnityTextOutlineColor);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnityTextOutlineColor, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x00059E7C File Offset: 0x0005807C
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x00059E9C File Offset: 0x0005809C
		StyleFloat IStyle.unityTextOutlineWidth
		{
			get
			{
				return base.GetStyleFloat(StylePropertyId.UnityTextOutlineWidth);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.UnityTextOutlineWidth, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00059ED0 File Offset: 0x000580D0
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x00059F04 File Offset: 0x00058104
		StyleEnum<TextOverflowPosition> IStyle.unityTextOverflowPosition
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.UnityTextOverflowPosition);
				return new StyleEnum<TextOverflowPosition>((TextOverflowPosition)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<TextOverflowPosition>(StylePropertyId.UnityTextOverflowPosition, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x00059F38 File Offset: 0x00058138
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x00059F6C File Offset: 0x0005816C
		StyleEnum<Visibility> IStyle.visibility
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.Visibility);
				return new StyleEnum<Visibility>((Visibility)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<Visibility>(StylePropertyId.Visibility, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint | VersionChangeType.Picking);
				}
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x00059FA0 File Offset: 0x000581A0
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x00059FD4 File Offset: 0x000581D4
		StyleEnum<WhiteSpace> IStyle.whiteSpace
		{
			get
			{
				StyleInt styleInt = base.GetStyleInt(StylePropertyId.WhiteSpace);
				return new StyleEnum<WhiteSpace>((WhiteSpace)styleInt.value, styleInt.keyword);
			}
			set
			{
				bool flag = this.SetStyleValue<WhiteSpace>(StylePropertyId.WhiteSpace, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0005A004 File Offset: 0x00058204
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x0005A024 File Offset: 0x00058224
		StyleLength IStyle.width
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.Width);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.Width, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Styles);
					this.ve.yogaNode.Width = this.ve.computedStyle.width.ToYogaValue();
				}
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0005A078 File Offset: 0x00058278
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x0005A098 File Offset: 0x00058298
		StyleLength IStyle.wordSpacing
		{
			get
			{
				return base.GetStyleLength(StylePropertyId.WordSpacing);
			}
			set
			{
				bool flag = this.SetStyleValue(StylePropertyId.WordSpacing, value);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x0400091A RID: 2330
		private static StylePropertyReader s_StylePropertyReader = new StylePropertyReader();

		// Token: 0x0400091B RID: 2331
		private List<StyleValueManaged> m_ValuesManaged;

		// Token: 0x0400091D RID: 2333
		private bool m_HasInlineCursor;

		// Token: 0x0400091E RID: 2334
		private StyleCursor m_InlineCursor;

		// Token: 0x0400091F RID: 2335
		private bool m_HasInlineTextShadow;

		// Token: 0x04000920 RID: 2336
		private StyleTextShadow m_InlineTextShadow;

		// Token: 0x04000921 RID: 2337
		private bool m_HasInlineTransformOrigin;

		// Token: 0x04000922 RID: 2338
		private StyleTransformOrigin m_InlineTransformOrigin;

		// Token: 0x04000923 RID: 2339
		private bool m_HasInlineTranslate;

		// Token: 0x04000924 RID: 2340
		private StyleTranslate m_InlineTranslateOperation;

		// Token: 0x04000925 RID: 2341
		private bool m_HasInlineRotate;

		// Token: 0x04000926 RID: 2342
		private StyleRotate m_InlineRotateOperation;

		// Token: 0x04000927 RID: 2343
		private bool m_HasInlineScale;

		// Token: 0x04000928 RID: 2344
		private StyleScale m_InlineScale;

		// Token: 0x04000929 RID: 2345
		private InlineStyleAccess.InlineRule m_InlineRule;

		// Token: 0x0200027A RID: 634
		internal struct InlineRule
		{
			// Token: 0x170004D8 RID: 1240
			// (get) Token: 0x06001491 RID: 5265 RVA: 0x0005A0D5 File Offset: 0x000582D5
			public StyleProperty[] properties
			{
				get
				{
					return this.rule.properties;
				}
			}

			// Token: 0x0400092A RID: 2346
			public StyleSheet sheet;

			// Token: 0x0400092B RID: 2347
			public StyleRule rule;

			// Token: 0x0400092C RID: 2348
			public StylePropertyId[] propertyIds;
		}
	}
}
