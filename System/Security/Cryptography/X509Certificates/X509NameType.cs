using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает тип имени, содержащегося в сертификате X509.</summary>
	// Token: 0x020002C6 RID: 710
	public enum X509NameType
	{
		/// <summary>Простое имя субъекта или поставщика сертификата X509.</summary>
		// Token: 0x04000CB3 RID: 3251
		SimpleName,
		/// <summary>Адрес электронной почты субъекта или поставщика сертификата X509.</summary>
		// Token: 0x04000CB4 RID: 3252
		EmailName,
		/// <summary>Имя участника-пользователя (UPN) субъекта или поставщика сертификата X509.</summary>
		// Token: 0x04000CB5 RID: 3253
		UpnName,
		/// <summary>DNS-имя, связанное с альтернативным именем субъекта или поставщика сертификата X509.</summary>
		// Token: 0x04000CB6 RID: 3254
		DnsName,
		/// <summary>DNS-имя, связанное с альтернативным именем субъекта или поставщика сертификата X509.  Это значение эквивалентно значению <see cref="F:System.Security.Cryptography.X509Certificates.X509NameType.DnsName" />.</summary>
		// Token: 0x04000CB7 RID: 3255
		DnsFromAlternativeName,
		/// <summary>URL-адрес, связанный с альтернативным именем субъекта или поставщика сертификата X509.</summary>
		// Token: 0x04000CB8 RID: 3256
		UrlName
	}
}
