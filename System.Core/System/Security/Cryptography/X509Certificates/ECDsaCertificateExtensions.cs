using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>
	///         Предоставляет методы расширения для получения реализаций <see cref="T:System.Security.Cryptography.ECDsa" /> для открытых и закрытых ключей сертификата <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
	///       </summary>
	// Token: 0x02000063 RID: 99
	public static class ECDsaCertificateExtensions
	{
		/// <summary>
		///         Возвращает закрытый ключ <see cref="T:System.Security.Cryptography.ECDsa" /> из сертификата <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат.
		///         </param>
		/// <returns>
		///         Закрытый ключ или <see langword="null" />, если у сертификата отсутствует закрытый ключ ECDsa.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000221 RID: 545 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public static ECDsa GetECDsaPrivateKey(this X509Certificate2 certificate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Возвращает закрытый ключ <see cref="T:System.Security.Cryptography.ECDsa" /> из сертификата <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат.
		///         </param>
		/// <returns>
		///         Закрытый ключ или <see langword="null" />, если у сертификата отсутствует закрытый ключ ECDsa.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Дескриптор недействителен.
		///           </exception>
		// Token: 0x06000222 RID: 546 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public static ECDsa GetECDsaPublicKey(this X509Certificate2 certificate)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Объединяет закрытый ключ с открытым ключом сертификата <see cref="T:System.Security.Cryptography.ECDsa" /> для создания нового сертификата ECDSA.
		///       </summary>
		/// <param name="certificate">
		///           Сертификат ECDSA.
		///         </param>
		/// <param name="privateKey">
		///           Закрытый ключ ECDSA.
		///         </param>
		/// <returns>
		///         Новый сертификат ECDSA, свойству <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.HasPrivateKey" /> которого присвоено значение <see langword="true" />.
		///          Входной объект сертификата ECDSA не изменен.
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
		// Token: 0x06000223 RID: 547 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, ECDsa privateKey)
		{
			throw new NotImplementedException();
		}
	}
}
