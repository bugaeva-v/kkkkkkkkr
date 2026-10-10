using System;

namespace System.Drawing.Imaging
{
	/// <summary>Определяет типы изображений и цвета, на которые влияют параметры настройки цветной или черно-белой палитры объекта <see cref="T:System.Drawing.Imaging.ImageAttributes" />.</summary>
	// Token: 0x020000FB RID: 251
	public enum ColorMatrixFlag
	{
		/// <summary>Позволяет указать, что все значения цветов (включая оттенки серого) настраиваются одной и той же матрицей настройки цвета.</summary>
		// Token: 0x04000867 RID: 2151
		Default,
		/// <summary>Позволяет указать, что настраиваются все цвета, кроме оттенков серого. Оттенком серого является цвет, имеющий одинаковые значения красного, зеленого и синего компонентов.</summary>
		// Token: 0x04000868 RID: 2152
		SkipGrays,
		/// <summary>Возможна настройка только оттенков серого.</summary>
		// Token: 0x04000869 RID: 2153
		AltGrays
	}
}
