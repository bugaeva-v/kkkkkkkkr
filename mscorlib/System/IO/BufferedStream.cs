using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Добавляет уровень буферизации в операциях чтения и записи в другие потоки. Этот класс не наследуется.</summary>
	// Token: 0x02000B41 RID: 2881
	public sealed class BufferedStream : Stream
	{
		// Token: 0x0600680A RID: 26634 RVA: 0x001629BB File Offset: 0x00160BBB
		internal SemaphoreSlim LazyEnsureAsyncActiveSemaphoreInitialized()
		{
			return LazyInitializer.EnsureInitialized<SemaphoreSlim>(ref this._asyncActiveSemaphore, () => new SemaphoreSlim(1, 1));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BufferedStream" /> со стандартным размером буфера 4096 байт.</summary>
		/// <param name="stream">Текущий поток.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600680B RID: 26635 RVA: 0x001629E7 File Offset: 0x00160BE7
		public BufferedStream(Stream stream) : this(stream, 4096)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BufferedStream" /> с заданным размером буфера.</summary>
		/// <param name="stream">Текущий поток.</param>
		/// <param name="bufferSize">Размер буфера в байтах.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="bufferSize" /> является отрицательным значением.</exception>
		// Token: 0x0600680C RID: 26636 RVA: 0x001629F8 File Offset: 0x00160BF8
		public BufferedStream(Stream stream, int bufferSize)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", SR.Format("'{0}' must be greater than zero.", "bufferSize"));
			}
			this._stream = stream;
			this._bufferSize = bufferSize;
			if (!this._stream.CanRead && !this._stream.CanWrite)
			{
				throw new ObjectDisposedException(null, "Cannot access a closed Stream.");
			}
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x00162A6B File Offset: 0x00160C6B
		private void EnsureNotClosed()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot access a closed Stream.");
			}
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x00162A81 File Offset: 0x00160C81
		private void EnsureCanSeek()
		{
			if (!this._stream.CanSeek)
			{
				throw new NotSupportedException("Stream does not support seeking.");
			}
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x00162A9B File Offset: 0x00160C9B
		private void EnsureCanRead()
		{
			if (!this._stream.CanRead)
			{
				throw new NotSupportedException("Stream does not support reading.");
			}
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x00162AB5 File Offset: 0x00160CB5
		private void EnsureCanWrite()
		{
			if (!this._stream.CanWrite)
			{
				throw new NotSupportedException("Stream does not support writing.");
			}
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x00162AD0 File Offset: 0x00160CD0
		private void EnsureShadowBufferAllocated()
		{
			if (this._buffer.Length != this._bufferSize || this._bufferSize >= 81920)
			{
				return;
			}
			byte[] array = new byte[Math.Min(this._bufferSize + this._bufferSize, 81920)];
			Buffer.BlockCopy(this._buffer, 0, array, 0, this._writePos);
			this._buffer = array;
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x00162B33 File Offset: 0x00160D33
		private void EnsureBufferAllocated()
		{
			if (this._buffer == null)
			{
				this._buffer = new byte[this._bufferSize];
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06006813 RID: 26643 RVA: 0x00162B4E File Offset: 0x00160D4E
		public Stream UnderlyingStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x00162B56 File Offset: 0x00160D56
		public int BufferSize
		{
			get
			{
				return this._bufferSize;
			}
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций чтения.</summary>
		/// <returns>Значение <see langword="true" />, если в потоке поддерживаются операции чтения; значение <see langword="false" />, если поток закрыт или открыт только для записи.</returns>
		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x00162B5E File Offset: 0x00160D5E
		public override bool CanRead
		{
			get
			{
				return this._stream != null && this._stream.CanRead;
			}
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций записи.</summary>
		/// <returns>Значение <see langword="true" />, если поток поддерживает операции записи; значение <see langword="false" />, если поток закрыт или открыт только для чтения.</returns>
		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06006816 RID: 26646 RVA: 0x00162B75 File Offset: 0x00160D75
		public override bool CanWrite
		{
			get
			{
				return this._stream != null && this._stream.CanWrite;
			}
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций поиска.</summary>
		/// <returns>Значение <see langword="true" /> если поток поддерживает поиск; значение <see langword="false" />, если поток закрыт или создан на базе дескриптора операционной системы, соответствующего каналу или выводу на консоль.</returns>
		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06006817 RID: 26647 RVA: 0x00162B8C File Offset: 0x00160D8C
		public override bool CanSeek
		{
			get
			{
				return this._stream != null && this._stream.CanSeek;
			}
		}

		/// <summary>Возвращает длину потока в байтах.</summary>
		/// <returns>Длина потока в байтах.</returns>
		/// <exception cref="T:System.IO.IOException">Базовый поток закрыт или его значение равно <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает поиск.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06006818 RID: 26648 RVA: 0x00162BA3 File Offset: 0x00160DA3
		public override long Length
		{
			get
			{
				this.EnsureNotClosed();
				if (this._writePos > 0)
				{
					this.FlushWrite();
				}
				return this._stream.Length;
			}
		}

		/// <summary>Возвращает позицию в текущем потоке.</summary>
		/// <returns>Позиция в текущем потоке.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, переданное в <see cref="M:System.IO.BufferedStream.Seek(System.Int64,System.IO.SeekOrigin)" />, представляет собой отрицательное число.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода, например указывающая, что поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает поиск.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06006819 RID: 26649 RVA: 0x00162BC5 File Offset: 0x00160DC5
		// (set) Token: 0x0600681A RID: 26650 RVA: 0x00162BF4 File Offset: 0x00160DF4
		public override long Position
		{
			get
			{
				this.EnsureNotClosed();
				this.EnsureCanSeek();
				return this._stream.Position + (long)(this._readPos - this._readLen + this._writePos);
			}
			set
			{
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value", "Non-negative number required.");
				}
				this.EnsureNotClosed();
				this.EnsureCanSeek();
				if (this._writePos > 0)
				{
					this.FlushWrite();
				}
				this._readPos = 0;
				this._readLen = 0;
				this._stream.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x00162C50 File Offset: 0x00160E50
		public override ValueTask DisposeAsync()
		{
			BufferedStream.<DisposeAsync>d__34 <DisposeAsync>d__;
			<DisposeAsync>d__.<>4__this = this;
			<DisposeAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<DisposeAsync>d__.<>1__state = -1;
			<DisposeAsync>d__.<>t__builder.Start<BufferedStream.<DisposeAsync>d__34>(ref <DisposeAsync>d__);
			return <DisposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x00162C94 File Offset: 0x00160E94
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this._stream != null)
				{
					try
					{
						this.Flush();
					}
					finally
					{
						this._stream.Dispose();
					}
				}
			}
			finally
			{
				this._stream = null;
				this._buffer = null;
				base.Dispose(disposing);
			}
		}

		/// <summary>Очищает все буферы для этого потока и приводит к записи всех буферизованных данных в базовое устройство.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.IO.IOException">Источник данных или репозиторий закрыты.</exception>
		// Token: 0x0600681D RID: 26653 RVA: 0x00162CF4 File Offset: 0x00160EF4
		public override void Flush()
		{
			this.EnsureNotClosed();
			if (this._writePos > 0)
			{
				this.FlushWrite();
				return;
			}
			if (this._readPos < this._readLen)
			{
				if (this._stream.CanSeek)
				{
					this.FlushRead();
				}
				if (this._stream.CanWrite)
				{
					this._stream.Flush();
				}
				return;
			}
			if (this._stream.CanWrite)
			{
				this._stream.Flush();
			}
			this._writePos = (this._readPos = (this._readLen = 0));
		}

		/// <summary>Асинхронно очищает все буферы данного потока, вызывает запись буферизованных данных в базовое устройство и отслеживает запросы отмены.</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		// Token: 0x0600681E RID: 26654 RVA: 0x00162D82 File Offset: 0x00160F82
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			this.EnsureNotClosed();
			return this.FlushAsyncInternal(cancellationToken);
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x00162DA4 File Offset: 0x00160FA4
		private Task FlushAsyncInternal(CancellationToken cancellationToken)
		{
			BufferedStream.<FlushAsyncInternal>d__38 <FlushAsyncInternal>d__;
			<FlushAsyncInternal>d__.<>4__this = this;
			<FlushAsyncInternal>d__.cancellationToken = cancellationToken;
			<FlushAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FlushAsyncInternal>d__.<>1__state = -1;
			<FlushAsyncInternal>d__.<>t__builder.Start<BufferedStream.<FlushAsyncInternal>d__38>(ref <FlushAsyncInternal>d__);
			return <FlushAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x00162DEF File Offset: 0x00160FEF
		private void FlushRead()
		{
			if (this._readPos - this._readLen != 0)
			{
				this._stream.Seek((long)(this._readPos - this._readLen), SeekOrigin.Current);
			}
			this._readPos = 0;
			this._readLen = 0;
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x00162E2C File Offset: 0x0016102C
		private void ClearReadBufferBeforeWrite()
		{
			if (this._readPos == this._readLen)
			{
				this._readPos = (this._readLen = 0);
				return;
			}
			if (!this._stream.CanSeek)
			{
				throw new NotSupportedException("Cannot write to a BufferedStream while the read buffer is not empty if the underlying stream is not seekable. Ensure that the stream underlying this BufferedStream can seek or avoid interleaving read and write operations on this BufferedStream.");
			}
			this.FlushRead();
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x00162E76 File Offset: 0x00161076
		private void FlushWrite()
		{
			this._stream.Write(this._buffer, 0, this._writePos);
			this._writePos = 0;
			this._stream.Flush();
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x00162EA4 File Offset: 0x001610A4
		private Task FlushWriteAsync(CancellationToken cancellationToken)
		{
			BufferedStream.<FlushWriteAsync>d__42 <FlushWriteAsync>d__;
			<FlushWriteAsync>d__.<>4__this = this;
			<FlushWriteAsync>d__.cancellationToken = cancellationToken;
			<FlushWriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FlushWriteAsync>d__.<>1__state = -1;
			<FlushWriteAsync>d__.<>t__builder.Start<BufferedStream.<FlushWriteAsync>d__42>(ref <FlushWriteAsync>d__);
			return <FlushWriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x00162EF0 File Offset: 0x001610F0
		private int ReadFromBuffer(byte[] array, int offset, int count)
		{
			int num = this._readLen - this._readPos;
			if (num == 0)
			{
				return 0;
			}
			if (num > count)
			{
				num = count;
			}
			Buffer.BlockCopy(this._buffer, this._readPos, array, offset, num);
			this._readPos += num;
			return num;
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x00162F3C File Offset: 0x0016113C
		private int ReadFromBuffer(Span<byte> destination)
		{
			int num = Math.Min(this._readLen - this._readPos, destination.Length);
			if (num > 0)
			{
				new ReadOnlySpan<byte>(this._buffer, this._readPos, num).CopyTo(destination);
				this._readPos += num;
			}
			return num;
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x00162F94 File Offset: 0x00161194
		private int ReadFromBuffer(byte[] array, int offset, int count, out Exception error)
		{
			int result;
			try
			{
				error = null;
				result = this.ReadFromBuffer(array, offset, count);
			}
			catch (Exception ex)
			{
				error = ex;
				result = 0;
			}
			return result;
		}

		/// <summary>Копирует байты из текущего буферизованного потока в массив.</summary>
		/// <param name="array">Буфер, в который необходимо скопировать байты.</param>
		/// <param name="offset">Смещение в буфере (в байтах), с которого начинается чтение байтов.</param>
		/// <param name="count">Количество байтов, чтение которых необходимо выполнить.</param>
		/// <returns>Общее число байтов, считанных в <paramref name="array" />. Это число может быть меньше, чем количество запрошенных байтов, если столько байтов в настоящее время недоступно, или равняться нулю, если конец файла был достигнут раньше, чем были считаны данные.</returns>
		/// <exception cref="T:System.ArgumentException">Длина <paramref name="array" /> минус <paramref name="offset" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Поток не открыт или его значение равно <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x06006827 RID: 26663 RVA: 0x00162FCC File Offset: 0x001611CC
		public override int Read(byte[] array, int offset, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (array.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = this.ReadFromBuffer(array, offset, count);
			if (num == count)
			{
				return num;
			}
			int num2 = num;
			if (num > 0)
			{
				count -= num;
				offset += num;
			}
			this._readPos = (this._readLen = 0);
			if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			if (count >= this._bufferSize)
			{
				return this._stream.Read(array, offset, count) + num2;
			}
			this.EnsureBufferAllocated();
			this._readLen = this._stream.Read(this._buffer, 0, this._bufferSize);
			num = this.ReadFromBuffer(array, offset, count);
			return num + num2;
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x001630C0 File Offset: 0x001612C0
		public override int Read(Span<byte> destination)
		{
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = this.ReadFromBuffer(destination);
			if (num == destination.Length)
			{
				return num;
			}
			if (num > 0)
			{
				destination = destination.Slice(num);
			}
			this._readPos = (this._readLen = 0);
			if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			if (destination.Length >= this._bufferSize)
			{
				return this._stream.Read(destination) + num;
			}
			this.EnsureBufferAllocated();
			this._readLen = this._stream.Read(this._buffer, 0, this._bufferSize);
			return this.ReadFromBuffer(destination) + num;
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x00163168 File Offset: 0x00161368
		private Task<int> LastSyncCompletedReadTask(int val)
		{
			Task<int> task = this._lastSyncCompletedReadTask;
			if (task != null && task.Result == val)
			{
				return task;
			}
			task = Task.FromResult<int>(val);
			this._lastSyncCompletedReadTask = task;
			return task;
		}

		/// <summary>Асинхронно считывает последовательность байтов из текущего потока, перемещает позицию в потоке на число считанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, в который записываются данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="buffer" />, с которого начинается запись данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число доступных в данный момент байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x0600682A RID: 26666 RVA: 0x0016319C File Offset: 0x0016139C
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
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = 0;
			SemaphoreSlim semaphoreSlim = this.LazyEnsureAsyncActiveSemaphoreInitialized();
			Task task = semaphoreSlim.WaitAsync();
			if (task.IsCompletedSuccessfully)
			{
				bool flag = true;
				try
				{
					Exception ex;
					num = this.ReadFromBuffer(buffer, offset, count, out ex);
					flag = (num == count || ex != null);
					if (flag)
					{
						return (ex == null) ? this.LastSyncCompletedReadTask(num) : Task.FromException<int>(ex);
					}
				}
				finally
				{
					if (flag)
					{
						semaphoreSlim.Release();
					}
				}
			}
			return this.ReadFromUnderlyingStreamAsync(new Memory<byte>(buffer, offset + num, count - num), cancellationToken, num, task).AsTask();
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x001632A4 File Offset: 0x001614A4
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = 0;
			SemaphoreSlim semaphoreSlim = this.LazyEnsureAsyncActiveSemaphoreInitialized();
			Task task = semaphoreSlim.WaitAsync();
			if (task.IsCompletedSuccessfully)
			{
				bool flag = true;
				try
				{
					num = this.ReadFromBuffer(buffer.Span);
					flag = (num == buffer.Length);
					if (flag)
					{
						return new ValueTask<int>(num);
					}
				}
				finally
				{
					if (flag)
					{
						semaphoreSlim.Release();
					}
				}
			}
			return this.ReadFromUnderlyingStreamAsync(buffer.Slice(num), cancellationToken, num, task);
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00163344 File Offset: 0x00161544
		private ValueTask<int> ReadFromUnderlyingStreamAsync(Memory<byte> buffer, CancellationToken cancellationToken, int bytesAlreadySatisfied, Task semaphoreLockTask)
		{
			BufferedStream.<ReadFromUnderlyingStreamAsync>d__51 <ReadFromUnderlyingStreamAsync>d__;
			<ReadFromUnderlyingStreamAsync>d__.<>4__this = this;
			<ReadFromUnderlyingStreamAsync>d__.buffer = buffer;
			<ReadFromUnderlyingStreamAsync>d__.cancellationToken = cancellationToken;
			<ReadFromUnderlyingStreamAsync>d__.bytesAlreadySatisfied = bytesAlreadySatisfied;
			<ReadFromUnderlyingStreamAsync>d__.semaphoreLockTask = semaphoreLockTask;
			<ReadFromUnderlyingStreamAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadFromUnderlyingStreamAsync>d__.<>1__state = -1;
			<ReadFromUnderlyingStreamAsync>d__.<>t__builder.Start<BufferedStream.<ReadFromUnderlyingStreamAsync>d__51>(ref <ReadFromUnderlyingStreamAsync>d__);
			return <ReadFromUnderlyingStreamAsync>d__.<>t__builder.Task;
		}

		/// <summary>Начинает операцию асинхронного чтения. (Рекомендуется использовать <see cref="M:System.IO.BufferedStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" />.)</summary>
		/// <param name="buffer">Буфер, в который необходимо считать данные.</param>
		/// <param name="offset">Смещение байтов в буфере <paramref name="buffer" />, с которого начинается запись данных, считанных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="callback">Дополнительный асинхронный обратный вызов по завершении чтения.</param>
		/// <param name="state">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронное чтение от других запросов.</param>
		/// <returns>Объект, представляющий асинхронную операцию чтения, которая может все еще быть отложена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Предпринята попытка асинхронного чтения за пределами потока.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="offset" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий поток не поддерживает операцию чтения.</exception>
		// Token: 0x0600682D RID: 26669 RVA: 0x000A4382 File Offset: 0x000A2582
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.ReadAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		/// <summary>Ожидает завершения отложенной асинхронной операции чтения. (Рекомендуется использовать <see cref="M:System.IO.BufferedStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" />.)</summary>
		/// <param name="asyncResult">Ссылка на ожидаемый отложенный асинхронный запрос.</param>
		/// <returns>Количество байтов, считанных из потока, от нуля (0) до количества запрошенных байтов. Потоки возвращают только 0 только в конце потока, в противном случае они должны блокироваться, пока не будет доступен по крайней мере 1 байт.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Этот объект <see cref="T:System.IAsyncResult" /> не был создан путем вызова <see cref="M:System.IO.BufferedStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> для данного класса.</exception>
		// Token: 0x0600682E RID: 26670 RVA: 0x000A439B File Offset: 0x000A259B
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToApm.End<int>(asyncResult);
		}

		/// <summary>Считывает байт из базового потока и возвращает байт, приведенный к <see langword="int" />, или значение -1 при попытке чтения из конца потока.</summary>
		/// <returns>Байт, приведенный к <see langword="int" />, или значение -1 при попытке чтения из конца потока.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода, например указывающая, что поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x0600682F RID: 26671 RVA: 0x001633A8 File Offset: 0x001615A8
		public override int ReadByte()
		{
			if (this._readPos == this._readLen)
			{
				return this.ReadByteSlow();
			}
			byte[] buffer = this._buffer;
			int readPos = this._readPos;
			this._readPos = readPos + 1;
			return buffer[readPos];
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x001633E4 File Offset: 0x001615E4
		private int ReadByteSlow()
		{
			this.EnsureNotClosed();
			this.EnsureCanRead();
			if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			this.EnsureBufferAllocated();
			this._readLen = this._stream.Read(this._buffer, 0, this._bufferSize);
			this._readPos = 0;
			if (this._readLen == 0)
			{
				return -1;
			}
			byte[] buffer = this._buffer;
			int readPos = this._readPos;
			this._readPos = readPos + 1;
			return buffer[readPos];
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x0016345C File Offset: 0x0016165C
		private void WriteToBuffer(byte[] array, ref int offset, ref int count)
		{
			int num = Math.Min(this._bufferSize - this._writePos, count);
			if (num <= 0)
			{
				return;
			}
			this.EnsureBufferAllocated();
			Buffer.BlockCopy(array, offset, this._buffer, this._writePos, num);
			this._writePos += num;
			count -= num;
			offset += num;
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x001634B8 File Offset: 0x001616B8
		private int WriteToBuffer(ReadOnlySpan<byte> buffer)
		{
			int num = Math.Min(this._bufferSize - this._writePos, buffer.Length);
			if (num > 0)
			{
				this.EnsureBufferAllocated();
				buffer.Slice(0, num).CopyTo(new Span<byte>(this._buffer, this._writePos, num));
				this._writePos += num;
			}
			return num;
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x0016351C File Offset: 0x0016171C
		private void WriteToBuffer(byte[] array, ref int offset, ref int count, out Exception error)
		{
			try
			{
				error = null;
				this.WriteToBuffer(array, ref offset, ref count);
			}
			catch (Exception ex)
			{
				error = ex;
			}
		}

		/// <summary>Копирует байты в буферизованный поток и перемещает текущую позицию в буферизованном потоке вперед на количество записанных байтов.</summary>
		/// <param name="array">Массив байтов, из которого необходимо скопировать <paramref name="count" /> байтов в текущий буферизованный поток.</param>
		/// <param name="offset">Смещение в буфере, с которого необходимо начать копирование байтов в текущий буферизованный поток.</param>
		/// <param name="count">Количество байтов, которые необходимо записать в текущий буферизованный поток.</param>
		/// <exception cref="T:System.ArgumentException">Длина <paramref name="array" /> минус <paramref name="offset" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Поток закрыт или его значение равно <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x06006834 RID: 26676 RVA: 0x00163550 File Offset: 0x00161750
		public override void Write(byte[] array, int offset, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (array.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			this.EnsureNotClosed();
			this.EnsureCanWrite();
			if (this._writePos == 0)
			{
				this.ClearReadBufferBeforeWrite();
			}
			int num = checked(this._writePos + count);
			if (checked(num + count >= this._bufferSize + this._bufferSize))
			{
				if (this._writePos > 0)
				{
					if (num <= this._bufferSize + this._bufferSize && num <= 81920)
					{
						this.EnsureShadowBufferAllocated();
						Buffer.BlockCopy(array, offset, this._buffer, this._writePos, count);
						this._stream.Write(this._buffer, 0, num);
						this._writePos = 0;
						return;
					}
					this._stream.Write(this._buffer, 0, this._writePos);
					this._writePos = 0;
				}
				this._stream.Write(array, offset, count);
				return;
			}
			this.WriteToBuffer(array, ref offset, ref count);
			if (this._writePos < this._bufferSize)
			{
				return;
			}
			this._stream.Write(this._buffer, 0, this._writePos);
			this._writePos = 0;
			this.WriteToBuffer(array, ref offset, ref count);
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x001636AC File Offset: 0x001618AC
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			this.EnsureNotClosed();
			this.EnsureCanWrite();
			if (this._writePos == 0)
			{
				this.ClearReadBufferBeforeWrite();
			}
			int num = checked(this._writePos + buffer.Length);
			if (checked(num + buffer.Length >= this._bufferSize + this._bufferSize))
			{
				if (this._writePos > 0)
				{
					if (num <= this._bufferSize + this._bufferSize && num <= 81920)
					{
						this.EnsureShadowBufferAllocated();
						buffer.CopyTo(new Span<byte>(this._buffer, this._writePos, buffer.Length));
						this._stream.Write(this._buffer, 0, num);
						this._writePos = 0;
						return;
					}
					this._stream.Write(this._buffer, 0, this._writePos);
					this._writePos = 0;
				}
				this._stream.Write(buffer);
				return;
			}
			int start = this.WriteToBuffer(buffer);
			if (this._writePos < this._bufferSize)
			{
				return;
			}
			buffer = buffer.Slice(start);
			this._stream.Write(this._buffer, 0, this._writePos);
			this._writePos = 0;
			start = this.WriteToBuffer(buffer);
		}

		/// <summary>Асинхронно записывает последовательность байтов в текущий поток, перемещает текущую позицию внутри потока на число записанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в объекте <paramref name="buffer" />, с которого начинается копирование байтов в поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06006836 RID: 26678 RVA: 0x001637D4 File Offset: 0x001619D4
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
			return this.WriteAsync(new ReadOnlyMemory<byte>(buffer, offset, count), cancellationToken).AsTask();
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x00163848 File Offset: 0x00161A48
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask(Task.FromCanceled<int>(cancellationToken));
			}
			this.EnsureNotClosed();
			this.EnsureCanWrite();
			SemaphoreSlim semaphoreSlim = this.LazyEnsureAsyncActiveSemaphoreInitialized();
			Task task = semaphoreSlim.WaitAsync();
			if (task.IsCompletedSuccessfully)
			{
				bool flag = true;
				try
				{
					if (this._writePos == 0)
					{
						this.ClearReadBufferBeforeWrite();
					}
					flag = (buffer.Length < this._bufferSize - this._writePos);
					if (flag)
					{
						this.WriteToBuffer(buffer.Span);
						return default(ValueTask);
					}
				}
				finally
				{
					if (flag)
					{
						semaphoreSlim.Release();
					}
				}
			}
			return new ValueTask(this.WriteToUnderlyingStreamAsync(buffer, cancellationToken, task));
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x00163900 File Offset: 0x00161B00
		private Task WriteToUnderlyingStreamAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken, Task semaphoreLockTask)
		{
			BufferedStream.<WriteToUnderlyingStreamAsync>d__63 <WriteToUnderlyingStreamAsync>d__;
			<WriteToUnderlyingStreamAsync>d__.<>4__this = this;
			<WriteToUnderlyingStreamAsync>d__.buffer = buffer;
			<WriteToUnderlyingStreamAsync>d__.cancellationToken = cancellationToken;
			<WriteToUnderlyingStreamAsync>d__.semaphoreLockTask = semaphoreLockTask;
			<WriteToUnderlyingStreamAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteToUnderlyingStreamAsync>d__.<>1__state = -1;
			<WriteToUnderlyingStreamAsync>d__.<>t__builder.Start<BufferedStream.<WriteToUnderlyingStreamAsync>d__63>(ref <WriteToUnderlyingStreamAsync>d__);
			return <WriteToUnderlyingStreamAsync>d__.<>t__builder.Task;
		}

		/// <summary>Начинает операцию асинхронной записи. (Рекомендуется использовать <see cref="M:System.IO.BufferedStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" />.)</summary>
		/// <param name="buffer">Буфер, содержащий данные для записи в текущий поток.</param>
		/// <param name="offset">Отсчитываемое от нуля смещение байтов в буфере <paramref name="buffer" />, с которого начинается копирование байтов в текущий поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="callback">Метод, вызываемый после завершения операции асинхронной записи.</param>
		/// <param name="state">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронную запись от других запросов.</param>
		/// <returns>Объект, который ссылается на асинхронную операцию записи, которая может все еще быть отложена.</returns>
		/// <exception cref="T:System.ArgumentException">Длина <paramref name="buffer" /> минус <paramref name="offset" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		// Token: 0x06006839 RID: 26681 RVA: 0x000A45AF File Offset: 0x000A27AF
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.WriteAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		/// <summary>Завершает асинхронную операцию записи и блокирует до тех пор, пока не будет завершена операция ввода-вывода. (Рекомендуется использовать <see cref="M:System.IO.BufferedStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" />.)</summary>
		/// <param name="asyncResult">Отложенный асинхронный запрос.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Этот объект <see cref="T:System.IAsyncResult" /> не был создан путем вызова <see cref="M:System.IO.BufferedStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> для данного класса.</exception>
		// Token: 0x0600683A RID: 26682 RVA: 0x000A45C8 File Offset: 0x000A27C8
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		/// <summary>Записывает байт в текущую позицию буферизованного потока.</summary>
		/// <param name="value">Байт, который необходимо записать в поток.</param>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x0600683B RID: 26683 RVA: 0x0016395C File Offset: 0x00161B5C
		public override void WriteByte(byte value)
		{
			this.EnsureNotClosed();
			if (this._writePos == 0)
			{
				this.EnsureCanWrite();
				this.ClearReadBufferBeforeWrite();
				this.EnsureBufferAllocated();
			}
			if (this._writePos >= this._bufferSize - 1)
			{
				this.FlushWrite();
			}
			byte[] buffer = this._buffer;
			int writePos = this._writePos;
			this._writePos = writePos + 1;
			buffer[writePos] = value;
		}

		/// <summary>Задает позицию в текущем буферизованном потоке.</summary>
		/// <param name="offset">Смещение в байтах относительно <paramref name="origin" />.</param>
		/// <param name="origin">Значение типа <see cref="T:System.IO.SeekOrigin" />, указывающее точку отсчета, относительно которой задается новая позиция.</param>
		/// <returns>Новая позиция в текущем буферизованном потоке.</returns>
		/// <exception cref="T:System.IO.IOException">Поток не открыт или его значение равно <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает поиск.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x0600683C RID: 26684 RVA: 0x001639B8 File Offset: 0x00161BB8
		public override long Seek(long offset, SeekOrigin origin)
		{
			this.EnsureNotClosed();
			this.EnsureCanSeek();
			if (this._writePos > 0)
			{
				this.FlushWrite();
				return this._stream.Seek(offset, origin);
			}
			if (this._readLen - this._readPos > 0 && origin == SeekOrigin.Current)
			{
				offset -= (long)(this._readLen - this._readPos);
			}
			long position = this.Position;
			long num = this._stream.Seek(offset, origin);
			this._readPos = (int)(num - (position - (long)this._readPos));
			if (0 <= this._readPos && this._readPos < this._readLen)
			{
				this._stream.Seek((long)(this._readLen - this._readPos), SeekOrigin.Current);
			}
			else
			{
				this._readPos = (this._readLen = 0);
			}
			return num;
		}

		/// <summary>Задает длину буферизованного потока.</summary>
		/// <param name="value">Целое число, определяющее необходимую длину текущего буферизованного потока в байтах.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="value" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Поток не открыт или его значение равно <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись и поиск.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x0600683D RID: 26685 RVA: 0x00163A80 File Offset: 0x00161C80
		public override void SetLength(long value)
		{
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value", "Non-negative number required.");
			}
			this.EnsureNotClosed();
			this.EnsureCanSeek();
			this.EnsureCanWrite();
			this.Flush();
			this._stream.SetLength(value);
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x00163ABC File Offset: 0x00161CBC
		public override void CopyTo(Stream destination, int bufferSize)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			int num = this._readLen - this._readPos;
			if (num > 0)
			{
				destination.Write(this._buffer, this._readPos, num);
				this._readPos = (this._readLen = 0);
			}
			else if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			this._stream.CopyTo(destination, bufferSize);
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x00163B24 File Offset: 0x00161D24
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.CopyToAsyncCore(destination, bufferSize, cancellationToken);
			}
			return Task.FromCanceled<int>(cancellationToken);
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x00163B48 File Offset: 0x00161D48
		private Task CopyToAsyncCore(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			BufferedStream.<CopyToAsyncCore>d__71 <CopyToAsyncCore>d__;
			<CopyToAsyncCore>d__.<>4__this = this;
			<CopyToAsyncCore>d__.destination = destination;
			<CopyToAsyncCore>d__.bufferSize = bufferSize;
			<CopyToAsyncCore>d__.cancellationToken = cancellationToken;
			<CopyToAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncCore>d__.<>1__state = -1;
			<CopyToAsyncCore>d__.<>t__builder.Start<BufferedStream.<CopyToAsyncCore>d__71>(ref <CopyToAsyncCore>d__);
			return <CopyToAsyncCore>d__.<>t__builder.Task;
		}

		// Token: 0x04003C87 RID: 15495
		private const int MaxShadowBufferSize = 81920;

		// Token: 0x04003C88 RID: 15496
		private const int DefaultBufferSize = 4096;

		// Token: 0x04003C89 RID: 15497
		private Stream _stream;

		// Token: 0x04003C8A RID: 15498
		private byte[] _buffer;

		// Token: 0x04003C8B RID: 15499
		private readonly int _bufferSize;

		// Token: 0x04003C8C RID: 15500
		private int _readPos;

		// Token: 0x04003C8D RID: 15501
		private int _readLen;

		// Token: 0x04003C8E RID: 15502
		private int _writePos;

		// Token: 0x04003C8F RID: 15503
		private Task<int> _lastSyncCompletedReadTask;

		// Token: 0x04003C90 RID: 15504
		private SemaphoreSlim _asyncActiveSemaphore;
	}
}
