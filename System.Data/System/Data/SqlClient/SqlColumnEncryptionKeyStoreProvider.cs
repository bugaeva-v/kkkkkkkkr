using System;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Базовый класс для всех поставщиков хранилища ключей. Настраиваемый поставщик должен наследовать от этого класса и переопределить свои функции-члены, а затем зарегистрируйте его с помощью SqlConnection.RegisterColumnEncryptionKeyStoreProviders(). Дополнительные сведения см. в разделе Always Encrypted.</summary>
	// Token: 0x020003EA RID: 1002
	public abstract class SqlColumnEncryptionKeyStoreProvider
	{
		/// <summary>Инициализирует новый экземпляр класса SqlColumnEncryptionKeyStoreProviderClass.</summary>
		// Token: 0x06002F6B RID: 12139 RVA: 0x000108A6 File Offset: 0x0000EAA6
		protected SqlColumnEncryptionKeyStoreProvider()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Расшифровывает указанное зашифрованное значение ключа шифрования столбца. Зашифрованное значение должно быть зашифровано с помощью главного ключа столбца с указанным путем к ключу и с помощью указанного алгоритма.</summary>
		/// <param name="masterKeyPath">Путь к главному ключу.</param>
		/// <param name="encryptionAlgorithm">Алгоритм шифрования.</param>
		/// <param name="encryptedColumnEncryptionKey">Зашифрованный ключ шифрования столбца.</param>
		/// <returns>Возвращает <see cref="T:System.Byte" />.Расшифрованный ключ шифрования столбца.</returns>
		// Token: 0x06002F6C RID: 12140
		public abstract byte[] DecryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] encryptedColumnEncryptionKey);

		/// <summary>Шифрует ключ шифрования столбца с помощью главного ключа столбца по указанному пути ключа и с помощью указанного алгоритма.</summary>
		/// <param name="masterKeyPath">Путь к главному ключу.</param>
		/// <param name="encryptionAlgorithm">Алгоритм шифрования.</param>
		/// <param name="columnEncryptionKey">Зашифрованный ключ шифрования столбца.</param>
		/// <returns>Возвращает <see cref="T:System.Byte" />.Зашифрованный ключ шифрования столбца.</returns>
		// Token: 0x06002F6D RID: 12141
		public abstract byte[] EncryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] columnEncryptionKey);

		/// <summary>При реализации в производном классе выполняет цифровую подпись метаданных главного ключа столбца, используя главный ключ столбца, на который ссылается параметр <paramref name="masterKeyPath" />. Входные значения, используемые для создания подписи должны задаваться значениями параметров <paramref name="masterKeyPath" /> и <paramref name="allowEnclaveComputations" />.</summary>
		/// <param name="masterKeyPath">Путь к главному ключу столбца.</param>
		/// <param name="allowEnclaveComputations">Значение <see langword="true" />, если главный ключ столбца поддерживает анклавные вычисления, иначе значение <see langword="false" />.</param>
		/// <returns>Подпись метаданных главного ключа столбца.</returns>
		/// <exception cref="T:System.NotImplementedException">Во всех случаях.</exception>
		// Token: 0x06002F6E RID: 12142 RVA: 0x00060C51 File Offset: 0x0005EE51
		public virtual byte[] SignColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>При реализации в производном классе этот метод должен проверять действительность указанной подписи для главного ключа столбца с указанным путем к ключу и заданным поведением анклава. Реализация по умолчанию вызывает исключение NotImplementedException.</summary>
		/// <param name="masterKeyPath">Путь к главному ключу столбца.</param>
		/// <param name="allowEnclaveComputations">Указывает, поддерживает ли главный ключ столбца анклавные вычисления.</param>
		/// <param name="signature">Подпись метаданных главного ключа столбца.</param>
		/// <returns>При реализации в производном классе этот метод должен возвращать значение true, если указанная подпись является действительной, или false в противном случае. Реализация по умолчанию вызывает исключение NotImplementedException.</returns>
		// Token: 0x06002F6F RID: 12143 RVA: 0x000CB998 File Offset: 0x000C9B98
		public virtual bool VerifyColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations, byte[] signature)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}
	}
}
