using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Определяет шаблон смешивания для объекта <see cref="T:System.Drawing.Drawing2D.LinearGradientBrush" />. Этот класс не наследуется.</summary>
	// Token: 0x02000134 RID: 308
	public sealed class Blend
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.Blend" />.</summary>
		// Token: 0x06000E0C RID: 3596 RVA: 0x0001FD39 File Offset: 0x0001DF39
		public Blend()
		{
			this.Factors = new float[1];
			this.Positions = new float[1];
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.Blend" /> с указанным числом коэффициентов и позиций.</summary>
		/// <param name="count">Число элементов в массивах <see cref="P:System.Drawing.Drawing2D.Blend.Factors" /> и <see cref="P:System.Drawing.Drawing2D.Blend.Positions" />.</param>
		// Token: 0x06000E0D RID: 3597 RVA: 0x0001FD59 File Offset: 0x0001DF59
		public Blend(int count)
		{
			this.Factors = new float[count];
			this.Positions = new float[count];
		}

		/// <summary>Возвращает или задает массив коэффициентов смешения для градиента.</summary>
		/// <returns>Массив коэффициентов смешения, которые определяют те процентные отношения начального и конечного цветов, которые должны использоваться для соответствующего местоположения.</returns>
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0001FD79 File Offset: 0x0001DF79
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x0001FD81 File Offset: 0x0001DF81
		public float[] Factors { get; set; }

		/// <summary>Возвращает или задает массив позиций смешения для градиента.</summary>
		/// <returns>Массив мест смешения, определяющий доли расстояния по линии градиента.</returns>
		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0001FD8A File Offset: 0x0001DF8A
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x0001FD92 File Offset: 0x0001DF92
		public float[] Positions { get; set; }
	}
}
