using System;

namespace System.Data.SqlClient
{
	/// <summary>Описывает различные методы проверки подлинности SQL, которые могут использоваться в клиентском подключении к базе данных SQL Azure. Дополнительные сведения см. в разделе Подключение к базе данных SQL с использованием проверки подлинности Azure Active Directory.</summary>
	// Token: 0x02000284 RID: 644
	public enum SqlAuthenticationMethod
	{
		/// <summary>Этот метод проверки подлинности не поддерживается.</summary>
		// Token: 0x040014B2 RID: 5298
		NotSpecified,
		/// <summary>Метод проверки подлинности —.пароль SQL.</summary>
		// Token: 0x040014B3 RID: 5299
		SqlPassword,
		/// <summary>Метод проверки подлинности использует пароль Active Directory. Используйте пароль Active Directory для подключения к базе данных SQL с помощью имени и пароля участника-пользователя Azure AD.</summary>
		// Token: 0x040014B4 RID: 5300
		ActiveDirectoryPassword,
		/// <summary>Метод проверки подлинности использует интегрированные службы Active Directory. Используйте интегрированные службы Active Directory для подключения к базе данных SQL с помощью встроенной проверки подлинности Windows.</summary>
		// Token: 0x040014B5 RID: 5301
		ActiveDirectoryIntegrated,
		/// <summary>Метод проверки подлинности использует интерактивные службы Active Directory. Доступно с версии .NET Framework 4.7.2.</summary>
		// Token: 0x040014B6 RID: 5302
		ActiveDirectoryInteractive
	}
}
