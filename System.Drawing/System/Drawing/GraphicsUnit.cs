using System;

namespace System.Drawing
{
	/// <summary>Задает единицу измерения для заданных данных.</summary>
	// Token: 0x02000074 RID: 116
	public enum GraphicsUnit
	{
		/// <summary>Задает в качестве единицы измерения единицу мировой системы координат.</summary>
		// Token: 0x0400049D RID: 1181
		World,
		/// <summary>Задает единицу измерения устройства отображения. Обычно это пиксели для видеодисплеев и 1/100 дюйма для принтеров.</summary>
		// Token: 0x0400049E RID: 1182
		Display,
		/// <summary>Задает в качестве единицы измерения пиксель устройства.</summary>
		// Token: 0x0400049F RID: 1183
		Pixel,
		/// <summary>Задает в качестве единицы измерения пункт (1/72 дюйма).</summary>
		// Token: 0x040004A0 RID: 1184
		Point,
		/// <summary>Задает в качестве единицы измерения дюйм.</summary>
		// Token: 0x040004A1 RID: 1185
		Inch,
		/// <summary>Задает в качестве единицы измерения единицу документа (1/300 дюйма).</summary>
		// Token: 0x040004A2 RID: 1186
		Document,
		/// <summary>Задает в качестве единицы измерения миллиметр.</summary>
		// Token: 0x040004A3 RID: 1187
		Millimeter
	}
}
