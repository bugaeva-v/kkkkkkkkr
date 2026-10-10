using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный базовый класс, от которого наследуются все реализации модуля асимметричного удаления формата подписи.</summary>
	// Token: 0x0200047B RID: 1147
	[ComVisible(true)]
	public abstract class AsymmetricSignatureDeformatter
	{
		/// <summary>При переопределении в производном классе задает открытый ключ для проверки подписи.</summary>
		/// <param name="key">Экземпляр реализации <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />, который содержит открытый ключ.</param>
		// Token: 0x06002E6D RID: 11885
		public abstract void SetKey(AsymmetricAlgorithm key);

		/// <summary>Если переопределено в производном классе, задает хэш-алгоритм для подтверждения подписи.</summary>
		/// <param name="strName">Имя хэш-алгоритма для подтверждения подписи.</param>
		// Token: 0x06002E6E RID: 11886
		public abstract void SetHashAlgorithm(string strName);

		/// <summary>Проверяет подпись из указанного хэш-значения.</summary>
		/// <param name="hash">Хэш-алгоритм, который следует использовать для проверки подписи.</param>
		/// <param name="rgbSignature">Подпись для проверки.</param>
		/// <returns>Значение <see langword="true" />, если подпись допустима для хэша; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hash" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002E6F RID: 11887 RVA: 0x000A6239 File Offset: 0x000A4439
		public virtual bool VerifySignature(HashAlgorithm hash, byte[] rgbSignature)
		{
			if (hash == null)
			{
				throw new ArgumentNullException("hash");
			}
			this.SetHashAlgorithm(hash.ToString());
			return this.VerifySignature(hash.Hash, rgbSignature);
		}

		/// <summary>При переопределении в производном классе проверяет подпись с использованием указанных данных.</summary>
		/// <param name="rgbHash">Данные, подписанные с помощью <paramref name="rgbSignature" />.</param>
		/// <param name="rgbSignature">Подпись, которую требуется проверить с использованием <paramref name="rgbHash" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="rgbSignature" /> совпадает с подписью, вычисленной с помощью указанного хэш-алгоритма и ключа для <paramref name="rgbHash" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E70 RID: 11888
		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
	}
}
