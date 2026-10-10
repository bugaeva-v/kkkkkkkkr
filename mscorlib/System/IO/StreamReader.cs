using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Реализует объект <see cref="T:System.IO.TextReader" />, который считывает символы из потока байтов в определенной кодировке.</summary>
	// Token: 0x02000B12 RID: 2834
	[Serializable]
	public class StreamReader : TextReader
	{
		// Token: 0x06006537 RID: 25911 RVA: 0x0015865F File Offset: 0x0015685F
		private void CheckAsyncTaskInProgress()
		{
			if (!this._asyncReadTask.IsCompleted)
			{
				StreamReader.ThrowAsyncIOInProgress();
			}
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00158673 File Offset: 0x00156873
		private static void ThrowAsyncIOInProgress()
		{
			throw new InvalidOperationException("The stream is currently in use by a previous operation on the stream.");
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x0015867F File Offset: 0x0015687F
		internal StreamReader()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для заданного потока.</summary>
		/// <param name="stream">Поток, который нужно считать.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="stream" /> не поддерживает чтение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600653A RID: 25914 RVA: 0x00158692 File Offset: 0x00156892
		public StreamReader(Stream stream) : this(stream, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для указанного потока, используя заданный параметр обнаружения метки порядка следования байтов.</summary>
		/// <param name="stream">Поток, который нужно считать.</param>
		/// <param name="detectEncodingFromByteOrderMarks">Указывает, следует ли выполнять поиск меток порядка байтов с начала файла.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="stream" /> не поддерживает чтение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600653B RID: 25915 RVA: 0x0015869C File Offset: 0x0015689C
		public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks) : this(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks, 1024, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для заданного потока, используя указанную кодировку символов.</summary>
		/// <param name="stream">Поток, который нужно считать.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="stream" /> не поддерживает чтение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="stream" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600653C RID: 25916 RVA: 0x001586B1 File Offset: 0x001568B1
		public StreamReader(Stream stream, Encoding encoding) : this(stream, encoding, true, 1024, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для заданного потока, используя указанную кодировку символов и параметр обнаружения метки порядка байтов.</summary>
		/// <param name="stream">Поток, который нужно считать.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <param name="detectEncodingFromByteOrderMarks">Указывает, следует ли выполнять поиск меток порядка байтов с начала файла.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="stream" /> не поддерживает чтение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="stream" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600653D RID: 25917 RVA: 0x001586C2 File Offset: 0x001568C2
		public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks) : this(stream, encoding, detectEncodingFromByteOrderMarks, 1024, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для заданного потока, используя указанную кодировку символов, параметр обнаружения метки порядка байтов и размер буфера.</summary>
		/// <param name="stream">Поток, который нужно считать.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <param name="detectEncodingFromByteOrderMarks">Указывает, следует ли выполнять поиск меток порядка байтов с начала файла.</param>
		/// <param name="bufferSize">Минимальный размер буфера.</param>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="stream" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="bufferSize" /> не больше нуля.</exception>
		// Token: 0x0600653E RID: 25918 RVA: 0x001586D3 File Offset: 0x001568D3
		public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) : this(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для указанного потока на основе заданной кодировки символов, параметра обнаружения меток порядка байтов и размера буфера, а также при необходимости оставляет поток открытым.</summary>
		/// <param name="stream">Считываемый поток.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <param name="detectEncodingFromByteOrderMarks">Значение <see langword="true" />, если метки порядка байтов необходимо искать в начале файла; в противном случае — значение <see langword="false" />.</param>
		/// <param name="bufferSize">Минимальный размер буфера.</param>
		/// <param name="leaveOpen">Значение <see langword="true" />, чтобы оставить поток открытым после удаления объекта <see cref="T:System.IO.StreamReader" />; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600653F RID: 25919 RVA: 0x001586E4 File Offset: 0x001568E4
		public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			if (stream == null || encoding == null)
			{
				throw new ArgumentNullException((stream == null) ? "stream" : "encoding");
			}
			if (!stream.CanRead)
			{
				throw new ArgumentException("Stream was not readable.");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", "Positive number required.");
			}
			this.Init(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для указанного имени файла.</summary>
		/// <param name="path">Полный путь к файлу для чтения.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> содержит неправильный или недопустимый синтаксис имени файла, имени каталога или метки тома.</exception>
		// Token: 0x06006540 RID: 25920 RVA: 0x00158752 File Offset: 0x00156952
		public StreamReader(string path) : this(path, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для заданного имени файла, используя указанный параметр обнаружения меток порядка байтов.</summary>
		/// <param name="path">Полный путь к файлу для чтения.</param>
		/// <param name="detectEncodingFromByteOrderMarks">Указывает, следует ли выполнять поиск меток порядка байтов с начала файла.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> содержит неправильный или недопустимый синтаксис имени файла, имени каталога или метки тома.</exception>
		// Token: 0x06006541 RID: 25921 RVA: 0x0015875C File Offset: 0x0015695C
		public StreamReader(string path, bool detectEncodingFromByteOrderMarks) : this(path, Encoding.UTF8, detectEncodingFromByteOrderMarks, 1024)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для заданного имени файла, используя указанную кодировку символов.</summary>
		/// <param name="path">Полный путь к файлу для чтения.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> содержит неправильный или недопустимый синтаксис имени файла, имени каталога или метки тома.</exception>
		// Token: 0x06006542 RID: 25922 RVA: 0x00158770 File Offset: 0x00156970
		public StreamReader(string path, Encoding encoding) : this(path, encoding, true, 1024)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для заданного имени файла, используя указанную кодировку символов и параметр обнаружения меток порядка байтов.</summary>
		/// <param name="path">Полный путь к файлу для чтения.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <param name="detectEncodingFromByteOrderMarks">Указывает, следует ли выполнять поиск меток порядка байтов с начала файла.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> содержит неправильный или недопустимый синтаксис имени файла, имени каталога или метки тома.</exception>
		// Token: 0x06006543 RID: 25923 RVA: 0x00158780 File Offset: 0x00156980
		public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) : this(path, encoding, detectEncodingFromByteOrderMarks, 1024)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StreamReader" /> для заданного имени файла, используя указанную кодировку символов, параметр обнаружения меток порядка байтов и размер буфера.</summary>
		/// <param name="path">Полный путь к файлу для чтения.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <param name="detectEncodingFromByteOrderMarks">Указывает, следует ли выполнять поиск меток порядка байтов с начала файла.</param>
		/// <param name="bufferSize">Минимальный размер буфера (в 16-разрядных символах).</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> содержит неправильный или недопустимый синтаксис имени файла, имени каталога или метки тома.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="buffersize" /> не больше нуля.</exception>
		// Token: 0x06006544 RID: 25924 RVA: 0x00158790 File Offset: 0x00156990
		public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", "Positive number required.");
			}
			Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan);
			this.Init(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, false);
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x00158814 File Offset: 0x00156A14
		private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			this._stream = stream;
			this._encoding = encoding;
			this._decoder = encoding.GetDecoder();
			if (bufferSize < 128)
			{
				bufferSize = 128;
			}
			this._byteBuffer = new byte[bufferSize];
			this._maxCharsPerBuffer = encoding.GetMaxCharCount(bufferSize);
			this._charBuffer = new char[this._maxCharsPerBuffer];
			this._byteLen = 0;
			this._bytePos = 0;
			this._detectEncoding = detectEncodingFromByteOrderMarks;
			this._checkPreamble = (encoding.Preamble.Length > 0);
			this._isBlocked = false;
			this._closable = !leaveOpen;
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x001588B5 File Offset: 0x00156AB5
		internal void Init(Stream stream)
		{
			this._stream = stream;
			this._closable = true;
		}

		/// <summary>Закрывает объект <see cref="T:System.IO.StreamReader" /> и основной поток и освобождает все системные ресурсы, связанные с устройством чтения.</summary>
		// Token: 0x06006547 RID: 25927 RVA: 0x001588C5 File Offset: 0x00156AC5
		public override void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Закрывает основной поток, освобождает неуправляемые ресурсы, используемые <see cref="T:System.IO.StreamReader" />, и при необходимости освобождает управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06006548 RID: 25928 RVA: 0x001588D0 File Offset: 0x00156AD0
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this.LeaveOpen && disposing && this._stream != null)
				{
					this._stream.Close();
				}
			}
			finally
			{
				if (!this.LeaveOpen && this._stream != null)
				{
					this._stream = null;
					this._encoding = null;
					this._decoder = null;
					this._byteBuffer = null;
					this._charBuffer = null;
					this._charPos = 0;
					this._charLen = 0;
					base.Dispose(disposing);
				}
			}
		}

		/// <summary>Возвращает текущую кодировку символов, используемую текущим объектом <see cref="T:System.IO.StreamReader" />.</summary>
		/// <returns>Текущая кодировка символов, используемая текущим устройством чтения. После первого вызова любого метода <see cref="Overload:System.IO.StreamReader.Read" /> объекта <see cref="T:System.IO.StreamReader" /> значение может измениться, поскольку до первого вызова метода <see cref="Overload:System.IO.StreamReader.Read" /> автоматическое определение кодировки не выполняется.</returns>
		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06006549 RID: 25929 RVA: 0x00158958 File Offset: 0x00156B58
		public virtual Encoding CurrentEncoding
		{
			get
			{
				return this._encoding;
			}
		}

		/// <summary>Возвращает основной поток.</summary>
		/// <returns>Основной поток.</returns>
		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600654A RID: 25930 RVA: 0x00158960 File Offset: 0x00156B60
		public virtual Stream BaseStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600654B RID: 25931 RVA: 0x00158968 File Offset: 0x00156B68
		internal bool LeaveOpen
		{
			get
			{
				return !this._closable;
			}
		}

		/// <summary>Очищает внутренний буфер.</summary>
		// Token: 0x0600654C RID: 25932 RVA: 0x00158973 File Offset: 0x00156B73
		public void DiscardBufferedData()
		{
			this.CheckAsyncTaskInProgress();
			this._byteLen = 0;
			this._charLen = 0;
			this._charPos = 0;
			if (this._encoding != null)
			{
				this._decoder = this._encoding.GetDecoder();
			}
			this._isBlocked = false;
		}

		/// <summary>Возвращает значение, определяющее, находится ли позиция текущего потока в конце потока.</summary>
		/// <returns>Значение <see langword="true" />, если текущее положение находится в конце потока; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Базовый поток был удален.</exception>
		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x0600654D RID: 25933 RVA: 0x001589B0 File Offset: 0x00156BB0
		public bool EndOfStream
		{
			get
			{
				if (this._stream == null)
				{
					throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
				}
				this.CheckAsyncTaskInProgress();
				return this._charPos >= this._charLen && this.ReadBuffer() == 0;
			}
		}

		/// <summary>Возвращает следующий доступный символ, но не использует его.</summary>
		/// <returns>Целое число, представляющее следующий символ для прочтения или значение -1, если доступных для чтения символов нет или поток не поддерживает поиск.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600654E RID: 25934 RVA: 0x001589E8 File Offset: 0x00156BE8
		public override int Peek()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && (this._isBlocked || this.ReadBuffer() == 0))
			{
				return -1;
			}
			return (int)this._charBuffer[this._charPos];
		}

		/// <summary>Выполняет чтение следующего символа из входного потока и перемещает положение символа на одну позицию вперед.</summary>
		/// <returns>Следующий символ из входного потока, представленный в виде объекта <see cref="T:System.Int32" />, или значение -1, если больше нет доступных символов.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600654F RID: 25935 RVA: 0x00158A3C File Offset: 0x00156C3C
		public override int Read()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && this.ReadBuffer() == 0)
			{
				return -1;
			}
			int result = (int)this._charBuffer[this._charPos];
			this._charPos++;
			return result;
		}

		/// <summary>Считывает заданное максимальное количество символов из текущего потока в буфер начиная с заданного индекса.</summary>
		/// <param name="buffer">При возвращении данного метода содержит заданный массив знаков, в котором значения в интервале между <paramref name="index" /> и (index + count – 1) заменены знаками, считанными из текущего источника.</param>
		/// <param name="index">Индекс <paramref name="buffer" />, с которого требуется начать запись.</param>
		/// <param name="count">Максимальное число считываемых символов.</param>
		/// <returns>Число символов, которые были считаны, или значение 0, если к концу потока не было считано никаких данных. Это число будет не больше параметра <paramref name="count" />, в зависимости от доступности данных в потоке.</returns>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода, например "Поток закрыт".</exception>
		// Token: 0x06006550 RID: 25936 RVA: 0x00158A98 File Offset: 0x00156C98
		public override int Read(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return this.ReadSpan(new Span<char>(buffer, index, count));
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x00158AFC File Offset: 0x00156CFC
		public override int Read(Span<char> buffer)
		{
			if (!(base.GetType() == typeof(StreamReader)))
			{
				return base.Read(buffer);
			}
			return this.ReadSpan(buffer);
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x00158B24 File Offset: 0x00156D24
		private int ReadSpan(Span<char> buffer)
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			int num = 0;
			bool flag = false;
			int i = buffer.Length;
			while (i > 0)
			{
				int num2 = this._charLen - this._charPos;
				if (num2 == 0)
				{
					num2 = this.ReadBuffer(buffer.Slice(num), out flag);
				}
				if (num2 == 0)
				{
					break;
				}
				if (num2 > i)
				{
					num2 = i;
				}
				if (!flag)
				{
					new Span<char>(this._charBuffer, this._charPos, num2).CopyTo(buffer.Slice(num));
					this._charPos += num2;
				}
				num += num2;
				i -= num2;
				if (this._isBlocked)
				{
					break;
				}
			}
			return num;
		}

		/// <summary>Считывает все символы, начиная с текущей позиции до конца потока.</summary>
		/// <returns>Остальная часть потока в виде строки (от текущего положения до конца). Если текущее положение находится в конце потока, возвращается пустая строка ("").</returns>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти для выделения буфера под возвращаемую строку.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006553 RID: 25939 RVA: 0x00158BD0 File Offset: 0x00156DD0
		public override string ReadToEnd()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			StringBuilder stringBuilder = new StringBuilder(this._charLen - this._charPos);
			do
			{
				stringBuilder.Append(this._charBuffer, this._charPos, this._charLen - this._charPos);
				this._charPos = this._charLen;
				this.ReadBuffer();
			}
			while (this._charLen > 0);
			return stringBuilder.ToString();
		}

		/// <summary>Считывает указанное максимальное количество символов из текущего потока и записывает данные в буфер, начиная с заданного индекса.</summary>
		/// <param name="buffer">При возвращении данного метода содержит заданный массив знаков, в котором значения в интервале между <paramref name="index" /> и (index + count – 1) заменены знаками, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов.</param>
		/// <returns>Количество считанных символов. Число будет меньше или равно значению <paramref name="count" />, в зависимости от того, считаны ли все входящие символы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.IO.StreamReader" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06006554 RID: 25940 RVA: 0x00158C4C File Offset: 0x00156E4C
		public override int ReadBlock(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			return base.ReadBlock(buffer, index, count);
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x00158CC8 File Offset: 0x00156EC8
		public override int ReadBlock(Span<char> buffer)
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadBlock(buffer);
			}
			int num = 0;
			int num2;
			do
			{
				num2 = this.ReadSpan(buffer.Slice(num));
				num += num2;
			}
			while (num2 > 0 && num < buffer.Length);
			return num;
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x00158D18 File Offset: 0x00156F18
		private void CompressBuffer(int n)
		{
			Buffer.BlockCopy(this._byteBuffer, n, this._byteBuffer, 0, this._byteLen - n);
			this._byteLen -= n;
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x00158D44 File Offset: 0x00156F44
		private void DetectEncoding()
		{
			if (this._byteLen < 2)
			{
				return;
			}
			this._detectEncoding = false;
			bool flag = false;
			if (this._byteBuffer[0] == 254 && this._byteBuffer[1] == 255)
			{
				this._encoding = Encoding.BigEndianUnicode;
				this.CompressBuffer(2);
				flag = true;
			}
			else if (this._byteBuffer[0] == 255 && this._byteBuffer[1] == 254)
			{
				if (this._byteLen < 4 || this._byteBuffer[2] != 0 || this._byteBuffer[3] != 0)
				{
					this._encoding = Encoding.Unicode;
					this.CompressBuffer(2);
					flag = true;
				}
				else
				{
					this._encoding = Encoding.UTF32;
					this.CompressBuffer(4);
					flag = true;
				}
			}
			else if (this._byteLen >= 3 && this._byteBuffer[0] == 239 && this._byteBuffer[1] == 187 && this._byteBuffer[2] == 191)
			{
				this._encoding = Encoding.UTF8;
				this.CompressBuffer(3);
				flag = true;
			}
			else if (this._byteLen >= 4 && this._byteBuffer[0] == 0 && this._byteBuffer[1] == 0 && this._byteBuffer[2] == 254 && this._byteBuffer[3] == 255)
			{
				this._encoding = new UTF32Encoding(true, true);
				this.CompressBuffer(4);
				flag = true;
			}
			else if (this._byteLen == 2)
			{
				this._detectEncoding = true;
			}
			if (flag)
			{
				this._decoder = this._encoding.GetDecoder();
				int maxCharCount = this._encoding.GetMaxCharCount(this._byteBuffer.Length);
				if (maxCharCount > this._maxCharsPerBuffer)
				{
					this._charBuffer = new char[maxCharCount];
				}
				this._maxCharsPerBuffer = maxCharCount;
			}
		}

		// Token: 0x06006558 RID: 25944 RVA: 0x00158EFC File Offset: 0x001570FC
		private unsafe bool IsPreamble()
		{
			if (!this._checkPreamble)
			{
				return this._checkPreamble;
			}
			ReadOnlySpan<byte> preamble = this._encoding.Preamble;
			int num = (this._byteLen >= preamble.Length) ? (preamble.Length - this._bytePos) : (this._byteLen - this._bytePos);
			int i = 0;
			while (i < num)
			{
				if (this._byteBuffer[this._bytePos] != *preamble[this._bytePos])
				{
					this._bytePos = 0;
					this._checkPreamble = false;
					break;
				}
				i++;
				this._bytePos++;
			}
			if (this._checkPreamble && this._bytePos == preamble.Length)
			{
				this.CompressBuffer(preamble.Length);
				this._bytePos = 0;
				this._checkPreamble = false;
				this._detectEncoding = false;
			}
			return this._checkPreamble;
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x00158FD8 File Offset: 0x001571D8
		internal virtual int ReadBuffer()
		{
			this._charLen = 0;
			this._charPos = 0;
			if (!this._checkPreamble)
			{
				this._byteLen = 0;
			}
			for (;;)
			{
				if (this._checkPreamble)
				{
					int num = this._stream.Read(this._byteBuffer, this._bytePos, this._byteBuffer.Length - this._bytePos);
					if (num == 0)
					{
						break;
					}
					this._byteLen += num;
				}
				else
				{
					this._byteLen = this._stream.Read(this._byteBuffer, 0, this._byteBuffer.Length);
					if (this._byteLen == 0)
					{
						goto Block_5;
					}
				}
				this._isBlocked = (this._byteLen < this._byteBuffer.Length);
				if (!this.IsPreamble())
				{
					if (this._detectEncoding && this._byteLen >= 2)
					{
						this.DetectEncoding();
					}
					this._charLen += this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, this._charLen);
				}
				if (this._charLen != 0)
				{
					goto Block_9;
				}
			}
			if (this._byteLen > 0)
			{
				this._charLen += this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, this._charLen);
				this._bytePos = (this._byteLen = 0);
			}
			return this._charLen;
			Block_5:
			return this._charLen;
			Block_9:
			return this._charLen;
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x00159140 File Offset: 0x00157340
		private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer)
		{
			this._charLen = 0;
			this._charPos = 0;
			if (!this._checkPreamble)
			{
				this._byteLen = 0;
			}
			int num = 0;
			readToUserBuffer = (userBuffer.Length >= this._maxCharsPerBuffer);
			for (;;)
			{
				if (this._checkPreamble)
				{
					int num2 = this._stream.Read(this._byteBuffer, this._bytePos, this._byteBuffer.Length - this._bytePos);
					if (num2 == 0)
					{
						break;
					}
					this._byteLen += num2;
				}
				else
				{
					this._byteLen = this._stream.Read(this._byteBuffer, 0, this._byteBuffer.Length);
					if (this._byteLen == 0)
					{
						goto IL_1CD;
					}
				}
				this._isBlocked = (this._byteLen < this._byteBuffer.Length);
				if (!this.IsPreamble())
				{
					if (this._detectEncoding && this._byteLen >= 2)
					{
						this.DetectEncoding();
						readToUserBuffer = (userBuffer.Length >= this._maxCharsPerBuffer);
					}
					this._charPos = 0;
					if (readToUserBuffer)
					{
						num += this._decoder.GetChars(new ReadOnlySpan<byte>(this._byteBuffer, 0, this._byteLen), userBuffer.Slice(num), false);
						this._charLen = 0;
					}
					else
					{
						num = this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, num);
						this._charLen += num;
					}
				}
				if (num != 0)
				{
					goto IL_1CD;
				}
			}
			if (this._byteLen > 0)
			{
				if (readToUserBuffer)
				{
					num = this._decoder.GetChars(new ReadOnlySpan<byte>(this._byteBuffer, 0, this._byteLen), userBuffer.Slice(num), false);
					this._charLen = 0;
				}
				else
				{
					num = this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, num);
					this._charLen += num;
				}
			}
			return num;
			IL_1CD:
			this._isBlocked &= (num < userBuffer.Length);
			return num;
		}

		/// <summary>Выполняет чтение строки символов из текущего потока и возвращает данные в виде строки.</summary>
		/// <returns>Следующая строка из входного потока или значение <see langword="null" />, если достигнут конец входного потока.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти для выделения буфера под возвращаемую строку.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600655B RID: 25947 RVA: 0x00159334 File Offset: 0x00157534
		public override string ReadLine()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && this.ReadBuffer() == 0)
			{
				return null;
			}
			StringBuilder stringBuilder = null;
			int num;
			char c;
			for (;;)
			{
				num = this._charPos;
				do
				{
					c = this._charBuffer[num];
					if (c == '\r' || c == '\n')
					{
						goto IL_51;
					}
					num++;
				}
				while (num < this._charLen);
				num = this._charLen - this._charPos;
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(num + 80);
				}
				stringBuilder.Append(this._charBuffer, this._charPos, num);
				if (this.ReadBuffer() <= 0)
				{
					goto Block_11;
				}
			}
			IL_51:
			string result;
			if (stringBuilder != null)
			{
				stringBuilder.Append(this._charBuffer, this._charPos, num - this._charPos);
				result = stringBuilder.ToString();
			}
			else
			{
				result = new string(this._charBuffer, this._charPos, num - this._charPos);
			}
			this._charPos = num + 1;
			if (c == '\r' && (this._charPos < this._charLen || this.ReadBuffer() > 0) && this._charBuffer[this._charPos] == '\n')
			{
				this._charPos++;
			}
			return result;
			Block_11:
			return stringBuilder.ToString();
		}

		/// <summary>Асинхронно выполняет чтение строки символов из текущего потока и возвращает данные в виде строки.</summary>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит следующую строку из потока или значение <see langword="null" />, если все знаки прочитаны.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов в следующей строке больше <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x0600655C RID: 25948 RVA: 0x0015946C File Offset: 0x0015766C
		public override Task<string> ReadLineAsync()
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadLineAsync();
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			Task<string> task = this.ReadLineAsyncInternal();
			this._asyncReadTask = task;
			return task;
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x001594C0 File Offset: 0x001576C0
		private Task<string> ReadLineAsyncInternal()
		{
			StreamReader.<ReadLineAsyncInternal>d__61 <ReadLineAsyncInternal>d__;
			<ReadLineAsyncInternal>d__.<>4__this = this;
			<ReadLineAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadLineAsyncInternal>d__.<>1__state = -1;
			<ReadLineAsyncInternal>d__.<>t__builder.Start<StreamReader.<ReadLineAsyncInternal>d__61>(ref <ReadLineAsyncInternal>d__);
			return <ReadLineAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Асинхронно считывает все символы, начиная с текущей позиции до конца потока, и возвращает их в виде одной строки.</summary>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит строку с символами от текущего положения до конца потока.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов больше <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x0600655E RID: 25950 RVA: 0x00159504 File Offset: 0x00157704
		public override Task<string> ReadToEndAsync()
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadToEndAsync();
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			Task<string> task = this.ReadToEndAsyncInternal();
			this._asyncReadTask = task;
			return task;
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x00159558 File Offset: 0x00157758
		private Task<string> ReadToEndAsyncInternal()
		{
			StreamReader.<ReadToEndAsyncInternal>d__63 <ReadToEndAsyncInternal>d__;
			<ReadToEndAsyncInternal>d__.<>4__this = this;
			<ReadToEndAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadToEndAsyncInternal>d__.<>1__state = -1;
			<ReadToEndAsyncInternal>d__.<>t__builder.Start<StreamReader.<ReadToEndAsyncInternal>d__63>(ref <ReadToEndAsyncInternal>d__);
			return <ReadToEndAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Асинхронно считывает указанное максимальное количество символов из текущего потока и записывает данные в буфер, начиная с заданного индекса.</summary>
		/// <param name="buffer">При возвращении из этого метода содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> и (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов. Если конец потока достигнут, прежде чем указанное количество символов записывается в буфер, возвращается текущий метод.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число символов (в байтах), считанных в буфер. Результирующее значение может быть меньше запрошенного числа символов, если число доступных в данный момент символов меньше запрошенного числа, или результат может быть равен 0 (нулю), если достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x06006560 RID: 25952 RVA: 0x0015959C File Offset: 0x0015779C
		public override Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadAsync(buffer, index, count);
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			Task<int> task = this.ReadAsyncInternal(new Memory<char>(buffer, index, count), default(CancellationToken)).AsTask();
			this._asyncReadTask = task;
			return task;
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x00159658 File Offset: 0x00157858
		public override ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadAsync(buffer, cancellationToken);
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			return this.ReadAsyncInternal(buffer, cancellationToken);
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x001596BC File Offset: 0x001578BC
		internal override ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			StreamReader.<ReadAsyncInternal>d__66 <ReadAsyncInternal>d__;
			<ReadAsyncInternal>d__.<>4__this = this;
			<ReadAsyncInternal>d__.buffer = buffer;
			<ReadAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadAsyncInternal>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadAsyncInternal>d__.<>1__state = -1;
			<ReadAsyncInternal>d__.<>t__builder.Start<StreamReader.<ReadAsyncInternal>d__66>(ref <ReadAsyncInternal>d__);
			return <ReadAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Асинхронно считывает указанное максимальное количество символов из текущего потока и записывает данные в буфер, начиная с заданного индекса.</summary>
		/// <param name="buffer">При возвращении из этого метода содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> и (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов. Если конец потока достигнут, прежде чем в буфер записано указанное количество символов, метод возвращает управление.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число символов (в байтах), считанных в буфер. Результирующее значение может быть меньше запрошенного числа символов, если число доступных в данный момент символов меньше запрошенного числа, или результат может быть равен 0 (нулю), если достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x06006563 RID: 25955 RVA: 0x00159710 File Offset: 0x00157910
		public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadBlockAsync(buffer, index, count);
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			Task<int> task = base.ReadBlockAsync(buffer, index, count);
			this._asyncReadTask = task;
			return task;
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x001597B4 File Offset: 0x001579B4
		public override ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadBlockAsync(buffer, cancellationToken);
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			ValueTask<int> result = base.ReadBlockAsyncInternal(buffer, cancellationToken);
			if (result.IsCompletedSuccessfully)
			{
				return result;
			}
			Task<int> task = result.AsTask();
			this._asyncReadTask = task;
			return new ValueTask<int>(task);
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x0015983C File Offset: 0x00157A3C
		private Task<int> ReadBufferAsync()
		{
			StreamReader.<ReadBufferAsync>d__69 <ReadBufferAsync>d__;
			<ReadBufferAsync>d__.<>4__this = this;
			<ReadBufferAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ReadBufferAsync>d__.<>1__state = -1;
			<ReadBufferAsync>d__.<>t__builder.Start<StreamReader.<ReadBufferAsync>d__69>(ref <ReadBufferAsync>d__);
			return <ReadBufferAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x0015987F File Offset: 0x00157A7F
		internal bool DataAvailable()
		{
			return this._charPos < this._charLen;
		}

		/// <summary>Объект <see cref="T:System.IO.StreamReader" /> для пустого потока.</summary>
		// Token: 0x04003B6D RID: 15213
		public new static readonly StreamReader Null = new StreamReader.NullStreamReader();

		// Token: 0x04003B6E RID: 15214
		private const int DefaultBufferSize = 1024;

		// Token: 0x04003B6F RID: 15215
		private const int DefaultFileStreamBufferSize = 4096;

		// Token: 0x04003B70 RID: 15216
		private const int MinBufferSize = 128;

		// Token: 0x04003B71 RID: 15217
		private Stream _stream;

		// Token: 0x04003B72 RID: 15218
		private Encoding _encoding;

		// Token: 0x04003B73 RID: 15219
		private Decoder _decoder;

		// Token: 0x04003B74 RID: 15220
		private byte[] _byteBuffer;

		// Token: 0x04003B75 RID: 15221
		private char[] _charBuffer;

		// Token: 0x04003B76 RID: 15222
		private int _charPos;

		// Token: 0x04003B77 RID: 15223
		private int _charLen;

		// Token: 0x04003B78 RID: 15224
		private int _byteLen;

		// Token: 0x04003B79 RID: 15225
		private int _bytePos;

		// Token: 0x04003B7A RID: 15226
		private int _maxCharsPerBuffer;

		// Token: 0x04003B7B RID: 15227
		private bool _detectEncoding;

		// Token: 0x04003B7C RID: 15228
		private bool _checkPreamble;

		// Token: 0x04003B7D RID: 15229
		private bool _isBlocked;

		// Token: 0x04003B7E RID: 15230
		private bool _closable;

		// Token: 0x04003B7F RID: 15231
		private Task _asyncReadTask = Task.CompletedTask;

		// Token: 0x02000B13 RID: 2835
		private class NullStreamReader : StreamReader
		{
			// Token: 0x06006568 RID: 25960 RVA: 0x0015989B File Offset: 0x00157A9B
			internal NullStreamReader()
			{
				base.Init(Stream.Null);
			}

			// Token: 0x170011BD RID: 4541
			// (get) Token: 0x06006569 RID: 25961 RVA: 0x001598AE File Offset: 0x00157AAE
			public override Stream BaseStream
			{
				get
				{
					return Stream.Null;
				}
			}

			// Token: 0x170011BE RID: 4542
			// (get) Token: 0x0600656A RID: 25962 RVA: 0x001598B5 File Offset: 0x00157AB5
			public override Encoding CurrentEncoding
			{
				get
				{
					return Encoding.Unicode;
				}
			}

			// Token: 0x0600656B RID: 25963 RVA: 0x00004BF9 File Offset: 0x00002DF9
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x0600656C RID: 25964 RVA: 0x00122772 File Offset: 0x00120972
			public override int Peek()
			{
				return -1;
			}

			// Token: 0x0600656D RID: 25965 RVA: 0x00122772 File Offset: 0x00120972
			public override int Read()
			{
				return -1;
			}

			// Token: 0x0600656E RID: 25966 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			// Token: 0x0600656F RID: 25967 RVA: 0x0000AF5E File Offset: 0x0000915E
			public override string ReadLine()
			{
				return null;
			}

			// Token: 0x06006570 RID: 25968 RVA: 0x000258DB File Offset: 0x00023ADB
			public override string ReadToEnd()
			{
				return string.Empty;
			}

			// Token: 0x06006571 RID: 25969 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			internal override int ReadBuffer()
			{
				return 0;
			}
		}
	}
}
