using System;

namespace System.Net.Http
{
	/// <summary>Указывает, каким образом предоставляются клиентские сертификаты.</summary>
	// Token: 0x02000013 RID: 19
	public enum ClientCertificateOption
	{
		/// <summary>Приложение вручную предоставляет клиентские сертификаты объектам <see cref="T:System.Net.Http.WebRequestHandler" />. Это значение по умолчанию.</summary>
		// Token: 0x0400004F RID: 79
		Manual,
		/// <summary>Объект <see cref="T:System.Net.Http.HttpClientHandler" /> будет пытаться предоставить все доступные клиентские сертификаты автоматически.</summary>
		// Token: 0x04000050 RID: 80
		Automatic
	}
}
