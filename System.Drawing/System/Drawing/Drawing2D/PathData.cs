using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Содержит графические данные, составляющие объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />. Этот класс не наследуется.</summary>
	// Token: 0x02000149 RID: 329
	public sealed class PathData
	{
		/// <summary>Получает или задает массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, с помощью которых создается контур.</summary>
		/// <returns>Массив объектов <see cref="T:System.Drawing.PointF" />, представляющий точки, с помощью которых создается контур.</returns>
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x000206CF File Offset: 0x0001E8CF
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x000206D7 File Offset: 0x0001E8D7
		public PointF[] Points { get; set; }

		/// <summary>Получает или задает типы соответствующих точек контура.</summary>
		/// <returns>Массив байтов, определяющих типы соответствующих точек в контуре.</returns>
		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x000206E0 File Offset: 0x0001E8E0
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x000206E8 File Offset: 0x0001E8E8
		public byte[] Types { get; set; }
	}
}
