using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets
{
	// Token: 0x020007E3 RID: 2019
	internal sealed class WebSocketHandle
	{
		// Token: 0x06004070 RID: 16496 RVA: 0x000DD530 File Offset: 0x000DB730
		public static WebSocketHandle Create()
		{
			return new WebSocketHandle();
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x000DD537 File Offset: 0x000DB737
		public static bool IsValid(WebSocketHandle handle)
		{
			return handle != null;
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x000DD540 File Offset: 0x000DB740
		public WebSocketCloseStatus? CloseStatus
		{
			get
			{
				WebSocket webSocket = this._webSocket;
				if (webSocket == null)
				{
					return null;
				}
				return webSocket.CloseStatus;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x000DD566 File Offset: 0x000DB766
		public string CloseStatusDescription
		{
			get
			{
				WebSocket webSocket = this._webSocket;
				if (webSocket == null)
				{
					return null;
				}
				return webSocket.CloseStatusDescription;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x000DD579 File Offset: 0x000DB779
		public WebSocketState State
		{
			get
			{
				WebSocket webSocket = this._webSocket;
				if (webSocket == null)
				{
					return this._state;
				}
				return webSocket.State;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x000DD591 File Offset: 0x000DB791
		public string SubProtocol
		{
			get
			{
				WebSocket webSocket = this._webSocket;
				if (webSocket == null)
				{
					return null;
				}
				return webSocket.SubProtocol;
			}
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00003917 File Offset: 0x00001B17
		public static void CheckPlatformSupport()
		{
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x000DD5A4 File Offset: 0x000DB7A4
		public void Dispose()
		{
			this._state = WebSocketState.Closed;
			WebSocket webSocket = this._webSocket;
			if (webSocket == null)
			{
				return;
			}
			webSocket.Dispose();
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x000DD5BD File Offset: 0x000DB7BD
		public void Abort()
		{
			this._abortSource.Cancel();
			WebSocket webSocket = this._webSocket;
			if (webSocket == null)
			{
				return;
			}
			webSocket.Abort();
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x000DD5DA File Offset: 0x000DB7DA
		public Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			return this._webSocket.SendAsync(buffer, messageType, endOfMessage, cancellationToken);
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x000DD5EC File Offset: 0x000DB7EC
		public ValueTask SendAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			return this._webSocket.SendAsync(buffer, messageType, endOfMessage, cancellationToken);
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x000DD5FE File Offset: 0x000DB7FE
		public Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return this._webSocket.ReceiveAsync(buffer, cancellationToken);
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x000DD60D File Offset: 0x000DB80D
		public ValueTask<ValueWebSocketReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			return this._webSocket.ReceiveAsync(buffer, cancellationToken);
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x000DD61C File Offset: 0x000DB81C
		public Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return this._webSocket.CloseAsync(closeStatus, statusDescription, cancellationToken);
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x000DD62C File Offset: 0x000DB82C
		public Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return this._webSocket.CloseOutputAsync(closeStatus, statusDescription, cancellationToken);
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x000DD63C File Offset: 0x000DB83C
		public Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken, ClientWebSocketOptions options)
		{
			WebSocketHandle.<ConnectAsyncCore>d__26 <ConnectAsyncCore>d__;
			<ConnectAsyncCore>d__.<>4__this = this;
			<ConnectAsyncCore>d__.uri = uri;
			<ConnectAsyncCore>d__.cancellationToken = cancellationToken;
			<ConnectAsyncCore>d__.options = options;
			<ConnectAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ConnectAsyncCore>d__.<>1__state = -1;
			<ConnectAsyncCore>d__.<>t__builder.Start<WebSocketHandle.<ConnectAsyncCore>d__26>(ref <ConnectAsyncCore>d__);
			return <ConnectAsyncCore>d__.<>t__builder.Task;
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x000DD698 File Offset: 0x000DB898
		private Task<Socket> ConnectSocketAsync(string host, int port, CancellationToken cancellationToken)
		{
			WebSocketHandle.<ConnectSocketAsync>d__27 <ConnectSocketAsync>d__;
			<ConnectSocketAsync>d__.<>4__this = this;
			<ConnectSocketAsync>d__.host = host;
			<ConnectSocketAsync>d__.port = port;
			<ConnectSocketAsync>d__.cancellationToken = cancellationToken;
			<ConnectSocketAsync>d__.<>t__builder = AsyncTaskMethodBuilder<Socket>.Create();
			<ConnectSocketAsync>d__.<>1__state = -1;
			<ConnectSocketAsync>d__.<>t__builder.Start<WebSocketHandle.<ConnectSocketAsync>d__27>(ref <ConnectSocketAsync>d__);
			return <ConnectSocketAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x000DD6F4 File Offset: 0x000DB8F4
		private static byte[] BuildRequestHeader(Uri uri, ClientWebSocketOptions options, string secKey)
		{
			StringBuilder stringBuilder;
			if ((stringBuilder = WebSocketHandle.t_cachedStringBuilder) == null)
			{
				stringBuilder = (WebSocketHandle.t_cachedStringBuilder = new StringBuilder());
			}
			StringBuilder stringBuilder2 = stringBuilder;
			byte[] bytes;
			try
			{
				stringBuilder2.Append("GET ").Append(uri.PathAndQuery).Append(" HTTP/1.1\r\n");
				string value = options.RequestHeaders["Host"];
				stringBuilder2.Append("Host: ");
				if (string.IsNullOrEmpty(value))
				{
					stringBuilder2.Append(uri.IdnHost).Append(':').Append(uri.Port).Append("\r\n");
				}
				else
				{
					stringBuilder2.Append(value).Append("\r\n");
				}
				stringBuilder2.Append("Connection: Upgrade\r\n");
				stringBuilder2.Append("Upgrade: websocket\r\n");
				stringBuilder2.Append("Sec-WebSocket-Version: 13\r\n");
				stringBuilder2.Append("Sec-WebSocket-Key: ").Append(secKey).Append("\r\n");
				foreach (string text in options.RequestHeaders.AllKeys)
				{
					if (!string.Equals(text, "Host", StringComparison.OrdinalIgnoreCase))
					{
						stringBuilder2.Append(text).Append(": ").Append(options.RequestHeaders[text]).Append("\r\n");
					}
				}
				if (options.RequestedSubProtocols.Count > 0)
				{
					stringBuilder2.Append("Sec-WebSocket-Protocol").Append(": ");
					stringBuilder2.Append(options.RequestedSubProtocols[0]);
					for (int j = 1; j < options.RequestedSubProtocols.Count; j++)
					{
						stringBuilder2.Append(", ").Append(options.RequestedSubProtocols[j]);
					}
					stringBuilder2.Append("\r\n");
				}
				if (options.Cookies != null)
				{
					string cookieHeader = options.Cookies.GetCookieHeader(uri);
					if (!string.IsNullOrWhiteSpace(cookieHeader))
					{
						stringBuilder2.Append("Cookie").Append(": ").Append(cookieHeader).Append("\r\n");
					}
				}
				stringBuilder2.Append("\r\n");
				bytes = WebSocketHandle.s_defaultHttpEncoding.GetBytes(stringBuilder2.ToString());
			}
			finally
			{
				stringBuilder2.Clear();
			}
			return bytes;
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x000DD940 File Offset: 0x000DBB40
		private static KeyValuePair<string, string> CreateSecKeyAndSecWebSocketAccept()
		{
			string text = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
			KeyValuePair<string, string> result;
			using (SHA1 sha = SHA1.Create())
			{
				result = new KeyValuePair<string, string>(text, Convert.ToBase64String(sha.ComputeHash(Encoding.ASCII.GetBytes(text + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"))));
			}
			return result;
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x000DD9AC File Offset: 0x000DBBAC
		private Task<string> ParseAndValidateConnectResponseAsync(Stream stream, ClientWebSocketOptions options, string expectedSecWebSocketAccept, CancellationToken cancellationToken)
		{
			WebSocketHandle.<ParseAndValidateConnectResponseAsync>d__30 <ParseAndValidateConnectResponseAsync>d__;
			<ParseAndValidateConnectResponseAsync>d__.stream = stream;
			<ParseAndValidateConnectResponseAsync>d__.options = options;
			<ParseAndValidateConnectResponseAsync>d__.expectedSecWebSocketAccept = expectedSecWebSocketAccept;
			<ParseAndValidateConnectResponseAsync>d__.cancellationToken = cancellationToken;
			<ParseAndValidateConnectResponseAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ParseAndValidateConnectResponseAsync>d__.<>1__state = -1;
			<ParseAndValidateConnectResponseAsync>d__.<>t__builder.Start<WebSocketHandle.<ParseAndValidateConnectResponseAsync>d__30>(ref <ParseAndValidateConnectResponseAsync>d__);
			return <ParseAndValidateConnectResponseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x000DDA08 File Offset: 0x000DBC08
		private static void ValidateAndTrackHeader(string targetHeaderName, string targetHeaderValue, string foundHeaderName, string foundHeaderValue, ref bool foundHeader)
		{
			bool flag = string.Equals(targetHeaderName, foundHeaderName, StringComparison.OrdinalIgnoreCase);
			if (!foundHeader)
			{
				if (flag)
				{
					if (!string.Equals(targetHeaderValue, foundHeaderValue, StringComparison.OrdinalIgnoreCase))
					{
						throw new WebSocketException(SR.Format("The '{0}' header value '{1}' is invalid.", targetHeaderName, foundHeaderValue));
					}
					foundHeader = true;
					return;
				}
			}
			else if (flag)
			{
				throw new WebSocketException(SR.Format("Unable to connect to the remote server", Array.Empty<object>()));
			}
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x000DDA60 File Offset: 0x000DBC60
		private static Task<string> ReadResponseHeaderLineAsync(Stream stream, CancellationToken cancellationToken)
		{
			WebSocketHandle.<ReadResponseHeaderLineAsync>d__32 <ReadResponseHeaderLineAsync>d__;
			<ReadResponseHeaderLineAsync>d__.stream = stream;
			<ReadResponseHeaderLineAsync>d__.cancellationToken = cancellationToken;
			<ReadResponseHeaderLineAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadResponseHeaderLineAsync>d__.<>1__state = -1;
			<ReadResponseHeaderLineAsync>d__.<>t__builder.Start<WebSocketHandle.<ReadResponseHeaderLineAsync>d__32>(ref <ReadResponseHeaderLineAsync>d__);
			return <ReadResponseHeaderLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040026EA RID: 9962
		[ThreadStatic]
		private static StringBuilder t_cachedStringBuilder;

		// Token: 0x040026EB RID: 9963
		private static readonly Encoding s_defaultHttpEncoding = Encoding.GetEncoding(28591);

		// Token: 0x040026EC RID: 9964
		private const int DefaultReceiveBufferSize = 4096;

		// Token: 0x040026ED RID: 9965
		private const string WSServerGuid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";

		// Token: 0x040026EE RID: 9966
		private readonly CancellationTokenSource _abortSource = new CancellationTokenSource();

		// Token: 0x040026EF RID: 9967
		private WebSocketState _state = WebSocketState.Connecting;

		// Token: 0x040026F0 RID: 9968
		private WebSocket _webSocket;
	}
}
