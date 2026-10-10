using System;

namespace System.Net
{
	/// <summary>Базовый интерфейс проверки подлинности для извлечения учетных данных с целью проверки подлинности веб-клиентов.</summary>
	// Token: 0x020005D6 RID: 1494
	public interface ICredentials
	{
		/// <summary>Возвращает объект <see cref="T:System.Net.NetworkCredential" />, связанный с заданными URI и типом проверки подлинности.</summary>
		/// <param name="uri">
		///   <see cref="T:System.Uri" />, для которого клиент предоставляет проверку подлинности.</param>
		/// <param name="authType">Тип проверки подлинности согласно его определению в свойстве <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" />.</param>
		/// <returns>Объект <see cref="T:System.Net.NetworkCredential" />, связанный с заданными URI и типом проверки подлинности, или <see langword="null" />, если учетные данные отсутствуют.</returns>
		// Token: 0x06003029 RID: 12329
		NetworkCredential GetCredential(Uri uri, string authType);
	}
}
