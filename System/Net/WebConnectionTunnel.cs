using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020006C4 RID: 1732
	internal class WebConnectionTunnel
	{
		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x000C3C82 File Offset: 0x000C1E82
		public HttpWebRequest Request { get; }

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x000C3C8A File Offset: 0x000C1E8A
		public Uri ConnectUri { get; }

		// Token: 0x060037B6 RID: 14262 RVA: 0x000C3C92 File Offset: 0x000C1E92
		public WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
		{
			this.Request = request;
			this.ConnectUri = connectUri;
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x000C3CA8 File Offset: 0x000C1EA8
		// (set) Token: 0x060037B8 RID: 14264 RVA: 0x000C3CB0 File Offset: 0x000C1EB0
		public bool Success { get; private set; }

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x000C3CB9 File Offset: 0x000C1EB9
		// (set) Token: 0x060037BA RID: 14266 RVA: 0x000C3CC1 File Offset: 0x000C1EC1
		public bool CloseConnection { get; private set; }

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x000C3CCA File Offset: 0x000C1ECA
		// (set) Token: 0x060037BC RID: 14268 RVA: 0x000C3CD2 File Offset: 0x000C1ED2
		public int StatusCode { get; private set; }

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060037BD RID: 14269 RVA: 0x000C3CDB File Offset: 0x000C1EDB
		// (set) Token: 0x060037BE RID: 14270 RVA: 0x000C3CE3 File Offset: 0x000C1EE3
		public string StatusDescription { get; private set; }

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x000C3CEC File Offset: 0x000C1EEC
		// (set) Token: 0x060037C0 RID: 14272 RVA: 0x000C3CF4 File Offset: 0x000C1EF4
		public string[] Challenge { get; private set; }

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x000C3CFD File Offset: 0x000C1EFD
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x000C3D05 File Offset: 0x000C1F05
		public WebHeaderCollection Headers { get; private set; }

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060037C3 RID: 14275 RVA: 0x000C3D0E File Offset: 0x000C1F0E
		// (set) Token: 0x060037C4 RID: 14276 RVA: 0x000C3D16 File Offset: 0x000C1F16
		public Version ProxyVersion { get; private set; }

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060037C5 RID: 14277 RVA: 0x000C3D1F File Offset: 0x000C1F1F
		// (set) Token: 0x060037C6 RID: 14278 RVA: 0x000C3D27 File Offset: 0x000C1F27
		public byte[] Data { get; private set; }

		// Token: 0x060037C7 RID: 14279 RVA: 0x000C3D30 File Offset: 0x000C1F30
		internal Task Initialize(Stream stream, CancellationToken cancellationToken)
		{
			WebConnectionTunnel.<Initialize>d__42 <Initialize>d__;
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.stream = stream;
			<Initialize>d__.cancellationToken = cancellationToken;
			<Initialize>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<WebConnectionTunnel.<Initialize>d__42>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x000C3D84 File Offset: 0x000C1F84
		private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken)
		{
			WebConnectionTunnel.<ReadHeaders>d__43 <ReadHeaders>d__;
			<ReadHeaders>d__.<>4__this = this;
			<ReadHeaders>d__.stream = stream;
			<ReadHeaders>d__.cancellationToken = cancellationToken;
			<ReadHeaders>d__.<>t__builder = AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.Create();
			<ReadHeaders>d__.<>1__state = -1;
			<ReadHeaders>d__.<>t__builder.Start<WebConnectionTunnel.<ReadHeaders>d__43>(ref <ReadHeaders>d__);
			return <ReadHeaders>d__.<>t__builder.Task;
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x000C3DD8 File Offset: 0x000C1FD8
		private void FlushContents(Stream stream, int contentLength)
		{
			while (contentLength > 0)
			{
				byte[] buffer = new byte[contentLength];
				int num = stream.Read(buffer, 0, contentLength);
				if (num <= 0)
				{
					break;
				}
				contentLength -= num;
			}
		}

		// Token: 0x04002085 RID: 8325
		private HttpWebRequest connectRequest;

		// Token: 0x04002086 RID: 8326
		private WebConnectionTunnel.NtlmAuthState ntlmAuthState;

		// Token: 0x020006C5 RID: 1733
		private enum NtlmAuthState
		{
			// Token: 0x04002090 RID: 8336
			None,
			// Token: 0x04002091 RID: 8337
			Challenge,
			// Token: 0x04002092 RID: 8338
			Response
		}
	}
}
