using System;

namespace System.Net
{
	/// <summary>Определяет политику учетных данных, используемую для запросов, создаваемых с помощью <see cref="T:System.Net.WebRequest" /> и соответствующих производных классов.</summary>
	// Token: 0x0200069D RID: 1693
	public interface ICredentialPolicy
	{
		/// <summary>Возвращает объект <see cref="T:System.Boolean" />, который указывает, отправляются ли учетные данные клиента вместе с запросом ресурса, сделанного с помощью экземпляра класса <see cref="T:System.Net.WebRequest" />.</summary>
		/// <param name="challengeUri">Адрес <see cref="T:System.Uri" />, который получит этот запрос.</param>
		/// <param name="request">Запрос <see cref="T:System.Net.WebRequest" />, представляющий запрашиваемый ресурс.</param>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, которые будут отправлены с запросом, если этот метод возвращает значение <see langword="true" />.</param>
		/// <param name="authenticationModule">Модуль <see cref="T:System.Net.IAuthenticationModule" />, который будет выполнять проверку подлинности, если проверка подлинности является необходимой.</param>
		/// <returns>Если учетные данные отправлены с запросом, значение <see langword="true" />, если нет — значение <see langword="false" />.</returns>
		// Token: 0x06003641 RID: 13889
		bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authenticationModule);
	}
}
