using System;
using System.IO;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет реализацию алгоритма цифровых подписей на основе эллиптических кривых (ECDSA) на платформе криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x0200004B RID: 75
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ECDsaCng : ECDsa
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDsaCng" /> с парой случайных пар ключей.
		///       </summary>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Классы криптографии следующего поколения (CNG) не поддерживаются в этой системе.
		///           </exception>
		// Token: 0x0600019C RID: 412 RVA: 0x00003EC8 File Offset: 0x000020C8
		public ECDsaCng() : this(521)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDsaCng" /> с созданной случайным образом парой ключей указанного размера.
		///       </summary>
		/// <param name="keySize">
		///           Размер ключа.
		///            Допустимые размеры ключей: 256, 384 и 521 бит.
		///         </param>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Классы криптографии следующего поколения (CNG) не поддерживаются в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="keySize" /> задает недопустимую длину.
		///           </exception>
		// Token: 0x0600019D RID: 413 RVA: 0x00003ED5 File Offset: 0x000020D5
		public ECDsaCng(int keySize)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDsaCng" />, используя указанный объект <see cref="T:System.Security.Cryptography.CngKey" />.
		///       </summary>
		/// <param name="key">
		///           Ключ, который будет использоваться в качестве входных данных для криптографических операций, выполняемых текущим объектом.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="key" /> не указывает группу алгоритмов цифровых подписей на основе эллиптических кривых (ECDSA).
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="key" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Классы криптографии следующего поколения (CNG) не поддерживаются в этой системе.
		///           </exception>
		// Token: 0x0600019E RID: 414 RVA: 0x00003ED5 File Offset: 0x000020D5
		[SecuritySafeCritical]
		public ECDsaCng(CngKey key)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDsaCng" />, пара открытого и закрытого ключей которого создается на основе указанной кривой.
		///       </summary>
		/// <param name="curve">
		///           Кривая, используемая для создания пары открытого и закрытого ключей.
		///         </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="curve" /> не выполняет проверку.
		///           </exception>
		// Token: 0x0600019F RID: 415 RVA: 0x00003ED5 File Offset: 0x000020D5
		public ECDsaCng(ECCurve curve)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Возвращает или задает хэш-алгоритм, используемый при подписывании и проверке данных.
		///       </summary>
		/// <returns>
		///         Объект, задающий хэш-алгоритм.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00003EE2 File Offset: 0x000020E2
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00003EEA File Offset: 0x000020EA
		public CngAlgorithm HashAlgorithm { get; set; }

		/// <summary>
		///         Возвращает или задает ключ, используемый при подписании и проверке данных.
		///       </summary>
		/// <returns>
		///         Объект, задающий ключ.
		///       </returns>
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x000023CA File Offset: 0x000005CA
		public CngKey Key
		{
			get
			{
				throw new NotImplementedException();
			}
			private set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Создает подпись для указанного хэш-значения.
		///       </summary>
		/// <param name="hash">
		///           Хэш-значение подписываемых данных.
		///         </param>
		/// <returns>
		///         Цифровая подпись для указанного хэш-значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="hash" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Информация ключа, связанного с экземпляром, который не имеет закрытого ключа.
		///           </exception>
		// Token: 0x060001A4 RID: 420 RVA: 0x000023CA File Offset: 0x000005CA
		public override byte[] SignHash(byte[] hash)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Проверяет указанную цифровую подпись для заданного хэш-значения.
		///       </summary>
		/// <param name="hash">
		///           Хэш-значение проверяемых данных.
		///         </param>
		/// <param name="signature">
		///           Цифровая подпись данных, которую требуется проверить с использованием хэш-значения.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если подпись является допустимой; в противном случае — значение <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="hash" /> или <paramref name="signature" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060001A5 RID: 421 RVA: 0x000023CA File Offset: 0x000005CA
		public override bool VerifyHash(byte[] hash, byte[] signature)
		{
			throw new NotImplementedException();
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
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="format" /> указывает недопустимый формат.
		///              Единственным допустимым значением является <see cref="F:System.Security.Cryptography.ECKeyXmlFormat.Rfc4050" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x060001A6 RID: 422 RVA: 0x000023CA File Offset: 0x000005CA
		public void FromXmlString(string xml, ECKeyXmlFormat format)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает подпись для указанных данных.
		///       </summary>
		/// <param name="data">
		///           Данные сообщения должны быть подписаны.
		///         </param>
		/// <returns>
		///         Цифровая подпись для указанных данных.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Информация ключа, связанного с экземпляром, который не имеет закрытого ключа.
		///           </exception>
		// Token: 0x060001A7 RID: 423 RVA: 0x000023CA File Offset: 0x000005CA
		public byte[] SignData(byte[] data)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает подпись для указанного потока данных, чтения в конец потока.
		///       </summary>
		/// <param name="data">
		///           Поток данных, должны быть подписаны.
		///         </param>
		/// <returns>
		///         Цифровая подпись для указанного потока данных.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Информация ключа, связанного с экземпляром, который не имеет закрытого ключа.
		///           </exception>
		// Token: 0x060001A8 RID: 424 RVA: 0x000023CA File Offset: 0x000005CA
		public byte[] SignData(Stream data)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает цифровую подпись для указанного фрагмента данных, начиная с указанной позиции.
		///       </summary>
		/// <param name="data">
		///           Данные сообщения должны быть подписаны.
		///         </param>
		/// <param name="offset">
		///           Место в строке, с которой следует начать подписывание.
		///         </param>
		/// <param name="count">
		///           Длина строки в знаках, <paramref name="offset" /> будет выполнен вход.
		///         </param>
		/// <returns>
		///         Цифровая подпись для указанного фрагмента данных.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="count" /> или <paramref name="offset" /> вызвала чтения за пределами строки данных.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Информация ключа, связанного с экземпляром, который не имеет закрытого ключа.
		///           </exception>
		// Token: 0x060001A9 RID: 425 RVA: 0x000023CA File Offset: 0x000005CA
		public byte[] SignData(byte[] data, int offset, int count)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Сериализует данные ключа в XML-строку, используя указанный формат.
		///       </summary>
		/// <param name="format">
		///           Одно из значений перечисления, задающее формат XML-строки.
		///            Единственный момент принятый формат <see cref="F:System.Security.Cryptography.ECKeyXmlFormat.Rfc4050" />.
		///         </param>
		/// <returns>
		///         Строковый объект, содержащий данные ключа, сериализованные в XML-строку в соответствии с требуемый формат.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="format" /> указывает недопустимый формат.
		///              Единственным допустимым значением является <see cref="F:System.Security.Cryptography.ECKeyXmlFormat.Rfc4050" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x060001AA RID: 426 RVA: 0x000023CA File Offset: 0x000005CA
		public string ToXmlString(ECKeyXmlFormat format)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Проверяет цифровую подпись указанных данных.
		///       </summary>
		/// <param name="data">
		///           подписанные данные;
		///         </param>
		/// <param name="signature">
		///           Подпись для проверки.
		///         </param>
		/// <returns>
		///         <see langword="true" />, если подпись является допустимой. В противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="data" /> или <paramref name="signature" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060001AB RID: 427 RVA: 0x000023CA File Offset: 0x000005CA
		public bool VerifyData(byte[] data, byte[] signature)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Проверяет цифровую подпись для указанного потока данных, чтения в конец потока.
		///       </summary>
		/// <param name="data">
		///           Поток данных, который был подписан.
		///         </param>
		/// <param name="signature">
		///           Подпись для проверки.
		///         </param>
		/// <returns>
		///         <see langword="true" />, если подпись является допустимой. В противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="data" /> или <paramref name="signature" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060001AC RID: 428 RVA: 0x000023CA File Offset: 0x000005CA
		public bool VerifyData(Stream data, byte[] signature)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Проверяет подпись для указанного фрагмента данных, начиная с указанной позиции.
		///       </summary>
		/// <param name="data">
		///           подписанные данные;
		///         </param>
		/// <param name="offset">
		///           Расположение в данных, с которого начинается подписанные данные.
		///         </param>
		/// <param name="count">
		///           Длина данных в следующих символов <paramref name="offset" /> будет выполнен вход.
		///         </param>
		/// <param name="signature">
		///           Подпись для проверки.
		///         </param>
		/// <returns>
		///         <see langword="true" />, если подпись является допустимой. В противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="offset" /> или <paramref name="count" /> — меньше нуля.
		///
		///             -или-
		///
		///             <paramref name="offset" /> или <paramref name="count" /> больше, чем длина массива байтов, передаваемый в <paramref name="data" /> параметр.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="data" /> или <paramref name="signature" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060001AD RID: 429 RVA: 0x000023CA File Offset: 0x000005CA
		public bool VerifyData(byte[] data, int offset, int count, byte[] signature)
		{
			throw new NotImplementedException();
		}
	}
}
