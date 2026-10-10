using System;

namespace System.Net.Sockets
{
	/// <summary>Определяет режимы опроса для метода <see cref="M:System.Net.Sockets.Socket.Poll(System.Int32,System.Net.Sockets.SelectMode)" />.</summary>
	// Token: 0x020007AE RID: 1966
	public enum SelectMode
	{
		/// <summary>Режим состояния чтения.</summary>
		// Token: 0x0400251D RID: 9501
		SelectRead,
		/// <summary>Режим состояния записи.</summary>
		// Token: 0x0400251E RID: 9502
		SelectWrite,
		/// <summary>Режим состояния ошибки.</summary>
		// Token: 0x0400251F RID: 9503
		SelectError
	}
}
