using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace System.Drawing.Printing
{
	/// <summary>Задает сведения о способе печати документа, включая принтер, выполняющий печать из приложения Windows Forms.</summary>
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public class PrinterSettings : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrinterSettings" />.</summary>
		// Token: 0x06000B2C RID: 2860 RVA: 0x000194A2 File Offset: 0x000176A2
		public PrinterSettings() : this(SysPrn.CreatePrintingService())
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x000194AF File Offset: 0x000176AF
		internal PrinterSettings(PrintingServices printing_services)
		{
			this.printing_services = printing_services;
			this.printer_name = printing_services.DefaultPrinter;
			this.ResetToDefaults();
			printing_services.LoadPrinterSettings(this.printer_name, this);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000194DD File Offset: 0x000176DD
		private void ResetToDefaults()
		{
			this.printer_resolutions = null;
			this.paper_sizes = null;
			this.paper_sources = null;
			this.default_pagesettings = null;
			this.maximum_page = 9999;
			this.copies = 1;
			this.collate = true;
		}

		/// <summary>Получает значение, показывающее, поддерживает ли принтер двухстороннюю печать.</summary>
		/// <returns>Значение равно <see langword="true" />, если принтер поддерживает двухстороннюю печать; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00019514 File Offset: 0x00017714
		public bool CanDuplex
		{
			get
			{
				return this.can_duplex;
			}
		}

		/// <summary>Получает или задает значение, показывающее, выполняется ли разбор документа по копиям.</summary>
		/// <returns>Значение равно <see langword="true" />, если выводимый на печать документ разбирается по копиям; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0001951C File Offset: 0x0001771C
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00019524 File Offset: 0x00017724
		public bool Collate
		{
			get
			{
				return this.collate;
			}
			set
			{
				this.collate = value;
			}
		}

		/// <summary>Получает или задает количество копий документа, которое необходимо вывести на печать.</summary>
		/// <returns>Число копий для печати. Значение по умолчанию — 1.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.Copies" /> меньше нуля.</exception>
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0001952D File Offset: 0x0001772D
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00019535 File Offset: 0x00017735
		public short Copies
		{
			get
			{
				return this.copies;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("The value of the Copies property is less than zero.");
				}
				this.copies = value;
			}
		}

		/// <summary>Получает параметры страницы по умолчанию для принтера.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PageSettings" />, представляющий параметры страницы по умолчанию для этого принтера.</returns>
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00019550 File Offset: 0x00017750
		public PageSettings DefaultPageSettings
		{
			get
			{
				if (this.default_pagesettings == null)
				{
					this.default_pagesettings = new PageSettings(this, this.SupportsColor, false, new PaperSize("A4", 827, 1169), new PaperSource(PaperSourceKind.FormSource, "Tray"), new PrinterResolution(PrinterResolutionKind.Medium, 200, 200));
				}
				return this.default_pagesettings;
			}
		}

		/// <summary>Получает или задает параметры принтера для двухсторонней печати.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Printing.Duplex" />. Значение по умолчанию определяется принтером.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.Duplex" /> не равно ни одному из значений <see cref="T:System.Drawing.Printing.Duplex" />.</exception>
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000195AF File Offset: 0x000177AF
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x000195B7 File Offset: 0x000177B7
		public Duplex Duplex
		{
			get
			{
				return this.duplex;
			}
			set
			{
				this.duplex = value;
			}
		}

		/// <summary>Получает или задает необходимость печати номера страницы на первой странице документа.</summary>
		/// <returns>Номер страницы на первой странице, выводимой на печать.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <see cref="P:System.Drawing.Printing.PrinterSettings.FromPage" /> меньше нуля.</exception>
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x000195C0 File Offset: 0x000177C0
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x000195C8 File Offset: 0x000177C8
		public int FromPage
		{
			get
			{
				return this.from_page;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("The value of the FromPage property is less than zero");
				}
				this.from_page = value;
			}
		}

		/// <summary>Получает названия всех принтеров, установленных на компьютере.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PrinterSettings.StringCollection" />, представляющий названия всех принтеров, установленных на компьютере.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Доступность принтеров не регистрируется.</exception>
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000195E0 File Offset: 0x000177E0
		public static PrinterSettings.StringCollection InstalledPrinters
		{
			get
			{
				return SysPrn.GlobalService.InstalledPrinters;
			}
		}

		/// <summary>Получает значение, определяющее необходимость назначения при помощи свойства <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" /> принтера, используемого по умолчанию, за исключением случаев явного указания пользователем свойства <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />.</summary>
		/// <returns>
		///   <see langword="true" />, если свойство <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" /> назначает принтер по умолчанию, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x000195EC File Offset: 0x000177EC
		public bool IsDefaultPrinter
		{
			get
			{
				return this.printer_name == this.printing_services.DefaultPrinter;
			}
		}

		/// <summary>Получает значение, показывающее, является ли принтер плоттером.</summary>
		/// <returns>Значение равно <see langword="true" /> — если принтер является плоттером, <see langword="false" /> — если растровым принтером.</returns>
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00019604 File Offset: 0x00017804
		public bool IsPlotter
		{
			get
			{
				return this.is_plotter;
			}
		}

		/// <summary>Получает значение, определяющее, назначает ли свойство <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" /> действительный принтер.</summary>
		/// <returns>
		///   <see langword="true" />, если свойство <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" /> назначает действительный принтер, в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0001960C File Offset: 0x0001780C
		public bool IsValid
		{
			get
			{
				return this.printing_services.IsPrinterValid(this.printer_name);
			}
		}

		/// <summary>Получает угол поворота страницы в градусах от горизонтальной к вертикальной ориентации.</summary>
		/// <returns>Угол поворота страницы в градусах от горизонтальной к вертикальной ориентации.</returns>
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0001961F File Offset: 0x0001781F
		public int LandscapeAngle
		{
			get
			{
				return this.landscape_angle;
			}
		}

		/// <summary>Получает максимально допустимое число копий, которое пользователь может напечатать на данном принтере одновременно.</summary>
		/// <returns>Максимально допустимое число копий, которое пользователь может напечатать на данном принтере одновременно.</returns>
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x00019627 File Offset: 0x00017827
		public int MaximumCopies
		{
			get
			{
				return this.maximum_copies;
			}
		}

		/// <summary>Получает или задает максимальное значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.FromPage" /> или свойства <see cref="P:System.Drawing.Printing.PrinterSettings.ToPage" />, которое может быть выбрано в <see cref="T:System.Windows.Forms.PrintDialog" />.</summary>
		/// <returns>Максимальное значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.FromPage" /> или свойства <see cref="P:System.Drawing.Printing.PrinterSettings.ToPage" />, которое может быть выбрано в <see cref="T:System.Windows.Forms.PrintDialog" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.MaximumPage" /> меньше нуля.</exception>
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0001962F File Offset: 0x0001782F
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00019637 File Offset: 0x00017837
		public int MaximumPage
		{
			get
			{
				return this.maximum_page;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("The value of the MaximumPage property is less than zero");
				}
				this.maximum_page = value;
			}
		}

		/// <summary>Получает или задает минимальное значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.FromPage" /> или свойства <see cref="P:System.Drawing.Printing.PrinterSettings.ToPage" />, которое может быть выбрано в <see cref="T:System.Windows.Forms.PrintDialog" />.</summary>
		/// <returns>Минимальное значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.FromPage" /> или свойства <see cref="P:System.Drawing.Printing.PrinterSettings.ToPage" />, которое может быть выбрано в <see cref="T:System.Windows.Forms.PrintDialog" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.MinimumPage" /> меньше нуля.</exception>
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0001964F File Offset: 0x0001784F
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00019657 File Offset: 0x00017857
		public int MinimumPage
		{
			get
			{
				return this.minimum_page;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("The value of the MaximumPage property is less than zero");
				}
				this.minimum_page = value;
			}
		}

		/// <summary>Получает размеры бумаги, поддерживаемые принтером.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSizeCollection" />, представляющий размеры бумаги, поддерживаемые принтером.</returns>
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0001966F File Offset: 0x0001786F
		public PrinterSettings.PaperSizeCollection PaperSizes
		{
			get
			{
				if (!this.IsValid)
				{
					throw new InvalidPrinterException(this);
				}
				return this.paper_sizes;
			}
		}

		/// <summary>Получает допустимые при работе с принтером источники бумаги.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSourceCollection" />, представляющий допустимые при работе с принтером источники бумаги.</returns>
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00019686 File Offset: 0x00017886
		public PrinterSettings.PaperSourceCollection PaperSources
		{
			get
			{
				if (!this.IsValid)
				{
					throw new InvalidPrinterException(this);
				}
				return this.paper_sources;
			}
		}

		/// <summary>Получает или задает имя файла во время печати в файл.</summary>
		/// <returns>Имя файла во время печати в файл.</returns>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0001969D File Offset: 0x0001789D
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x000196A5 File Offset: 0x000178A5
		public string PrintFileName
		{
			get
			{
				return this.print_filename;
			}
			set
			{
				this.print_filename = value;
			}
		}

		/// <summary>Получает или задает имя используемого принтера.</summary>
		/// <returns>Имя используемого принтера.</returns>
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000196AE File Offset: 0x000178AE
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x000196B6 File Offset: 0x000178B6
		public string PrinterName
		{
			get
			{
				return this.printer_name;
			}
			set
			{
				if (this.printer_name == value)
				{
					return;
				}
				this.printer_name = value;
				this.printing_services.LoadPrinterSettings(this.printer_name, this);
			}
		}

		/// <summary>Получает разрешения, поддерживаемые принтером.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Printing.PrinterSettings.PrinterResolutionCollection" />, представляющий разрешения, поддерживаемые принтером.</returns>
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000196E0 File Offset: 0x000178E0
		public PrinterSettings.PrinterResolutionCollection PrinterResolutions
		{
			get
			{
				if (!this.IsValid)
				{
					throw new InvalidPrinterException(this);
				}
				if (this.printer_resolutions == null)
				{
					this.printer_resolutions = new PrinterSettings.PrinterResolutionCollection(new PrinterResolution[0]);
					this.printing_services.LoadPrinterResolutions(this.printer_name, this);
				}
				return this.printer_resolutions;
			}
		}

		/// <summary>Получает или задает номера страниц, отправленных на печать пользователем.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Printing.PrintRange" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.PrintRange" /> не равно ни одному из значений <see cref="T:System.Drawing.Printing.PrintRange" />.</exception>
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0001972D File Offset: 0x0001792D
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x00019735 File Offset: 0x00017935
		public PrintRange PrintRange
		{
			get
			{
				return this.print_range;
			}
			set
			{
				if (value != PrintRange.AllPages && value != PrintRange.Selection && value != PrintRange.SomePages)
				{
					throw new InvalidEnumArgumentException("The value of the PrintRange property is not one of the PrintRange values");
				}
				this.print_range = value;
			}
		}

		/// <summary>Получает или задает значение, определяющее, выводятся данные на печать или отправляются не в порт, а в файл.</summary>
		/// <returns>Значение <see langword="true" />, если выводимые на печать данные отправляются в файл; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00019754 File Offset: 0x00017954
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x0001975C File Offset: 0x0001795C
		public bool PrintToFile
		{
			get
			{
				return this.print_tofile;
			}
			set
			{
				this.print_tofile = value;
			}
		}

		/// <summary>Получает значение, показывающее, поддерживает принтер цветную печать или нет.</summary>
		/// <returns>
		///   <see langword="true" />, если принтер поддерживает цветную печать, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00019765 File Offset: 0x00017965
		public bool SupportsColor
		{
			get
			{
				return this.supports_color;
			}
		}

		/// <summary>Получает или задает номер последней страницы, выводимой на печать.</summary>
		/// <returns>Номер последней страницы для печати.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Drawing.Printing.PrinterSettings.ToPage" /> меньше нуля.</exception>
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0001976D File Offset: 0x0001796D
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00019775 File Offset: 0x00017975
		public int ToPage
		{
			get
			{
				return this.to_page;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("The value of the ToPage property is less than zero");
				}
				this.to_page = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0001978D File Offset: 0x0001798D
		internal NameValueCollection PrinterCapabilities
		{
			get
			{
				if (this.printer_capabilities == null)
				{
					this.printer_capabilities = new NameValueCollection();
				}
				return this.printer_capabilities;
			}
		}

		/// <summary>Создает копию данного объекта <see cref="T:System.Drawing.Printing.PrinterSettings" />.</summary>
		/// <returns>Копия этого объекта.</returns>
		// Token: 0x06000B52 RID: 2898 RVA: 0x000197A8 File Offset: 0x000179A8
		public object Clone()
		{
			return new PrinterSettings(this.printing_services);
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Graphics" />, содержащий сведения о принтере, используемые при создании <see cref="T:System.Drawing.Printing.PrintDocument" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Graphics" />, содержащий сведения о принтере.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		// Token: 0x06000B53 RID: 2899 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.CreateMeasurementGraphics")]
		public Graphics CreateMeasurementGraphics()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Graphics" /> со сведениями о принтере, дополнительно указывая исходный объект на полях.</summary>
		/// <param name="honorOriginAtMargins">Значение <see langword="true" /> для указания исходного объекта на полях, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Graphics" />, содержащий сведения о принтере из <see cref="T:System.Drawing.Printing.PageSettings" />.</returns>
		// Token: 0x06000B54 RID: 2900 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.CreateMeasurementGraphics")]
		public Graphics CreateMeasurementGraphics(bool honorOriginAtMargins)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Graphics" />, содержащий сведения о принтере, связанные с указанным <see cref="T:System.Drawing.Printing.PageSettings" />.</summary>
		/// <param name="pageSettings">
		///   <see cref="T:System.Drawing.Printing.PageSettings" />, для которого требуется извлечь графический объект.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Graphics" />, содержащий сведения о принтере из <see cref="T:System.Drawing.Printing.PageSettings" />.</returns>
		// Token: 0x06000B55 RID: 2901 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.CreateMeasurementGraphics")]
		public Graphics CreateMeasurementGraphics(PageSettings pageSettings)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает <see cref="T:System.Drawing.Graphics" />, связанный с указанными параметрами страницы и дополнительно указывающий исходный объект на полях.</summary>
		/// <param name="pageSettings">
		///   <see cref="T:System.Drawing.Printing.PageSettings" />, для которого требуется извлечь объект <see cref="T:System.Drawing.Graphics" />.</param>
		/// <param name="honorOriginAtMargins">Значение <see langword="true" /> для указания исходного объекта на полях, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Graphics" />, содержащий сведения о принтере из <see cref="T:System.Drawing.Printing.PageSettings" />.</returns>
		// Token: 0x06000B56 RID: 2902 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.CreateMeasurementGraphics")]
		public Graphics CreateMeasurementGraphics(PageSettings pageSettings, bool honorOriginAtMargins)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает дескриптор структуры <see langword="DEVMODE" />, относящейся к параметрам принтера.</summary>
		/// <returns>Дескриптор для структуры <see langword="DEVMODE" />.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Невозможно загрузить информацию об инициализации принтера.</exception>
		// Token: 0x06000B57 RID: 2903 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.GetHdevmode")]
		public IntPtr GetHdevmode()
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает дескриптор структуры <see langword="DEVMODE" />, относящейся к параметрам принтера и страницы, заданным с помощью параметра <paramref name="pageSettings" />.</summary>
		/// <param name="pageSettings">Объект <see cref="T:System.Drawing.Printing.PageSettings" />, к которому относится дескриптор структуры <see langword="DEVMODE" />.</param>
		/// <returns>Дескриптор для структуры <see langword="DEVMODE" />.</returns>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Принтер, заданный свойством <see cref="P:System.Drawing.Printing.PrinterSettings.PrinterName" />, не существует.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Невозможно загрузить информацию об инициализации принтера.</exception>
		// Token: 0x06000B58 RID: 2904 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.GetHdevmode")]
		public IntPtr GetHdevmode(PageSettings pageSettings)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает дескриптор структуры <see langword="DEVNAMES" />, относящейся к параметрам принтера.</summary>
		/// <returns>Дескриптор для структуры <see langword="DEVNAMES" />.</returns>
		// Token: 0x06000B59 RID: 2905 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.GetHdevname")]
		public IntPtr GetHdevnames()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает значение, показывающее, поддерживает ли принтер печать указанного файла изображения.</summary>
		/// <param name="image">Изображение для печати.</param>
		/// <returns>Значение равно <see langword="true" />, если принтер поддерживает указанное изображение; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000B5A RID: 2906 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("IsDirectPrintingSupported")]
		public bool IsDirectPrintingSupported(Image image)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли принтер печать указанного формата изображения.</summary>
		/// <param name="imageFormat">
		///   <see cref="T:System.Drawing.Imaging.ImageFormat" /> для печати.</param>
		/// <returns>Значение равно <see langword="true" />, если принтер поддерживает указанный формат, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000B5B RID: 2907 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("IsDirectPrintingSupported")]
		public bool IsDirectPrintingSupported(ImageFormat imageFormat)
		{
			throw new NotImplementedException();
		}

		/// <summary>Копирует релевантную информацию из указанного дескриптора в <see cref="T:System.Drawing.Printing.PrinterSettings" />.</summary>
		/// <param name="hdevmode">Дескриптор Win32 структуры <see langword="DEVMODE" />.</param>
		/// <exception cref="T:System.ArgumentException">Недопустимый дескриптор принтера.</exception>
		// Token: 0x06000B5C RID: 2908 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.SetHdevmode")]
		public void SetHdevmode(IntPtr hdevmode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Копирует релевантную информацию из указанного дескриптора в <see cref="T:System.Drawing.Printing.PrinterSettings" />.</summary>
		/// <param name="hdevnames">Дескриптор Win32 структуры <see langword="DEVNAMES" />.</param>
		/// <exception cref="T:System.ArgumentException">Неправильный дескриптор принтера.</exception>
		// Token: 0x06000B5D RID: 2909 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("PrinterSettings.SetHdevnames")]
		public void SetHdevnames(IntPtr hdevnames)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет сведения о <see cref="T:System.Drawing.Printing.PrinterSettings" /> в форме строки.</summary>
		/// <returns>Строка.</returns>
		// Token: 0x06000B5E RID: 2910 RVA: 0x000197B8 File Offset: 0x000179B8
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Printer [PrinterSettings ",
				this.printer_name,
				" Copies=",
				this.copies.ToString(),
				" Collate=",
				this.collate.ToString(),
				" Duplex=",
				this.can_duplex.ToString(),
				" FromPage=",
				this.from_page.ToString(),
				" LandscapeAngle=",
				this.landscape_angle.ToString(),
				" MaximumCopies=",
				this.maximum_copies.ToString(),
				" OutputPort= ToPage=",
				this.to_page.ToString(),
				"]"
			});
		}

		// Token: 0x04000737 RID: 1847
		private string printer_name;

		// Token: 0x04000738 RID: 1848
		private string print_filename;

		// Token: 0x04000739 RID: 1849
		private short copies;

		// Token: 0x0400073A RID: 1850
		private int maximum_page;

		// Token: 0x0400073B RID: 1851
		private int minimum_page;

		// Token: 0x0400073C RID: 1852
		private int from_page;

		// Token: 0x0400073D RID: 1853
		private int to_page;

		// Token: 0x0400073E RID: 1854
		private bool collate;

		// Token: 0x0400073F RID: 1855
		private PrintRange print_range;

		// Token: 0x04000740 RID: 1856
		internal int maximum_copies;

		// Token: 0x04000741 RID: 1857
		internal bool can_duplex;

		// Token: 0x04000742 RID: 1858
		internal bool supports_color;

		// Token: 0x04000743 RID: 1859
		internal int landscape_angle;

		// Token: 0x04000744 RID: 1860
		private bool print_tofile;

		// Token: 0x04000745 RID: 1861
		internal PrinterSettings.PrinterResolutionCollection printer_resolutions;

		// Token: 0x04000746 RID: 1862
		internal PrinterSettings.PaperSizeCollection paper_sizes;

		// Token: 0x04000747 RID: 1863
		internal PrinterSettings.PaperSourceCollection paper_sources;

		// Token: 0x04000748 RID: 1864
		private PageSettings default_pagesettings;

		// Token: 0x04000749 RID: 1865
		private Duplex duplex;

		// Token: 0x0400074A RID: 1866
		internal bool is_plotter;

		// Token: 0x0400074B RID: 1867
		private PrintingServices printing_services;

		// Token: 0x0400074C RID: 1868
		internal NameValueCollection printer_capabilities;

		/// <summary>Содержит коллекцию объектов <see cref="T:System.Drawing.Printing.PaperSource" />.</summary>
		// Token: 0x020000D4 RID: 212
		public class PaperSourceCollection : ICollection, IEnumerable
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSourceCollection" />.</summary>
			/// <param name="array">Массив типа <see cref="T:System.Drawing.Printing.PaperSource" />.</param>
			// Token: 0x06000B5F RID: 2911 RVA: 0x0001988C File Offset: 0x00017A8C
			public PaperSourceCollection(PaperSource[] array)
			{
				foreach (PaperSource value in array)
				{
					this._PaperSources.Add(value);
				}
			}

			/// <summary>Получает число разных источников бумаги в коллекции.</summary>
			/// <returns>Число разных источников бумаги в коллекции.</returns>
			// Token: 0x1700031A RID: 794
			// (get) Token: 0x06000B60 RID: 2912 RVA: 0x000198CB File Offset: 0x00017ACB
			public int Count
			{
				get
				{
					return this._PaperSources.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.Count" />.</summary>
			// Token: 0x1700031B RID: 795
			// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000198CB File Offset: 0x00017ACB
			int ICollection.Count
			{
				get
				{
					return this._PaperSources.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
			// Token: 0x1700031C RID: 796
			// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0000C228 File Offset: 0x0000A428
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
			// Token: 0x1700031D RID: 797
			// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00002058 File Offset: 0x00000258
			object ICollection.SyncRoot
			{
				get
				{
					return this;
				}
			}

			/// <summary>Добавляет заданный <see cref="T:System.Drawing.Printing.PaperSource" /> в конец коллекции <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSourceCollection" />.</summary>
			/// <param name="paperSource">Параметр <see cref="T:System.Drawing.Printing.PaperSource" /> для добавления в коллекцию.</param>
			/// <returns>Индекс (индексация ведется от нуля), в который был добавлен <see cref="T:System.Drawing.Printing.PaperSource" />.</returns>
			// Token: 0x06000B64 RID: 2916 RVA: 0x000198D8 File Offset: 0x00017AD8
			[EditorBrowsable(EditorBrowsableState.Never)]
			public int Add(PaperSource paperSource)
			{
				return this._PaperSources.Add(paperSource);
			}

			/// <summary>Копирует содержимое текущего списка <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSourceCollection" /> в указанный массив, начиная с указанного индекса.</summary>
			/// <param name="paperSources">Отсчитываемый от нуля массив, получающий элементы, скопированные из <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSourceCollection" />.</param>
			/// <param name="index">Индекс, по которому следует запустить копирование элементов.</param>
			// Token: 0x06000B65 RID: 2917 RVA: 0x00009B6A File Offset: 0x00007D6A
			public void CopyTo(PaperSource[] paperSources, int index)
			{
				throw new NotImplementedException();
			}

			/// <summary>Получает <see cref="T:System.Drawing.Printing.PaperSource" /> по указанному индексу.</summary>
			/// <param name="index">Индекс извлекаемой строки <see cref="T:System.Drawing.Printing.PaperSource" />.</param>
			/// <returns>Параметр <see cref="T:System.Drawing.Printing.PaperSource" /> по указанному индексу.</returns>
			// Token: 0x1700031E RID: 798
			public virtual PaperSource this[int index]
			{
				get
				{
					return this._PaperSources[index] as PaperSource;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</summary>
			// Token: 0x06000B67 RID: 2919 RVA: 0x000198F9 File Offset: 0x00017AF9
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._PaperSources.GetEnumerator();
			}

			/// <summary>Возвращает перечислитель, который может выполнять итерации по коллекции.</summary>
			/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSourceCollection" />.</returns>
			// Token: 0x06000B68 RID: 2920 RVA: 0x000198F9 File Offset: 0x00017AF9
			public IEnumerator GetEnumerator()
			{
				return this._PaperSources.GetEnumerator();
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.ICollection.CopyTo(System.Array,System.Int32)" />.</summary>
			/// <param name="array">Массив с назначением для содержимого коллекции.</param>
			/// <param name="index">Начинающийся с нуля индекс, по которому следует запустить операцию копирования.</param>
			// Token: 0x06000B69 RID: 2921 RVA: 0x00019906 File Offset: 0x00017B06
			void ICollection.CopyTo(Array array, int index)
			{
				this._PaperSources.CopyTo(array, index);
			}

			// Token: 0x06000B6A RID: 2922 RVA: 0x00019915 File Offset: 0x00017B15
			internal void Clear()
			{
				this._PaperSources.Clear();
			}

			// Token: 0x0400074D RID: 1869
			private ArrayList _PaperSources = new ArrayList();
		}

		/// <summary>Содержит коллекцию объектов <see cref="T:System.Drawing.Printing.PaperSize" />.</summary>
		// Token: 0x020000D5 RID: 213
		public class PaperSizeCollection : ICollection, IEnumerable
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSizeCollection" />.</summary>
			/// <param name="array">Массив типа <see cref="T:System.Drawing.Printing.PaperSize" />.</param>
			// Token: 0x06000B6B RID: 2923 RVA: 0x00019924 File Offset: 0x00017B24
			public PaperSizeCollection(PaperSize[] array)
			{
				foreach (PaperSize value in array)
				{
					this._PaperSizes.Add(value);
				}
			}

			/// <summary>Получает число различающихся размеров бумаги в коллекции.</summary>
			/// <returns>Число разных размеров бумаги в коллекции.</returns>
			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00019963 File Offset: 0x00017B63
			public int Count
			{
				get
				{
					return this._PaperSizes.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.Count" />.</summary>
			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00019963 File Offset: 0x00017B63
			int ICollection.Count
			{
				get
				{
					return this._PaperSizes.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0000C228 File Offset: 0x0000A428
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00002058 File Offset: 0x00000258
			object ICollection.SyncRoot
			{
				get
				{
					return this;
				}
			}

			/// <summary>Добавляет <see cref="T:System.Drawing.Printing.PrinterResolution" /> в конец коллекции.</summary>
			/// <param name="paperSize">Параметр <see cref="T:System.Drawing.Printing.PaperSize" /> для добавления в коллекцию.</param>
			/// <returns>Отсчитываемый от нуля индекс вновь добавленного элемента.</returns>
			// Token: 0x06000B70 RID: 2928 RVA: 0x00019970 File Offset: 0x00017B70
			[EditorBrowsable(EditorBrowsableState.Never)]
			public int Add(PaperSize paperSize)
			{
				return this._PaperSizes.Add(paperSize);
			}

			/// <summary>Копирует содержимое текущего списка <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSizeCollection" /> в указанный массив, начиная с указанного индекса.</summary>
			/// <param name="paperSizes">Отсчитываемый от нуля массив, получающий элементы, скопированные из <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSizeCollection" />.</param>
			/// <param name="index">Индекс, по которому следует запустить копирование элементов.</param>
			// Token: 0x06000B71 RID: 2929 RVA: 0x00009B6A File Offset: 0x00007D6A
			public void CopyTo(PaperSize[] paperSizes, int index)
			{
				throw new NotImplementedException();
			}

			/// <summary>Получает <see cref="T:System.Drawing.Printing.PaperSize" /> по указанному индексу.</summary>
			/// <param name="index">Индекс извлекаемой строки <see cref="T:System.Drawing.Printing.PaperSize" />.</param>
			/// <returns>Параметр <see cref="T:System.Drawing.Printing.PaperSize" /> по указанному индексу.</returns>
			// Token: 0x17000323 RID: 803
			public virtual PaperSize this[int index]
			{
				get
				{
					return this._PaperSizes[index] as PaperSize;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</summary>
			/// <returns>Перечислитель, связанный с коллекцией.</returns>
			// Token: 0x06000B73 RID: 2931 RVA: 0x00019991 File Offset: 0x00017B91
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._PaperSizes.GetEnumerator();
			}

			/// <summary>Возвращает перечислитель, который может выполнять итерации по коллекции.</summary>
			/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Drawing.Printing.PrinterSettings.PaperSizeCollection" />.</returns>
			// Token: 0x06000B74 RID: 2932 RVA: 0x00019991 File Offset: 0x00017B91
			public IEnumerator GetEnumerator()
			{
				return this._PaperSizes.GetEnumerator();
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.ICollection.CopyTo(System.Array,System.Int32)" />.</summary>
			/// <param name="array">Отсчитываемый от нуля массив, получающий элементы, скопированные из коллекции.</param>
			/// <param name="index">Индекс, по которому следует запустить копирование элементов.</param>
			// Token: 0x06000B75 RID: 2933 RVA: 0x0001999E File Offset: 0x00017B9E
			void ICollection.CopyTo(Array array, int index)
			{
				this._PaperSizes.CopyTo(array, index);
			}

			// Token: 0x06000B76 RID: 2934 RVA: 0x000199AD File Offset: 0x00017BAD
			internal void Clear()
			{
				this._PaperSizes.Clear();
			}

			// Token: 0x0400074E RID: 1870
			private ArrayList _PaperSizes = new ArrayList();
		}

		/// <summary>Содержит коллекцию объектов <see cref="T:System.Drawing.Printing.PrinterResolution" />.</summary>
		// Token: 0x020000D6 RID: 214
		public class PrinterResolutionCollection : ICollection, IEnumerable
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrinterSettings.PrinterResolutionCollection" />.</summary>
			/// <param name="array">Массив типа <see cref="T:System.Drawing.Printing.PrinterResolution" />.</param>
			// Token: 0x06000B77 RID: 2935 RVA: 0x000199BC File Offset: 0x00017BBC
			public PrinterResolutionCollection(PrinterResolution[] array)
			{
				foreach (PrinterResolution value in array)
				{
					this._PrinterResolutions.Add(value);
				}
			}

			/// <summary>Получает число доступных разрешений принтера в этой коллекции.</summary>
			/// <returns>Число доступных разрешений принтера в этой коллекции.</returns>
			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06000B78 RID: 2936 RVA: 0x000199FB File Offset: 0x00017BFB
			public int Count
			{
				get
				{
					return this._PrinterResolutions.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.Count" />.</summary>
			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06000B79 RID: 2937 RVA: 0x000199FB File Offset: 0x00017BFB
			int ICollection.Count
			{
				get
				{
					return this._PrinterResolutions.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0000C228 File Offset: 0x0000A428
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00002058 File Offset: 0x00000258
			object ICollection.SyncRoot
			{
				get
				{
					return this;
				}
			}

			/// <summary>Добавляет <see cref="T:System.Drawing.Printing.PrinterResolution" /> в конец коллекции.</summary>
			/// <param name="printerResolution">Параметр <see cref="T:System.Drawing.Printing.PrinterResolution" /> для добавления в коллекцию.</param>
			/// <returns>Отсчитываемый от нуля индекс вновь добавленного элемента.</returns>
			// Token: 0x06000B7C RID: 2940 RVA: 0x00019A08 File Offset: 0x00017C08
			[EditorBrowsable(EditorBrowsableState.Never)]
			public int Add(PrinterResolution printerResolution)
			{
				return this._PrinterResolutions.Add(printerResolution);
			}

			/// <summary>Копирует содержимое текущего списка <see cref="T:System.Drawing.Printing.PrinterSettings.PrinterResolutionCollection" /> в указанный массив, начиная с указанного индекса.</summary>
			/// <param name="printerResolutions">Отсчитываемый от нуля массив, получающий элементы, скопированные из <see cref="T:System.Drawing.Printing.PrinterSettings.PrinterResolutionCollection" />.</param>
			/// <param name="index">Индекс, по которому следует запустить копирование элементов.</param>
			// Token: 0x06000B7D RID: 2941 RVA: 0x00009B6A File Offset: 0x00007D6A
			public void CopyTo(PrinterResolution[] printerResolutions, int index)
			{
				throw new NotImplementedException();
			}

			/// <summary>Получает <see cref="T:System.Drawing.Printing.PrinterResolution" /> по указанному индексу.</summary>
			/// <param name="index">Индекс извлекаемой строки <see cref="T:System.Drawing.Printing.PrinterResolution" />.</param>
			/// <returns>Параметр <see cref="T:System.Drawing.Printing.PrinterResolution" /> по указанному индексу.</returns>
			// Token: 0x17000328 RID: 808
			public virtual PrinterResolution this[int index]
			{
				get
				{
					return this._PrinterResolutions[index] as PrinterResolution;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</summary>
			// Token: 0x06000B7F RID: 2943 RVA: 0x00019A29 File Offset: 0x00017C29
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._PrinterResolutions.GetEnumerator();
			}

			/// <summary>Возвращает перечислитель, который может выполнять итерации по коллекции.</summary>
			/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Drawing.Printing.PrinterSettings.PrinterResolutionCollection" />.</returns>
			// Token: 0x06000B80 RID: 2944 RVA: 0x00019A29 File Offset: 0x00017C29
			public IEnumerator GetEnumerator()
			{
				return this._PrinterResolutions.GetEnumerator();
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.ICollection.CopyTo(System.Array,System.Int32)" />.</summary>
			/// <param name="array">Массив назначения.</param>
			/// <param name="index">Начинающийся с нуля индекс, по которому следует запустить операцию копирования.</param>
			// Token: 0x06000B81 RID: 2945 RVA: 0x00019A36 File Offset: 0x00017C36
			void ICollection.CopyTo(Array array, int index)
			{
				this._PrinterResolutions.CopyTo(array, index);
			}

			// Token: 0x06000B82 RID: 2946 RVA: 0x00019A45 File Offset: 0x00017C45
			internal void Clear()
			{
				this._PrinterResolutions.Clear();
			}

			// Token: 0x0400074F RID: 1871
			private ArrayList _PrinterResolutions = new ArrayList();
		}

		/// <summary>Содержит коллекцию объектов <see cref="T:System.String" />.</summary>
		// Token: 0x020000D7 RID: 215
		public class StringCollection : ICollection, IEnumerable
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PrinterSettings.StringCollection" />.</summary>
			/// <param name="array">Массив типа <see cref="T:System.String" />.</param>
			// Token: 0x06000B83 RID: 2947 RVA: 0x00019A54 File Offset: 0x00017C54
			public StringCollection(string[] array)
			{
				foreach (string value in array)
				{
					this._Strings.Add(value);
				}
			}

			/// <summary>Получает число строк в коллекции.</summary>
			/// <returns>Число строк в коллекции.</returns>
			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00019A93 File Offset: 0x00017C93
			public int Count
			{
				get
				{
					return this._Strings.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.Count" />.</summary>
			// Token: 0x1700032A RID: 810
			// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00019A93 File Offset: 0x00017C93
			int ICollection.Count
			{
				get
				{
					return this._Strings.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
			// Token: 0x1700032B RID: 811
			// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0000C228 File Offset: 0x0000A428
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
			// Token: 0x1700032C RID: 812
			// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00002058 File Offset: 0x00000258
			object ICollection.SyncRoot
			{
				get
				{
					return this;
				}
			}

			/// <summary>Получает <see cref="T:System.String" /> по указанному индексу.</summary>
			/// <param name="index">Индекс извлекаемой строки <see cref="T:System.String" />.</param>
			/// <returns>Параметр <see cref="T:System.String" /> по указанному индексу.</returns>
			// Token: 0x1700032D RID: 813
			public virtual string this[int index]
			{
				get
				{
					return this._Strings[index] as string;
				}
			}

			/// <summary>Добавляет строку в конец коллекции.</summary>
			/// <param name="value">Строка, добавляемая к коллекции.</param>
			/// <returns>Отсчитываемый от нуля индекс вновь добавленного элемента.</returns>
			// Token: 0x06000B89 RID: 2953 RVA: 0x00019AB3 File Offset: 0x00017CB3
			[EditorBrowsable(EditorBrowsableState.Never)]
			public int Add(string value)
			{
				return this._Strings.Add(value);
			}

			/// <summary>Копирует содержимое текущего списка <see cref="T:System.Drawing.Printing.PrinterSettings.PrinterResolutionCollection" /> в указанную позицию массива, начиная с указанного индекса.</summary>
			/// <param name="strings">Отсчитываемый от нуля массив, получающий элементы, скопированные из <see cref="T:System.Drawing.Printing.PrinterSettings.StringCollection" />.</param>
			/// <param name="index">Индекс, по которому следует запустить копирование элементов.</param>
			// Token: 0x06000B8A RID: 2954 RVA: 0x00009B6A File Offset: 0x00007D6A
			public void CopyTo(string[] strings, int index)
			{
				throw new NotImplementedException();
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</summary>
			// Token: 0x06000B8B RID: 2955 RVA: 0x00019AC1 File Offset: 0x00017CC1
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._Strings.GetEnumerator();
			}

			/// <summary>Возвращает перечислитель, который может выполнять итерации по коллекции.</summary>
			/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Drawing.Printing.PrinterSettings.StringCollection" />.</returns>
			// Token: 0x06000B8C RID: 2956 RVA: 0x00019AC1 File Offset: 0x00017CC1
			public IEnumerator GetEnumerator()
			{
				return this._Strings.GetEnumerator();
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.ICollection.CopyTo(System.Array,System.Int32)" />.</summary>
			/// <param name="array">Массив, в который следует копировать элементы.</param>
			/// <param name="index">Начальный индекс.</param>
			// Token: 0x06000B8D RID: 2957 RVA: 0x00019ACE File Offset: 0x00017CCE
			void ICollection.CopyTo(Array array, int index)
			{
				this._Strings.CopyTo(array, index);
			}

			// Token: 0x04000750 RID: 1872
			private ArrayList _Strings = new ArrayList();
		}
	}
}
