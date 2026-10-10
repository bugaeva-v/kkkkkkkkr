using System;
using System.Buffers;
using System.IO;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет абстрактный базовый класс, который инкапсулирует алгоритм цифровых подписей на основе эллиптических кривых (ECDSA).
	///       </summary>
	// Token: 0x0200004A RID: 74
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public abstract class ECDsa : AsymmetricAlgorithm
	{
		/// <summary>
		///         Получает имя алгоритма обмена ключами.
		///       </summary>
		/// <returns>
		///         Всегда <see langword="null" />.
		///       </returns>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000392D File Offset: 0x00001B2D
		public override string KeyExchangeAlgorithm
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///         Получает имя алгоритма подписи.
		///       </summary>
		/// <returns>
		///         Строка «ECDsa».
		///       </returns>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00003A7E File Offset: 0x00001C7E
		public override string SignatureAlgorithm
		{
			get
			{
				return "ECDsa";
			}
		}

		/// <summary>
		///         Создает новый экземпляр реализации по умолчанию из эллиптических кривых цифровой подписи алгоритма (ECDSA).
		///       </summary>
		/// <returns>
		///         Новый экземпляр реализации по умолчанию (<see cref="T:System.Security.Cryptography.ECDsaCng" />) этого класса.
		///       </returns>
		// Token: 0x0600017F RID: 383 RVA: 0x000023CA File Offset: 0x000005CA
		public new static ECDsa Create()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает новый экземпляр заданной реализации из эллиптических кривых цифровой подписи алгоритма (ECDSA).
		///       </summary>
		/// <param name="algorithm">
		///           Имя реализации ECDSA.
		///            Следующие строки относятся же реализация, которая в настоящее время является только реализация поддерживается в .NET Framework:
		///
		///           -«ECDsa»
		///
		///           -«ECDsaCng»
		///
		///           -«System.Security.Cryptography.ECDsaCng»
		///
		///           Можно также указать имя пользовательской реализации ECDSA.
		///         </param>
		/// <returns>
		///         Новый экземпляр заданной реализации этого класса.
		///          Если заданное имя алгоритма не соответствует реализации ECDSA, этот метод возвращает <see langword="null" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="algorithm" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000180 RID: 384 RVA: 0x00003A85 File Offset: 0x00001C85
		public new static ECDsa Create(string algorithm)
		{
			if (algorithm == null)
			{
				throw new ArgumentNullException("algorithm");
			}
			return CryptoConfig.CreateFromName(algorithm) as ECDsa;
		}

		/// <summary>
		///         Создает новый экземпляр реализации по умолчанию на основе алгоритма цифровых подписей на основе эллиптических кривых (ECDSA), используя новый созданный ключ на основе указанной кривой.
		///       </summary>
		/// <param name="curve">
		///           Кривая, используемая для создания ключа.
		///         </param>
		/// <returns>
		///         Новый экземпляр реализации по умолчанию (<see cref="T:System.Security.Cryptography.ECDsaCng" />) этого класса.
		///       </returns>
		// Token: 0x06000181 RID: 385 RVA: 0x00003AA0 File Offset: 0x00001CA0
		public static ECDsa Create(ECCurve curve)
		{
			ECDsa ecdsa = ECDsa.Create();
			if (ecdsa != null)
			{
				try
				{
					ecdsa.GenerateKey(curve);
				}
				catch
				{
					ecdsa.Dispose();
					throw;
				}
			}
			return ecdsa;
		}

		/// <summary>
		///         Создает новый экземпляр реализации по умолчанию на основе алгоритма цифровых подписей на основе эллиптических кривых (ECDSA), используя указанные параметры в качестве ключа.
		///       </summary>
		/// <param name="parameters">
		///           Параметры, представляющие используемый ключ.
		///         </param>
		/// <returns>
		///         Новый экземпляр реализации по умолчанию (<see cref="T:System.Security.Cryptography.ECDsaCng" />) этого класса.
		///       </returns>
		// Token: 0x06000182 RID: 386 RVA: 0x00003ADC File Offset: 0x00001CDC
		public static ECDsa Create(ECParameters parameters)
		{
			ECDsa ecdsa = ECDsa.Create();
			if (ecdsa != null)
			{
				try
				{
					ecdsa.ImportParameters(parameters);
				}
				catch
				{
					ecdsa.Dispose();
					throw;
				}
			}
			return ecdsa;
		}

		/// <summary>
		///         Создает цифровую подпись для указанного хэш-значения.
		///       </summary>
		/// <param name="hash">
		///           Хэш-значение подписываемых данных.
		///         </param>
		/// <returns>
		///         Цифровая подпись, состоящая из указанного хэш-значения, зашифрованного с помощью закрытого ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="hash" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000183 RID: 387
		public abstract byte[] SignHash(byte[] hash);

		/// <summary>
		///         Проверяет цифровую подпись на соответствие указанному хэш-значению.
		///       </summary>
		/// <param name="hash">
		///           Хэш-значение блока данных.
		///         </param>
		/// <param name="signature">
		///           Проверяемая цифровая подпись.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если хэш-значение соответствует расшифрованной подписи; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x06000184 RID: 388
		public abstract bool VerifyHash(byte[] hash, byte[] signature);

		/// <summary>
		///         При переопределении в производном классе вычисляет хэш-значение указанного фрагмента массива байтов с помощью заданного алгоритма хэширования.
		///       </summary>
		/// <param name="data">
		///           Данные, предназначенные для хэширования.
		///         </param>
		/// <param name="offset">
		///           Индекс первого байта в <paramref name="data" />, хэширование которого требуется выполнить.
		///         </param>
		/// <param name="count">
		///           Количество байтов, хэширование которых необходимо выполнить.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Алгоритм, который будет использоваться для хэширования данных.
		///         </param>
		/// <returns>
		///         Хэшированные данные.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x06000185 RID: 389 RVA: 0x00003B18 File Offset: 0x00001D18
		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			throw ECDsa.DerivedClassMustOverride();
		}

		/// <summary>
		///         При переопределении в производном классе вычисляет хэш-значение указанного двоичного потока с помощью заданного алгоритма хэширования.
		///       </summary>
		/// <param name="data">
		///           Двоичный поток, хэширование которого требуется выполнить.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Алгоритм, который будет использоваться для хэширования данных.
		///         </param>
		/// <returns>
		///         Хэшированные данные.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x06000186 RID: 390 RVA: 0x00003B18 File Offset: 0x00001D18
		protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			throw ECDsa.DerivedClassMustOverride();
		}

		/// <summary>
		///         Вычисляет хэш-значение заданного массива байтов с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.
		///       </summary>
		/// <param name="data">
		///           Входные данные, для которых нужно вычислить хэш.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Алгоритм хэширования, используемый для создания хэш-значения.
		///         </param>
		/// <returns>
		///         Подпись ECDSA для указанных данных.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.
		///           </exception>
		// Token: 0x06000187 RID: 391 RVA: 0x00003B1F File Offset: 0x00001D1F
		public virtual byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			return this.SignData(data, 0, data.Length, hashAlgorithm);
		}

		/// <summary>
		///         Вычисляет хэш-значение фрагмента заданного массива байтов с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.
		///       </summary>
		/// <param name="data">
		///           Входные данные, для которых нужно вычислить хэш.
		///         </param>
		/// <param name="offset">
		///           Смещение в массиве, начиная с которого следует использовать данные.
		///         </param>
		/// <param name="count">
		///           Число байтов в массиве для использования в качестве данных.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Алгоритм хэширования, используемый для создания хэш-значения.
		///         </param>
		/// <returns>
		///         Подпись ECDSA для указанных данных.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="offset" /> меньше нуля.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="count" /> меньше нуля.
		///
		///             -или-
		///
		///             <paramref name="offset" /> + <paramref name="count" /> – 1 приводит к получению значения индекса, который выходит за пределы верхней границы <paramref name="data" />.
		///           </exception>
		// Token: 0x06000188 RID: 392 RVA: 0x00003B3C File Offset: 0x00001D3C
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
				throw ECDsa.HashAlgorithmNameNullOrEmpty();
			}
			byte[] hash = this.HashData(data, offset, count, hashAlgorithm);
			return this.SignHash(hash);
		}

		/// <summary>
		///         Вычисляет хэш-значение заданного потока с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.
		///       </summary>
		/// <param name="data">
		///           Входной поток, для которого нужно вычислить хэш.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Алгоритм хэширования, используемый для создания хэш-значения.
		///         </param>
		/// <returns>
		///         Подпись ECDSA для указанных данных.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.
		///           </exception>
		// Token: 0x06000189 RID: 393 RVA: 0x00003BAC File Offset: 0x00001DAC
		public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw ECDsa.HashAlgorithmNameNullOrEmpty();
			}
			byte[] hash = this.HashData(data, hashAlgorithm);
			return this.SignHash(hash);
		}

		/// <summary>
		///         Проверяет допустимость цифровой подписи путем вычисления хэш-значения заданных данных с помощью указанного алгоритма хэширования и его сравнения с предоставленной подписью.
		///       </summary>
		/// <param name="data">
		///           Подписанные данные.
		///         </param>
		/// <param name="signature">
		///           Данные подписи, которые требуется поверить.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Алгоритм хэширования, используемый для создания хэш-значения данных.
		///         </param>
		/// <returns>
		///         <see langword="true" />, если подпись является допустимой. В противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///
		///             -или-
		///
		///             Свойство <paramref name="signature" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.
		///           </exception>
		// Token: 0x0600018A RID: 394 RVA: 0x00003BEB File Offset: 0x00001DEB
		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			return this.VerifyData(data, 0, data.Length, signature, hashAlgorithm);
		}

		/// <summary>
		///         Проверяет допустимость цифровой подписи путем вычисления хэш-значения данных во фрагменте массива байтов с помощью указанного алгоритма хэширования и его сравнения с предоставленной подписью.
		///       </summary>
		/// <param name="data">
		///           Подписанные данные.
		///         </param>
		/// <param name="offset">
		///           Индекс, начиная с которого нужно вычислять хэш.
		///         </param>
		/// <param name="count">
		///           Количество байтов для хэширования.
		///         </param>
		/// <param name="signature">
		///           Данные подписи, которые требуется поверить.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Алгоритм хэширования, используемый для создания хэш-значения данных.
		///         </param>
		/// <returns>
		///         <see langword="true" />, если подпись является допустимой. В противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///
		///             -или-
		///
		///             Свойство <paramref name="signature" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="offset" /> меньше нуля.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="count" /> меньше нуля.
		///
		///             -или-
		///
		///             <paramref name="offset" /> + <paramref name="count" /> – 1 приводит к получению значения индекса, который выходит за пределы верхней границы <paramref name="data" />.
		///           </exception>
		// Token: 0x0600018B RID: 395 RVA: 0x00003C08 File Offset: 0x00001E08
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
				throw ECDsa.HashAlgorithmNameNullOrEmpty();
			}
			byte[] hash = this.HashData(data, offset, count, hashAlgorithm);
			return this.VerifyHash(hash, signature);
		}

		/// <summary>
		///         Проверяет допустимость цифровой подписи путем вычисления хэш-значения заданного потока с помощью указанного алгоритма хэширования и его сравнения с предоставленной подписью.
		///       </summary>
		/// <param name="data">
		///           Подписанные данные.
		///         </param>
		/// <param name="signature">
		///           Данные подписи, которые требуется поверить.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Алгоритм хэширования, используемый для создания хэш-значения данных.
		///         </param>
		/// <returns>
		///         <see langword="true" />, если подпись является допустимой. В противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///
		///             -или-
		///
		///             Свойство <paramref name="signature" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.
		///           </exception>
		// Token: 0x0600018C RID: 396 RVA: 0x00003C88 File Offset: 0x00001E88
		public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm)
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
				throw ECDsa.HashAlgorithmNameNullOrEmpty();
			}
			byte[] hash = this.HashData(data, hashAlgorithm);
			return this.VerifyHash(hash, signature);
		}

		/// <summary>
		///         Если переопределено в производном классе, экспортирует именованные или явные параметры для эллиптической кривой.
		///          Если кривая имеет имя, поле <see cref="F:System.Security.Cryptography.ECParameters.Curve" /> содержит параметры именованной кривой; в противном случае оно содержит параметры явной кривой.
		///       </summary>
		/// <param name="includePrivateParameters">
		///           Значение <see langword="true" /> для включения закрытых параметров; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <returns>
		///         Параметры, представляющие точку на кривой для этого ключа.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600018D RID: 397 RVA: 0x000039F5 File Offset: 0x00001BF5
		public virtual ECParameters ExportParameters(bool includePrivateParameters)
		{
			throw new NotSupportedException(SR.GetString("Method not supported. Derived class must override."));
		}

		/// <summary>
		///         Если переопределено в производном классе, экспортирует явные параметры для эллиптической кривой.
		///       </summary>
		/// <param name="includePrivateParameters">
		///           Значение <see langword="true" /> для включения закрытых параметров; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <returns>
		///         Параметры, представляющие точку на кривой для этого ключа, в формате явной кривой.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600018E RID: 398 RVA: 0x000039F5 File Offset: 0x00001BF5
		public virtual ECParameters ExportExplicitParameters(bool includePrivateParameters)
		{
			throw new NotSupportedException(SR.GetString("Method not supported. Derived class must override."));
		}

		/// <summary>
		///         Если переопределено в производном классе, импортирует указанные объекты.
		///       </summary>
		/// <param name="parameters">
		///           Параметры кривой.
		///         </param>
		/// <exception cref="T:System.NotSupportedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600018F RID: 399 RVA: 0x000039F5 File Offset: 0x00001BF5
		public virtual void ImportParameters(ECParameters parameters)
		{
			throw new NotSupportedException(SR.GetString("Method not supported. Derived class must override."));
		}

		/// <summary>
		///         При переопределении в производном классе создает новую пару открытого и закрытого ключей для указанной кривой.
		///       </summary>
		/// <param name="curve">
		///           Кривая для использования.
		///         </param>
		/// <exception cref="T:System.NotSupportedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x06000190 RID: 400 RVA: 0x000039F5 File Offset: 0x00001BF5
		public virtual void GenerateKey(ECCurve curve)
		{
			throw new NotSupportedException(SR.GetString("Method not supported. Derived class must override."));
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000039E4 File Offset: 0x00001BE4
		private static Exception DerivedClassMustOverride()
		{
			return new NotImplementedException(SR.GetString("Method not supported. Derived class must override."));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003CD6 File Offset: 0x00001ED6
		internal static Exception HashAlgorithmNameNullOrEmpty()
		{
			return new ArgumentException(SR.GetString("The hash algorithm name cannot be null or empty."), "hashAlgorithm");
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003CEC File Offset: 0x00001EEC
		protected virtual bool TryHashData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(data.Length);
			bool result;
			try
			{
				data.CopyTo(array);
				byte[] array2 = this.HashData(array, 0, data.Length, hashAlgorithm);
				if (array2.Length <= destination.Length)
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

		// Token: 0x06000194 RID: 404 RVA: 0x00003D84 File Offset: 0x00001F84
		public virtual bool TrySignHash(ReadOnlySpan<byte> hash, Span<byte> destination, out int bytesWritten)
		{
			byte[] array = this.SignHash(hash.ToArray());
			if (array.Length <= destination.Length)
			{
				new ReadOnlySpan<byte>(array).CopyTo(destination);
				bytesWritten = array.Length;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003DC5 File Offset: 0x00001FC5
		public virtual bool VerifyHash(ReadOnlySpan<byte> hash, ReadOnlySpan<byte> signature)
		{
			return this.VerifyHash(hash.ToArray(), signature.ToArray());
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003DDC File Offset: 0x00001FDC
		public virtual bool TrySignData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw new ArgumentException("The hash algorithm name cannot be null or empty.", "hashAlgorithm");
			}
			int length;
			if (this.TryHashData(data, destination, hashAlgorithm, out length) && this.TrySignHash(destination.Slice(0, length), destination, out bytesWritten))
			{
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003E34 File Offset: 0x00002034
		public virtual bool VerifyData(ReadOnlySpan<byte> data, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm)
		{
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw new ArgumentException("The hash algorithm name cannot be null or empty.", "hashAlgorithm");
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
							result = this.VerifyHash(new ReadOnlySpan<byte>(array, 0, length), signature);
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

		// Token: 0x06000198 RID: 408 RVA: 0x00003A06 File Offset: 0x00001C06
		public virtual byte[] ExportECPrivateKey()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00003A06 File Offset: 0x00001C06
		public virtual bool TryExportECPrivateKey(Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003A06 File Offset: 0x00001C06
		public virtual void ImportECPrivateKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw new PlatformNotSupportedException();
		}
	}
}
