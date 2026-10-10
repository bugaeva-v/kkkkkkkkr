using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Указывает, применяется ли сглаживание к линиям, кривым и краям заполненных областей.</summary>
	// Token: 0x02000151 RID: 337
	public enum SmoothingMode
	{
		/// <summary>Указывает недопустимый режим.</summary>
		// Token: 0x04000B64 RID: 2916
		Invalid = -1,
		/// <summary>Задает отсутствие сглаживания.</summary>
		// Token: 0x04000B65 RID: 2917
		Default,
		/// <summary>Задает отсутствие сглаживания.</summary>
		// Token: 0x04000B66 RID: 2918
		HighSpeed,
		/// <summary>Задает отрисовку со сглаживанием.</summary>
		// Token: 0x04000B67 RID: 2919
		HighQuality,
		/// <summary>Задает отсутствие сглаживания.</summary>
		// Token: 0x04000B68 RID: 2920
		None,
		/// <summary>Задает отрисовку со сглаживанием.</summary>
		// Token: 0x04000B69 RID: 2921
		AntiAlias
	}
}
