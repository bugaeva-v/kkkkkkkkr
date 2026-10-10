using System;

namespace System.Security.Cryptography
{
	/// <summary>Определяет методы, позволяющие классу <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> перечислять данные о контейнерах ключей и импортировать или экспортировать BLOB-объекты ключей, совместимые с API шифрования (Майкрософт) (CAPI).</summary>
	// Token: 0x02000467 RID: 1127
	public interface ICspAsymmetricAlgorithm
	{
		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" />, в котором содержатся дополнительные сведения о паре криптографических ключей.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" />, в котором содержатся дополнительные сведения о паре криптографических ключей.</returns>
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002DCF RID: 11727
		CspKeyContainerInfo CspKeyContainerInfo { get; }

		/// <summary>Экспортирует большой двоичный объект, в котором содержатся данные ключа, связанные с объектом <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />.</summary>
		/// <param name="includePrivateParameters">Значение <see langword="true" /> для включения закрытого ключа; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив байтов, в котором содержатся основные сведения, связанные с объектом <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />.</returns>
		// Token: 0x06002DD0 RID: 11728
		byte[] ExportCspBlob(bool includePrivateParameters);

		/// <summary>Импортирует большой двоичный объект, представляющий сведения об асимметричном ключе.</summary>
		/// <param name="rawData">Массив байтов, представляющий большой двоичный объект асимметричного ключа.</param>
		// Token: 0x06002DD1 RID: 11729
		void ImportCspBlob(byte[] rawData);
	}
}
