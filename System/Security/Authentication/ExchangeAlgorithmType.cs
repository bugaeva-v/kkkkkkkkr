using System;

namespace System.Security.Authentication
{
	/// <summary>Задает алгоритм, используемый для создания ключей, которые совместно используются клиентом и сервером.</summary>
	// Token: 0x0200029D RID: 669
	public enum ExchangeAlgorithmType
	{
		/// <summary>Алгоритм обмена ключами не используется.</summary>
		// Token: 0x04000BDC RID: 3036
		None,
		/// <summary>Алгоритм обмена ключами Диффи-Хеллмана с использованием временного ключа.</summary>
		// Token: 0x04000BDD RID: 3037
		DiffieHellman = 43522,
		/// <summary>Алгоритм обмена открытыми ключами RSA.</summary>
		// Token: 0x04000BDE RID: 3038
		RsaKeyX = 41984,
		/// <summary>Алгоритм подписи открытых ключей RSA.</summary>
		// Token: 0x04000BDF RID: 3039
		RsaSign = 9216
	}
}
