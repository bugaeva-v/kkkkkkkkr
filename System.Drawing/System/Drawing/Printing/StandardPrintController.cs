using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает контроллер печати, отправляющий данные на принтер.</summary>
	// Token: 0x020000F1 RID: 241
	public class StandardPrintController : PrintController
	{
		/// <summary>Завершает набор команд управления, определяющих время и способ вывода страницы документа на печать.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий напечатанный документ.</param>
		/// <param name="e">Класс <see cref="T:System.Drawing.Printing.PrintPageEventArgs" />, содержащий сведения о способе печати страницы документа.</param>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Запись на страницу не может быть закончена машинным интерфейсом Win32 API.</exception>
		// Token: 0x06000BFC RID: 3068 RVA: 0x0001BA77 File Offset: 0x00019C77
		public override void OnEndPage(PrintDocument document, PrintPageEventArgs e)
		{
			SysPrn.GlobalService.EndPage(e.GraphicsContext);
		}

		/// <summary>Начинает набор команд управления, определяющих время и способ вывода документа на печать.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий напечатанный документ.</param>
		/// <param name="e">Класс <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий сведения о печати документа.</param>
		/// <exception cref="T:System.Drawing.Printing.InvalidPrinterException">Недопустимые параметры принтера.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Задание для принтера не может быть начато машинным интерфейсом Win32 API.</exception>
		// Token: 0x06000BFD RID: 3069 RVA: 0x0001BA8C File Offset: 0x00019C8C
		public override void OnStartPrint(PrintDocument document, PrintEventArgs e)
		{
			IntPtr dc = SysPrn.GlobalService.CreateGraphicsContext(document.PrinterSettings, document.DefaultPageSettings);
			e.GraphicsContext = new GraphicsPrinter(null, dc);
			SysPrn.GlobalService.StartDoc(e.GraphicsContext, document.DocumentName, string.Empty);
		}

		/// <summary>Завершает набор команд управления, определяющих время и способ вывода документа на печать.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий напечатанный документ.</param>
		/// <param name="e">Класс <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий сведения о печати документа.</param>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Задание для принтера не может быть завершено машинным интерфейсом Win32 API.  
		///
		/// или - 
		/// Машинный интерфейс Win32 API не может удалить указанный контекст устройства (DC).</exception>
		// Token: 0x06000BFE RID: 3070 RVA: 0x0001BAD9 File Offset: 0x00019CD9
		public override void OnEndPrint(PrintDocument document, PrintEventArgs e)
		{
			SysPrn.GlobalService.EndDoc(e.GraphicsContext);
		}

		/// <summary>Начинает набор команд управления, определяющих время и способ вывода на печать страницы документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий напечатанный документ.</param>
		/// <param name="e">Класс <see cref="T:System.Drawing.Printing.PrintPageEventArgs" />, содержащий сведения о способе печати страницы документа. Сначала свойство <see cref="P:System.Drawing.Printing.PrintPageEventArgs.Graphics" /> этого параметра равно <see langword="null" />. Свойству присваивается значение, возвращенное методом <see cref="M:System.Drawing.Printing.StandardPrintController.OnStartPage(System.Drawing.Printing.PrintDocument,System.Drawing.Printing.PrintPageEventArgs)" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Graphics" />, представляющий страницу из <see cref="T:System.Drawing.Printing.PrintDocument" />.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Драйвер принтера не может быть подготовлен машинным интерфейсом Win32 API к приему данных.  
		/// -или- 
		/// машинный интерфейс Win32 API не может обновить контекст устройства (DC) для принтера или плоттера, используя указанные данные.</exception>
		// Token: 0x06000BFF RID: 3071 RVA: 0x0001BAEC File Offset: 0x00019CEC
		public override Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e)
		{
			SysPrn.GlobalService.StartPage(e.GraphicsContext);
			return e.Graphics;
		}
	}
}
