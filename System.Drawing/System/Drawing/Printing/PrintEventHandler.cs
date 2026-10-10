using System;

namespace System.Drawing.Printing
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Drawing.Printing.PrintDocument.BeginPrint" /> или событие <see cref="E:System.Drawing.Printing.PrintDocument.EndPrint" /> из <see cref="T:System.Drawing.Printing.PrintDocument" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Drawing.Printing.PrintEventArgs" />, содержащий данные события.</param>
	// Token: 0x020000C0 RID: 192
	// (Invoke) Token: 0x06000AA5 RID: 2725
	public delegate void PrintEventHandler(object sender, PrintEventArgs e);
}
