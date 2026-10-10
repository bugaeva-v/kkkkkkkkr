using System;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.ComponentModel.TypeDescriptor.Refreshed" />, возникающее при изменении типа <see cref="T:System.Type" /> или компонента во время разработки.</summary>
	/// <param name="e">Класс <see cref="T:System.ComponentModel.RefreshEventArgs" />, содержащий измененный компонент или тип <see cref="T:System.Type" />.</param>
	// Token: 0x020003E8 RID: 1000
	// (Invoke) Token: 0x060020CE RID: 8398
	public delegate void RefreshEventHandler(RefreshEventArgs e);
}
