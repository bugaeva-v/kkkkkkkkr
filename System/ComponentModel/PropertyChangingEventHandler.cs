using System;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, который будет обрабатывать событие <see cref="E:System.ComponentModel.INotifyPropertyChanging.PropertyChanging" /> интерфейса <see cref="T:System.ComponentModel.INotifyPropertyChanging" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.PropertyChangingEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000406 RID: 1030
	// (Invoke) Token: 0x06002152 RID: 8530
	public delegate void PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e);
}
