using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Предоставляет доступ к неуправляемым блокам памяти из управляемого кода.</summary>
	// Token: 0x02000B29 RID: 2857
	public class UnmanagedMemoryStream : Stream
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryStream" />.</summary>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет необходимого разрешения.</exception>
		// Token: 0x06006695 RID: 26261 RVA: 0x0015E33E File Offset: 0x0015C53E
		protected UnmanagedMemoryStream()
		{
			this._mem = null;
			this._isOpen = false;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryStream" /> в безопасном буфере с указанным смещением и длиной.</summary>
		/// <param name="buffer">Буфер, который должен содержать поток неуправляемой памяти.</param>
		/// <param name="offset">Позиция байта в буфере, с которой должен начинаться поток неуправляемой памяти.</param>
		/// <param name="length">Длина потока неуправляемой памяти.</param>
		// Token: 0x06006696 RID: 26262 RVA: 0x0015E355 File Offset: 0x0015C555
		public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length)
		{
			this.Initialize(buffer, offset, length, FileAccess.Read);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryStream" /> в безопасном буфере с указанными смещением, длиной и правами доступа к файлам.</summary>
		/// <param name="buffer">Буфер, который должен содержать поток неуправляемой памяти.</param>
		/// <param name="offset">Позиция байта в буфере, с которой должен начинаться поток неуправляемой памяти.</param>
		/// <param name="length">Длина потока неуправляемой памяти.</param>
		/// <param name="access">Режим доступа к файлам для потока неуправляемой памяти.</param>
		// Token: 0x06006697 RID: 26263 RVA: 0x0015E367 File Offset: 0x0015C567
		public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length, FileAccess access)
		{
			this.Initialize(buffer, offset, length, access);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryStream" /> в безопасном буфере с указанными смещением, длиной и правами доступа к файлам.</summary>
		/// <param name="buffer">Буфер, который должен содержать поток неуправляемой памяти.</param>
		/// <param name="offset">Позиция байта в буфере, с которой должен начинаться поток неуправляемой памяти.</param>
		/// <param name="length">Длина потока неуправляемой памяти.</param>
		/// <param name="access">Режим доступа к файлам для потока неуправляемой памяти.</param>
		// Token: 0x06006698 RID: 26264 RVA: 0x0015E37C File Offset: 0x0015C57C
		protected unsafe void Initialize(SafeBuffer buffer, long offset, long length, FileAccess access)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0L)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (length < 0L)
			{
				throw new ArgumentOutOfRangeException("length", "Non-negative number required.");
			}
			if (buffer.ByteLength < (ulong)(offset + length))
			{
				throw new ArgumentException("Offset and length were greater than the size of the SafeBuffer.");
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access");
			}
			if (this._isOpen)
			{
				throw new InvalidOperationException("The method cannot be called twice on the same instance.");
			}
			byte* ptr = null;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				buffer.AcquirePointer(ref ptr);
				if (ptr + offset + length < ptr)
				{
					throw new ArgumentException("The UnmanagedMemoryStream capacity would wrap around the high end of the address space.");
				}
			}
			finally
			{
				if (ptr != null)
				{
					buffer.ReleasePointer();
				}
			}
			this._offset = offset;
			this._buffer = buffer;
			this._length = length;
			this._capacity = length;
			this._access = access;
			this._isOpen = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryStream" />, используя заданное расположение и объем памяти.</summary>
		/// <param name="pointer">Указатель на расположение неуправляемой памяти.</param>
		/// <param name="length">Используемый объем памяти.</param>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет необходимого разрешения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение <paramref name="pointer" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length" /> меньше нуля.  
		/// -или- 
		/// Значение параметра <paramref name="length" /> достаточно велико, чтобы привести к переполнению.</exception>
		// Token: 0x06006699 RID: 26265 RVA: 0x0015E470 File Offset: 0x0015C670
		[CLSCompliant(false)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length)
		{
			this.Initialize(pointer, length, length, FileAccess.Read);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryStream" />, используя указанные значения расположения, объема памяти, общего объема памяти и доступа к файлам.</summary>
		/// <param name="pointer">Указатель на расположение неуправляемой памяти.</param>
		/// <param name="length">Используемый объем памяти.</param>
		/// <param name="capacity">Общий объем памяти, назначенный для потока.</param>
		/// <param name="access">Одно из значений <see cref="T:System.IO.FileAccess" />.</param>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет необходимого разрешения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение <paramref name="pointer" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="capacity" /> меньше нуля.  
		///
		/// -или- 
		/// Значение параметра <paramref name="length" /> больше, чем значение <paramref name="capacity" />.</exception>
		// Token: 0x0600669A RID: 26266 RVA: 0x0015E482 File Offset: 0x0015C682
		[CLSCompliant(false)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
		{
			this.Initialize(pointer, length, capacity, access);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryStream" />, используя указатель на неуправляемое расположение в памяти.</summary>
		/// <param name="pointer">Указатель на расположение неуправляемой памяти.</param>
		/// <param name="length">Используемый объем памяти.</param>
		/// <param name="capacity">Общий объем памяти, назначенный для потока.</param>
		/// <param name="access">Одно из значений <see cref="T:System.IO.FileAccess" />.</param>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет необходимого разрешения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение <paramref name="pointer" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="length" /> меньше нуля.  
		/// -или- 
		/// Значение параметра <paramref name="capacity" /> меньше нуля.  
		/// -или- 
		/// Значение параметра <paramref name="length" /> достаточно велико, чтобы привести к переполнению.</exception>
		// Token: 0x0600669B RID: 26267 RVA: 0x0015E498 File Offset: 0x0015C698
		[CLSCompliant(false)]
		protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
		{
			if (pointer == null)
			{
				throw new ArgumentNullException("pointer");
			}
			if (length < 0L || capacity < 0L)
			{
				throw new ArgumentOutOfRangeException((length < 0L) ? "length" : "capacity", "Non-negative number required.");
			}
			if (length > capacity)
			{
				throw new ArgumentOutOfRangeException("length", "The length cannot be greater than the capacity.");
			}
			if (pointer + capacity < pointer)
			{
				throw new ArgumentOutOfRangeException("capacity", "The UnmanagedMemoryStream capacity would wrap around the high end of the address space.");
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access", "Enum value was out of legal range.");
			}
			if (this._isOpen)
			{
				throw new InvalidOperationException("The method cannot be called twice on the same instance.");
			}
			this._mem = pointer;
			this._offset = 0L;
			this._length = length;
			this._capacity = capacity;
			this._access = access;
			this._isOpen = true;
		}

		/// <summary>Возвращает значение, определяющее, поддерживает ли поток операции чтения.</summary>
		/// <returns>Значение <see langword="false" />, если объект был создан конструктором с использованием параметра <paramref name="access" />, не включающего чтение потока, и если поток закрыт; в противном случае — значение <see langword="true" />.</returns>
		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x0600669C RID: 26268 RVA: 0x0015E560 File Offset: 0x0015C760
		public override bool CanRead
		{
			get
			{
				return this._isOpen && (this._access & FileAccess.Read) > (FileAccess)0;
			}
		}

		/// <summary>Возвращает значение, определяющее, поддерживает ли поток операции поиска.</summary>
		/// <returns>Значение равно <see langword="false" />, если поток закрыт, в противном случае значение равно <see langword="true" />.</returns>
		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x0600669D RID: 26269 RVA: 0x0015E577 File Offset: 0x0015C777
		public override bool CanSeek
		{
			get
			{
				return this._isOpen;
			}
		}

		/// <summary>Возвращает значение, определяющее, поддерживает ли поток операции записи.</summary>
		/// <returns>Значение <see langword="false" />, если объект был создан конструктором со значением параметра <paramref name="access" />, которое поддерживает запись, или если объект был создан конструктором без параметров, или если поток закрыт; в противном случае — значение <see langword="true" />.</returns>
		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x0015E57F File Offset: 0x0015C77F
		public override bool CanWrite
		{
			get
			{
				return this._isOpen && (this._access & FileAccess.Write) > (FileAccess)0;
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.UnmanagedMemoryStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600669F RID: 26271 RVA: 0x0015E596 File Offset: 0x0015C796
		protected override void Dispose(bool disposing)
		{
			this._isOpen = false;
			this._mem = null;
			base.Dispose(disposing);
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x0015E5AE File Offset: 0x0015C7AE
		private void EnsureNotClosed()
		{
			if (!this._isOpen)
			{
				throw Error.GetStreamIsClosed();
			}
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x0015E5BE File Offset: 0x0015C7BE
		private void EnsureReadable()
		{
			if (!this.CanRead)
			{
				throw Error.GetReadNotSupported();
			}
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x00156DDC File Offset: 0x00154FDC
		private void EnsureWriteable()
		{
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
		}

		/// <summary>Переопределяет метод <see cref="M:System.IO.Stream.Flush" /> так, что никакие действия не выполняются.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x060066A3 RID: 26275 RVA: 0x0015E5CE File Offset: 0x0015C7CE
		public override void Flush()
		{
			this.EnsureNotClosed();
		}

		/// <summary>Переопределяет метод <see cref="M:System.IO.Stream.FlushAsync(System.Threading.CancellationToken)" /> так, что операция отменяется, если это указано, но никакие другие действия не выполняются.  
		/// Доступно начиная с .NET Framework 4.6</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		// Token: 0x060066A4 RID: 26276 RVA: 0x0015E5D8 File Offset: 0x0015C7D8
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.Flush();
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		/// <summary>Возвращает длину данных в потоке.</summary>
		/// <returns>Длина данных в потоке.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x060066A5 RID: 26277 RVA: 0x0015E620 File Offset: 0x0015C820
		public override long Length
		{
			get
			{
				this.EnsureNotClosed();
				return Interlocked.Read(ref this._length);
			}
		}

		/// <summary>Возвращает длину потока (размер) или общий объем памяти, назначенный потоку (емкость).</summary>
		/// <returns>Размер или емкость потока.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x0015E633 File Offset: 0x0015C833
		public long Capacity
		{
			get
			{
				this.EnsureNotClosed();
				return this._capacity;
			}
		}

		/// <summary>Возвращает или задает текущую позицию в потоке.</summary>
		/// <returns>Текущая позиция в потоке.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для позиции задано значение меньше нуля или значение позиции больше <see cref="F:System.Int32.MaxValue" />, или добавление к текущему указателю привело к переполнению.</exception>
		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x060066A7 RID: 26279 RVA: 0x0015E641 File Offset: 0x0015C841
		// (set) Token: 0x060066A8 RID: 26280 RVA: 0x0015E65C File Offset: 0x0015C85C
		public override long Position
		{
			get
			{
				if (!this.CanSeek)
				{
					throw Error.GetStreamIsClosed();
				}
				return Interlocked.Read(ref this._position);
			}
			set
			{
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value", "Non-negative number required.");
				}
				if (!this.CanSeek)
				{
					throw Error.GetStreamIsClosed();
				}
				Interlocked.Exchange(ref this._position, value);
			}
		}

		/// <summary>Возвращает или задает указатель байтов для потока, используя текущее положение в потоке.</summary>
		/// <returns>Указатель байтов.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение текущей позиции превышает емкость потока.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указываемая позиция не является допустимой в текущем потоке.</exception>
		/// <exception cref="T:System.IO.IOException">Для указателя задается значение меньше, чем значение начальной позиции потока.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток был инициализирован для использования с <see cref="T:System.Runtime.InteropServices.SafeBuffer" />. Свойство <see cref="P:System.IO.UnmanagedMemoryStream.PositionPointer" /> допустимо только для потоков, которые инициализируются с указателем <see cref="T:System.Byte" />.</exception>
		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x060066A9 RID: 26281 RVA: 0x0015E690 File Offset: 0x0015C890
		// (set) Token: 0x060066AA RID: 26282 RVA: 0x0015E6E0 File Offset: 0x0015C8E0
		[CLSCompliant(false)]
		public unsafe byte* PositionPointer
		{
			get
			{
				if (this._buffer != null)
				{
					throw new NotSupportedException("This operation is not supported for an UnmanagedMemoryStream created from a SafeBuffer.");
				}
				this.EnsureNotClosed();
				long num = Interlocked.Read(ref this._position);
				if (num > this._capacity)
				{
					throw new IndexOutOfRangeException("Unmanaged memory stream position was beyond the capacity of the stream.");
				}
				return this._mem + num;
			}
			set
			{
				if (this._buffer != null)
				{
					throw new NotSupportedException("This operation is not supported for an UnmanagedMemoryStream created from a SafeBuffer.");
				}
				this.EnsureNotClosed();
				if (value < this._mem)
				{
					throw new IOException("An attempt was made to move the position before the beginning of the stream.");
				}
				long num = (long)(value - this._mem);
				if (num < 0L)
				{
					throw new ArgumentOutOfRangeException("offset", "UnmanagedMemoryStream length must be non-negative and less than 2^63 - 1 - baseAddress.");
				}
				Interlocked.Exchange(ref this._position, num);
			}
		}

		/// <summary>Считывает указанное число байтов в указанный массив.</summary>
		/// <param name="buffer">Когда этот метод возвращает управление, он содержит указанный массив байтов, в котором значения между <paramref name="offset" /> и (<paramref name="offset" /> + <paramref name="count" /> - 1) заменены байтами, считанными из текущего источника. Этот параметр передается неинициализированным.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в <paramref name="buffer" />, с которого начинается сохранение данных, считанных из текущего потока.</param>
		/// <param name="count">Максимальное количество байтов, которое должно быть считано из текущего потока.</param>
		/// <returns>Общее количество байтов, считанных в буфер. Это число может быть меньше количества запрошенных байтов, если столько байтов в настоящее время недоступно, а также равняться нулю (0), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Основная память не поддерживает чтение.  
		/// -или- 
		/// Свойству <see cref="P:System.IO.UnmanagedMemoryStream.CanRead" /> задано значение <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="buffer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.  
		/// -или- 
		/// Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Длина массива буфера без учета параметра <paramref name="offset" /> меньше значения параметра <paramref name="count" />.</exception>
		// Token: 0x060066AB RID: 26283 RVA: 0x0015E748 File Offset: 0x0015C948
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return this.ReadCore(new Span<byte>(buffer, offset, count));
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x0015E7B1 File Offset: 0x0015C9B1
		public override int Read(Span<byte> buffer)
		{
			if (base.GetType() == typeof(UnmanagedMemoryStream))
			{
				return this.ReadCore(buffer);
			}
			return base.Read(buffer);
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x0015E7DC File Offset: 0x0015C9DC
		internal unsafe int ReadCore(Span<byte> buffer)
		{
			this.EnsureNotClosed();
			this.EnsureReadable();
			long num = Interlocked.Read(ref this._position);
			long num2 = Math.Min(Interlocked.Read(ref this._length) - num, (long)buffer.Length);
			if (num2 <= 0L)
			{
				return 0;
			}
			int num3 = (int)num2;
			if (num3 < 0)
			{
				return 0;
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(buffer))
			{
				byte* dest = reference;
				if (this._buffer != null)
				{
					byte* ptr = null;
					RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
						this._buffer.AcquirePointer(ref ptr);
						Buffer.Memcpy(dest, ptr + num + this._offset, num3, true);
						goto IL_A7;
					}
					finally
					{
						if (ptr != null)
						{
							this._buffer.ReleasePointer();
						}
					}
				}
				Buffer.Memcpy(dest, this._mem + num, num3, true);
				IL_A7:;
			}
			Interlocked.Exchange(ref this._position, num + num2);
			return num3;
		}

		/// <summary>Считывает в асинхронном режиме указанное число байтов в указанный массив.  
		/// Доступно начиная с .NET Framework 4.6</summary>
		/// <param name="buffer">Буфер, в который записываются данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="buffer" />, с которого начинается запись данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число доступных в данный момент байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец потока.</returns>
		// Token: 0x060066AE RID: 26286 RVA: 0x0015E8B4 File Offset: 0x0015CAB4
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			Task<int> task;
			try
			{
				int num = this.Read(buffer, offset, count);
				Task<int> lastReadTask = this._lastReadTask;
				Task<int> task2;
				if (lastReadTask == null || lastReadTask.Result != num)
				{
					task = (this._lastReadTask = Task.FromResult<int>(num));
					task2 = task;
				}
				else
				{
					task2 = lastReadTask;
				}
				task = task2;
			}
			catch (Exception exception)
			{
				task = Task.FromException<int>(exception);
			}
			return task;
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x0015E96C File Offset: 0x0015CB6C
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			ValueTask<int> result;
			try
			{
				ArraySegment<byte> arraySegment;
				result = new ValueTask<int>(MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment) ? this.Read(arraySegment.Array, arraySegment.Offset, arraySegment.Count) : this.Read(buffer.Span));
			}
			catch (Exception exception)
			{
				result = new ValueTask<int>(Task.FromException<int>(exception));
			}
			return result;
		}

		/// <summary>Считывает байт из потока и перемещает позицию в потоке на один байт или возвращает -1, если достигнут конец потока.</summary>
		/// <returns>Байт без знака, приведенный к объекту <see cref="T:System.Int32" />, или значение -1, если достигнут конец потока.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Основная память не поддерживает чтение.  
		///
		/// или - 
		/// Текущая позиция – в конце потока.</exception>
		// Token: 0x060066B0 RID: 26288 RVA: 0x0015E9F0 File Offset: 0x0015CBF0
		public unsafe override int ReadByte()
		{
			this.EnsureNotClosed();
			this.EnsureReadable();
			long num = Interlocked.Read(ref this._position);
			long num2 = Interlocked.Read(ref this._length);
			if (num >= num2)
			{
				return -1;
			}
			Interlocked.Exchange(ref this._position, num + 1L);
			if (this._buffer != null)
			{
				byte* ptr = null;
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
					this._buffer.AcquirePointer(ref ptr);
					return (int)(ptr + num)[this._offset];
				}
				finally
				{
					if (ptr != null)
					{
						this._buffer.ReleasePointer();
					}
				}
			}
			return (int)this._mem[num];
		}

		/// <summary>Устанавливает текущую позицию текущего потока на заданное значение.</summary>
		/// <param name="offset">Указатель относительно origin, от которого начинается поиск.</param>
		/// <param name="loc">Описывает начальную, конечную или текущую позицию как опорную точку для origin, используя значение типа <see cref="T:System.IO.SeekOrigin" />.</param>
		/// <returns>Новая позиция в потоке.</returns>
		/// <exception cref="T:System.IO.IOException">Попытка поиска была выполнена до начала потока.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> больше максимального значения потока.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="loc" /> недопустим.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x060066B1 RID: 26289 RVA: 0x0015EA94 File Offset: 0x0015CC94
		public override long Seek(long offset, SeekOrigin loc)
		{
			this.EnsureNotClosed();
			switch (loc)
			{
			case SeekOrigin.Begin:
				if (offset < 0L)
				{
					throw new IOException("An attempt was made to move the position before the beginning of the stream.");
				}
				Interlocked.Exchange(ref this._position, offset);
				break;
			case SeekOrigin.Current:
			{
				long num = Interlocked.Read(ref this._position);
				if (offset + num < 0L)
				{
					throw new IOException("An attempt was made to move the position before the beginning of the stream.");
				}
				Interlocked.Exchange(ref this._position, offset + num);
				break;
			}
			case SeekOrigin.End:
			{
				long num2 = Interlocked.Read(ref this._length);
				if (num2 + offset < 0L)
				{
					throw new IOException("An attempt was made to move the position before the beginning of the stream.");
				}
				Interlocked.Exchange(ref this._position, num2 + offset);
				break;
			}
			default:
				throw new ArgumentException("Invalid seek origin.");
			}
			return Interlocked.Read(ref this._position);
		}

		/// <summary>Присваивает длине потока указанное значение.</summary>
		/// <param name="value">Длина потока.</param>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Основная память не поддерживает запись.  
		/// -или- 
		/// Предпринята попытка записи в поток, и значение свойства <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> равно <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение <paramref name="value" /> превышает значение емкости потока.  
		/// -или- 
		/// Указанный <paramref name="value" /> имеет отрицательное значение.</exception>
		// Token: 0x060066B2 RID: 26290 RVA: 0x0015EB50 File Offset: 0x0015CD50
		public override void SetLength(long value)
		{
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value", "Non-negative number required.");
			}
			if (this._buffer != null)
			{
				throw new NotSupportedException("This operation is not supported for an UnmanagedMemoryStream created from a SafeBuffer.");
			}
			this.EnsureNotClosed();
			this.EnsureWriteable();
			if (value > this._capacity)
			{
				throw new IOException("Unable to expand length of this stream beyond its capacity.");
			}
			long num = Interlocked.Read(ref this._position);
			long num2 = Interlocked.Read(ref this._length);
			if (value > num2)
			{
				Buffer.ZeroMemory(this._mem + num2, value - num2);
			}
			Interlocked.Exchange(ref this._length, value);
			if (num > value)
			{
				Interlocked.Exchange(ref this._position, value);
			}
		}

		/// <summary>Записывает в текущий поток блок байтов, используя данные из буфера.</summary>
		/// <param name="buffer">Массив байтов, из которого необходимо скопировать байты в текущий поток.</param>
		/// <param name="offset">Смещение в буфере, с которого необходимо начать копирование байтов в текущий поток.</param>
		/// <param name="count">Число байтов для записи в текущий поток.</param>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Основная память не поддерживает запись.  
		/// -или- 
		/// Предпринята попытка записи в поток, и значение свойства <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> равно <see langword="false" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="count" /> больше значения емкости потока.  
		///
		/// -или- 
		/// Позиция – в конце емкости потока.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение одного из указанных параметров меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="offset" /> без учета длины параметра <paramref name="buffer" /> меньше значения параметра <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060066B3 RID: 26291 RVA: 0x0015EBF0 File Offset: 0x0015CDF0
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			this.WriteCore(new Span<byte>(buffer, offset, count));
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x0015EC5E File Offset: 0x0015CE5E
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			if (base.GetType() == typeof(UnmanagedMemoryStream))
			{
				this.WriteCore(buffer);
				return;
			}
			base.Write(buffer);
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x0015EC88 File Offset: 0x0015CE88
		internal unsafe void WriteCore(ReadOnlySpan<byte> buffer)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			long num = Interlocked.Read(ref this._position);
			long num2 = Interlocked.Read(ref this._length);
			long num3 = num + (long)buffer.Length;
			if (num3 < 0L)
			{
				throw new IOException("Stream was too long.");
			}
			if (num3 > this._capacity)
			{
				throw new NotSupportedException("Unable to expand length of this stream beyond its capacity.");
			}
			if (this._buffer == null)
			{
				if (num > num2)
				{
					Buffer.ZeroMemory(this._mem + num2, num - num2);
				}
				if (num3 > num2)
				{
					Interlocked.Exchange(ref this._length, num3);
				}
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(buffer))
			{
				byte* src = reference;
				if (this._buffer != null)
				{
					if (this._capacity - num < (long)buffer.Length)
					{
						throw new ArgumentException("Not enough space available in the buffer.");
					}
					byte* ptr = null;
					RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
						this._buffer.AcquirePointer(ref ptr);
						Buffer.Memcpy(ptr + num + this._offset, src, buffer.Length, true);
						goto IL_10E;
					}
					finally
					{
						if (ptr != null)
						{
							this._buffer.ReleasePointer();
						}
					}
				}
				Buffer.Memcpy(this._mem + num, src, buffer.Length, true);
				IL_10E:;
			}
			Interlocked.Exchange(ref this._position, num3);
		}

		/// <summary>Асинхронно записывает последовательность байтов в текущий поток, перемещает текущую позицию внутри потока на число записанных байтов и отслеживает запросы отмены.  
		/// Доступно начиная с .NET Framework 4.6</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в объекте <paramref name="buffer" />, с которого начинается копирование байтов в поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		// Token: 0x060066B6 RID: 26294 RVA: 0x0015EDC4 File Offset: 0x0015CFC4
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.Write(buffer, offset, count);
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x0015EE5C File Offset: 0x0015D05C
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask(Task.FromCanceled(cancellationToken));
			}
			ValueTask valueTask;
			try
			{
				ArraySegment<byte> arraySegment;
				if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
				{
					this.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
				}
				else
				{
					this.Write(buffer.Span);
				}
				valueTask = default(ValueTask);
				valueTask = valueTask;
			}
			catch (Exception exception)
			{
				valueTask = new ValueTask(Task.FromException(exception));
			}
			return valueTask;
		}

		/// <summary>Запись байта в текущую позицию в потоке файла.</summary>
		/// <param name="value">Значение в байтах, записанное в поток.</param>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Основная память не поддерживает запись.  
		/// -или- 
		/// Предпринята попытка записи в поток, и значение свойства <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> равно <see langword="false" />.  
		///
		/// или - 
		/// Текущая позиция – в конце емкости потока.</exception>
		/// <exception cref="T:System.IO.IOException">Предоставленное значение <paramref name="value" /> приводит к превышению максимальной емкости потока.</exception>
		// Token: 0x060066B8 RID: 26296 RVA: 0x0015EEE0 File Offset: 0x0015D0E0
		public unsafe override void WriteByte(byte value)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			long num = Interlocked.Read(ref this._position);
			long num2 = Interlocked.Read(ref this._length);
			long num3 = num + 1L;
			if (num >= num2)
			{
				if (num3 < 0L)
				{
					throw new IOException("Stream was too long.");
				}
				if (num3 > this._capacity)
				{
					throw new NotSupportedException("Unable to expand length of this stream beyond its capacity.");
				}
				if (this._buffer == null)
				{
					if (num > num2)
					{
						Buffer.ZeroMemory(this._mem + num2, num - num2);
					}
					Interlocked.Exchange(ref this._length, num3);
				}
			}
			if (this._buffer != null)
			{
				byte* ptr = null;
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
					this._buffer.AcquirePointer(ref ptr);
					(ptr + num)[this._offset] = value;
					goto IL_C4;
				}
				finally
				{
					if (ptr != null)
					{
						this._buffer.ReleasePointer();
					}
				}
			}
			this._mem[num] = value;
			IL_C4:
			Interlocked.Exchange(ref this._position, num3);
		}

		// Token: 0x04003C14 RID: 15380
		private SafeBuffer _buffer;

		// Token: 0x04003C15 RID: 15381
		private unsafe byte* _mem;

		// Token: 0x04003C16 RID: 15382
		private long _length;

		// Token: 0x04003C17 RID: 15383
		private long _capacity;

		// Token: 0x04003C18 RID: 15384
		private long _position;

		// Token: 0x04003C19 RID: 15385
		private long _offset;

		// Token: 0x04003C1A RID: 15386
		private FileAccess _access;

		// Token: 0x04003C1B RID: 15387
		internal bool _isOpen;

		// Token: 0x04003C1C RID: 15388
		private Task<int> _lastReadTask;
	}
}
