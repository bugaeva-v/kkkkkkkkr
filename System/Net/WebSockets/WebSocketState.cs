using System;

namespace System.Net.WebSockets
{
	/// <summary>Определяет разные состояния, в которых может находиться экземпляр WebSockets.</summary>
	// Token: 0x020007F4 RID: 2036
	public enum WebSocketState
	{
		/// <summary>Зарезервировано для будущего использования.</summary>
		// Token: 0x04002756 RID: 10070
		None,
		/// <summary>Соединение согласует подтверждение с удаленной конечной точкой.</summary>
		// Token: 0x04002757 RID: 10071
		Connecting,
		/// <summary>Начальное состояние после завершения подтверждения HTTP.</summary>
		// Token: 0x04002758 RID: 10072
		Open,
		/// <summary>Сообщение закрытия было отправлено в удаленную конечную точку.</summary>
		// Token: 0x04002759 RID: 10073
		CloseSent,
		/// <summary>Сообщение закрытия было получено из удаленной конечной точки.</summary>
		// Token: 0x0400275A RID: 10074
		CloseReceived,
		/// <summary>Указывает, что подтверждение закрытия WebSocket выполнено корректно.</summary>
		// Token: 0x0400275B RID: 10075
		Closed,
		/// <summary>Зарезервировано для будущего использования.</summary>
		// Token: 0x0400275C RID: 10076
		Aborted
	}
}
