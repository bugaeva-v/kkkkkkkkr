using System;

namespace System.Net
{
	/// <summary>Предоставляет базовый интерфейс проверки подлинности для модулей проверки подлинности, принадлежащих веб-клиенту.</summary>
	// Token: 0x020005D4 RID: 1492
	public interface IAuthenticationModule
	{
		/// <summary>Возвращает экземпляр класса <see cref="T:System.Net.Authorization" /> в ответ на запрос проверки подлинности, посылаемый с сервера.</summary>
		/// <param name="challenge">Запрос проверки подлинности, посылаемый сервером.</param>
		/// <param name="request">Экземпляр класса <see cref="T:System.Net.WebRequest" />, связанный с запросом.</param>
		/// <param name="credentials">Учетные данные, связанные с запросом.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Net.Authorization" />, содержащий сообщение авторизации для запроса или <see langword="null" />, если запрос не может быть обработан.</returns>
		// Token: 0x06003024 RID: 12324
		Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

		/// <summary>Возвращает экземпляр класса <see cref="T:System.Net.Authorization" /> для запроса проверки подлинности, посылаемого на сервер.</summary>
		/// <param name="request">Экземпляр класса <see cref="T:System.Net.WebRequest" />, связанный с запросом проверки подлинности.</param>
		/// <param name="credentials">Учетные данные, связанные с запросом проверки подлинности.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Net.Authorization" />, содержащий сообщение авторизации для запроса.</returns>
		// Token: 0x06003025 RID: 12325
		Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

		/// <summary>Получает значение, указывающее наличие поддержки предварительной проверки подлинности модулями проверки подлинности.</summary>
		/// <returns>Значение <see langword="true" />, если модули проверки подлинности поддерживают предварительную проверку подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06003026 RID: 12326
		bool CanPreAuthenticate { get; }

		/// <summary>Получает тип проверки подлинности, предоставляемый данным модулем проверки подлинности.</summary>
		/// <returns>Строка, показывающая тип проверки подлинности, предоставляемый данным модулем проверки подлинности.</returns>
		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06003027 RID: 12327
		string AuthenticationType { get; }
	}
}
