using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Создает подпись <see cref="T:System.Security.Cryptography.DSA" />.</summary>
	// Token: 0x0200048D RID: 1165
	[ComVisible(true)]
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSASignatureFormatter" />.</summary>
		// Token: 0x06002EE4 RID: 12004 RVA: 0x000A77DE File Offset: 0x000A59DE
		public DSASignatureFormatter()
		{
			this._oid = CryptoConfig.MapNameToOID("SHA1");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSASignatureFormatter" /> с заданным ключом.</summary>
		/// <param name="key">Экземпляр <see cref="T:System.Security.Cryptography.DSA" />, в котором содержится ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002EE5 RID: 12005 RVA: 0x000A77F6 File Offset: 0x000A59F6
		public DSASignatureFormatter(AsymmetricAlgorithm key) : this()
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._dsaKey = (DSA)key;
		}

		/// <summary>Задает ключ, используемый объектом создания подписи <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		/// <param name="key">Экземпляр <see cref="T:System.Security.Cryptography.DSA" />, в котором содержится ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002EE6 RID: 12006 RVA: 0x000A7818 File Offset: 0x000A5A18
		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._dsaKey = (DSA)key;
		}

		/// <summary>Задает хэш-алгоритм для объекта создания подписи <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		/// <param name="strName">Имя хэш-алгоритма, используемого объектом создания подписи.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Параметр <paramref name="strName" /> не соответствует хэш-алгоритму <see cref="T:System.Security.Cryptography.SHA1" />.</exception>
		// Token: 0x06002EE7 RID: 12007 RVA: 0x000A7834 File Offset: 0x000A5A34
		public override void SetHashAlgorithm(string strName)
		{
			if (CryptoConfig.MapNameToOID(strName) != this._oid)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("This operation is not supported for this class."));
			}
		}

		/// <summary>Создает подпись <see cref="T:System.Security.Cryptography.DSA" /> PKCS 1 для указанных данных.</summary>
		/// <param name="rgbHash">Данные, которые должны быть подписаны.</param>
		/// <returns>Цифровая подпись для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rgbHash" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Значение идентификатора объекта — <see langword="null" />.  
		///
		/// или - 
		/// Значение ключа DSA — <see langword="null" />.</exception>
		// Token: 0x06002EE8 RID: 12008 RVA: 0x000A785C File Offset: 0x000A5A5C
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			if (rgbHash == null)
			{
				throw new ArgumentNullException("rgbHash");
			}
			if (this._oid == null)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Required object identifier (OID) cannot be found."));
			}
			if (this._dsaKey == null)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("No asymmetric key object has been associated with this formatter object."));
			}
			return this._dsaKey.CreateSignature(rgbHash);
		}

		// Token: 0x04002163 RID: 8547
		private DSA _dsaKey;

		// Token: 0x04002164 RID: 8548
		private string _oid;
	}
}
