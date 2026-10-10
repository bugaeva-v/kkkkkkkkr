using System;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, который обрабатывает событие <see cref="E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged" />, возникающее при изменении свойства компонента.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.PropertyChangedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000404 RID: 1028
	// (Invoke) Token: 0x0600214C RID: 8524
	public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);
}
