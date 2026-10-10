using System;

namespace System.Net.Security
{
	/// <summary>Перечисляет ошибки политики SSL.</summary>
	// Token: 0x0200085E RID: 2142
	[Flags]
	public enum SslPolicyErrors
	{
		/// <summary>Ошибки политики SSL отсутствуют.</summary>
		// Token: 0x04002926 RID: 10534
		None = 0,
		/// <summary>Сертификат недоступен.</summary>
		// Token: 0x04002927 RID: 10535
		RemoteCertificateNotAvailable = 1,
		/// <summary>Имя сертификата не соответствует.</summary>
		// Token: 0x04002928 RID: 10536
		RemoteCertificateNameMismatch = 2,
		/// <summary>Свойство <see cref="P:System.Security.Cryptography.X509Certificates.X509Chain.ChainStatus" /> возвратило непустой массив.</summary>
		// Token: 0x04002929 RID: 10537
		RemoteCertificateChainErrors = 4
	}
}
