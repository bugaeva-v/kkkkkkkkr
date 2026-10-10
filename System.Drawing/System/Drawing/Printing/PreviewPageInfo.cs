using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает информацию для предварительного просмотра одной страницы. Этот класс не наследуется.</summary>
	// Token: 0x020000BE RID: 190
	public sealed class PreviewPageInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PreviewPageInfo" />.</summary>
		/// <param name="image">Изображение страницы, выводимой на печать.</param>
		/// <param name="physicalSize">Высота выводимой на печать страницы в сотых долях дюйма.</param>
		// Token: 0x06000AA1 RID: 2721 RVA: 0x00018484 File Offset: 0x00016684
		public PreviewPageInfo(Image image, Size physicalSize)
		{
			this._image = image;
			this._physicalSize = physicalSize;
		}

		/// <summary>Получает изображение страницы, выводимой на печать.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Image" />, представляющий выводимую на печать страницу.</returns>
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x000184A5 File Offset: 0x000166A5
		public Image Image
		{
			get
			{
				return this._image;
			}
		}

		/// <summary>Получает размер выводимой на печать страницы в сотых долях дюйма.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Size" />, задающий размер выводимой на печать страницы в сотых долях дюйма.</returns>
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000184AD File Offset: 0x000166AD
		public Size PhysicalSize
		{
			get
			{
				return this._physicalSize;
			}
		}

		// Token: 0x040006F7 RID: 1783
		private Image _image;

		// Token: 0x040006F8 RID: 1784
		private Size _physicalSize = Size.Empty;
	}
}
