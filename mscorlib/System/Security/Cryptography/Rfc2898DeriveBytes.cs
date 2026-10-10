using System;
using System.Buffers;
using System.Text;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Реализует функцию формирования ключа на основе пароля (PBKDF2) посредством генератора псевдослучайных чисел <see cref="T:System.Security.Cryptography.HMACSHA1" />.</summary>
	// Token: 0x02000466 RID: 1126
	public class Rfc2898DeriveBytes : DeriveBytes
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002DBB RID: 11707 RVA: 0x000A3B6C File Offset: 0x000A1D6C
		public HashAlgorithmName HashAlgorithm { get; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />, используя пароль, расширяющее значение и число итераций для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль, используемая для формирования ключа.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		/// <exception cref="T:System.ArgumentException">Размер указанного расширяющего значения менее 8 байт, а число итераций менее 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Пароль или расширяющее значение равны <see langword="null" />.</exception>
		// Token: 0x06002DBC RID: 11708 RVA: 0x000A3B74 File Offset: 0x000A1D74
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations) : this(password, salt, iterations, HashAlgorithmName.SHA1)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />, используя заданные пароль, случайные данные, число итераций и имя хэш-алгоритма для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль ключа, используемая для формирования ключа.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		/// <param name="hashAlgorithm">Имя хэш-алгоритма, используемое для формирования ключа.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="saltSize" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> — <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимое имя хэш-алгоритма.</exception>
		// Token: 0x06002DBD RID: 11709 RVA: 0x000A3B84 File Offset: 0x000A1D84
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
			if (salt == null)
			{
				throw new ArgumentNullException("salt");
			}
			if (salt.Length < 8)
			{
				throw new ArgumentException("Salt is not at least eight bytes.", "salt");
			}
			if (iterations <= 0)
			{
				throw new ArgumentOutOfRangeException("iterations", "Positive number required.");
			}
			if (password == null)
			{
				throw new NullReferenceException();
			}
			this._salt = salt.CloneByteArray();
			this._iterations = (uint)iterations;
			this._password = password.CloneByteArray();
			this.HashAlgorithm = hashAlgorithm;
			this._hmac = this.OpenHmac();
			this._blockSize = this._hmac.HashSize >> 3;
			this.Initialize();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />, используя пароль и соль для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль, используемая для формирования ключа.</param>
		/// <exception cref="T:System.ArgumentException">Размер указанного расширяющего значения менее 8 байт, а число итераций менее 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Пароль или расширяющее значение равны <see langword="null" />.</exception>
		// Token: 0x06002DBE RID: 11710 RVA: 0x000A3C24 File Offset: 0x000A1E24
		public Rfc2898DeriveBytes(string password, byte[] salt) : this(password, salt, 1000)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />, используя пароль, расширяющее значение и число итераций для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль, используемая для формирования ключа.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		/// <exception cref="T:System.ArgumentException">Размер указанного расширяющего значения менее 8 байт, а число итераций менее 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Пароль или расширяющее значение равны <see langword="null" />.</exception>
		// Token: 0x06002DBF RID: 11711 RVA: 0x000A3C33 File Offset: 0x000A1E33
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations) : this(password, salt, iterations, HashAlgorithmName.SHA1)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />, используя заданные пароль, случайные данные, число итераций и имя хэш-алгоритма для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль ключа, используемая для формирования ключа.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		/// <param name="hashAlgorithm">Имя хэш-алгоритма, используемое для формирования ключа.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> — <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимое имя хэш-алгоритма.</exception>
		// Token: 0x06002DC0 RID: 11712 RVA: 0x000A3C43 File Offset: 0x000A1E43
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm) : this(Encoding.UTF8.GetBytes(password), salt, iterations, hashAlgorithm)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />, используя пароль и соль для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="saltSize">Размер произвольной соли, которую должен создать класс.</param>
		/// <exception cref="T:System.ArgumentException">Указанный размер расширяющего значения менее 8 байт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Пароль или расширяющее значение равны <see langword="null" />.</exception>
		// Token: 0x06002DC1 RID: 11713 RVA: 0x000A3C5A File Offset: 0x000A1E5A
		public Rfc2898DeriveBytes(string password, int saltSize) : this(password, saltSize, 1000)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />, используя пароль, размер соли и число итераций для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="saltSize">Размер произвольной соли, которую должен создать класс.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		/// <exception cref="T:System.ArgumentException">Размер указанного расширяющего значения менее 8 байт, а число итераций менее 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Пароль или расширяющее значение равны <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="iterations" /> выходит за пределы диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		// Token: 0x06002DC2 RID: 11714 RVA: 0x000A3C69 File Offset: 0x000A1E69
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations) : this(password, saltSize, iterations, HashAlgorithmName.SHA1)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />, используя заданные пароль, размер случайных данных, число итераций и имя хэш-алгоритма для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="saltSize">Размер произвольной соли, которую должен создать класс.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		/// <param name="hashAlgorithm">Имя хэш-алгоритма, используемое для формирования ключа.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="saltSize" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /><paramref name="hashAlgorithm" /> — <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимое имя хэш-алгоритма.</exception>
		// Token: 0x06002DC3 RID: 11715 RVA: 0x000A3C7C File Offset: 0x000A1E7C
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm)
		{
			if (saltSize < 0)
			{
				throw new ArgumentOutOfRangeException("saltSize", "Non-negative number required.");
			}
			if (saltSize < 8)
			{
				throw new ArgumentException("Salt is not at least eight bytes.", "saltSize");
			}
			if (iterations <= 0)
			{
				throw new ArgumentOutOfRangeException("iterations", "Positive number required.");
			}
			this._salt = Helpers.GenerateRandom(saltSize);
			this._iterations = (uint)iterations;
			this._password = Encoding.UTF8.GetBytes(password);
			this.HashAlgorithm = hashAlgorithm;
			this._hmac = this.OpenHmac();
			this._blockSize = this._hmac.HashSize >> 3;
			this.Initialize();
		}

		/// <summary>Возвращает или задает число итераций для данной операции.</summary>
		/// <returns>Число итераций для данной операции.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число итераций менее 1.</exception>
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x000A3D1C File Offset: 0x000A1F1C
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x000A3D24 File Offset: 0x000A1F24
		public int IterationCount
		{
			get
			{
				return (int)this._iterations;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value", "Positive number required.");
				}
				this._iterations = (uint)value;
				this.Initialize();
			}
		}

		/// <summary>Возвращает или задает значение соли ключа для данной операции.</summary>
		/// <returns>Значение соли ключа для данной операции.</returns>
		/// <exception cref="T:System.ArgumentException">Указанный размер расширяющего значения менее 8 байт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Расширяющее значение равно <see langword="null" />.</exception>
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x000A3D47 File Offset: 0x000A1F47
		// (set) Token: 0x06002DC7 RID: 11719 RVA: 0x000A3D54 File Offset: 0x000A1F54
		public byte[] Salt
		{
			get
			{
				return this._salt.CloneByteArray();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.Length < 8)
				{
					throw new ArgumentException("Salt is not at least eight bytes.");
				}
				this._salt = value.CloneByteArray();
				this.Initialize();
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> (при необходимости освобождает и управляемые ресурсы).</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002DC8 RID: 11720 RVA: 0x000A3D88 File Offset: 0x000A1F88
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this._hmac != null)
				{
					this._hmac.Dispose();
					this._hmac = null;
				}
				if (this._buffer != null)
				{
					Array.Clear(this._buffer, 0, this._buffer.Length);
				}
				if (this._password != null)
				{
					Array.Clear(this._password, 0, this._password.Length);
				}
				if (this._salt != null)
				{
					Array.Clear(this._salt, 0, this._salt.Length);
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>Возвращает псевдослучайный ключ для данного объекта.</summary>
		/// <param name="cb">Число генерируемых псевдослучайных байтов ключа.</param>
		/// <returns>Массив байтов, заполненный псевдослучайными байтами ключа.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="cb" /> выходит за пределы диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		// Token: 0x06002DC9 RID: 11721 RVA: 0x000A3E10 File Offset: 0x000A2010
		public override byte[] GetBytes(int cb)
		{
			if (cb <= 0)
			{
				throw new ArgumentOutOfRangeException("cb", "Positive number required.");
			}
			byte[] array = new byte[cb];
			int i = 0;
			int num = this._endIndex - this._startIndex;
			if (num > 0)
			{
				if (cb < num)
				{
					Buffer.BlockCopy(this._buffer, this._startIndex, array, 0, cb);
					this._startIndex += cb;
					return array;
				}
				Buffer.BlockCopy(this._buffer, this._startIndex, array, 0, num);
				this._startIndex = (this._endIndex = 0);
				i += num;
			}
			while (i < cb)
			{
				byte[] src = this.Func();
				int num2 = cb - i;
				if (num2 <= this._blockSize)
				{
					Buffer.BlockCopy(src, 0, array, i, num2);
					i += num2;
					Buffer.BlockCopy(src, num2, this._buffer, this._startIndex, this._blockSize - num2);
					this._endIndex += this._blockSize - num2;
					return array;
				}
				Buffer.BlockCopy(src, 0, array, i, this._blockSize);
				i += this._blockSize;
			}
			return array;
		}

		/// <summary>Возвращает криптографический ключ из объекта <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />.</summary>
		/// <param name="algname">Имя алгоритма, используемого для формирования ключа.</param>
		/// <param name="alghashname">Имя хэш-алгоритма, используемого для формирования ключа.</param>
		/// <param name="keySize">Размер формируемого ключа в битах.</param>
		/// <param name="rgbIV">Вектор инициализации, используемый для формирования ключа.</param>
		/// <returns>Сформированный ключ.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="keySize" /> является неверным.  
		///
		/// или - 
		/// Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// Значение параметра <paramref name="algname" /> не является допустимым именем алгоритма.  
		///
		/// или - 
		/// Значение параметра <paramref name="alghashname" /> не является допустимым именем хэш-алгоритма.</exception>
		// Token: 0x06002DCA RID: 11722 RVA: 0x0001B98B File Offset: 0x00019B8B
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Восстанавливает состояние данной операции.</summary>
		// Token: 0x06002DCB RID: 11723 RVA: 0x000A3F22 File Offset: 0x000A2122
		public override void Reset()
		{
			this.Initialize();
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000A3F2C File Offset: 0x000A212C
		private HMAC OpenHmac()
		{
			HashAlgorithmName hashAlgorithm = this.HashAlgorithm;
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw new CryptographicException("The hash algorithm name cannot be null or empty.");
			}
			if (hashAlgorithm == HashAlgorithmName.SHA1)
			{
				return new HMACSHA1(this._password);
			}
			if (hashAlgorithm == HashAlgorithmName.SHA256)
			{
				return new HMACSHA256(this._password);
			}
			if (hashAlgorithm == HashAlgorithmName.SHA384)
			{
				return new HMACSHA384(this._password);
			}
			if (hashAlgorithm == HashAlgorithmName.SHA512)
			{
				return new HMACSHA512(this._password);
			}
			throw new CryptographicException(SR.Format("'{0}' is not a known hash algorithm.", hashAlgorithm.Name));
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000A3FD4 File Offset: 0x000A21D4
		private void Initialize()
		{
			if (this._buffer != null)
			{
				Array.Clear(this._buffer, 0, this._buffer.Length);
			}
			this._buffer = new byte[this._blockSize];
			this._block = 1U;
			this._startIndex = (this._endIndex = 0);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x000A4028 File Offset: 0x000A2228
		private byte[] Func()
		{
			byte[] array = new byte[this._salt.Length + 4];
			Buffer.BlockCopy(this._salt, 0, array, 0, this._salt.Length);
			Helpers.WriteInt(this._block, array, this._salt.Length);
			byte[] array2 = ArrayPool<byte>.Shared.Rent(this._blockSize);
			byte[] result;
			try
			{
				Span<byte> span = new Span<byte>(array2, 0, this._blockSize);
				int num;
				if (!this._hmac.TryComputeHash(array, span, out num) || num != this._blockSize)
				{
					throw new CryptographicException();
				}
				byte[] array3 = new byte[this._blockSize];
				span.CopyTo(array3);
				int num2 = 2;
				while ((long)num2 <= (long)((ulong)this._iterations))
				{
					if (!this._hmac.TryComputeHash(span, span, out num) || num != this._blockSize)
					{
						throw new CryptographicException();
					}
					for (int i = 0; i < this._blockSize; i++)
					{
						byte[] array4 = array3;
						int num3 = i;
						array4[num3] ^= array2[i];
					}
					num2++;
				}
				this._block += 1U;
				result = array3;
			}
			finally
			{
				Array.Clear(array2, 0, this._blockSize);
				ArrayPool<byte>.Shared.Return(array2, false);
			}
			return result;
		}

		// Token: 0x040020C3 RID: 8387
		private const int MinimumSaltSize = 8;

		// Token: 0x040020C4 RID: 8388
		private readonly byte[] _password;

		// Token: 0x040020C5 RID: 8389
		private byte[] _salt;

		// Token: 0x040020C6 RID: 8390
		private uint _iterations;

		// Token: 0x040020C7 RID: 8391
		private HMAC _hmac;

		// Token: 0x040020C8 RID: 8392
		private int _blockSize;

		// Token: 0x040020C9 RID: 8393
		private byte[] _buffer;

		// Token: 0x040020CA RID: 8394
		private uint _block;

		// Token: 0x040020CB RID: 8395
		private int _startIndex;

		// Token: 0x040020CC RID: 8396
		private int _endIndex;
	}
}
