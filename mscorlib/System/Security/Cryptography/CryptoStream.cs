using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Security.Cryptography
{
	/// <summary>Определяет поток, который связывает потоки данных с криптографическими преобразованиями.</summary>
	// Token: 0x02000469 RID: 1129
	public class CryptoStream : Stream, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptoStream" />, используя целевой поток данных, преобразования и режим потока.</summary>
		/// <param name="stream">Поток для выполнения криптографического преобразования.</param>
		/// <param name="transform">Криптографическое преобразование, применяемое к потоку.</param>
		/// <param name="mode">Одно из значений перечисления <see cref="T:System.Security.Cryptography.CryptoStreamMode" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="stream" /> недопустим.</exception>
		// Token: 0x06002DD2 RID: 11730 RVA: 0x000A4174 File Offset: 0x000A2374
		public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) : this(stream, transform, mode, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
		/// <param name="stream">Поток для выполнения криптографического преобразования.</param>
		/// <param name="transform">Криптографическое преобразование, применяемое к потоку.</param>
		/// <param name="mode">Режим потока.</param>
		/// <param name="leaveOpen">
		///   <see langword="true" />, чтобы не закрывать базовый поток при ликвидации объекта <see cref="T:System.Security.Cryptography.CryptoStream" />, в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mode" /> недопустим.</exception>
		// Token: 0x06002DD3 RID: 11731 RVA: 0x000A4180 File Offset: 0x000A2380
		public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen)
		{
			this._stream = stream;
			this._transformMode = mode;
			this._transform = transform;
			this._leaveOpen = leaveOpen;
			CryptoStreamMode transformMode = this._transformMode;
			if (transformMode != CryptoStreamMode.Read)
			{
				if (transformMode != CryptoStreamMode.Write)
				{
					throw new ArgumentException("Argument {0} should be larger than {1}.");
				}
				if (!this._stream.CanWrite)
				{
					throw new ArgumentException(SR.Format("Stream was not writable.", "stream"));
				}
				this._canWrite = true;
			}
			else
			{
				if (!this._stream.CanRead)
				{
					throw new ArgumentException(SR.Format("Stream was not readable.", "stream"));
				}
				this._canRead = true;
			}
			this.InitializeBuffer();
		}

		/// <summary>Возвращает значение, определяющее, доступен ли текущий поток <see cref="T:System.Security.Cryptography.CryptoStream" /> для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если текущий поток доступен для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x000A4227 File Offset: 0x000A2427
		public override bool CanRead
		{
			get
			{
				return this._canRead;
			}
		}

		/// <summary>Возвращает значение, указывающее, возможен ли поиск в текущем потоке <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
		/// <returns>Всегда <see langword="false" />.</returns>
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, определяющее, доступен ли текущий поток <see cref="T:System.Security.Cryptography.CryptoStream" /> для записи.</summary>
		/// <returns>Значение <see langword="true" />, если текущий поток доступен для записи; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x000A422F File Offset: 0x000A242F
		public override bool CanWrite
		{
			get
			{
				return this._canWrite;
			}
		}

		/// <summary>Возвращает длину потока в байтах.</summary>
		/// <returns>Данное свойство не поддерживается.</returns>
		/// <exception cref="T:System.NotSupportedException">Данное свойство не поддерживается.</exception>
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x000A4237 File Offset: 0x000A2437
		public override long Length
		{
			get
			{
				throw new NotSupportedException("Stream does not support seeking.");
			}
		}

		/// <summary>Возвращает или задает позицию в текущем потоке.</summary>
		/// <returns>Данное свойство не поддерживается.</returns>
		/// <exception cref="T:System.NotSupportedException">Данное свойство не поддерживается.</exception>
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x000A4237 File Offset: 0x000A2437
		// (set) Token: 0x06002DD9 RID: 11737 RVA: 0x000A4237 File Offset: 0x000A2437
		public override long Position
		{
			get
			{
				throw new NotSupportedException("Stream does not support seeking.");
			}
			set
			{
				throw new NotSupportedException("Stream does not support seeking.");
			}
		}

		/// <summary>Возвращает значение, указывающее, записан ли последний буферный блок в базовый поток.</summary>
		/// <returns>Значение <see langword="true" />, если последний блок передан. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x000A4243 File Offset: 0x000A2443
		public bool HasFlushedFinalBlock
		{
			get
			{
				return this._finalBlockTransformed;
			}
		}

		/// <summary>Обновляет базовый источник данных или хранилище текущим содержимым буфера, а затем очищает буфер.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Ключ поврежден, что может привести к неправильному заполнению потока.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий поток недоступен для записи.  
		///
		/// или - 
		/// Последний блок уже преобразован.</exception>
		// Token: 0x06002DDB RID: 11739 RVA: 0x000A424C File Offset: 0x000A244C
		public void FlushFinalBlock()
		{
			if (this._finalBlockTransformed)
			{
				throw new NotSupportedException("FlushFinalBlock() method was called twice on a CryptoStream. It can only be called once.");
			}
			byte[] array = this._transform.TransformFinalBlock(this._inputBuffer, 0, this._inputBufferIndex);
			this._finalBlockTransformed = true;
			if (this._canWrite && this._outputBufferIndex > 0)
			{
				this._stream.Write(this._outputBuffer, 0, this._outputBufferIndex);
				this._outputBufferIndex = 0;
			}
			if (this._canWrite)
			{
				this._stream.Write(array, 0, array.Length);
			}
			CryptoStream cryptoStream = this._stream as CryptoStream;
			if (cryptoStream != null)
			{
				if (!cryptoStream.HasFlushedFinalBlock)
				{
					cryptoStream.FlushFinalBlock();
				}
			}
			else
			{
				this._stream.Flush();
			}
			if (this._inputBuffer != null)
			{
				Array.Clear(this._inputBuffer, 0, this._inputBuffer.Length);
			}
			if (this._outputBuffer != null)
			{
				Array.Clear(this._outputBuffer, 0, this._outputBuffer.Length);
			}
		}

		/// <summary>Очищает все буферы для текущего потока и вызывает запись всех буферизированных данных в базовое устройство.</summary>
		// Token: 0x06002DDC RID: 11740 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public override void Flush()
		{
		}

		/// <summary>Асинхронно очищает все буферы текущего потока, вызывает запись буферизованных данных в базовое устройство и отслеживает запросы отмены.</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		// Token: 0x06002DDD RID: 11741 RVA: 0x000A4336 File Offset: 0x000A2536
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (base.GetType() != typeof(CryptoStream))
			{
				return base.FlushAsync(cancellationToken);
			}
			if (!cancellationToken.IsCancellationRequested)
			{
				return Task.CompletedTask;
			}
			return Task.FromCanceled(cancellationToken);
		}

		/// <summary>Задает позицию в текущем потоке.</summary>
		/// <param name="offset">Смещение в байтах относительно параметра <paramref name="origin" />.</param>
		/// <param name="origin">Объект <see cref="T:System.IO.SeekOrigin" />, задающий опорную точку, используемую для получения новой позиции.</param>
		/// <returns>Этот метод не поддерживается.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06002DDE RID: 11742 RVA: 0x000A4237 File Offset: 0x000A2437
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("Stream does not support seeking.");
		}

		/// <summary>Устанавливает длину текущего потока.</summary>
		/// <param name="value">Нужная длина текущего потока в байтах.</param>
		/// <exception cref="T:System.NotSupportedException">Это свойство служит только для поддержки наследования от класса <see cref="T:System.IO.Stream" /> и не может применяться на практике.</exception>
		// Token: 0x06002DDF RID: 11743 RVA: 0x000A4237 File Offset: 0x000A2437
		public override void SetLength(long value)
		{
			throw new NotSupportedException("Stream does not support seeking.");
		}

		/// <summary>Асинхронно считывает последовательность байтов из текущего потока, перемещает позицию в потоке на число считанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, в который записываются данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="buffer" />, с которого начинается запись данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> объекта задач содержит общее число байтов, считанных в буфер. Результат может быть меньше запрошенного числа байтов, если число текущих доступных байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x06002DE0 RID: 11744 RVA: 0x000A436C File Offset: 0x000A256C
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckReadArguments(buffer, offset, count);
			return this.ReadAsyncInternal(buffer, offset, count, cancellationToken);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000A4382 File Offset: 0x000A2582
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.ReadAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000A439B File Offset: 0x000A259B
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToApm.End<int>(asyncResult);
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000A43A4 File Offset: 0x000A25A4
		private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			CryptoStream.<ReadAsyncInternal>d__37 <ReadAsyncInternal>d__;
			<ReadAsyncInternal>d__.<>4__this = this;
			<ReadAsyncInternal>d__.buffer = buffer;
			<ReadAsyncInternal>d__.offset = offset;
			<ReadAsyncInternal>d__.count = count;
			<ReadAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ReadAsyncInternal>d__.<>1__state = -1;
			<ReadAsyncInternal>d__.<>t__builder.Start<CryptoStream.<ReadAsyncInternal>d__37>(ref <ReadAsyncInternal>d__);
			return <ReadAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000A4408 File Offset: 0x000A2608
		public override int ReadByte()
		{
			if (this._outputBufferIndex > 1)
			{
				int result = (int)this._outputBuffer[0];
				Buffer.BlockCopy(this._outputBuffer, 1, this._outputBuffer, 0, this._outputBufferIndex - 1);
				this._outputBufferIndex--;
				return result;
			}
			return base.ReadByte();
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000A4458 File Offset: 0x000A2658
		public override void WriteByte(byte value)
		{
			if (this._inputBufferIndex + 1 < this._inputBlockSize)
			{
				byte[] inputBuffer = this._inputBuffer;
				int inputBufferIndex = this._inputBufferIndex;
				this._inputBufferIndex = inputBufferIndex + 1;
				inputBuffer[inputBufferIndex] = value;
				return;
			}
			base.WriteByte(value);
		}

		/// <summary>Считывает последовательность байтов из текущего потока и перемещает позицию внутри потока на число считанных байтов.</summary>
		/// <param name="buffer">Массив байтов. Максимальное число байтов <paramref name="count" /> считывается из текущего потока и сохраняется в параметре <paramref name="buffer" />.</param>
		/// <param name="offset">Позиция байта в параметре <paramref name="buffer" />, с которой начинается сохранение данных, считанных из текущего потока.</param>
		/// <param name="count">Максимальное количество байтов, которое должно быть считано из текущего потока.</param>
		/// <returns>Общее количество байтов, считанных в буфер. Это число может быть меньше количества запрошенных байтов, если нужное число байтов в настоящее время недоступно, а также равняться нулю, если был достигнут конец потока.</returns>
		/// <exception cref="T:System.NotSupportedException">Режим <see cref="T:System.Security.Cryptography.CryptoStreamMode" />, связанный с текущим объектом <see cref="T:System.Security.Cryptography.CryptoStream" /> не соответствует базовому потоку.  Например, это исключение возникает при использовании режима <see cref="F:System.Security.Cryptography.CryptoStreamMode.Read" /> с потоком, доступным только для записи.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма параметров <paramref name="count" /> и <paramref name="offset" /> превышает длину буфера.</exception>
		// Token: 0x06002DE6 RID: 11750 RVA: 0x000A4498 File Offset: 0x000A2698
		public override int Read(byte[] buffer, int offset, int count)
		{
			this.CheckReadArguments(buffer, offset, count);
			return this.ReadAsyncCore(buffer, offset, count, default(CancellationToken), false).GetAwaiter().GetResult();
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000A44D0 File Offset: 0x000A26D0
		private void CheckReadArguments(byte[] buffer, int offset, int count)
		{
			if (!this.CanRead)
			{
				throw new NotSupportedException("Stream does not support reading.");
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
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x000A452C File Offset: 0x000A272C
		private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			CryptoStream.<ReadAsyncCore>d__42 <ReadAsyncCore>d__;
			<ReadAsyncCore>d__.<>4__this = this;
			<ReadAsyncCore>d__.buffer = buffer;
			<ReadAsyncCore>d__.offset = offset;
			<ReadAsyncCore>d__.count = count;
			<ReadAsyncCore>d__.cancellationToken = cancellationToken;
			<ReadAsyncCore>d__.useAsync = useAsync;
			<ReadAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ReadAsyncCore>d__.<>1__state = -1;
			<ReadAsyncCore>d__.<>t__builder.Start<CryptoStream.<ReadAsyncCore>d__42>(ref <ReadAsyncCore>d__);
			return <ReadAsyncCore>d__.<>t__builder.Task;
		}

		/// <summary>Асинхронно записывает последовательность байтов в текущий поток, перемещает текущую позицию внутри потока на число записанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в <paramref name="buffer" />, с которого начинается запись байтов в поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06002DE9 RID: 11753 RVA: 0x000A4599 File Offset: 0x000A2799
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckWriteArguments(buffer, offset, count);
			return this.WriteAsyncInternal(buffer, offset, count, cancellationToken);
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000A45AF File Offset: 0x000A27AF
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.WriteAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000A45C8 File Offset: 0x000A27C8
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000A45D0 File Offset: 0x000A27D0
		private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			CryptoStream.<WriteAsyncInternal>d__46 <WriteAsyncInternal>d__;
			<WriteAsyncInternal>d__.<>4__this = this;
			<WriteAsyncInternal>d__.buffer = buffer;
			<WriteAsyncInternal>d__.offset = offset;
			<WriteAsyncInternal>d__.count = count;
			<WriteAsyncInternal>d__.cancellationToken = cancellationToken;
			<WriteAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncInternal>d__.<>1__state = -1;
			<WriteAsyncInternal>d__.<>t__builder.Start<CryptoStream.<WriteAsyncInternal>d__46>(ref <WriteAsyncInternal>d__);
			return <WriteAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Записывает последовательность байтов в текущий <see cref="T:System.Security.Cryptography.CryptoStream" /> и перемещает текущую позицию внутри потока на число записанных байтов.</summary>
		/// <param name="buffer">Массив байтов. Этот метод копирует байты <paramref name="count" /> из <paramref name="buffer" /> в текущий поток.</param>
		/// <param name="offset">Позиция байта в <paramref name="buffer" />, с которой начинается копирование байтов в текущий поток.</param>
		/// <param name="count">Количество байтов, которое необходимо записать в текущий поток.</param>
		/// <exception cref="T:System.NotSupportedException">Режим <see cref="T:System.Security.Cryptography.CryptoStreamMode" />, связанный с текущим объектом <see cref="T:System.Security.Cryptography.CryptoStream" /> не соответствует базовому потоку.  Например, это исключение возникает при использовании <see cref="F:System.Security.Cryptography.CryptoStreamMode.Write" /> с базовым потоком, доступным только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма параметров <paramref name="count" /> и <paramref name="offset" /> превышает длину буфера.</exception>
		// Token: 0x06002DED RID: 11757 RVA: 0x000A4634 File Offset: 0x000A2834
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.CheckWriteArguments(buffer, offset, count);
			this.WriteAsyncCore(buffer, offset, count, default(CancellationToken), false).GetAwaiter().GetResult();
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000A466C File Offset: 0x000A286C
		private void CheckWriteArguments(byte[] buffer, int offset, int count)
		{
			if (!this.CanWrite)
			{
				throw new NotSupportedException("Stream does not support writing.");
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
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x000A46C8 File Offset: 0x000A28C8
		private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			CryptoStream.<WriteAsyncCore>d__49 <WriteAsyncCore>d__;
			<WriteAsyncCore>d__.<>4__this = this;
			<WriteAsyncCore>d__.buffer = buffer;
			<WriteAsyncCore>d__.offset = offset;
			<WriteAsyncCore>d__.count = count;
			<WriteAsyncCore>d__.cancellationToken = cancellationToken;
			<WriteAsyncCore>d__.useAsync = useAsync;
			<WriteAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncCore>d__.<>1__state = -1;
			<WriteAsyncCore>d__.<>t__builder.Start<CryptoStream.<WriteAsyncCore>d__49>(ref <WriteAsyncCore>d__);
			return <WriteAsyncCore>d__.<>t__builder.Task;
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
		// Token: 0x06002DF0 RID: 11760 RVA: 0x000A4735 File Offset: 0x000A2935
		public void Clear()
		{
			this.Close();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.CryptoStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002DF1 RID: 11761 RVA: 0x000A4740 File Offset: 0x000A2940
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					if (!this._finalBlockTransformed)
					{
						this.FlushFinalBlock();
					}
					if (!this._leaveOpen)
					{
						this._stream.Dispose();
					}
				}
			}
			finally
			{
				try
				{
					this._finalBlockTransformed = true;
					if (this._inputBuffer != null)
					{
						Array.Clear(this._inputBuffer, 0, this._inputBuffer.Length);
					}
					if (this._outputBuffer != null)
					{
						Array.Clear(this._outputBuffer, 0, this._outputBuffer.Length);
					}
					this._inputBuffer = null;
					this._outputBuffer = null;
					this._canRead = false;
					this._canWrite = false;
				}
				finally
				{
					base.Dispose(disposing);
				}
			}
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000A47F8 File Offset: 0x000A29F8
		private void InitializeBuffer()
		{
			if (this._transform != null)
			{
				this._inputBlockSize = this._transform.InputBlockSize;
				this._inputBuffer = new byte[this._inputBlockSize];
				this._outputBlockSize = this._transform.OutputBlockSize;
				this._outputBuffer = new byte[this._outputBlockSize];
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000A4851 File Offset: 0x000A2A51
		private SemaphoreSlim AsyncActiveSemaphore
		{
			get
			{
				return LazyInitializer.EnsureInitialized<SemaphoreSlim>(ref this._lazyAsyncActiveSemaphore, () => new SemaphoreSlim(1, 1));
			}
		}

		// Token: 0x040020D1 RID: 8401
		private readonly Stream _stream;

		// Token: 0x040020D2 RID: 8402
		private readonly ICryptoTransform _transform;

		// Token: 0x040020D3 RID: 8403
		private readonly CryptoStreamMode _transformMode;

		// Token: 0x040020D4 RID: 8404
		private byte[] _inputBuffer;

		// Token: 0x040020D5 RID: 8405
		private int _inputBufferIndex;

		// Token: 0x040020D6 RID: 8406
		private int _inputBlockSize;

		// Token: 0x040020D7 RID: 8407
		private byte[] _outputBuffer;

		// Token: 0x040020D8 RID: 8408
		private int _outputBufferIndex;

		// Token: 0x040020D9 RID: 8409
		private int _outputBlockSize;

		// Token: 0x040020DA RID: 8410
		private bool _canRead;

		// Token: 0x040020DB RID: 8411
		private bool _canWrite;

		// Token: 0x040020DC RID: 8412
		private bool _finalBlockTransformed;

		// Token: 0x040020DD RID: 8413
		private SemaphoreSlim _lazyAsyncActiveSemaphore;

		// Token: 0x040020DE RID: 8414
		private readonly bool _leaveOpen;
	}
}
