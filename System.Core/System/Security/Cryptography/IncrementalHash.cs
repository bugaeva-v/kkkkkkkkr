using System;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Обеспечивает поддержку для постепенного вычисления значения хэша или HMAC в нескольких сегментах.
	///       </summary>
	// Token: 0x02000037 RID: 55
	public sealed class IncrementalHash : IDisposable
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00002933 File Offset: 0x00000B33
		private IncrementalHash(HashAlgorithmName name, HashAlgorithm hash)
		{
			this._algorithmName = name;
			this._hash = hash;
		}

		/// <summary>
		///         Получает имя выполняемого алгоритма.
		///       </summary>
		/// <returns>
		///         Имя выполняемого алгоритма.
		///       </returns>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002949 File Offset: 0x00000B49
		public HashAlgorithmName AlgorithmName
		{
			get
			{
				return this._algorithmName;
			}
		}

		/// <summary>
		///         Добавляет указанные данные к данным, уже обработанным в хэше или HMAC.
		///       </summary>
		/// <param name="data">
		///           Данные для обработки.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Объект <see cref="T:System.Security.Cryptography.IncrementalHash" /> уже удален.
		///           </exception>
		// Token: 0x060000BC RID: 188 RVA: 0x00002951 File Offset: 0x00000B51
		public void AppendData(byte[] data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			this.AppendData(data, 0, data.Length);
		}

		/// <summary>
		///         Добавляет указанное число байтов из указанных данных, начиная с заданного смещения, к данным, уже обработанным в хэше или HMAC.
		///       </summary>
		/// <param name="data">
		///           Данные для обработки.
		///         </param>
		/// <param name="offset">
		///           Смещение в массиве байтов, начиная с которого следует использовать данные.
		///         </param>
		/// <param name="count">
		///           Число байтов, которое нужно использовать из <paramref name="data" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="data" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="count" /> или <paramref name="offset" /> является отрицательным значением.
		///
		///             -или-
		///
		///             <paramref name="count" /> больше, чем длина <paramref name="data" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина данных.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Объект <see cref="T:System.Security.Cryptography.IncrementalHash" /> уже удален.
		///           </exception>
		// Token: 0x060000BD RID: 189 RVA: 0x0000296C File Offset: 0x00000B6C
		public void AppendData(byte[] data, int offset, int count)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non negative number is required.");
			}
			if (count < 0 || count > data.Length)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (data.Length - count < offset)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (this._disposed)
			{
				throw new ObjectDisposedException(typeof(IncrementalHash).Name);
			}
			if (this._resetPending)
			{
				this._hash.Initialize();
				this._resetPending = false;
			}
			this._hash.TransformBlock(data, offset, count, null, 0);
		}

		/// <summary>
		///         Извлекает хэш или HMAC для данных, собранных из предыдущих вызовов метода <see cref="M:System.Security.Cryptography.IncrementalHash.AppendData(System.Byte[])" />, и сбрасывает объект к исходному состоянию.
		///       </summary>
		/// <returns>
		///         Вычисляемый хэш или HMAC.
		///       </returns>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Объект <see cref="T:System.Security.Cryptography.IncrementalHash" /> уже удален.
		///           </exception>
		// Token: 0x060000BE RID: 190 RVA: 0x00002A0C File Offset: 0x00000C0C
		public byte[] GetHashAndReset()
		{
			if (this._disposed)
			{
				throw new ObjectDisposedException(typeof(IncrementalHash).Name);
			}
			if (this._resetPending)
			{
				this._hash.Initialize();
			}
			this._hash.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
			byte[] hash = this._hash.Hash;
			this._resetPending = true;
			return hash;
		}

		/// <summary>
		///         Освобождает ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.IncrementalHash" />.
		///       </summary>
		// Token: 0x060000BF RID: 191 RVA: 0x00002A6E File Offset: 0x00000C6E
		public void Dispose()
		{
			this._disposed = true;
			if (this._hash != null)
			{
				this._hash.Dispose();
				this._hash = null;
			}
		}

		/// <summary>
		///         Создает <see cref="T:System.Security.Cryptography.IncrementalHash" /> для указанного алгоритма.
		///       </summary>
		/// <param name="hashAlgorithm">
		///           Имя алгоритма хэширования для выполнения.
		///         </param>
		/// <returns>
		///         Экземпляр <see cref="T:System.Security.Cryptography.IncrementalHash" /> готов для вычисления алгоритма хэширования, указанного <paramref name="hashAlgorithm" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="hashAlgorithm" />.Параметр <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или является пустой строкой.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="hashAlgorithm" /> — неизвестный алгоритм хэширования.
		///           </exception>
		// Token: 0x060000C0 RID: 192 RVA: 0x00002A91 File Offset: 0x00000C91
		public static IncrementalHash CreateHash(HashAlgorithmName hashAlgorithm)
		{
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw new ArgumentException("The hash algorithm name cannot be null or empty.", "hashAlgorithm");
			}
			return new IncrementalHash(hashAlgorithm, IncrementalHash.GetHashAlgorithm(hashAlgorithm));
		}

		/// <summary>
		///         Создает <see cref="T:System.Security.Cryptography.IncrementalHash" /> для алгоритма HMAC с помощью указанного алгоритма хэширования и ключа.
		///       </summary>
		/// <param name="hashAlgorithm">
		///           Имя алгоритма хэширования для выполнения в HMAC.
		///         </param>
		/// <param name="key">
		///                Секретный ключ для HMAC.
		///            Ключ может иметь любую длину, но ключ, длина которого превышает выходной размер указанного алгоритма хэширования, будет хэшироваться для получения правильного размера.
		///            Таким образом, рекомендуемым размером секретного ключа является выходной размер указанного алгоритма хэширования.
		///         </param>
		/// <returns>
		///         Экземпляр класса <see cref="T:System.Security.Cryptography.IncrementalHash" /> готов для вычисления указанного алгоритма хэширования.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="key" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="hashAlgorithm" />.Параметр <see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> имеет значение <see langword="null" /> или является пустой строкой.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="hashAlgorithm" /> — неизвестный алгоритм хэширования.
		///           </exception>
		// Token: 0x060000C1 RID: 193 RVA: 0x00002ABD File Offset: 0x00000CBD
		public static IncrementalHash CreateHMAC(HashAlgorithmName hashAlgorithm, byte[] key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw new ArgumentException("The hash algorithm name cannot be null or empty.", "hashAlgorithm");
			}
			return new IncrementalHash(hashAlgorithm, IncrementalHash.GetHMAC(hashAlgorithm, key));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002AF8 File Offset: 0x00000CF8
		private static HashAlgorithm GetHashAlgorithm(HashAlgorithmName hashAlgorithm)
		{
			if (hashAlgorithm == HashAlgorithmName.MD5)
			{
				return new MD5CryptoServiceProvider();
			}
			if (hashAlgorithm == HashAlgorithmName.SHA1)
			{
				return new SHA1CryptoServiceProvider();
			}
			if (hashAlgorithm == HashAlgorithmName.SHA256)
			{
				return new SHA256CryptoServiceProvider();
			}
			if (hashAlgorithm == HashAlgorithmName.SHA384)
			{
				return new SHA384CryptoServiceProvider();
			}
			if (hashAlgorithm == HashAlgorithmName.SHA512)
			{
				return new SHA512CryptoServiceProvider();
			}
			throw new CryptographicException(-2146893816);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002B70 File Offset: 0x00000D70
		private static HashAlgorithm GetHMAC(HashAlgorithmName hashAlgorithm, byte[] key)
		{
			if (hashAlgorithm == HashAlgorithmName.MD5)
			{
				return new HMACMD5(key);
			}
			if (hashAlgorithm == HashAlgorithmName.SHA1)
			{
				return new HMACSHA1(key);
			}
			if (hashAlgorithm == HashAlgorithmName.SHA256)
			{
				return new HMACSHA256(key);
			}
			if (hashAlgorithm == HashAlgorithmName.SHA384)
			{
				return new HMACSHA384(key);
			}
			if (hashAlgorithm == HashAlgorithmName.SHA512)
			{
				return new HMACSHA512(key);
			}
			throw new CryptographicException(-2146893816);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002BEB File Offset: 0x00000DEB
		public void AppendData(ReadOnlySpan<byte> data)
		{
			this.AppendData(data.ToArray());
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002BFC File Offset: 0x00000DFC
		public bool TryGetHashAndReset(Span<byte> destination, out int bytesWritten)
		{
			if (this._disposed)
			{
				throw new ObjectDisposedException(typeof(IncrementalHash).Name);
			}
			byte[] hashAndReset = this.GetHashAndReset();
			if (hashAndReset.AsSpan<byte>().TryCopyTo(destination))
			{
				bytesWritten = hashAndReset.Length;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000235B File Offset: 0x0000055B
		internal IncrementalHash()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040002D5 RID: 725
		private const int NTE_BAD_ALGID = -2146893816;

		// Token: 0x040002D6 RID: 726
		private readonly HashAlgorithmName _algorithmName;

		// Token: 0x040002D7 RID: 727
		private HashAlgorithm _hash;

		// Token: 0x040002D8 RID: 728
		private bool _disposed;

		// Token: 0x040002D9 RID: 729
		private bool _resetPending;
	}
}
