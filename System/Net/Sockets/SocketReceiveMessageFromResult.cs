using System;

namespace System.Net.Sockets
{
	/// <summary>Результат операции <see cref="M:System.Net.Sockets.SocketTaskExtensions.ReceiveMessageFromAsync(System.Net.Sockets.Socket,System.ArraySegment{System.Byte},System.Net.Sockets.SocketFlags,System.Net.EndPoint)" />.</summary>
	// Token: 0x020007C6 RID: 1990
	public struct SocketReceiveMessageFromResult
	{
		/// <summary>Количество полученных байтов. Если операция <see cref="M:System.Net.Sockets.SocketTaskExtensions.ReceiveMessageFromAsync(System.Net.Sockets.Socket,System.ArraySegment{System.Byte},System.Net.Sockets.SocketFlags,System.Net.EndPoint)" /> завершается неудачно, это значение будет равно 0.</summary>
		// Token: 0x04002615 RID: 9749
		public int ReceivedBytes;

		/// <summary>Поразрядное сочетание значений перечисления <see cref="T:System.Net.Sockets.SocketFlags" /> для принятого пакета.</summary>
		// Token: 0x04002616 RID: 9750
		public SocketFlags SocketFlags;

		/// <summary>Источник <see cref="T:System.Net.EndPoint" />.</summary>
		// Token: 0x04002617 RID: 9751
		public EndPoint RemoteEndPoint;

		/// <summary>
		///   <see cref="T:System.Net.Sockets.IPPacketInformation" /> сохраняет адрес и сведения об интерфейсе.</summary>
		// Token: 0x04002618 RID: 9752
		public IPPacketInformation PacketInformation;
	}
}
