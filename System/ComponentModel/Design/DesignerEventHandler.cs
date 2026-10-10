using System;

namespace System.ComponentModel.Design
{
	/// <summary>Представляет метод, обрабатывающий события <see cref="E:System.ComponentModel.Design.IDesignerEventService.DesignerCreated" /> и <see cref="E:System.ComponentModel.Design.IDesignerEventService.DesignerDisposed" />, вызываемые при создании или уничтожении документа.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.Design.DesignerEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000452 RID: 1106
	// (Invoke) Token: 0x060023F1 RID: 9201
	public delegate void DesignerEventHandler(object sender, DesignerEventArgs e);
}
