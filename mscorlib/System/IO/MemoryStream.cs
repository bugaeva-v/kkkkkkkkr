using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Создает поток, резервным хранилищем которого является память.</summary>
	// Token: 0x02000B0C RID: 2828
	[Serializable]
	public class MemoryStream : Stream
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.MemoryStream" /> расширяемой емкостью, инициализированной нулевым значением.</summary>
		// Token: 0x060064E3 RID: 25827 RVA: 0x00156C1F File Offset: 0x00154E1F
		public MemoryStream() : this(0)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.MemoryStream" /> расширяемой емкостью, инициализированной с указанным значением.</summary>
		/// <param name="capacity">Исходный размер внутреннего массива в байтах.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> является отрицательным значением.</exception>
		// Token: 0x060064E4 RID: 25828 RVA: 0x00156C28 File Offset: 0x00154E28
		public MemoryStream(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", "Capacity must be positive.");
			}
			this._buffer = ((capacity != 0) ? new byte[capacity] : Array.Empty<byte>());
			this._capacity = capacity;
			this._expandable = true;
			this._writable = true;
			this._exposable = true;
			this._origin = 0;
			this._isOpen = true;
		}

		/// <summary>Инициализирует новый неизменяемый экземпляр класса <see cref="T:System.IO.MemoryStream" /> на основе указанного массива байтов.</summary>
		/// <param name="buffer">Массив байтов без знака, из которого создается текущий поток.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060064E5 RID: 25829 RVA: 0x00156C8F File Offset: 0x00154E8F
		public MemoryStream(byte[] buffer) : this(buffer, true)
		{
		}

		/// <summary>Инициализирует новый неизменяемый экземпляр класса <see cref="T:System.IO.MemoryStream" /> на основе указанного массива байтов с помощью указанного значения свойства <see cref="P:System.IO.MemoryStream.CanWrite" />.</summary>
		/// <param name="buffer">Массив байтов без знака, из которого создается данный поток.</param>
		/// <param name="writable">Параметр свойства <see cref="P:System.IO.MemoryStream.CanWrite" />, который определяет возможность поддержки потоком записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060064E6 RID: 25830 RVA: 0x00156C9C File Offset: 0x00154E9C
		public MemoryStream(byte[] buffer, bool writable)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			this._buffer = buffer;
			this._length = (this._capacity = buffer.Length);
			this._writable = writable;
			this._exposable = false;
			this._origin = 0;
			this._isOpen = true;
		}

		/// <summary>Инициализирует новый неизменяемый экземпляр класса <see cref="T:System.IO.MemoryStream" /> на основе указанной области (индекса) массива байтов.</summary>
		/// <param name="buffer">Массив байтов без знака, из которого создается данный поток.</param>
		/// <param name="index">Индекс в <paramref name="buffer" />, с которого начинается поток.</param>
		/// <param name="count">Длина потока в байтах.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		// Token: 0x060064E7 RID: 25831 RVA: 0x00156CF7 File Offset: 0x00154EF7
		public MemoryStream(byte[] buffer, int index, int count) : this(buffer, index, count, true, false)
		{
		}

		/// <summary>Инициализирует новый неизменяемый экземпляр класса <see cref="T:System.IO.MemoryStream" /> на основе указанной области массива байтов с помощью указанного значения свойства <see cref="P:System.IO.MemoryStream.CanWrite" />.</summary>
		/// <param name="buffer">Массив байтов без знака, из которого создается данный поток.</param>
		/// <param name="index">Индекс в <paramref name="buffer" />, с которого начинается поток.</param>
		/// <param name="count">Длина потока в байтах.</param>
		/// <param name="writable">Параметр свойства <see cref="P:System.IO.MemoryStream.CanWrite" />, который определяет возможность поддержки потоком записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> или <paramref name="count" /> имеет отрицательное значение.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		// Token: 0x060064E8 RID: 25832 RVA: 0x00156D04 File Offset: 0x00154F04
		public MemoryStream(byte[] buffer, int index, int count, bool writable) : this(buffer, index, count, writable, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.MemoryStream" /> на основе указанной области массива байтов с помощью указанного значения свойства <see cref="P:System.IO.MemoryStream.CanWrite" /> и возможности вызова <see cref="M:System.IO.MemoryStream.GetBuffer" /> с указанным значением.</summary>
		/// <param name="buffer">Массив байтов без знака, из которого создается данный поток.</param>
		/// <param name="index">Индекс в <paramref name="buffer" />, с которого начинается поток.</param>
		/// <param name="count">Длина потока в байтах.</param>
		/// <param name="writable">Параметр свойства <see cref="P:System.IO.MemoryStream.CanWrite" />, который определяет возможность поддержки потоком записи.</param>
		/// <param name="publiclyVisible">Значение <see langword="true" />, чтобы разрешить метод <see cref="M:System.IO.MemoryStream.GetBuffer" />, возвращающий массив байтов без знака, из которого создан поток; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		// Token: 0x060064E9 RID: 25833 RVA: 0x00156D14 File Offset: 0x00154F14
		public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			this._buffer = buffer;
			this._position = index;
			this._origin = index;
			this._length = (this._capacity = index + count);
			this._writable = writable;
			this._exposable = publiclyVisible;
			this._expandable = false;
			this._isOpen = true;
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций чтения.</summary>
		/// <returns>Значение <see langword="true" />, если поток открыт.</returns>
		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x060064EA RID: 25834 RVA: 0x00156DBC File Offset: 0x00154FBC
		public override bool CanRead
		{
			get
			{
				return this._isOpen;
			}
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций поиска.</summary>
		/// <returns>Значение <see langword="true" />, если поток открыт.</returns>
		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x060064EB RID: 25835 RVA: 0x00156DBC File Offset: 0x00154FBC
		public override bool CanSeek
		{
			get
			{
				return this._isOpen;
			}
		}

		/// <summary>Возвращает значение, определяющее в текущем потоке наличие поддержки операций записи.</summary>
		/// <returns>Значение <see langword="true" />, если поток поддерживает запись; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x060064EC RID: 25836 RVA: 0x00156DC4 File Offset: 0x00154FC4
		public override bool CanWrite
		{
			get
			{
				return this._writable;
			}
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x00156DCC File Offset: 0x00154FCC
		private void EnsureNotClosed()
		{
			if (!this._isOpen)
			{
				throw Error.GetStreamIsClosed();
			}
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x00156DDC File Offset: 0x00154FDC
		private void EnsureWriteable()
		{
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.IO.MemoryStream" /> (при необходимости освобождает и управляемые ресурсы).</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060064EF RID: 25839 RVA: 0x00156DEC File Offset: 0x00154FEC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					this._isOpen = false;
					this._writable = false;
					this._expandable = false;
					this._lastReadTask = null;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x00156E34 File Offset: 0x00155034
		private bool EnsureCapacity(int value)
		{
			if (value < 0)
			{
				throw new IOException("Stream was too long.");
			}
			if (value > this._capacity)
			{
				int num = value;
				if (num < 256)
				{
					num = 256;
				}
				if (num < this._capacity * 2)
				{
					num = this._capacity * 2;
				}
				if (this._capacity * 2 > 2147483591)
				{
					num = ((value > 2147483591) ? value : 2147483591);
				}
				this.Capacity = num;
				return true;
			}
			return false;
		}

		/// <summary>Переопределяет метод <see cref="M:System.IO.Stream.Flush" /> так, что никакие действия не выполняются.</summary>
		// Token: 0x060064F1 RID: 25841 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public override void Flush()
		{
		}

		/// <summary>Асинхронно очищает все буферы для этого потока и отслеживает запросы отмены.</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		// Token: 0x060064F2 RID: 25842 RVA: 0x00156EA8 File Offset: 0x001550A8
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

		/// <summary>Возвращает массив байтов без знака, из которого был создан данный поток.</summary>
		/// <returns>Массив байтов, из которого был создан данный поток, или базовый массив, если массив байтов не был предоставлен конструктору <see cref="T:System.IO.MemoryStream" /> в процессе конструирования текущего экземпляра.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Экземпляр <see langword="MemoryStream" /> не был создан с помощью открытого буфера.</exception>
		// Token: 0x060064F3 RID: 25843 RVA: 0x00156EF0 File Offset: 0x001550F0
		public virtual byte[] GetBuffer()
		{
			if (!this._exposable)
			{
				throw new UnauthorizedAccessException("MemoryStream's internal buffer cannot be accessed.");
			}
			return this._buffer;
		}

		/// <summary>Возвращает массив байтов без знака, из которого был создан данный поток. Возвращаемое значение указывает, успешно ли выполнено преобразование.</summary>
		/// <param name="buffer">Сегмент массива байтов, из которого был создан данный поток.</param>
		/// <returns>Значение <see langword="true" />, если преобразование прошло успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060064F4 RID: 25844 RVA: 0x00156F0B File Offset: 0x0015510B
		public virtual bool TryGetBuffer(out ArraySegment<byte> buffer)
		{
			if (!this._exposable)
			{
				buffer = default(ArraySegment<byte>);
				return false;
			}
			buffer = new ArraySegment<byte>(this._buffer, this._origin, this._length - this._origin);
			return true;
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x00156F43 File Offset: 0x00155143
		internal byte[] InternalGetBuffer()
		{
			return this._buffer;
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x00156F4B File Offset: 0x0015514B
		internal void InternalGetOriginAndLength(out int origin, out int length)
		{
			if (!this._isOpen)
			{
				__Error.StreamIsClosed();
			}
			origin = this._origin;
			length = this._length;
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00156F6A File Offset: 0x0015516A
		internal int InternalGetPosition()
		{
			return this._position;
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00156F74 File Offset: 0x00155174
		internal int InternalReadInt32()
		{
			this.EnsureNotClosed();
			int num = this._position += 4;
			if (num > this._length)
			{
				this._position = this._length;
				throw Error.GetEndOfFile();
			}
			return (int)this._buffer[num - 4] | (int)this._buffer[num - 3] << 8 | (int)this._buffer[num - 2] << 16 | (int)this._buffer[num - 1] << 24;
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00156FE8 File Offset: 0x001551E8
		internal int InternalEmulateRead(int count)
		{
			this.EnsureNotClosed();
			int num = this._length - this._position;
			if (num > count)
			{
				num = count;
			}
			if (num < 0)
			{
				num = 0;
			}
			this._position += num;
			return num;
		}

		/// <summary>Возвращает или задает число байтов, выделенных для этого потока.</summary>
		/// <returns>Длина применимой к использованию части буфера для потока.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Заданная емкость отрицательная или меньше текущей длины потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <see langword="set" /> вызывается для потока, емкость которого нельзя изменить.</exception>
		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x060064FA RID: 25850 RVA: 0x00157024 File Offset: 0x00155224
		// (set) Token: 0x060064FB RID: 25851 RVA: 0x0015703C File Offset: 0x0015523C
		public virtual int Capacity
		{
			get
			{
				this.EnsureNotClosed();
				return this._capacity - this._origin;
			}
			set
			{
				if ((long)value < this.Length)
				{
					throw new ArgumentOutOfRangeException("value", "capacity was less than the current size.");
				}
				this.EnsureNotClosed();
				if (!this._expandable && value != this.Capacity)
				{
					throw new NotSupportedException("Memory stream is not expandable.");
				}
				if (this._expandable && value != this._capacity)
				{
					if (value > 0)
					{
						byte[] array = new byte[value];
						if (this._length > 0)
						{
							Buffer.BlockCopy(this._buffer, 0, array, 0, this._length);
						}
						this._buffer = array;
					}
					else
					{
						this._buffer = null;
					}
					this._capacity = value;
				}
			}
		}

		/// <summary>Возвращает длину потока в байтах.</summary>
		/// <returns>Длина потока в байтах.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x060064FC RID: 25852 RVA: 0x001570D5 File Offset: 0x001552D5
		public override long Length
		{
			get
			{
				this.EnsureNotClosed();
				return (long)(this._length - this._origin);
			}
		}

		/// <summary>Возвращает или задает текущее положение в потоке.</summary>
		/// <returns>Текущее положение в потоке.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">В качестве положения задано отрицательное значение или значение, большее <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x060064FD RID: 25853 RVA: 0x001570EB File Offset: 0x001552EB
		// (set) Token: 0x060064FE RID: 25854 RVA: 0x00157104 File Offset: 0x00155304
		public override long Position
		{
			get
			{
				this.EnsureNotClosed();
				return (long)(this._position - this._origin);
			}
			set
			{
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value", "Non-negative number required.");
				}
				this.EnsureNotClosed();
				if (value > 2147483647L)
				{
					throw new ArgumentOutOfRangeException("value", "Stream length must be non-negative and less than 2^31 - 1 - origin.");
				}
				this._position = this._origin + (int)value;
			}
		}

		/// <summary>Считывает блок байтов из текущего потока и записывает данные в буфер.</summary>
		/// <param name="buffer">При возвращении данного метода этот параметр содержит указанный массив байтов со значениями от <paramref name="offset" /> до (<paramref name="offset" /> + <paramref name="count" /> - 1), замененными символами, считанными из текущего потока.</param>
		/// <param name="offset">Отсчитываемое от нуля смещение байтов в буфере <paramref name="buffer" />, с которого начинается сохранение данных из текущего потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <returns>Общее число байтов, записанных в буфер. Оно может быть меньше запрошенного числа байтов, если это количество в текущий момент не доступно, или же равно нулю, если конец потока достигнут до того, как байты были считаны.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера за вычетом <paramref name="offset" /> меньше, чем <paramref name="count" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр потока закрыт.</exception>
		// Token: 0x060064FF RID: 25855 RVA: 0x00157154 File Offset: 0x00155354
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
			this.EnsureNotClosed();
			int num = this._length - this._position;
			if (num > count)
			{
				num = count;
			}
			if (num <= 0)
			{
				return 0;
			}
			if (num <= 8)
			{
				int num2 = num;
				while (--num2 >= 0)
				{
					buffer[offset + num2] = this._buffer[this._position + num2];
				}
			}
			else
			{
				Buffer.BlockCopy(this._buffer, this._position, buffer, offset, num);
			}
			this._position += num;
			return num;
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00157218 File Offset: 0x00155418
		public override int Read(Span<byte> buffer)
		{
			if (base.GetType() != typeof(MemoryStream))
			{
				return base.Read(buffer);
			}
			this.EnsureNotClosed();
			int num = Math.Min(this._length - this._position, buffer.Length);
			if (num <= 0)
			{
				return 0;
			}
			new Span<byte>(this._buffer, this._position, num).CopyTo(buffer);
			this._position += num;
			return num;
		}

		/// <summary>Асинхронно считывает последовательность байтов из текущего потока, перемещает позицию в потоке на число считанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, в который записываются данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="buffer" />, с которого начинается запись данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены. Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число доступных в данный момент байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x06006501 RID: 25857 RVA: 0x00157294 File Offset: 0x00155494
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
			catch (OperationCanceledException exception)
			{
				task = Task.FromCancellation<int>(exception);
			}
			catch (Exception exception2)
			{
				task = Task.FromException<int>(exception2);
			}
			return task;
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x00157360 File Offset: 0x00155560
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
			catch (OperationCanceledException exception)
			{
				result = new ValueTask<int>(Task.FromCancellation<int>(exception));
			}
			catch (Exception exception2)
			{
				result = new ValueTask<int>(Task.FromException<int>(exception2));
			}
			return result;
		}

		/// <summary>Считывает байт из текущего потока.</summary>
		/// <returns>Байт приводится к типу <see cref="T:System.Int32" /> или -1, если достигнут конец потока.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр потока закрыт.</exception>
		// Token: 0x06006503 RID: 25859 RVA: 0x001573FC File Offset: 0x001555FC
		public override int ReadByte()
		{
			this.EnsureNotClosed();
			if (this._position >= this._length)
			{
				return -1;
			}
			byte[] buffer = this._buffer;
			int position = this._position;
			this._position = position + 1;
			return buffer[position];
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00157438 File Offset: 0x00155638
		public override void CopyTo(Stream destination, int bufferSize)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			if (base.GetType() != typeof(MemoryStream))
			{
				base.CopyTo(destination, bufferSize);
				return;
			}
			int position = this._position;
			int num = this.InternalEmulateRead(this._length - position);
			if (num > 0)
			{
				destination.Write(this._buffer, position, num);
			}
		}

		/// <summary>Асинхронно считывает все байты из текущего потока и записывает их в другой поток, используя указанный размер буфера и токен отмены.</summary>
		/// <param name="destination">Поток, в который будет скопировано содержимое текущего потока.</param>
		/// <param name="bufferSize">Размер (в байтах) буфера. Это значение должно быть больше нуля.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию копирования.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destination" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="buffersize" /> имеет отрицательное значение или равен нулю.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток или поток назначения удаляется.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий поток не поддерживает чтение или поток назначения не поддерживает запись.</exception>
		// Token: 0x06006505 RID: 25861 RVA: 0x00157498 File Offset: 0x00155698
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			if (base.GetType() != typeof(MemoryStream))
			{
				return base.CopyToAsync(destination, bufferSize, cancellationToken);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			int position = this._position;
			int num = this.InternalEmulateRead(this._length - this._position);
			if (num == 0)
			{
				return Task.CompletedTask;
			}
			MemoryStream memoryStream = destination as MemoryStream;
			if (memoryStream == null)
			{
				return destination.WriteAsync(this._buffer, position, num, cancellationToken);
			}
			Task result;
			try
			{
				memoryStream.Write(this._buffer, position, num);
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		/// <summary>Задает указанное значение для положения в текущем потоке.</summary>
		/// <param name="offset">Новое положение в потоке. Оно определяется относительно параметра <paramref name="loc" /> и может быть положительным или отрицательным.</param>
		/// <param name="loc">Значение типа <see cref="T:System.IO.SeekOrigin" />, которое действует как точка ссылки поиска.</param>
		/// <returns>Новое положение в потоке, вычисляемое путем объединения смещения и исходной точки ссылки.</returns>
		/// <exception cref="T:System.IO.IOException">Попытка поиска выполняется до начала потока.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="T:System.IO.SeekOrigin" /> недопустим.  
		///
		/// или - 
		/// Значение <paramref name="offset" /> вызвало арифметическое переполнение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр потока закрыт.</exception>
		// Token: 0x06006506 RID: 25862 RVA: 0x0015754C File Offset: 0x0015574C
		public override long Seek(long offset, SeekOrigin loc)
		{
			this.EnsureNotClosed();
			if (offset > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("offset", "Stream length must be non-negative and less than 2^31 - 1 - origin.");
			}
			switch (loc)
			{
			case SeekOrigin.Begin:
			{
				int num = this._origin + (int)offset;
				if (offset < 0L || num < this._origin)
				{
					throw new IOException("An attempt was made to move the position before the beginning of the stream.");
				}
				this._position = num;
				break;
			}
			case SeekOrigin.Current:
			{
				int num2 = this._position + (int)offset;
				if ((long)this._position + offset < (long)this._origin || num2 < this._origin)
				{
					throw new IOException("An attempt was made to move the position before the beginning of the stream.");
				}
				this._position = num2;
				break;
			}
			case SeekOrigin.End:
			{
				int num3 = this._length + (int)offset;
				if ((long)this._length + offset < (long)this._origin || num3 < this._origin)
				{
					throw new IOException("An attempt was made to move the position before the beginning of the stream.");
				}
				this._position = num3;
				break;
			}
			default:
				throw new ArgumentException("Invalid seek origin.");
			}
			return (long)this._position;
		}

		/// <summary>Задает указанное значение для длины текущего потока.</summary>
		/// <param name="value">Значение задаваемой длины.</param>
		/// <exception cref="T:System.NotSupportedException">Размер текущего потока изменить нельзя, и значение параметра <paramref name="value" /> больше текущей емкости.  
		///
		/// или - 
		/// Текущий поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="value" /> отрицательное или больше максимальной длины <see cref="T:System.IO.MemoryStream" />, где максимальная длина равна (<see cref="F:System.Int32.MaxValue" /> - источник). Источник — это индекс в основном буфере, с которого начинается поток.</exception>
		// Token: 0x06006507 RID: 25863 RVA: 0x00157640 File Offset: 0x00155840
		public override void SetLength(long value)
		{
			if (value < 0L || value > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("value", "Stream length must be non-negative and less than 2^31 - 1 - origin.");
			}
			this.EnsureWriteable();
			if (value > (long)(2147483647 - this._origin))
			{
				throw new ArgumentOutOfRangeException("value", "Stream length must be non-negative and less than 2^31 - 1 - origin.");
			}
			int num = this._origin + (int)value;
			if (!this.EnsureCapacity(num) && num > this._length)
			{
				Array.Clear(this._buffer, this._length, num - this._length);
			}
			this._length = num;
			if (this._position > num)
			{
				this._position = num;
			}
		}

		/// <summary>Записывает содержимое потока в массив байтов независимо от свойства <see cref="P:System.IO.MemoryStream.Position" />.</summary>
		/// <returns>Новый массив байтов.</returns>
		// Token: 0x06006508 RID: 25864 RVA: 0x001576E0 File Offset: 0x001558E0
		public virtual byte[] ToArray()
		{
			int num = this._length - this._origin;
			if (num == 0)
			{
				return Array.Empty<byte>();
			}
			byte[] array = new byte[num];
			Buffer.BlockCopy(this._buffer, this._origin, array, 0, num);
			return array;
		}

		/// <summary>Записывает в текущий поток блок байтов, используя данные, считанные из буфера.</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Отсчитываемое от нуля смещение байтов в буфере <paramref name="buffer" />, с которого начинается копирование байтов в текущий поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись. Дополнительные сведения см. в разделе <see cref="P:System.IO.Stream.CanWrite" />.  
		///
		/// или - 
		/// Текущее положение ближе к концу потока, чем число байтов <paramref name="count" />, и емкость изменить невозможно.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера за вычетом <paramref name="offset" /> меньше, чем <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="offset" /> или <paramref name="count" /> имеет отрицательное значение.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр потока закрыт.</exception>
		// Token: 0x06006509 RID: 25865 RVA: 0x00157720 File Offset: 0x00155920
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
			this.EnsureNotClosed();
			this.EnsureWriteable();
			int num = this._position + count;
			if (num < 0)
			{
				throw new IOException("Stream was too long.");
			}
			if (num > this._length)
			{
				bool flag = this._position > this._length;
				if (num > this._capacity && this.EnsureCapacity(num))
				{
					flag = false;
				}
				if (flag)
				{
					Array.Clear(this._buffer, this._length, num - this._length);
				}
				this._length = num;
			}
			if (count <= 8 && buffer != this._buffer)
			{
				int num2 = count;
				while (--num2 >= 0)
				{
					this._buffer[this._position + num2] = buffer[offset + num2];
				}
			}
			else
			{
				Buffer.BlockCopy(buffer, offset, this._buffer, this._position, count);
			}
			this._position = num;
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x00157838 File Offset: 0x00155A38
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			if (base.GetType() != typeof(MemoryStream))
			{
				base.Write(buffer);
				return;
			}
			this.EnsureNotClosed();
			this.EnsureWriteable();
			int num = this._position + buffer.Length;
			if (num < 0)
			{
				throw new IOException("Stream was too long.");
			}
			if (num > this._length)
			{
				bool flag = this._position > this._length;
				if (num > this._capacity && this.EnsureCapacity(num))
				{
					flag = false;
				}
				if (flag)
				{
					Array.Clear(this._buffer, this._length, num - this._length);
				}
				this._length = num;
			}
			buffer.CopyTo(new Span<byte>(this._buffer, this._position, buffer.Length));
			this._position = num;
		}

		/// <summary>Асинхронно записывает последовательность байтов в текущий поток, перемещает текущую позицию внутри потока на число записанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в объекте <paramref name="buffer" />, с которого начинается копирование байтов в поток.</param>
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
		// Token: 0x0600650B RID: 25867 RVA: 0x00157904 File Offset: 0x00155B04
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
			catch (OperationCanceledException exception)
			{
				result = Task.FromCancellation<VoidTaskResult>(exception);
			}
			catch (Exception exception2)
			{
				result = Task.FromException(exception2);
			}
			return result;
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x001579B0 File Offset: 0x00155BB0
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
			catch (OperationCanceledException exception)
			{
				valueTask = new ValueTask(Task.FromCancellation<VoidTaskResult>(exception));
			}
			catch (Exception exception2)
			{
				valueTask = new ValueTask(Task.FromException(exception2));
			}
			return valueTask;
		}

		/// <summary>Записывает байт в текущее положение текущего потока.</summary>
		/// <param name="value">Записываемый байт.</param>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись. Дополнительные сведения см. в разделе <see cref="P:System.IO.Stream.CanWrite" />.  
		///
		/// или - 
		/// Текущее положение находится в конце потока и емкость изменить невозможно.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток закрыт.</exception>
		// Token: 0x0600650D RID: 25869 RVA: 0x00157A4C File Offset: 0x00155C4C
		public override void WriteByte(byte value)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			if (this._position >= this._length)
			{
				int num = this._position + 1;
				bool flag = this._position > this._length;
				if (num >= this._capacity && this.EnsureCapacity(num))
				{
					flag = false;
				}
				if (flag)
				{
					Array.Clear(this._buffer, this._length, this._position - this._length);
				}
				this._length = num;
			}
			byte[] buffer = this._buffer;
			int position = this._position;
			this._position = position + 1;
			buffer[position] = value;
		}

		/// <summary>Записывает все содержимое данного потока памяти в другой поток.</summary>
		/// <param name="stream">Поток, в который требуется осуществить запись данного потока памяти.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий или конечный поток закрыт.</exception>
		// Token: 0x0600650E RID: 25870 RVA: 0x00157AE0 File Offset: 0x00155CE0
		public virtual void WriteTo(Stream stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream", "Stream cannot be null.");
			}
			this.EnsureNotClosed();
			stream.Write(this._buffer, this._origin, this._length - this._origin);
		}

		// Token: 0x04003B4B RID: 15179
		private byte[] _buffer;

		// Token: 0x04003B4C RID: 15180
		private int _origin;

		// Token: 0x04003B4D RID: 15181
		private int _position;

		// Token: 0x04003B4E RID: 15182
		private int _length;

		// Token: 0x04003B4F RID: 15183
		private int _capacity;

		// Token: 0x04003B50 RID: 15184
		private bool _expandable;

		// Token: 0x04003B51 RID: 15185
		private bool _writable;

		// Token: 0x04003B52 RID: 15186
		private bool _exposable;

		// Token: 0x04003B53 RID: 15187
		private bool _isOpen;

		// Token: 0x04003B54 RID: 15188
		[NonSerialized]
		private Task<int> _lastReadTask;

		// Token: 0x04003B55 RID: 15189
		private const int MemStreamMaxLength = 2147483647;
	}
}
