using System;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Перечисление <see cref="T:System.Security.Cryptography.Pkcs.KeyAgreeKeyChoice" /> определяет тип ключа, используемый в протоколе согласования ключей.</summary>
	// Token: 0x0200008D RID: 141
	public enum KeyAgreeKeyChoice
	{
		/// <summary>Тип ключа при согласовании ключей неизвестен.</summary>
		// Token: 0x040002D0 RID: 720
		Unknown,
		/// <summary>При согласовании ключей используется временный ключ, который существует только во время согласования.</summary>
		// Token: 0x040002D1 RID: 721
		EphemeralKey,
		/// <summary>При согласовании ключей используется статический ключ, который существует в течение продолжительного времени.</summary>
		// Token: 0x040002D2 RID: 722
		StaticKey
	}
}
