using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>
	///         Предоставляет методы расширения для получения реализаций <see cref="T:System.Security.Cryptography.RSA" /> для открытых и закрытых ключей <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
	///       </summary>
	// Token: 0x02000064 RID: 100
	public static class RSACertificateExtensions
	{
		/// <summary>
		///         Получает закрытый ключ <see cref="T:System.Security.Cryptography.RSA" /> из сертификата <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат.
		///         </param>
		/// <returns>
		///         Закрытый ключ или <see langword="null" />, если у сертификата отсутствует закрытый ключ RSA.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000224 RID: 548 RVA: 0x000061EF File Offset: 0x000043EF
		public static RSA GetRSAPrivateKey(this X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (!certificate.HasPrivateKey)
			{
				return null;
			}
			return certificate.Impl.GetRSAPrivateKey();
		}

		/// <summary>
		///         Получает открытый ключ <see cref="T:System.Security.Cryptography.RSA" /> из <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат.
		///         </param>
		/// <returns>
		///         Открытый ключ или <see langword="null" />, если у сертификата отсутствует открытый ключ RSA.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Windows сообщает об ошибке.
		///              Дополнительные сведения см. в разделе, посвященном свойству <see cref="P:System.Exception.Message" />.
		///           </exception>
		// Token: 0x06000225 RID: 549 RVA: 0x00006214 File Offset: 0x00004414
		public static RSA GetRSAPublicKey(this X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			return certificate.PublicKey.Key as RSA;
		}

		/// <summary>
		///         Объединяет закрытый ключ с открытым ключом сертификата <see cref="T:System.Security.Cryptography.RSA" /> для создания нового сертификата RSA.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат RSA.
		///         </param>
		/// <param name="privateKey">
		///           Закрытый ключ RSA.
		///         </param>
		/// <returns>
		///         Новый сертификат RSA, свойству <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.HasPrivateKey" /> которого присвоено значение <see langword="true" />.
		///          Входной объект RSA сертификата не изменен.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="certificate" /> или <paramref name="privateKey" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             С сертификатом уже связан закрытый ключ.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Сертификат не имеет открытого ключа.
		///
		///             -или-
		///
		///             Заданный закрытый ключ не соответствует открытому ключу для указанного сертификата.
		///           </exception>
		// Token: 0x06000226 RID: 550 RVA: 0x00006234 File Offset: 0x00004434
		public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, RSA privateKey)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (privateKey == null)
			{
				throw new ArgumentNullException("privateKey");
			}
			return (X509Certificate2)certificate.Impl.CopyWithPrivateKey(privateKey).CreateCertificate();
		}
	}
}
