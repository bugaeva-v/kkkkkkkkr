using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Проверяет подпись, созданную по алгоритму PKCS 1 v1.5 DSA (<see cref="T:System.Security.Cryptography.DSA" />).</summary>
	// Token: 0x0200048C RID: 1164
	[ComVisible(true)]
	public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSASignatureDeformatter" />.</summary>
		// Token: 0x06002EDF RID: 11999 RVA: 0x000A7712 File Offset: 0x000A5912
		public DSASignatureDeformatter()
		{
			this._oid = CryptoConfig.MapNameToOID("SHA1");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSASignatureDeformatter" /> с заданным ключом.</summary>
		/// <param name="key">Экземпляр DSA (<see cref="T:System.Security.Cryptography.DSA" />), в котором содержится ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002EE0 RID: 12000 RVA: 0x000A772A File Offset: 0x000A592A
		public DSASignatureDeformatter(AsymmetricAlgorithm key) : this()
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._dsaKey = (DSA)key;
		}

		/// <summary>Задает ключ, используемый объектом проверки подписи DSA (<see cref="T:System.Security.Cryptography.DSA" />).</summary>
		/// <param name="key">Экземпляр <see cref="T:System.Security.Cryptography.DSA" />, в котором содержится ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002EE1 RID: 12001 RVA: 0x000A774C File Offset: 0x000A594C
		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._dsaKey = (DSA)key;
		}

		/// <summary>Задает хэш-алгоритм для объекта проверки подписи DSA (<see cref="T:System.Security.Cryptography.DSA" />).</summary>
		/// <param name="strName">Имя хэш-алгоритма, который необходимо использовать для объекта проверки подписи.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Параметр <paramref name="strName" /> не соответствует хэш-алгоритму <see cref="T:System.Security.Cryptography.SHA1" />.</exception>
		// Token: 0x06002EE2 RID: 12002 RVA: 0x000A7768 File Offset: 0x000A5968
		public override void SetHashAlgorithm(string strName)
		{
			if (CryptoConfig.MapNameToOID(strName) != this._oid)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("This operation is not supported for this class."));
			}
		}

		/// <summary>Проверяет подпись DSA (<see cref="T:System.Security.Cryptography.DSA" />), созданную для данных.</summary>
		/// <param name="rgbHash">Данные, подписанные с помощью <paramref name="rgbSignature" />.</param>
		/// <param name="rgbSignature">Подпись, которую требуется проверить с использованием <paramref name="rgbHash" />.</param>
		/// <returns>Значение <see langword="true" />, если подпись данных верна; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rgbHash" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="rgbSignature" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Отсутствует ключ DSA.</exception>
		// Token: 0x06002EE3 RID: 12003 RVA: 0x000A7790 File Offset: 0x000A5990
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			if (rgbHash == null)
			{
				throw new ArgumentNullException("rgbHash");
			}
			if (rgbSignature == null)
			{
				throw new ArgumentNullException("rgbSignature");
			}
			if (this._dsaKey == null)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("No asymmetric key object has been associated with this formatter object."));
			}
			return this._dsaKey.VerifySignature(rgbHash, rgbSignature);
		}

		// Token: 0x04002161 RID: 8545
		private DSA _dsaKey;

		// Token: 0x04002162 RID: 8546
		private string _oid;
	}
}
