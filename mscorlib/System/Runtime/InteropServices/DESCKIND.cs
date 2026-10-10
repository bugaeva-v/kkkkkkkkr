using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.DESCKIND" />.</summary>
	// Token: 0x0200073B RID: 1851
	[Obsolete]
	[Serializable]
	public enum DESCKIND
	{
		/// <summary>Показывает отсутствие совпадений.</summary>
		// Token: 0x04002BB4 RID: 11188
		DESCKIND_NONE,
		/// <summary>Показывает возврат объекта <see cref="T:System.Runtime.InteropServices.FUNCDESC" />.</summary>
		// Token: 0x04002BB5 RID: 11189
		DESCKIND_FUNCDESC,
		/// <summary>Показывает возврат объекта <see langword="VARDESC" />.</summary>
		// Token: 0x04002BB6 RID: 11190
		DESCKIND_VARDESC,
		/// <summary>Показывает возврат объекта <see langword="TYPECOMP" />.</summary>
		// Token: 0x04002BB7 RID: 11191
		DESCKIND_TYPECOMP,
		/// <summary>Показывает возвращение <see langword="IMPLICITAPPOBJ" />.</summary>
		// Token: 0x04002BB8 RID: 11192
		DESCKIND_IMPLICITAPPOBJ,
		/// <summary>Показывает метку окончания перечисления.</summary>
		// Token: 0x04002BB9 RID: 11193
		DESCKIND_MAX
	}
}
