using System;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Создает подпись <see cref="T:System.Security.Cryptography.RSA" /> PKCS 1 версии 1.5.</summary>
	// Token: 0x020004CE RID: 1230
	[ComVisible(true)]
	public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureFormatter" />.</summary>
		// Token: 0x0600313D RID: 12605 RVA: 0x000B5EAC File Offset: 0x000B40AC
		public RSAPKCS1SignatureFormatter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureFormatter" /> с заданным ключом.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится закрытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600313E RID: 12606 RVA: 0x000B5EB4 File Offset: 0x000B40B4
		public RSAPKCS1SignatureFormatter(AsymmetricAlgorithm key)
		{
			this.SetKey(key);
		}

		/// <summary>Создает подпись PKCS #1 <see cref="T:System.Security.Cryptography.RSA" /> для указанных данных.</summary>
		/// <param name="rgbHash">Данные, которые должны быть подписаны.</param>
		/// <returns>Цифровая подпись для <paramref name="rgbHash" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Ключ имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Хэш-алгоритм имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbHash" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600313F RID: 12607 RVA: 0x000B5EC4 File Offset: 0x000B40C4
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			if (this.rsa == null)
			{
				throw new CryptographicUnexpectedOperationException(Locale.GetText("No key pair available."));
			}
			if (this.hash == null)
			{
				throw new CryptographicUnexpectedOperationException(Locale.GetText("Missing hash algorithm."));
			}
			if (rgbHash == null)
			{
				throw new ArgumentNullException("rgbHash");
			}
			return PKCS1.Sign_v15(this.rsa, this.hash, rgbHash);
		}

		/// <summary>Задает хэш-алгоритм для создания подписи.</summary>
		/// <param name="strName">Имя хэш-алгоритма для создания подписи.</param>
		// Token: 0x06003140 RID: 12608 RVA: 0x000B5F21 File Offset: 0x000B4121
		public override void SetHashAlgorithm(string strName)
		{
			if (strName == null)
			{
				throw new ArgumentNullException("strName");
			}
			this.hash = strName;
		}

		/// <summary>Задает закрытый ключ, используемый для создания подписи.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится закрытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003141 RID: 12609 RVA: 0x000B5F38 File Offset: 0x000B4138
		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.rsa = (RSA)key;
		}

		// Token: 0x0400226F RID: 8815
		private RSA rsa;

		// Token: 0x04002270 RID: 8816
		private string hash;
	}
}
