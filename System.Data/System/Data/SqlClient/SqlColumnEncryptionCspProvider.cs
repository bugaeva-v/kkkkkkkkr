using System;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Реализация поставщика хранилища CMK для использования поставщиков служб шифрования (CSP) на основе Microsoft CAPI в режиме Always Encrypted.</summary>
	// Token: 0x020003F3 RID: 1011
	public class SqlColumnEncryptionCspProvider : SqlColumnEncryptionKeyStoreProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlColumnEncryptionCspProvider" />.</summary>
		// Token: 0x06002FA3 RID: 12195 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlColumnEncryptionCspProvider()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Расшифровывает данное зашифрованное значение, используя асимметричный ключ, заданный путем к ключу, и алгоритм. Ключ должен иметь путь в формате [имя_поставщика]/KeyIdentifier и быть асимметричным, хранящимся в указанном поставщике CSP. Допустимым алгоритмом, используемым для шифрования и расшифровки CEK, является "RSA_OAEP".</summary>
		/// <param name="masterKeyPath">Путь к главному ключу.</param>
		/// <param name="encryptionAlgorithm">Алгоритм шифрования.</param>
		/// <param name="encryptedColumnEncryptionKey">Зашифрованный ключ шифрования столбца.</param>
		/// <returns>Расшифрованный ключ шифрования столбца.</returns>
		// Token: 0x06002FA4 RID: 12196 RVA: 0x00060C51 File Offset: 0x0005EE51
		public override byte[] DecryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] encryptedColumnEncryptionKey)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Шифрует конкретный ключ шифрования столбца в обычном тексте с помощью указанного алгоритма и асимметричного ключа, указанного в пути к ключу. Ключ должен иметь путь в формате [имя_поставщика]/KeyIdentifier и быть асимметричным, хранящимся в указанном поставщике CSP. Допустимым алгоритмом, используемым для шифрования и расшифровки CEK, является "RSA_OAEP".</summary>
		/// <param name="masterKeyPath">Путь к главному ключу.</param>
		/// <param name="encryptionAlgorithm">Алгоритм шифрования.</param>
		/// <param name="columnEncryptionKey">Зашифрованный ключ шифрования столбца.</param>
		/// <returns>Зашифрованный ключ шифрования столбца.</returns>
		// Token: 0x06002FA5 RID: 12197 RVA: 0x00060C51 File Offset: 0x0005EE51
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
		// Token: 0x06002FA6 RID: 12198 RVA: 0x00060C51 File Offset: 0x0005EE51
		public override byte[] SignColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Эта функция должна реализовываться соответствующими поставщиками хранилищ ключей. Эта функция должна использовать асимметричный ключ, который задается как путь к ключу, и подписывать метаданные главного ключа (masterKeyPath, allowEnclaveComputations, providerName).</summary>
		/// <param name="masterKeyPath">Полный путь к асимметричному ключу. Формат пути зависит от поставщика хранилища ключей.</param>
		/// <param name="allowEnclaveComputations">Логическое значение, указывающее, можно ли отправлять этот ключ в безопасный анклав.</param>
		/// <param name="signature">Подпись метаданных главного ключа.</param>
		/// <returns>Логическое значение, указывающее, могут ли быть подтверждены метаданные ключа на основе предоставленной подписи.</returns>
		// Token: 0x06002FA7 RID: 12199 RVA: 0x000CBB58 File Offset: 0x000C9D58
		public override bool VerifyColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations, byte[] signature)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>Постоянная строка для имени поставщика MSSQL_CSP_PROVIDER.</summary>
		// Token: 0x04001CBD RID: 7357
		public const string ProviderName = "MSSQL_CSP_PROVIDER";
	}
}
