using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Ссылается на один или несколько методов, вызываемых при изменении доступности сети.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.EventArgs" />, который содержит данные о событии.</param>
	// Token: 0x020006F3 RID: 1779
	// (Invoke) Token: 0x06003940 RID: 14656
	public delegate void NetworkAvailabilityChangedEventHandler(object sender, NetworkAvailabilityEventArgs e);
}
