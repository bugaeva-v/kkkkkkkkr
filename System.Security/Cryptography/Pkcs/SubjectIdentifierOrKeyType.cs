using System;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Перечисление <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierOrKeyType" /> определяет типы идентификаторов субъекта.</summary>
	// Token: 0x0200008B RID: 139
	public enum SubjectIdentifierOrKeyType
	{
		/// <summary>Тип неизвестен.</summary>
		// Token: 0x040002C6 RID: 710
		Unknown,
		/// <summary>Субъект определяется по поставщику и серийному номеру сертификата.</summary>
		// Token: 0x040002C7 RID: 711
		IssuerAndSerialNumber,
		/// <summary>Субъект определяется по хэшу ключа субъекта.</summary>
		// Token: 0x040002C8 RID: 712
		SubjectKeyIdentifier,
		/// <summary>Субъект определяется по хэшу открытого ключа.</summary>
		// Token: 0x040002C9 RID: 713
		PublicKeyInfo
	}
}
