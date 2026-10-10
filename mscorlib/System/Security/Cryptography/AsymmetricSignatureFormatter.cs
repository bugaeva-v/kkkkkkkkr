using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет базовый класс, от которого наследуются все реализации асимметричного форматирования подписи.</summary>
	// Token: 0x0200047C RID: 1148
	[ComVisible(true)]
	public abstract class AsymmetricSignatureFormatter
	{
		/// <summary>При переопределении в производном классе задает асимметричный алгоритм, используемый для создания подписи.</summary>
		/// <param name="key">Экземпляр реализации <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> для использования при создании подписи.</param>
		// Token: 0x06002E72 RID: 11890
		public abstract void SetKey(AsymmetricAlgorithm key);

		/// <summary>При переопределении в производном классе задает хэш-алгоритм, используемый для создания подписи.</summary>
		/// <param name="strName">Имя хэш-алгоритма для создания подписи.</param>
		// Token: 0x06002E73 RID: 11891
		public abstract void SetHashAlgorithm(string strName);

		/// <summary>Создает подпись из указанного хэш-значения.</summary>
		/// <param name="hash">Хэш-алгоритм, который следует использовать для создания подписи.</param>
		/// <returns>Подпись для указанного хэш-значения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hash" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002E74 RID: 11892 RVA: 0x000A6262 File Offset: 0x000A4462
		public virtual byte[] CreateSignature(HashAlgorithm hash)
		{
			if (hash == null)
			{
				throw new ArgumentNullException("hash");
			}
			this.SetHashAlgorithm(hash.ToString());
			return this.CreateSignature(hash.Hash);
		}

		/// <summary>При переопределении в производном классе создает подпись для указанных данных.</summary>
		/// <param name="rgbHash">Данные, которые должны быть подписаны.</param>
		/// <returns>Цифровая подпись для параметра <paramref name="rgbHash" />.</returns>
		// Token: 0x06002E75 RID: 11893
		public abstract byte[] CreateSignature(byte[] rgbHash);
	}
}
