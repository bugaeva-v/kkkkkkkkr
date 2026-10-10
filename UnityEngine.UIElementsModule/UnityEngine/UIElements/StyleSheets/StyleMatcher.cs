using System;
using System.Text.RegularExpressions;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000376 RID: 886
	internal class StyleMatcher : BaseStyleMatcher
	{
		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0008701E File Offset: 0x0008521E
		private string current
		{
			get
			{
				return base.hasCurrent ? this.m_PropertyParts[base.currentIndex] : null;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00087038 File Offset: 0x00085238
		public override int valueCount
		{
			get
			{
				return this.m_PropertyParts.Length;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x00087042 File Offset: 0x00085242
		public override bool isCurrentVariable
		{
			get
			{
				return base.hasCurrent && this.current.StartsWith("var(");
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0008705F File Offset: 0x0008525F
		public override bool isCurrentComma
		{
			get
			{
				return base.hasCurrent && this.current == ",";
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0008707C File Offset: 0x0008527C
		private void Initialize(string propertyValue)
		{
			base.Initialize();
			this.m_PropertyParts = this.m_Parser.Parse(propertyValue);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00087098 File Offset: 0x00085298
		public MatchResult Match(Expression exp, string propertyValue)
		{
			MatchResult matchResult = new MatchResult
			{
				errorCode = MatchResultErrorCode.None
			};
			bool flag = string.IsNullOrEmpty(propertyValue);
			MatchResult result;
			if (flag)
			{
				matchResult.errorCode = MatchResultErrorCode.EmptyValue;
				result = matchResult;
			}
			else
			{
				this.Initialize(propertyValue);
				string current = this.current;
				bool flag2 = current == "initial" || current.StartsWith("env(");
				bool flag3;
				if (flag2)
				{
					base.MoveNext();
					flag3 = true;
				}
				else
				{
					flag3 = base.Match(exp);
				}
				bool flag4 = !flag3;
				if (flag4)
				{
					matchResult.errorCode = MatchResultErrorCode.Syntax;
					matchResult.errorValue = this.current;
				}
				else
				{
					bool hasCurrent = base.hasCurrent;
					if (hasCurrent)
					{
						matchResult.errorCode = MatchResultErrorCode.ExpectedEndOfValue;
						matchResult.errorValue = this.current;
					}
				}
				result = matchResult;
			}
			return result;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0008716C File Offset: 0x0008536C
		protected override bool MatchKeyword(string keyword)
		{
			return this.current != null && keyword == this.current.ToLower();
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0008719C File Offset: 0x0008539C
		protected override bool MatchNumber()
		{
			string current = this.current;
			Match match = StyleMatcher.s_NumberRegex.Match(current);
			return match.Success;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x000871C8 File Offset: 0x000853C8
		protected override bool MatchInteger()
		{
			string current = this.current;
			Match match = StyleMatcher.s_IntegerRegex.Match(current);
			return match.Success;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000871F4 File Offset: 0x000853F4
		protected override bool MatchLength()
		{
			string current = this.current;
			Match match = StyleMatcher.s_LengthRegex.Match(current);
			bool success = match.Success;
			bool result;
			if (success)
			{
				result = true;
			}
			else
			{
				match = StyleMatcher.s_ZeroRegex.Match(current);
				result = match.Success;
			}
			return result;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0008723C File Offset: 0x0008543C
		protected override bool MatchPercentage()
		{
			string current = this.current;
			Match match = StyleMatcher.s_PercentRegex.Match(current);
			bool success = match.Success;
			bool result;
			if (success)
			{
				result = true;
			}
			else
			{
				match = StyleMatcher.s_ZeroRegex.Match(current);
				result = match.Success;
			}
			return result;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00087284 File Offset: 0x00085484
		protected override bool MatchColor()
		{
			string current = this.current;
			Match match = StyleMatcher.s_HexColorRegex.Match(current);
			bool success = match.Success;
			bool result;
			if (success)
			{
				result = true;
			}
			else
			{
				match = StyleMatcher.s_RgbRegex.Match(current);
				bool success2 = match.Success;
				if (success2)
				{
					result = true;
				}
				else
				{
					match = StyleMatcher.s_RgbaRegex.Match(current);
					bool success3 = match.Success;
					if (success3)
					{
						result = true;
					}
					else
					{
						Color clear = Color.clear;
						bool flag = StyleSheetColor.TryGetColor(current, out clear);
						result = flag;
					}
				}
			}
			return result;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00087310 File Offset: 0x00085510
		protected override bool MatchResource()
		{
			string current = this.current;
			Match match = StyleMatcher.s_ResourceRegex.Match(current);
			bool flag = !match.Success;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string input = match.Groups[1].Value.Trim();
				match = StyleMatcher.s_VarFunctionRegex.Match(input);
				result = !match.Success;
			}
			return result;
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00087378 File Offset: 0x00085578
		protected override bool MatchUrl()
		{
			string current = this.current;
			Match match = StyleMatcher.s_UrlRegex.Match(current);
			bool flag = !match.Success;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string input = match.Groups[1].Value.Trim();
				match = StyleMatcher.s_VarFunctionRegex.Match(input);
				result = !match.Success;
			}
			return result;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x000873E0 File Offset: 0x000855E0
		protected override bool MatchTime()
		{
			string current = this.current;
			Match match = StyleMatcher.s_TimeRegex.Match(current);
			return match.Success;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0008740C File Offset: 0x0008560C
		protected override bool MatchAngle()
		{
			string current = this.current;
			Match match = StyleMatcher.s_AngleRegex.Match(current);
			bool success = match.Success;
			bool result;
			if (success)
			{
				result = true;
			}
			else
			{
				match = StyleMatcher.s_ZeroRegex.Match(current);
				result = match.Success;
			}
			return result;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00087454 File Offset: 0x00085654
		protected override bool MatchCustomIdent()
		{
			string current = this.current;
			Match match = BaseStyleMatcher.s_CustomIdentRegex.Match(current);
			return match.Success && match.Length == current.Length;
		}

		// Token: 0x04000E39 RID: 3641
		private StylePropertyValueParser m_Parser = new StylePropertyValueParser();

		// Token: 0x04000E3A RID: 3642
		private string[] m_PropertyParts;

		// Token: 0x04000E3B RID: 3643
		private static readonly Regex s_NumberRegex = new Regex("^[+-]?\\d+(?:\\.\\d+)?$", RegexOptions.Compiled);

		// Token: 0x04000E3C RID: 3644
		private static readonly Regex s_IntegerRegex = new Regex("^[+-]?\\d+$", RegexOptions.Compiled);

		// Token: 0x04000E3D RID: 3645
		private static readonly Regex s_ZeroRegex = new Regex("^0(?:\\.0+)?$", RegexOptions.Compiled);

		// Token: 0x04000E3E RID: 3646
		private static readonly Regex s_LengthRegex = new Regex("^[+-]?\\d+(?:\\.\\d+)?(?:px)$", RegexOptions.Compiled);

		// Token: 0x04000E3F RID: 3647
		private static readonly Regex s_PercentRegex = new Regex("^[+-]?\\d+(?:\\.\\d+)?(?:%)$", RegexOptions.Compiled);

		// Token: 0x04000E40 RID: 3648
		private static readonly Regex s_HexColorRegex = new Regex("^#[a-fA-F0-9]{3}(?:[a-fA-F0-9]{3})?$", RegexOptions.Compiled);

		// Token: 0x04000E41 RID: 3649
		private static readonly Regex s_RgbRegex = new Regex("^rgb\\(\\s*(\\d+)\\s*,\\s*(\\d+)\\s*,\\s*(\\d+)\\s*\\)$", RegexOptions.Compiled);

		// Token: 0x04000E42 RID: 3650
		private static readonly Regex s_RgbaRegex = new Regex("rgba\\(\\s*(\\d+)\\s*,\\s*(\\d+)\\s*,\\s*(\\d+)\\s*,\\s*([\\d.]+)\\s*\\)$", RegexOptions.Compiled);

		// Token: 0x04000E43 RID: 3651
		private static readonly Regex s_VarFunctionRegex = new Regex("^var\\(.+\\)$", RegexOptions.Compiled);

		// Token: 0x04000E44 RID: 3652
		private static readonly Regex s_ResourceRegex = new Regex("^resource\\((.+)\\)$", RegexOptions.Compiled);

		// Token: 0x04000E45 RID: 3653
		private static readonly Regex s_UrlRegex = new Regex("^url\\((.+)\\)$", RegexOptions.Compiled);

		// Token: 0x04000E46 RID: 3654
		private static readonly Regex s_TimeRegex = new Regex("^[+-]?\\.?\\d+(?:\\.\\d+)?(?:s|ms)$", RegexOptions.Compiled);

		// Token: 0x04000E47 RID: 3655
		private static readonly Regex s_AngleRegex = new Regex("^[+-]?\\d+(?:\\.\\d+)?(?:deg|grad|rad|turn)$", RegexOptions.Compiled);
	}
}
