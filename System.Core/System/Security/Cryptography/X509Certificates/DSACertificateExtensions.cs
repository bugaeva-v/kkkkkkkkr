using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>
	///         Предоставляет методы расширения для получения реализаций <see cref="T:System.Security.Cryptography.DSA" /> для открытых и закрытых ключей <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
	///       </summary>
	// Token: 0x02000062 RID: 98
	public static class DSACertificateExtensions
	{
		/// <summary>
		///         Получает открытый ключ <see cref="T:System.Security.Cryptography.DSA" /> из <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат.
		///         </param>
		/// <returns>
		///         Открытый ключ или <see langword="null" />, если у сертификата отсутствует открытый ключ DSA.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Windows сообщает об ошибке.
		///              Дополнительные сведения см. в разделе, посвященном свойству <see cref="P:System.Exception.Message" />.
		///           </exception>
		// Token: 0x0600021E RID: 542 RVA: 0x00006191 File Offset: 0x00004391
		public static DSA GetDSAPublicKey(this X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			return certificate.PrivateKey as DSA;
		}

		/// <summary>
		///         Получает закрытый ключ <see cref="T:System.Security.Cryptography.DSA" /> из сертификата <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат.
		///         </param>
		/// <returns>
		///         Закрытый ключ или <see langword="null" />, если у сертификата отсутствует закрытый ключ DSA.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600021F RID: 543 RVA: 0x000061AC File Offset: 0x000043AC
		public static DSA GetDSAPrivateKey(this X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			return certificate.PublicKey.Key as DSA;
		}

		/// <summary>
		///         Объединяет закрытый ключ с открытым ключом сертификата <see cref="T:System.Security.Cryptography.DSA" /> для создания нового сертификата DSA.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат DSA.
		///         </param>
		/// <param name="privateKey">
		///           Закрытый ключ DSA.
		///         </param>
		/// <returns>
		///         Новый сертификат DSA, свойству <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.HasPrivateKey" /> которого присвоено значение <see langword="true" />.
		///          Входной объект сертификата DSA не изменен.
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
		// Token: 0x06000220 RID: 544 RVA: 0x000061CC File Offset: 0x000043CC
		[MonoTODO]
		public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, DSA privateKey)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (privateKey == null)
			{
				throw new ArgumentNullException("privateKey");
			}
			throw new NotImplementedException();
		}
	}
}
