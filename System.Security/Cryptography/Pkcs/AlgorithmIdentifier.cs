using System;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" /> определяет алгоритм, используемый в операции шифрования.</summary>
	// Token: 0x02000068 RID: 104
	public sealed class AlgorithmIdentifier
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.AlgorithmIdentifier.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" />, используя набор параметров по умолчанию.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x06000375 RID: 885 RVA: 0x00010DE6 File Offset: 0x0000EFE6
		public AlgorithmIdentifier() : this(Oid.FromOidValue("1.2.840.113549.3.7", OidGroup.EncryptionAlgorithm), 0)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.AlgorithmIdentifier.#ctor(System.Security.Cryptography.Oid)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" />, используя указанный идентификатор алгоритма.</summary>
		/// <param name="oid">Объект, идентифицирующий алгоритм.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x06000376 RID: 886 RVA: 0x00010DFA File Offset: 0x0000EFFA
		public AlgorithmIdentifier(Oid oid) : this(oid, 0)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.AlgorithmIdentifier.#ctor(System.Security.Cryptography.Oid,System.Int32)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" />, используя указанные идентификатор алгоритма и длину ключа.</summary>
		/// <param name="oid">Объект, идентифицирующий алгоритм.</param>
		/// <param name="keyLength">Длина ключа в битах.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x06000377 RID: 887 RVA: 0x00010E04 File Offset: 0x0000F004
		public AlgorithmIdentifier(Oid oid, int keyLength)
		{
			this.Oid = oid;
			this.KeyLength = keyLength;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.AlgorithmIdentifier.Oid" /> задает или получает объект <see cref="T:System.Security.Cryptography.Oid" />, который определяет идентификатор объекта для алгоритма.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Oid" />, представляющий алгоритм.</returns>
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00010E25 File Offset: 0x0000F025
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00010E2D File Offset: 0x0000F02D
		public Oid Oid { get; set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.AlgorithmIdentifier.KeyLength" /> устанавливает или возвращает длину ключа в битах. Это свойство не используется для алгоритмов с ключом фиксированной длины.</summary>
		/// <returns>Целочисленное значение, представляющее длину ключа в битах.</returns>
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00010E36 File Offset: 0x0000F036
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00010E3E File Offset: 0x0000F03E
		public int KeyLength { get; set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.AlgorithmIdentifier.Parameters" /> устанавливает или возвращает все параметры, необходимые для работы алгоритма.</summary>
		/// <returns>Массив байтовых значений, определяющий все параметры, необходимые для работы алгоритма.</returns>
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00010E47 File Offset: 0x0000F047
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00010E4F File Offset: 0x0000F04F
		public byte[] Parameters { get; set; } = Array.Empty<byte>();
	}
}
