using System;
using System.ComponentModel;

namespace System.Drawing.Printing
{
	/// <summary>Определяет повторно используемый объект, который отправляет выходные данные на принтер при печати из приложения Windows Forms.</summary>
	// Token: 0x020000D0 RID: 208
	[DefaultEvent("PrintPage")]
	[DefaultProperty("DocumentName")]
	[ToolboxItemFilter("System.Drawing.Printing", ToolboxItemFilterType.Allow)]
	public class PrintDocument : Component
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrintDocument" />.</summary>
		// Token: 0x06000B02 RID: 2818 RVA: 0x00018FF4 File Offset: 0x000171F4
		public PrintDocument()
		{
			this.documentname = "document";
			this.printersettings = new PrinterSettings();
			this.defaultpagesettings = (PageSettings)this.printersettings.DefaultPageSettings.Clone();
			this.printcontroller = new StandardPrintController();
		}

		/// <summary>Получает или задает параметры страницы, используемые по умолчанию для всех выводимых на печать страниц.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PageSettings" />, указывающий параметры страницы по умолчанию для документа.</returns>
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00019043 File Offset: 0x00017243
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x0001904B File Offset: 0x0001724B
		[SRDescription("The settings for the current page.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public PageSettings DefaultPageSettings
		{
			get
			{
				return this.defaultpagesettings;
			}
			set
			{
				this.defaultpagesettings = value;
			}
		}

		/// <summary>Получает или задает имя документа, отображаемое (например, в диалоговом окне состояния принтера или в очереди принтера) во время печати документа.</summary>
		/// <returns>Имя документа, отображаемое во время печати. По умолчанию — "документ".</returns>
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00019054 File Offset: 0x00017254
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x0001905C File Offset: 0x0001725C
		[DefaultValue("document")]
		[SRDescription("The name of the document.")]
		public string DocumentName
		{
			get
			{
				return this.documentname;
			}
			set
			{
				this.documentname = value;
			}
		}

		/// <summary>Получает или задает контроллер печати, выполняющий печать.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PrintController" />, выполняющий печать. По умолчанию это новый экземпляр класса <see cref="T:System.Windows.Forms.PrintControllerWithStatusDialog" />.</returns>
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00019065 File Offset: 0x00017265
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x0001906D File Offset: 0x0001726D
		[Browsable(false)]
		[SRDescription("The print controller object.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public PrintController PrintController
		{
			get
			{
				return this.printcontroller;
			}
			set
			{
				this.printcontroller = value;
			}
		}

		/// <summary>Получает или задает принтер, выполняющий печать документа.</summary>
		/// <returns>Класс <see cref="T:System.Drawing.Printing.PrinterSettings" />, указывающий время и способ печати документа. По умолчанию его значение равно <see cref="T:System.Drawing.Printing.PrinterSettings" />, для свойств также задаются значения по умолчанию.</returns>
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00019076 File Offset: 0x00017276
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x0001907E File Offset: 0x0001727E
		[SRDescription("The current settings for the active printer.")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public PrinterSettings PrinterSettings
		{
			get
			{
				return this.printersettings;
			}
			set
			{
				this.printersettings = ((value == null) ? new PrinterSettings() : value);
			}
		}

		/// <summary>Получает или задает значение, показывающее, находится ли связанный со страницей графический объект внутри полей, заданных пользователем, или в верхнем левом углу пригодной для печати площади страницы.</summary>
		/// <returns>Значение равно <see langword="true" />, если исходный графический объект располагается внутри полей страницы. Если графический объект начинается в верхнем левом углу страницы — значение равно <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00019091 File Offset: 0x00017291
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00019099 File Offset: 0x00017299
		[SRDescription("Determines if the origin is set at the specified margins.")]
		[DefaultValue(false)]
		public bool OriginAtMargins
		{
			get
			{
				return this.originAtMargins;
			}
			set
			{
				this.originAtMargins = value;
			}
		}

		/// <summary>Запускает процесс печати документа.</summary>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		// Token: 0x06000B0D RID: 2829 RVA: 0x000190A4 File Offset: 0x000172A4
		public void Print()
		{
			PrintEventArgs printEventArgs = new PrintEventArgs();
			this.OnBeginPrint(printEventArgs);
			if (printEventArgs.Cancel)
			{
				return;
			}
			this.PrintController.OnStartPrint(this, printEventArgs);
			if (printEventArgs.Cancel)
			{
				return;
			}
			Graphics graphics = null;
			if (printEventArgs.GraphicsContext != null)
			{
				graphics = Graphics.FromHdc(printEventArgs.GraphicsContext.Hdc);
				printEventArgs.GraphicsContext.Graphics = graphics;
			}
			PrintPageEventArgs printPageEventArgs;
			do
			{
				QueryPageSettingsEventArgs queryPageSettingsEventArgs = new QueryPageSettingsEventArgs(this.DefaultPageSettings.Clone() as PageSettings);
				this.OnQueryPageSettings(queryPageSettingsEventArgs);
				PageSettings pageSettings = queryPageSettingsEventArgs.PageSettings;
				printPageEventArgs = new PrintPageEventArgs(graphics, pageSettings.Bounds, new Rectangle(0, 0, pageSettings.PaperSize.Width, pageSettings.PaperSize.Height), pageSettings);
				printPageEventArgs.GraphicsContext = printEventArgs.GraphicsContext;
				Graphics graphics2 = this.PrintController.OnStartPage(this, printPageEventArgs);
				printPageEventArgs.SetGraphics(graphics2);
				if (!printPageEventArgs.Cancel)
				{
					this.OnPrintPage(printPageEventArgs);
				}
				this.PrintController.OnEndPage(this, printPageEventArgs);
			}
			while (!printPageEventArgs.Cancel && printPageEventArgs.HasMorePages);
			this.OnEndPrint(printEventArgs);
			this.PrintController.OnEndPrint(this, printEventArgs);
		}

		/// <summary>Содержит сведения о выводимом на печать документе в форме строки.</summary>
		/// <returns>Строка.</returns>
		// Token: 0x06000B0E RID: 2830 RVA: 0x000191BE File Offset: 0x000173BE
		public override string ToString()
		{
			return "[PrintDocument " + this.DocumentName + "]";
		}

		/// <summary>Вызывает событие <see cref="E:System.Drawing.Printing.PrintDocument.BeginPrint" />. Вызывается после вызова метода <see cref="M:System.Drawing.Printing.PrintDocument.Print" /> и перед печатью первой страницы документа.</summary>
		/// <param name="e">Объект <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000B0F RID: 2831 RVA: 0x000191D5 File Offset: 0x000173D5
		protected virtual void OnBeginPrint(PrintEventArgs e)
		{
			if (this.BeginPrint != null)
			{
				this.BeginPrint(this, e);
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.Drawing.Printing.PrintDocument.EndPrint" />. Вызывается после вывода на печать последней страницы документа.</summary>
		/// <param name="e">Объект <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000B10 RID: 2832 RVA: 0x000191EC File Offset: 0x000173EC
		protected virtual void OnEndPrint(PrintEventArgs e)
		{
			if (this.EndPrint != null)
			{
				this.EndPrint(this, e);
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.Drawing.Printing.PrintDocument.PrintPage" />. Вызывается перед выводом страницы на печать.</summary>
		/// <param name="e">Объект <see cref="T:System.Drawing.Printing.PrintPageEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000B11 RID: 2833 RVA: 0x00019203 File Offset: 0x00017403
		protected virtual void OnPrintPage(PrintPageEventArgs e)
		{
			if (this.PrintPage != null)
			{
				this.PrintPage(this, e);
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.Drawing.Printing.PrintDocument.QueryPageSettings" />. Происходит непосредственно перед каждым событием <see cref="E:System.Drawing.Printing.PrintDocument.PrintPage" />.</summary>
		/// <param name="e">Объект <see cref="T:System.Drawing.Printing.QueryPageSettingsEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000B12 RID: 2834 RVA: 0x0001921A File Offset: 0x0001741A
		protected virtual void OnQueryPageSettings(QueryPageSettingsEventArgs e)
		{
			if (this.QueryPageSettings != null)
			{
				this.QueryPageSettings(this, e);
			}
		}

		/// <summary>Происходит при вызове метода <see cref="M:System.Drawing.Printing.PrintDocument.Print" /> и перед печатью первой страницы документа.</summary>
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000B13 RID: 2835 RVA: 0x00019234 File Offset: 0x00017434
		// (remove) Token: 0x06000B14 RID: 2836 RVA: 0x0001926C File Offset: 0x0001746C
		[SRDescription("Raised when printing begins")]
		public event PrintEventHandler BeginPrint;

		/// <summary>Происходит после вывода на печать последней страницы документа.</summary>
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000B15 RID: 2837 RVA: 0x000192A4 File Offset: 0x000174A4
		// (remove) Token: 0x06000B16 RID: 2838 RVA: 0x000192DC File Offset: 0x000174DC
		[SRDescription("Raised when printing ends")]
		public event PrintEventHandler EndPrint;

		/// <summary>Происходит, когда необходимо вывести на печать текущую страницу.</summary>
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000B17 RID: 2839 RVA: 0x00019314 File Offset: 0x00017514
		// (remove) Token: 0x06000B18 RID: 2840 RVA: 0x0001934C File Offset: 0x0001754C
		[SRDescription("Raised when printing of a new page begins")]
		public event PrintPageEventHandler PrintPage;

		/// <summary>Происходит непосредственно перед каждым событием <see cref="E:System.Drawing.Printing.PrintDocument.PrintPage" />.</summary>
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000B19 RID: 2841 RVA: 0x00019384 File Offset: 0x00017584
		// (remove) Token: 0x06000B1A RID: 2842 RVA: 0x000193BC File Offset: 0x000175BC
		[SRDescription("Raised before printing of a new page begins")]
		public event QueryPageSettingsEventHandler QueryPageSettings;

		// Token: 0x04000725 RID: 1829
		private PageSettings defaultpagesettings;

		// Token: 0x04000726 RID: 1830
		private PrinterSettings printersettings;

		// Token: 0x04000727 RID: 1831
		private PrintController printcontroller;

		// Token: 0x04000728 RID: 1832
		private string documentname;

		// Token: 0x04000729 RID: 1833
		private bool originAtMargins;
	}
}
