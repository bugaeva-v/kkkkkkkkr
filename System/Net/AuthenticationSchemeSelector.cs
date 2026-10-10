using System;

namespace System.Net
{
	/// <summary>Выбирает схему проверки подлинности для экземпляра <see cref="T:System.Net.HttpListener" />.</summary>
	/// <param name="httpRequest">Экземпляр <see cref="T:System.Net.HttpListenerRequest" />, для которого следует выбрать схему проверки подлинности.</param>
	/// <returns>Одно из значений <see cref="T:System.Net.AuthenticationSchemes" />, указывающее метод проверки подлинности, который будет использоваться с определенным клиентским запросом.</returns>
	// Token: 0x020005C3 RID: 1475
	// (Invoke) Token: 0x06002FD3 RID: 12243
	public delegate AuthenticationSchemes AuthenticationSchemeSelector(HttpListenerRequest httpRequest);
}
