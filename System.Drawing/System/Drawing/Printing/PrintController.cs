using System;

namespace System.Drawing.Printing
{
	/// <summary>Управляет способами печати документов при осуществлении печати из приложения Windows Forms.</summary>
	// Token: 0x020000CF RID: 207
	public abstract class PrintController
	{
		/// <summary>Получает значение, показывающее, используется ли объект <see cref="T:System.Drawing.Printing.PrintController" /> для предварительного просмотра печати.</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0000C228 File Offset: 0x0000A428
		public virtual bool IsPreview
		{
			get
			{
				return false;
			}
		}

		/// <summary>При переопределении в производный класс завершает набор команд управления, определяющих время и способ печати страницы документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий печатаемый документ.</param>
		/// <param name="e">Объект <see cref="T:System.Drawing.Printing.PrintPageEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000AFD RID: 2813 RVA: 0x000049FE File Offset: 0x00002BFE
		public virtual void OnEndPage(PrintDocument document, PrintPageEventArgs e)
		{
		}

		/// <summary>При переопределении в производный класс начинает набор команд управления, определяющих время и способ печати документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий печатаемый документ.</param>
		/// <param name="e">Объект <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000AFE RID: 2814 RVA: 0x000049FE File Offset: 0x00002BFE
		public virtual void OnStartPrint(PrintDocument document, PrintEventArgs e)
		{
		}

		/// <summary>При переопределении в производный класс завершает набор команд управления, определяющих время и способ печати документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий печатаемый документ.</param>
		/// <param name="e">Объект <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000AFF RID: 2815 RVA: 0x000049FE File Offset: 0x00002BFE
		public virtual void OnEndPrint(PrintDocument document, PrintEventArgs e)
		{
		}

		/// <summary>При переопределении в производный класс, начинает набор команд управления, определяющих способ и очередность действий при печати страницы документа.</summary>
		/// <param name="document">Класс <see cref="T:System.Drawing.Printing.PrintDocument" />, представляющий печатаемый документ.</param>
		/// <param name="e">Объект <see cref="T:System.Drawing.Printing.PrintPageEventArgs" />, содержащий данные события.</param>
		/// <returns>Класс <see cref="T:System.Drawing.Graphics" />, представляющий страницу из <see cref="T:System.Drawing.Printing.PrintDocument" />.</returns>
		// Token: 0x06000B00 RID: 2816 RVA: 0x00018785 File Offset: 0x00016985
		public virtual Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e)
		{
			return null;
		}
	}
}
