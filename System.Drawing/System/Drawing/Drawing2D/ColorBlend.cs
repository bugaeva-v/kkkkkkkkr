using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Определяет массивы цветов и позиций, используемые для интерполяции смешения цветов в многоцветном градиенте. Этот класс не наследуется.</summary>
	// Token: 0x02000136 RID: 310
	public sealed class ColorBlend
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.ColorBlend" />.</summary>
		// Token: 0x06000E12 RID: 3602 RVA: 0x0001FD9B File Offset: 0x0001DF9B
		public ColorBlend()
		{
			this.Colors = new Color[1];
			this.Positions = new float[1];
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.ColorBlend" /> с указанным числом цветов и позиций.</summary>
		/// <param name="count">Число цветов и позиций в этом объекте <see cref="T:System.Drawing.Drawing2D.ColorBlend" />.</param>
		// Token: 0x06000E13 RID: 3603 RVA: 0x0001FDBB File Offset: 0x0001DFBB
		public ColorBlend(int count)
		{
			this.Colors = new Color[count];
			this.Positions = new float[count];
		}

		/// <summary>Возвращает или задает массив цветов, представляющих цвета для использования в соответствующих позициях вдоль градиента.</summary>
		/// <returns>Массив структур <see cref="T:System.Drawing.Color" />, представляющий цвета для использования в соответствующих положениях вдоль градиента.</returns>
		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0001FDDB File Offset: 0x0001DFDB
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0001FDE3 File Offset: 0x0001DFE3
		public Color[] Colors { get; set; }

		/// <summary>Возвращает или задает позиции вдоль линии градиента.</summary>
		/// <returns>Массив значений, определяющих доли расстояния по линии градиента.</returns>
		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0001FDEC File Offset: 0x0001DFEC
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
		public float[] Positions { get; set; }
	}
}
