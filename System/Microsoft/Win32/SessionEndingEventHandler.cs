using System;

namespace Microsoft.Win32
{
	/// <summary>Представляет метод обработки события <see cref="E:Microsoft.Win32.SystemEvents.SessionEnding" /> из операционной системы.</summary>
	/// <param name="sender">Источник события. Когда это событие вызывается классом <see cref="T:Microsoft.Win32.SystemEvents" />, данный объект всегда равен <see langword="null" />.</param>
	/// <param name="e">Объект <see cref="T:Microsoft.Win32.SessionEndingEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000126 RID: 294
	// (Invoke) Token: 0x060006D6 RID: 1750
	public delegate void SessionEndingEventHandler(object sender, SessionEndingEventArgs e);
}
