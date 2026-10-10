using System;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>Задает режим заполнения и параметры для использования с операциями шифрования или расшифровки RSA.</summary>
	// Token: 0x02000473 RID: 1139
	public sealed class RSAEncryptionPadding : IEquatable<RSAEncryptionPadding>
	{
		/// <summary>Получает объект, представляющий стандарт шифрования PKCS #1.</summary>
		/// <returns>Объект, представляющий стандарт шифрования PKCS #1.</returns>
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x000A5E88 File Offset: 0x000A4088
		public static RSAEncryptionPadding Pkcs1
		{
			get
			{
				return RSAEncryptionPadding.s_pkcs1;
			}
		}

		/// <summary>Получает объект, представляющий стандарт шифрования OAEP с хэш-алгоритмом SHA1.</summary>
		/// <returns>Объект, представляющий стандарт шифрования OAEP с хэш-алгоритмом SHA1.</returns>
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x000A5E8F File Offset: 0x000A408F
		public static RSAEncryptionPadding OaepSHA1
		{
			get
			{
				return RSAEncryptionPadding.s_oaepSHA1;
			}
		}

		/// <summary>Получает объект, представляющий стандарт шифрования OAEP с хэш-алгоритмом SHA256.</summary>
		/// <returns>Объект, представляющий стандарт шифрования OAEP с хэш-алгоритмом SHA256.</returns>
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x000A5E96 File Offset: 0x000A4096
		public static RSAEncryptionPadding OaepSHA256
		{
			get
			{
				return RSAEncryptionPadding.s_oaepSHA256;
			}
		}

		/// <summary>Получает объект, представляющий стандарт шифрования OAEP с хэш-алгоритмом SHA-384.</summary>
		/// <returns>Объект, представляющий стандарт шифрования OAEP с хэш-алгоритмом SHA384.</returns>
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000A5E9D File Offset: 0x000A409D
		public static RSAEncryptionPadding OaepSHA384
		{
			get
			{
				return RSAEncryptionPadding.s_oaepSHA384;
			}
		}

		/// <summary>Получает объект, представляющий стандарт шифрования OAEP с хэш-алгоритмом SHA512.</summary>
		/// <returns>Объект, представляющий стандарт шифрования OAEP с хэш-алгоритмом SHA512.</returns>
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x000A5EA4 File Offset: 0x000A40A4
		public static RSAEncryptionPadding OaepSHA512
		{
			get
			{
				return RSAEncryptionPadding.s_oaepSHA512;
			}
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000A5EAB File Offset: 0x000A40AB
		private RSAEncryptionPadding(RSAEncryptionPaddingMode mode, HashAlgorithmName oaepHashAlgorithm)
		{
			this._mode = mode;
			this._oaepHashAlgorithm = oaepHashAlgorithm;
		}

		/// <summary>Создает новый экземпляр <see cref="T:System.Security.Cryptography.RSAEncryptionPadding" />, у которого <see cref="P:System.Security.Cryptography.RSAEncryptionPadding.Mode" /> — <see cref="F:System.Security.Cryptography.RSAEncryptionPaddingMode.Oaep" /> с указанным хэш-алгоритмом.</summary>
		/// <param name="hashAlgorithm">Хэш-алгоритм.</param>
		/// <returns>Объект, чей режим <see cref="P:System.Security.Cryptography.RSAEncryptionPadding.Mode" /> — <see cref="F:System.Security.Cryptography.RSAEncryptionPaddingMode.Oaep" /> с алгоритмом хеширования, заданным <paramref name="hashAlgorithm" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> — <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002E2D RID: 11821 RVA: 0x000A5EC1 File Offset: 0x000A40C1
		public static RSAEncryptionPadding CreateOaep(HashAlgorithmName hashAlgorithm)
		{
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw new ArgumentException(Environment.GetResourceString("The hash algorithm name cannot be null or empty."), "hashAlgorithm");
			}
			return new RSAEncryptionPadding(RSAEncryptionPaddingMode.Oaep, hashAlgorithm);
		}

		/// <summary>Получает режим заполнения, представленный этим экземпляром <see cref="T:System.Security.Cryptography.RSAEncryptionPadding" />.</summary>
		/// <returns>Режим заполнения.</returns>
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000A5EED File Offset: 0x000A40ED
		public RSAEncryptionPaddingMode Mode
		{
			get
			{
				return this._mode;
			}
		}

		/// <summary>Получает хэш-алгоритм, используемый в сочетании с режимом заполнения <see cref="F:System.Security.Cryptography.RSAEncryptionPaddingMode.Oaep" />. Если значение свойства <see cref="P:System.Security.Cryptography.RSAEncryptionPadding.Mode" /> не равно <see cref="F:System.Security.Cryptography.RSAEncryptionPaddingMode.Oaep" />, то <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" />.</summary>
		/// <returns>Хэш-алгоритм.</returns>
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x000A5EF5 File Offset: 0x000A40F5
		public HashAlgorithmName OaepHashAlgorithm
		{
			get
			{
				return this._oaepHashAlgorithm;
			}
		}

		/// <summary>Возвращает хэш-код данного объекта <see cref="T:System.Security.Cryptography.RSAEncryptionPadding" />.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x06002E30 RID: 11824 RVA: 0x000A5EFD File Offset: 0x000A40FD
		public override int GetHashCode()
		{
			return RSAEncryptionPadding.CombineHashCodes(this._mode.GetHashCode(), this._oaepHashAlgorithm.GetHashCode());
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00033E4B File Offset: 0x0003204B
		private static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		/// <summary>Определяет, равен ли текущий экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E32 RID: 11826 RVA: 0x000A5F26 File Offset: 0x000A4126
		public override bool Equals(object obj)
		{
			return this.Equals(obj as RSAEncryptionPadding);
		}

		/// <summary>Определяет, равен ли текущий экземпляр указанному объекту <see cref="T:System.Security.Cryptography.RSAEncryptionPadding" />.</summary>
		/// <param name="other">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="other" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E33 RID: 11827 RVA: 0x000A5F34 File Offset: 0x000A4134
		public bool Equals(RSAEncryptionPadding other)
		{
			return other != null && this._mode == other._mode && this._oaepHashAlgorithm == other._oaepHashAlgorithm;
		}

		/// <summary>Указывает, равны ли значения двух заданных объектов <see cref="T:System.Security.Cryptography.RSAEncryptionPadding" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <see langword="left" /> и <see langword="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E34 RID: 11828 RVA: 0x000A5F60 File Offset: 0x000A4160
		public static bool operator ==(RSAEncryptionPadding left, RSAEncryptionPadding right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		/// <summary>Указывает, равны ли значения двух заданных объектов <see cref="T:System.Security.Cryptography.RSAEncryptionPadding" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <see langword="left" /> и <see langword="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002E35 RID: 11829 RVA: 0x000A5F71 File Offset: 0x000A4171
		public static bool operator !=(RSAEncryptionPadding left, RSAEncryptionPadding right)
		{
			return !(left == right);
		}

		/// <summary>Возвращает строковое представление текущего экземпляра <see cref="T:System.Security.Cryptography.RSAEncryptionPadding" />.</summary>
		/// <returns>Строковое представление текущего объекта.</returns>
		// Token: 0x06002E36 RID: 11830 RVA: 0x000A5F7D File Offset: 0x000A417D
		public override string ToString()
		{
			return this._mode.ToString() + this._oaepHashAlgorithm.Name;
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x000173AD File Offset: 0x000155AD
		internal RSAEncryptionPadding()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002119 RID: 8473
		private static readonly RSAEncryptionPadding s_pkcs1 = new RSAEncryptionPadding(RSAEncryptionPaddingMode.Pkcs1, default(HashAlgorithmName));

		// Token: 0x0400211A RID: 8474
		private static readonly RSAEncryptionPadding s_oaepSHA1 = RSAEncryptionPadding.CreateOaep(HashAlgorithmName.SHA1);

		// Token: 0x0400211B RID: 8475
		private static readonly RSAEncryptionPadding s_oaepSHA256 = RSAEncryptionPadding.CreateOaep(HashAlgorithmName.SHA256);

		// Token: 0x0400211C RID: 8476
		private static readonly RSAEncryptionPadding s_oaepSHA384 = RSAEncryptionPadding.CreateOaep(HashAlgorithmName.SHA384);

		// Token: 0x0400211D RID: 8477
		private static readonly RSAEncryptionPadding s_oaepSHA512 = RSAEncryptionPadding.CreateOaep(HashAlgorithmName.SHA512);

		// Token: 0x0400211E RID: 8478
		private RSAEncryptionPaddingMode _mode;

		// Token: 0x0400211F RID: 8479
		private HashAlgorithmName _oaepHashAlgorithm;
	}
}
