using System;

namespace System
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.AppDomain.AssemblyLoad" /> класса <see cref="T:System.AppDomain" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="args">Объект класса <see cref="T:System.AssemblyLoadEventArgs" />, содержащий данные события.</param>
	// Token: 0x020000FB RID: 251
	// (Invoke) Token: 0x0600074A RID: 1866
	[Serializable]
	public delegate void AssemblyLoadEventHandler(object sender, AssemblyLoadEventArgs args);
}
