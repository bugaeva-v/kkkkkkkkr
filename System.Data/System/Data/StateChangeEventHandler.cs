using System;

namespace System.Data
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.Common.DbConnection.StateChange" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.Data.StateChangeEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x02000132 RID: 306
	// (Invoke) Token: 0x060010A6 RID: 4262
	public delegate void StateChangeEventHandler(object sender, StateChangeEventArgs e);
}
