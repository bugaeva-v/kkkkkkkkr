using System;
using System.Runtime.CompilerServices;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Представляет маркер проверки подлинности Active Directory.</summary>
	// Token: 0x020003EF RID: 1007
	public class SqlAuthenticationToken
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlAuthenticationToken" />.</summary>
		/// <param name="accessToken">Маркер доступа.</param>
		/// <param name="expiresOn">Время завершения действия маркера.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="accessToken" /> имеет значение <see langword="null" /> или является пустым.</exception>
		// Token: 0x06002F91 RID: 12177 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlAuthenticationToken(string accessToken, DateTimeOffset expiresOn)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает строку маркера.</summary>
		/// <returns>Строка маркера.</returns>
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x00060C51 File Offset: 0x0005EE51
		public string AccessToken
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает время завершения действия маркера.</summary>
		/// <returns>Время завершения действия маркера.</returns>
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x000CBACC File Offset: 0x000C9CCC
		public DateTimeOffset ExpiresOn
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(DateTimeOffset);
			}
		}
	}
}
