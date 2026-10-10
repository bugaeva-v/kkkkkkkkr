using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets
{
	/// <summary>Предоставляет клиент для подключения к службам WebSocket.</summary>
	// Token: 0x020007DE RID: 2014
	public sealed class ClientWebSocket : WebSocket
	{
		/// <summary>Создает экземпляр класса <see cref="T:System.Net.WebSockets.ClientWebSocket" />.</summary>
		// Token: 0x0600403C RID: 16444 RVA: 0x000DCD88 File Offset: 0x000DAF88
		public ClientWebSocket()
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, ".ctor");
			}
			WebSocketHandle.CheckPlatformSupport();
			this._state = 0;
			this._options = new ClientWebSocketOptions
			{
				Proxy = ClientWebSocket.DefaultWebProxy.Instance
			};
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Exit(this, null, ".ctor");
			}
		}

		/// <summary>Возвращает параметры WebSocket для экземпляра <see cref="T:System.Net.WebSockets.ClientWebSocket" />.</summary>
		/// <returns>Параметры WebSocket для экземпляра <see cref="T:System.Net.WebSockets.ClientWebSocket" />.</returns>
		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x000DCDE3 File Offset: 0x000DAFE3
		public ClientWebSocketOptions Options
		{
			get
			{
				return this._options;
			}
		}

		/// <summary>Возвращает причину, по которой подтверждение закрытия было инициировано для экземпляра <see cref="T:System.Net.WebSockets.ClientWebSocket" />.</summary>
		/// <returns>Причина, по которой было инициировано подтверждение закрытия.</returns>
		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x000DCDEC File Offset: 0x000DAFEC
		public override WebSocketCloseStatus? CloseStatus
		{
			get
			{
				if (WebSocketHandle.IsValid(this._innerWebSocket))
				{
					return this._innerWebSocket.CloseStatus;
				}
				return null;
			}
		}

		/// <summary>Возвращает описание причины, по которой экземпляр <see cref="T:System.Net.WebSockets.ClientWebSocket" /> был закрыт.</summary>
		/// <returns>Описание причины, по которой экземпляр <see cref="T:System.Net.WebSockets.ClientWebSocket" /> был закрыт.</returns>
		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x0600403F RID: 16447 RVA: 0x000DCE1B File Offset: 0x000DB01B
		public override string CloseStatusDescription
		{
			get
			{
				if (WebSocketHandle.IsValid(this._innerWebSocket))
				{
					return this._innerWebSocket.CloseStatusDescription;
				}
				return null;
			}
		}

		/// <summary>Получает поддерживаемый подпротокол WebSocket для экземпляра <see cref="T:System.Net.WebSockets.ClientWebSocket" />.</summary>
		/// <returns>Поддерживаемый подпротокол WebSocket.</returns>
		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x000DCE37 File Offset: 0x000DB037
		public override string SubProtocol
		{
			get
			{
				if (WebSocketHandle.IsValid(this._innerWebSocket))
				{
					return this._innerWebSocket.SubProtocol;
				}
				return null;
			}
		}

		/// <summary>Получает состояние WebSocket экземпляра <see cref="T:System.Net.WebSockets.ClientWebSocket" />.</summary>
		/// <returns>Состояние WebSocket экземпляра <see cref="T:System.Net.WebSockets.ClientWebSocket" />.</returns>
		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x000DCE54 File Offset: 0x000DB054
		public override WebSocketState State
		{
			get
			{
				if (WebSocketHandle.IsValid(this._innerWebSocket))
				{
					return this._innerWebSocket.State;
				}
				ClientWebSocket.InternalState state = (ClientWebSocket.InternalState)this._state;
				if (state == ClientWebSocket.InternalState.Created)
				{
					return WebSocketState.None;
				}
				if (state != ClientWebSocket.InternalState.Connecting)
				{
					return WebSocketState.Closed;
				}
				return WebSocketState.Connecting;
			}
		}

		/// <summary>Подключение к серверу WebSocket в виде асинхронной операции.</summary>
		/// <param name="uri">URI сервера WebSocket для подключения.</param>
		/// <param name="cancellationToken">Токен отмены, используемый для распространения уведомления о том, что эта операция должна быть отменена.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004042 RID: 16450 RVA: 0x000DCE90 File Offset: 0x000DB090
		public Task ConnectAsync(Uri uri, CancellationToken cancellationToken)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			if (!uri.IsAbsoluteUri)
			{
				throw new ArgumentException("This operation is not supported for a relative URI.", "uri");
			}
			if (uri.Scheme != "ws" && uri.Scheme != "wss")
			{
				throw new ArgumentException("Only Uris starting with 'ws://' or 'wss://' are supported.", "uri");
			}
			ClientWebSocket.InternalState internalState = (ClientWebSocket.InternalState)Interlocked.CompareExchange(ref this._state, 1, 0);
			if (internalState == ClientWebSocket.InternalState.Disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (internalState != ClientWebSocket.InternalState.Created)
			{
				throw new InvalidOperationException("The WebSocket has already been started.");
			}
			this._options.SetToReadOnly();
			return this.ConnectAsyncCore(uri, cancellationToken);
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x000DCF44 File Offset: 0x000DB144
		private Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken)
		{
			ClientWebSocket.<ConnectAsyncCore>d__16 <ConnectAsyncCore>d__;
			<ConnectAsyncCore>d__.<>4__this = this;
			<ConnectAsyncCore>d__.uri = uri;
			<ConnectAsyncCore>d__.cancellationToken = cancellationToken;
			<ConnectAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ConnectAsyncCore>d__.<>1__state = -1;
			<ConnectAsyncCore>d__.<>t__builder.Start<ClientWebSocket.<ConnectAsyncCore>d__16>(ref <ConnectAsyncCore>d__);
			return <ConnectAsyncCore>d__.<>t__builder.Task;
		}

		/// <summary>Отправьте данные по <see cref="T:System.Net.WebSockets.ClientWebSocket" /> в качестве асинхронной операции.</summary>
		/// <param name="buffer">Буфер, содержащий отправляемое сообщение.</param>
		/// <param name="messageType">Указывает, содержит ли буфер открытый текст или текст в двоичном формате.</param>
		/// <param name="endOfMessage">Указывает, является ли данная отправка последней асинхронной отправкой. Значение <see langword="true" />, если это последняя отправка; в противном случае — значение <see langword="false" />.</param>
		/// <param name="cancellationToken">Токен отмены, используемый для распространения уведомления о том, что эта операция должна быть отменена.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004044 RID: 16452 RVA: 0x000DCF97 File Offset: 0x000DB197
		public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			this.ThrowIfNotConnected();
			return this._innerWebSocket.SendAsync(buffer, messageType, endOfMessage, cancellationToken);
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x000DCFAF File Offset: 0x000DB1AF
		public override ValueTask SendAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			this.ThrowIfNotConnected();
			return this._innerWebSocket.SendAsync(buffer, messageType, endOfMessage, cancellationToken);
		}

		/// <summary>Извлекает данные по <see cref="T:System.Net.WebSockets.ClientWebSocket" /> в виде асинхронной операции.</summary>
		/// <param name="buffer">Буфер для получения ответа.</param>
		/// <param name="cancellationToken">Токен отмены, используемый для распространения уведомления о том, что эта операция должна быть отменена.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004046 RID: 16454 RVA: 0x000DCFC7 File Offset: 0x000DB1C7
		public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			this.ThrowIfNotConnected();
			return this._innerWebSocket.ReceiveAsync(buffer, cancellationToken);
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x000DCFDC File Offset: 0x000DB1DC
		public override ValueTask<ValueWebSocketReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			this.ThrowIfNotConnected();
			return this._innerWebSocket.ReceiveAsync(buffer, cancellationToken);
		}

		/// <summary>Закрывает экземпляр <see cref="T:System.Net.WebSockets.ClientWebSocket" /> как асинхронную операцию.</summary>
		/// <param name="closeStatus">Состояние закрытия WebSocket.</param>
		/// <param name="statusDescription">Описание состояния закрытия.</param>
		/// <param name="cancellationToken">Токен отмены, используемый для распространения уведомления о том, что эта операция должна быть отменена.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004048 RID: 16456 RVA: 0x000DCFF1 File Offset: 0x000DB1F1
		public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			this.ThrowIfNotConnected();
			return this._innerWebSocket.CloseAsync(closeStatus, statusDescription, cancellationToken);
		}

		/// <summary>Закрывает вывод для экземпляра <see cref="T:System.Net.WebSockets.ClientWebSocket" /> как асинхронную операцию.</summary>
		/// <param name="closeStatus">Состояние закрытия WebSocket.</param>
		/// <param name="statusDescription">Описание состояния закрытия.</param>
		/// <param name="cancellationToken">Токен отмены, используемый для распространения уведомления о том, что эта операция должна быть отменена.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004049 RID: 16457 RVA: 0x000DD007 File Offset: 0x000DB207
		public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			this.ThrowIfNotConnected();
			return this._innerWebSocket.CloseOutputAsync(closeStatus, statusDescription, cancellationToken);
		}

		/// <summary>Прерывает подключение и отменяет все ожидающие операции ввода-вывода.</summary>
		// Token: 0x0600404A RID: 16458 RVA: 0x000DD01D File Offset: 0x000DB21D
		public override void Abort()
		{
			if (this._state == 3)
			{
				return;
			}
			if (WebSocketHandle.IsValid(this._innerWebSocket))
			{
				this._innerWebSocket.Abort();
			}
			this.Dispose();
		}

		/// <summary>Высвобождает неуправляемые ресурсы, используемые экземпляром <see cref="T:System.Net.WebSockets.ClientWebSocket" />.</summary>
		// Token: 0x0600404B RID: 16459 RVA: 0x000DD047 File Offset: 0x000DB247
		public override void Dispose()
		{
			if (Interlocked.Exchange(ref this._state, 3) == 3)
			{
				return;
			}
			if (WebSocketHandle.IsValid(this._innerWebSocket))
			{
				this._innerWebSocket.Dispose();
			}
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x000DD071 File Offset: 0x000DB271
		private void ThrowIfNotConnected()
		{
			if (this._state == 3)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (this._state != 2)
			{
				throw new InvalidOperationException("The WebSocket is not connected.");
			}
		}

		// Token: 0x040026CE RID: 9934
		private readonly ClientWebSocketOptions _options;

		// Token: 0x040026CF RID: 9935
		private WebSocketHandle _innerWebSocket;

		// Token: 0x040026D0 RID: 9936
		private int _state;

		// Token: 0x020007DF RID: 2015
		private enum InternalState
		{
			// Token: 0x040026D2 RID: 9938
			Created,
			// Token: 0x040026D3 RID: 9939
			Connecting,
			// Token: 0x040026D4 RID: 9940
			Connected,
			// Token: 0x040026D5 RID: 9941
			Disposed
		}

		// Token: 0x020007E0 RID: 2016
		internal sealed class DefaultWebProxy : IWebProxy
		{
			// Token: 0x17000E8C RID: 3724
			// (get) Token: 0x0600404D RID: 16461 RVA: 0x000DD0A1 File Offset: 0x000DB2A1
			public static ClientWebSocket.DefaultWebProxy Instance { get; } = new ClientWebSocket.DefaultWebProxy();

			// Token: 0x17000E8D RID: 3725
			// (get) Token: 0x0600404E RID: 16462 RVA: 0x000044FA File Offset: 0x000026FA
			// (set) Token: 0x0600404F RID: 16463 RVA: 0x000044FA File Offset: 0x000026FA
			public ICredentials Credentials
			{
				get
				{
					throw new NotSupportedException();
				}
				set
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x06004050 RID: 16464 RVA: 0x000044FA File Offset: 0x000026FA
			public Uri GetProxy(Uri destination)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06004051 RID: 16465 RVA: 0x000044FA File Offset: 0x000026FA
			public bool IsBypassed(Uri host)
			{
				throw new NotSupportedException();
			}
		}
	}
}
