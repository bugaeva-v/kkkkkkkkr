using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Задает функцию формирования ключа, <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /> класс будет использоваться для преобразования секретного соглашения в ключевой материал.
	///       </summary>
	// Token: 0x0200036E RID: 878
	public enum ECDiffieHellmanKeyDerivationFunction
	{
		/// <summary>
		///         Хэш-алгоритм используется для формирования ключевого материала.
		///         <see cref="P:System.Security.Cryptography.ECDiffieHellmanCng.HashAlgorithm" /> Свойство задает имя алгоритма для использования.
		///          Если имя алгоритма не указан, <see cref="T:System.Security.Cryptography.SHA256" /> используется как алгоритм по умолчанию.
		///       </summary>
		// Token: 0x04000CDC RID: 3292
		Hash,
		/// <summary>
		///         Для формирования ключевого материала используется алгоритм хэширования-сообщения проверки подлинности кода (HMAC).
		///         <see cref="P:System.Security.Cryptography.ECDiffieHellmanCng.HmacKey" /> Свойство указывает ключ, используемый.
		///          Либо это свойство должно быть задано или <see cref="P:System.Security.Cryptography.ECDiffieHellmanCng.UseSecretAgreementAsHmacKey" /> должно быть присвоено свойству <see langword="true" />; в противном случае — <see cref="T:System.Security.Cryptography.CryptographicException" /> возникает при использовании <see cref="F:System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction.Hmac" />.
		///          Если заданы оба свойства, секретное соглашение используется в качестве ключа HMAC.
		///       </summary>
		// Token: 0x04000CDD RID: 3293
		Hmac,
		/// <summary>
		///         Для формирования ключевого материала используется протокол безопасности транспортного уровня (TLS).
		///         <see cref="P:System.Security.Cryptography.ECDiffieHellmanCng.Seed" /> И <see cref="P:System.Security.Cryptography.ECDiffieHellmanCng.Label" /> свойства должно быть задано, в противном случае — <see cref="T:System.Security.Cryptography.CryptographicException" /> возникает при использовании <see cref="F:System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction.Tls" />.
		///       </summary>
		// Token: 0x04000CDE RID: 3294
		Tls
	}
}
