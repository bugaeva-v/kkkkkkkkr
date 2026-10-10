using System;

namespace System.Net.Sockets
{
	/// <summary>Определяет уровни параметров сокета для методов <see cref="M:System.Net.Sockets.Socket.SetSocketOption(System.Net.Sockets.SocketOptionLevel,System.Net.Sockets.SocketOptionName,System.Int32)" /> и <see cref="M:System.Net.Sockets.Socket.GetSocketOption(System.Net.Sockets.SocketOptionLevel,System.Net.Sockets.SocketOptionName)" />.</summary>
	// Token: 0x020007B6 RID: 1974
	public enum SocketOptionLevel
	{
		/// <summary>Параметры <see cref="T:System.Net.Sockets.Socket" /> применяются для всех сокетов.</summary>
		// Token: 0x04002577 RID: 9591
		Socket = 65535,
		/// <summary>Параметры <see cref="T:System.Net.Sockets.Socket" /> применяются только для IP-сокетов.</summary>
		// Token: 0x04002578 RID: 9592
		IP = 0,
		/// <summary>Параметры <see cref="T:System.Net.Sockets.Socket" /> применяются только для IPv6-сокетов.</summary>
		// Token: 0x04002579 RID: 9593
		IPv6 = 41,
		/// <summary>Параметры <see cref="T:System.Net.Sockets.Socket" /> применяются только для TCP-сокетов.</summary>
		// Token: 0x0400257A RID: 9594
		Tcp = 6,
		/// <summary>Параметры <see cref="T:System.Net.Sockets.Socket" /> применяются только для UDP-сокетов.</summary>
		// Token: 0x0400257B RID: 9595
		Udp = 17
	}
}
