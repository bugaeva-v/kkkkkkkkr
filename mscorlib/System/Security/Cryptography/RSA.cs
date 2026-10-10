using System;
using System.Buffers;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Util;
using System.Text;

namespace System.Security.Cryptography
{
	/// <summary>Представляет базовый класс, от которого наследуются все реализации алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
	// Token: 0x020004AA RID: 1194
	[ComVisible(true)]
	public abstract class RSA : AsymmetricAlgorithm
	{
		/// <summary>Создает экземпляр реализации алгоритма <see cref="T:System.Security.Cryptography.RSA" /> по умолчанию.</summary>
		/// <returns>Новый экземпляр реализации объекта <see cref="T:System.Security.Cryptography.RSA" /> по умолчанию.</returns>
		// Token: 0x06002FB3 RID: 12211 RVA: 0x000AD478 File Offset: 0x000AB678
		public new static RSA Create()
		{
			return RSA.Create("System.Security.Cryptography.RSA");
		}

		/// <summary>Создает экземпляр заданной реализации класса <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <param name="algName">Имя используемой реализации <see cref="T:System.Security.Cryptography.RSA" />.</param>
		/// <returns>Новый экземпляр заданной реализации класса <see cref="T:System.Security.Cryptography.RSA" />.</returns>
		// Token: 0x06002FB4 RID: 12212 RVA: 0x000AD484 File Offset: 0x000AB684
		public new static RSA Create(string algName)
		{
			return (RSA)CryptoConfig.CreateFromName(algName);
		}

		/// <summary>При переопределении в производном классе выполняет шифрование входных данных с использованием указанного режима заполнения.</summary>
		/// <param name="data">Данные, которые необходимо зашифровать.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Зашифрованные данные.</returns>
		/// <exception cref="T:System.NotImplementedException">Производный класс должен переопределять этот метод.</exception>
		// Token: 0x06002FB5 RID: 12213 RVA: 0x000AD491 File Offset: 0x000AB691
		public virtual byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			throw RSA.DerivedClassMustOverride();
		}

		/// <summary>При переопределении в производном классе выполняет расшифровку входных данных с использованием указанного режима заполнения.</summary>
		/// <param name="data">Расшифровываемые данные.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Расшифрованные данные.</returns>
		/// <exception cref="T:System.NotImplementedException">Производный класс должен переопределять этот метод.</exception>
		// Token: 0x06002FB6 RID: 12214 RVA: 0x000AD491 File Offset: 0x000AB691
		public virtual byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			throw RSA.DerivedClassMustOverride();
		}

		/// <summary>При переопределении в производном классе вычисляет подпись для указанного хэш-значения путем его шифрования с закрытым ключом с использованием указанного заполнения.</summary>
		/// <param name="hash">Значение хэша подписываемых данных.</param>
		/// <param name="hashAlgorithm">Алгоритм хэширования, используемый для создания хэш-значения данных.</param>
		/// <param name="padding">Заполнение.</param>
		/// <returns>Подпись RSA для указанного хэш-значения.</returns>
		/// <exception cref="T:System.NotImplementedException">Производный класс должен переопределять этот метод.</exception>
		// Token: 0x06002FB7 RID: 12215 RVA: 0x000AD491 File Offset: 0x000AB691
		public virtual byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw RSA.DerivedClassMustOverride();
		}

		/// <summary>Проверяет допустимость цифровой подписи путем определения хэш-значения в этой подписи с помощью указанного хэш-алгоритма и заполнения, сравнивая его с предоставленным хэш-значением.</summary>
		/// <param name="hash">Хэш-значение подписанных данных.</param>
		/// <param name="signature">Подпись, подлежащая проверке.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Значение <see langword="true" />, если подпись действительна; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Производный класс должен переопределять этот метод.</exception>
		// Token: 0x06002FB8 RID: 12216 RVA: 0x000AD491 File Offset: 0x000AB691
		public virtual bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw RSA.DerivedClassMustOverride();
		}

		/// <summary>При переопределении в производном классе вычисляет хэш-значение указанного фрагмента массива байтов с помощью заданного хэш-алгоритма.</summary>
		/// <param name="data">Данные, предназначенные для хэширования.</param>
		/// <param name="offset">Индекс первого байта в <paramref name="data" />, хэширование которого требуется выполнить.</param>
		/// <param name="count">Количество байтов, хэширование которых необходимо выполнить.</param>
		/// <param name="hashAlgorithm">Алгоритм, который должен использоваться при хэшировании данных.</param>
		/// <returns>Хэшированные данные.</returns>
		/// <exception cref="T:System.NotImplementedException">Производный класс должен переопределять этот метод.</exception>
		// Token: 0x06002FB9 RID: 12217 RVA: 0x000AD491 File Offset: 0x000AB691
		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			throw RSA.DerivedClassMustOverride();
		}

		/// <summary>При переопределении в производном классе вычисляет хэш-значение указанного двоичного потока с помощью заданного алгоритма хэширования.</summary>
		/// <param name="data">Двоичный поток, хэширование которого требуется выполнить.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм.</param>
		/// <returns>Хэшированные данные.</returns>
		/// <exception cref="T:System.NotImplementedException">Производный класс должен переопределять этот метод.</exception>
		// Token: 0x06002FBA RID: 12218 RVA: 0x000AD491 File Offset: 0x000AB691
		protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			throw RSA.DerivedClassMustOverride();
		}

		/// <summary>Вычисляет хэш-значение заданного массива байтов с помощью указанного алгоритма хэширования и режима заполнения, а затем подписывает полученное хэш-значение.</summary>
		/// <param name="data">Входные данные, для которых вычисляется хэш.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Подпись RSA для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="padding" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002FBB RID: 12219 RVA: 0x000AD498 File Offset: 0x000AB698
		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			return this.SignData(data, 0, data.Length, hashAlgorithm, padding);
		}

		/// <summary>Вычисляет хэш-значение части заданного массива байтов с помощью указанного алгоритма хэширования и режима заполнения, а затем подписывает полученное хэш-значение.</summary>
		/// <param name="data">Входные данные, для которых вычисляется хэш.</param>
		/// <param name="offset">Смещение в массиве, начиная с которого следует использовать данные.</param>
		/// <param name="count">Число байтов в массиве для использования в качестве данных.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Подпись RSA для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="padding" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="offset" /> + <paramref name="count" /> - 1 приводит к получению значения индекса, который выходит за пределы верхней границы <paramref name="data" />.</exception>
		// Token: 0x06002FBC RID: 12220 RVA: 0x000AD4B8 File Offset: 0x000AB6B8
		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (offset < 0 || offset > data.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > data.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw RSA.HashAlgorithmNameNullOrEmpty();
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			byte[] hash = this.HashData(data, offset, count, hashAlgorithm);
			return this.SignHash(hash, hashAlgorithm, padding);
		}

		/// <summary>Вычисляет хэш-значение заданного потока с помощью указанного алгоритма хэширования и режима заполнения, а затем подписывает полученное хэш-значение.</summary>
		/// <param name="data">Входной поток, для которого нужно вычислить хэш.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Подпись RSA для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="padding" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002FBD RID: 12221 RVA: 0x000AD540 File Offset: 0x000AB740
		public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw RSA.HashAlgorithmNameNullOrEmpty();
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			byte[] hash = this.HashData(data, hashAlgorithm);
			return this.SignHash(hash, hashAlgorithm, padding);
		}

		/// <summary>Проверяет допустимость цифровой подписи, вычисляя хэш-значение указанных данных с помощью указанного алгоритма хэширования и заполнения, а затем сравнивая его с предоставленной подписью.</summary>
		/// <param name="data">Подписанные данные.</param>
		/// <param name="signature">Данные подписи, которые требуется поверить.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения данных.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Значение <see langword="true" />, если подпись действительна; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="signature" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="padding" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002FBE RID: 12222 RVA: 0x000AD595 File Offset: 0x000AB795
		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			return this.VerifyData(data, 0, data.Length, signature, hashAlgorithm, padding);
		}

		/// <summary>Проверяет допустимость цифровой подписи, вычисляя хэш-значение данных во фрагменте массива байтов с помощью указанного алгоритма хэширования и заполнения и сравнивая его с предоставленной подписью.</summary>
		/// <param name="data">Подписанные данные.</param>
		/// <param name="offset">Индекс, начиная с которого нужно вычислять хэш.</param>
		/// <param name="count">Количество байтов для хэширования.</param>
		/// <param name="signature">Подпись, подлежащая проверке.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения данных.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Значение <see langword="true" />, если подпись действительна; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="signature" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="padding" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="offset" /> + <paramref name="count" /> - 1 приводит к получению значения индекса, который выходит за пределы верхней границы <paramref name="data" />.</exception>
		// Token: 0x06002FBF RID: 12223 RVA: 0x000AD5B4 File Offset: 0x000AB7B4
		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (offset < 0 || offset > data.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > data.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (signature == null)
			{
				throw new ArgumentNullException("signature");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw RSA.HashAlgorithmNameNullOrEmpty();
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			byte[] hash = this.HashData(data, offset, count, hashAlgorithm);
			return this.VerifyHash(hash, signature, hashAlgorithm, padding);
		}

		/// <summary>Проверяет допустимость цифровой подписи, вычисляя хэш-значение указанного потока с помощью указанного алгоритма хэширования и заполнения, а затем сравнивая его с предоставленной подписью.</summary>
		/// <param name="data">Подписанные данные.</param>
		/// <param name="signature">Данные подписи, которые требуется поверить.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения данных.</param>
		/// <param name="padding">Режим заполнения.</param>
		/// <returns>Значение <see langword="true" />, если подпись действительна; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="signature" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="padding" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002FC0 RID: 12224 RVA: 0x000AD64C File Offset: 0x000AB84C
		public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (signature == null)
			{
				throw new ArgumentNullException("signature");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw RSA.HashAlgorithmNameNullOrEmpty();
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			byte[] hash = this.HashData(data, hashAlgorithm);
			return this.VerifyHash(hash, signature, hashAlgorithm, padding);
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x000A74B1 File Offset: 0x000A56B1
		private static Exception DerivedClassMustOverride()
		{
			return new NotImplementedException(Environment.GetResourceString("Derived classes must provide an implementation."));
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x000A74C2 File Offset: 0x000A56C2
		internal static Exception HashAlgorithmNameNullOrEmpty()
		{
			return new ArgumentException(Environment.GetResourceString("The hash algorithm name cannot be null or empty."), "hashAlgorithm");
		}

		/// <summary>При переопределении в производном классе расшифровывает входные данные с помощью закрытого ключа.</summary>
		/// <param name="rgb">Зашифрованный текст, который требуется расшифровать.</param>
		/// <returns>Результат расшифровки значения параметра <paramref name="rgb" /> в форме обычного текста.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот вызов метода не поддерживается. Это исключение выдается, начиная с .NET Framework 4.6.</exception>
		// Token: 0x06002FC3 RID: 12227 RVA: 0x000AD6B2 File Offset: 0x000AB8B2
		public virtual byte[] DecryptValue(byte[] rgb)
		{
			throw new NotSupportedException(Environment.GetResourceString("Method is not supported."));
		}

		/// <summary>При переопределении в производном классе зашифровывает входные данные с помощью открытого ключа.</summary>
		/// <param name="rgb">Открытый текст, который требуется зашифровать.</param>
		/// <returns>Результат зашифровки значения параметра <paramref name="rgb" /> в форме зашифрованного текста.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот вызов метода не поддерживается. Это исключение выдается, начиная с .NET Framework 4.6.</exception>
		// Token: 0x06002FC4 RID: 12228 RVA: 0x000AD6B2 File Offset: 0x000AB8B2
		public virtual byte[] EncryptValue(byte[] rgb)
		{
			throw new NotSupportedException(Environment.GetResourceString("Method is not supported."));
		}

		/// <summary>Получает имя алгоритма обмена ключами, предоставляемого этой реализацией объекта <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <returns>Возвращает RSA.</returns>
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000AD6C3 File Offset: 0x000AB8C3
		public override string KeyExchangeAlgorithm
		{
			get
			{
				return "RSA";
			}
		}

		/// <summary>Получает имя алгоритма подписи, предоставляемого этой реализацией объекта <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <returns>Возвращает RSA.</returns>
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x000AD6C3 File Offset: 0x000AB8C3
		public override string SignatureAlgorithm
		{
			get
			{
				return "RSA";
			}
		}

		/// <summary>Инициализирует объект <see cref="T:System.Security.Cryptography.RSA" />, используя данные ключа из строки XML.</summary>
		/// <param name="xmlString">Строка XML, содержащая данные ключа <see cref="T:System.Security.Cryptography.RSA" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="xmlString" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый формат значения параметра <paramref name="xmlString" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: этот элемент не поддерживается.</exception>
		// Token: 0x06002FC7 RID: 12231 RVA: 0x000AD6CC File Offset: 0x000AB8CC
		public override void FromXmlString(string xmlString)
		{
			if (xmlString == null)
			{
				throw new ArgumentNullException("xmlString");
			}
			RSAParameters parameters = default(RSAParameters);
			SecurityElement topElement = new Parser(xmlString).GetTopElement();
			string text = topElement.SearchForTextOfLocalName("Modulus");
			if (text == null)
			{
				throw new CryptographicException(Environment.GetResourceString("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.", new object[]
				{
					"RSA",
					"Modulus"
				}));
			}
			parameters.Modulus = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text));
			string text2 = topElement.SearchForTextOfLocalName("Exponent");
			if (text2 == null)
			{
				throw new CryptographicException(Environment.GetResourceString("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.", new object[]
				{
					"RSA",
					"Exponent"
				}));
			}
			parameters.Exponent = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text2));
			string text3 = topElement.SearchForTextOfLocalName("P");
			if (text3 != null)
			{
				parameters.P = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text3));
			}
			string text4 = topElement.SearchForTextOfLocalName("Q");
			if (text4 != null)
			{
				parameters.Q = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text4));
			}
			string text5 = topElement.SearchForTextOfLocalName("DP");
			if (text5 != null)
			{
				parameters.DP = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text5));
			}
			string text6 = topElement.SearchForTextOfLocalName("DQ");
			if (text6 != null)
			{
				parameters.DQ = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text6));
			}
			string text7 = topElement.SearchForTextOfLocalName("InverseQ");
			if (text7 != null)
			{
				parameters.InverseQ = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text7));
			}
			string text8 = topElement.SearchForTextOfLocalName("D");
			if (text8 != null)
			{
				parameters.D = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text8));
			}
			this.ImportParameters(parameters);
		}

		/// <summary>Создает и возвращает строку XML, содержащую ключ текущего объекта <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <param name="includePrivateParameters">Значение <see langword="true" />, чтобы включать закрытый и открытый ключ RSA; значение <see langword="false" />, чтобы включать только открытый ключ.</param>
		/// <returns>Строка XML, содержащая ключ текущего объекта <see cref="T:System.Security.Cryptography.RSA" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: этот элемент не поддерживается.</exception>
		// Token: 0x06002FC8 RID: 12232 RVA: 0x000AD868 File Offset: 0x000ABA68
		public override string ToXmlString(bool includePrivateParameters)
		{
			RSAParameters rsaparameters = this.ExportParameters(includePrivateParameters);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<RSAKeyValue>");
			stringBuilder.Append("<Modulus>" + Convert.ToBase64String(rsaparameters.Modulus) + "</Modulus>");
			stringBuilder.Append("<Exponent>" + Convert.ToBase64String(rsaparameters.Exponent) + "</Exponent>");
			if (includePrivateParameters)
			{
				stringBuilder.Append("<P>" + Convert.ToBase64String(rsaparameters.P) + "</P>");
				stringBuilder.Append("<Q>" + Convert.ToBase64String(rsaparameters.Q) + "</Q>");
				stringBuilder.Append("<DP>" + Convert.ToBase64String(rsaparameters.DP) + "</DP>");
				stringBuilder.Append("<DQ>" + Convert.ToBase64String(rsaparameters.DQ) + "</DQ>");
				stringBuilder.Append("<InverseQ>" + Convert.ToBase64String(rsaparameters.InverseQ) + "</InverseQ>");
				stringBuilder.Append("<D>" + Convert.ToBase64String(rsaparameters.D) + "</D>");
			}
			stringBuilder.Append("</RSAKeyValue>");
			return stringBuilder.ToString();
		}

		/// <summary>При переопределении в производном классе экспортирует объект <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="includePrivateParameters">Значение <see langword="true" /> для включения параметров с модификатором доступа private; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Параметры для <see cref="T:System.Security.Cryptography.RSA" />.</returns>
		// Token: 0x06002FC9 RID: 12233
		public abstract RSAParameters ExportParameters(bool includePrivateParameters);

		/// <summary>При переопределении в производном классе импортирует заданный объект <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="parameters">Параметры для <see cref="T:System.Security.Cryptography.RSA" />.</param>
		// Token: 0x06002FCA RID: 12234
		public abstract void ImportParameters(RSAParameters parameters);

		/// <summary>Создает новый временный RSA-ключ с заданным размером ключа.</summary>
		/// <param name="keySizeInBits">Размер ключа в битах.</param>
		/// <returns>Новый временный RSA-ключ с заданным размером ключа.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///   <paramref name="keySizeInBits" /> отличается от <see cref="P:System.Security.Cryptography.AsymmetricAlgorithm.KeySize" />.</exception>
		// Token: 0x06002FCB RID: 12235 RVA: 0x000AD9B0 File Offset: 0x000ABBB0
		public static RSA Create(int keySizeInBits)
		{
			RSA rsa = RSA.Create();
			RSA result;
			try
			{
				rsa.KeySize = keySizeInBits;
				result = rsa;
			}
			catch
			{
				rsa.Dispose();
				throw;
			}
			return result;
		}

		/// <summary>Создает новый временный RSA-ключ с заданными параметрами RSA-ключа.</summary>
		/// <param name="parameters">Параметры для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</param>
		/// <returns>Новый временный RSA-ключ.</returns>
		// Token: 0x06002FCC RID: 12236 RVA: 0x000AD9E8 File Offset: 0x000ABBE8
		public static RSA Create(RSAParameters parameters)
		{
			RSA rsa = RSA.Create();
			RSA result;
			try
			{
				rsa.ImportParameters(parameters);
				result = rsa;
			}
			catch
			{
				rsa.Dispose();
				throw;
			}
			return result;
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x000ADA20 File Offset: 0x000ABC20
		public virtual bool TryDecrypt(ReadOnlySpan<byte> data, Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			byte[] array = this.Decrypt(data.ToArray(), padding);
			if (destination.Length >= array.Length)
			{
				new ReadOnlySpan<byte>(array).CopyTo(destination);
				bytesWritten = array.Length;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x000ADA64 File Offset: 0x000ABC64
		public virtual bool TryEncrypt(ReadOnlySpan<byte> data, Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			byte[] array = this.Encrypt(data.ToArray(), padding);
			if (destination.Length >= array.Length)
			{
				new ReadOnlySpan<byte>(array).CopyTo(destination);
				bytesWritten = array.Length;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x000ADAA8 File Offset: 0x000ABCA8
		protected virtual bool TryHashData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(data.Length);
			byte[] array2;
			try
			{
				data.CopyTo(array);
				array2 = this.HashData(array, 0, data.Length, hashAlgorithm);
			}
			finally
			{
				Array.Clear(array, 0, data.Length);
				ArrayPool<byte>.Shared.Return(array, false);
			}
			if (destination.Length >= array2.Length)
			{
				new ReadOnlySpan<byte>(array2).CopyTo(destination);
				bytesWritten = array2.Length;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x000ADB3C File Offset: 0x000ABD3C
		public virtual bool TrySignHash(ReadOnlySpan<byte> hash, Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			byte[] array = this.SignHash(hash.ToArray(), hashAlgorithm, padding);
			if (destination.Length >= array.Length)
			{
				new ReadOnlySpan<byte>(array).CopyTo(destination);
				bytesWritten = array.Length;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000ADB84 File Offset: 0x000ABD84
		public virtual bool TrySignData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw RSA.HashAlgorithmNameNullOrEmpty();
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			int length;
			if (this.TryHashData(data, destination, hashAlgorithm, out length) && this.TrySignHash(destination.Slice(0, length), destination, hashAlgorithm, padding, out bytesWritten))
			{
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x000ADBEC File Offset: 0x000ABDEC
		public virtual bool VerifyData(ReadOnlySpan<byte> data, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw RSA.HashAlgorithmNameNullOrEmpty();
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			int num = 256;
			checked
			{
				bool result;
				for (;;)
				{
					int length = 0;
					byte[] array = ArrayPool<byte>.Shared.Rent(num);
					try
					{
						if (this.TryHashData(data, array, hashAlgorithm, out length))
						{
							result = this.VerifyHash(new ReadOnlySpan<byte>(array, 0, length), signature, hashAlgorithm, padding);
							break;
						}
					}
					finally
					{
						Array.Clear(array, 0, length);
						ArrayPool<byte>.Shared.Return(array, false);
					}
					num *= 2;
				}
				return result;
			}
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x000ADC8C File Offset: 0x000ABE8C
		public virtual bool VerifyHash(ReadOnlySpan<byte> hash, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return this.VerifyHash(hash.ToArray(), signature.ToArray(), hashAlgorithm, padding);
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual byte[] ExportRSAPrivateKey()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual byte[] ExportRSAPublicKey()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual void ImportRSAPrivateKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual void ImportRSAPublicKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual bool TryExportRSAPrivateKey(Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual bool TryExportRSAPublicKey(Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}
	}
}
