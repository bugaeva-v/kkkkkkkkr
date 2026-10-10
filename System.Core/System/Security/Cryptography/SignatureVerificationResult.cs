using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Задает большинство кодов результата для проверки подписи.
	///       </summary>
	// Token: 0x02000373 RID: 883
	public enum SignatureVerificationResult
	{
		/// <summary>
		///         Удостоверение сборки, указанные в данных / asm: assemblyIdentity манифеста не совпадает с именем сборки в подписи Authenticode в данных и ds:signature или DS: KeyInfo или msrel:RelData или r: лицензии или r: grant / как: ManifestInformation или как: assemblyIdentity узла.
		///       </summary>
		// Token: 0x04000CE0 RID: 3296
		AssemblyIdentityMismatch = 1,
		/// <summary>
		///         Цифровая подпись объекта не была проверена.
		///       </summary>
		// Token: 0x04000CE1 RID: 3297
		BadDigest = -2146869232,
		/// <summary>
		///         Недопустимый формат подписи.
		///       </summary>
		// Token: 0x04000CE2 RID: 3298
		BadSignatureFormat = -2146762749,
		/// <summary>
		///         Расширение основных ограничений сертификата не были просмотрены.
		///       </summary>
		// Token: 0x04000CE3 RID: 3299
		BasicConstraintsNotObserved = -2146869223,
		/// <summary>
		///         Истек срок действия сертификата.
		///       </summary>
		// Token: 0x04000CE4 RID: 3300
		CertificateExpired = -2146762495,
		/// <summary>
		///         Сертификат был явно помечен как ненадежный пользователем.
		///       </summary>
		// Token: 0x04000CE5 RID: 3301
		CertificateExplicitlyDistrusted = -2146762479,
		/// <summary>
		///         Сертификат не найден или имеет пустое значение важных полей, таких как имя субъекта или поставщика.
		///       </summary>
		// Token: 0x04000CE6 RID: 3302
		CertificateMalformed = -2146762488,
		/// <summary>
		///         Сертификат не является доверенным явным образом.
		///       </summary>
		// Token: 0x04000CE7 RID: 3303
		CertificateNotExplicitlyTrusted = -2146762748,
		/// <summary>
		///         Сертификат был отозван.
		///       </summary>
		// Token: 0x04000CE8 RID: 3304
		CertificateRevoked = -2146762484,
		/// <summary>
		///         Сертификат не может использоваться для подписывания и проверки.
		///       </summary>
		// Token: 0x04000CE9 RID: 3305
		CertificateUsageNotAllowed = -2146762490,
		/// <summary>
		///         Не проверяет подпись строгого имени в <see cref="T:System.Security.Cryptography.X509Certificates.AuthenticodeSignatureInformation" /> объекта.
		///          Поскольку подпись строгого имени охватывает подпись Authenticode, злоумышленник может попытаться подменить подпись Authenticode подписью по своему выбору.
		///          Чтобы избежать этого, этот код ошибки возвращается, если строгое имя не удается проверить подмена части подписи строгого имени сделает его.
		///       </summary>
		// Token: 0x04000CEA RID: 3306
		ContainingSignatureInvalid = 2,
		/// <summary>
		///         Не удается построить цепочку.
		///       </summary>
		// Token: 0x04000CEB RID: 3307
		CouldNotBuildChain = -2146762486,
		/// <summary>
		///         Не удалось общие доверия сертификата.
		///       </summary>
		// Token: 0x04000CEC RID: 3308
		GenericTrustFailure,
		/// <summary>
		///         Сертификат имеет недопустимое имя.
		///          Имя не включены в список разрешенных или явно исключен.
		///       </summary>
		// Token: 0x04000CED RID: 3309
		InvalidCertificateName = -2146762476,
		/// <summary>
		///         Сертификат имеет недопустимую политику.
		///       </summary>
		// Token: 0x04000CEE RID: 3310
		InvalidCertificatePolicy = -2146762477,
		/// <summary>
		///         Сертификат имеет недопустимую роль.
		///       </summary>
		// Token: 0x04000CEF RID: 3311
		InvalidCertificateRole = -2146762493,
		/// <summary>
		///         Невозможно проверить подпись сертификата.
		///       </summary>
		// Token: 0x04000CF0 RID: 3312
		InvalidCertificateSignature = -2146869244,
		/// <summary>
		///         Сертификат имеет недопустимое назначение.
		///       </summary>
		// Token: 0x04000CF1 RID: 3313
		InvalidCertificateUsage = -2146762480,
		/// <summary>
		///         Одна из подписей счетчика является недопустимой.
		///       </summary>
		// Token: 0x04000CF2 RID: 3314
		InvalidCountersignature = -2146869245,
		/// <summary>
		///         Сертификат для подписи сообщения является недопустимым или не найден.
		///       </summary>
		// Token: 0x04000CF3 RID: 3315
		InvalidSignerCertificate = -2146869246,
		/// <summary>
		///         Сертификат был выдан после выдачи сертификата истек.
		///       </summary>
		// Token: 0x04000CF4 RID: 3316
		InvalidTimePeriodNesting = -2146762494,
		/// <summary>
		///         Подписи отметки времени или сертификат имеет неправильный формат или не могут быть проверены.
		///       </summary>
		// Token: 0x04000CF5 RID: 3317
		InvalidTimestamp = -2146869243,
		/// <summary>
		///         Является родительским для данного сертификата не выдавал этот дочерний сертификат.
		///       </summary>
		// Token: 0x04000CF6 RID: 3318
		IssuerChainingError = -2146762489,
		/// <summary>
		///         Отсутствует подпись.
		///       </summary>
		// Token: 0x04000CF7 RID: 3319
		MissingSignature = -2146762496,
		/// <summary>
		///         Нарушено ограничение длины цепочки сертификатов.
		///       </summary>
		// Token: 0x04000CF8 RID: 3320
		PathLengthConstraintViolated = -2146762492,
		/// <summary>
		///         Токен открытого ключа из манифеста удостоверения в данных / asm: узел не соответствует токен открытого ключа ключ, используемый для подписания манифеста.
		///       </summary>
		// Token: 0x04000CF9 RID: 3321
		PublicKeyTokenMismatch = 3,
		/// <summary>
		///         Имя издателя из данных / asmv2:publisherIdentity не соответствует имени субъекта сертификата подписи или хэша ключа издателя из одного узла publisherIdentity не соответствует хеш ключа сертификата подписи.
		///       </summary>
		// Token: 0x04000CFA RID: 3322
		PublisherMismatch,
		/// <summary>
		///         Сбой проверки отзыва.
		///       </summary>
		// Token: 0x04000CFB RID: 3323
		RevocationCheckFailure = -2146762482,
		/// <summary>
		///         При проверке отношений доверия произошла ошибка системного уровня.
		///       </summary>
		// Token: 0x04000CFC RID: 3324
		SystemError = -2146869247,
		/// <summary>
		///         В сертификате содержится Неизвестное расширение, отмечены как критические.
		///       </summary>
		// Token: 0x04000CFD RID: 3325
		UnknownCriticalExtension = -2146762491,
		/// <summary>
		///         Сертификат имеет неизвестный поставщик доверия.
		///       </summary>
		// Token: 0x04000CFE RID: 3326
		UnknownTrustProvider = -2146762751,
		/// <summary>
		///         Сертификат имеет Неизвестная операция проверки.
		///       </summary>
		// Token: 0x04000CFF RID: 3327
		UnknownVerificationAction,
		/// <summary>
		///         Цепочка сертификатов обработана правильно, но один из сертификатов ЦС не является доверенным для поставщика политики.
		///       </summary>
		// Token: 0x04000D00 RID: 3328
		UntrustedCertificationAuthority = -2146762478,
		/// <summary>
		///         Корневой сертификат не является доверенным.
		///       </summary>
		// Token: 0x04000D01 RID: 3329
		UntrustedRootCertificate = -2146762487,
		/// <summary>
		///         Тестовый корневой сертификат не является доверенным.
		///       </summary>
		// Token: 0x04000D02 RID: 3330
		UntrustedTestRootCertificate = -2146762483,
		/// <summary>
		///         Результат проверки: сертификат является допустимым.
		///       </summary>
		// Token: 0x04000D03 RID: 3331
		Valid = 0
	}
}
