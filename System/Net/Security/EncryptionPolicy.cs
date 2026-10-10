using System;

namespace System.Net.Security
{
	/// <summary>Используемое перечисление EncryptionPolicy.</summary>
	// Token: 0x02000859 RID: 2137
	public enum EncryptionPolicy
	{
		/// <summary>Требуется шифрование; шифр NULL запрещен.</summary>
		// Token: 0x0400291B RID: 10523
		RequireEncryption,
		/// <summary>Предпочтительно используется полное шифрование, но если сервер поддерживает, допустим и шифр NULL (без шифрования).</summary>
		// Token: 0x0400291C RID: 10524
		AllowNoEncryption,
		/// <summary>Допускается отсутствие шифрования и запроса использования шифра NULL, если вторая конечная точка может обработать шифр NULL.</summary>
		// Token: 0x0400291D RID: 10525
		NoEncryption
	}
}
