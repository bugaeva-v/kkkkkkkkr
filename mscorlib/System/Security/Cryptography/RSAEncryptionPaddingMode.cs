using System;

namespace System.Security.Cryptography
{
	/// <summary>Задает режим заполнения для использования с операциями шифрования или расшифровки RSA.</summary>
	// Token: 0x02000474 RID: 1140
	public enum RSAEncryptionPaddingMode
	{
		/// <summary>PKCS #1 v1.5</summary>
		// Token: 0x04002121 RID: 8481
		Pkcs1,
		/// <summary>Заполнение для оптимального асимметричного шифрования (заполнение OAEP).</summary>
		// Token: 0x04002122 RID: 8482
		Oaep
	}
}
