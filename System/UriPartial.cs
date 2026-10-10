using System;

namespace System
{
	/// <summary>Определяет части URI для метода <see cref="M:System.Uri.GetLeftPart(System.UriPartial)" />.</summary>
	// Token: 0x02000155 RID: 341
	public enum UriPartial
	{
		/// <summary>Сегмент схемы URI.</summary>
		// Token: 0x04000609 RID: 1545
		Scheme,
		/// <summary>Сегменты схемы и полномочий URI.</summary>
		// Token: 0x0400060A RID: 1546
		Authority,
		/// <summary>Сегменты схемы, полномочий и пути URI.</summary>
		// Token: 0x0400060B RID: 1547
		Path,
		/// <summary>Сегменты схемы, полномочий, пути и запроса URI.</summary>
		// Token: 0x0400060C RID: 1548
		Query
	}
}
