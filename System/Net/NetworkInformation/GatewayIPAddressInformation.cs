using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Представляет IP-адрес сетевого шлюза. Для этого класса невозможно создание экземпляров.</summary>
	// Token: 0x020006DD RID: 1757
	public abstract class GatewayIPAddressInformation
	{
		/// <summary>Получает IP-адрес шлюза.</summary>
		/// <returns>Объект <see cref="T:System.Net.IPAddress" />, содержащий IP-адрес шлюза.</returns>
		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600385E RID: 14430
		public abstract IPAddress Address { get; }
	}
}
