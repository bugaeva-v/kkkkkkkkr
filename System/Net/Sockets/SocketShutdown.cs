using System;

namespace System.Net.Sockets
{
	/// <summary>Определяет константы, используемые методом <see cref="M:System.Net.Sockets.Socket.Shutdown(System.Net.Sockets.SocketShutdown)" />.</summary>
	// Token: 0x020007B8 RID: 1976
	public enum SocketShutdown
	{
		/// <summary>Отключает объект <see cref="T:System.Net.Sockets.Socket" /> от приема. Это поле является константой.</summary>
		// Token: 0x040025AC RID: 9644
		Receive,
		/// <summary>Отключает объект <see cref="T:System.Net.Sockets.Socket" /> от передачи. Это поле является константой.</summary>
		// Token: 0x040025AD RID: 9645
		Send,
		/// <summary>Отключает объект <see cref="T:System.Net.Sockets.Socket" /> как от приема, так и от передачи. Это поле является константой.</summary>
		// Token: 0x040025AE RID: 9646
		Both
	}
}
