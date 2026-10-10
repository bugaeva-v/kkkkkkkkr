using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет реализацию алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH) алгоритма криптографии следующего поколения (CNG).
	///          Этот класс используется для выполнения криптографических операций.
	///       </summary>
	// Token: 0x0200036D RID: 877
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ECDiffieHellmanCng : ECDiffieHellman
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /> с парой случайных пар ключей.
		///       </summary>
		// Token: 0x06001AAF RID: 6831 RVA: 0x0000235B File Offset: 0x0000055B
		public ECDiffieHellmanCng()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /> с созданной случайным образом парой ключей указанного размера.
		///       </summary>
		/// <param name="keySize">
		///           Размер ключа.
		///            Допустимые размеры ключей: 256, 384 и 521 бит.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="keySize" /> задает недопустимую длину.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Классы криптографии следующего поколения (CNG) не поддерживаются в этой системе.
		///           </exception>
		// Token: 0x06001AB0 RID: 6832 RVA: 0x0000235B File Offset: 0x0000055B
		public ECDiffieHellmanCng(int keySize)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" />, используя указанный объект <see cref="T:System.Security.Cryptography.CngKey" />.
		///       </summary>
		/// <param name="key">
		///           Ключ, который будет использоваться в качестве входных данных для криптографических операций, выполняемых текущим объектом.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="key" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="key" /> не указывайте группу алгоритмов алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Классы криптографии следующего поколения (CNG) не поддерживаются в этой системе.
		///           </exception>
		// Token: 0x06001AB1 RID: 6833 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		public ECDiffieHellmanCng(CngKey key)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Создает новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" />, пара открытого и закрытого ключей которого создается на основе указанной кривой.
		///       </summary>
		/// <param name="curve">
		///           Кривая, используемая для создания пары открытого и закрытого ключей.
		///         </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="curve" /> не выполняет проверку.
		///           </exception>
		// Token: 0x06001AB2 RID: 6834 RVA: 0x0000235B File Offset: 0x0000055B
		public ECDiffieHellmanCng(ECCurve curve)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает или задает хэш-алгоритм, используемый при генерации ключевого материала.
		///       </summary>
		/// <returns>
		///         Объект, задающий хэш-алгоритм.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение равно <see langword="null." />
		///           </exception>
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x0000235B File Offset: 0x0000055B
		public CngAlgorithm HashAlgorithm
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает или задает ключ хэш-сообщения проверки подлинности кода (HMAC), используемый при формировании ключевого материала.
		///       </summary>
		/// <returns>
		///         Ключ хэш-сообщения проверки подлинности кода (HMAC), используемый при формировании ключевого материала.
		///       </returns>
		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x0000235B File Offset: 0x0000055B
		public byte[] HmacKey
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Указывает <see cref="T:System.Security.Cryptography.CngKey" /> используемый текущим объектом для криптографических операций.
		///       </summary>
		/// <returns>
		///         Пара ключей, используемые этим объектом для выполнения криптографических операций.
		///       </returns>
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0005A05A File Offset: 0x0005825A
		public CngKey Key
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает или задает функцию формирования ключа для <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /> класса.
		///       </summary>
		/// <returns>
		///         Один из <see cref="T:System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction" /> значений перечисления: <see cref="F:System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction.Hash" />, <see cref="F:System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction.Hmac" />, или <see cref="F:System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction.Tls" />.
		///          Значение по умолчанию — <see cref="F:System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction.Hash" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение перечисления находится вне диапазона.
		///           </exception>
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0005A09C File Offset: 0x0005829C
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0000235B File Offset: 0x0000055B
		public ECDiffieHellmanKeyDerivationFunction KeyDerivationFunction
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return ECDiffieHellmanKeyDerivationFunction.Hash;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает или задает значение метки, используемый для формирования ключа.
		///       </summary>
		/// <returns>
		///         Значение метки.
		///       </returns>
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0000235B File Offset: 0x0000055B
		public byte[] Label
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает открытый ключ, который может использоваться в другом <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /> объект для создания общего секретного соглашения.
		///       </summary>
		/// <returns>
		///         Открытый ключ, связанный с этим экземпляром <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /> объекта.
		///       </returns>
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0005A05A File Offset: 0x0005825A
		public override ECDiffieHellmanPublicKey PublicKey
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, добавляемое к концу секретного соглашения при генерации ключевого материала.
		///       </summary>
		/// <returns>
		///         Значение, добавляемое к концу секретного соглашения.
		///       </returns>
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0000235B File Offset: 0x0000055B
		public byte[] SecretAppend
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает или задает значение, добавляемое к началу секретного соглашения при формировании ключевого материала.
		///       </summary>
		/// <returns>
		///         Значение, добавляемое к началу секретного соглашения при формировании ключевого материала.
		///       </returns>
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0000235B File Offset: 0x0000055B
		public byte[] SecretPrepend
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает или задает начальное значение, которое будет использоваться при формировании ключевого материала.
		///       </summary>
		/// <returns>
		///         Начальное значение.
		///       </returns>
		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x0000235B File Offset: 0x0000055B
		public byte[] Seed
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, используется ли секретное соглашение в качестве ключа хэш-сообщения проверки подлинности кода (HMAC) для получения материала ключа.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если секретное соглашение используется в качестве ключа HMAC для формирования ключевого материала; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0005A0B8 File Offset: 0x000582B8
		public bool UseSecretAgreementAsHmacKey
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>
		///         Получение материала ключа, созданный из секретного соглашения между двумя сторонами, используя заданный <see cref="T:System.Security.Cryptography.CngKey" /> объект, содержащий открытый ключ второй стороны.
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Объект, содержащий открытая часть ключа алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH) от другой стороны, при обмене ключами.
		///         </param>
		/// <returns>
		///         Массив байтов, содержащий ключевой материал.
		///          Эта информация формируется из секретного соглашения, которое вычисляется на основе закрытого ключа текущего объекта и указанного открытого ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="otherPartyPublicKey" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="otherPartyPublicKey" /> недопустим.
		///              Либо его <see cref="P:System.Security.Cryptography.CngKey.AlgorithmGroup" /> не содержит свойство <see cref="P:System.Security.Cryptography.CngAlgorithmGroup.ECDiffieHellman" /> или его размер ключа не соответствует размер ключа данного экземпляра.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Этот объект <see cref="P:System.Security.Cryptography.ECDiffieHellmanCng.KeyDerivationFunction" /> указывает свойство <see cref="F:System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction.Tls" /> функцию формирования ключа, но либо <see cref="P:System.Security.Cryptography.ECDiffieHellmanCng.Label" /> или <see cref="P:System.Security.Cryptography.ECDiffieHellmanCng.Seed" /> — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06001AC4 RID: 6852 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecuritySafeCritical]
		public byte[] DeriveKeyMaterial(CngKey otherPartyPublicKey)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Получает дескриптор секретного соглашения, заключенного между двумя сторонами, используя заданный <see cref="T:System.Security.Cryptography.CngKey" /> объект, содержащий открытый ключ второй стороны.
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Объект, содержащий открытая часть ключа алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH) от другой стороны, при обмене ключами.
		///         </param>
		/// <returns>
		///         Дескриптор секретного соглашения.
		///          Эта информация вычисляется на основе закрытого ключа текущего объекта и указанного открытого ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="otherPartyPublicKey" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="otherPartyPublicKey" /> не является ключом ECDH или не является правильным размером.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06001AC5 RID: 6853 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public SafeNCryptSecretHandle DeriveSecretAgreementHandle(CngKey otherPartyPublicKey)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Получает дескриптор секретного соглашения, заключенного между двумя сторонами, используя заданный <see cref="T:System.Security.Cryptography.ECDiffieHellmanPublicKey" /> объект, содержащий открытый ключ второй стороны.
		///       </summary>
		/// <param name="otherPartyPublicKey">
		///           Открытый ключ из другой стороне обмена ключами.
		///         </param>
		/// <returns>
		///         Дескриптор секретного соглашения.
		///          Эта информация вычисляется на основе закрытого ключа текущего объекта и указанного открытого ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="otherPartyPublicKey" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="otherPartyPublicKey" /> не <see cref="T:System.Security.Cryptography.ECDiffieHellmanPublicKey" /> ключа.
		///           </exception>
		// Token: 0x06001AC6 RID: 6854 RVA: 0x0005A05A File Offset: 0x0005825A
		public SafeNCryptSecretHandle DeriveSecretAgreementHandle(ECDiffieHellmanPublicKey otherPartyPublicKey)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Выполняет десериализацию данных ключа из XML-строки, используя указанный формат.
		///       </summary>
		/// <param name="xml">
		///           Основанный на XML данные ключа для десериализации.
		///         </param>
		/// <param name="format">
		///           Одно из значений перечисления, задающее формат XML-строки.
		///            Единственный момент принятый формат <see cref="F:System.Security.Cryptography.ECKeyXmlFormat.Rfc4050" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="xml" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="xml" /> Неправильный формат.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="format" /> указывает недопустимый формат.
		///              Единственным допустимым значением является <see cref="F:System.Security.Cryptography.ECKeyXmlFormat.Rfc4050" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06001AC7 RID: 6855 RVA: 0x0000235B File Offset: 0x0000055B
		public void FromXmlString(string xml, ECKeyXmlFormat format)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Сериализует данные ключа в XML-строку, используя указанный формат.
		///       </summary>
		/// <param name="format">
		///           Одно из значений перечисления, задающее формат XML-строки.
		///            Единственный момент принятый формат <see cref="F:System.Security.Cryptography.ECKeyXmlFormat.Rfc4050" />.
		///         </param>
		/// <returns>
		///         Строковый объект, содержащий данные ключа, сериализованные в XML-строку, в соответствии с требуемый формат.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="format" /> указывает недопустимый формат.
		///              Единственным допустимым значением является <see cref="F:System.Security.Cryptography.ECKeyXmlFormat.Rfc4050" />.
		///           </exception>
		// Token: 0x06001AC8 RID: 6856 RVA: 0x0005A05A File Offset: 0x0005825A
		public string ToXmlString(ECKeyXmlFormat format)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
