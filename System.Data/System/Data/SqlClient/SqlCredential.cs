using System;
using System.Security;

namespace System.Data.SqlClient
{
	/// <summary>
	///   <see cref="T:System.Data.SqlClient.SqlCredential" /> обеспечивает более безопасный способ указания пароля для попытки входа с использованием проверки подлинности SQL Server.  
	/// <see cref="T:System.Data.SqlClient.SqlCredential" /> состоит из идентификатора пользователя и пароля, используемых для проверки подлинности SQL Server. Пароль в объекте <see cref="T:System.Data.SqlClient.SqlCredential" /> имеет тип <see cref="T:System.Security.SecureString" />.  
	/// <see cref="T:System.Data.SqlClient.SqlCredential" /> не может быть унаследован.  
	/// Проверка подлинности Windows (<see langword="Integrated Security = true" />) остается самым безопасным способом доступа к базе данных SQL Server.</summary>
	// Token: 0x02000282 RID: 642
	[Serializable]
	public sealed class SqlCredential
	{
		/// <summary>Создает объект типа <see cref="T:System.Data.SqlClient.SqlCredential" />.</summary>
		/// <param name="userId">Идентификатор пользователя.</param>
		/// <param name="password">Пароль; значение <see cref="T:System.Security.SecureString" />, помеченное как доступное только для чтения.  Передача параметра чтения/записи <see cref="T:System.Security.SecureString" /> создает <see cref="T:System.ArgumentException" />.</param>
		// Token: 0x06001E23 RID: 7715 RVA: 0x0008EF1C File Offset: 0x0008D11C
		public SqlCredential(string userId, SecureString password)
		{
			if (userId == null)
			{
				throw new ArgumentNullException("userId");
			}
			if (password == null)
			{
				throw new ArgumentNullException("password");
			}
			this.uid = userId;
			this.pwd = password;
		}

		/// <summary>Получает компонент ИД пользователя объекта <see cref="T:System.Data.SqlClient.SqlCredential" />.</summary>
		/// <returns>Компонент идентификатора пользователя объекта <see cref="T:System.Data.SqlClient.SqlCredential" /> объекта.</returns>
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0008EF59 File Offset: 0x0008D159
		public string UserId
		{
			get
			{
				return this.uid;
			}
		}

		/// <summary>Получает компонент пароля объекта <see cref="T:System.Data.SqlClient.SqlCredential" />.</summary>
		/// <returns>Компонент пароля объекта <see cref="T:System.Data.SqlClient.SqlCredential" /> объекта.</returns>
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x0008EF61 File Offset: 0x0008D161
		public SecureString Password
		{
			get
			{
				return this.pwd;
			}
		}

		// Token: 0x040014AC RID: 5292
		private string uid = "";

		// Token: 0x040014AD RID: 5293
		private SecureString pwd;
	}
}
