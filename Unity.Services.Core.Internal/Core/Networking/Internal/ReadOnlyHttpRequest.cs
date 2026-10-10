using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Networking.Internal
{
	// Token: 0x0200001E RID: 30
	internal struct ReadOnlyHttpRequest
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000021D3 File Offset: 0x000003D3
		public ReadOnlyHttpRequest(HttpRequest request)
		{
			this.m_Request = request;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000021DC File Offset: 0x000003DC
		public string Method
		{
			get
			{
				return this.m_Request.Method;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000021E9 File Offset: 0x000003E9
		public string Url
		{
			get
			{
				return this.m_Request.Url;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000021F6 File Offset: 0x000003F6
		public IReadOnlyDictionary<string, string> Headers
		{
			get
			{
				return this.m_Request.Headers;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002203 File Offset: 0x00000403
		public byte[] Body
		{
			get
			{
				return this.m_Request.Body;
			}
		}

		// Token: 0x0400001A RID: 26
		private HttpRequest m_Request;
	}
}
