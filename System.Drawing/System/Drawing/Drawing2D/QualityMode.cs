using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Задает общее качество при отрисовке объектов GDI+.</summary>
	// Token: 0x0200014E RID: 334
	public enum QualityMode
	{
		/// <summary>Указывает недопустимый режим.</summary>
		// Token: 0x04000B5E RID: 2910
		Invalid = -1,
		/// <summary>Задает режим, используемый по умолчанию.</summary>
		// Token: 0x04000B5F RID: 2911
		Default,
		/// <summary>Задает медленную высококачественную отрисовку.</summary>
		// Token: 0x04000B60 RID: 2912
		Low,
		/// <summary>Задает медленную высококачественную отрисовку.</summary>
		// Token: 0x04000B61 RID: 2913
		High
	}
}
