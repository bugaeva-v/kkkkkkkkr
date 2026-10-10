using System;
using System.Collections;

namespace System.Drawing.Printing
{
	/// <summary>Задает контроллер печати, отображающий на экране документ в виде набора изображений.</summary>
	// Token: 0x020000CE RID: 206
	public class PreviewPrintController : PrintController
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PreviewPrintController" />.</summary>
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00018E7D File Offset: 0x0001707D
		public PreviewPrintController()
		{
			this.pageInfoList = new ArrayList();
		}

		/// <summary>Получает значение, показывающее, используется ли этот контроллер для обзора печати.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00003610 File Offset: 0x00001810
		public override bool IsPreview
		{
			get
			{
				return true;
			}
		}

		/// <summary>Завершает набор команд управления, определяющих способ и очередность действий при предварительном просмотре выводимого на печать документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий документ, предварительный просмотр которого выполнен.</param>
		/// <param name="e">Класс <see cref="T:System.Drawing.Printing.PrintPageEventArgs" />, содержащий сведения о предварительном просмотре страницы выводимого на печать документа.</param>
		// Token: 0x06000AF5 RID: 2805 RVA: 0x000049FE File Offset: 0x00002BFE
		[MonoTODO]
		public override void OnEndPage(PrintDocument document, PrintPageEventArgs e)
		{
		}

		/// <summary>Начинает набор команд управления, определяющих способ и очередность действий при предварительном просмотре выводимого на печать документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий документ, предварительный просмотр которого выполнен.</param>
		/// <param name="e">Класс <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий сведения о печати документа.</param>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		// Token: 0x06000AF6 RID: 2806 RVA: 0x00018E90 File Offset: 0x00017090
		[MonoTODO]
		public override void OnStartPrint(PrintDocument document, PrintEventArgs e)
		{
			if (!document.PrinterSettings.IsValid)
			{
				throw new InvalidPrinterException(document.PrinterSettings);
			}
			foreach (object obj in this.pageInfoList)
			{
				((PreviewPageInfo)obj).Image.Dispose();
			}
			this.pageInfoList.Clear();
		}

		/// <summary>Завершает набор команд управления, определяющих способ и очередность действий при предварительном просмотре выводимого на печать документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий документ, предварительный просмотр которого выполнен.</param>
		/// <param name="e">Класс <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий сведения о предварительном просмотре выводимого на печать документа.</param>
		// Token: 0x06000AF7 RID: 2807 RVA: 0x000049FE File Offset: 0x00002BFE
		[MonoTODO]
		public override void OnEndPrint(PrintDocument document, PrintEventArgs e)
		{
		}

		/// <summary>Начинает набор команд управления, определяющих способ и очередность действий при предварительном просмотре выводимого на печать документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий документ, предварительный просмотр которого выполнен.</param>
		/// <param name="e">Класс <see cref="T:System.Drawing.Printing.PrintPageEventArgs" />, содержащий сведения о предварительном просмотре страницы выводимого на печать документа. Сначала свойство <see cref="P:System.Drawing.Printing.PrintPageEventArgs.Graphics" /> этого параметра равно <see langword="null" />. Свойству присваивается значение, возвращенное этим методом.</param>
		/// <returns>Класс <see cref="T:System.Drawing.Graphics" />, представляющий страницу из <see cref="T:System.Drawing.Printing.PrintDocument" />.</returns>
		// Token: 0x06000AF8 RID: 2808 RVA: 0x00018F10 File Offset: 0x00017110
		[MonoTODO]
		public override Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e)
		{
			Image image = new Bitmap(e.PageSettings.PaperSize.Width, e.PageSettings.PaperSize.Height);
			PreviewPageInfo previewPageInfo = new PreviewPageInfo(image, new Size(e.PageSettings.PaperSize.Width, e.PageSettings.PaperSize.Height));
			this.pageInfoList.Add(previewPageInfo);
			Graphics graphics = Graphics.FromImage(previewPageInfo.Image);
			graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(new Point(0, 0), new Size(image.Width, image.Height)));
			return graphics;
		}

		/// <summary>Получает или задает значение, показывающее необходимость использования сглаживания при отображении предварительного просмотра.</summary>
		/// <returns>Значение равно <see langword="true" />, если при предварительном просмотре нужно выполнять сглаживание; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00018FB4 File Offset: 0x000171B4
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00018FBC File Offset: 0x000171BC
		public virtual bool UseAntiAlias
		{
			get
			{
				return this.useantialias;
			}
			set
			{
				this.useantialias = value;
			}
		}

		/// <summary>Собирает страницы документа в виде набора изображений.</summary>
		/// <returns>Массив типа <see cref="T:System.Drawing.Printing.PreviewPageInfo" />, содержащий страницы <see cref="T:System.Drawing.Printing.PrintDocument" /> в виде набора рисунков.</returns>
		// Token: 0x06000AFB RID: 2811 RVA: 0x00018FC8 File Offset: 0x000171C8
		public PreviewPageInfo[] GetPreviewPageInfo()
		{
			PreviewPageInfo[] array = new PreviewPageInfo[this.pageInfoList.Count];
			this.pageInfoList.CopyTo(array);
			return array;
		}

		// Token: 0x04000723 RID: 1827
		private bool useantialias;

		// Token: 0x04000724 RID: 1828
		private ArrayList pageInfoList;
	}
}
