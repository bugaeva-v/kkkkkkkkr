using System;

namespace System.Security.Authentication
{
	/// <summary>Определяет возможные алгоритмы шифрования для класса <see cref="T:System.Net.Security.SslStream" />.</summary>
	// Token: 0x0200029C RID: 668
	public enum CipherAlgorithmType
	{
		/// <summary>Шифрование не применяется.</summary>
		// Token: 0x04000BD1 RID: 3025
		None,
		/// <summary>Шифрование не используется с алгоритмом шифрования Null.</summary>
		// Token: 0x04000BD2 RID: 3026
		Null = 24576,
		/// <summary>Алгоритм AES (Advanced Encryption Standard).</summary>
		// Token: 0x04000BD3 RID: 3027
		Aes = 26129,
		/// <summary>Алгоритм AES (Advanced Encryption Standard) со 128-разрядным ключом.</summary>
		// Token: 0x04000BD4 RID: 3028
		Aes128 = 26126,
		/// <summary>Алгоритм AES (Advanced Encryption Standard) со 192-разрядным ключом.</summary>
		// Token: 0x04000BD5 RID: 3029
		Aes192,
		/// <summary>Алгоритм AES (Advanced Encryption Standard) с 256-разрядным ключом.</summary>
		// Token: 0x04000BD6 RID: 3030
		Aes256,
		/// <summary>Алгоритм DES (Data Encryption Standard).</summary>
		// Token: 0x04000BD7 RID: 3031
		Des = 26113,
		/// <summary>Алгортим RC2 (Rivest's Code 2).</summary>
		// Token: 0x04000BD8 RID: 3032
		Rc2,
		/// <summary>Алгоритм RC4 (Rivest's Code 4).</summary>
		// Token: 0x04000BD9 RID: 3033
		Rc4 = 26625,
		/// <summary>Алгоритм Triple DES (Triple Data Encryption Standard).</summary>
		// Token: 0x04000BDA RID: 3034
		TripleDes = 26115
	}
}
