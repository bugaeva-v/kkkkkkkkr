using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Определяет тип хэш-алгоритма для использования с классом <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" />.</summary>
	// Token: 0x020002C9 RID: 713
	public enum X509SubjectKeyIdentifierHashAlgorithm
	{
		/// <summary>Идентификатор ключа субъекта (SKI) состоит из 160-разрядного хэша SHA-1 значения открытого ключа (исключая тег, длину и количество неиспользуемых разрядов).</summary>
		// Token: 0x04000CC2 RID: 3266
		Sha1,
		/// <summary>Идентификатор ключа субъекта (SKI) состоит из поля 4-разрядного типа со значением 0100, за которым следует не менее 60 значащих разрядов хэш-значения SHA-1 открытого ключа (исключая тег, длину и количество неиспользуемых разрядов двоичных строк).</summary>
		// Token: 0x04000CC3 RID: 3267
		ShortSha1,
		/// <summary>Идентификатор ключа субъекта (SKI) состоит из 160-разрядного хэш-значения SHA-1 закодированного открытого ключа (включая тег, длину и количество неиспользуемых разрядов).</summary>
		// Token: 0x04000CC4 RID: 3268
		CapiSha1
	}
}
