using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает режим для проверки отзыва сертификата X509.</summary>
	// Token: 0x020002C8 RID: 712
	public enum X509RevocationMode
	{
		/// <summary>Проверка отзыва сертификата не выполняется.</summary>
		// Token: 0x04000CBE RID: 3262
		NoCheck,
		/// <summary>Проверка выполняется с помощью списка отзыва сертификатов с подключением к сети.</summary>
		// Token: 0x04000CBF RID: 3263
		Online,
		/// <summary>Проверка выполняется с помощью кэшированного списка отзыва сертификатов (CRL).</summary>
		// Token: 0x04000CC0 RID: 3264
		Offline
	}
}
