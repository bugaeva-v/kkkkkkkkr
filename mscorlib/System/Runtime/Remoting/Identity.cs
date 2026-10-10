using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x02000560 RID: 1376
	internal abstract class Identity
	{
		// Token: 0x060035E8 RID: 13800 RVA: 0x000C23C5 File Offset: 0x000C05C5
		public Identity(string objectUri)
		{
			this._objectUri = objectUri;
		}

		// Token: 0x060035E9 RID: 13801
		public abstract ObjRef CreateObjRef(Type requestedType);

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x000C23D4 File Offset: 0x000C05D4
		public bool IsFromThisAppDomain
		{
			get
			{
				return this._channelSink == null;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x000C23DF File Offset: 0x000C05DF
		// (set) Token: 0x060035EC RID: 13804 RVA: 0x000C23E7 File Offset: 0x000C05E7
		public IMessageSink ChannelSink
		{
			get
			{
				return this._channelSink;
			}
			set
			{
				this._channelSink = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x000C23F0 File Offset: 0x000C05F0
		public IMessageSink EnvoySink
		{
			get
			{
				return this._envoySink;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x000C23F8 File Offset: 0x000C05F8
		// (set) Token: 0x060035EF RID: 13807 RVA: 0x000C2400 File Offset: 0x000C0600
		public string ObjectUri
		{
			get
			{
				return this._objectUri;
			}
			set
			{
				this._objectUri = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x000C2409 File Offset: 0x000C0609
		public bool IsConnected
		{
			get
			{
				return this._objectUri != null;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060035F1 RID: 13809 RVA: 0x000C2414 File Offset: 0x000C0614
		// (set) Token: 0x060035F2 RID: 13810 RVA: 0x000C241C File Offset: 0x000C061C
		public bool Disposed
		{
			get
			{
				return this._disposed;
			}
			set
			{
				this._disposed = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x000C2425 File Offset: 0x000C0625
		public DynamicPropertyCollection ClientDynamicProperties
		{
			get
			{
				if (this._clientDynamicProperties == null)
				{
					this._clientDynamicProperties = new DynamicPropertyCollection();
				}
				return this._clientDynamicProperties;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x000C2440 File Offset: 0x000C0640
		public DynamicPropertyCollection ServerDynamicProperties
		{
			get
			{
				if (this._serverDynamicProperties == null)
				{
					this._serverDynamicProperties = new DynamicPropertyCollection();
				}
				return this._serverDynamicProperties;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x000C245B File Offset: 0x000C065B
		public bool HasClientDynamicSinks
		{
			get
			{
				return this._clientDynamicProperties != null && this._clientDynamicProperties.HasProperties;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x000C2472 File Offset: 0x000C0672
		public bool HasServerDynamicSinks
		{
			get
			{
				return this._serverDynamicProperties != null && this._serverDynamicProperties.HasProperties;
			}
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x000C2489 File Offset: 0x000C0689
		public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (this._clientDynamicProperties != null && this._clientDynamicProperties.HasProperties)
			{
				this._clientDynamicProperties.NotifyMessage(start, req_msg, client_site, async);
			}
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x000C24B0 File Offset: 0x000C06B0
		public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (this._serverDynamicProperties != null && this._serverDynamicProperties.HasProperties)
			{
				this._serverDynamicProperties.NotifyMessage(start, req_msg, client_site, async);
			}
		}

		// Token: 0x0400251B RID: 9499
		protected string _objectUri;

		// Token: 0x0400251C RID: 9500
		protected IMessageSink _channelSink;

		// Token: 0x0400251D RID: 9501
		protected IMessageSink _envoySink;

		// Token: 0x0400251E RID: 9502
		private DynamicPropertyCollection _clientDynamicProperties;

		// Token: 0x0400251F RID: 9503
		private DynamicPropertyCollection _serverDynamicProperties;

		// Token: 0x04002520 RID: 9504
		protected ObjRef _objRef;

		// Token: 0x04002521 RID: 9505
		private bool _disposed;
	}
}
