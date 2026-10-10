using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	/// <summary>Обеспечивает базовый поток данных для доступа к сети.</summary>
	// Token: 0x02000792 RID: 1938
	public class NetworkStream : Stream
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Sockets.NetworkStream" /> для указанного объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="socket">Объект <see cref="T:System.Net.Sockets.Socket" />, который будет использоваться <see cref="T:System.Net.Sockets.NetworkStream" /> для отправки и приема данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="socket" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Параметр <paramref name="socket" /> не используется.  
		/// -или- 
		/// Свойство <see cref="P:System.Net.Sockets.Socket.SocketType" /> параметра <paramref name="socket" /> не содержит значения <see cref="F:System.Net.Sockets.SocketType.Stream" />.  
		/// -или- 
		/// Параметр <paramref name="socket" /> находится в неблокирующем состоянии.</exception>
		// Token: 0x06003CF1 RID: 15601 RVA: 0x000CF654 File Offset: 0x000CD854
		public NetworkStream(Socket socket) : this(socket, FileAccess.ReadWrite, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.NetworkStream" /> для указанного объекта <see cref="T:System.Net.Sockets.Socket" /> с заданным правом на владение <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="socket">Объект <see cref="T:System.Net.Sockets.Socket" />, который будет использоваться <see cref="T:System.Net.Sockets.NetworkStream" /> для отправки и приема данных.</param>
		/// <param name="ownsSocket">Задайте значение <see langword="true" />, чтобы указать на то, что объект <see cref="T:System.Net.Sockets.NetworkStream" /> будет иметь право владения объектом <see cref="T:System.Net.Sockets.Socket" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="socket" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Параметр <paramref name="socket" /> не используется.  
		/// -или- 
		/// значение свойства <see cref="P:System.Net.Sockets.Socket.SocketType" /> параметра <paramref name="socket" /> не является значением <see cref="F:System.Net.Sockets.SocketType.Stream" />.  
		/// -или- 
		/// параметр <paramref name="socket" /> находится в неблокирующем состоянии.</exception>
		// Token: 0x06003CF2 RID: 15602 RVA: 0x000CF65F File Offset: 0x000CD85F
		public NetworkStream(Socket socket, bool ownsSocket) : this(socket, FileAccess.ReadWrite, ownsSocket)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Sockets.NetworkStream" /> для указанного объекта <see cref="T:System.Net.Sockets.Socket" /> с заданными правами на доступ.</summary>
		/// <param name="socket">Объект <see cref="T:System.Net.Sockets.Socket" />, который будет использоваться <see cref="T:System.Net.Sockets.NetworkStream" /> для отправки и приема данных.</param>
		/// <param name="access">Комбинация битов значений <see cref="T:System.IO.FileAccess" />, указывающих тот тип доступа, который дан объекту <see cref="T:System.Net.Sockets.NetworkStream" /> с использованием предоставленного объекта <see cref="T:System.Net.Sockets.Socket" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="socket" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Параметр <paramref name="socket" /> не используется.  
		/// -или- 
		/// свойство <see cref="P:System.Net.Sockets.Socket.SocketType" /> параметра <paramref name="socket" /> не содержит значения <see cref="F:System.Net.Sockets.SocketType.Stream" />.  
		/// -или- 
		/// параметр <paramref name="socket" /> находится в неблокирующем состоянии.</exception>
		// Token: 0x06003CF3 RID: 15603 RVA: 0x000CF66A File Offset: 0x000CD86A
		public NetworkStream(Socket socket, FileAccess access) : this(socket, access, false)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Sockets.NetworkStream" /> для указанного объекта <see cref="T:System.Net.Sockets.Socket" /> с заданными правами доступа и указанными правами владения объектом <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="socket">Объект <see cref="T:System.Net.Sockets.Socket" />, который будет использоваться <see cref="T:System.Net.Sockets.NetworkStream" /> для отправки и приема данных.</param>
		/// <param name="access">Комбинация битов значений <see cref="T:System.IO.FileAccess" />, указывающая тот тип доступа, который дан объекту <see cref="T:System.Net.Sockets.NetworkStream" /> с использованием предоставленного объекта <see cref="T:System.Net.Sockets.Socket" />.</param>
		/// <param name="ownsSocket">Задайте значение <see langword="true" />, чтобы указать на то, что объект <see cref="T:System.Net.Sockets.NetworkStream" /> будет иметь право владения объектом <see cref="T:System.Net.Sockets.Socket" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="socket" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Параметр <paramref name="socket" /> не используется.  
		/// -или- 
		/// Свойство <see cref="P:System.Net.Sockets.Socket.SocketType" /> параметра <paramref name="socket" /> не содержит значения <see cref="F:System.Net.Sockets.SocketType.Stream" />.  
		/// -или- 
		/// Параметр <paramref name="socket" /> находится в неблокирующем состоянии.</exception>
		// Token: 0x06003CF4 RID: 15604 RVA: 0x000CF678 File Offset: 0x000CD878
		public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
		{
			if (socket == null)
			{
				throw new ArgumentNullException("socket");
			}
			if (!socket.Blocking)
			{
				throw new IOException("The operation is not allowed on a non-blocking Socket.");
			}
			if (!socket.Connected)
			{
				throw new IOException("The operation is not allowed on non-connected sockets.");
			}
			if (socket.SocketType != SocketType.Stream)
			{
				throw new IOException("The operation is not allowed on non-stream oriented sockets.");
			}
			this._streamSocket = socket;
			this._ownsSocket = ownsSocket;
			switch (access)
			{
			case FileAccess.Read:
				this._readable = true;
				return;
			case FileAccess.Write:
				this._writeable = true;
				return;
			}
			this._readable = true;
			this._writeable = true;
		}

		/// <summary>Возвращает основной объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.Socket" />, который представляет основное сетевое подключение.</returns>
		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x000CF72A File Offset: 0x000CD92A
		protected Socket Socket
		{
			get
			{
				return this._streamSocket;
			}
		}

		/// <summary>Получает или устанавливает значение, указывающее, может ли выполняться чтение из объекта <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <returns>Значение <see langword="true" />, указывающее на то, что может выполняться чтение из объекта <see cref="T:System.Net.Sockets.NetworkStream" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x000CF732 File Offset: 0x000CD932
		// (set) Token: 0x06003CF7 RID: 15607 RVA: 0x000CF73A File Offset: 0x000CD93A
		protected bool Readable
		{
			get
			{
				return this._readable;
			}
			set
			{
				this._readable = value;
			}
		}

		/// <summary>Получает значение, указывающее, предусмотрена ли запись в объект <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <returns>Значение <see langword="true" />, если данные могут быть записаны в поток; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x000CF743 File Offset: 0x000CD943
		// (set) Token: 0x06003CF9 RID: 15609 RVA: 0x000CF74B File Offset: 0x000CD94B
		protected bool Writeable
		{
			get
			{
				return this._writeable;
			}
			set
			{
				this._writeable = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, поддерживает ли объект <see cref="T:System.Net.Sockets.NetworkStream" /> чтение.</summary>
		/// <returns>Значение <see langword="true" />, если данные могут быть прочитаны из потока; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06003CFA RID: 15610 RVA: 0x000CF732 File Offset: 0x000CD932
		public override bool CanRead
		{
			get
			{
				return this._readable;
			}
		}

		/// <summary>Получает значение, указывающее, поддерживает ли поток поиск. Это свойство в настоящее время не поддерживается и всегда возвращает значение <see langword="false" />.</summary>
		/// <returns>Значение <see langword="false" /> всегда указывает на то, что объект <see cref="T:System.Net.Sockets.NetworkStream" /> не может выполнять поиск определенного местоположения в потоке.</returns>
		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06003CFB RID: 15611 RVA: 0x00003062 File Offset: 0x00001262
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, поддерживает ли объект <see cref="T:System.Net.Sockets.NetworkStream" /> запись.</summary>
		/// <returns>Значение <see langword="true" />, если данные могут быть записаны в объект <see cref="T:System.Net.Sockets.NetworkStream" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06003CFC RID: 15612 RVA: 0x000CF743 File Offset: 0x000CD943
		public override bool CanWrite
		{
			get
			{
				return this._writeable;
			}
		}

		/// <summary>Указывает, применимы ли для объекта <see cref="T:System.Net.Sockets.NetworkStream" /> свойства тайм-аута.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06003CFD RID: 15613 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool CanTimeout
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает или задает время, в течение которого операция чтения блокирует ожидание данных.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, указывающий период времени (в миллисекундах), по истечении которого происходит сбой операции чтения. По умолчанию установлен флаг <see cref="F:System.Threading.Timeout.Infinite" />, указывающий, что время операции чтения не ограничено.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение меньше или равно нулю, и флаг <see cref="F:System.Threading.Timeout.Infinite" /> не установлен.</exception>
		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x000CF754 File Offset: 0x000CD954
		// (set) Token: 0x06003CFF RID: 15615 RVA: 0x000CF782 File Offset: 0x000CD982
		public override int ReadTimeout
		{
			get
			{
				int num = (int)this._streamSocket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
				if (num == 0)
				{
					return -1;
				}
				return num;
			}
			set
			{
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value > 0.");
				}
				this.SetSocketTimeoutOption(SocketShutdown.Receive, value, false);
			}
		}

		/// <summary>Возвращает или задает время, в течение которого операция записи блокирует ожидание данных.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, указывающий период времени (в миллисекундах), по истечении которого происходит сбой операции записи. По умолчанию установлен флаг <see cref="F:System.Threading.Timeout.Infinite" />, указывающий, что время операции записи не ограничено.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение меньше или равно нулю, и флаг <see cref="F:System.Threading.Timeout.Infinite" /> не установлен.</exception>
		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06003D00 RID: 15616 RVA: 0x000CF7A8 File Offset: 0x000CD9A8
		// (set) Token: 0x06003D01 RID: 15617 RVA: 0x000CF7D6 File Offset: 0x000CD9D6
		public override int WriteTimeout
		{
			get
			{
				int num = (int)this._streamSocket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
				if (num == 0)
				{
					return -1;
				}
				return num;
			}
			set
			{
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value > 0.");
				}
				this.SetSocketTimeoutOption(SocketShutdown.Send, value, false);
			}
		}

		/// <summary>Возвращает значение, указывающее, имеются ли в объекте <see cref="T:System.Net.Sockets.NetworkStream" /> данные, доступные для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если содержащиеся в потоке данные могут быть прочитаны; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.NetworkStream" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Используйте свойство <see cref="P:System.Net.Sockets.SocketException.ErrorCode" /> для получения конкретного кода ошибки и обратитесь за подробным описанием ошибки к документации Коды ошибок API для сокетов Windows версии 2.</exception>
		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06003D02 RID: 15618 RVA: 0x000CF7F9 File Offset: 0x000CD9F9
		public virtual bool DataAvailable
		{
			get
			{
				if (this._cleanedUp)
				{
					throw new ObjectDisposedException(base.GetType().FullName);
				}
				return this._streamSocket.Available != 0;
			}
		}

		/// <summary>Получает длину данных, доступных в потоке. Это свойство в настоящее время не поддерживается, и обращение к нему всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Длина данных, доступных в потоке.</returns>
		/// <exception cref="T:System.NotSupportedException">При любом использовании этого свойства.</exception>
		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x000C3C76 File Offset: 0x000C1E76
		public override long Length
		{
			get
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
		}

		/// <summary>Возвращает или задает текущую позицию в потоке. Это свойство в настоящее время не поддерживается, и обращение к нему всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Текущая позиция в потоке.</returns>
		/// <exception cref="T:System.NotSupportedException">При любом использовании этого свойства.</exception>
		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x000C3C76 File Offset: 0x000C1E76
		// (set) Token: 0x06003D05 RID: 15621 RVA: 0x000C3C76 File Offset: 0x000C1E76
		public override long Position
		{
			get
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
			set
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
		}

		/// <summary>Устанавливает заданное значение для текущей позиции потока. Этот метод в настоящее время не поддерживается, и он всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">Этот параметр не используется.</param>
		/// <param name="origin">Этот параметр не используется.</param>
		/// <returns>Позиция в потоке.</returns>
		/// <exception cref="T:System.NotSupportedException">При любом использовании этого свойства.</exception>
		// Token: 0x06003D06 RID: 15622 RVA: 0x000C3C76 File Offset: 0x000C1E76
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("This stream does not support seek operations.");
		}

		/// <summary>Читает данные из объекта <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением в памяти для хранения данных, прочитанных из <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
		/// <param name="offset">Местоположение в объекте <paramref name="buffer" />, начиная с которого записываются сохраняемые данные.</param>
		/// <param name="size">Число байтов, читаемых из объекта <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
		/// <returns>Количество считанных байтов из <see cref="T:System.Net.Sockets.NetworkStream" />, или 0, если сокет закрыт.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="offset" />  больше длины значения, указанного в параметре <paramref name="buffer" />.  
		/// -или- 
		/// Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="size" /> больше разности значений длины в параметре <paramref name="buffer" /> и значения параметра <paramref name="offset" />.  
		/// -или- 
		/// Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.IO.IOException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.NetworkStream" /> закрыт.  
		/// -или- 
		/// Произошел отказ в процессе чтения из сети.</exception>
		// Token: 0x06003D07 RID: 15623 RVA: 0x000CF824 File Offset: 0x000CDA24
		public override int Read(byte[] buffer, int offset, int size)
		{
			bool canRead = this.CanRead;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			int result;
			try
			{
				result = this._streamSocket.Receive(buffer, offset, size, SocketFlags.None);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x000CF8F0 File Offset: 0x000CDAF0
		public override int Read(Span<byte> destination)
		{
			if (base.GetType() != typeof(NetworkStream))
			{
				return base.Read(destination);
			}
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.CanRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			SocketError socketError;
			int result = this._streamSocket.Receive(destination, SocketFlags.None, out socketError);
			if (socketError != SocketError.Success)
			{
				SocketException ex = new SocketException((int)socketError);
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x000CF97C File Offset: 0x000CDB7C
		public unsafe override int ReadByte()
		{
			byte result;
			if (this.Read(new Span<byte>((void*)(&result), 1)) != 0)
			{
				return (int)result;
			}
			return -1;
		}

		/// <summary>Записывает данные в объект <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для записи в объект <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
		/// <param name="offset">Место в буфере <paramref name="buffer" />, начиная с которого записываются данные.</param>
		/// <param name="size">Число байтов для записи в объект <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="offset" />  больше длины значения, указанного в параметре <paramref name="buffer" />.  
		/// -или- 
		/// Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="size" /> больше разности значений длины в параметре <paramref name="buffer" /> и значения параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошел сбой в процессе записи в сеть.  
		/// -или- 
		/// Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.NetworkStream" /> закрыт.  
		/// -или- 
		/// Произошел отказ в процессе чтения из сети.</exception>
		// Token: 0x06003D0A RID: 15626 RVA: 0x000CF9A0 File Offset: 0x000CDBA0
		public override void Write(byte[] buffer, int offset, int size)
		{
			bool canWrite = this.CanWrite;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			try
			{
				this._streamSocket.Send(buffer, offset, size, SocketFlags.None);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x000CFA6C File Offset: 0x000CDC6C
		public override void Write(ReadOnlySpan<byte> source)
		{
			if (base.GetType() != typeof(NetworkStream))
			{
				base.Write(source);
				return;
			}
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.CanWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			SocketError socketError;
			this._streamSocket.Send(source, SocketFlags.None, out socketError);
			if (socketError != SocketError.Success)
			{
				SocketException ex = new SocketException((int)socketError);
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x000CFAF7 File Offset: 0x000CDCF7
		public unsafe override void WriteByte(byte value)
		{
			this.Write(new ReadOnlySpan<byte>((void*)(&value), 1));
		}

		/// <summary>Закрывает объект <see cref="T:System.Net.Sockets.NetworkStream" /> после ожидания в течение указанного времени, позволяя выполнить отправку данных.</summary>
		/// <param name="timeout">32-битное целое число со знаком, определяющее количество миллисекунд ожидания для отправки оставшихся данных перед закрытием.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="timeout" /> меньше –1.</exception>
		// Token: 0x06003D0D RID: 15629 RVA: 0x000CFB08 File Offset: 0x000CDD08
		public void Close(int timeout)
		{
			if (timeout < -1)
			{
				throw new ArgumentOutOfRangeException("timeout");
			}
			this._closeTimeout = timeout;
			base.Dispose();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Sockets.NetworkStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x06003D0E RID: 15630 RVA: 0x000CFB28 File Offset: 0x000CDD28
		protected override void Dispose(bool disposing)
		{
			int cleanedUp = this._cleanedUp ? 1 : 0;
			this._cleanedUp = true;
			if (cleanedUp == 0 && disposing)
			{
				this._readable = false;
				this._writeable = false;
				if (this._ownsSocket)
				{
					this._streamSocket.InternalShutdown(SocketShutdown.Both);
					this._streamSocket.Close(this._closeTimeout);
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		// Token: 0x06003D0F RID: 15631 RVA: 0x000CFB88 File Offset: 0x000CDD88
		~NetworkStream()
		{
			this.Dispose(false);
		}

		/// <summary>Начинает асинхронное чтение из объекта <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, который является местоположением в памяти для хранения данных, прочитанных из <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
		/// <param name="offset">Местоположение в объекте <paramref name="buffer" />, начиная с которого записываются сохраняемые данные.</param>
		/// <param name="size">Число байтов, читаемых из объекта <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, который выполняется после выполнения метода <see cref="M:System.Net.Sockets.NetworkStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</param>
		/// <param name="state">Объект, содержащий любые дополнительные данные, определенные пользователем.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который представляет асинхронный вызов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="offset" />  больше длины значения, указанного в параметре <paramref name="buffer" />.  
		/// -или- 
		/// Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="size" /> больше разности значений длины в параметре <paramref name="buffer" /> и значения параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.IO.IOException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.  
		/// -или- 
		/// Произошел сбой в процессе чтения из сети.  
		/// -или- 
		/// Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.NetworkStream" /> закрыт.</exception>
		// Token: 0x06003D10 RID: 15632 RVA: 0x000CFBB8 File Offset: 0x000CDDB8
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			bool canRead = this.CanRead;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			IAsyncResult result;
			try
			{
				result = this._streamSocket.BeginReceive(buffer, offset, size, SocketFlags.None, callback, state);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		/// <summary>Обрабатывает завершение асинхронного чтения.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, который представляет асинхронный вызов.</param>
		/// <returns>Число байтов, читаемых из объекта <see cref="T:System.Net.Sockets.NetworkStream" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.  
		/// -или- 
		/// Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.NetworkStream" /> закрыт.</exception>
		// Token: 0x06003D11 RID: 15633 RVA: 0x000CFC88 File Offset: 0x000CDE88
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			int result;
			try
			{
				result = this._streamSocket.EndReceive(asyncResult);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		/// <summary>Начинает асинхронную запись в поток.</summary>
		/// <param name="buffer">Массив типа <see cref="T:System.Byte" />, содержащий данные для записи в объект <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
		/// <param name="offset">Местоположение в буфере <paramref name="buffer" />, начиная с которого отправляются данные.</param>
		/// <param name="size">Число байтов для записи в объект <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, который выполняется после выполнения метода <see cref="M:System.Net.Sockets.NetworkStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</param>
		/// <param name="state">Объект, содержащий любые дополнительные данные, определенные пользователем.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который представляет асинхронный вызов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="offset" />  больше длины значения, указанного в параметре <paramref name="buffer" />.  
		/// -или- 
		/// Значение параметра <paramref name="size" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="size" /> больше разности значений длины в параметре <paramref name="buffer" /> и значения параметра <paramref name="offset" />.</exception>
		/// <exception cref="T:System.IO.IOException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.  
		/// -или- 
		/// Произошел сбой в процессе записи в сеть.  
		/// -или- 
		/// Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.NetworkStream" /> закрыт.</exception>
		// Token: 0x06003D12 RID: 15634 RVA: 0x000CFD18 File Offset: 0x000CDF18
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			bool canWrite = this.CanWrite;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			IAsyncResult result;
			try
			{
				result = this._streamSocket.BeginSend(buffer, offset, size, SocketFlags.None, callback, state);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		/// <summary>Обрабатывает завершение асинхронной записи.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, который представляет асинхронный вызов.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.  
		/// -или- 
		/// Произошла ошибка в процессе записи в сеть.  
		/// -или- 
		/// Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.NetworkStream" /> закрыт.</exception>
		// Token: 0x06003D13 RID: 15635 RVA: 0x000CFDE8 File Offset: 0x000CDFE8
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			try
			{
				this._streamSocket.EndSend(asyncResult);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x000CFE74 File Offset: 0x000CE074
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			bool canRead = this.CanRead;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			Task<int> result;
			try
			{
				result = this._streamSocket.ReceiveAsync(new Memory<byte>(buffer, offset, size), SocketFlags.None, true, cancellationToken).AsTask();
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x000CFF50 File Offset: 0x000CE150
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			bool canRead = this.CanRead;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			ValueTask<int> result;
			try
			{
				result = this._streamSocket.ReceiveAsync(buffer, SocketFlags.None, true, cancellationToken);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x000CFFE8 File Offset: 0x000CE1E8
		public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			bool canWrite = this.CanWrite;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			Task result;
			try
			{
				result = this._streamSocket.SendAsyncForNetworkStream(new ReadOnlyMemory<byte>(buffer, offset, size), SocketFlags.None, cancellationToken).AsTask();
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x000D00C4 File Offset: 0x000CE2C4
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			bool canWrite = this.CanWrite;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			ValueTask result;
			try
			{
				result = this._streamSocket.SendAsyncForNetworkStream(buffer, SocketFlags.None, cancellationToken);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		/// <summary>Удаляет данные из потока. Этот метод зарезервирован для использования в будущем.</summary>
		// Token: 0x06003D18 RID: 15640 RVA: 0x00003917 File Offset: 0x00001B17
		public override void Flush()
		{
		}

		/// <summary>Удаляет данные из потока в качестве асинхронной операции.</summary>
		/// <param name="cancellationToken">Токен отмены, используемый для распространения уведомления о том, что эта операция должна быть отменена.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06003D19 RID: 15641 RVA: 0x0008EB07 File Offset: 0x0008CD07
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}

		/// <summary>Задает длину потока. Этот метод всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">Этот параметр не используется.</param>
		/// <exception cref="T:System.NotSupportedException">При любом использовании этого свойства.</exception>
		// Token: 0x06003D1A RID: 15642 RVA: 0x000C3C76 File Offset: 0x000C1E76
		public override void SetLength(long value)
		{
			throw new NotSupportedException("This stream does not support seek operations.");
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x000D0158 File Offset: 0x000CE358
		internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, mode, timeout, silent, "SetSocketTimeoutOption");
			}
			if (timeout < 0)
			{
				timeout = 0;
			}
			if ((mode == SocketShutdown.Send || mode == SocketShutdown.Both) && timeout != this._currentWriteTimeout)
			{
				this._streamSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, timeout, silent);
				this._currentWriteTimeout = timeout;
			}
			if ((mode == SocketShutdown.Receive || mode == SocketShutdown.Both) && timeout != this._currentReadTimeout)
			{
				this._streamSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, timeout, silent);
				this._currentReadTimeout = timeout;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06003D1C RID: 15644 RVA: 0x000D01F0 File Offset: 0x000CE3F0
		internal Socket InternalSocket
		{
			get
			{
				Socket streamSocket = this._streamSocket;
				if (this._cleanedUp || streamSocket == null)
				{
					throw new ObjectDisposedException(base.GetType().FullName);
				}
				return streamSocket;
			}
		}

		// Token: 0x0400241B RID: 9243
		private readonly Socket _streamSocket;

		// Token: 0x0400241C RID: 9244
		private readonly bool _ownsSocket;

		// Token: 0x0400241D RID: 9245
		private bool _readable;

		// Token: 0x0400241E RID: 9246
		private bool _writeable;

		// Token: 0x0400241F RID: 9247
		private int _closeTimeout = -1;

		// Token: 0x04002420 RID: 9248
		private volatile bool _cleanedUp;

		// Token: 0x04002421 RID: 9249
		private int _currentReadTimeout = -1;

		// Token: 0x04002422 RID: 9250
		private int _currentWriteTimeout = -1;
	}
}
