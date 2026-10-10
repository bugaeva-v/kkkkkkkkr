using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	/// <summary>Проверяет достоверность сертификата сервера.</summary>
	// Token: 0x020005D5 RID: 1493
	public interface ICertificatePolicy
	{
		/// <summary>Проверяет достоверность сертификата сервера.</summary>
		/// <param name="srvPoint">Класс <see cref="T:System.Net.ServicePoint" />, который будет использовать сертификат.</param>
		/// <param name="certificate">Сертификат, проверяемый на достоверность.</param>
		/// <param name="request">Запрос, получивший сертификат.</param>
		/// <param name="certificateProblem">Неполадка, возникшая при использовании сертификата.</param>
		/// <returns>Значение <see langword="true" />, если сертификат должен быть принят, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003028 RID: 12328
		bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
	}
}
