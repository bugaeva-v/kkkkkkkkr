using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения о подключениях TCP на локальном компьютере.</summary>
	// Token: 0x02000705 RID: 1797
	public abstract class TcpConnectionInformation
	{
		/// <summary>Возвращает локальную конечную точку подключения TCP.</summary>
		/// <returns>Экземпляр <see cref="T:System.Net.IPEndPoint" />, содержащий IP-адрес и порт локального компьютера.</returns>
		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06003998 RID: 14744
		public abstract IPEndPoint LocalEndPoint { get; }

		/// <summary>Возвращает удаленную конечную точку подключения TCP.</summary>
		/// <returns>Экземпляр <see cref="T:System.Net.IPEndPoint" />, содержащий IP-адрес и порт удаленного компьютера.</returns>
		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06003999 RID: 14745
		public abstract IPEndPoint RemoteEndPoint { get; }

		/// <summary>Возвращает состояние этого подключения TCP.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.NetworkInformation.TcpState" />.</returns>
		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600399A RID: 14746
		public abstract TcpState State { get; }
	}
}
