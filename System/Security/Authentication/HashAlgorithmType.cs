using System;

namespace System.Security.Authentication
{
	/// <summary>Определяет алгоритм, с помощью которого создаются коды проверки подлинности сообщений (MAC).</summary>
	// Token: 0x0200029E RID: 670
	public enum HashAlgorithmType
	{
		/// <summary>Хэширование не применяется.</summary>
		// Token: 0x04000BE1 RID: 3041
		None,
		/// <summary>Алгоритм хэширования Message Digest 5 (MD5).</summary>
		// Token: 0x04000BE2 RID: 3042
		Md5 = 32771,
		/// <summary>Алгоритм Secure Hashing Algorithm (SHA1).</summary>
		// Token: 0x04000BE3 RID: 3043
		Sha1,
		/// <summary>SHA-2 с длиной дайджеста 256 бит.</summary>
		// Token: 0x04000BE4 RID: 3044
		Sha256 = 32780,
		/// <summary>SHA-2 с длиной дайджеста 384 бит.</summary>
		// Token: 0x04000BE5 RID: 3045
		Sha384,
		/// <summary>SHA-2 с длиной дайджеста 512 бит.</summary>
		// Token: 0x04000BE6 RID: 3046
		Sha512
	}
}
