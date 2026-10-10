using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets
{
	/// <summary>Класс WebSocket позволяет приложениям отправлять и получать данные после завершения обновления WebSocket.</summary>
	// Token: 0x020007EB RID: 2027
	public abstract class WebSocket : IDisposable
	{
		/// <summary>Указывает причину, по которой удаленная конечная точка инициировала подтверждение закрытия.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.WebSockets.WebSocketCloseStatus" />.</returns>
		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x0600409D RID: 16541
		public abstract WebSocketCloseStatus? CloseStatus { get; }

		/// <summary>Позволяет удаленной конечной точке описать причину закрытия подключения.</summary>
		/// <returns>Возвращает <see cref="T:System.String" />.</returns>
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x0600409E RID: 16542
		public abstract string CloseStatusDescription { get; }

		/// <summary>Возвращает подпротокол, который был согласован во время подтверждения открытия.</summary>
		/// <returns>Подпротокол, который был согласован во время подтверждения открытия.</returns>
		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x0600409F RID: 16543
		public abstract string SubProtocol { get; }

		/// <summary>Возвращает текущее состояние соединения WebSocket.</summary>
		/// <returns>Текущее состояние соединения WebSocket.</returns>
		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x060040A0 RID: 16544
		public abstract WebSocketState State { get; }

		/// <summary>Прерывает подключение WebSocket и отменяет все ожидающие операции ввода-вывода.</summary>
		// Token: 0x060040A1 RID: 16545
		public abstract void Abort();

		/// <summary>Закрывает подключение WebSocket в качестве асинхронной операции, используя подтверждение закрытия, которое определено в разделе 7 спецификации протокола WebSocket.</summary>
		/// <param name="closeStatus">Указывает причину закрытия соединения WebSocket.</param>
		/// <param name="statusDescription">Задает понятное пользователю пояснение причины закрытия подключения.</param>
		/// <param name="cancellationToken">Токен, который можно использовать для распространения уведомления о том, что операции нужно отменить.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x060040A2 RID: 16546
		public abstract Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);

		/// <summary>Инициирует или завершает подтверждение закрытия, определенное в разделе 7 спецификации протокола WebSocket.</summary>
		/// <param name="closeStatus">Указывает причину закрытия соединения WebSocket.</param>
		/// <param name="statusDescription">Разрешает приложениям задавать понятное пользователю объяснение причины закрытия соединения.</param>
		/// <param name="cancellationToken">Токен, который можно использовать для распространения уведомления о том, что операции нужно отменить.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x060040A3 RID: 16547
		public abstract Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);

		/// <summary>Используется для очистки неуправляемых ресурсов для ASP.NET и резидентных реализаций.</summary>
		// Token: 0x060040A4 RID: 16548
		public abstract void Dispose();

		/// <summary>Асинхронно получает данные через соединение <see cref="T:System.Net.WebSockets.WebSocket" />.</summary>
		/// <param name="buffer">Ссылается на буфер приложения, который является местом хранения полученных данных.</param>
		/// <param name="cancellationToken">Распространяет уведомление о том, что операции следует отменить.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию. Свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> объекта задачи возвращает массив <see cref="T:System.Byte" />, содержащий полученные данные.</returns>
		// Token: 0x060040A5 RID: 16549
		public abstract Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken);

		/// <summary>Асинхронно отправляет данные по соединению <see cref="T:System.Net.WebSockets.WebSocket" />.</summary>
		/// <param name="buffer">Буфер, передаваемый по этому соединению.</param>
		/// <param name="messageType">Указывает, какое сообщение отправляет приложение — двоичное или текстовое.</param>
		/// <param name="endOfMessage">Указывает, являются ли данные в "буфере" последней частью сообщения.</param>
		/// <param name="cancellationToken">Токен, распространяющий уведомление о том, что операции следует отменить.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x060040A6 RID: 16550
		public abstract Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken);

		// Token: 0x060040A7 RID: 16551 RVA: 0x000DE8C0 File Offset: 0x000DCAC0
		public virtual ValueTask<ValueWebSocketReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			WebSocket.<ReceiveAsync>d__14 <ReceiveAsync>d__;
			<ReceiveAsync>d__.<>4__this = this;
			<ReceiveAsync>d__.buffer = buffer;
			<ReceiveAsync>d__.cancellationToken = cancellationToken;
			<ReceiveAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult>.Create();
			<ReceiveAsync>d__.<>1__state = -1;
			<ReceiveAsync>d__.<>t__builder.Start<WebSocket.<ReceiveAsync>d__14>(ref <ReceiveAsync>d__);
			return <ReceiveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x000DE914 File Offset: 0x000DCB14
		public virtual ValueTask SendAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			ArraySegment<byte> buffer2;
			return new ValueTask(MemoryMarshal.TryGetArray<byte>(buffer, out buffer2) ? this.SendAsync(buffer2, messageType, endOfMessage, cancellationToken) : this.SendWithArrayPoolAsync(buffer, messageType, endOfMessage, cancellationToken));
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x000DE948 File Offset: 0x000DCB48
		private Task SendWithArrayPoolAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			WebSocket.<SendWithArrayPoolAsync>d__16 <SendWithArrayPoolAsync>d__;
			<SendWithArrayPoolAsync>d__.<>4__this = this;
			<SendWithArrayPoolAsync>d__.buffer = buffer;
			<SendWithArrayPoolAsync>d__.messageType = messageType;
			<SendWithArrayPoolAsync>d__.endOfMessage = endOfMessage;
			<SendWithArrayPoolAsync>d__.cancellationToken = cancellationToken;
			<SendWithArrayPoolAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SendWithArrayPoolAsync>d__.<>1__state = -1;
			<SendWithArrayPoolAsync>d__.<>t__builder.Start<WebSocket.<SendWithArrayPoolAsync>d__16>(ref <SendWithArrayPoolAsync>d__);
			return <SendWithArrayPoolAsync>d__.<>t__builder.Task;
		}

		/// <summary>Возвращает интервал проверки активности протокола WebSocket.</summary>
		/// <returns>По умолчанию интервал проверки активности WebSocket протокола. Стандартное значение для этого интервала составляет 30 секунд (согласно определению операционной системы или платформы .NET). Он используется для инициализации <see cref="P:System.Net.WebSockets.ClientWebSocketOptions.KeepAliveInterval" /> значение.</returns>
		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x060040AA RID: 16554 RVA: 0x000DE9AC File Offset: 0x000DCBAC
		public static TimeSpan DefaultKeepAliveInterval
		{
			get
			{
				return TimeSpan.FromSeconds(30.0);
			}
		}

		/// <summary>Проверяет, находится ли соединение в ожидаемом состоянии.</summary>
		/// <param name="state">Текущее состояние объекта WebSocket, который необходимо проверить на соответствие списку допустимых состояний.</param>
		/// <param name="validStates">Список допустимых состояний соединения.</param>
		// Token: 0x060040AB RID: 16555 RVA: 0x000DE9BC File Offset: 0x000DCBBC
		protected static void ThrowOnInvalidState(WebSocketState state, params WebSocketState[] validStates)
		{
			string p = string.Empty;
			if (validStates != null && validStates.Length != 0)
			{
				foreach (WebSocketState webSocketState in validStates)
				{
					if (state == webSocketState)
					{
						return;
					}
				}
				p = string.Join<WebSocketState>(", ", validStates);
			}
			throw new WebSocketException(SR.Format("The WebSocket is in an invalid state ('{0}') for this operation. Valid states are: '{1}'", state, p));
		}

		/// <summary>Возвращает значение, указывающее, какое состояние экземпляра WebSocket - закрыто или прервано.</summary>
		/// <param name="state">Текущее состояние WebSocket.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Net.WebSockets.WebSocket" /> закрыт или отменен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060040AC RID: 16556 RVA: 0x000DEA11 File Offset: 0x000DCC11
		protected static bool IsStateTerminal(WebSocketState state)
		{
			return state == WebSocketState.Closed || state == WebSocketState.Aborted;
		}

		/// <summary>Создайте буферы клиента для использования с этим экземпляром <see cref="T:System.Net.WebSockets.WebSocket" />.</summary>
		/// <param name="receiveBufferSize">Размер буфера получения клиента (в байтах).</param>
		/// <param name="sendBufferSize">Размер буфера отправки в байтах.</param>
		/// <returns>Массив с буферами клиента.</returns>
		// Token: 0x060040AD RID: 16557 RVA: 0x000DEA20 File Offset: 0x000DCC20
		public static ArraySegment<byte> CreateClientBuffer(int receiveBufferSize, int sendBufferSize)
		{
			if (receiveBufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("receiveBufferSize", receiveBufferSize, SR.Format("The argument must be a value greater than {0}.", 1));
			}
			if (sendBufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("sendBufferSize", sendBufferSize, SR.Format("The argument must be a value greater than {0}.", 1));
			}
			return new ArraySegment<byte>(new byte[Math.Max(receiveBufferSize, sendBufferSize)]);
		}

		/// <summary>Создает буфер сервера WebSocket.</summary>
		/// <param name="receiveBufferSize">Размер требуемого буфера (в байтах).</param>
		/// <returns>Возвращает <see cref="T:System.ArraySegment`1" />.</returns>
		// Token: 0x060040AE RID: 16558 RVA: 0x000DEA88 File Offset: 0x000DCC88
		public static ArraySegment<byte> CreateServerBuffer(int receiveBufferSize)
		{
			if (receiveBufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("receiveBufferSize", receiveBufferSize, SR.Format("The argument must be a value greater than {0}.", 1));
			}
			return new ArraySegment<byte>(new byte[receiveBufferSize]);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x000DEABC File Offset: 0x000DCCBC
		public static WebSocket CreateFromStream(Stream stream, bool isServer, string subProtocol, TimeSpan keepAliveInterval)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			if (!stream.CanRead || !stream.CanWrite)
			{
				throw new ArgumentException((!stream.CanRead) ? "The base stream is not readable." : "The base stream is not writeable.", "stream");
			}
			if (subProtocol != null)
			{
				WebSocketValidate.ValidateSubprotocol(subProtocol);
			}
			if (keepAliveInterval != Timeout.InfiniteTimeSpan && keepAliveInterval < TimeSpan.Zero)
			{
				throw new ArgumentOutOfRangeException("keepAliveInterval", keepAliveInterval, SR.Format("The argument must be a value greater than {0}.", 0));
			}
			return ManagedWebSocket.CreateFromConnectedStream(stream, isServer, subProtocol, keepAliveInterval);
		}

		/// <summary>Возвращает значение, которое указывает, является ли для экземпляра WebSocket целевым .NET Framework 4.5.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Net.WebSockets.WebSocket" /> имеет целью .NET Framework 4.5; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060040B0 RID: 16560 RVA: 0x0000390E File Offset: 0x00001B0E
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.")]
		public static bool IsApplicationTargeting45()
		{
			return true;
		}

		/// <summary>Разрешает вызывающим объектам  регистрировать префиксы для запросов WebSocket (ws и wss).</summary>
		// Token: 0x060040B1 RID: 16561 RVA: 0x00011F54 File Offset: 0x00010154
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void RegisterPrefixes()
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Позволяет вызывающим объектам создать класс WebSocket на стороне клиента, который будет использовать WSPC для кадрирования.</summary>
		/// <param name="innerStream">Подключение, которое необходимо использовать операций ввода-вывода.</param>
		/// <param name="subProtocol">Подпротокол, принятый клиентом.</param>
		/// <param name="receiveBufferSize">Размер в байтах буфера получения WebSocket клиента.</param>
		/// <param name="sendBufferSize">Размер в байтах буфера передачи клиента WebSocket.</param>
		/// <param name="keepAliveInterval">Определяет, как регулярно кадр передается через соединение для поддержание активности. Применяется только в том случае, если соединение бездействует.</param>
		/// <param name="useZeroMaskingKey">Указывает, случайный ключ или статический ключ (нули) должен использоваться для маскирования WebSocket.</param>
		/// <param name="internalBuffer">Используется как внутренний буфер в WPC. Размер должен быть ко крайней мере равен <c>2 * ReceiveBufferSize + SendBufferSize + 256 + 20 (16 в 32-разрядной версии)</c>.</param>
		/// <returns>Возвращает <see cref="T:System.Net.WebSockets.WebSocket" />.</returns>
		// Token: 0x060040B2 RID: 16562 RVA: 0x000DEB54 File Offset: 0x000DCD54
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static WebSocket CreateClientWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval, bool useZeroMaskingKey, ArraySegment<byte> internalBuffer)
		{
			if (innerStream == null)
			{
				throw new ArgumentNullException("innerStream");
			}
			if (!innerStream.CanRead || !innerStream.CanWrite)
			{
				throw new ArgumentException((!innerStream.CanRead) ? "The base stream is not readable." : "The base stream is not writeable.", "innerStream");
			}
			if (subProtocol != null)
			{
				WebSocketValidate.ValidateSubprotocol(subProtocol);
			}
			if (keepAliveInterval != Timeout.InfiniteTimeSpan && keepAliveInterval < TimeSpan.Zero)
			{
				throw new ArgumentOutOfRangeException("keepAliveInterval", keepAliveInterval, SR.Format("The argument must be a value greater than {0}.", 0));
			}
			if (receiveBufferSize <= 0 || sendBufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException((receiveBufferSize <= 0) ? "receiveBufferSize" : "sendBufferSize", (receiveBufferSize <= 0) ? receiveBufferSize : sendBufferSize, SR.Format("The argument must be a value greater than {0}.", 0));
			}
			return ManagedWebSocket.CreateFromConnectedStream(innerStream, false, subProtocol, keepAliveInterval);
		}
	}
}
