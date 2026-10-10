using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security
{
	/// <summary>Выбирает локальный сертификат SSL, используемый для проверки подлинности.</summary>
	/// <param name="sender">Объект, содержащий сведения о состоянии для данной проверки.</param>
	/// <param name="targetHost">Сервер, указанный клиентом.</param>
	/// <param name="localCertificates">Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, содержащая локальные сертификаты.</param>
	/// <param name="remoteCertificate">Сертификат, используемый для проверки подлинности удаленной стороны.</param>
	/// <param name="acceptableIssuers">Массив элементов <see cref="T:System.String" />, определяющий поставщиков сертификатов, приемлемых для удаленной стороны.</param>
	/// <returns>Сертификат <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, используемый для установки SSL-соединения.</returns>
	// Token: 0x0200085A RID: 2138
	// (Invoke) Token: 0x060043FF RID: 17407
	public delegate X509Certificate LocalCertificateSelectionCallback(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
}
