using System;

namespace System.Net.Security
{
	/// <summary>Определяет клиентские требования проверки подлинности и олицетворения при использовании класса <see cref="T:System.Net.WebRequest" /> и производных от него классов для запроса ресурса.</summary>
	// Token: 0x02000857 RID: 2135
	public enum AuthenticationLevel
	{
		/// <summary>Для клиента и для сервера проверка подлинности не требуется.</summary>
		// Token: 0x04002913 RID: 10515
		None,
		/// <summary>Клиент и сервер должны пройти проверку подлинности. Запрос не завершается неудачно, если сервер не прошел проверку подлинности. Чтобы определить, произошла ли взаимная проверка подлинности, следует проверить значение свойства <see cref="P:System.Net.WebResponse.IsMutuallyAuthenticated" />.</summary>
		// Token: 0x04002914 RID: 10516
		MutualAuthRequested,
		/// <summary>Клиент и сервер должны пройти проверку подлинности. Если сервер не прошел проверку подлинности, приложение получит исключение <see cref="T:System.IO.IOException" /> с внутренним исключением <see cref="T:System.Net.ProtocolViolationException" />, указывающим на неудачное завершение взаимной проверки подлинности.</summary>
		// Token: 0x04002915 RID: 10517
		MutualAuthRequired
	}
}
