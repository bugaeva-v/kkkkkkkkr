using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Cryptography
{
	/// <summary>Формирует ключ из пароля с помощью расширения алгоритма PBKDF1.</summary>
	// Token: 0x0200049E RID: 1182
	[ComVisible(true)]
	public class PasswordDeriveBytes : DeriveBytes
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> паролем и солью ключа, которые используются для формирования ключа.</summary>
		/// <param name="strPassword">Пароль, используемый для формирования ключа.</param>
		/// <param name="rgbSalt">Соль ключа, используемая для формирования ключа.</param>
		// Token: 0x06002F47 RID: 12103 RVA: 0x000A862D File Offset: 0x000A682D
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt) : this(strPassword, rgbSalt, new CspParameters())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> паролем и солью ключа, которые используются для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль ключа, используемая для формирования ключа.</param>
		// Token: 0x06002F48 RID: 12104 RVA: 0x000A863C File Offset: 0x000A683C
		public PasswordDeriveBytes(byte[] password, byte[] salt) : this(password, salt, new CspParameters())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> паролем, солью ключа, именем хэша и числом итераций, которые используются для формирования ключа.</summary>
		/// <param name="strPassword">Пароль, используемый для формирования ключа.</param>
		/// <param name="rgbSalt">Соль ключа, используемая для формирования ключа.</param>
		/// <param name="strHashName">Имя хэш-алгоритма для данной операции.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		// Token: 0x06002F49 RID: 12105 RVA: 0x000A864B File Offset: 0x000A684B
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations) : this(strPassword, rgbSalt, strHashName, iterations, new CspParameters())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> паролем, солью ключа, именем хэша и числом итераций, которые используются для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль ключа, используемая для формирования ключа.</param>
		/// <param name="hashName">Имя хэш-алгоритма, используемое для формирования ключа.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		// Token: 0x06002F4A RID: 12106 RVA: 0x000A865D File Offset: 0x000A685D
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations) : this(password, salt, hashName, iterations, new CspParameters())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> паролем, солью ключа и параметрами поставщика служб шифрования (CSP), которые используются для формирования ключа.</summary>
		/// <param name="strPassword">Пароль, используемый для формирования ключа.</param>
		/// <param name="rgbSalt">Соль ключа, используемая для формирования ключа.</param>
		/// <param name="cspParams">Параметры CSP для данной операции.</param>
		// Token: 0x06002F4B RID: 12107 RVA: 0x000A866F File Offset: 0x000A686F
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams) : this(strPassword, rgbSalt, "SHA1", 100, cspParams)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> паролем, солью ключа и параметрами поставщика служб шифрования (CSP), которые используются для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль ключа, используемая для формирования ключа.</param>
		/// <param name="cspParams">Параметры поставщика служб шифрования (CSP) для данной операции.</param>
		// Token: 0x06002F4C RID: 12108 RVA: 0x000A8681 File Offset: 0x000A6881
		public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams) : this(password, salt, "SHA1", 100, cspParams)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> паролем, солью ключа, именем хэша, числом итераций и параметрами поставщика служб шифрования (CSP), которые используются для формирования ключа.</summary>
		/// <param name="strPassword">Пароль, используемый для формирования ключа.</param>
		/// <param name="rgbSalt">Соль ключа, используемая для формирования ключа.</param>
		/// <param name="strHashName">Имя хэш-алгоритма для данной операции.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		/// <param name="cspParams">Параметры CSP для данной операции.</param>
		// Token: 0x06002F4D RID: 12109 RVA: 0x000A8693 File Offset: 0x000A6893
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams) : this(new UTF8Encoding(false).GetBytes(strPassword), rgbSalt, strHashName, iterations, cspParams)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> паролем, солью ключа, именем хэша, числом итераций и параметрами поставщика служб шифрования (CSP), которые используются для формирования ключа.</summary>
		/// <param name="password">Пароль, используемый для формирования ключа.</param>
		/// <param name="salt">Соль ключа, используемая для формирования ключа.</param>
		/// <param name="hashName">Имя хэш-алгоритма, используемое для формирования ключа.</param>
		/// <param name="iterations">Число итераций для данной операции.</param>
		/// <param name="cspParams">Параметры поставщика служб шифрования (CSP) для данной операции.</param>
		// Token: 0x06002F4E RID: 12110 RVA: 0x000A86AD File Offset: 0x000A68AD
		[SecuritySafeCritical]
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams)
		{
			this.IterationCount = iterations;
			this.Salt = salt;
			this.HashName = hashName;
			this._password = password;
		}

		/// <summary>Возвращает или задает имя хэш-алгоритма для данной операции.</summary>
		/// <returns>Имя хэш-алгоритма для данной операции.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Имя хэш-алгоритма является фиксированным, и предпринята попытка изменить это значение.</exception>
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x000A86D2 File Offset: 0x000A68D2
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x000A86DC File Offset: 0x000A68DC
		public string HashName
		{
			get
			{
				return this._hashName;
			}
			set
			{
				if (this._baseValue != null)
				{
					throw new CryptographicException(Environment.GetResourceString("Value of '{0}' cannot be changed after the bytes have been retrieved.", new object[]
					{
						"HashName"
					}));
				}
				this._hashName = value;
				this._hash = (HashAlgorithm)CryptoConfig.CreateFromName(this._hashName);
			}
		}

		/// <summary>Возвращает или задает число итераций для данной операции.</summary>
		/// <returns>Число итераций для данной операции.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Число итераций является фиксированным, и предпринята попытка изменить это значение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Невозможно задать свойство, поскольку его значение находится вне диапазона. Значение этого свойства не должно быть отрицательным.</exception>
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x000A872C File Offset: 0x000A692C
		// (set) Token: 0x06002F52 RID: 12114 RVA: 0x000A8734 File Offset: 0x000A6934
		public int IterationCount
		{
			get
			{
				return this._iterations;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("Positive number required."));
				}
				if (this._baseValue != null)
				{
					throw new CryptographicException(Environment.GetResourceString("Value of '{0}' cannot be changed after the bytes have been retrieved.", new object[]
					{
						"IterationCount"
					}));
				}
				this._iterations = value;
			}
		}

		/// <summary>Возвращает или задает значение соли ключа для данной операции.</summary>
		/// <returns>Значение соли ключа для данной операции.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение ключевой привязки является фиксированным, и предпринята попытка изменить это значение.</exception>
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x000A8787 File Offset: 0x000A6987
		// (set) Token: 0x06002F54 RID: 12116 RVA: 0x000A87A4 File Offset: 0x000A69A4
		public byte[] Salt
		{
			get
			{
				if (this._salt == null)
				{
					return null;
				}
				return (byte[])this._salt.Clone();
			}
			set
			{
				if (this._baseValue != null)
				{
					throw new CryptographicException(Environment.GetResourceString("Value of '{0}' cannot be changed after the bytes have been retrieved.", new object[]
					{
						"Salt"
					}));
				}
				if (value == null)
				{
					this._salt = null;
					return;
				}
				this._salt = (byte[])value.Clone();
			}
		}

		/// <summary>Возвращает псевдослучайные байты ключа.</summary>
		/// <param name="cb">Число генерируемых псевдослучайных байтов ключа.</param>
		/// <returns>Массив байтов, заполненный псевдослучайными байтами ключа.</returns>
		// Token: 0x06002F55 RID: 12117 RVA: 0x000A87F4 File Offset: 0x000A69F4
		[SecuritySafeCritical]
		[Obsolete("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
		public override byte[] GetBytes(int cb)
		{
			if (cb < 1)
			{
				throw new IndexOutOfRangeException("cb");
			}
			int num = 0;
			byte[] array = new byte[cb];
			if (this._baseValue == null)
			{
				this.ComputeBaseValue();
			}
			else if (this._extra != null)
			{
				num = this._extra.Length - this._extraCount;
				if (num >= cb)
				{
					Buffer.InternalBlockCopy(this._extra, this._extraCount, array, 0, cb);
					if (num > cb)
					{
						this._extraCount += cb;
					}
					else
					{
						this._extra = null;
					}
					return array;
				}
				Buffer.InternalBlockCopy(this._extra, num, array, 0, num);
				this._extra = null;
			}
			byte[] array2 = this.ComputeBytes(cb - num);
			Buffer.InternalBlockCopy(array2, 0, array, num, cb - num);
			if (array2.Length + num > cb)
			{
				this._extra = array2;
				this._extraCount = cb - num;
			}
			return array;
		}

		/// <summary>Восстанавливает состояние данной операции.</summary>
		// Token: 0x06002F56 RID: 12118 RVA: 0x000A88BF File Offset: 0x000A6ABF
		public override void Reset()
		{
			this._prefix = 0;
			this._extra = null;
			this._baseValue = null;
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> (при необходимости освобождает и управляемые ресурсы).</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002F57 RID: 12119 RVA: 0x000A88D8 File Offset: 0x000A6AD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				if (this._hash != null)
				{
					this._hash.Dispose();
				}
				if (this._baseValue != null)
				{
					Array.Clear(this._baseValue, 0, this._baseValue.Length);
				}
				if (this._extra != null)
				{
					Array.Clear(this._extra, 0, this._extra.Length);
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
		}

		/// <summary>Возвращает криптографический ключ из объекта <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" />.</summary>
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
		// Token: 0x06002F58 RID: 12120 RVA: 0x000A8975 File Offset: 0x000A6B75
		[SecuritySafeCritical]
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			if (keySize < 0)
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
			}
			throw new NotSupportedException("CspParameters are not supported by Mono");
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000A8998 File Offset: 0x000A6B98
		private byte[] ComputeBaseValue()
		{
			this._hash.Initialize();
			this._hash.TransformBlock(this._password, 0, this._password.Length, this._password, 0);
			if (this._salt != null)
			{
				this._hash.TransformBlock(this._salt, 0, this._salt.Length, this._salt, 0);
			}
			this._hash.TransformFinalBlock(EmptyArray<byte>.Value, 0, 0);
			this._baseValue = this._hash.Hash;
			this._hash.Initialize();
			for (int i = 1; i < this._iterations - 1; i++)
			{
				this._hash.ComputeHash(this._baseValue);
				this._baseValue = this._hash.Hash;
			}
			return this._baseValue;
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000A8A68 File Offset: 0x000A6C68
		[SecurityCritical]
		private byte[] ComputeBytes(int cb)
		{
			int num = 0;
			this._hash.Initialize();
			int num2 = this._hash.HashSize / 8;
			byte[] array = new byte[(cb + num2 - 1) / num2 * num2];
			using (CryptoStream cryptoStream = new CryptoStream(Stream.Null, this._hash, CryptoStreamMode.Write))
			{
				this.HashPrefix(cryptoStream);
				cryptoStream.Write(this._baseValue, 0, this._baseValue.Length);
				cryptoStream.Close();
			}
			Buffer.InternalBlockCopy(this._hash.Hash, 0, array, num, num2);
			num += num2;
			while (cb > num)
			{
				this._hash.Initialize();
				using (CryptoStream cryptoStream2 = new CryptoStream(Stream.Null, this._hash, CryptoStreamMode.Write))
				{
					this.HashPrefix(cryptoStream2);
					cryptoStream2.Write(this._baseValue, 0, this._baseValue.Length);
					cryptoStream2.Close();
				}
				Buffer.InternalBlockCopy(this._hash.Hash, 0, array, num, num2);
				num += num2;
			}
			return array;
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000A8B88 File Offset: 0x000A6D88
		private void HashPrefix(CryptoStream cs)
		{
			int num = 0;
			byte[] array = new byte[]
			{
				48,
				48,
				48
			};
			if (this._prefix > 999)
			{
				throw new CryptographicException(Environment.GetResourceString("Requested number of bytes exceeds the maximum."));
			}
			if (this._prefix >= 100)
			{
				byte[] array2 = array;
				int num2 = 0;
				array2[num2] += (byte)(this._prefix / 100);
				num++;
			}
			if (this._prefix >= 10)
			{
				byte[] array3 = array;
				int num3 = num;
				array3[num3] += (byte)(this._prefix % 100 / 10);
				num++;
			}
			if (this._prefix > 0)
			{
				byte[] array4 = array;
				int num4 = num;
				array4[num4] += (byte)(this._prefix % 10);
				num++;
				cs.Write(array, 0, num);
			}
			this._prefix++;
		}

		// Token: 0x04002188 RID: 8584
		private int _extraCount;

		// Token: 0x04002189 RID: 8585
		private int _prefix;

		// Token: 0x0400218A RID: 8586
		private int _iterations;

		// Token: 0x0400218B RID: 8587
		private byte[] _baseValue;

		// Token: 0x0400218C RID: 8588
		private byte[] _extra;

		// Token: 0x0400218D RID: 8589
		private byte[] _salt;

		// Token: 0x0400218E RID: 8590
		private string _hashName;

		// Token: 0x0400218F RID: 8591
		private byte[] _password;

		// Token: 0x04002190 RID: 8592
		private HashAlgorithm _hash;
	}
}
