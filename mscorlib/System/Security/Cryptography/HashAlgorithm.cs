using System;
using System.Buffers;
using System.IO;

namespace System.Security.Cryptography
{
	/// <summary>Представляет базовый класс, из которого создаются все реализации криптографических хэш-алгоритмов.</summary>
	// Token: 0x02000471 RID: 1137
	public abstract class HashAlgorithm : IDisposable, ICryptoTransform
	{
		/// <summary>Создает экземпляр реализации по умолчанию хэш-алгоритма.</summary>
		/// <returns>Новый экземпляр <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />, если параметры по умолчанию не были изменены с помощью .</returns>
		// Token: 0x06002E02 RID: 11778 RVA: 0x000A5A08 File Offset: 0x000A3C08
		public static HashAlgorithm Create()
		{
			return CryptoConfigForwarder.CreateDefaultHashAlgorithm();
		}

		/// <summary>Создает экземпляр заданной реализации хэш-алгоритма.</summary>
		/// <param name="hashName">Используемая реализация хэш-алгоритма. В следующей таблице представлены допустимые значения параметра <paramref name="hashName" /> и алгоритмы, с которыми они сопоставляются.  
		///   Значение параметра 
		///   Инструменты 
		///   SHA 
		///  <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> SHA1 
		///  <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> System.Security.Cryptography.SHA1 
		///  <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> System.Security.Cryptography.HashAlgorithm 
		///  <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> MD5 
		///  <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" /> System.Security.Cryptography.MD5 
		///  <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" /> SHA256 
		///  <see cref="T:System.Security.Cryptography.SHA256Managed" /> SHA-256 
		///  <see cref="T:System.Security.Cryptography.SHA256Managed" /> System.Security.Cryptography.SHA256 
		///  <see cref="T:System.Security.Cryptography.SHA256Managed" /> SHA384 
		///  <see cref="T:System.Security.Cryptography.SHA384Managed" /> SHA-384 
		///  <see cref="T:System.Security.Cryptography.SHA384Managed" /> System.Security.Cryptography.SHA384 
		///  <see cref="T:System.Security.Cryptography.SHA384Managed" /> SHA512 
		///  <see cref="T:System.Security.Cryptography.SHA512Managed" /> SHA-512 
		///  <see cref="T:System.Security.Cryptography.SHA512Managed" /> System.Security.Cryptography.SHA512 
		///  <see cref="T:System.Security.Cryptography.SHA512Managed" /></param>
		/// <returns>Новый экземпляр заданного хэш-алгоритма или значение <see langword="null" />, если <paramref name="hashName" /> не является допустимым хэш-алгоритмом.</returns>
		// Token: 0x06002E03 RID: 11779 RVA: 0x000A5A0F File Offset: 0x000A3C0F
		public static HashAlgorithm Create(string hashName)
		{
			return (HashAlgorithm)CryptoConfigForwarder.CreateFromName(hashName);
		}

		/// <summary>Возвращает размер вычисляемого хэш-кода в битах.</summary>
		/// <returns>Размер вычисляемого хэш-кода в битах.</returns>
		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x000A5A1C File Offset: 0x000A3C1C
		public virtual int HashSize
		{
			get
			{
				return this.HashSizeValue;
			}
		}

		/// <summary>Возвращает значение вычисляемого хэш-кода.</summary>
		/// <returns>Текущее значение вычисляемого хэш-кода.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Свойство <see cref="F:System.Security.Cryptography.HashAlgorithm.HashValue" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект уже удален.</exception>
		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x000A5A24 File Offset: 0x000A3C24
		public virtual byte[] Hash
		{
			get
			{
				if (this._disposed)
				{
					throw new ObjectDisposedException(null);
				}
				if (this.State != 0)
				{
					throw new CryptographicUnexpectedOperationException("Hash must be finalized before the hash value is retrieved.");
				}
				byte[] hashValue = this.HashValue;
				return (byte[])((hashValue != null) ? hashValue.Clone() : null);
			}
		}

		/// <summary>Вычисляет хэш-значение для заданного массива байтов.</summary>
		/// <param name="buffer">Входные данные, для которых вычисляется хэш-код.</param>
		/// <returns>Вычисляемый хэш-код.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект уже удален.</exception>
		// Token: 0x06002E06 RID: 11782 RVA: 0x000A5A5F File Offset: 0x000A3C5F
		public byte[] ComputeHash(byte[] buffer)
		{
			if (this._disposed)
			{
				throw new ObjectDisposedException(null);
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			this.HashCore(buffer, 0, buffer.Length);
			return this.CaptureHashCodeAndReinitialize();
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000A5A90 File Offset: 0x000A3C90
		public bool TryComputeHash(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten)
		{
			if (this._disposed)
			{
				throw new ObjectDisposedException(null);
			}
			if (destination.Length < this.HashSizeValue / 8)
			{
				bytesWritten = 0;
				return false;
			}
			this.HashCore(source);
			if (!this.TryHashFinal(destination, out bytesWritten))
			{
				throw new InvalidOperationException("The algorithm's implementation is incorrect.");
			}
			this.HashValue = null;
			this.Initialize();
			return true;
		}

		/// <summary>Вычисляет хэш-значение для заданной области заданного массива байтов.</summary>
		/// <param name="buffer">Входные данные, для которых вычисляется хэш-код.</param>
		/// <param name="offset">Смещение в массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="count">Число байтов в массиве для использования в качестве данных.</param>
		/// <returns>Вычисляемый хэш-код.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="count" /> не является допустимым значением.  
		///
		/// или - 
		/// Недопустимая длина значения параметра <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> выходит за пределы диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект уже удален.</exception>
		// Token: 0x06002E08 RID: 11784 RVA: 0x000A5AEC File Offset: 0x000A3CEC
		public byte[] ComputeHash(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0 || count > buffer.Length)
			{
				throw new ArgumentException("Argument {0} should be larger than {1}.");
			}
			if (buffer.Length - count < offset)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (this._disposed)
			{
				throw new ObjectDisposedException(null);
			}
			this.HashCore(buffer, offset, count);
			return this.CaptureHashCodeAndReinitialize();
		}

		/// <summary>Вычисляет хэш-значение для заданного объекта <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="inputStream">Входные данные, для которых вычисляется хэш-код.</param>
		/// <returns>Вычисляемый хэш-код.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект уже удален.</exception>
		// Token: 0x06002E09 RID: 11785 RVA: 0x000A5B64 File Offset: 0x000A3D64
		public byte[] ComputeHash(Stream inputStream)
		{
			if (this._disposed)
			{
				throw new ObjectDisposedException(null);
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(4096);
			byte[] result;
			try
			{
				int cbSize;
				while ((cbSize = inputStream.Read(array, 0, array.Length)) > 0)
				{
					this.HashCore(array, 0, cbSize);
				}
				result = this.CaptureHashCodeAndReinitialize();
			}
			finally
			{
				CryptographicOperations.ZeroMemory(array);
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000A5BE0 File Offset: 0x000A3DE0
		private byte[] CaptureHashCodeAndReinitialize()
		{
			this.HashValue = this.HashFinal();
			byte[] result = (byte[])this.HashValue.Clone();
			this.Initialize();
			return result;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.HashAlgorithm" />.</summary>
		// Token: 0x06002E0B RID: 11787 RVA: 0x000A5C04 File Offset: 0x000A3E04
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает все ресурсы, используемые классом <see cref="T:System.Security.Cryptography.HashAlgorithm" />.</summary>
		// Token: 0x06002E0C RID: 11788 RVA: 0x000A5C13 File Offset: 0x000A3E13
		public void Clear()
		{
			((IDisposable)this).Dispose();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.HashAlgorithm" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002E0D RID: 11789 RVA: 0x000A5C1B File Offset: 0x000A3E1B
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._disposed = true;
			}
		}

		/// <summary>Если переопределено в производном классе, возвращает размер входного блока.</summary>
		/// <returns>Размер входного блока.</returns>
		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		/// <summary>Если переопределено в производном классе, возвращает размер выходного блока.</summary>
		/// <returns>Размер выходного блока.</returns>
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		/// <summary>Если переопределено в производном классе, возвращает значение, указывающее, возможно ли преобразование нескольких блоков.</summary>
		/// <returns>Значение <see langword="true" />, если возможно преобразование нескольких блоков; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает значение, указывающее, возможно ли повторное использование текущего преобразования.</summary>
		/// <returns>Всегда <see langword="true" />.</returns>
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		/// <summary>Вычисляет хэш-значение для заданной области входного массива байтов и копирует указанную область входного массива байтов в заданную область выходного массива байтов.</summary>
		/// <param name="inputBuffer">Входные данные, для которых вычисляется хэш-код.</param>
		/// <param name="inputOffset">Смещение во входном массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="inputCount">Число байтов во входном массиве для использования в качестве данных.</param>
		/// <param name="outputBuffer">Копия части входного массива, используемого для вычисления хэш-кода.</param>
		/// <param name="outputOffset">Смещение в выходном массиве байтов, начиная с которого следует записывать данные.</param>
		/// <returns>Число записанных байтов.</returns>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение параметра <paramref name="inputCount" />.  
		///
		/// или - 
		/// Недопустимая длина значения параметра <paramref name="inputBuffer" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inputBuffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="inputOffset" /> выходит за пределы диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект уже удален.</exception>
		// Token: 0x06002E12 RID: 11794 RVA: 0x000A5C27 File Offset: 0x000A3E27
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			this.ValidateTransformBlock(inputBuffer, inputOffset, inputCount);
			this.State = 1;
			this.HashCore(inputBuffer, inputOffset, inputCount);
			if (outputBuffer != null && (inputBuffer != outputBuffer || inputOffset != outputOffset))
			{
				Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
			}
			return inputCount;
		}

		/// <summary>Вычисляет хэш-значение для заданной области заданного массива байтов.</summary>
		/// <param name="inputBuffer">Входные данные, для которых вычисляется хэш-код.</param>
		/// <param name="inputOffset">Смещение в массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="inputCount">Число байтов в массиве для использования в качестве данных.</param>
		/// <returns>Массив, который является копией хэшируемой части входных данных.</returns>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение параметра <paramref name="inputCount" />.  
		///
		/// или - 
		/// Для параметра <paramref name="inputBuffer" /> задано недопустимое смещение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inputBuffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="inputOffset" /> выходит за пределы диапазона. Значение этого параметра не должно быть отрицательным.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект уже удален.</exception>
		// Token: 0x06002E13 RID: 11795 RVA: 0x000A5C60 File Offset: 0x000A3E60
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			this.ValidateTransformBlock(inputBuffer, inputOffset, inputCount);
			this.HashCore(inputBuffer, inputOffset, inputCount);
			this.HashValue = this.CaptureHashCodeAndReinitialize();
			byte[] array;
			if (inputCount != 0)
			{
				array = new byte[inputCount];
				Buffer.BlockCopy(inputBuffer, inputOffset, array, 0, inputCount);
			}
			else
			{
				array = Array.Empty<byte>();
			}
			this.State = 0;
			return array;
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000A5CB0 File Offset: 0x000A3EB0
		private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException("inputBuffer");
			}
			if (inputOffset < 0)
			{
				throw new ArgumentOutOfRangeException("inputOffset", "Non-negative number required.");
			}
			if (inputCount < 0 || inputCount > inputBuffer.Length)
			{
				throw new ArgumentException("Argument {0} should be larger than {1}.");
			}
			if (inputBuffer.Length - inputCount < inputOffset)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (this._disposed)
			{
				throw new ObjectDisposedException(null);
			}
		}

		/// <summary>Если переопределено в производном классе, передает данные, записанные в объект, на вход хэш-алгоритма для вычисления хэша.</summary>
		/// <param name="array">Входные данные, для которых вычисляется хэш-код.</param>
		/// <param name="ibStart">Смещение в массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="cbSize">Число байтов в массиве для использования в качестве данных.</param>
		// Token: 0x06002E15 RID: 11797
		protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

		/// <summary>Если переопределено в производном классе, завершает вычисление хэша после обработки последних данных криптографическим потоковым объектом.</summary>
		/// <returns>Вычисляемый хэш-код.</returns>
		// Token: 0x06002E16 RID: 11798
		protected abstract byte[] HashFinal();

		/// <summary>Инициализирует реализацию класса <see cref="T:System.Security.Cryptography.HashAlgorithm" />.</summary>
		// Token: 0x06002E17 RID: 11799
		public abstract void Initialize();

		// Token: 0x06002E18 RID: 11800 RVA: 0x000A5D18 File Offset: 0x000A3F18
		protected virtual void HashCore(ReadOnlySpan<byte> source)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(source.Length);
			try
			{
				source.CopyTo(array);
				this.HashCore(array, 0, source.Length);
			}
			finally
			{
				Array.Clear(array, 0, source.Length);
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x000A5D80 File Offset: 0x000A3F80
		protected virtual bool TryHashFinal(Span<byte> destination, out int bytesWritten)
		{
			int num = this.HashSizeValue / 8;
			if (destination.Length < num)
			{
				bytesWritten = 0;
				return false;
			}
			byte[] array = this.HashFinal();
			if (array.Length == num)
			{
				new ReadOnlySpan<byte>(array).CopyTo(destination);
				bytesWritten = array.Length;
				return true;
			}
			throw new InvalidOperationException("The algorithm's implementation is incorrect.");
		}

		// Token: 0x04002114 RID: 8468
		private bool _disposed;

		/// <summary>Представляет размер вычисляемого хэш-кода в битах.</summary>
		// Token: 0x04002115 RID: 8469
		protected int HashSizeValue;

		/// <summary>Представляет значение вычисляемого хэш-кода.</summary>
		// Token: 0x04002116 RID: 8470
		protected internal byte[] HashValue;

		/// <summary>Представляет состояние процесса вычисления хэша.</summary>
		// Token: 0x04002117 RID: 8471
		protected int State;
	}
}
