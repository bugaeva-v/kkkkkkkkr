using System;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Реализация поставщика хранилища CMK для использования Microsoft Cryptography API: Next Generation (CNG) с режимом Always Encrypted.</summary>
	// Token: 0x020003F2 RID: 1010
	public class SqlColumnEncryptionCngProvider : SqlColumnEncryptionKeyStoreProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlColumnEncryptionCngProvider" />.</summary>
		// Token: 0x06002F9E RID: 12190 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlColumnEncryptionCngProvider()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Расшифровывает данное зашифрованное значение, используя асимметричный ключ, заданный путем к ключу, и указанный алгоритм. Ключ должен иметь путь в формате [имя_поставщика]/KeyIdentifier и быть асимметричным, хранящимся в указанном поставщике хранилища ключей CNG. Допустимым алгоритмом, используемым для шифрования и расшифровки CEK, является "RSA_OAEP".</summary>
		/// <param name="masterKeyPath">Путь к главному ключу.</param>
		/// <param name="encryptionAlgorithm">Алгоритм шифрования.</param>
		/// <param name="encryptedColumnEncryptionKey">Зашифрованный ключ шифрования столбца.</param>
		/// <returns>Расшифрованный ключ шифрования столбца.</returns>
		// Token: 0x06002F9F RID: 12191 RVA: 0x00060C51 File Offset: 0x0005EE51
		public override byte[] DecryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] encryptedColumnEncryptionKey)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Шифрует конкретный ключ шифрования столбца в обычном тексте с помощью указанного алгоритма и асимметричного ключа, указанного в пути к ключу. Ключ должен иметь путь в формате [имя_поставщика]/KeyIdentifier и быть асимметричным, хранящимся в указанном поставщике хранилища ключей CNG. Допустимым алгоритмом, используемым для шифрования и расшифровки CEK, является "RSA_OAEP".</summary>
		/// <param name="masterKeyPath">Путь к главному ключу.</param>
		/// <param name="encryptionAlgorithm">Алгоритм шифрования.</param>
		/// <param name="columnEncryptionKey">Зашифрованный ключ шифрования столбца.</param>
		/// <returns>Зашифрованный ключ шифрования столбца.</returns>
		// Token: 0x06002FA0 RID: 12192 RVA: 0x00060C51 File Offset: 0x0005EE51
		public override byte[] EncryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] columnEncryptionKey)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Вызывает исключение <see cref="T:System.NotSupportedException" /> во всех случаях.</summary>
		/// <param name="masterKeyPath">Путь к главному ключу столбца. Формат пути зависит от поставщика хранилища ключей.</param>
		/// <param name="allowEnclaveComputations">Значение <see langword="true" />, если главный ключ столбца поддерживает анклавные вычисления, иначе значение <see langword="false" />.</param>
		/// <returns>Подпись метаданных главного ключа столбца.</returns>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06002FA1 RID: 12193 RVA: 0x00060C51 File Offset: 0x0005EE51
		public override byte[] SignColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Эта функция должна реализовываться соответствующими поставщиками хранилищ ключей. Эта функция должна использовать асимметричный ключ, который задается по пути к ключу, и подтверждать метаданные главного ключа (masterKeyPath, allowEnclaveComputations, providerName).</summary>
		/// <param name="masterKeyPath">Полный путь к асимметричному ключу. Формат пути зависит от поставщика хранилища ключей.</param>
		/// <param name="allowEnclaveComputations">Логическое значение, указывающее, может ли этот ключ передаваться в безопасный анклав.</param>
		/// <param name="signature">Подпись метаданных главного ключа.</param>
		/// <returns>Логическое значение, указывающее, могут ли быть подтверждены метаданные ключа на основе предоставленной подписи.</returns>
		// Token: 0x06002FA2 RID: 12194 RVA: 0x000CBB3C File Offset: 0x000C9D3C
		public override bool VerifyColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations, byte[] signature)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>Постоянная строка для имени поставщика MSSQL_CNG_STORE.</summary>
		// Token: 0x04001CBC RID: 7356
		public const string ProviderName = "MSSQL_CNG_STORE";
	}
}
