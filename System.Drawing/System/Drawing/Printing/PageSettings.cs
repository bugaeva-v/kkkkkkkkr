using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает параметры одной страницы, выводимой на печать.</summary>
	// Token: 0x020000CD RID: 205
	[Serializable]
	public class PageSettings : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PageSettings" /> с помощью принтера, используемого по умолчанию.</summary>
		// Token: 0x06000ADA RID: 2778 RVA: 0x00018AB0 File Offset: 0x00016CB0
		public PageSettings() : this(new PrinterSettings())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PageSettings" /> с помощью указанного принтера.</summary>
		/// <param name="printerSettings">
		///   <see cref="T:System.Drawing.Printing.PrinterSettings" />, описывающий используемый принтер.</param>
		// Token: 0x06000ADB RID: 2779 RVA: 0x00018AC0 File Offset: 0x00016CC0
		public PageSettings(PrinterSettings printerSettings)
		{
			this.margins = new Margins();
			base..ctor();
			this.PrinterSettings = printerSettings;
			this.color = printerSettings.DefaultPageSettings.color;
			this.landscape = printerSettings.DefaultPageSettings.landscape;
			this.paperSize = printerSettings.DefaultPageSettings.paperSize;
			this.paperSource = printerSettings.DefaultPageSettings.paperSource;
			this.printerResolution = printerSettings.DefaultPageSettings.printerResolution;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00018B3A File Offset: 0x00016D3A
		internal PageSettings(PrinterSettings printerSettings, bool color, bool landscape, PaperSize paperSize, PaperSource paperSource, PrinterResolution printerResolution)
		{
			this.margins = new Margins();
			base..ctor();
			this.PrinterSettings = printerSettings;
			this.color = color;
			this.landscape = landscape;
			this.paperSize = paperSize;
			this.paperSource = paperSource;
			this.printerResolution = printerResolution;
		}

		/// <summary>Получает размер страницы, принимая во внимание ориентацию страницы, заданную свойством <see cref="P:System.Drawing.Printing.PageSettings.Landscape" />.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Rectangle" />, представляющий длину и ширину страницы в сотых долях дюйма.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00018B7C File Offset: 0x00016D7C
		public Rectangle Bounds
		{
			get
			{
				int num = this.paperSize.Width;
				int num2 = this.paperSize.Height;
				num -= this.margins.Left + this.margins.Right;
				num2 -= this.margins.Top + this.margins.Bottom;
				if (this.landscape)
				{
					int num3 = num;
					num = num2;
					num2 = num3;
				}
				return new Rectangle(this.margins.Left, this.margins.Top, num, num2);
			}
		}

		/// <summary>Получает или задает значение, определяющее необходимость цветной печати страницы.</summary>
		/// <returns>Значение равно <see langword="true" />, если нужно выполнить цветную печать страницы; в противном случае — <see langword="false" />. Значение по умолчанию определяется принтером.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00018BFE File Offset: 0x00016DFE
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00018C1F File Offset: 0x00016E1F
		public bool Color
		{
			get
			{
				if (!this.printerSettings.IsValid)
				{
					throw new InvalidPrinterException(this.printerSettings);
				}
				return this.color;
			}
			set
			{
				this.color = value;
			}
		}

		/// <summary>Получает или задает значение, показывающее, выполняется печать страницы с альбомной или с книжной ориентацией.</summary>
		/// <returns>Значение равно <see langword="true" />, если нужно выполнить печать страницы с альбомной ориентацией; в противном случае — <see langword="false" />. Значение по умолчанию определяется принтером.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00018C28 File Offset: 0x00016E28
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00018C49 File Offset: 0x00016E49
		public bool Landscape
		{
			get
			{
				if (!this.printerSettings.IsValid)
				{
					throw new InvalidPrinterException(this.printerSettings);
				}
				return this.landscape;
			}
			set
			{
				this.landscape = value;
			}
		}

		/// <summary>Получает или задает поля страницы.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.Margins" />, представляющий поля страницы в сотых долях дюйма. По умолчанию поля со всех сторон установлены равными 1 дюйму.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00018C52 File Offset: 0x00016E52
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00018C73 File Offset: 0x00016E73
		public Margins Margins
		{
			get
			{
				if (!this.printerSettings.IsValid)
				{
					throw new InvalidPrinterException(this.printerSettings);
				}
				return this.margins;
			}
			set
			{
				this.margins = value;
			}
		}

		/// <summary>Получает или задает размер бумаги для страницы.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PaperSize" />, представляющий размер бумаги. Размер бумаги по умолчанию устанавливается в соответствии с настройками принтера.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, указанный в свойстве <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, отсутствует или не установлен принтер по умолчанию.</exception>
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00018C7C File Offset: 0x00016E7C
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00018C9D File Offset: 0x00016E9D
		public PaperSize PaperSize
		{
			get
			{
				if (!this.printerSettings.IsValid)
				{
					throw new InvalidPrinterException(this.printerSettings);
				}
				return this.paperSize;
			}
			set
			{
				if (value != null)
				{
					this.paperSize = value;
				}
			}
		}

		/// <summary>Получает или задает источник бумаги для страницы, например верхний лоток принтера.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PaperSource" />, задающий источник бумаги. Источник бумаги по умолчанию устанавливается в соответствии с настройками принтера.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, указанный в свойстве <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, отсутствует или не установлен принтер по умолчанию.</exception>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00018CA9 File Offset: 0x00016EA9
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00018CCA File Offset: 0x00016ECA
		public PaperSource PaperSource
		{
			get
			{
				if (!this.printerSettings.IsValid)
				{
					throw new InvalidPrinterException(this.printerSettings);
				}
				return this.paperSource;
			}
			set
			{
				if (value != null)
				{
					this.paperSource = value;
				}
			}
		}

		/// <summary>Получает или задает разрешающую способность принтера для страницы.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PrinterResolution" />, указывающий разрешающую способность принтера для страницы. Разрешающая способность принтера по умолчанию устанавливается в соответствии с настройками принтера.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, указанный в свойстве <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, отсутствует или не установлен принтер по умолчанию.</exception>
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00018CD6 File Offset: 0x00016ED6
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00018CF7 File Offset: 0x00016EF7
		public PrinterResolution PrinterResolution
		{
			get
			{
				if (!this.printerSettings.IsValid)
				{
					throw new InvalidPrinterException(this.printerSettings);
				}
				return this.printerResolution;
			}
			set
			{
				if (value != null)
				{
					this.printerResolution = value;
				}
			}
		}

		/// <summary>Получает или задает параметры принтера для страницы.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PrinterSettings" />, представляющий параметры принтера, связанные с этой страницей.</returns>
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00018D03 File Offset: 0x00016F03
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x00018D0B File Offset: 0x00016F0B
		public PrinterSettings PrinterSettings
		{
			get
			{
				return this.printerSettings;
			}
			set
			{
				this.printerSettings = value;
			}
		}

		/// <summary>Получает координату на оси х в сотых долях дюйма фиксированного поля с левой стороны страницы.</summary>
		/// <returns>Координата на оси х в сотых долях дюйма левого фиксированного поля.</returns>
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00018D14 File Offset: 0x00016F14
		public float HardMarginX
		{
			get
			{
				return this.hardMarginX;
			}
		}

		/// <summary>Получает координату на оси у в сотых долях дюйма фиксированного поля в верхней части страницы.</summary>
		/// <returns>Координата на оси у в сотых долях дюйма фиксированного поля в верхней части страницы.</returns>
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00018D1C File Offset: 0x00016F1C
		public float HardMarginY
		{
			get
			{
				return this.hardMarginY;
			}
		}

		/// <summary>Получает границы области печати страницы для принтера.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.RectangleF" />, представляющий длину и ширину страницы в сотых долях дюйма области, в которой принтер может осуществлять печать.</returns>
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00018D24 File Offset: 0x00016F24
		public RectangleF PrintableArea
		{
			get
			{
				return this.printableArea;
			}
		}

		/// <summary>Создает копию данного объекта <see cref="T:System.Drawing.Printing.PageSettings" />.</summary>
		/// <returns>Копия этого объекта.</returns>
		// Token: 0x06000AEF RID: 2799 RVA: 0x00018D2C File Offset: 0x00016F2C
		public object Clone()
		{
			PrinterResolution printerResolution = new PrinterResolution(this.printerResolution.Kind, this.printerResolution.X, this.printerResolution.Y);
			PaperSource paperSource = new PaperSource(this.paperSource.Kind, this.paperSource.SourceName);
			PaperSize paperSize = new PaperSize(this.paperSize.PaperName, this.paperSize.Width, this.paperSize.Height);
			paperSize.RawKind = (int)this.paperSize.Kind;
			return new PageSettings(this.printerSettings, this.color, this.landscape, paperSize, paperSource, printerResolution)
			{
				Margins = (Margins)this.margins.Clone()
			};
		}

		/// <summary>Копирует релевантную информацию из <see cref="T:System.Drawing.Printing.PageSettings" /> в указанную структуру <see langword="DEVMODE" />.</summary>
		/// <param name="hdevmode">Дескриптор Win32 структуры <see langword="DEVMODE" />.</param>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, указанный в свойстве <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, отсутствует или не установлен принтер по умолчанию.</exception>
		// Token: 0x06000AF0 RID: 2800 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PageSettings.CopyToHdevmode")]
		public void CopyToHdevmode(IntPtr hdevmode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Копирует релевантную информацию в форму <see cref="T:System.Drawing.Printing.PageSettings" /> из указанной структуры <see langword="DEVMODE" />.</summary>
		/// <param name="hdevmode">Дескриптор Win32 структуры <see langword="DEVMODE" />.</param>
		/// <exception cref="T:System.ArgumentException">Недопустимый дескриптор принтера.</exception>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, указанный в свойстве <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, отсутствует или не установлен принтер по умолчанию.</exception>
		// Token: 0x06000AF1 RID: 2801 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PageSettings.SetHdevmode")]
		public void SetHdevmode(IntPtr hdevmode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Преобразует объект <see cref="T:System.Drawing.Printing.PageSettings" /> в форму строки.</summary>
		/// <returns>Строка, отображающая различные параметры свойства для <see cref="T:System.Drawing.Printing.PageSettings" />.</returns>
		// Token: 0x06000AF2 RID: 2802 RVA: 0x00018DE4 File Offset: 0x00016FE4
		public override string ToString()
		{
			return string.Format("[PageSettings: Color={0}" + ", Landscape={1}" + ", Margins={2}" + ", PaperSize={3}" + ", PaperSource={4}" + ", PrinterResolution={5}" + "]", new object[]
			{
				this.color,
				this.landscape,
				this.margins,
				this.paperSize,
				this.paperSource,
				this.printerResolution
			});
		}

		// Token: 0x04000719 RID: 1817
		internal bool color;

		// Token: 0x0400071A RID: 1818
		internal bool landscape;

		// Token: 0x0400071B RID: 1819
		internal PaperSize paperSize;

		// Token: 0x0400071C RID: 1820
		internal PaperSource paperSource;

		// Token: 0x0400071D RID: 1821
		internal PrinterResolution printerResolution;

		// Token: 0x0400071E RID: 1822
		private Margins margins;

		// Token: 0x0400071F RID: 1823
		private float hardMarginX;

		// Token: 0x04000720 RID: 1824
		private float hardMarginY;

		// Token: 0x04000721 RID: 1825
		private RectangleF printableArea;

		// Token: 0x04000722 RID: 1826
		private PrinterSettings printerSettings;
	}
}
