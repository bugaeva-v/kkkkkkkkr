using System;
using System.Buffers;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Util;
using System.Text;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный базовый класс, от которого наследуются все реализации алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
	// Token: 0x0200048B RID: 1163
	[ComVisible(true)]
	public abstract class DSA : AsymmetricAlgorithm
	{
		/// <summary>Создает криптографический объект по умолчанию, используемый для выполнения алгоритма асимметричного шифрования.</summary>
		/// <returns>Криптографический объект, используемый для выполнения алгоритма асимметричного шифрования.</returns>
		// Token: 0x06002EC6 RID: 11974 RVA: 0x000A6F37 File Offset: 0x000A5137
		public new static DSA Create()
		{
			return DSA.Create("System.Security.Cryptography.DSA");
		}

		/// <summary>Создает заданный криптографический объект, используемый для выполнения алгоритма асимметричного шифрования.</summary>
		/// <param name="algName">Имя конкретной реализации <see cref="T:System.Security.Cryptography.DSA" />, которую требуется использовать.</param>
		/// <returns>Криптографический объект, используемый для выполнения алгоритма асимметричного шифрования.</returns>
		// Token: 0x06002EC7 RID: 11975 RVA: 0x000A6F43 File Offset: 0x000A5143
		public new static DSA Create(string algName)
		{
			return (DSA)CryptoConfig.CreateFromName(algName);
		}

		/// <summary>При переопределении в производном классе создает подпись <see cref="T:System.Security.Cryptography.DSA" /> для указанных данных.</summary>
		/// <param name="rgbHash">Данные, которые необходимо подписать.</param>
		/// <returns>Цифровая подпись для указанных данных.</returns>
		// Token: 0x06002EC8 RID: 11976
		public abstract byte[] CreateSignature(byte[] rgbHash);

		/// <summary>При переопределении в производном классе проверяет подпись <see cref="T:System.Security.Cryptography.DSA" /> для указанных данных.</summary>
		/// <param name="rgbHash">Хэш данных, подписанных с помощью <paramref name="rgbSignature" />.</param>
		/// <param name="rgbSignature">Подпись, которую требуется проверить для rgbData.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="rgbSignature" /> совпадает с подписью, вычисленной для <paramref name="rgbHash" /> с использованием заданного хэш-алгоритма и ключа; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002EC9 RID: 11977
		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

		/// <summary>При переопределении в производном классе вычисляет хэш-значение указанного фрагмента массива байтов с помощью заданного хэш-алгоритма.</summary>
		/// <param name="data">Данные, предназначенные для хэширования.</param>
		/// <param name="offset">Индекс первого байта в <paramref name="data" />, хэширование которого требуется выполнить.</param>
		/// <param name="count">Количество байтов для хэширования.</param>
		/// <param name="hashAlgorithm">Алгоритм, который будет использоваться для хэширования данных.</param>
		/// <returns>Хэшированные данные.</returns>
		/// <exception cref="T:System.NotImplementedException">Производный класс должен переопределять этот метод.</exception>
		// Token: 0x06002ECA RID: 11978 RVA: 0x000A6F50 File Offset: 0x000A5150
		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			throw DSA.DerivedClassMustOverride();
		}

		/// <summary>При переопределении в производном классе вычисляет хэш-значение указанного двоичного потока с помощью заданного алгоритма хэширования.</summary>
		/// <param name="data">Двоичный поток, хэширование которого требуется выполнить.</param>
		/// <param name="hashAlgorithm">Алгоритм, который будет использоваться для хэширования данных.</param>
		/// <returns>Хэшированные данные.</returns>
		/// <exception cref="T:System.NotImplementedException">Производный класс должен переопределять этот метод.</exception>
		// Token: 0x06002ECB RID: 11979 RVA: 0x000A6F50 File Offset: 0x000A5150
		protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			throw DSA.DerivedClassMustOverride();
		}

		/// <summary>Вычисляет хэш-значение заданного массива байтов с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.</summary>
		/// <param name="data">Входные данные, для которых вычисляется хэш.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения.</param>
		/// <returns>Подпись DSA для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002ECC RID: 11980 RVA: 0x000A6F57 File Offset: 0x000A5157
		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			return this.SignData(data, 0, data.Length, hashAlgorithm);
		}

		/// <summary>Вычисляет хэш-значение фрагмента заданного массива байтов с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.</summary>
		/// <param name="data">Входные данные, для которых вычисляется хэш.</param>
		/// <param name="offset">Смещение в массиве, начиная с которого следует использовать данные.</param>
		/// <param name="count">Число байтов в массиве для использования в качестве данных.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения.</param>
		/// <returns>Подпись DSA для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="offset" /> + <paramref name="count" /> — 1 приводит к получению значения индекса, который выходит за пределы верхней границы <paramref name="data" />.</exception>
		// Token: 0x06002ECD RID: 11981 RVA: 0x000A6F74 File Offset: 0x000A5174
		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
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
				throw DSA.HashAlgorithmNameNullOrEmpty();
			}
			byte[] rgbHash = this.HashData(data, offset, count, hashAlgorithm);
			return this.CreateSignature(rgbHash);
		}

		/// <summary>Вычисляет хэш-значение заданного потока с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.</summary>
		/// <param name="data">Входной поток, для которого нужно вычислить хэш.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения.</param>
		/// <returns>Подпись DSA для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="data" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002ECE RID: 11982 RVA: 0x000A6FE4 File Offset: 0x000A51E4
		public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw DSA.HashAlgorithmNameNullOrEmpty();
			}
			byte[] rgbHash = this.HashData(data, hashAlgorithm);
			return this.CreateSignature(rgbHash);
		}

		/// <summary>Проверяет допустимость цифровой подписи путем вычисления хэш-значения заданных данных с помощью указанного алгоритма хэширования и его сравнения с предоставленной подписью.</summary>
		/// <param name="data">Подписанные данные.</param>
		/// <param name="signature">Данные подписи, которые требуется поверить.</param>
		/// <param name="hashAlgorithm">Алгоритм хэширования, используемый для создания хэш-значения данных.</param>
		/// <returns>Значение <see langword="true" />, если цифровая подпись является допустимой. В противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="data" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="signature" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002ECF RID: 11983 RVA: 0x000A7023 File Offset: 0x000A5223
		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			return this.VerifyData(data, 0, data.Length, signature, hashAlgorithm);
		}

		/// <summary>Проверяет допустимость цифровой подписи путем вычисления хэш-значения данных во фрагменте массива байтов с помощью указанного алгоритма хэширования и его сравнения с предоставленной подписью.</summary>
		/// <param name="data">Подписанные данные.</param>
		/// <param name="offset">Индекс, начиная с которого нужно вычислять хэш.</param>
		/// <param name="count">Количество байтов для хэширования.</param>
		/// <param name="signature">Подпись, подлежащая проверке.</param>
		/// <param name="hashAlgorithm">Алгоритм хэширования, используемый для создания хэш-значения данных.</param>
		/// <returns>Значение <see langword="true" />, если цифровая подпись является допустимой. В противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="data" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="signature" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="offset" /> + <paramref name="count" /> — 1 приводит к получению значения индекса, который выходит за пределы верхней границы <paramref name="data" />.</exception>
		// Token: 0x06002ED0 RID: 11984 RVA: 0x000A7040 File Offset: 0x000A5240
		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm)
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
				throw DSA.HashAlgorithmNameNullOrEmpty();
			}
			byte[] rgbHash = this.HashData(data, offset, count, hashAlgorithm);
			return this.VerifySignature(rgbHash, signature);
		}

		/// <summary>Проверяет допустимость цифровой подписи путем вычисления хэш-значения заданного потока с помощью указанного алгоритма хэширования и его сравнения с предоставленной подписью.</summary>
		/// <param name="data">Подписанные данные.</param>
		/// <param name="signature">Данные подписи, которые требуется поверить.</param>
		/// <param name="hashAlgorithm">Алгоритм хэширования, используемый для создания хэш-значения данных.</param>
		/// <returns>Значение <see langword="true" />, если цифровая подпись является допустимой. В противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="data" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="signature" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x06002ED1 RID: 11985 RVA: 0x000A70C0 File Offset: 0x000A52C0
		public virtual bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm)
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
				throw DSA.HashAlgorithmNameNullOrEmpty();
			}
			byte[] rgbHash = this.HashData(data, hashAlgorithm);
			return this.VerifySignature(rgbHash, signature);
		}

		/// <summary>Восстанавливает объект <see cref="T:System.Security.Cryptography.DSA" /> из XML-строки.</summary>
		/// <param name="xmlString">XML-строка, используемая для восстановления объекта <see cref="T:System.Security.Cryptography.DSA" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="xmlString" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый формат значения параметра <paramref name="xmlString" />.</exception>
		// Token: 0x06002ED2 RID: 11986 RVA: 0x000A7110 File Offset: 0x000A5310
		public override void FromXmlString(string xmlString)
		{
			if (xmlString == null)
			{
				throw new ArgumentNullException("xmlString");
			}
			DSAParameters parameters = default(DSAParameters);
			SecurityElement topElement = new Parser(xmlString).GetTopElement();
			string text = topElement.SearchForTextOfLocalName("P");
			if (text == null)
			{
				throw new CryptographicException(Environment.GetResourceString("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.", new object[]
				{
					"DSA",
					"P"
				}));
			}
			parameters.P = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text));
			string text2 = topElement.SearchForTextOfLocalName("Q");
			if (text2 == null)
			{
				throw new CryptographicException(Environment.GetResourceString("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.", new object[]
				{
					"DSA",
					"Q"
				}));
			}
			parameters.Q = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text2));
			string text3 = topElement.SearchForTextOfLocalName("G");
			if (text3 == null)
			{
				throw new CryptographicException(Environment.GetResourceString("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.", new object[]
				{
					"DSA",
					"G"
				}));
			}
			parameters.G = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text3));
			string text4 = topElement.SearchForTextOfLocalName("Y");
			if (text4 == null)
			{
				throw new CryptographicException(Environment.GetResourceString("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.", new object[]
				{
					"DSA",
					"Y"
				}));
			}
			parameters.Y = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text4));
			string text5 = topElement.SearchForTextOfLocalName("J");
			if (text5 != null)
			{
				parameters.J = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text5));
			}
			string text6 = topElement.SearchForTextOfLocalName("X");
			if (text6 != null)
			{
				parameters.X = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text6));
			}
			string text7 = topElement.SearchForTextOfLocalName("Seed");
			string text8 = topElement.SearchForTextOfLocalName("PgenCounter");
			if (text7 != null && text8 != null)
			{
				parameters.Seed = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text7));
				parameters.Counter = Utils.ConvertByteArrayToInt(Convert.FromBase64String(Utils.DiscardWhiteSpaces(text8)));
			}
			else if (text7 != null || text8 != null)
			{
				if (text7 == null)
				{
					throw new CryptographicException(Environment.GetResourceString("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.", new object[]
					{
						"DSA",
						"Seed"
					}));
				}
				throw new CryptographicException(Environment.GetResourceString("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.", new object[]
				{
					"DSA",
					"PgenCounter"
				}));
			}
			this.ImportParameters(parameters);
		}

		/// <summary>Создает и возвращает XML-представление текущего объекта <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		/// <param name="includePrivateParameters">Значение <see langword="true" /> для включения параметров с модификатором доступа private; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Кодировка XML-строки текущего объекта <see cref="T:System.Security.Cryptography.DSA" />.</returns>
		// Token: 0x06002ED3 RID: 11987 RVA: 0x000A7358 File Offset: 0x000A5558
		public override string ToXmlString(bool includePrivateParameters)
		{
			DSAParameters dsaparameters = this.ExportParameters(includePrivateParameters);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<DSAKeyValue>");
			stringBuilder.Append("<P>" + Convert.ToBase64String(dsaparameters.P) + "</P>");
			stringBuilder.Append("<Q>" + Convert.ToBase64String(dsaparameters.Q) + "</Q>");
			stringBuilder.Append("<G>" + Convert.ToBase64String(dsaparameters.G) + "</G>");
			stringBuilder.Append("<Y>" + Convert.ToBase64String(dsaparameters.Y) + "</Y>");
			if (dsaparameters.J != null)
			{
				stringBuilder.Append("<J>" + Convert.ToBase64String(dsaparameters.J) + "</J>");
			}
			if (dsaparameters.Seed != null)
			{
				stringBuilder.Append("<Seed>" + Convert.ToBase64String(dsaparameters.Seed) + "</Seed>");
				stringBuilder.Append("<PgenCounter>" + Convert.ToBase64String(Utils.ConvertIntToByteArray(dsaparameters.Counter)) + "</PgenCounter>");
			}
			if (includePrivateParameters)
			{
				stringBuilder.Append("<X>" + Convert.ToBase64String(dsaparameters.X) + "</X>");
			}
			stringBuilder.Append("</DSAKeyValue>");
			return stringBuilder.ToString();
		}

		/// <summary>При переопределении в производном классе экспортирует объект <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
		/// <param name="includePrivateParameters">Значение <see langword="true" /> для включения параметров с модификатором доступа private; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Параметры для <see cref="T:System.Security.Cryptography.DSA" />.</returns>
		// Token: 0x06002ED4 RID: 11988
		public abstract DSAParameters ExportParameters(bool includePrivateParameters);

		/// <summary>При переопределении в производном классе импортирует заданный объект <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
		/// <param name="parameters">Параметры для <see cref="T:System.Security.Cryptography.DSA" />.</param>
		// Token: 0x06002ED5 RID: 11989
		public abstract void ImportParameters(DSAParameters parameters);

		// Token: 0x06002ED6 RID: 11990 RVA: 0x000A74B1 File Offset: 0x000A56B1
		private static Exception DerivedClassMustOverride()
		{
			return new NotImplementedException(Environment.GetResourceString("Derived classes must provide an implementation."));
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x000A74C2 File Offset: 0x000A56C2
		internal static Exception HashAlgorithmNameNullOrEmpty()
		{
			return new ArgumentException(Environment.GetResourceString("The hash algorithm name cannot be null or empty."), "hashAlgorithm");
		}

		/// <summary>Создает новый временный DSA-ключ с заданным размером ключа.</summary>
		/// <param name="keySizeInBits">Размер ключа в битах.</param>
		/// <returns>Создает новый временный DSA-ключ с заданным размером ключа.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///   <paramref name="keySizeInBits" /> отличается от <see cref="P:System.Security.Cryptography.AsymmetricAlgorithm.KeySize" />.</exception>
		// Token: 0x06002ED8 RID: 11992 RVA: 0x000A74D8 File Offset: 0x000A56D8
		public static DSA Create(int keySizeInBits)
		{
			DSA dsa = DSA.Create();
			DSA result;
			try
			{
				dsa.KeySize = keySizeInBits;
				result = dsa;
			}
			catch
			{
				dsa.Dispose();
				throw;
			}
			return result;
		}

		/// <summary>Создает новый временный DSA-ключ с заданными параметрами DSA-ключа.</summary>
		/// <param name="parameters">Параметры для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</param>
		/// <returns>Новый временный DSA-ключ.</returns>
		// Token: 0x06002ED9 RID: 11993 RVA: 0x000A7510 File Offset: 0x000A5710
		public static DSA Create(DSAParameters parameters)
		{
			DSA dsa = DSA.Create();
			DSA result;
			try
			{
				dsa.ImportParameters(parameters);
				result = dsa;
			}
			catch
			{
				dsa.Dispose();
				throw;
			}
			return result;
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000A7548 File Offset: 0x000A5748
		public virtual bool TryCreateSignature(ReadOnlySpan<byte> hash, Span<byte> destination, out int bytesWritten)
		{
			byte[] array = this.CreateSignature(hash.ToArray());
			if (array.Length <= destination.Length)
			{
				new ReadOnlySpan<byte>(array).CopyTo(destination);
				bytesWritten = array.Length;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x000A758C File Offset: 0x000A578C
		protected virtual bool TryHashData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(data.Length);
			bool result;
			try
			{
				data.CopyTo(array);
				byte[] array2 = this.HashData(array, 0, data.Length, hashAlgorithm);
				if (destination.Length >= array2.Length)
				{
					new ReadOnlySpan<byte>(array2).CopyTo(destination);
					bytesWritten = array2.Length;
					result = true;
				}
				else
				{
					bytesWritten = 0;
					result = false;
				}
			}
			finally
			{
				Array.Clear(array, 0, data.Length);
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000A7624 File Offset: 0x000A5824
		public virtual bool TrySignData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw DSA.HashAlgorithmNameNullOrEmpty();
			}
			int length;
			if (this.TryHashData(data, destination, hashAlgorithm, out length) && this.TryCreateSignature(destination.Slice(0, length), destination, out bytesWritten))
			{
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000A7674 File Offset: 0x000A5874
		public virtual bool VerifyData(ReadOnlySpan<byte> data, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm)
		{
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw DSA.HashAlgorithmNameNullOrEmpty();
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
							result = this.VerifySignature(new ReadOnlySpan<byte>(array, 0, length), signature);
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

		// Token: 0x06002EDE RID: 11998 RVA: 0x000A76FC File Offset: 0x000A58FC
		public virtual bool VerifySignature(ReadOnlySpan<byte> hash, ReadOnlySpan<byte> signature)
		{
			return this.VerifySignature(hash.ToArray(), signature.ToArray());
		}
	}
}
