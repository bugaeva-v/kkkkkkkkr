using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Указывает уровень качества, используемый в процессе компоновки.</summary>
	// Token: 0x02000139 RID: 313
	public enum CompositingQuality
	{
		/// <summary>Недопустимое качество.</summary>
		// Token: 0x04000AC5 RID: 2757
		Invalid = -1,
		/// <summary>Качество по умолчанию.</summary>
		// Token: 0x04000AC6 RID: 2758
		Default,
		/// <summary>Высокая скорость, низкое качество.</summary>
		// Token: 0x04000AC7 RID: 2759
		HighSpeed,
		/// <summary>Медленная высококачественная компоновка.</summary>
		// Token: 0x04000AC8 RID: 2760
		HighQuality,
		/// <summary>Используется гамма-коррекция.</summary>
		// Token: 0x04000AC9 RID: 2761
		GammaCorrected,
		/// <summary>Предполагаются линейные значения.</summary>
		// Token: 0x04000ACA RID: 2762
		AssumeLinear
	}
}
