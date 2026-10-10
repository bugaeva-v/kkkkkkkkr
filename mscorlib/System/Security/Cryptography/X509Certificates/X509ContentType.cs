using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает формат сертификата X.509.</summary>
	// Token: 0x020004D7 RID: 1239
	public enum X509ContentType
	{
		/// <summary>Неизвестный сертификат X.509.</summary>
		// Token: 0x04002288 RID: 8840
		Unknown,
		/// <summary>Единый сертификат X.509.</summary>
		// Token: 0x04002289 RID: 8841
		Cert,
		/// <summary>Единый сериализованный сертификат X.509.</summary>
		// Token: 0x0400228A RID: 8842
		SerializedCert,
		/// <summary>Сертификат в формате PFX. Значение <see langword="Pfx" /> идентично значению <see langword="Pkcs12" />.</summary>
		// Token: 0x0400228B RID: 8843
		Pfx,
		/// <summary>Сертификат в формате PKCS 12. Значение <see langword="Pkcs12" /> идентично значению <see langword="Pfx" />.</summary>
		// Token: 0x0400228C RID: 8844
		Pkcs12 = 3,
		/// <summary>Сериализованное хранилище.</summary>
		// Token: 0x0400228D RID: 8845
		SerializedStore,
		/// <summary>Сертификат в формате PKCS 7.</summary>
		// Token: 0x0400228E RID: 8846
		Pkcs7,
		/// <summary>Сертификат Authenticode X.509.</summary>
		// Token: 0x0400228F RID: 8847
		Authenticode
	}
}
