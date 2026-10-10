using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>
	///         Идентифицирует уровень достоверности, назначенный подписи манифеста.
	///       </summary>
	// Token: 0x02000061 RID: 97
	public enum TrustStatus
	{
		/// <summary>
		///         Подпись создана явно доверяемый домен издателем.
		///       </summary>
		// Token: 0x0400036D RID: 877
		Untrusted,
		/// <summary>
		///         Удостоверение не известно, Недопустимая подпись.
		///          Так как отсутствует проверенная подпись, невозможно определить идентификацию.
		///       </summary>
		// Token: 0x0400036E RID: 878
		UnknownIdentity,
		/// <summary>
		///         Известная идентификация и подпись действительна.
		///          Действительная подпись Authenticode предоставляет удостоверение.
		///       </summary>
		// Token: 0x0400036F RID: 879
		KnownIdentity,
		/// <summary>
		///         Подпись действительна и была создана явно доверенным издателем.
		///       </summary>
		// Token: 0x04000370 RID: 880
		Trusted
	}
}
