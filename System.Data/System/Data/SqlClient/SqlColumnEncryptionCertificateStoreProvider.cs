using System;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Реализация поставщика хранилища ключей для хранилища сертификатов Windows. Этот класс позволяет использовать сертификаты, находящиеся в хранилище сертификатов Windows, в качестве главных ключей столбца. Дополнительные сведения см. в разделе Always Encrypted.</summary>
	// Token: 0x020003F1 RID: 1009
	public class SqlColumnEncryptionCertificateStoreProvider : SqlColumnEncryptionKeyStoreProvider
	{
		/// <summary>Поставщик хранилища ключей для хранилища сертификатов Windows.</summary>
		// Token: 0x06002F99 RID: 12185 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public SqlColumnEncryptionCertificateStoreProvider()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Расшифровывает указанное зашифрованное значение ключа шифрования столбца. Зашифрованное значение должно быть зашифровано с помощью сертификата по указанному пути к ключу и с помощью указанного алгоритма. Формат пути к ключу должен быть следующим: Local Machine/My/&lt;отпечаток_сертификата&gt; или Current User/My/&lt;отпечаток_сертификата&gt;.</summary>
		/// <param name="masterKeyPath">Путь к главному ключу.</param>
		/// <param name="encryptionAlgorithm">Алгоритм шифрования. В настоящее время единственным допустимым значением является RSA_OAEP.</param>
		/// <param name="encryptedColumnEncryptionKey">Зашифрованный ключ шифрования столбца.</param>
		/// <returns>Возвращает <see cref="T:System.Byte" />.Расшифрованный ключ шифрования столбца.</returns>
		// Token: 0x06002F9A RID: 12186 RVA: 0x00060C51 File Offset: 0x0005EE51
		public override byte[] DecryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] encryptedColumnEncryptionKey)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Шифрует ключ шифрования столбца с помощью сертификата по указанному пути ключа и с помощью указанного алгоритма. Формат пути к ключу должен быть следующим: Local Machine/My/&lt;отпечаток_сертификата&gt; или Current User/My/&lt;отпечаток_сертификата&gt;.</summary>
		/// <param name="masterKeyPath">Путь к главному ключу.</param>
		/// <param name="encryptionAlgorithm">Алгоритм шифрования. В настоящее время единственным допустимым значением является RSA_OAEP.</param>
		/// <param name="columnEncryptionKey">Зашифрованный ключ шифрования столбца.</param>
		/// <returns>Возвращает <see cref="T:System.Byte" />.Зашифрованный ключ шифрования столбца.</returns>
		// Token: 0x06002F9B RID: 12187 RVA: 0x00060C51 File Offset: 0x0005EE51
		public override byte[] EncryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] columnEncryptionKey)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Создает цифровую подпись метаданных главного ключа столбца, используя главный ключ столбца, на который ссылается параметр <paramref name="masterKeyPath" />.</summary>
		/// <param name="masterKeyPath">Путь к главному ключу столбца.</param>
		/// <param name="allowEnclaveComputations">Значение <see langword="true" />, если главный ключ столбца поддерживает анклавные вычисления, иначе значение <see langword="false" />.</param>
		/// <returns>Подпись метаданных главного ключа столбца.</returns>
		// Token: 0x06002F9C RID: 12188 RVA: 0x00060C51 File Offset: 0x0005EE51
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
		// Token: 0x06002F9D RID: 12189 RVA: 0x000CBB20 File Offset: 0x000C9D20
		public override bool VerifyColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations, byte[] signature)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}

		/// <summary>Имя поставщика.</summary>
		// Token: 0x04001CBB RID: 7355
		public const string ProviderName = "MSSQL_CERTIFICATE_STORE";
	}
}
