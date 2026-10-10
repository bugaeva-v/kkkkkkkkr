using System;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Перечисление <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" /> определяет типы идентификаторов субъекта.</summary>
	// Token: 0x0200008C RID: 140
	public enum SubjectIdentifierType
	{
		/// <summary>Тип идентификатора субъекта неизвестен.</summary>
		// Token: 0x040002CB RID: 715
		Unknown,
		/// <summary>Субъект определяется по поставщику и серийному номеру сертификата.</summary>
		// Token: 0x040002CC RID: 716
		IssuerAndSerialNumber,
		/// <summary>Субъект определяется по хэшу отрытого ключа субъекта. Хэш-алгоритм определяется набором алгоритмов подписи в сертификате субъекта.</summary>
		// Token: 0x040002CD RID: 717
		SubjectKeyIdentifier,
		/// <summary>Субъект определяется как принимающий участие в операции проверки целостности, при которой используется только хэш-алгоритм.</summary>
		// Token: 0x040002CE RID: 718
		NoSignature
	}
}
