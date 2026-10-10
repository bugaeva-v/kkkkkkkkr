using System;

namespace System.Net.Sockets
{
	/// <summary>Описывает состояния для объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x020007B5 RID: 1973
	[Flags]
	public enum SocketInformationOptions
	{
		/// <summary>Объект <see cref="T:System.Net.Sockets.Socket" /> является неблокирующим.</summary>
		// Token: 0x04002572 RID: 9586
		NonBlocking = 1,
		/// <summary>Объект <see cref="T:System.Net.Sockets.Socket" /> подключен.</summary>
		// Token: 0x04002573 RID: 9587
		Connected = 2,
		/// <summary>Объект <see cref="T:System.Net.Sockets.Socket" /> ожидает новые подключения.</summary>
		// Token: 0x04002574 RID: 9588
		Listening = 4,
		/// <summary>Объект <see cref="T:System.Net.Sockets.Socket" /> использует перекрывающиеся операции ввода-вывода.</summary>
		// Token: 0x04002575 RID: 9589
		UseOnlyOverlappedIO = 8
	}
}
