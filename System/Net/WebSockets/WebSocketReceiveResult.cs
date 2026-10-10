using System;

namespace System.Net.WebSockets
{
	/// <summary>Экземпляр этого класса представляет результат выполнения одной операции ReceiveAsync на WebSocket.</summary>
	// Token: 0x020007F3 RID: 2035
	public class WebSocketReceiveResult
	{
		/// <summary>Создает экземпляр класса <see cref="T:System.Net.WebSockets.WebSocketReceiveResult" />.</summary>
		/// <param name="count">Количество полученных байтов.</param>
		/// <param name="messageType">Тип сообщения, которое было получено.</param>
		/// <param name="endOfMessage">Указывает, является ли это сообщение последним.</param>
		// Token: 0x060040DA RID: 16602 RVA: 0x000DF1B8 File Offset: 0x000DD3B8
		public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage) : this(count, messageType, endOfMessage, null, null)
		{
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Net.WebSockets.WebSocketReceiveResult" />.</summary>
		/// <param name="count">Количество полученных байтов.</param>
		/// <param name="messageType">Тип сообщения, которое было получено.</param>
		/// <param name="endOfMessage">Указывает, является ли это сообщение последним.</param>
		/// <param name="closeStatus">Указывает <see cref="T:System.Net.WebSockets.WebSocketCloseStatus" /> подключения.</param>
		/// <param name="closeStatusDescription">Описание <paramref name="closeStatus" />.</param>
		// Token: 0x060040DB RID: 16603 RVA: 0x000DF1D8 File Offset: 0x000DD3D8
		public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage, WebSocketCloseStatus? closeStatus, string closeStatusDescription)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.Count = count;
			this.EndOfMessage = endOfMessage;
			this.MessageType = messageType;
			this.CloseStatus = closeStatus;
			this.CloseStatusDescription = closeStatusDescription;
		}

		/// <summary>Указывает число байтов, полученных WebSocket.</summary>
		/// <returns>Возвращает <see cref="T:System.Int32" />.</returns>
		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x000DF214 File Offset: 0x000DD414
		public int Count { get; }

		/// <summary>Указывает, было ли сообщение получено полностью.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.</returns>
		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x000DF21C File Offset: 0x000DD41C
		public bool EndOfMessage { get; }

		/// <summary>Указывает, является ли текущее сообщение сообщением UTF-8 или двоичным сообщением.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.WebSockets.WebSocketMessageType" />.</returns>
		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060040DE RID: 16606 RVA: 0x000DF224 File Offset: 0x000DD424
		public WebSocketMessageType MessageType { get; }

		/// <summary>Указывает причину, по которой удаленная конечная точка инициировала подтверждение закрытия.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.WebSockets.WebSocketCloseStatus" />.</returns>
		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x060040DF RID: 16607 RVA: 0x000DF22C File Offset: 0x000DD42C
		public WebSocketCloseStatus? CloseStatus { get; }

		/// <summary>Возвращает необязательное описание, описывающее, почему удаленная конечная точка инициировала подтверждение закрытия.</summary>
		/// <returns>Возвращает <see cref="T:System.String" />.</returns>
		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x000DF234 File Offset: 0x000DD434
		public string CloseStatusDescription { get; }
	}
}
