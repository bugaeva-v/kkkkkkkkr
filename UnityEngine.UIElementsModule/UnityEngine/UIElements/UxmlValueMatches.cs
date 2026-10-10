using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002F1 RID: 753
	public class UxmlValueMatches : UxmlTypeRestriction
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00065D42 File Offset: 0x00063F42
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x00065D4A File Offset: 0x00063F4A
		public string regex { get; set; }

		// Token: 0x060018F3 RID: 6387 RVA: 0x00065D54 File Offset: 0x00063F54
		public override bool Equals(UxmlTypeRestriction other)
		{
			UxmlValueMatches uxmlValueMatches = other as UxmlValueMatches;
			bool flag = uxmlValueMatches == null;
			return !flag && this.regex == uxmlValueMatches.regex;
		}
	}
}
