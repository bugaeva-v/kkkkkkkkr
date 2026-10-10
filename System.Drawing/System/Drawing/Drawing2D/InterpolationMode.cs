using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Перечисление <see cref="T:System.Drawing.Drawing2D.InterpolationMode" /> определяет алгоритм, используемый при масштабировании или повороте изображения.</summary>
	// Token: 0x02000144 RID: 324
	public enum InterpolationMode
	{
		/// <summary>Эквивалентно элементу <see cref="F:System.Drawing.Drawing2D.QualityMode.Invalid" /> перечисления <see cref="T:System.Drawing.Drawing2D.QualityMode" />.</summary>
		// Token: 0x04000B1D RID: 2845
		Invalid = -1,
		/// <summary>Задает режим, используемый по умолчанию.</summary>
		// Token: 0x04000B1E RID: 2846
		Default,
		/// <summary>Задает низкокачественную интерполяцию.</summary>
		// Token: 0x04000B1F RID: 2847
		Low,
		/// <summary>Задает высококачественную интерполяцию.</summary>
		// Token: 0x04000B20 RID: 2848
		High,
		/// <summary>Задает билинейную интерполяцию. Предварительная фильтрация не выполняется. Этот режим не применяется для сжатия изображения до размера менее 50 процентов от его исходного размера.</summary>
		// Token: 0x04000B21 RID: 2849
		Bilinear,
		/// <summary>Задает бикубическую интерполяцию. Предварительная фильтрация не выполняется. Этот режим не применяется для сжатия изображения до размера менее 25 процентов от его исходного размера.</summary>
		// Token: 0x04000B22 RID: 2850
		Bicubic,
		/// <summary>Задает интерполяцию по ближайшим соседним элементам.</summary>
		// Token: 0x04000B23 RID: 2851
		NearestNeighbor,
		/// <summary>Задает высококачественную билинейную интерполяцию. Выполняется предварительная фильтрация, чтобы гарантировать высококачественное сжатие.</summary>
		// Token: 0x04000B24 RID: 2852
		HighQualityBilinear,
		/// <summary>Задает высококачественную бикубическую интерполяцию. Выполняется предварительная фильтрация, чтобы гарантировать высококачественное сжатие. Этот режим создает преобразованные изображения самого высокого качества.</summary>
		// Token: 0x04000B25 RID: 2853
		HighQualityBicubic
	}
}
