using System;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Проверяет подпись PKCS #1 версии 1.5 <see cref="T:System.Security.Cryptography.RSA" />.</summary>
	// Token: 0x020004CD RID: 1229
	[ComVisible(true)]
	public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureDeformatter" />.</summary>
		// Token: 0x06003138 RID: 12600 RVA: 0x000B5DF5 File Offset: 0x000B3FF5
		public RSAPKCS1SignatureDeformatter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureDeformatter" /> с заданным ключом.</summary>
		/// <param name="key">Экземпляр класса <see cref="T:System.Security.Cryptography.RSA" />, который содержит открытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003139 RID: 12601 RVA: 0x000B5DFD File Offset: 0x000B3FFD
		public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
		{
			this.SetKey(key);
		}

		/// <summary>Задает хэш-алгоритм для подтверждения подписи.</summary>
		/// <param name="strName">Имя хэш-алгоритма для подтверждения подписи.</param>
		// Token: 0x0600313A RID: 12602 RVA: 0x000B5E0C File Offset: 0x000B400C
		public override void SetHashAlgorithm(string strName)
		{
			if (strName == null)
			{
				throw new ArgumentNullException("strName");
			}
			this.hashName = strName;
		}

		/// <summary>Задает открытый ключ, используемый для проверки подписи.</summary>
		/// <param name="key">Экземпляр класса <see cref="T:System.Security.Cryptography.RSA" />, который содержит открытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600313B RID: 12603 RVA: 0x000B5E23 File Offset: 0x000B4023
		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.rsa = (RSA)key;
		}

		/// <summary>Проверяет подпись PKCS #1 <see cref="T:System.Security.Cryptography.RSA" /> для указанных данных.</summary>
		/// <param name="rgbHash">Данные, подписанные с помощью <paramref name="rgbSignature" />.</param>
		/// <param name="rgbSignature">Подпись, которую требуется проверить с использованием <paramref name="rgbHash" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="rgbSignature" /> совпадает с подписью, вычисленной с помощью указанного хэш-алгоритма и ключа для <paramref name="rgbHash" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Ключ имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Хэш-алгоритм имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbHash" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="rgbSignature" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600313C RID: 12604 RVA: 0x000B5E40 File Offset: 0x000B4040
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			if (this.rsa == null)
			{
				throw new CryptographicUnexpectedOperationException(Locale.GetText("No public key available."));
			}
			if (this.hashName == null)
			{
				throw new CryptographicUnexpectedOperationException(Locale.GetText("Missing hash algorithm."));
			}
			if (rgbHash == null)
			{
				throw new ArgumentNullException("rgbHash");
			}
			if (rgbSignature == null)
			{
				throw new ArgumentNullException("rgbSignature");
			}
			return PKCS1.Verify_v15(this.rsa, this.hashName, rgbHash, rgbSignature);
		}

		// Token: 0x0400226D RID: 8813
		private RSA rsa;

		// Token: 0x0400226E RID: 8814
		private string hashName;
	}
}
