using System;

namespace System.Net
{
	/// <summary>Предоставляет базовый интерфейс, помогающий реализовать доступ к прокси-серверу для класса <see cref="T:System.Net.WebRequest" />.</summary>
	// Token: 0x0200065B RID: 1627
	public interface IWebProxy
	{
		/// <summary>Возвращает URI, принадлежащий прокси-серверу.</summary>
		/// <param name="destination">Перечисление <see cref="T:System.Uri" />, указывающее тип требуемого интернет-ресурса.</param>
		/// <returns>Экземпляр <see cref="T:System.Uri" />, который содержит URI прокси-сервера, используемого для связи с <paramref name="destination" />.</returns>
		// Token: 0x0600335D RID: 13149
		Uri GetProxy(Uri destination);

		/// <summary>Указывает, что прокси-сервер не должен использоваться для заданного узла.</summary>
		/// <param name="host">Принадлежащий узлу идентификатор <see cref="T:System.Uri" /> для проверки использования прокси-сервера.</param>
		/// <returns>Значение <see langword="true" />, если прокси-сервер не должен использоваться для <paramref name="host" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600335E RID: 13150
		bool IsBypassed(Uri host);

		/// <summary>Учетные данные, передаваемые прокси-серверу для выполнения проверки подлинности.</summary>
		/// <returns>Экземпляр <see cref="T:System.Net.ICredentials" />, содержащий учетные данные, необходимые для проверки подлинности запроса к прокси-серверу.</returns>
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600335F RID: 13151
		// (set) Token: 0x06003360 RID: 13152
		ICredentials Credentials { get; set; }
	}
}
