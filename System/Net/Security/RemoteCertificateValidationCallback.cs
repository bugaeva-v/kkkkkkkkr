using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security
{
	/// <summary>Проверяет удаленный сертификат SSL, используемый для проверки подлинности.</summary>
	/// <param name="sender">Объект, содержащий сведения о состоянии для данной проверки.</param>
	/// <param name="certificate">Сертификат, используемый для проверки подлинности удаленной стороны.</param>
	/// <param name="chain">Цепочка центров сертификации, связанная с удаленным сертификатом.</param>
	/// <param name="sslPolicyErrors">Одна или более ошибок, связанных с удаленным сертификатом.</param>
	/// <returns>Значение типа <see cref="T:System.Boolean" />, определяющее, принимается ли указанный сертификат для проверки подлинности.</returns>
	// Token: 0x0200085D RID: 2141
	// (Invoke) Token: 0x06004440 RID: 17472
	public delegate bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);
}
