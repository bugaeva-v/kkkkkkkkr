using System;
using System.Security;

namespace System.Net
{
	/// <summary>Предоставляет учетные данные для схем проверки подлинности на основе пароля, таких как обычная или дайджест-проверка подлинности либо проверка подлинности NTLM или Kerberos.</summary>
	// Token: 0x020005FF RID: 1535
	public class NetworkCredential : ICredentials, ICredentialsByHost
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkCredential" />.</summary>
		// Token: 0x0600307E RID: 12414 RVA: 0x000A5779 File Offset: 0x000A3979
		public NetworkCredential() : this(string.Empty, string.Empty, string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkCredential" /> с заданными значениями пароля и имени пользователя.</summary>
		/// <param name="userName">Имя пользователя, связанное с учетными данными.</param>
		/// <param name="password">Пароль для имени пользователя, связанный с учетными данными.</param>
		// Token: 0x0600307F RID: 12415 RVA: 0x000A7051 File Offset: 0x000A5251
		public NetworkCredential(string userName, string password) : this(userName, password, string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkCredential" /> с заданными значениями пароля и имени пользователя.</summary>
		/// <param name="userName">Имя пользователя, связанное с учетными данными.</param>
		/// <param name="password">Пароль для имени пользователя, связанный с учетными данными.</param>
		/// <exception cref="T:System.NotSupportedException">Класс <see cref="T:System.Security.SecureString" /> не поддерживается данной платформой.</exception>
		// Token: 0x06003080 RID: 12416 RVA: 0x000A7060 File Offset: 0x000A5260
		public NetworkCredential(string userName, SecureString password) : this(userName, password, string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkCredential" /> с заданными значениями имени пользователя, пароля и домена.</summary>
		/// <param name="userName">Имя пользователя, связанное с учетными данными.</param>
		/// <param name="password">Пароль для имени пользователя, связанный с учетными данными.</param>
		/// <param name="domain">Домен, связанный с этими учетными данными.</param>
		// Token: 0x06003081 RID: 12417 RVA: 0x000A706F File Offset: 0x000A526F
		public NetworkCredential(string userName, string password, string domain)
		{
			this.UserName = userName;
			this.Password = password;
			this.Domain = domain;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkCredential" /> с заданными значениями имени пользователя, пароля и домена.</summary>
		/// <param name="userName">Имя пользователя, связанное с учетными данными.</param>
		/// <param name="password">Пароль для имени пользователя, связанный с учетными данными.</param>
		/// <param name="domain">Домен, связанный с этими учетными данными.</param>
		/// <exception cref="T:System.NotSupportedException">Класс <see cref="T:System.Security.SecureString" /> не поддерживается данной платформой.</exception>
		// Token: 0x06003082 RID: 12418 RVA: 0x000A708C File Offset: 0x000A528C
		public NetworkCredential(string userName, SecureString password, string domain)
		{
			this.UserName = userName;
			this.SecurePassword = password;
			this.Domain = domain;
		}

		/// <summary>Возвращает или задает имя пользователя, связанное с учетными данными.</summary>
		/// <returns>Имя пользователя, связанное с учетными данными.</returns>
		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x000A70A9 File Offset: 0x000A52A9
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x000A70B1 File Offset: 0x000A52B1
		public string UserName
		{
			get
			{
				return this.InternalGetUserName();
			}
			set
			{
				if (value == null)
				{
					this.m_userName = string.Empty;
					return;
				}
				this.m_userName = value;
			}
		}

		/// <summary>Возвращает или задает пароль для имени пользователя, связанного с учетными данными.</summary>
		/// <returns>Пароль пользователя, связанный с учетными данными. Если данный экземпляр <see cref="T:System.Net.NetworkCredential" /> инициализируется с параметром <paramref name="password" />, имеющим значение <see langword="null" />, свойство <see cref="P:System.Net.NetworkCredential.Password" /> вернет пустую строку.</returns>
		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x000A70C9 File Offset: 0x000A52C9
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x000A70D1 File Offset: 0x000A52D1
		public string Password
		{
			get
			{
				return this.InternalGetPassword();
			}
			set
			{
				this.m_password = UnsafeNclNativeMethods.SecureStringHelper.CreateSecureString(value);
			}
		}

		/// <summary>Получает или задает пароль в виде экземпляра <see cref="T:System.Security.SecureString" />.</summary>
		/// <returns>Пароль для имени пользователя, связанный с учетными данными.</returns>
		/// <exception cref="T:System.NotSupportedException">Класс <see cref="T:System.Security.SecureString" /> не поддерживается данной платформой.</exception>
		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x000A70DF File Offset: 0x000A52DF
		// (set) Token: 0x06003088 RID: 12424 RVA: 0x000A70EC File Offset: 0x000A52EC
		public SecureString SecurePassword
		{
			get
			{
				return this.InternalGetSecurePassword().Copy();
			}
			set
			{
				if (value == null)
				{
					this.m_password = new SecureString();
					return;
				}
				this.m_password = value.Copy();
			}
		}

		/// <summary>Возвращает или устанавливает имя домена или компьютера, проверяющего учетные данные.</summary>
		/// <returns>Имя домена, связанное с учетными данными.</returns>
		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x000A7109 File Offset: 0x000A5309
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x000A7111 File Offset: 0x000A5311
		public string Domain
		{
			get
			{
				return this.InternalGetDomain();
			}
			set
			{
				if (value == null)
				{
					this.m_domain = string.Empty;
					return;
				}
				this.m_domain = value;
			}
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x000A7129 File Offset: 0x000A5329
		internal string InternalGetUserName()
		{
			return this.m_userName;
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x000A7131 File Offset: 0x000A5331
		internal string InternalGetPassword()
		{
			return UnsafeNclNativeMethods.SecureStringHelper.CreateString(this.m_password);
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000A713E File Offset: 0x000A533E
		internal SecureString InternalGetSecurePassword()
		{
			return this.m_password;
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x000A7146 File Offset: 0x000A5346
		internal string InternalGetDomain()
		{
			return this.m_domain;
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x000A7150 File Offset: 0x000A5350
		internal string InternalGetDomainUserName()
		{
			string text = this.InternalGetDomain();
			if (text.Length != 0)
			{
				text += "\\";
			}
			return text + this.InternalGetUserName();
		}

		/// <summary>Возвращает экземпляр класса <see cref="T:System.Net.NetworkCredential" />, связанный с указанным URI и типом проверки подлинности.</summary>
		/// <param name="uri">URI, для получения доступа к которому клиент проходит проверку подлинности.</param>
		/// <param name="authType">Тип запрашиваемой проверки подлинности согласно его определению в свойстве <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" />.</param>
		/// <returns>Объект <see cref="T:System.Net.NetworkCredential" />.</returns>
		// Token: 0x06003090 RID: 12432 RVA: 0x000075E1 File Offset: 0x000057E1
		public NetworkCredential GetCredential(Uri uri, string authType)
		{
			return this;
		}

		/// <summary>Возвращает экземпляр класса <see cref="T:System.Net.NetworkCredential" /> для заданных узла, порта и типа проверки подлинности.</summary>
		/// <param name="host">узел, проверяющий подлинность клиента.</param>
		/// <param name="port">Порт на <paramref name="host" />, с которым клиент будет устанавливать связь.</param>
		/// <param name="authenticationType">Тип запрашиваемой проверки подлинности согласно его определению в свойстве <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" />.</param>
		/// <returns>Учетные данные <see cref="T:System.Net.NetworkCredential" /> для указанного узла, порта и протокола проверки подлинности или значение <see langword="null" />, если для указанных узла, порта и протокола проверки подлинности не определены учетные данные.</returns>
		// Token: 0x06003091 RID: 12433 RVA: 0x000075E1 File Offset: 0x000057E1
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			return this;
		}

		// Token: 0x04001C2E RID: 7214
		private string m_domain;

		// Token: 0x04001C2F RID: 7215
		private string m_userName;

		// Token: 0x04001C30 RID: 7216
		private SecureString m_password;
	}
}
