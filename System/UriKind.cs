using System;

namespace System
{
	/// <summary>Определяет виды <see cref="T:System.Uri" /> для <see cref="M:System.Uri.IsWellFormedUriString(System.String,System.UriKind)" /> и нескольких методов <see cref="Overload:System.Uri.#ctor" /> methods.</summary>
	// Token: 0x02000156 RID: 342
	public enum UriKind
	{
		/// <summary>Вид URI не определен.</summary>
		// Token: 0x0400060E RID: 1550
		RelativeOrAbsolute,
		/// <summary>Данный URI является абсолютным.</summary>
		// Token: 0x0400060F RID: 1551
		Absolute,
		/// <summary>Данный URI является относительным.</summary>
		// Token: 0x04000610 RID: 1552
		Relative
	}
}
