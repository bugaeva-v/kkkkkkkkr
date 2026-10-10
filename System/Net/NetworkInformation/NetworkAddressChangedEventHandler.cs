using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Ссылается на один или несколько методов, вызываемых при изменении адреса сетевого интерфейса.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.EventArgs" />, который содержит данные о событии.</param>
	// Token: 0x020006F2 RID: 1778
	// (Invoke) Token: 0x0600393C RID: 14652
	public delegate void NetworkAddressChangedEventHandler(object sender, EventArgs e);
}
