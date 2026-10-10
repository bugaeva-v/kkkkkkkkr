using System;

namespace System.ComponentModel.Design
{
	/// <summary>Представляет метод, обрабатывающий события конструктора <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosed" /> и <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosing" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.Design.DesignerTransactionCloseEventArgs" />, содержащий данные события.</param>
	// Token: 0x0200044A RID: 1098
	// (Invoke) Token: 0x060023BE RID: 9150
	public delegate void DesignerTransactionCloseEventHandler(object sender, DesignerTransactionCloseEventArgs e);
}
