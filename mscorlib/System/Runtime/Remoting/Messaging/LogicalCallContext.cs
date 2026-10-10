using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Principal;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Предоставляет набор свойств, которые переносятся с помощью выполняемой ветви кода во время вызовов удаленных методов.</summary>
	// Token: 0x02000604 RID: 1540
	[SecurityCritical]
	[ComVisible(true)]
	[Serializable]
	public sealed class LogicalCallContext : ISerializable, ICloneable
	{
		// Token: 0x06003A4E RID: 14926 RVA: 0x0000259F File Offset: 0x0000079F
		internal LogicalCallContext()
		{
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x000CC820 File Offset: 0x000CAA20
		[SecurityCritical]
		internal LogicalCallContext(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Name.Equals("__RemotingData"))
				{
					this.m_RemotingData = (CallContextRemotingData)enumerator.Value;
				}
				else if (enumerator.Name.Equals("__SecurityData"))
				{
					if (context.State == StreamingContextStates.CrossAppDomain)
					{
						this.m_SecurityData = (CallContextSecurityData)enumerator.Value;
					}
				}
				else if (enumerator.Name.Equals("__HostContext"))
				{
					this.m_HostContext = enumerator.Value;
				}
				else if (enumerator.Name.Equals("__CorrelationMgrSlotPresent"))
				{
					this.m_IsCorrelationMgr = (bool)enumerator.Value;
				}
				else
				{
					this.Datastore[enumerator.Name] = enumerator.Value;
				}
			}
		}

		/// <summary>Заполняет заданный <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации текущего <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий не имеет разрешения SerializationFormatter.</exception>
		// Token: 0x06003A50 RID: 14928 RVA: 0x000CC904 File Offset: 0x000CAB04
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.SetType(LogicalCallContext.s_callContextType);
			if (this.m_RemotingData != null)
			{
				info.AddValue("__RemotingData", this.m_RemotingData);
			}
			if (this.m_SecurityData != null && context.State == StreamingContextStates.CrossAppDomain)
			{
				info.AddValue("__SecurityData", this.m_SecurityData);
			}
			if (this.m_HostContext != null)
			{
				info.AddValue("__HostContext", this.m_HostContext);
			}
			if (this.m_IsCorrelationMgr)
			{
				info.AddValue("__CorrelationMgrSlotPresent", this.m_IsCorrelationMgr);
			}
			if (this.HasUserData)
			{
				IDictionaryEnumerator enumerator = this.m_Datastore.GetEnumerator();
				while (enumerator.MoveNext())
				{
					info.AddValue((string)enumerator.Key, enumerator.Value);
				}
			}
		}

		/// <summary>Создает новый объект, являющийся копией текущего экземпляра.</summary>
		/// <returns>Новый объект, являющийся копией этого экземпляра.</returns>
		// Token: 0x06003A51 RID: 14929 RVA: 0x000CC9D4 File Offset: 0x000CABD4
		[SecuritySafeCritical]
		public object Clone()
		{
			LogicalCallContext logicalCallContext = new LogicalCallContext();
			if (this.m_RemotingData != null)
			{
				logicalCallContext.m_RemotingData = (CallContextRemotingData)this.m_RemotingData.Clone();
			}
			if (this.m_SecurityData != null)
			{
				logicalCallContext.m_SecurityData = (CallContextSecurityData)this.m_SecurityData.Clone();
			}
			if (this.m_HostContext != null)
			{
				logicalCallContext.m_HostContext = this.m_HostContext;
			}
			logicalCallContext.m_IsCorrelationMgr = this.m_IsCorrelationMgr;
			if (this.HasUserData)
			{
				IDictionaryEnumerator enumerator = this.m_Datastore.GetEnumerator();
				if (!this.m_IsCorrelationMgr)
				{
					while (enumerator.MoveNext())
					{
						logicalCallContext.Datastore[(string)enumerator.Key] = enumerator.Value;
					}
				}
				else
				{
					while (enumerator.MoveNext())
					{
						string text = (string)enumerator.Key;
						if (text.Equals("System.Diagnostics.Trace.CorrelationManagerSlot"))
						{
							logicalCallContext.Datastore[text] = ((ICloneable)enumerator.Value).Clone();
						}
						else
						{
							logicalCallContext.Datastore[text] = enumerator.Value;
						}
					}
				}
			}
			return logicalCallContext;
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x000CCADC File Offset: 0x000CACDC
		[SecurityCritical]
		internal void Merge(LogicalCallContext lc)
		{
			if (lc != null && this != lc && lc.HasUserData)
			{
				IDictionaryEnumerator enumerator = lc.Datastore.GetEnumerator();
				while (enumerator.MoveNext())
				{
					this.Datastore[(string)enumerator.Key] = enumerator.Value;
				}
			}
		}

		/// <summary>Возвращает значение, определяющее, содержит ли информацию текущий <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" />.</summary>
		/// <returns>Логическое значение, определяющее, содержит ли информацию текущий <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" />.</returns>
		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x000CCB2C File Offset: 0x000CAD2C
		public bool HasInfo
		{
			[SecurityCritical]
			get
			{
				bool result = false;
				if ((this.m_RemotingData != null && this.m_RemotingData.HasInfo) || (this.m_SecurityData != null && this.m_SecurityData.HasInfo) || this.m_HostContext != null || this.HasUserData)
				{
					result = true;
				}
				return result;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x000CCB78 File Offset: 0x000CAD78
		private bool HasUserData
		{
			get
			{
				return this.m_Datastore != null && this.m_Datastore.Count > 0;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x000CCB92 File Offset: 0x000CAD92
		internal CallContextRemotingData RemotingData
		{
			get
			{
				if (this.m_RemotingData == null)
				{
					this.m_RemotingData = new CallContextRemotingData();
				}
				return this.m_RemotingData;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x000CCBAD File Offset: 0x000CADAD
		internal CallContextSecurityData SecurityData
		{
			get
			{
				if (this.m_SecurityData == null)
				{
					this.m_SecurityData = new CallContextSecurityData();
				}
				return this.m_SecurityData;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x000CCBC8 File Offset: 0x000CADC8
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x000CCBD0 File Offset: 0x000CADD0
		internal object HostContext
		{
			get
			{
				return this.m_HostContext;
			}
			set
			{
				this.m_HostContext = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x000CCBD9 File Offset: 0x000CADD9
		private Hashtable Datastore
		{
			get
			{
				if (this.m_Datastore == null)
				{
					this.m_Datastore = new Hashtable();
				}
				return this.m_Datastore;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x000CCBF4 File Offset: 0x000CADF4
		// (set) Token: 0x06003A5B RID: 14939 RVA: 0x000CCC0B File Offset: 0x000CAE0B
		internal IPrincipal Principal
		{
			get
			{
				if (this.m_SecurityData != null)
				{
					return this.m_SecurityData.Principal;
				}
				return null;
			}
			[SecurityCritical]
			set
			{
				this.SecurityData.Principal = value;
			}
		}

		/// <summary>Очищает область данных с заданным именем.</summary>
		/// <param name="name">Имя очищаемой области данных.</param>
		// Token: 0x06003A5C RID: 14940 RVA: 0x000CCC19 File Offset: 0x000CAE19
		[SecurityCritical]
		public void FreeNamedDataSlot(string name)
		{
			this.Datastore.Remove(name);
		}

		/// <summary>Извлекает объект, связанный с заданным именем, из текущего экземпляра.</summary>
		/// <param name="name">Имя элемента в контексте вызова.</param>
		/// <returns>Объект в логическом контексте вызова с заданным именем.</returns>
		// Token: 0x06003A5D RID: 14941 RVA: 0x000CCC27 File Offset: 0x000CAE27
		[SecurityCritical]
		public object GetData(string name)
		{
			return this.Datastore[name];
		}

		/// <summary>Сохраняет заданный объект в текущем экземпляре и связывает его с заданным именем.</summary>
		/// <param name="name">Имя, с которым связывается новый элемент в контексте вызова.</param>
		/// <param name="data">Объект, сохраняемый в контексте вызова.</param>
		// Token: 0x06003A5E RID: 14942 RVA: 0x000CCC35 File Offset: 0x000CAE35
		[SecurityCritical]
		public void SetData(string name, object data)
		{
			this.Datastore[name] = data;
			if (name.Equals("System.Diagnostics.Trace.CorrelationManagerSlot"))
			{
				this.m_IsCorrelationMgr = true;
			}
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x000CCC58 File Offset: 0x000CAE58
		private Header[] InternalGetOutgoingHeaders()
		{
			Header[] sendHeaders = this._sendHeaders;
			this._sendHeaders = null;
			this._recvHeaders = null;
			return sendHeaders;
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x000CCC6E File Offset: 0x000CAE6E
		internal void InternalSetHeaders(Header[] headers)
		{
			this._sendHeaders = headers;
			this._recvHeaders = null;
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x000CCC7E File Offset: 0x000CAE7E
		internal Header[] InternalGetHeaders()
		{
			if (this._sendHeaders != null)
			{
				return this._sendHeaders;
			}
			return this._recvHeaders;
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x000CCC98 File Offset: 0x000CAE98
		[SecurityCritical]
		internal IPrincipal RemovePrincipalIfNotSerializable()
		{
			IPrincipal principal = this.Principal;
			if (principal != null && !principal.GetType().IsSerializable)
			{
				this.Principal = null;
			}
			return principal;
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x000CCCC4 File Offset: 0x000CAEC4
		[SecurityCritical]
		internal void PropagateOutgoingHeadersToMessage(IMessage msg)
		{
			Header[] array = this.InternalGetOutgoingHeaders();
			if (array != null)
			{
				IDictionary properties = msg.Properties;
				foreach (Header header in array)
				{
					if (header != null)
					{
						string propertyKeyForHeader = LogicalCallContext.GetPropertyKeyForHeader(header);
						properties[propertyKeyForHeader] = header;
					}
				}
			}
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x000CCD0E File Offset: 0x000CAF0E
		internal static string GetPropertyKeyForHeader(Header header)
		{
			if (header == null)
			{
				return null;
			}
			if (header.HeaderNamespace != null)
			{
				return header.Name + ", " + header.HeaderNamespace;
			}
			return header.Name;
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x000CCD3C File Offset: 0x000CAF3C
		[SecurityCritical]
		internal void PropagateIncomingHeadersToCallContext(IMessage msg)
		{
			IInternalMessage internalMessage = msg as IInternalMessage;
			if (internalMessage != null && !internalMessage.HasProperties())
			{
				return;
			}
			IDictionaryEnumerator enumerator = msg.Properties.GetEnumerator();
			int num = 0;
			while (enumerator.MoveNext())
			{
				if (!((string)enumerator.Key).StartsWith("__", StringComparison.Ordinal) && enumerator.Value is Header)
				{
					num++;
				}
			}
			Header[] array = null;
			if (num > 0)
			{
				array = new Header[num];
				num = 0;
				enumerator.Reset();
				while (enumerator.MoveNext())
				{
					if (!((string)enumerator.Key).StartsWith("__", StringComparison.Ordinal))
					{
						Header header = enumerator.Value as Header;
						if (header != null)
						{
							array[num++] = header;
						}
					}
				}
			}
			this._recvHeaders = array;
			this._sendHeaders = null;
		}

		// Token: 0x0400264D RID: 9805
		private static Type s_callContextType = typeof(LogicalCallContext);

		// Token: 0x0400264E RID: 9806
		private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";

		// Token: 0x0400264F RID: 9807
		private Hashtable m_Datastore;

		// Token: 0x04002650 RID: 9808
		private CallContextRemotingData m_RemotingData;

		// Token: 0x04002651 RID: 9809
		private CallContextSecurityData m_SecurityData;

		// Token: 0x04002652 RID: 9810
		private object m_HostContext;

		// Token: 0x04002653 RID: 9811
		private bool m_IsCorrelationMgr;

		// Token: 0x04002654 RID: 9812
		private Header[] _sendHeaders;

		// Token: 0x04002655 RID: 9813
		private Header[] _recvHeaders;

		// Token: 0x02000605 RID: 1541
		internal struct Reader
		{
			// Token: 0x06003A67 RID: 14951 RVA: 0x000CCE0D File Offset: 0x000CB00D
			public Reader(LogicalCallContext ctx)
			{
				this.m_ctx = ctx;
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x06003A68 RID: 14952 RVA: 0x000CCE16 File Offset: 0x000CB016
			public bool IsNull
			{
				get
				{
					return this.m_ctx == null;
				}
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06003A69 RID: 14953 RVA: 0x000CCE21 File Offset: 0x000CB021
			public bool HasInfo
			{
				get
				{
					return !this.IsNull && this.m_ctx.HasInfo;
				}
			}

			// Token: 0x06003A6A RID: 14954 RVA: 0x000CCE38 File Offset: 0x000CB038
			public LogicalCallContext Clone()
			{
				return (LogicalCallContext)this.m_ctx.Clone();
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06003A6B RID: 14955 RVA: 0x000CCE4A File Offset: 0x000CB04A
			public IPrincipal Principal
			{
				get
				{
					if (!this.IsNull)
					{
						return this.m_ctx.Principal;
					}
					return null;
				}
			}

			// Token: 0x06003A6C RID: 14956 RVA: 0x000CCE61 File Offset: 0x000CB061
			[SecurityCritical]
			public object GetData(string name)
			{
				if (!this.IsNull)
				{
					return this.m_ctx.GetData(name);
				}
				return null;
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06003A6D RID: 14957 RVA: 0x000CCE79 File Offset: 0x000CB079
			public object HostContext
			{
				get
				{
					if (!this.IsNull)
					{
						return this.m_ctx.HostContext;
					}
					return null;
				}
			}

			// Token: 0x04002656 RID: 9814
			private LogicalCallContext m_ctx;
		}
	}
}
