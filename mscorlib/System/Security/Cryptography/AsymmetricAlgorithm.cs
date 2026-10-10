using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный базовый класс, от которого должны наследоваться все реализации алгоритмов асимметричного шифрования.</summary>
	// Token: 0x02000478 RID: 1144
	[ComVisible(true)]
	public abstract class AsymmetricAlgorithm : IDisposable
	{
		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />.</summary>
		// Token: 0x06002E4A RID: 11850 RVA: 0x000A615B File Offset: 0x000A435B
		public void Dispose()
		{
			this.Clear();
		}

		/// <summary>Освобождает все ресурсы, используемые классом <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />.</summary>
		// Token: 0x06002E4B RID: 11851 RVA: 0x000A6163 File Offset: 0x000A4363
		public void Clear()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> (при необходимости освобождает и управляемые ресурсы).</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002E4C RID: 11852 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Получает или задает размер модуля ключа (в битах), используемого алгоритмом асимметричного шифрования.</summary>
		/// <returns>Размер модуля ключа (в битах), используемого алгоритмом асимметричного шифрования.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый размер модуля ключа.</exception>
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000A6172 File Offset: 0x000A4372
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x000A617C File Offset: 0x000A437C
		public virtual int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				for (int i = 0; i < this.LegalKeySizesValue.Length; i++)
				{
					if (this.LegalKeySizesValue[i].SkipSize == 0)
					{
						if (this.LegalKeySizesValue[i].MinSize == value)
						{
							this.KeySizeValue = value;
							return;
						}
					}
					else
					{
						for (int j = this.LegalKeySizesValue[i].MinSize; j <= this.LegalKeySizesValue[i].MaxSize; j += this.LegalKeySizesValue[i].SkipSize)
						{
							if (j == value)
							{
								this.KeySizeValue = value;
								return;
							}
						}
					}
				}
				throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
			}
		}

		/// <summary>Возвращает размеры ключа, которые поддерживаются алгоритмом асимметричного шифрования.</summary>
		/// <returns>Массив, в котором содержатся размеры ключа, поддерживаемые алгоритмом асимметричного шифрования.</returns>
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000A620E File Offset: 0x000A440E
		public virtual KeySizes[] LegalKeySizes
		{
			get
			{
				return (KeySizes[])this.LegalKeySizesValue.Clone();
			}
		}

		/// <summary>При реализации в производном классе возвращает имя алгоритма подписи. В противном случае всегда создается исключение <see cref="T:System.NotImplementedException" />.</summary>
		/// <returns>Имя алгоритма подписи.</returns>
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual string SignatureAlgorithm
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>При переопределении в производном классе возвращает имя алгоритма обмена ключами. В противном случае создается исключение <see cref="T:System.NotImplementedException" />.</summary>
		/// <returns>Имя алгоритма обмена ключами.</returns>
		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual string KeyExchangeAlgorithm
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Создает криптографический объект по умолчанию, используемый для выполнения алгоритма асимметричного шифрования.</summary>
		/// <returns>Новый экземпляр <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" />, если параметры по умолчанию не были изменены с помощью элемента &lt;cryptoClass&gt;.</returns>
		// Token: 0x06002E52 RID: 11858 RVA: 0x000A6220 File Offset: 0x000A4420
		public static AsymmetricAlgorithm Create()
		{
			return AsymmetricAlgorithm.Create("System.Security.Cryptography.AsymmetricAlgorithm");
		}

		/// <summary>Создает экземпляр заданной реализации алгоритма асимметричного шифрования.</summary>
		/// <param name="algName">Реализация асимметричного алгоритма, которую требуется использовать. В следующей таблице представлены допустимые значения параметра <paramref name="algName" /> и алгоритмы, с которыми они сопоставляются.  
		///   Значение параметра 
		///   Инструменты 
		///   System.Security.Cryptography.AsymmetricAlgorithm 
		///  <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> RSA 
		///  <see cref="T:System.Security.Cryptography.RSA" /> System.Security.Cryptography.RSA 
		///  <see cref="T:System.Security.Cryptography.RSA" /> DSA 
		///  <see cref="T:System.Security.Cryptography.DSA" /> System.Security.Cryptography.DSA 
		///  <see cref="T:System.Security.Cryptography.DSA" /> ECDsa 
		///  <see cref="T:System.Security.Cryptography.ECDsa" /> ECDsaCng 
		///  <see cref="T:System.Security.Cryptography.ECDsaCng" /> System.Security.Cryptography.ECDsaCng 
		///  <see cref="T:System.Security.Cryptography.ECDsaCng" /> ECDH 
		///  <see cref="T:System.Security.Cryptography.ECDiffieHellman" /> ECDiffieHellman 
		///  <see cref="T:System.Security.Cryptography.ECDiffieHellman" /> ECDiffieHellmanCng 
		///  <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /> System.Security.Cryptography.ECDiffieHellmanCng 
		///  <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /></param>
		/// <returns>Новый экземпляр заданной реализации алгоритма асимметричного шифрования.</returns>
		// Token: 0x06002E53 RID: 11859 RVA: 0x000A622C File Offset: 0x000A442C
		public static AsymmetricAlgorithm Create(string algName)
		{
			return (AsymmetricAlgorithm)CryptoConfig.CreateFromName(algName);
		}

		/// <summary>Если переопределено в производном классе, восстанавливает объект <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> из XML-строки. В противном случае создается исключение <see cref="T:System.NotImplementedException" />.</summary>
		/// <param name="xmlString">XML-строка, используемая для восстановления объекта <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />.</param>
		// Token: 0x06002E54 RID: 11860 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual void FromXmlString(string xmlString)
		{
			throw new NotImplementedException();
		}

		/// <summary>Если переопределено в производном классе, создает и возвращает представление текущего объекта <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> в виде XML-строки. В противном случае создается исключение <see cref="T:System.NotImplementedException" />.</summary>
		/// <param name="includePrivateParameters">Значение <see langword="true" /> для включения закрытых параметров; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Кодировка XML-строки текущего объекта <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />.</returns>
		// Token: 0x06002E55 RID: 11861 RVA: 0x000479F8 File Offset: 0x00045BF8
		public virtual string ToXmlString(bool includePrivateParameters)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual byte[] ExportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual byte[] ExportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, PbeParameters pbeParameters)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual byte[] ExportPkcs8PrivateKey()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual byte[] ExportSubjectPublicKeyInfo()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual void ImportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual void ImportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual void ImportPkcs8PrivateKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual void ImportSubjectPublicKeyInfo(ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual bool TryExportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters, Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual bool TryExportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, PbeParameters pbeParameters, Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual bool TryExportPkcs8PrivateKey(Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual bool TryExportSubjectPublicKeyInfo(Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Представляет размер модуля ключа (в битах), используемого алгоритмом асимметричного шифрования.</summary>
		// Token: 0x0400212B RID: 8491
		protected int KeySizeValue;

		/// <summary>Задает размеры ключа, которые поддерживаются алгоритмом асимметричного шифрования.</summary>
		// Token: 0x0400212C RID: 8492
		protected KeySizes[] LegalKeySizesValue;
	}
}
