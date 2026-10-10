using System;

namespace System
{
	/// <summary>Указывает, какое время представляет объект <see cref="T:System.DateTime" />: местное, UTC или не определенное как местное или UTC.</summary>
	// Token: 0x0200010D RID: 269
	public enum DateTimeKind
	{
		/// <summary>Представленное время не определено ни как местное, ни как время UTC.</summary>
		// Token: 0x040010C3 RID: 4291
		Unspecified,
		/// <summary>Представленное время является временем UTC.</summary>
		// Token: 0x040010C4 RID: 4292
		Utc,
		/// <summary>Представленное время является местным.</summary>
		// Token: 0x040010C5 RID: 4293
		Local
	}
}
