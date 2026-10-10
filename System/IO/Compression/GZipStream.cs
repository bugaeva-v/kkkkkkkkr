using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression
{
	/// <summary>Предоставляет методы и свойства, используемые для сжатия и распаковки потоков.</summary>
	// Token: 0x02000545 RID: 1349
	public class GZipStream : Stream
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.GZipStream" /> с использованием указанного потока и режима сжатия.</summary>
		/// <param name="stream">Поток, в который записываются сжатые или распакованные данные.</param>
		/// <param name="mode">Одно из значений перечисления, указывающее, нужно ли выполнить сжатие или распаковку потока.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> не является допустимым значением перечисления <see cref="T:System.IO.Compression.CompressionMode" />.  
		/// -или- 
		///  Свойство <see cref="T:System.IO.Compression.CompressionMode" /> имеет значение <see cref="F:System.IO.Compression.CompressionMode.Compress" />; свойство <see cref="P:System.IO.Stream.CanWrite" /> имеет значение <see langword="false" />.  
		/// -или- 
		///  Свойство <see cref="T:System.IO.Compression.CompressionMode" /> имеет значение <see cref="F:System.IO.Compression.CompressionMode.Decompress" />; свойство <see cref="P:System.IO.Stream.CanRead" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06002BBD RID: 11197 RVA: 0x000955EE File Offset: 0x000937EE
		public GZipStream(Stream stream, CompressionMode mode) : this(stream, mode, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.GZipStream" /> с помощью указанного потока и режима сжатия, а также при необходимости оставляет поток открытым.</summary>
		/// <param name="stream">Поток, в который записываются сжатые или распакованные данные.</param>
		/// <param name="mode">Одно из значений перечисления, указывающее, нужно ли выполнить сжатие или распаковку потока.</param>
		/// <param name="leaveOpen">Значение <see langword="true" />, чтобы оставить поток открытым после удаления объекта <see cref="T:System.IO.Compression.GZipStream" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> не является допустимым значением <see cref="T:System.IO.Compression.CompressionMode" />.  
		/// -или- 
		///  Свойство <see cref="T:System.IO.Compression.CompressionMode" /> имеет значение <see cref="F:System.IO.Compression.CompressionMode.Compress" />; свойство <see cref="P:System.IO.Stream.CanWrite" /> имеет значение <see langword="false" />.  
		/// -или- 
		///  Свойство <see cref="T:System.IO.Compression.CompressionMode" /> имеет значение <see cref="F:System.IO.Compression.CompressionMode.Decompress" />; свойство <see cref="P:System.IO.Stream.CanRead" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06002BBE RID: 11198 RVA: 0x000955F9 File Offset: 0x000937F9
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
			this._deflateStream = new DeflateStream(stream, mode, leaveOpen, 31);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.GZipStream" /> с использованием указанного потока и уровня сжатия.</summary>
		/// <param name="stream">Поток, в который необходимо записать сжатые данные.</param>
		/// <param name="compressionLevel">Одно из значений перечисления, указывающее, чему отдается приоритет при сжатии потока: скорости или эффективности сжатия.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает операции записи, например сжатие. (Свойство <see cref="P:System.IO.Stream.CanWrite" /> в объекте потока имеет значение <see langword="false" />).</exception>
		// Token: 0x06002BBF RID: 11199 RVA: 0x00095611 File Offset: 0x00093811
		public GZipStream(Stream stream, CompressionLevel compressionLevel) : this(stream, compressionLevel, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.GZipStream" /> с помощью указанного потока и уровня сжатия, а также при необходимости оставляет поток открытым.</summary>
		/// <param name="stream">Поток, в который необходимо записать сжатые данные.</param>
		/// <param name="compressionLevel">Одно из значений перечисления, указывающее, чему отдается приоритет при сжатии потока: скорости или эффективности сжатия.</param>
		/// <param name="leaveOpen">Значение <see langword="true" />, чтобы оставить объект потока открытым после удаления объекта <see cref="T:System.IO.Compression.GZipStream" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="stream" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает операции записи, например сжатие. (Свойство <see cref="P:System.IO.Stream.CanWrite" /> в объекте потока имеет значение <see langword="false" />).</exception>
		// Token: 0x06002BC0 RID: 11200 RVA: 0x0009561C File Offset: 0x0009381C
		public GZipStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen)
		{
			this._deflateStream = new DeflateStream(stream, compressionLevel, leaveOpen, 31);
		}

		/// <summary>Возвращает значение, указывающее, поддерживает ли поток чтение во время распаковки файла.</summary>
		/// <returns>Значение <see langword="true" />, если значение <see cref="T:System.IO.Compression.CompressionMode" /> равно <see langword="Decompress," />, и основной поток поддерживает чтение и не закрыт; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x00095634 File Offset: 0x00093834
		public override bool CanRead
		{
			get
			{
				DeflateStream deflateStream = this._deflateStream;
				return deflateStream != null && deflateStream.CanRead;
			}
		}

		/// <summary>Возвращает значение, определяющее, поддерживает ли поток операции записи.</summary>
		/// <returns>Значение <see langword="true" />, если значение <see cref="T:System.IO.Compression.CompressionMode" /> равно <see langword="Compress" />, и основной поток поддерживает запись и не закрыт; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x00095647 File Offset: 0x00093847
		public override bool CanWrite
		{
			get
			{
				DeflateStream deflateStream = this._deflateStream;
				return deflateStream != null && deflateStream.CanWrite;
			}
		}

		/// <summary>Возвращает значение, указывающее, поддерживает ли поток поиск.</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x0009565A File Offset: 0x0009385A
		public override bool CanSeek
		{
			get
			{
				DeflateStream deflateStream = this._deflateStream;
				return deflateStream != null && deflateStream.CanSeek;
			}
		}

		/// <summary>Это свойство не поддерживается и всегда вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Значение типа long.</returns>
		/// <exception cref="T:System.NotSupportedException">Для данного потока это свойство не поддерживается.</exception>
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x0009566D File Offset: 0x0009386D
		public override long Length
		{
			get
			{
				throw new NotSupportedException("This operation is not supported.");
			}
		}

		/// <summary>Это свойство не поддерживается и всегда вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Значение типа long.</returns>
		/// <exception cref="T:System.NotSupportedException">Для данного потока это свойство не поддерживается.</exception>
		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x0009566D File Offset: 0x0009386D
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x0009566D File Offset: 0x0009386D
		public override long Position
		{
			get
			{
				throw new NotSupportedException("This operation is not supported.");
			}
			set
			{
				throw new NotSupportedException("This operation is not supported.");
			}
		}

		/// <summary>Текущая реализация этого метода не функциональна.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06002BC7 RID: 11207 RVA: 0x00095679 File Offset: 0x00093879
		public override void Flush()
		{
			this.CheckDeflateStream();
			this._deflateStream.Flush();
		}

		/// <summary>Это свойство не поддерживается и всегда вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">Расположение в потоке.</param>
		/// <param name="origin">Одно из значений <see cref="T:System.IO.SeekOrigin" />.</param>
		/// <returns>Значение типа long.</returns>
		/// <exception cref="T:System.NotSupportedException">Для данного потока это свойство не поддерживается.</exception>
		// Token: 0x06002BC8 RID: 11208 RVA: 0x0009566D File Offset: 0x0009386D
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("This operation is not supported.");
		}

		/// <summary>Это свойство не поддерживается и всегда вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">Длина потока.</param>
		/// <exception cref="T:System.NotSupportedException">Для данного потока это свойство не поддерживается.</exception>
		// Token: 0x06002BC9 RID: 11209 RVA: 0x0009566D File Offset: 0x0009386D
		public override void SetLength(long value)
		{
			throw new NotSupportedException("This operation is not supported.");
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x0009568C File Offset: 0x0009388C
		public override int ReadByte()
		{
			this.CheckDeflateStream();
			return this._deflateStream.ReadByte();
		}

		/// <summary>Начинает операцию асинхронного чтения. (Вместо него рекомендуется использовать метод <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="array">Массив байтов, в который следует считывать данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="array" />, с которого начинается чтение данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="asyncCallback">Дополнительный асинхронный ответный вызов по завершении операции чтения.</param>
		/// <param name="asyncState">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронное чтение от других запросов.</param>
		/// <returns>Объект, представляющий асинхронную операцию чтения, которая может все еще быть отложена.</returns>
		/// <exception cref="T:System.IO.IOException">Метод пытался в асинхронном режиме выполнить чтение за пределами потока, или произошла ошибка диска.</exception>
		/// <exception cref="T:System.ArgumentException">Один или несколько аргументов являются недопустимыми.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущая реализация класса <see cref="T:System.IO.Compression.GZipStream" /> не поддерживает операцию чтения.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция чтения не может быть выполнена, поскольку поток закрыт.</exception>
		// Token: 0x06002BCB RID: 11211 RVA: 0x0009569F File Offset: 0x0009389F
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return TaskToApm.Begin(this.ReadAsync(array, offset, count, CancellationToken.None), asyncCallback, asyncState);
		}

		/// <summary>Ожидает завершения отложенного асинхронного чтения. (Вместо него рекомендуется использовать метод <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="asyncResult">Ссылка на отложенный асинхронный запрос, который необходимо завершить.</param>
		/// <returns>Количество байтов, считанных из потока, от нуля (0) до количества запрошенных байтов. Объект <see cref="T:System.IO.Compression.GZipStream" /> возвращает 0 только в конце потока; в противном случае он блокируется, пока доступен хотя бы один байт.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> не происходит из метода <see cref="M:System.IO.Compression.GZipStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> в текущем потоке.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция окончания не может быть выполнена, поскольку поток закрыт.</exception>
		// Token: 0x06002BCC RID: 11212 RVA: 0x0008F0E9 File Offset: 0x0008D2E9
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToApm.End<int>(asyncResult);
		}

		/// <summary>Считывает число распакованных байтов в указанный массив байтов.</summary>
		/// <param name="array">Массив, используемый для хранения распакованных байтов.</param>
		/// <param name="offset">Смещение в байтах в массиве <paramref name="array" />, в который будут помещены считанные байты.</param>
		/// <param name="count">Максимальное число распакованных байтов для считывания.</param>
		/// <returns>Число байтов, которые были распакованы в массив байтов. Если достигнут конец потока, возвращаемое значение представляет собой число считанных байтов или же равно нулю.</returns>
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
		// Token: 0x06002BCD RID: 11213 RVA: 0x000956B8 File Offset: 0x000938B8
		public override int Read(byte[] array, int offset, int count)
		{
			this.CheckDeflateStream();
			return this._deflateStream.Read(array, offset, count);
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000956CE File Offset: 0x000938CE
		public override int Read(Span<byte> buffer)
		{
			if (base.GetType() != typeof(GZipStream))
			{
				return base.Read(buffer);
			}
			this.CheckDeflateStream();
			return this._deflateStream.ReadCore(buffer);
		}

		/// <summary>Начинает операцию асинхронной записи. (Вместо него рекомендуется использовать метод <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="array">Буфер, содержащий данные для записи в текущий поток.</param>
		/// <param name="offset">Смещение байтов в <paramref name="array" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="asyncCallback">Дополнительный асинхронный ответный вызов по завершении операции записи.</param>
		/// <param name="asyncState">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронную запись от других запросов.</param>
		/// <returns>Объект, представляющий асинхронную операцию записи, которая может все еще быть отложена.</returns>
		/// <exception cref="T:System.InvalidOperationException">Основной поток является <see langword="null" />.  
		/// -или- 
		/// Основной поток закрыт.</exception>
		// Token: 0x06002BCF RID: 11215 RVA: 0x00095701 File Offset: 0x00093901
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return TaskToApm.Begin(this.WriteAsync(array, offset, count, CancellationToken.None), asyncCallback, asyncState);
		}

		/// <summary>Обрабатывает завершение операции асинхронной записи. (Вместо него рекомендуется использовать метод <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" />.)</summary>
		/// <param name="asyncResult">Объект, который представляет асинхронный вызов.</param>
		/// <exception cref="T:System.InvalidOperationException">Основной поток является <see langword="null" />.  
		/// -или- 
		/// Основной поток закрыт.</exception>
		// Token: 0x06002BD0 RID: 11216 RVA: 0x0009571A File Offset: 0x0009391A
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		/// <summary>Записывает сжатые байты в основной поток из указанного массива байтов.</summary>
		/// <param name="array">Буфер, содержащий данные для сжатия.</param>
		/// <param name="offset">Смещение байтов в <paramref name="array" />, из которого будут считываться байты.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Операция записи не может быть выполнена, поскольку поток закрыт.</exception>
		// Token: 0x06002BD1 RID: 11217 RVA: 0x00095722 File Offset: 0x00093922
		public override void Write(byte[] array, int offset, int count)
		{
			this.CheckDeflateStream();
			this._deflateStream.Write(array, offset, count);
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00095738 File Offset: 0x00093938
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			if (base.GetType() != typeof(GZipStream))
			{
				base.Write(buffer);
				return;
			}
			this.CheckDeflateStream();
			this._deflateStream.WriteCore(buffer);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x0009576B File Offset: 0x0009396B
		public override void CopyTo(Stream destination, int bufferSize)
		{
			this.CheckDeflateStream();
			this._deflateStream.CopyTo(destination, bufferSize);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.Compression.GZipStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x06002BD4 RID: 11220 RVA: 0x00095780 File Offset: 0x00093980
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this._deflateStream != null)
				{
					this._deflateStream.Dispose();
				}
				this._deflateStream = null;
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>Возвращает ссылку на основной поток.</summary>
		/// <returns>Объект потока, представляющий основной поток.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Основной поток закрыт.</exception>
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x000957C4 File Offset: 0x000939C4
		public Stream BaseStream
		{
			get
			{
				DeflateStream deflateStream = this._deflateStream;
				if (deflateStream == null)
				{
					return null;
				}
				return deflateStream.BaseStream;
			}
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000957D7 File Offset: 0x000939D7
		public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckDeflateStream();
			return this._deflateStream.ReadAsync(array, offset, count, cancellationToken);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x000957EF File Offset: 0x000939EF
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(GZipStream))
			{
				return base.ReadAsync(buffer, cancellationToken);
			}
			this.CheckDeflateStream();
			return this._deflateStream.ReadAsyncMemory(buffer, cancellationToken);
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x00095824 File Offset: 0x00093A24
		public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckDeflateStream();
			return this._deflateStream.WriteAsync(array, offset, count, cancellationToken);
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x0009583C File Offset: 0x00093A3C
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(GZipStream))
			{
				return base.WriteAsync(buffer, cancellationToken);
			}
			this.CheckDeflateStream();
			return this._deflateStream.WriteAsyncMemory(buffer, cancellationToken);
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x00095871 File Offset: 0x00093A71
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			this.CheckDeflateStream();
			return this._deflateStream.FlushAsync(cancellationToken);
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00095885 File Offset: 0x00093A85
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			this.CheckDeflateStream();
			return this._deflateStream.CopyToAsync(destination, bufferSize, cancellationToken);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x0009589B File Offset: 0x00093A9B
		private void CheckDeflateStream()
		{
			if (this._deflateStream == null)
			{
				GZipStream.ThrowStreamClosedException();
			}
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000958AA File Offset: 0x00093AAA
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowStreamClosedException()
		{
			throw new ObjectDisposedException(null, "Cannot access a closed Stream.");
		}

		// Token: 0x040017AB RID: 6059
		private DeflateStream _deflateStream;
	}
}
