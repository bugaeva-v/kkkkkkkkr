using System;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет абстрактный базовый класс, эллиптических кривых Диффи-Хелмана (ECDH) могут быть производными реализаций алгоритмов.
	///          Этот класс предоставляет базовый набор операций, которые должны поддерживать все реализации алгоритма ECDH.
	///       </summary>
	// Token: 0x02000048 RID: 72
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public abstract class ECDiffieHellman : AsymmetricAlgorithm
	{
		/// <summary>
		///         Получает имя алгоритма обмена ключами.
		///       </summary>
		/// <returns>
		///         Имя алгоритма обмена ключами.
		///       </returns>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00003926 File Offset: 0x00001B26
		public override string KeyExchangeAlgorithm
		{
			get
			{
				return "ECDiffieHellman";
			}
		}

		/// <summary>
		///         Получает имя алгоритма подписи.
		///       </summary>
		/// <returns>
		///         Всегда <see langword="null" />.
		///       </returns>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000392D File Offset: 0x00001B2D
		public override string SignatureAlgorithm
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///         Создает новый экземпляр реализации по умолчанию алгоритма алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH).
		///       </summary>
		/// <returns>
		///         Новый экземпляр реализации по умолчанию этого класса.
		///       </returns>
		// Token: 0x06000161 RID: 353 RVA: 0x000023CA File Offset: 0x000005CA
		public new static ECDiffieHellman Create()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает экземпляр указанной реализации алгоритма Диффи — Хеллмана на эллиптических кривых (ECDH).
		///       </summary>
		/// <param name="algorithm">
		///           Название реализации алгоритма ECDH.
		///         </param>
		/// <returns>
		///         Новый экземпляр указанной реализации этого класса.
		///          Если указанное название алгоритма не соответствует реализации ECDH, этот метод возвращает значение <see langword="null" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="algorithm" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000162 RID: 354 RVA: 0x00003930 File Offset: 0x00001B30
		public new static ECDiffieHellman Create(string algorithm)
		{
			if (algorithm == null)
			{
				throw new ArgumentNullException("algorithm");
			}
			return CryptoConfig.CreateFromName(algorithm) as ECDiffieHellman;
		}

		/// <summary>
		///         Создает новый экземпляр реализации по умолчанию алгоритма эллиптической кривой Диффи-Хелмана (ECDH) с новой парой открытого и закрытого ключей, созданных на основе указанной кривой.
		///       </summary>
		/// <param name="curve">
		///           Кривая, используемая для создания новой пары открытого и закрытого ключей.
		///         </param>
		/// <returns>
		///         Новый экземпляр реализации по умолчанию алгоритма эллиптической кривой Диффи-Хелмана (ECDH).
		///       </returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="curve" /> не выполняет проверку.
		///           </exception>
		// Token: 0x06000163 RID: 355 RVA: 0x0000394C File Offset: 0x00001B4C
		public static ECDiffieHellman Create(ECCurve curve)
		{
			ECDiffieHellman ecdiffieHellman = ECDiffieHellman.Create();
			if (ecdiffieHellman != null)
			{
				try
				{
					ecdiffieHellman.GenerateKey(curve);
				}
				catch
				{
					ecdiffieHellman.Dispose();
					throw;
				}
			}
			return ecdiffieHellman;
		}

		/// <summary>
		///         Создает новый экземпляр реализации по умолчанию алгоритма эллиптической кривой Диффи-Хелмана (ECDH) с ключом, описываемым указанным объектом <see cref="T:System.Security.Cryptography.ECParameters" />.
		///       </summary>
		/// <param name="parameters">
		///           Параметры для алгоритма шифрования на основе эллиптических кривых (ECC).
		///         </param>
		/// <returns>
		///         Новый экземпляр реализации по умолчанию алгоритма эллиптической кривой Диффи-Хелмана (ECDH).
		///       </returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="parameters" /> не выполняет проверку.
		///           </exception>
		// Token: 0x06000164 RID: 356 RVA: 0x00003988 File Offset: 0x00001B88
		public static ECDiffieHellman Create(ECParameters parameters)
		{
			ECDiffieHellman ecdiffieHellman = ECDiffieHellman.Create();
			if (ecdiffieHellman != null)
			{
				try
				{
					ecdiffieHellman.ImportParameters(parameters);
				}
				catch
				{
					ecdiffieHellman.Dispose();
					throw;
				}
			}
			return ecdiffieHellman;
		}

		/// <summary>
		///         Возвращает открытый ключ, используемый в текущем экземпляре алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH).
		///       </summary>
		/// <returns>
		///         Открытая часть пары ключей ECDH, который используется в этом <see cref="T:System.Security.Cryptography.ECDiffieHellman" /> экземпляр.
		///       </returns>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000165 RID: 357
		public abstract ECDiffieHellmanPublicKey PublicKey { get; }

		/// <summary>
		///         Является производным байтов, которые можно использовать в качестве ключа, открытый ключ другой стороны.
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Открытый ключ другой стороны.
		///         </param>
		/// <returns>
		///         Материал ключа из обмена ключами, с другой стороны открытого ключа.
		///       </returns>
		// Token: 0x06000166 RID: 358 RVA: 0x000039C4 File Offset: 0x00001BC4
		public virtual byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey)
		{
			throw ECDiffieHellman.DerivedClassMustOverride();
		}

		/// <summary>
		///         Извлекает с помощью хэш-функции байты, которые можно использовать в качестве ключа, учитывая открытый ключ другой стороны и имя хэш-алгоритма.
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Открытый ключ другой стороны.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Хэш-алгоритм, используемый для формирования материала ключа.
		///         </param>
		/// <returns>
		///         Материал ключа, полученный при обмене ключами с открытым ключом другой стороны.
		///       </returns>
		// Token: 0x06000167 RID: 359 RVA: 0x000039CB File Offset: 0x00001BCB
		public byte[] DeriveKeyFromHash(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm)
		{
			return this.DeriveKeyFromHash(otherPartyPublicKey, hashAlgorithm, null, null);
		}

		/// <summary>
		///         Если реализуется в производном классе, то извлекает с помощью хэш-функции байты, которые можно использовать в качестве ключа, учитывая открытый ключ другой стороны, имя хэш-алгоритма и добавленное значение (в начало и конец).
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Открытый ключ другой стороны.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Хэш-алгоритм, используемый для формирования материала ключа.
		///         </param>
		/// <param name="secretPrepend">
		///           Значение, добавляемое к производному секрету (в начало) перед хэшированием.
		///         </param>
		/// <param name="secretAppend">
		///           Значение, добавляемое к производному секрету перед хэшированием.
		///         </param>
		/// <returns>
		///         Материал ключа, полученный при обмене ключами с открытым ключом другой стороны.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x06000168 RID: 360 RVA: 0x000039C4 File Offset: 0x00001BC4
		public virtual byte[] DeriveKeyFromHash(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm, byte[] secretPrepend, byte[] secretAppend)
		{
			throw ECDiffieHellman.DerivedClassMustOverride();
		}

		/// <summary>
		///         Получает последовательность байтов, которые можно использовать в качестве ключа, использующего код проверки подлинности хэш-сообщения (HMAC).
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Открытый ключ другой стороны.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Хэш-алгоритм, используемый для получения материала ключа.
		///         </param>
		/// <param name="hmacKey">
		///           Ключ HMAC.
		///         </param>
		/// <returns>
		///         Материал ключа, полученный при обмене ключами с открытым ключом другой стороны.
		///       </returns>
		// Token: 0x06000169 RID: 361 RVA: 0x000039D7 File Offset: 0x00001BD7
		public byte[] DeriveKeyFromHmac(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm, byte[] hmacKey)
		{
			return this.DeriveKeyFromHmac(otherPartyPublicKey, hashAlgorithm, hmacKey, null, null);
		}

		/// <summary>
		///         При применении в производном классе получает последовательность байтов, которые можно использовать в качестве ключа, использующего код проверки подлинности хэш-сообщения (HMAC).
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Открытый ключ другой стороны.
		///         </param>
		/// <param name="hashAlgorithm">
		///           Хэш-алгоритм, используемый для получения материала ключа.
		///         </param>
		/// <param name="hmacKey">
		///           Ключ HMAC.
		///         </param>
		/// <param name="secretPrepend">
		///           Значение, добавляемое к производному секрету (в начало) перед хэшированием.
		///         </param>
		/// <param name="secretAppend">
		///           Значение, добавляемое к производному секрету перед хэшированием.
		///         </param>
		/// <returns>
		///         Материал ключа, полученный при обмене ключами с открытым ключом другой стороны.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600016A RID: 362 RVA: 0x000039C4 File Offset: 0x00001BC4
		public virtual byte[] DeriveKeyFromHmac(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm, byte[] hmacKey, byte[] secretPrepend, byte[] secretAppend)
		{
			throw ECDiffieHellman.DerivedClassMustOverride();
		}

		/// <summary>
		///         При применении в производном классе извлекает байты, которые могут использоваться как ключ с применением алгоритма получения псевдослучайной функции (PRF) протокола TLS.
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Открытый ключ другой стороны.
		///         </param>
		/// <param name="prfLabel">
		///           Метка PRF с использованием кодировки ASCII.
		///         </param>
		/// <param name="prfSeed">
		///           Начальное значение PRF (64-байтовое).
		///         </param>
		/// <returns>
		///         Материал ключа, полученный при обмене ключами с открытым ключом другой стороны.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600016B RID: 363 RVA: 0x000039C4 File Offset: 0x00001BC4
		public virtual byte[] DeriveKeyTls(ECDiffieHellmanPublicKey otherPartyPublicKey, byte[] prfLabel, byte[] prfSeed)
		{
			throw ECDiffieHellman.DerivedClassMustOverride();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000039E4 File Offset: 0x00001BE4
		private static Exception DerivedClassMustOverride()
		{
			return new NotImplementedException(SR.GetString("Method not supported. Derived class must override."));
		}

		/// <summary>
		///         При переопределении в производном классе экспортирует сведения об открытом или открытом и закрытом ключе из рабочего раздела <see cref="T:System.Security.Cryptography.ECDiffieHellman" />, в структуру <see cref="T:System.Security.Cryptography.ECParameters" /> таким образом, чтобы их можно было передать в метод <see cref="M:System.Security.Cryptography.ECDiffieHellman.ImportParameters(System.Security.Cryptography.ECParameters)" />.
		///       </summary>
		/// <param name="includePrivateParameters">
		///           <see langword="true" /> для включения закрытых параметров; в противном случае — <see langword="false" /> для включения только открытых параметров.
		///         </param>
		/// <returns>
		///         Объект, представляющий точку на кривой для этого ключа.
		///          Может передаваться в метод <see cref="M:System.Security.Cryptography.ECDiffieHellman.ImportParameters(System.Security.Cryptography.ECParameters)" />.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600016D RID: 365 RVA: 0x000039C4 File Offset: 0x00001BC4
		public virtual ECParameters ExportParameters(bool includePrivateParameters)
		{
			throw ECDiffieHellman.DerivedClassMustOverride();
		}

		/// <summary>
		///         При переопределении в производном классе экспортирует сведения об открытом или открытом и закрытом ключе, используя формат явной кривой в работающем разделе <see cref="T:System.Security.Cryptography.ECDiffieHellman" />, в структуру <see cref="T:System.Security.Cryptography.ECParameters" /> таким образом, чтобы их можно было передать в метод <see cref="M:System.Security.Cryptography.ECDiffieHellman.ImportParameters(System.Security.Cryptography.ECParameters)" />.
		///       </summary>
		/// <param name="includePrivateParameters">
		///           Значение <see langword="true" /> для включения закрытых параметров; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <returns>
		///         Объект, представляющий точку на кривой для этого ключа, в формате явной кривой.
		///       </returns>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600016E RID: 366 RVA: 0x000039C4 File Offset: 0x00001BC4
		public virtual ECParameters ExportExplicitParameters(bool includePrivateParameters)
		{
			throw ECDiffieHellman.DerivedClassMustOverride();
		}

		/// <summary>
		///         При переопределении в производном классе импортирует заданные параметры для <see cref="T:System.Security.Cryptography.ECCurve" /> как эфемерный ключ в текущий объект <see cref="T:System.Security.Cryptography.ECDiffieHellman" />.
		///       </summary>
		/// <param name="parameters">
		///           Параметры кривой для импорта.
		///         </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="parameters" /> не выполняет проверку.
		///           </exception>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600016F RID: 367 RVA: 0x000039C4 File Offset: 0x00001BC4
		public virtual void ImportParameters(ECParameters parameters)
		{
			throw ECDiffieHellman.DerivedClassMustOverride();
		}

		/// <summary>
		///         При переопределении в производном классе создает новую пару открытого и закрытого эфемерных ключей для указанной кривой.
		///       </summary>
		/// <param name="curve">
		///           Кривая, используемая для создания пары открытого и закрытого эфемерных ключей.
		///         </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="curve" /> не выполняет проверку.
		///           </exception>
		/// <exception cref="T:System.NotImplementedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x06000170 RID: 368 RVA: 0x000039F5 File Offset: 0x00001BF5
		public virtual void GenerateKey(ECCurve curve)
		{
			throw new NotSupportedException(SR.GetString("Method not supported. Derived class must override."));
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00003A06 File Offset: 0x00001C06
		public virtual byte[] ExportECPrivateKey()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00003A06 File Offset: 0x00001C06
		public virtual bool TryExportECPrivateKey(Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00003A06 File Offset: 0x00001C06
		public virtual void ImportECPrivateKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw new PlatformNotSupportedException();
		}
	}
}
