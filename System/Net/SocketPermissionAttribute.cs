using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Указывает действия по обеспечению безопасности для управления подключениями <see cref="T:System.Net.Sockets.Socket" />. Этот класс не наследуется.</summary>
	// Token: 0x020006B7 RID: 1719
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class SocketPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.SocketPermissionAttribute" /> заданным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="action" /> не является допустимым значением <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x06003750 RID: 14160 RVA: 0x000A97B6 File Offset: 0x000A79B6
		public SocketPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Возвращает или задает метод доступа к сети, разрешенный этим <see cref="T:System.Net.SocketPermissionAttribute" />.</summary>
		/// <returns>Строка, содержащая метод доступа к сети, разрешенный этим экземпляром <see cref="T:System.Net.SocketPermissionAttribute" />. Допустимыми значениями являются "Accept" и "Connect".</returns>
		/// <exception cref="T:System.ArgumentException">При попытке установить значение свойство <see cref="P:System.Net.SocketPermissionAttribute.Access" /> не равно <see langword="null" />. Чтобы задать несколько методов доступа, используйте дополнительный оператор объявления атрибута.</exception>
		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x000C2377 File Offset: 0x000C0577
		// (set) Token: 0x06003752 RID: 14162 RVA: 0x000C237F File Offset: 0x000C057F
		public string Access
		{
			get
			{
				return this.m_access;
			}
			set
			{
				if (this.m_access != null)
				{
					this.AlreadySet("Access");
				}
				this.m_access = value;
			}
		}

		/// <summary>Возвращает или задает DNS-имя или IP-адрес узла, указанные этим <see cref="T:System.Net.SocketPermissionAttribute" />.</summary>
		/// <returns>Строка, содержащая DNS-имя или IP-адрес узла, связанного с этим экземпляром <see cref="T:System.Net.SocketPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">При попытке установить значение свойство <see cref="P:System.Net.SocketPermissionAttribute.Host" /> не равно <see langword="null" />. Чтобы задать несколько узлов, используйте дополнительный оператор объявления атрибута.</exception>
		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x000C239B File Offset: 0x000C059B
		// (set) Token: 0x06003754 RID: 14164 RVA: 0x000C23A3 File Offset: 0x000C05A3
		public string Host
		{
			get
			{
				return this.m_host;
			}
			set
			{
				if (this.m_host != null)
				{
					this.AlreadySet("Host");
				}
				this.m_host = value;
			}
		}

		/// <summary>Возвращает или задает номер порта, связанного с данным <see cref="T:System.Net.SocketPermissionAttribute" />.</summary>
		/// <returns>Строка, содержащая номер порта, связанного с этим экземпляром <see cref="T:System.Net.SocketPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">При попытке установить значение свойство <see cref="P:System.Net.SocketPermissionAttribute.Port" /> равно <see langword="null" />. Чтобы задать несколько портов, используйте дополнительный оператор объявления атрибута.</exception>
		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06003755 RID: 14165 RVA: 0x000C23BF File Offset: 0x000C05BF
		// (set) Token: 0x06003756 RID: 14166 RVA: 0x000C23C7 File Offset: 0x000C05C7
		public string Port
		{
			get
			{
				return this.m_port;
			}
			set
			{
				if (this.m_port != null)
				{
					this.AlreadySet("Port");
				}
				this.m_port = value;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Net.TransportType" />, указанный этим <see cref="T:System.Net.SocketPermissionAttribute" />.</summary>
		/// <returns>Строка, которая содержит объект <see cref="T:System.Net.TransportType" />, связанный с этим объектом <see cref="T:System.Net.SocketPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">При попытке установить значение свойство <see cref="P:System.Net.SocketPermissionAttribute.Transport" /> не равно <see langword="null" />. Чтобы задать несколько типов транспорта, используйте дополнительный оператор объявления атрибута.</exception>
		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x000C23E3 File Offset: 0x000C05E3
		// (set) Token: 0x06003758 RID: 14168 RVA: 0x000C23EB File Offset: 0x000C05EB
		public string Transport
		{
			get
			{
				return this.m_transport;
			}
			set
			{
				if (this.m_transport != null)
				{
					this.AlreadySet("Transport");
				}
				this.m_transport = value;
			}
		}

		/// <summary>Создает и возвращает новый экземпляр класса <see cref="T:System.Net.SocketPermission" />.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Net.SocketPermission" />, соответствующий объявлению безопасности.</returns>
		/// <exception cref="T:System.ArgumentException">Одно или несколько из свойств <see cref="P:System.Net.SocketPermissionAttribute.Access" />, <see cref="P:System.Net.SocketPermissionAttribute.Host" />, <see cref="P:System.Net.SocketPermissionAttribute.Transport" /> или <see cref="P:System.Net.SocketPermissionAttribute.Port" /> текущего экземпляра равны <see langword="null" />.</exception>
		// Token: 0x06003759 RID: 14169 RVA: 0x000C2408 File Offset: 0x000C0608
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new SocketPermission(PermissionState.Unrestricted);
			}
			string text = string.Empty;
			if (this.m_access == null)
			{
				text += "Access, ";
			}
			if (this.m_host == null)
			{
				text += "Host, ";
			}
			if (this.m_port == null)
			{
				text += "Port, ";
			}
			if (this.m_transport == null)
			{
				text += "Transport, ";
			}
			if (text.Length > 0)
			{
				string text2 = Locale.GetText("The value(s) for {0} must be specified.");
				text = text.Substring(0, text.Length - 2);
				throw new ArgumentException(string.Format(text2, text));
			}
			int num = -1;
			NetworkAccess access;
			if (string.Compare(this.m_access, "Connect", true) == 0)
			{
				access = NetworkAccess.Connect;
			}
			else
			{
				if (string.Compare(this.m_access, "Accept", true) != 0)
				{
					throw new ArgumentException(string.Format(Locale.GetText("The parameter value for 'Access', '{1}, is invalid."), this.m_access));
				}
				access = NetworkAccess.Accept;
			}
			if (string.Compare(this.m_port, "All", true) != 0)
			{
				try
				{
					num = int.Parse(this.m_port);
				}
				catch
				{
					throw new ArgumentException(string.Format(Locale.GetText("The parameter value for 'Port', '{1}, is invalid."), this.m_port));
				}
				new IPEndPoint(1L, num);
			}
			TransportType transport;
			try
			{
				transport = (TransportType)Enum.Parse(typeof(TransportType), this.m_transport, true);
			}
			catch
			{
				throw new ArgumentException(string.Format(Locale.GetText("The parameter value for 'Transport', '{1}, is invalid."), this.m_transport));
			}
			SocketPermission socketPermission = new SocketPermission(PermissionState.None);
			socketPermission.AddPermission(access, transport, this.m_host, num);
			return socketPermission;
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x000C25AC File Offset: 0x000C07AC
		internal void AlreadySet(string property)
		{
			throw new ArgumentException(string.Format(Locale.GetText("The parameter '{0}' can be set only once."), property), property);
		}

		// Token: 0x04002039 RID: 8249
		private string m_access;

		// Token: 0x0400203A RID: 8250
		private string m_host;

		// Token: 0x0400203B RID: 8251
		private string m_port;

		// Token: 0x0400203C RID: 8252
		private string m_transport;
	}
}
