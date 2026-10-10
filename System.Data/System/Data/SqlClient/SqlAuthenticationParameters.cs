using System;
using System.Runtime.CompilerServices;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Представляет параметры проверки подлинности Active Directory, переданные драйвером поставщикам проверки подлинности.</summary>
	// Token: 0x020003ED RID: 1005
	public class SqlAuthenticationParameters
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlAuthenticationParameters" />, используя указанный метод проверки подлинности, имя сервера, имя базы данных, URI ресурса, URI центра, пользовательский идентификатор и имя для входа, пароль пользователя и идентификатор подключения.</summary>
		/// <param name="authenticationMethod">Одно из значений перечисления, указывающее метод проверки подлинности.</param>
		/// <param name="serverName">Имя сервера.</param>
		/// <param name="databaseName">Имя базы данных.</param>
		/// <param name="resource">URI ресурса.</param>
		/// <param name="authority">URI центра.</param>
		/// <param name="userId">Имя для входа или идентификатор пользователя.</param>
		/// <param name="password">Пароль пользователя.</param>
		/// <param name="connectionId">Идентификатор соединения.</param>
		// Token: 0x06002F81 RID: 12161 RVA: 0x000108A6 File Offset: 0x0000EAA6
		protected SqlAuthenticationParameters(SqlAuthenticationMethod authenticationMethod, string serverName, string databaseName, string resource, string authority, string userId, string password, Guid connectionId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает метод проверки подлинности.</summary>
		/// <returns>Метод проверки подлинности.</returns>
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x000CBA78 File Offset: 0x000C9C78
		public SqlAuthenticationMethod AuthenticationMethod
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return SqlAuthenticationMethod.NotSpecified;
			}
		}

		/// <summary>Получает URI центра.</summary>
		/// <returns>URI центра.</returns>
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x00060C51 File Offset: 0x0005EE51
		public string Authority
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает идентификатор соединения.</summary>
		/// <returns>Идентификатор соединения.</returns>
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x000CBA94 File Offset: 0x000C9C94
		public Guid ConnectionId
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(Guid);
			}
		}

		/// <summary>Получает имя базы данных.</summary>
		/// <returns>Имя базы данных.</returns>
		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x00060C51 File Offset: 0x0005EE51
		public string DatabaseName
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает пароль пользователя.</summary>
		/// <returns>Пароль пользователя.</returns>
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x00060C51 File Offset: 0x0005EE51
		public string Password
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает URI ресурса.</summary>
		/// <returns>URI ресурса.</returns>
		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x00060C51 File Offset: 0x0005EE51
		public string Resource
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает имя сервера.</summary>
		/// <returns>Имя сервера.</returns>
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x00060C51 File Offset: 0x0005EE51
		public string ServerName
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает имя для входа или идентификатор пользователя.</summary>
		/// <returns>Имя для входа или идентификатор пользователя.</returns>
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00060C51 File Offset: 0x0005EE51
		public string UserId
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}
	}
}
