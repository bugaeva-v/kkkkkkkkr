using System;

namespace System.Drawing.Printing
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Drawing.Printing.PrintDocument.PrintPage" />.</summary>
	// Token: 0x020000D2 RID: 210
	public class PrintPageEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrintPageEventArgs" />.</summary>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, используемый для рисования элемента.</param>
		/// <param name="marginBounds">Область, находящаяся внутри полей.</param>
		/// <param name="pageBounds">Полная площадь бумаги.</param>
		/// <param name="pageSettings">
		///   <see cref="T:System.Drawing.Printing.PageSettings" /> страницы.</param>
		// Token: 0x06000B20 RID: 2848 RVA: 0x00019421 File Offset: 0x00017621
		public PrintPageEventArgs(Graphics graphics, Rectangle marginBounds, Rectangle pageBounds, PageSettings pageSettings)
		{
			this.graphics = graphics;
			this.marginBounds = marginBounds;
			this.pageBounds = pageBounds;
			this.pageSettings = pageSettings;
		}

		/// <summary>Получает или задает значение, показывающее, нужно ли отменить задание для принтера.</summary>
		/// <returns>
		///   <see langword="true" />, если требуется отменить задание; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00019446 File Offset: 0x00017646
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x0001944E File Offset: 0x0001764E
		public bool Cancel
		{
			get
			{
				return this.cancel;
			}
			set
			{
				this.cancel = value;
			}
		}

		/// <summary>Получает <see cref="T:System.Drawing.Graphics" />, используемый для рисования страницы.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Graphics" />, используемый для рисования страницы.</returns>
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00019457 File Offset: 0x00017657
		public Graphics Graphics
		{
			get
			{
				return this.graphics;
			}
		}

		/// <summary>Получает или задает значение, показывающее, нужно ли выводить на печать дополнительную страницу.</summary>
		/// <returns>
		///   <see langword="true" />, если следует выводить на печать дополнительную страницу; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0001945F File Offset: 0x0001765F
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00019467 File Offset: 0x00017667
		public bool HasMorePages
		{
			get
			{
				return this.hasmorePages;
			}
			set
			{
				this.hasmorePages = value;
			}
		}

		/// <summary>Получает прямоугольную область, представляющую находящуюся внутри полей часть страницы.</summary>
		/// <returns>Прямоугольная область, измеряемая в сотых долях дюйма, представляющая находящуюся внутри полей часть страницы.</returns>
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00019470 File Offset: 0x00017670
		public Rectangle MarginBounds
		{
			get
			{
				return this.marginBounds;
			}
		}

		/// <summary>Получает прямоугольную область, представляющую полную площадь страницы.</summary>
		/// <returns>Прямоугольная область, представляющая полную площадь страницы.</returns>
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00019478 File Offset: 0x00017678
		public Rectangle PageBounds
		{
			get
			{
				return this.pageBounds;
			}
		}

		/// <summary>Получает параметры текущей страницы.</summary>
		/// <returns>Параметры текущей страницы.</returns>
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00019480 File Offset: 0x00017680
		public PageSettings PageSettings
		{
			get
			{
				return this.pageSettings;
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00019488 File Offset: 0x00017688
		internal void SetGraphics(Graphics g)
		{
			this.graphics = g;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00019491 File Offset: 0x00017691
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x00019499 File Offset: 0x00017699
		internal GraphicsPrinter GraphicsContext
		{
			get
			{
				return this.graphics_context;
			}
			set
			{
				this.graphics_context = value;
			}
		}

		// Token: 0x04000730 RID: 1840
		private bool cancel;

		// Token: 0x04000731 RID: 1841
		private Graphics graphics;

		// Token: 0x04000732 RID: 1842
		private bool hasmorePages;

		// Token: 0x04000733 RID: 1843
		private Rectangle marginBounds;

		// Token: 0x04000734 RID: 1844
		private Rectangle pageBounds;

		// Token: 0x04000735 RID: 1845
		private PageSettings pageSettings;

		// Token: 0x04000736 RID: 1846
		private GraphicsPrinter graphics_context;
	}
}
