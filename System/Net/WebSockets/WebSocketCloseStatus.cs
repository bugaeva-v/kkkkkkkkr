using System;

namespace System.Net.WebSockets
{
	/// <summary>Представляет известные коды закрытия WebSocket, как определено в разделе 11.7 спецификации протокола WebSocket.</summary>
	// Token: 0x020007EE RID: 2030
	public enum WebSocketCloseStatus
	{
		/// <summary>(1000) Соединение закрыто после выполнения запроса.</summary>
		// Token: 0x04002736 RID: 10038
		NormalClosure = 1000,
		/// <summary>(1001) Указывает удаляемую конечную точку. Клиент или сервер станет недоступным.</summary>
		// Token: 0x04002737 RID: 10039
		EndpointUnavailable,
		/// <summary>(1002) Клиент или сервер завершает соединение из-за ошибки протокола.</summary>
		// Token: 0x04002738 RID: 10040
		ProtocolError,
		/// <summary>(1003) Клиент или сервер завершает соединение, так как не может принять полученный тип данных.</summary>
		// Token: 0x04002739 RID: 10041
		InvalidMessageType,
		/// <summary>Нет указанных ошибок.</summary>
		// Token: 0x0400273A RID: 10042
		Empty = 1005,
		/// <summary>(1007) Клиент или сервер завершает соединение, так как получены данные, несовместимые с типом сообщения.</summary>
		// Token: 0x0400273B RID: 10043
		InvalidPayloadData = 1007,
		/// <summary>(1008) Подключение будет закрыто, так как конечная точка получила сообщение, нарушающее ее политику.</summary>
		// Token: 0x0400273C RID: 10044
		PolicyViolation,
		/// <summary>(1004) Зарезервировано для будущего использования.</summary>
		// Token: 0x0400273D RID: 10045
		MessageTooBig,
		/// <summary>(1010) Клиент завершает соединение, так как ожидал согласование расширения сервером.</summary>
		// Token: 0x0400273E RID: 10046
		MandatoryExtension,
		/// <summary>Соединение будет разорвано сервером из-за ошибки на сервере.</summary>
		// Token: 0x0400273F RID: 10047
		InternalServerError
	}
}
