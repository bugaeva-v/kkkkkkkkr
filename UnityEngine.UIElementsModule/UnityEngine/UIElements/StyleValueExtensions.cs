using System;
using System.Collections.Generic;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x02000294 RID: 660
	internal static class StyleValueExtensions
	{
		// Token: 0x060015E0 RID: 5600 RVA: 0x0005F9C4 File Offset: 0x0005DBC4
		internal static string DebugString<T>(this IStyleValue<T> styleValue)
		{
			return (styleValue.keyword != StyleKeyword.Undefined) ? string.Format("{0}", styleValue.keyword) : string.Format("{0}", styleValue.value);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0005FA0C File Offset: 0x0005DC0C
		internal static YogaValue ToYogaValue(this Length length)
		{
			bool flag = length.IsAuto();
			YogaValue result;
			if (flag)
			{
				result = YogaValue.Auto();
			}
			else
			{
				bool flag2 = length.IsNone();
				if (flag2)
				{
					result = float.NaN;
				}
				else
				{
					LengthUnit unit = length.unit;
					LengthUnit lengthUnit = unit;
					if (lengthUnit != LengthUnit.Pixel)
					{
						if (lengthUnit != LengthUnit.Percent)
						{
							Debug.LogAssertion(string.Format("Unexpected unit '{0}'", length.unit));
							result = float.NaN;
						}
						else
						{
							result = YogaValue.Percent(length.value);
						}
					}
					else
					{
						result = YogaValue.Point(length.value);
					}
				}
			}
			return result;
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0005FAA4 File Offset: 0x0005DCA4
		internal static Length ToLength(this StyleKeyword keyword)
		{
			StyleKeyword styleKeyword = keyword;
			StyleKeyword styleKeyword2 = styleKeyword;
			Length result;
			if (styleKeyword2 != StyleKeyword.Auto)
			{
				if (styleKeyword2 != StyleKeyword.None)
				{
					Debug.LogAssertion("Unexpected StyleKeyword '" + keyword.ToString() + "'");
					result = default(Length);
				}
				else
				{
					result = Length.None();
				}
			}
			else
			{
				result = Length.Auto();
			}
			return result;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0005FB04 File Offset: 0x0005DD04
		internal static Rotate ToRotate(this StyleKeyword keyword)
		{
			StyleKeyword styleKeyword = keyword;
			StyleKeyword styleKeyword2 = styleKeyword;
			Rotate result;
			if (styleKeyword2 != StyleKeyword.None)
			{
				Debug.LogAssertion("Unexpected StyleKeyword '" + keyword.ToString() + "'");
				result = default(Rotate);
			}
			else
			{
				result = Rotate.None();
			}
			return result;
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0005FB54 File Offset: 0x0005DD54
		internal static Scale ToScale(this StyleKeyword keyword)
		{
			StyleKeyword styleKeyword = keyword;
			StyleKeyword styleKeyword2 = styleKeyword;
			Scale result;
			if (styleKeyword2 != StyleKeyword.None)
			{
				Debug.LogAssertion("Unexpected StyleKeyword '" + keyword.ToString() + "'");
				result = default(Scale);
			}
			else
			{
				result = Scale.None();
			}
			return result;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0005FBA4 File Offset: 0x0005DDA4
		internal static Translate ToTranslate(this StyleKeyword keyword)
		{
			StyleKeyword styleKeyword = keyword;
			StyleKeyword styleKeyword2 = styleKeyword;
			Translate result;
			if (styleKeyword2 != StyleKeyword.None)
			{
				Debug.LogAssertion("Unexpected StyleKeyword '" + keyword.ToString() + "'");
				result = default(Translate);
			}
			else
			{
				result = Translate.None();
			}
			return result;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0005FBF4 File Offset: 0x0005DDF4
		internal static Length ToLength(this StyleLength styleLength)
		{
			StyleKeyword keyword = styleLength.keyword;
			StyleKeyword styleKeyword = keyword;
			Length result;
			if (styleKeyword - StyleKeyword.Auto > 1)
			{
				result = styleLength.value;
			}
			else
			{
				result = styleLength.keyword.ToLength();
			}
			return result;
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0005FC2E File Offset: 0x0005DE2E
		internal static void CopyFrom<T>(this List<T> list, List<T> other)
		{
			list.Clear();
			list.AddRange(other);
		}
	}
}
