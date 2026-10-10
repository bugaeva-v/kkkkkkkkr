using System;

namespace System.Net.WebSockets
{
	/// <summary>Указывает тип сообщения.</summary>
	// Token: 0x020007F2 RID: 2034
	public enum WebSocketMessageType
	{
		/// <summary>Сообщение является открытым текстом.</summary>
		// Token: 0x0400274D RID: 10061
		Text,
		/// <summary>Сообщение имеет двоичный формат.</summary>
		// Token: 0x0400274E RID: 10062
		Binary,
		/// <summary>Инструкция receive завершена, поскольку было получено сообщение закрытия.</summary>
		// Token: 0x0400274F RID: 10063
		Close
	}
}
