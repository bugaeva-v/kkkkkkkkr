using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002F2 RID: 754
	public class UxmlValueBounds : UxmlTypeRestriction
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00065D94 File Offset: 0x00063F94
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x00065D9C File Offset: 0x00063F9C
		public string min { get; set; }

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00065DA5 File Offset: 0x00063FA5
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00065DAD File Offset: 0x00063FAD
		public string max { get; set; }

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00065DB6 File Offset: 0x00063FB6
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x00065DBE File Offset: 0x00063FBE
		public bool excludeMin { get; set; }

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x00065DC7 File Offset: 0x00063FC7
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00065DCF File Offset: 0x00063FCF
		public bool excludeMax { get; set; }

		// Token: 0x060018FD RID: 6397 RVA: 0x00065DD8 File Offset: 0x00063FD8
		public override bool Equals(UxmlTypeRestriction other)
		{
			UxmlValueBounds uxmlValueBounds = other as UxmlValueBounds;
			bool flag = uxmlValueBounds == null;
			return !flag && (this.min == uxmlValueBounds.min && this.max == uxmlValueBounds.max && this.excludeMin == uxmlValueBounds.excludeMin) && this.excludeMax == uxmlValueBounds.excludeMax;
		}
	}
}
