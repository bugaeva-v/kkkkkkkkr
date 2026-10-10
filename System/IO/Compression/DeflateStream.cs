using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression
{
	/// <summary>Предоставляет методы и свойства для сжатия и распаковки потоков с использованием алгоритма Deflate.</summary>
	// Token: 0x02000546 RID: 1350
	public class DeflateStream : Stream
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.DeflateStream" /> с использованием указанного потока и режима сжатия.</summary>
		/// <param name="stream">Поток, который нужно сжать или распаковать.</param>
		/// <param name="mode">Одно из значений перечисления, указывающее, нужно ли выполнить сжатие или распаковку потока.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> не является допустимым значением <see cref="T:System.IO.Compression.CompressionMode" />.  
		/// -или- 
		///  Свойство <see cref="T:System.IO.Compression.CompressionMode" /> имеет значение <see cref="F:System.IO.Compression.CompressionMode.Compress" />; свойство <see cref="P:System.IO.Stream.CanWrite" /> имеет значение <see langword="false" />.  
		/// -или- 
		///  Свойство <see cref="T:System.IO.Compression.CompressionMode" /> имеет значение <see cref="F:System.IO.Compression.CompressionMode.Decompress" />; свойство <see cref="P:System.IO.Stream.CanRead" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06002BDE RID: 11230 RVA: 0x000958B7 File Offset: 0x00093AB7
		public DeflateStream(Stream stream, CompressionMode mode) : this(stream, mode, false, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.DeflateStream" /> с помощью указанного потока и режима сжатия, а также при необходимости оставляет поток открытым.</summary>
		/// <param name="stream">Поток, который нужно сжать или распаковать.</param>
		/// <param name="mode">Одно из значений перечисления, указывающее, нужно ли выполнить сжатие или распаковку потока.</param>
		/// <param name="leaveOpen">Значение <see langword="true" />, чтобы оставить поток открытым после удаления объекта <see cref="T:System.IO.Compression.DeflateStream" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> не является допустимым значением <see cref="T:System.IO.Compression.CompressionMode" />.  
		/// -или- 
		///  Свойство <see cref="T:System.IO.Compression.CompressionMode" /> имеет значение <see cref="F:System.IO.Compression.CompressionMode.Compress" />; свойство <see cref="P:System.IO.Stream.CanWrite" /> имеет значение <see langword="false" />.  
		/// -или- 
		///  Свойство <see cref="T:System.IO.Compression.CompressionMode" /> имеет значение <see cref="F:System.IO.Compression.CompressionMode.Decompress" />; свойство <see cref="P:System.IO.Stream.CanRead" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06002BDF RID: 11231 RVA: 0x000958C3 File Offset: 0x00093AC3
		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen) : this(stream, mode, leaveOpen, false)
		{
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000958CF File Offset: 0x00093ACF
		internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) : this(stream, mode, leaveOpen, true)
		{
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000958DC File Offset: 0x00093ADC
		internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip)
		{
			if (compressedStream == null)
			{
				throw new ArgumentNullException("compressedStream");
			}
			if (mode != CompressionMode.Compress && mode != CompressionMode.Decompress)
			{
				throw new ArgumentException("mode");
			}
			this.base_stream = compressedStream;
			this.native = DeflateStreamNative.Create(compressedStream, mode, gzip);
			if (this.native == null)
			{
				throw new NotImplementedException("Failed to initialize zlib. You probably have an old zlib installed. Version 1.2.0.4 or later is required.");
			}
			this.mode = mode;
			this.leaveOpen = leaveOpen;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.DeflateStream" /> с использованием указанного потока и уровня сжатия.</summary>
		/// <param name="stream">Поток для сжатия.</param>
		/// <param name="compressionLevel">Одно из значений перечисления, указывающее, чему отдается приоритет при сжатии потока: скорости или эффективности сжатия.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает операции записи, например сжатие. (Свойство <see cref="P:System.IO.Stream.CanWrite" /> в объекте потока имеет значение <see langword="false" />).</exception>
		// Token: 0x06002BE2 RID: 11234 RVA: 0x00095946 File Offset: 0x00093B46
		public DeflateStream(Stream stream, CompressionLevel compressionLevel) : this(stream, compressionLevel, false, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.DeflateStream" /> с помощью указанного потока и уровня сжатия, а также при необходимости оставляет поток открытым.</summary>
		/// <param name="stream">Поток для сжатия.</param>
		/// <param name="compressionLevel">Одно из значений перечисления, указывающее, чему отдается приоритет при сжатии потока: скорости или эффективности сжатия.</param>
		/// <param name="leaveOpen">Значение <see langword="true" />, чтобы оставить объект потока открытым после удаления объекта <see cref="T:System.IO.Compression.DeflateStream" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает операции записи, например сжатие. (Свойство <see cref="P:System.IO.Stream.CanWrite" /> в объекте потока имеет значение <see langword="false" />).</exception>
		// Token: 0x06002BE3 RID: 11235 RVA: 0x00095952 File Offset: 0x00093B52
		public DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen) : this(stream, compressionLevel, leaveOpen, false)
		{
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x0009595E File Offset: 0x00093B5E
		internal DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, int windowsBits) : this(stream, compressionLevel, leaveOpen, true)
		{
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x0009596A File Offset: 0x00093B6A
		internal DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, bool gzip) : this(stream, CompressionMode.Compress, leaveOpen, gzip)
		{
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00095978 File Offset: 0x00093B78
		~DeflateStream()
		{
			this.Dispose(false);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.Compression.DeflateStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x06002BE7 RID: 11239 RVA: 0x000959A8 File Offset: 0x00093BA8
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				GC.SuppressFinalize(this);
			}
			DeflateStreamNative deflateStreamNative = this.native;
			if (deflateStreamNative != null)
			{
				deflateStreamNative.Dispose(disposing);
			}
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (!this.leaveOpen)
				{
					Stream stream = this.base_stream;
					if (stream != null)
					{
						stream.Close();
					}
					this.base_stream = null;
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00095A08 File Offset: 0x00093C08
		private unsafe int ReadInternal(byte[] array, int offset, int count)
		{
			if (count == 0)
			{
				return 0;
			}
			byte* ptr;
			if (array == null || array.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array[0];
			}
			IntPtr buffer = new IntPtr((void*)(ptr + offset));
			return this.native.ReadZStream(buffer, count);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x00095A49 File Offset: 0x00093C49
		internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken)
		{
			return base.ReadAsync(destination, cancellationToken);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x00095A54 File Offset: 0x00093C54
		internal int ReadCore(Span<byte> destination)
		{
			byte[] array = new byte[destination.Length];
			int num = this.Read(array, 0, array.Length);
			array.AsSpan(0, num).CopyTo(destination);
			return num;
		}

		/// <summary>Считывает число распакованных байтов в указанный массив байтов.</summary>
		/// <param name="array">Массив для хранения распакованных байтов.</param>
		/// <param name="offset">Смещение в байтах в массиве <paramref name="array" />, в который будут помещены считанные байты.</param>
		/// <param name="count">Максимальное число распакованных байтов для считывания.</param>
		/// <returns>Число байтов, которые были считаны в массив байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">При создании объекта значение <see cref="T:System.IO.Compression.CompressionMode" /> было равно <see langword="Compress" />.  
		/// -или- 
		/// Основной поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  Длина массива <paramref name="array" /> минус начальная точка индекса меньше чем <paramref name="count" />.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">Недопустимый формат данных.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06002BEB RID: 11243 RVA: 0x00095A8C File Offset: 0x00093C8C
		public override int Read(byte[] array, int offset, int count)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (array == null)
			{
				throw new ArgumentNullException("Destination array is null.");
			}
			if (!this.CanRead)
			{
				throw new InvalidOperationException("Stream does not support reading.");
			}
			int num = array.Length;
			if (offset < 0 || count < 0)
			{
				throw new ArgumentException("Dest or count is negative.");
			}
			if (offset > num)
			{
				throw new ArgumentException("destination offset is beyond array size");
			}
			if (offset + count > num)
			{
				throw new ArgumentException("Reading would overrun buffer");
			}
			return this.ReadInternal(array, offset, count);
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00095B14 File Offset: 0x00093D14
		private unsafe void WriteInternal(byte[] array, int offset, int count)
		{
			if (count == 0)
			{
				return;
			}
			fixed (byte[] array2 = array)
			{
				byte* ptr;
				if (array == null || array2.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array2[0];
				}
				IntPtr buffer = new IntPtr((void*)(ptr + offset));
				this.native.WriteZStream(buffer, count);
			}
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00095B56 File Offset: 0x00093D56
		internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			return base.WriteAsync(source, cancellationToken);
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x00095B60 File Offset: 0x00093D60
		internal void WriteCore(ReadOnlySpan<byte> source)
		{
			this.Write(source.ToArray(), 0, source.Length);
		}

		/// <summary>Записывает сжатые байты в основной поток из указанного массива байтов.</summary>
		/// <param name="array">Буфер, содержащий данные для сжатия.</param>
		/// <param name="offset">Смещение байтов в <paramref name="array" />, из которого будут считываться байты.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		// Token: 0x06002BEF RID: 11247 RVA: 0x00095B78 File Offset: 0x00093D78
		public override void Write(byte[] array, int offset, int count)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (!this.CanWrite)
			{
				throw new NotSupportedException("Stream does not support writing");
			}
			if (offset > array.Length - count)
			{
				throw new ArgumentException("Buffer too small. count/offset wrong.");
			}
			this.WriteInternal(array, offset, count);
		}

		/// <summary>Текущая реализация этого метода не функциональна.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06002BF0 RID: 11248 RVA: 0x00095BF9 File Offset: 0x00093DF9
		public override void Flush()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (this.CanWrite)
			{
				this.native.Flush();
			}
		}

		/// <summary>Начинает операцию асинхронного чтения. (Вместо него рекомендуется использовать метод <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="array">Массив байтов, в который следует считывать данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="array" />, с которого начинается чтение данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="asyncCallback">Дополнительный асинхронный ответный вызов по завершении операции чтения.</param>
		/// <param name="asyncState">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронное чтение от других запросов.</param>
		/// <returns>Объект, представляющий асинхронную операцию чтения, которая все еще может быть отложена.</returns>
		/// <exception cref="T:System.IO.IOException">Метод пытался в асинхронном режиме выполнить чтение за пределами потока, или произошла ошибка диска.</exception>
		/// <exception cref="T:System.ArgumentException">Один или несколько аргументов являются недопустимыми.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущая реализация класса <see cref="T:System.IO.Compression.DeflateStream" /> не поддерживает операцию чтения.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот вызов не может быть завершен.</exception>
		// Token: 0x06002BF1 RID: 11249 RVA: 0x00095C28 File Offset: 0x00093E28
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.CanRead)
			{
				throw new NotSupportedException("This stream does not support reading");
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Must be >= 0");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must be >= 0");
			}
			if (count + offset > array.Length)
			{
				throw new ArgumentException("Buffer too small. count/offset wrong.");
			}
			return new DeflateStream.ReadMethod(this.ReadInternal).BeginInvoke(array, offset, count, asyncCallback, asyncState);
		}

		/// <summary>Начинает операцию асинхронной записи. (Вместо него рекомендуется использовать метод <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="array">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="asyncCallback">Дополнительный асинхронный обратный вызов по завершении операции записи.</param>
		/// <param name="asyncState">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронную запись от других запросов.</param>
		/// <returns>Объект, представляющий асинхронную операцию записи, которая может все еще быть отложена.</returns>
		/// <exception cref="T:System.IO.IOException">Метод пытался в асинхронном режиме выполнить запись за пределами потока, или произошла ошибка диска.</exception>
		/// <exception cref="T:System.ArgumentException">Один или несколько аргументов являются недопустимыми.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущая реализация класса <see cref="T:System.IO.Compression.DeflateStream" /> не поддерживает операцию записи.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция записи не может быть выполнена, поскольку поток закрыт.</exception>
		// Token: 0x06002BF2 RID: 11250 RVA: 0x00095CC4 File Offset: 0x00093EC4
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.CanWrite)
			{
				throw new InvalidOperationException("This stream does not support writing");
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Must be >= 0");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must be >= 0");
			}
			if (count + offset > array.Length)
			{
				throw new ArgumentException("Buffer too small. count/offset wrong.");
			}
			return new DeflateStream.WriteMethod(this.WriteInternal).BeginInvoke(array, offset, count, asyncCallback, asyncState);
		}

		/// <summary>Ожидает завершения отложенного асинхронного чтения. (Вместо него рекомендуется использовать метод <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="asyncResult">Ссылка на отложенный асинхронный запрос, который необходимо завершить.</param>
		/// <returns>Количество байтов, считанных из потока, от нуля (0) до количества запрошенных байтов. Объект <see cref="T:System.IO.Compression.DeflateStream" /> возвращает 0 только в конце потока; в противном случае он блокируется, пока доступен хотя бы один байт.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> не происходит из метода <see cref="M:System.IO.Compression.DeflateStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> в текущем потоке.</exception>
		/// <exception cref="T:System.SystemException">Исключение было вызвано во время вызова <see cref="M:System.Threading.WaitHandle.WaitOne" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Конечный вызов является недопустимым, поскольку еще не завершены операции асинхронного чтения для этого потока.
		/// -или-
		/// Поток имеет значение <see langword="null" />.</exception>
		// Token: 0x06002BF3 RID: 11251 RVA: 0x00095D60 File Offset: 0x00093F60
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			DeflateStream.ReadMethod readMethod = asyncResult2.AsyncDelegate as DeflateStream.ReadMethod;
			if (readMethod == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			return readMethod.EndInvoke(asyncResult);
		}

		/// <summary>Заканчивает операцию асинхронной записи. (Вместо него рекомендуется использовать метод <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="asyncResult">Ссылка на невыполненный асинхронный запрос ввода-вывода.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> не происходит из метода <see cref="M:System.IO.Compression.DeflateStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> в текущем потоке.</exception>
		/// <exception cref="T:System.Exception">Исключение было вызвано во время вызова <see cref="M:System.Threading.WaitHandle.WaitOne" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток имеет значение <see langword="null" />.
		/// -или-
		/// Конечный вызов записи является недопустимым.</exception>
		// Token: 0x06002BF4 RID: 11252 RVA: 0x00095DB8 File Offset: 0x00093FB8
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			DeflateStream.WriteMethod writeMethod = asyncResult2.AsyncDelegate as DeflateStream.WriteMethod;
			if (writeMethod == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			writeMethod.EndInvoke(asyncResult);
		}

		/// <summary>Эта операция не поддерживается и всегда вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">Расположение в потоке.</param>
		/// <param name="origin">Одно из значений <see cref="T:System.IO.SeekOrigin" />.</param>
		/// <returns>Значение типа long.</returns>
		/// <exception cref="T:System.NotSupportedException">Для данного потока это свойство не поддерживается.</exception>
		// Token: 0x06002BF5 RID: 11253 RVA: 0x000044FA File Offset: 0x000026FA
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		/// <summary>Эта операция не поддерживается и всегда вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">Длина потока.</param>
		/// <exception cref="T:System.NotSupportedException">Для данного потока это свойство не поддерживается.</exception>
		// Token: 0x06002BF6 RID: 11254 RVA: 0x000044FA File Offset: 0x000026FA
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает ссылку на основной поток.</summary>
		/// <returns>Объект потока, представляющий основной поток.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Основной поток закрыт.</exception>
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x00095E0F File Offset: 0x0009400F
		public Stream BaseStream
		{
			get
			{
				return this.base_stream;
			}
		}

		/// <summary>Возвращает значение, указывающее, поддерживает ли поток чтение во время распаковки файла.</summary>
		/// <returns>Значение <see langword="true" />, если значение <see cref="T:System.IO.Compression.CompressionMode" /> равно <see langword="Decompress" />, а основной поток открыт и поддерживает чтение; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x00095E17 File Offset: 0x00094017
		public override bool CanRead
		{
			get
			{
				return !this.disposed && this.mode == CompressionMode.Decompress && this.base_stream.CanRead;
			}
		}

		/// <summary>Возвращает значение, указывающее, поддерживает ли поток поиск.</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x00003062 File Offset: 0x00001262
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, определяющее, поддерживает ли поток операции записи.</summary>
		/// <returns>Значение <see langword="true" />, если значение <see cref="T:System.IO.Compression.CompressionMode" /> равно <see langword="Compress" />, и основной поток поддерживает запись и не закрыт; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x00095E36 File Offset: 0x00094036
		public override bool CanWrite
		{
			get
			{
				return !this.disposed && this.mode == CompressionMode.Compress && this.base_stream.CanWrite;
			}
		}

		/// <summary>Это свойство не поддерживается и всегда вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Значение типа long.</returns>
		/// <exception cref="T:System.NotSupportedException">Для данного потока это свойство не поддерживается.</exception>
		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x000044FA File Offset: 0x000026FA
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Это свойство не поддерживается и всегда вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Значение типа long.</returns>
		/// <exception cref="T:System.NotSupportedException">Для данного потока это свойство не поддерживается.</exception>
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x000044FA File Offset: 0x000026FA
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x000044FA File Offset: 0x000026FA
		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x040017AC RID: 6060
		private Stream base_stream;

		// Token: 0x040017AD RID: 6061
		private CompressionMode mode;

		// Token: 0x040017AE RID: 6062
		private bool leaveOpen;

		// Token: 0x040017AF RID: 6063
		private bool disposed;

		// Token: 0x040017B0 RID: 6064
		private DeflateStreamNative native;

		// Token: 0x02000547 RID: 1351
		// (Invoke) Token: 0x06002BFF RID: 11263
		private delegate int ReadMethod(byte[] array, int offset, int count);

		// Token: 0x02000548 RID: 1352
		// (Invoke) Token: 0x06002C03 RID: 11267
		private delegate void WriteMethod(byte[] array, int offset, int count);
	}
}
