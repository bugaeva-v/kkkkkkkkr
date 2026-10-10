using System;

namespace System.Net.WebSockets
{
	/// <summary>Содержит список возможных ошибок WebSocket.</summary>
	// Token: 0x020007F0 RID: 2032
	public enum WebSocketError
	{
		/// <summary>Указывает, что для исключения не было никаких собственных сведений об ошибке.</summary>
		// Token: 0x04002741 RID: 10049
		Success,
		/// <summary>Указывает, что был получен кадр WebSocket с неизвестным кодом операции.</summary>
		// Token: 0x04002742 RID: 10050
		InvalidMessageType,
		/// <summary>Указывает на общую ошибку.</summary>
		// Token: 0x04002743 RID: 10051
		Faulted,
		/// <summary>Указывает, что произошла неизвестная собственная ошибка.</summary>
		// Token: 0x04002744 RID: 10052
		NativeError,
		/// <summary>Указывает, что входящий запрос не был допустимым запросом WebSocket.</summary>
		// Token: 0x04002745 RID: 10053
		NotAWebSocket,
		/// <summary>Указывает, что клиент запросил неподдерживаемую версию протокола WebSocket.</summary>
		// Token: 0x04002746 RID: 10054
		UnsupportedVersion,
		/// <summary>Указывает, что клиент запросил неподдерживаемую версию подпротокола WebSocket.</summary>
		// Token: 0x04002747 RID: 10055
		UnsupportedProtocol,
		/// <summary>Указывает, что произошла ошибка при анализе заголовков HTTP во время подтверждения открытия.</summary>
		// Token: 0x04002748 RID: 10056
		HeaderError,
		/// <summary>Указывает, что подключение было неожиданно прервано.</summary>
		// Token: 0x04002749 RID: 10057
		ConnectionClosedPrematurely,
		/// <summary>Указывает, что WebSocket находится в недопустимом состоянии для заданной операции (например, закрывается или прерывается).</summary>
		// Token: 0x0400274A RID: 10058
		InvalidState
	}
}
