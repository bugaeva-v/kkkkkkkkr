using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Unity;

namespace System.Net.Sockets
{
	/// <summary>Представляет асинхронную операцию сокета.</summary>
	// Token: 0x020007C1 RID: 1985
	public class SocketAsyncEventArgs : EventArgs, IDisposable
	{
		/// <summary>Получает исключение в случае сбоя соединения при использовании <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <returns>Объект <see cref="T:System.Exception" />, указывающий причину ошибки соединения, если значение <see cref="T:System.Net.DnsEndPoint" /> было задано для свойства <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" />.</returns>
		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x000D8A4F File Offset: 0x000D6C4F
		// (set) Token: 0x06003F5D RID: 16221 RVA: 0x000D8A57 File Offset: 0x000D6C57
		public Exception ConnectByNameError { get; private set; }

		/// <summary>Возвращает или задает сокет для применения или сокет, созданный для принятия запроса на подключения, с помощью асинхронного метода сокета.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.Socket" /> для применения (сокет, созданный для принятия запроса на подключения с помощью асинхронного метода сокета).</returns>
		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06003F5E RID: 16222 RVA: 0x000D8A60 File Offset: 0x000D6C60
		// (set) Token: 0x06003F5F RID: 16223 RVA: 0x000D8A68 File Offset: 0x000D6C68
		public Socket AcceptSocket { get; set; }

		/// <summary>Получает количество байтов, переданных в операции сокета.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, содержащий количество байтов, переданных в операции сокета.</returns>
		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06003F60 RID: 16224 RVA: 0x000D8A71 File Offset: 0x000D6C71
		// (set) Token: 0x06003F61 RID: 16225 RVA: 0x000D8A79 File Offset: 0x000D6C79
		public int BytesTransferred { get; private set; }

		/// <summary>Возвращает или задает значение, указывающее, может ли сокет быть повторно использован после операции отключения.</summary>
		/// <returns>Объект <see cref="T:System.Boolean" />, указывающий, может ли сокет быть повторно использован после операции отключения.</returns>
		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x000D8A82 File Offset: 0x000D6C82
		// (set) Token: 0x06003F63 RID: 16227 RVA: 0x000D8A8A File Offset: 0x000D6C8A
		public bool DisconnectReuseSocket { get; set; }

		/// <summary>Получает тип операции сокета, которая была выполнена последней с этим объектом контекста.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Net.Sockets.SocketAsyncOperation" />, указывающий тип операции сокета, которая была выполнена последней с этим объектом контекста.</returns>
		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06003F64 RID: 16228 RVA: 0x000D8A93 File Offset: 0x000D6C93
		// (set) Token: 0x06003F65 RID: 16229 RVA: 0x000D8A9B File Offset: 0x000D6C9B
		public SocketAsyncOperation LastOperation { get; private set; }

		/// <summary>Возвращает или задает удаленную конечную точка IP для асинхронной операции.</summary>
		/// <returns>Объект <see cref="T:System.Net.EndPoint" />, представляющий удаленную конечную точка IP для асинхронной операции.</returns>
		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x000D8AA4 File Offset: 0x000D6CA4
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x000D8AAC File Offset: 0x000D6CAC
		public EndPoint RemoteEndPoint
		{
			get
			{
				return this.remote_ep;
			}
			set
			{
				this.remote_ep = value;
			}
		}

		/// <summary>Получает IP-адрес и интерфейс получаемого пакета.</summary>
		/// <returns>Экземпляр <see cref="T:System.Net.Sockets.IPPacketInformation" />, содержащий IP-адрес и интерфейс полученного пакета.</returns>
		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x000D8AB5 File Offset: 0x000D6CB5
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x000D8ABD File Offset: 0x000D6CBD
		public IPPacketInformation ReceiveMessageFromPacketInfo { get; private set; }

		/// <summary>Возвращает или задает массив буферов для отправки для асинхронной операции, используемой методом <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Net.Sockets.SendPacketsElement" />, которые представляют массив буферов для отправки.</returns>
		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x000D8AC6 File Offset: 0x000D6CC6
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x000D8ACE File Offset: 0x000D6CCE
		public SendPacketsElement[] SendPacketsElements { get; set; }

		/// <summary>Возвращает или задает битовую комбинацию значений <see cref="T:System.Net.Sockets.TransmitFileOptions" /> для асинхронной операции, используемой методом <see cref="M:System.Net.Sockets.Socket.SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)" />.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.TransmitFileOptions" />, содержащий битовую комбинацию значений, используемых асинхронной операцией.</returns>
		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x000D8AD7 File Offset: 0x000D6CD7
		// (set) Token: 0x06003F6D RID: 16237 RVA: 0x000D8ADF File Offset: 0x000D6CDF
		public TransmitFileOptions SendPacketsFlags { get; set; }

		/// <summary>Возвращает или задает размер (в байтах) блока данных, используемый в операции отправки.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, содержащий размер (в байтах) блока данных, используемый в операции отправки.</returns>
		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06003F6E RID: 16238 RVA: 0x000D8AE8 File Offset: 0x000D6CE8
		// (set) Token: 0x06003F6F RID: 16239 RVA: 0x000D8AF0 File Offset: 0x000D6CF0
		[MonoTODO("unused property")]
		public int SendPacketsSendSize { get; set; }

		/// <summary>Возвращает или задает результат асинхронной операции сокета.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.SocketError" />, представляющий результат асинхронной операции сокета.</returns>
		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x000D8AF9 File Offset: 0x000D6CF9
		// (set) Token: 0x06003F71 RID: 16241 RVA: 0x000D8B01 File Offset: 0x000D6D01
		public SocketError SocketError { get; set; }

		/// <summary>Получает результат асинхронной операции сокета или задает поведение асинхронной операции.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.SocketFlags" />, представляющий результат асинхронной операции сокета.</returns>
		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003F72 RID: 16242 RVA: 0x000D8B0A File Offset: 0x000D6D0A
		// (set) Token: 0x06003F73 RID: 16243 RVA: 0x000D8B12 File Offset: 0x000D6D12
		public SocketFlags SocketFlags { get; set; }

		/// <summary>Возвращает или задает объект пользователя или приложения, связанный с данной асинхронной операцией сокета.</summary>
		/// <returns>Объект, который представляет объект пользователя или приложения, связанный с данной асинхронной операцией сокета.</returns>
		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x000D8B1B File Offset: 0x000D6D1B
		// (set) Token: 0x06003F75 RID: 16245 RVA: 0x000D8B23 File Offset: 0x000D6D23
		public object UserToken { get; set; }

		/// <summary>Созданный и подключенный объект <see cref="T:System.Net.Sockets.Socket" /> после успешного выполнения метода <see cref="Overload:System.Net.Sockets.Socket.ConnectAsync" />.</summary>
		/// <returns>Подключенный объект <see cref="T:System.Net.Sockets.Socket" />.</returns>
		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06003F76 RID: 16246 RVA: 0x000D8B2C File Offset: 0x000D6D2C
		public Socket ConnectSocket
		{
			get
			{
				if (this.SocketError == SocketError.AccessDenied)
				{
					return null;
				}
				return this.current_socket;
			}
		}

		/// <summary>Событие, используемое для завершения асинхронной операции.</summary>
		// Token: 0x14000076 RID: 118
		// (add) Token: 0x06003F77 RID: 16247 RVA: 0x000D8B44 File Offset: 0x000D6D44
		// (remove) Token: 0x06003F78 RID: 16248 RVA: 0x000D8B7C File Offset: 0x000D6D7C
		public event EventHandler<SocketAsyncEventArgs> Completed;

		/// <summary>Создает пустой экземпляр <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Платформа не поддерживается.</exception>
		// Token: 0x06003F79 RID: 16249 RVA: 0x000D8BB1 File Offset: 0x000D6DB1
		public SocketAsyncEventArgs()
		{
			this.SendPacketsSendSize = -1;
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x000D8BCB File Offset: 0x000D6DCB
		internal SocketAsyncEventArgs(bool flowExecutionContext)
		{
		}

		/// <summary>Освобождает ресурсы, используемые классом <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />.</summary>
		// Token: 0x06003F7B RID: 16251 RVA: 0x000D8BE0 File Offset: 0x000D6DE0
		~SocketAsyncEventArgs()
		{
			this.Dispose(false);
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x000D8C10 File Offset: 0x000D6E10
		private void Dispose(bool disposing)
		{
			this.disposed = true;
			if (disposing)
			{
				int num = this.in_progress;
				return;
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые экземпляром класса <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" />, и при необходимости удаляет управляемые ресурсы.</summary>
		// Token: 0x06003F7D RID: 16253 RVA: 0x000D8C26 File Offset: 0x000D6E26
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x000D8C35 File Offset: 0x000D6E35
		internal void SetConnectByNameError(Exception error)
		{
			this.ConnectByNameError = error;
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x000D8C3E File Offset: 0x000D6E3E
		internal void SetBytesTransferred(int value)
		{
			this.BytesTransferred = value;
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06003F80 RID: 16256 RVA: 0x000D8C47 File Offset: 0x000D6E47
		internal Socket CurrentSocket
		{
			get
			{
				return this.current_socket;
			}
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x000D8C4F File Offset: 0x000D6E4F
		internal void SetCurrentSocket(Socket socket)
		{
			this.current_socket = socket;
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x000D8C58 File Offset: 0x000D6E58
		internal void SetLastOperation(SocketAsyncOperation op)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("System.Net.Sockets.SocketAsyncEventArgs");
			}
			if (Interlocked.Exchange(ref this.in_progress, 1) != 0)
			{
				throw new InvalidOperationException("Operation already in progress");
			}
			this.LastOperation = op;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x000D8C8D File Offset: 0x000D6E8D
		internal void Complete_internal()
		{
			this.in_progress = 0;
			this.OnCompleted(this);
		}

		/// <summary>Представляет метод, вызываемый после завершения асинхронной операции.</summary>
		/// <param name="e">Сигнализирующее событие.</param>
		// Token: 0x06003F84 RID: 16260 RVA: 0x000D8CA0 File Offset: 0x000D6EA0
		protected virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			if (e == null)
			{
				return;
			}
			EventHandler<SocketAsyncEventArgs> completed = e.Completed;
			if (completed != null)
			{
				completed(e.current_socket, e);
			}
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x000D8C4F File Offset: 0x000D6E4F
		internal void StartOperationCommon(Socket socket)
		{
			this.current_socket = socket;
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x000D8CC8 File Offset: 0x000D6EC8
		internal void StartOperationWrapperConnect(MultipleConnectAsync args)
		{
			this.SetLastOperation(SocketAsyncOperation.Connect);
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x000D8CD1 File Offset: 0x000D6ED1
		internal void FinishConnectByNameSyncFailure(Exception exception, int bytesTransferred, SocketFlags flags)
		{
			this.SetResults(exception, bytesTransferred, flags);
			if (this.current_socket != null)
			{
				this.current_socket.is_connected = false;
			}
			this.Complete_internal();
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x000D8CD1 File Offset: 0x000D6ED1
		internal void FinishOperationAsyncFailure(Exception exception, int bytesTransferred, SocketFlags flags)
		{
			this.SetResults(exception, bytesTransferred, flags);
			if (this.current_socket != null)
			{
				this.current_socket.is_connected = false;
			}
			this.Complete_internal();
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x000D8CF6 File Offset: 0x000D6EF6
		internal void FinishWrapperConnectSuccess(Socket connectSocket, int bytesTransferred, SocketFlags flags)
		{
			this.SetResults(SocketError.Success, bytesTransferred, flags);
			this.current_socket = connectSocket;
			this.Complete_internal();
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x000D8D0E File Offset: 0x000D6F0E
		internal void SetResults(SocketError socketError, int bytesTransferred, SocketFlags flags)
		{
			this.SocketError = socketError;
			this.ConnectByNameError = null;
			this.BytesTransferred = bytesTransferred;
			this.SocketFlags = flags;
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x000D8D2C File Offset: 0x000D6F2C
		internal void SetResults(Exception exception, int bytesTransferred, SocketFlags flags)
		{
			this.ConnectByNameError = exception;
			this.BytesTransferred = bytesTransferred;
			this.SocketFlags = flags;
			if (exception == null)
			{
				this.SocketError = SocketError.Success;
				return;
			}
			SocketException ex = exception as SocketException;
			if (ex != null)
			{
				this.SocketError = ex.SocketErrorCode;
				return;
			}
			this.SocketError = SocketError.SocketError;
		}

		/// <summary>Получает буфер данных для применения в асинхронном методе сокета.</summary>
		/// <returns>Массив <see cref="T:System.Byte" />, представляющий буфер данных для применения в асинхронном методе сокета.</returns>
		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06003F8C RID: 16268 RVA: 0x000D8D78 File Offset: 0x000D6F78
		public byte[] Buffer
		{
			get
			{
				if (this._bufferIsExplicitArray)
				{
					ArraySegment<byte> arraySegment;
					MemoryMarshal.TryGetArray<byte>(this._buffer, out arraySegment);
					return arraySegment.Array;
				}
				return null;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x000D8DA9 File Offset: 0x000D6FA9
		public Memory<byte> MemoryBuffer
		{
			get
			{
				return this._buffer;
			}
		}

		/// <summary>Получает смещение (в байтах) в буфере данных, на который ссылается свойство <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" />.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, содержащий смещение (в байтах) в буфере данных, на который ссылается свойство <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" />.</returns>
		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06003F8E RID: 16270 RVA: 0x000D8DB1 File Offset: 0x000D6FB1
		public int Offset
		{
			get
			{
				return this._offset;
			}
		}

		/// <summary>Получает значение, равное максимальному количеству данных (в байтах), которое может быть отправлено или получено в асинхронной операции.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, содержащий значение, равное максимальному количеству данных (в байтах), которое может быть отправлено или получено.</returns>
		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06003F8F RID: 16271 RVA: 0x000D8DB9 File Offset: 0x000D6FB9
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		/// <summary>Возвращает или задает массив буферов данных для применения в асинхронном методе сокета.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IList" />, представляющий массив буферов данных для применения в асинхронном методе сокета.</returns>
		/// <exception cref="T:System.ArgumentException">Неоднозначное указание буферов для заданной операции. Это исключение возникает, если для свойства <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> задано значение, отличное от NULL, и была предпринята попытка задать отличное от NULL значение для свойства <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" />.</exception>
		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06003F90 RID: 16272 RVA: 0x000D8DC1 File Offset: 0x000D6FC1
		// (set) Token: 0x06003F91 RID: 16273 RVA: 0x000D8DCC File Offset: 0x000D6FCC
		public IList<ArraySegment<byte>> BufferList
		{
			get
			{
				return this._bufferList;
			}
			set
			{
				if (value != null)
				{
					if (!this._buffer.Equals(default(Memory<byte>)))
					{
						throw new ArgumentException(SR.Format("Buffer and BufferList properties cannot both be non-null.", "Buffer"));
					}
					int count = value.Count;
					if (this._bufferListInternal == null)
					{
						this._bufferListInternal = new List<ArraySegment<byte>>(count);
					}
					else
					{
						this._bufferListInternal.Clear();
					}
					for (int i = 0; i < count; i++)
					{
						ArraySegment<byte> arraySegment = value[i];
						RangeValidationHelpers.ValidateSegment(arraySegment);
						this._bufferListInternal.Add(arraySegment);
					}
				}
				else
				{
					List<ArraySegment<byte>> bufferListInternal = this._bufferListInternal;
					if (bufferListInternal != null)
					{
						bufferListInternal.Clear();
					}
				}
				this._bufferList = value;
			}
		}

		/// <summary>Задает буфер данных для применения в асинхронном методе сокета.</summary>
		/// <param name="offset">Смещение (в байтах) в буфере данных, при котором начинается операция.</param>
		/// <param name="count">Максимальное количество данных (в байтах), которое может быть отправлено или получено в буфере.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент вне диапазона. Это исключение возникает, если значение параметра <paramref name="offset" /> меньше нуля или больше длины массива, указанной в свойстве <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" />. Это исключение возникает также, если значение параметра <paramref name="count" /> меньше нуля или больше разницы между длиной массива, указанной в свойстве <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" />, и значением параметра <paramref name="offset" />.</exception>
		// Token: 0x06003F92 RID: 16274 RVA: 0x000D8E70 File Offset: 0x000D7070
		public void SetBuffer(int offset, int count)
		{
			if (!this._buffer.Equals(default(Memory<byte>)))
			{
				if ((ulong)offset > (ulong)((long)this._buffer.Length))
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				if ((ulong)count > (ulong)((long)(this._buffer.Length - offset)))
				{
					throw new ArgumentOutOfRangeException("count");
				}
				if (!this._bufferIsExplicitArray)
				{
					throw new InvalidOperationException("This operation may only be performed when the buffer was set using the SetBuffer overload that accepts an array.");
				}
				this._offset = offset;
				this._count = count;
			}
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x000D8EEC File Offset: 0x000D70EC
		internal void CopyBufferFrom(SocketAsyncEventArgs source)
		{
			this._buffer = source._buffer;
			this._offset = source._offset;
			this._count = source._count;
			this._bufferIsExplicitArray = source._bufferIsExplicitArray;
		}

		/// <summary>Задает буфер данных для применения в асинхронном методе сокета.</summary>
		/// <param name="buffer">Буфер данных для применения в асинхронном методе сокета.</param>
		/// <param name="offset">Смещение (в байтах) в буфере данных, при котором начинается операция.</param>
		/// <param name="count">Максимальное количество данных (в байтах), которое может быть отправлено или получено в буфере.</param>
		/// <exception cref="T:System.ArgumentException">Неоднозначное указание буферов. Это исключение возникает, если значения свойств <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> и <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> одновременно отличны от null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент вне диапазона. Это исключение возникает, если значение параметра <paramref name="offset" /> меньше нуля или больше длины массива, указанной в свойстве <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" />. Это исключение возникает также, если значение параметра <paramref name="count" /> меньше нуля или больше разницы между длиной массива, указанной в свойстве <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" />, и значением параметра <paramref name="offset" />.</exception>
		// Token: 0x06003F94 RID: 16276 RVA: 0x000D8F20 File Offset: 0x000D7120
		public void SetBuffer(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				this._buffer = default(Memory<byte>);
				this._offset = 0;
				this._count = 0;
				this._bufferIsExplicitArray = false;
				return;
			}
			if (this._bufferList != null)
			{
				throw new ArgumentException(SR.Format("Buffer and BufferList properties cannot both be non-null.", "BufferList"));
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)count > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this._buffer = buffer;
			this._offset = offset;
			this._count = count;
			this._bufferIsExplicitArray = true;
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000D8FB8 File Offset: 0x000D71B8
		public void SetBuffer(Memory<byte> buffer)
		{
			if (buffer.Length != 0 && this._bufferList != null)
			{
				throw new ArgumentException(SR.Format("Buffer and BufferList properties cannot both be non-null.", "BufferList"));
			}
			this._buffer = buffer;
			this._offset = 0;
			this._count = buffer.Length;
			this._bufferIsExplicitArray = false;
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x000D900D File Offset: 0x000D720D
		internal bool HasMultipleBuffers
		{
			get
			{
				return this._bufferList != null;
			}
		}

		/// <summary>Получает или задает протокол для загрузки файла политики клиентского доступа к сокету.</summary>
		/// <returns>Протокол для загрузки файла политики клиентского доступа к сокету.</returns>
		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x000D9018 File Offset: 0x000D7218
		// (set) Token: 0x06003F98 RID: 16280 RVA: 0x00013BCA File Offset: 0x00011DCA
		public SocketClientAccessPolicyProtocol SocketClientAccessPolicyProtocol
		{
			[CompilerGenerated]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return SocketClientAccessPolicyProtocol.Tcp;
			}
			[CompilerGenerated]
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		// Token: 0x040025DA RID: 9690
		private bool disposed;

		// Token: 0x040025DB RID: 9691
		internal volatile int in_progress;

		// Token: 0x040025DC RID: 9692
		private EndPoint remote_ep;

		// Token: 0x040025DD RID: 9693
		private Socket current_socket;

		// Token: 0x040025DE RID: 9694
		internal SocketAsyncResult socket_async_result = new SocketAsyncResult();

		// Token: 0x040025EC RID: 9708
		private Memory<byte> _buffer;

		// Token: 0x040025ED RID: 9709
		private int _offset;

		// Token: 0x040025EE RID: 9710
		private int _count;

		// Token: 0x040025EF RID: 9711
		private bool _bufferIsExplicitArray;

		// Token: 0x040025F0 RID: 9712
		private IList<ArraySegment<byte>> _bufferList;

		// Token: 0x040025F1 RID: 9713
		private List<ArraySegment<byte>> _bufferListInternal;
	}
}
