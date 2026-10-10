using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает сертификаты X509 в цепочке, которые должны быть проверены для отзыва.</summary>
	// Token: 0x020002C7 RID: 711
	public enum X509RevocationFlag
	{
		/// <summary>Проверяется, не был ли отозван конечный сертификат.</summary>
		// Token: 0x04000CBA RID: 3258
		EndCertificateOnly,
		/// <summary>Проверяется, не была ли отозвана вся цепочка сертификатов.</summary>
		// Token: 0x04000CBB RID: 3259
		EntireChain,
		/// <summary>Вся цепочка, за исключением корневого сертификата, проверяется на отзыв сертификатов.</summary>
		// Token: 0x04000CBC RID: 3260
		ExcludeRoot
	}
}
