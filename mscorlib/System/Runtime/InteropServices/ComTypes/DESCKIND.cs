using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет, к описанию какого типа выполняется привязка.</summary>
	// Token: 0x020007B0 RID: 1968
	[Serializable]
	public enum DESCKIND
	{
		/// <summary>Показывает отсутствие совпадений.</summary>
		// Token: 0x04002C57 RID: 11351
		DESCKIND_NONE,
		/// <summary>Показывает, что структура <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> была возвращена.</summary>
		// Token: 0x04002C58 RID: 11352
		DESCKIND_FUNCDESC,
		/// <summary>Показывает возврат объекта <see langword="VARDESC" />.</summary>
		// Token: 0x04002C59 RID: 11353
		DESCKIND_VARDESC,
		/// <summary>Показывает возврат объекта <see langword="TYPECOMP" />.</summary>
		// Token: 0x04002C5A RID: 11354
		DESCKIND_TYPECOMP,
		/// <summary>Показывает возвращение <see langword="IMPLICITAPPOBJ" />.</summary>
		// Token: 0x04002C5B RID: 11355
		DESCKIND_IMPLICITAPPOBJ,
		/// <summary>Показывает метку окончания перечисления.</summary>
		// Token: 0x04002C5C RID: 11356
		DESCKIND_MAX
	}
}
