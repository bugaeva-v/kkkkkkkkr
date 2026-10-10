using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>
	///         Предоставляет объект <see cref="T:System.IO.Stream" /> для канала, поддерживающий анонимные и именованные каналы.
	///       </summary>
	// Token: 0x02000350 RID: 848
	public abstract class PipeStream : Stream
	{
		// Token: 0x060019A1 RID: 6561 RVA: 0x00055CF8 File Offset: 0x00053EF8
		internal static string GetPipePath(string serverName, string pipeName)
		{
			string fullPath = Path.GetFullPath("\\\\" + serverName + "\\pipe\\" + pipeName);
			if (string.Equals(fullPath, "\\\\.\\pipe\\anonymous", StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentOutOfRangeException("pipeName", "The pipeName \\\"anonymous\\\" is reserved.");
			}
			return fullPath;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00055D2E File Offset: 0x00053F2E
		internal void ValidateHandleIsPipe(SafePipeHandle safePipeHandle)
		{
			if (Interop.Kernel32.GetFileType(safePipeHandle) != 3)
			{
				throw new IOException("Invalid pipe handle.");
			}
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00055D44 File Offset: 0x00053F44
		private void InitializeAsyncHandle(SafePipeHandle handle)
		{
			this._threadPoolBinding = ThreadPoolBoundHandle.BindHandle(handle);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00055D52 File Offset: 0x00053F52
		private void DisposeCore(bool disposing)
		{
			if (disposing)
			{
				ThreadPoolBoundHandle threadPoolBinding = this._threadPoolBinding;
				if (threadPoolBinding == null)
				{
					return;
				}
				threadPoolBinding.Dispose();
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00055D68 File Offset: 0x00053F68
		private int ReadCore(Span<byte> buffer)
		{
			int num = 0;
			int num2 = this.ReadFileNative(this._handle, buffer, null, out num);
			if (num2 == -1)
			{
				if (num != 109 && num != 233)
				{
					throw Win32Marshal.GetExceptionForWin32Error(num, string.Empty);
				}
				this.State = PipeState.Broken;
				num2 = 0;
			}
			this._isMessageComplete = (num != 234);
			return num2;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00055DC4 File Offset: 0x00053FC4
		private unsafe Task<int> ReadAsyncCore(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			ReadWriteCompletionSource readWriteCompletionSource = new ReadWriteCompletionSource(this, buffer, false);
			int num = 0;
			if (this.ReadFileNative(this._handle, buffer.Span, readWriteCompletionSource.Overlapped, out num) == -1)
			{
				if (num == 109 || num == 233)
				{
					this.State = PipeState.Broken;
					readWriteCompletionSource.Overlapped->InternalLow = IntPtr.Zero;
					readWriteCompletionSource.ReleaseResources();
					this.UpdateMessageCompletion(true);
					return PipeStream.s_zeroTask;
				}
				if (num != 997)
				{
					throw Win32Marshal.GetExceptionForWin32Error(num, "");
				}
			}
			readWriteCompletionSource.RegisterForCancellation(cancellationToken);
			return readWriteCompletionSource.Task;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00055E5C File Offset: 0x0005405C
		private void WriteCore(ReadOnlySpan<byte> buffer)
		{
			int errorCode = 0;
			if (this.WriteFileNative(this._handle, buffer, null, out errorCode) == -1)
			{
				throw this.WinIOError(errorCode);
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00055E88 File Offset: 0x00054088
		private Task WriteAsyncCore(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			ReadWriteCompletionSource readWriteCompletionSource = new ReadWriteCompletionSource(this, buffer, true);
			int num = 0;
			if (this.WriteFileNative(this._handle, buffer.Span, readWriteCompletionSource.Overlapped, out num) == -1 && num != 997)
			{
				readWriteCompletionSource.ReleaseResources();
				throw this.WinIOError(num);
			}
			readWriteCompletionSource.RegisterForCancellation(cancellationToken);
			return readWriteCompletionSource.Task;
		}

		/// <summary>
		///         Ожидает завершения считывания всех отправленных байтов на противоположном конце канала.
		///       </summary>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Канал не поддерживает операции записи.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x060019A9 RID: 6569 RVA: 0x00055EE1 File Offset: 0x000540E1
		public void WaitForPipeDrain()
		{
			this.CheckWriteOperations();
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
			if (!Interop.Kernel32.FlushFileBuffers(this._handle))
			{
				throw this.WinIOError(Marshal.GetLastWin32Error());
			}
		}

		/// <summary>
		///         Возвращает режим передачи, поддерживаемый текущим каналом.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.IO.Pipes.PipeTransmissionMode" />, указывающих режим передачи, поддерживаемый текущим каналом.
		///       </returns>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Дескриптор не был задан.
		///
		///             -или-
		///
		///             Канал ожидает соединения в анонимной операции клиента/сервера или с именованным клиентом.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x00055F10 File Offset: 0x00054110
		public virtual PipeTransmissionMode TransmissionMode
		{
			get
			{
				this.CheckPipePropertyOperations();
				if (!this._isFromExistingHandle)
				{
					return this._transmissionMode;
				}
				int num;
				if (!Interop.Kernel32.GetNamedPipeInfo(this._handle, out num, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero))
				{
					throw this.WinIOError(Marshal.GetLastWin32Error());
				}
				if ((num & 4) != 0)
				{
					return PipeTransmissionMode.Message;
				}
				return PipeTransmissionMode.Byte;
			}
		}

		/// <summary>
		///         Возвращает размер (в байтах) входящего буфера для канала.
		///       </summary>
		/// <returns>
		///         Целое значение, представляющее размер входящего буфера (в байтах).
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Чтение потока невозможно.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал ожидает соединения.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x00055F64 File Offset: 0x00054164
		public virtual int InBufferSize
		{
			get
			{
				this.CheckPipePropertyOperations();
				if (!this.CanRead)
				{
					throw new NotSupportedException("Stream does not support reading.");
				}
				int result;
				if (!Interop.Kernel32.GetNamedPipeInfo(this._handle, IntPtr.Zero, IntPtr.Zero, out result, IntPtr.Zero))
				{
					throw this.WinIOError(Marshal.GetLastWin32Error());
				}
				return result;
			}
		}

		/// <summary>
		///         Возвращает размер (в байтах) исходящего буфера для канала.
		///       </summary>
		/// <returns>
		///         Размер исходящего буфера в байтах.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Запись в поток невозможна.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал ожидает соединения.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00055FB8 File Offset: 0x000541B8
		public virtual int OutBufferSize
		{
			get
			{
				this.CheckPipePropertyOperations();
				if (!this.CanWrite)
				{
					throw new NotSupportedException("Stream does not support writing.");
				}
				int outBufferSize;
				if (this._pipeDirection == PipeDirection.Out)
				{
					outBufferSize = this._outBufferSize;
				}
				else if (!Interop.Kernel32.GetNamedPipeInfo(this._handle, IntPtr.Zero, out outBufferSize, IntPtr.Zero, IntPtr.Zero))
				{
					throw this.WinIOError(Marshal.GetLastWin32Error());
				}
				return outBufferSize;
			}
		}

		/// <summary>
		///         Возвращает или задает режим чтения для объекта <see cref="T:System.IO.Pipes.PipeStream" />.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.IO.Pipes.PipeTransmissionMode" />, которое указывает, как объект <see cref="T:System.IO.Pipes.PipeStream" /> читает данные из канала.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Указанное значение не является допустимым значением <see cref="T:System.IO.Pipes.PipeTransmissionMode" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Указанное значение не является поддерживаемым значением <see cref="T:System.IO.Pipes.PipeTransmissionMode" /> для этого потока канала.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Дескриптор не был задан.
		///
		///             -или-
		///
		///             Канал ожидает соединения с указанным клиентом.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван или в указанном клиенте возникла ошибка ввода-вывода.
		///           </exception>
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x0005601B File Offset: 0x0005421B
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x00056040 File Offset: 0x00054240
		public unsafe virtual PipeTransmissionMode ReadMode
		{
			get
			{
				this.CheckPipePropertyOperations();
				if (this._isFromExistingHandle || this.IsHandleExposed)
				{
					this.UpdateReadMode();
				}
				return this._readMode;
			}
			set
			{
				this.CheckPipePropertyOperations();
				if (value < PipeTransmissionMode.Byte || value > PipeTransmissionMode.Message)
				{
					throw new ArgumentOutOfRangeException("value", "For named pipes, transmission mode can be TransmissionMode.Byte or PipeTransmissionMode.Message. For anonymous pipes, transmission mode can be TransmissionMode.Byte.");
				}
				int num = (int)((int)value << 1);
				if (!Interop.Kernel32.SetNamedPipeHandleState(this._handle, &num, IntPtr.Zero, IntPtr.Zero))
				{
					throw this.WinIOError(Marshal.GetLastWin32Error());
				}
				this._readMode = value;
			}
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0005609C File Offset: 0x0005429C
		private unsafe int ReadFileNative(SafePipeHandle handle, Span<byte> buffer, NativeOverlapped* overlapped, out int errorCode)
		{
			if (buffer.Length == 0)
			{
				errorCode = 0;
				return 0;
			}
			int result = 0;
			bool flag;
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(buffer))
			{
				byte* bytes = reference;
				flag = ((this._isAsync ? Interop.Kernel32.ReadFile(handle, bytes, buffer.Length, IntPtr.Zero, overlapped) : Interop.Kernel32.ReadFile(handle, bytes, buffer.Length, out result, IntPtr.Zero)) != 0);
			}
			if (flag)
			{
				errorCode = 0;
				return result;
			}
			errorCode = Marshal.GetLastWin32Error();
			if (errorCode != 234)
			{
				return -1;
			}
			return result;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00056118 File Offset: 0x00054318
		private unsafe int WriteFileNative(SafePipeHandle handle, ReadOnlySpan<byte> buffer, NativeOverlapped* overlapped, out int errorCode)
		{
			if (buffer.Length == 0)
			{
				errorCode = 0;
				return 0;
			}
			int result = 0;
			bool flag;
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(buffer))
			{
				byte* bytes = reference;
				flag = ((this._isAsync ? Interop.Kernel32.WriteFile(handle, bytes, buffer.Length, IntPtr.Zero, overlapped) : Interop.Kernel32.WriteFile(handle, bytes, buffer.Length, out result, IntPtr.Zero)) != 0);
			}
			if (!flag)
			{
				errorCode = Marshal.GetLastWin32Error();
				return -1;
			}
			errorCode = 0;
			return result;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00056188 File Offset: 0x00054388
		internal static Interop.Kernel32.SECURITY_ATTRIBUTES GetSecAttrs(HandleInheritability inheritability)
		{
			Interop.Kernel32.SECURITY_ATTRIBUTES result = default(Interop.Kernel32.SECURITY_ATTRIBUTES);
			if ((inheritability & HandleInheritability.Inheritable) != HandleInheritability.None)
			{
				result = default(Interop.Kernel32.SECURITY_ATTRIBUTES);
				result.nLength = (uint)sizeof(Interop.Kernel32.SECURITY_ATTRIBUTES);
				result.bInheritHandle = Interop.BOOL.TRUE;
			}
			return result;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000561C0 File Offset: 0x000543C0
		internal unsafe static Interop.Kernel32.SECURITY_ATTRIBUTES GetSecAttrs(HandleInheritability inheritability, PipeSecurity pipeSecurity, ref GCHandle pinningHandle)
		{
			Interop.Kernel32.SECURITY_ATTRIBUTES result = default(Interop.Kernel32.SECURITY_ATTRIBUTES);
			result.nLength = (uint)sizeof(Interop.Kernel32.SECURITY_ATTRIBUTES);
			if ((inheritability & HandleInheritability.Inheritable) != HandleInheritability.None)
			{
				result.bInheritHandle = Interop.BOOL.TRUE;
			}
			if (pipeSecurity != null)
			{
				byte[] securityDescriptorBinaryForm = pipeSecurity.GetSecurityDescriptorBinaryForm();
				pinningHandle = GCHandle.Alloc(securityDescriptorBinaryForm, GCHandleType.Pinned);
				byte[] array;
				byte* value;
				if ((array = securityDescriptorBinaryForm) == null || array.Length == 0)
				{
					value = null;
				}
				else
				{
					value = &array[0];
				}
				result.lpSecurityDescriptor = (IntPtr)((void*)value);
				array = null;
			}
			return result;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00056230 File Offset: 0x00054430
		private void UpdateReadMode()
		{
			int num;
			if (!Interop.Kernel32.GetNamedPipeHandleState(this.SafePipeHandle, out num, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 0))
			{
				throw this.WinIOError(Marshal.GetLastWin32Error());
			}
			if ((num & 2) != 0)
			{
				this._readMode = PipeTransmissionMode.Message;
				return;
			}
			this._readMode = PipeTransmissionMode.Byte;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00056284 File Offset: 0x00054484
		internal Exception WinIOError(int errorCode)
		{
			if (errorCode <= 38)
			{
				if (errorCode != 6)
				{
					if (errorCode == 38)
					{
						return Error.GetEndOfFile();
					}
				}
				else
				{
					this._handle.SetHandleAsInvalid();
					this._state = PipeState.Broken;
				}
			}
			else if (errorCode == 109 || errorCode - 232 <= 1)
			{
				this._state = PipeState.Broken;
				return new IOException("Pipe is broken.", Win32Marshal.MakeHRFromErrorCode(errorCode));
			}
			return Win32Marshal.GetExceptionForWin32Error(errorCode, "");
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Pipes.PipeStream" /> с использованием указанного значения <see cref="T:System.IO.Pipes.PipeDirection" /> и размера буфера.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений <see cref="T:System.IO.Pipes.PipeDirection" />, указывающих направление объекта канала.
		///         </param>
		/// <param name="bufferSize">
		///           Положительное значение типа <see cref="T:System.Int32" /> (большее или равное 0), соответствующее размеру буфера.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="bufferSize" /> меньше 0.
		///           </exception>
		// Token: 0x060019B5 RID: 6581 RVA: 0x000562EB File Offset: 0x000544EB
		protected PipeStream(PipeDirection direction, int bufferSize)
		{
			if (direction < PipeDirection.In || direction > PipeDirection.InOut)
			{
				throw new ArgumentOutOfRangeException("direction", "For named pipes, the pipe direction can be PipeDirection.In, PipeDirection.Out or PipeDirection.InOut. For anonymous pipes, the pipe direction can be PipeDirection.In or PipeDirection.Out.");
			}
			if (bufferSize < 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", "Non negative number is required.");
			}
			this.Init(direction, PipeTransmissionMode.Byte, bufferSize);
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Pipes.PipeStream" /> с использованием указанных значений <see cref="T:System.IO.Pipes.PipeDirection" />, <see cref="T:System.IO.Pipes.PipeTransmissionMode" /> и размера буфера.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений <see cref="T:System.IO.Pipes.PipeDirection" />, указывающих направление объекта канала.
		///         </param>
		/// <param name="transmissionMode">
		///           Одно из значений <see cref="T:System.IO.Pipes.PipeTransmissionMode" />, указывающих режим передачи для объекта канала.
		///         </param>
		/// <param name="outBufferSize">
		///           Положительное значение типа <see cref="T:System.Int32" /> (большее или равное 0), соответствующее размеру буфера.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///
		///             -или-
		///
		///             <paramref name="transmissionMode" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeTransmissionMode" />.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="bufferSize" /> меньше 0.
		///           </exception>
		// Token: 0x060019B6 RID: 6582 RVA: 0x00056328 File Offset: 0x00054528
		protected PipeStream(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize)
		{
			if (direction < PipeDirection.In || direction > PipeDirection.InOut)
			{
				throw new ArgumentOutOfRangeException("direction", "For named pipes, the pipe direction can be PipeDirection.In, PipeDirection.Out or PipeDirection.InOut. For anonymous pipes, the pipe direction can be PipeDirection.In or PipeDirection.Out.");
			}
			if (transmissionMode < PipeTransmissionMode.Byte || transmissionMode > PipeTransmissionMode.Message)
			{
				throw new ArgumentOutOfRangeException("transmissionMode", "For named pipes, transmission mode can be TransmissionMode.Byte or PipeTransmissionMode.Message. For anonymous pipes, transmission mode can be TransmissionMode.Byte.");
			}
			if (outBufferSize < 0)
			{
				throw new ArgumentOutOfRangeException("outBufferSize", "Non negative number is required.");
			}
			this.Init(direction, transmissionMode, outBufferSize);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00056388 File Offset: 0x00054588
		private void Init(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize)
		{
			this._readMode = transmissionMode;
			this._transmissionMode = transmissionMode;
			this._pipeDirection = direction;
			if ((this._pipeDirection & PipeDirection.In) != (PipeDirection)0)
			{
				this._canRead = true;
			}
			if ((this._pipeDirection & PipeDirection.Out) != (PipeDirection)0)
			{
				this._canWrite = true;
			}
			this._outBufferSize = outBufferSize;
			this._isMessageComplete = true;
			this._state = PipeState.WaitingToConnect;
		}

		/// <summary>
		///         Инициализирует объект <see cref="T:System.IO.Pipes.PipeStream" /> из указанного объекта <see cref="T:Microsoft.Win32.SafeHandles.SafePipeHandle" />.
		///       </summary>
		/// <param name="handle">
		///           Объект <see cref="T:Microsoft.Win32.SafeHandles.SafePipeHandle" /> для инициализируемого канала.
		///         </param>
		/// <param name="isExposed">
		///           Значение <see langword="true" /> для предоставления дескриптора, в противном случае — значение <see langword="false" />.
		///         </param>
		/// <param name="isAsync">
		///           Значение <see langword="true" />, если дескриптор открыт асинхронно; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <exception cref="T:System.IO.IOException">
		///             Невозможно привязать дескриптор к каналу.
		///           </exception>
		// Token: 0x060019B8 RID: 6584 RVA: 0x000563E1 File Offset: 0x000545E1
		protected void InitializeHandle(SafePipeHandle handle, bool isExposed, bool isAsync)
		{
			if (isAsync && handle != null)
			{
				this.InitializeAsyncHandle(handle);
			}
			this._handle = handle;
			this._isAsync = isAsync;
			this._isHandleExposed = isExposed;
			this._isFromExistingHandle = isExposed;
		}

		/// <summary>
		///         Считывает блок байтов из потока и записывает данные в заданный буфер.
		///       </summary>
		/// <param name="buffer">
		///           При возврате этот метод содержит указанный массив байтов, в котором значения в интервале от <paramref name="offset" /> до (<paramref name="offset" /> + <paramref name="count" /> - 1) заменены байтами, считанными из текущего источника.
		///         </param>
		/// <param name="offset">
		///           Смещение в массиве <paramref name="buffer" /> (в байтах), начиная с которого будут размещаться считанные байты.
		///         </param>
		/// <param name="count">
		///           Максимальное число байтов, предназначенных для чтения.
		///         </param>
		/// <returns>
		///         Общее число байтов, считанных в <paramref name="buffer" />.
		///          Это число может быть меньше количества запрошенных байтов, если это количество байтов в настоящее время недоступно, а также равняться нулю, если достигнут конец потока.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="offset" /> меньше 0.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="count" /> меньше 0.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="count" /> больше, чем число байтов, доступных в <paramref name="buffer" />.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Этот канал не поддерживает операции чтения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал отключен, ожидает подключения, или дескриптор не был задан.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Ошибка ввода/вывода.
		///           </exception>
		// Token: 0x060019B9 RID: 6585 RVA: 0x0005640C File Offset: 0x0005460C
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._isAsync)
			{
				return this.ReadAsync(buffer, offset, count, CancellationToken.None).GetAwaiter().GetResult();
			}
			this.CheckReadWriteArgs(buffer, offset, count);
			if (!this.CanRead)
			{
				throw Error.GetReadNotSupported();
			}
			this.CheckReadOperations();
			return this.ReadCore(new Span<byte>(buffer, offset, count));
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00056468 File Offset: 0x00054668
		public override int Read(Span<byte> buffer)
		{
			if (this._isAsync)
			{
				return base.Read(buffer);
			}
			if (!this.CanRead)
			{
				throw Error.GetReadNotSupported();
			}
			this.CheckReadOperations();
			return this.ReadCore(buffer);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00056498 File Offset: 0x00054698
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckReadWriteArgs(buffer, offset, count);
			if (!this.CanRead)
			{
				throw Error.GetReadNotSupported();
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			this.CheckReadOperations();
			if (!this._isAsync)
			{
				return base.ReadAsync(buffer, offset, count, cancellationToken);
			}
			if (count == 0)
			{
				this.UpdateMessageCompletion(false);
				return PipeStream.s_zeroTask;
			}
			return this.ReadAsyncCore(new Memory<byte>(buffer, offset, count), cancellationToken);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00056508 File Offset: 0x00054708
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (!this._isAsync)
			{
				return base.ReadAsync(buffer, cancellationToken);
			}
			if (!this.CanRead)
			{
				throw Error.GetReadNotSupported();
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			this.CheckReadOperations();
			if (buffer.Length == 0)
			{
				this.UpdateMessageCompletion(false);
				return new ValueTask<int>(0);
			}
			return new ValueTask<int>(this.ReadAsyncCore(buffer, cancellationToken));
		}

		/// <summary>
		///         Начинает операцию асинхронного чтения.
		///       </summary>
		/// <param name="buffer">
		///           Буфер, в который должны считываться данные.
		///         </param>
		/// <param name="offset">
		///           Смещение в <paramref name="buffer" /> (в байтах), с которого начинается чтение.
		///         </param>
		/// <param name="count">
		///           Максимальное число байтов, предназначенных для чтения.
		///         </param>
		/// <param name="callback">
		///           Метод, вызываемый после завершения операции асинхронного чтения.
		///         </param>
		/// <param name="state">
		///           Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронное чтение от других запросов.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное чтение.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="offset" /> меньше 0.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="count" /> меньше 0.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="count" /> больше, чем число байтов, доступных в <paramref name="buffer" />.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Этот канал не поддерживает операции чтения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал отключен, ожидает подключения, или дескриптор не был задан.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x060019BD RID: 6589 RVA: 0x00056573 File Offset: 0x00054773
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (this._isAsync)
			{
				return TaskToApm.Begin(this.ReadAsync(buffer, offset, count, CancellationToken.None), callback, state);
			}
			return base.BeginRead(buffer, offset, count, callback, state);
		}

		/// <summary>
		///         Завершает отложенный запрос асинхронного чтения.
		///       </summary>
		/// <param name="asyncResult">
		///           Ссылка на отложенный асинхронный запрос.
		///         </param>
		/// <returns>
		///         Количество прочитанных байтов.
		///          Возвращаемое значение, равное нулю, указывает конец потока (канал закрыт).
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="asyncResult" /> не происходит из метода <see cref="M:System.IO.Pipes.PipeStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> в текущем потоке.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Поток закрыт, или произошла внутренняя ошибка.
		///           </exception>
		// Token: 0x060019BE RID: 6590 RVA: 0x000565A2 File Offset: 0x000547A2
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (this._isAsync)
			{
				return TaskToApm.End<int>(asyncResult);
			}
			return base.EndRead(asyncResult);
		}

		/// <summary>
		///         Записывает в текущий поток блок байтов, используя данные из буфера.
		///       </summary>
		/// <param name="buffer">
		///           Буфер, содержащий данные для записи в канал.
		///         </param>
		/// <param name="offset">
		///           Отсчитываемое от нуля смещение байтов в буфере <paramref name="buffer" />, с которого начинается копирование байтов в текущий поток.
		///         </param>
		/// <param name="count">
		///           Максимальное число байтов для записи в текущий поток.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="offset" /> меньше 0.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="count" /> меньше 0.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="count" /> больше, чем число байтов, доступных в <paramref name="buffer" />.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Канал не поддерживает операции записи.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x060019BF RID: 6591 RVA: 0x000565BC File Offset: 0x000547BC
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._isAsync)
			{
				this.WriteAsync(buffer, offset, count, CancellationToken.None).GetAwaiter().GetResult();
				return;
			}
			this.CheckReadWriteArgs(buffer, offset, count);
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
			this.CheckWriteOperations();
			this.WriteCore(new ReadOnlySpan<byte>(buffer, offset, count));
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00056618 File Offset: 0x00054818
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			if (this._isAsync)
			{
				base.Write(buffer);
				return;
			}
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
			this.CheckWriteOperations();
			this.WriteCore(buffer);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00056648 File Offset: 0x00054848
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckReadWriteArgs(buffer, offset, count);
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			this.CheckWriteOperations();
			if (!this._isAsync)
			{
				return base.WriteAsync(buffer, offset, count, cancellationToken);
			}
			if (count == 0)
			{
				return Task.CompletedTask;
			}
			return this.WriteAsyncCore(new ReadOnlyMemory<byte>(buffer, offset, count), cancellationToken);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000566B0 File Offset: 0x000548B0
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (!this._isAsync)
			{
				return base.WriteAsync(buffer, cancellationToken);
			}
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask(Task.FromCanceled<int>(cancellationToken));
			}
			this.CheckWriteOperations();
			if (buffer.Length == 0)
			{
				return default(ValueTask);
			}
			return new ValueTask(this.WriteAsyncCore(buffer, cancellationToken));
		}

		/// <summary>
		///         Начинает операцию асинхронной записи.
		///       </summary>
		/// <param name="buffer">
		///           Буфер, содержащий данные для записи в текущий поток.
		///         </param>
		/// <param name="offset">
		///           Отсчитываемое от нуля смещение байтов в буфере <paramref name="buffer" />, с которого начинается копирование байтов в текущий поток.
		///         </param>
		/// <param name="count">
		///           Максимальное число байтов для записи.
		///         </param>
		/// <param name="callback">
		///           Метод, вызываемый после завершения операции асинхронной записи.
		///         </param>
		/// <param name="state">
		///           Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронную запись от других запросов.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.IAsyncResult" />, который ссылается на операцию асинхронной записи.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="offset" /> меньше 0.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="count" /> меньше 0.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="count" /> больше, чем число байтов, доступных в <paramref name="buffer" />.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Канал не поддерживает операции записи.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал отключен, ожидает подключения, или дескриптор не был задан.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x060019C3 RID: 6595 RVA: 0x00056717 File Offset: 0x00054917
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (this._isAsync)
			{
				return TaskToApm.Begin(this.WriteAsync(buffer, offset, count, CancellationToken.None), callback, state);
			}
			return base.BeginWrite(buffer, offset, count, callback, state);
		}

		/// <summary>
		///         Завершает отложенный запрос асинхронной записи.
		///       </summary>
		/// <param name="asyncResult">
		///           Ссылка на отложенный асинхронный запрос.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="asyncResult" /> не происходит из метода <see cref="M:System.IO.Pipes.PipeStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> в текущем потоке.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Поток закрыт, или произошла внутренняя ошибка.
		///           </exception>
		// Token: 0x060019C4 RID: 6596 RVA: 0x00056746 File Offset: 0x00054946
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (this._isAsync)
			{
				TaskToApm.End(asyncResult);
				return;
			}
			base.EndWrite(asyncResult);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00056760 File Offset: 0x00054960
		private void CheckReadWriteArgs(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non negative number is required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non negative number is required.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00003A59 File Offset: 0x00001C59
		[Conditional("DEBUG")]
		private static void DebugAssertHandleValid(SafePipeHandle handle)
		{
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00003A59 File Offset: 0x00001C59
		[Conditional("DEBUG")]
		private static void DebugAssertReadWriteArgs(byte[] buffer, int offset, int count, SafePipeHandle handle)
		{
		}

		/// <summary>
		///         Считывает байт из канала.
		///       </summary>
		/// <returns>
		///         Байт, приведенный к типу <see cref="T:System.Int32" />, или -1, если достигнут конец потока (канал закрыт).
		///       </returns>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Этот канал не поддерживает операции чтения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал отключен, ожидает подключения, или дескриптор не был задан.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Ошибка ввода/вывода.
		///           </exception>
		// Token: 0x060019C8 RID: 6600 RVA: 0x000567BC File Offset: 0x000549BC
		public unsafe override int ReadByte()
		{
			byte result;
			if (this.Read(new Span<byte>((void*)(&result), 1)) <= 0)
			{
				return -1;
			}
			return (int)result;
		}

		/// <summary>
		///         Выполняет запись байта в текущий поток.
		///       </summary>
		/// <param name="value">
		///           Байт, записываемый в поток.
		///         </param>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Канал не поддерживает операции записи.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал отключен, ожидает подключения, или дескриптор не был задан.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x060019C9 RID: 6601 RVA: 0x000567DE File Offset: 0x000549DE
		public unsafe override void WriteByte(byte value)
		{
			this.Write(new ReadOnlySpan<byte>((void*)(&value), 1));
		}

		/// <summary>
		///         Очищает буфер для текущего потока и вызывает запись всех буферизованных данных в соответствующее устройство.
		///       </summary>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Канал не поддерживает операции записи.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван, или возникла другая ошибка ввода-вывода.
		///           </exception>
		// Token: 0x060019CA RID: 6602 RVA: 0x000567EF File Offset: 0x000549EF
		public override void Flush()
		{
			this.CheckWriteOperations();
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.IO.Pipes.PipeStream" /> (при необходимости освобождает и управляемые ресурсы).
		///       </summary>
		/// <param name="disposing">
		///           Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.
		///         </param>
		// Token: 0x060019CB RID: 6603 RVA: 0x00056808 File Offset: 0x00054A08
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (this._handle != null && !this._handle.IsClosed)
				{
					this._handle.Dispose();
				}
				this.DisposeCore(disposing);
			}
			finally
			{
				base.Dispose(disposing);
			}
			this._state = PipeState.Closed;
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, подключен ли объект <see cref="T:System.IO.Pipes.PipeStream" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если объект <see cref="T:System.IO.Pipes.PipeStream" /> подключен; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00056860 File Offset: 0x00054A60
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0005686B File Offset: 0x00054A6B
		public bool IsConnected
		{
			get
			{
				return this.State == PipeState.Connected;
			}
			protected set
			{
				this._state = (value ? PipeState.Connected : PipeState.Disconnected);
			}
		}

		/// <summary>
		///         Возвращает значение, показывающее, как был открыт объект <see cref="T:System.IO.Pipes.PipeStream" /> — синхронно или асинхронно.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если объект <see cref="T:System.IO.Pipes.PipeStream" /> был открыт асинхронно, в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0005687A File Offset: 0x00054A7A
		public bool IsAsync
		{
			get
			{
				return this._isAsync;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, содержатся ли еще данные в сообщении, возвращенном из последней операции чтения.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если в сообщении больше нет символов для чтения, в противном случае — значение <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал не подключен.
		///
		///             -или-
		///
		///             Дескриптор канала не был задан.
		///
		///             -или-
		///
		///             Свойство <see cref="P:System.IO.Pipes.PipeStream.ReadMode" /> канала не имеет значение <see cref="F:System.IO.Pipes.PipeTransmissionMode.Message" />.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00056884 File Offset: 0x00054A84
		public bool IsMessageComplete
		{
			get
			{
				if (this._state == PipeState.WaitingToConnect)
				{
					throw new InvalidOperationException("Pipe hasn't been connected yet.");
				}
				if (this._state == PipeState.Disconnected)
				{
					throw new InvalidOperationException("Pipe is in a disconnected state.");
				}
				if (this._handle == null)
				{
					throw new InvalidOperationException("Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?");
				}
				if (this._state == PipeState.Closed || (this._handle != null && this._handle.IsClosed))
				{
					throw Error.GetPipeNotOpen();
				}
				if (this._readMode != PipeTransmissionMode.Message)
				{
					throw new InvalidOperationException("ReadMode is not of PipeTransmissionMode.Message.");
				}
				return this._isMessageComplete;
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00056909 File Offset: 0x00054B09
		internal void UpdateMessageCompletion(bool completion)
		{
			this._isMessageComplete = (completion || this._state == PipeState.Broken);
		}

		/// <summary>
		///         Возвращает безопасный дескриптор для локального конца канала, инкапсулируемого текущим объектом <see cref="T:System.IO.Pipes.PipeStream" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:Microsoft.Win32.SafeHandles.SafePipeHandle" /> для канала, инкапсулируемого текущим объектом <see cref="T:System.IO.Pipes.PipeStream" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Дескриптор канала не был задан.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x00056920 File Offset: 0x00054B20
		public SafePipeHandle SafePipeHandle
		{
			get
			{
				if (this._handle == null)
				{
					throw new InvalidOperationException("Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?");
				}
				if (this._handle.IsClosed)
				{
					throw Error.GetPipeNotOpen();
				}
				this._isHandleExposed = true;
				return this._handle;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00056955 File Offset: 0x00054B55
		internal SafePipeHandle InternalHandle
		{
			get
			{
				return this._handle;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, предоставлен ли дескриптор в объект <see cref="T:System.IO.Pipes.PipeStream" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если дескриптор представлен в объект <see cref="T:System.IO.Pipes.PipeStream" />; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0005695D File Offset: 0x00054B5D
		protected bool IsHandleExposed
		{
			get
			{
				return this._isHandleExposed;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, поддерживает ли текущий поток операции чтения.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если поток поддерживает операции чтения, в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00056965 File Offset: 0x00054B65
		public override bool CanRead
		{
			get
			{
				return this._canRead;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, поддерживает ли текущий поток операции записи.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если поток поддерживает операции записи, в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0005696D File Offset: 0x00054B6D
		public override bool CanWrite
		{
			get
			{
				return this._canWrite;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, поддерживает ли текущий поток операции поиска.
		///       </summary>
		/// <returns>
		///         Значение <see langword="false" /> во всех случаях.
		///       </returns>
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x000023D1 File Offset: 0x000005D1
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Возвращает длину потока в байтах.
		///       </summary>
		/// <returns>
		///         0 во всех случаях.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Создается всегда.
		///           </exception>
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x00056975 File Offset: 0x00054B75
		public override long Length
		{
			get
			{
				throw Error.GetSeekNotSupported();
			}
		}

		/// <summary>
		///         Возвращает или задает текущую позицию в текущем потоке.
		///       </summary>
		/// <returns>
		///         0 во всех случаях.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Создается всегда.
		///           </exception>
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00056975 File Offset: 0x00054B75
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x00056975 File Offset: 0x00054B75
		public override long Position
		{
			get
			{
				throw Error.GetSeekNotSupported();
			}
			set
			{
				throw Error.GetSeekNotSupported();
			}
		}

		/// <summary>
		///         Задает указанное значение для длины текущего потока.
		///       </summary>
		/// <param name="value">
		///           Новая длина потока.
		///         </param>
		// Token: 0x060019DA RID: 6618 RVA: 0x00056975 File Offset: 0x00054B75
		public override void SetLength(long value)
		{
			throw Error.GetSeekNotSupported();
		}

		/// <summary>
		///         Устанавливает заданное значение в качестве текущей позиции в текущем потоке.
		///       </summary>
		/// <param name="offset">
		///           Указатель относительно начальной точки <paramref name="origin" />, от которого начинается поиск.
		///         </param>
		/// <param name="origin">
		///           Задает начальную, конечную или текущую позицию как опорную точку для <paramref name="offset" />, используя значение типа <see cref="T:System.IO.SeekOrigin" />.
		///         </param>
		/// <returns>
		///         Новая позиция в потоке.
		///       </returns>
		// Token: 0x060019DB RID: 6619 RVA: 0x00056975 File Offset: 0x00054B75
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw Error.GetSeekNotSupported();
		}

		/// <summary>
		///         Проверяет, допускает ли состояние канала получение или установку свойств.
		///       </summary>
		// Token: 0x060019DC RID: 6620 RVA: 0x0005697C File Offset: 0x00054B7C
		protected internal virtual void CheckPipePropertyOperations()
		{
			if (this._handle == null)
			{
				throw new InvalidOperationException("Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?");
			}
			if (this._state == PipeState.Closed || (this._handle != null && this._handle.IsClosed))
			{
				throw Error.GetPipeNotOpen();
			}
		}

		/// <summary>
		///         Проверяет, находится ли канал в подключенном состоянии для выполнения операций чтения.
		///       </summary>
		// Token: 0x060019DD RID: 6621 RVA: 0x000569B8 File Offset: 0x00054BB8
		protected internal void CheckReadOperations()
		{
			if (this._state == PipeState.WaitingToConnect)
			{
				throw new InvalidOperationException("Pipe hasn't been connected yet.");
			}
			if (this._state == PipeState.Disconnected)
			{
				throw new InvalidOperationException("Pipe is in a disconnected state.");
			}
			if (this._handle == null)
			{
				throw new InvalidOperationException("Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?");
			}
			if (this._state == PipeState.Closed || (this._handle != null && this._handle.IsClosed))
			{
				throw Error.GetPipeNotOpen();
			}
		}

		/// <summary>
		///         Проверяет, находится ли канал в подключенном состоянии для выполнения операций записи.
		///       </summary>
		// Token: 0x060019DE RID: 6622 RVA: 0x00056A24 File Offset: 0x00054C24
		protected internal void CheckWriteOperations()
		{
			if (this._state == PipeState.WaitingToConnect)
			{
				throw new InvalidOperationException("Pipe hasn't been connected yet.");
			}
			if (this._state == PipeState.Disconnected)
			{
				throw new InvalidOperationException("Pipe is in a disconnected state.");
			}
			if (this._handle == null)
			{
				throw new InvalidOperationException("Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?");
			}
			if (this._state == PipeState.Broken)
			{
				throw new IOException("Pipe is broken.");
			}
			if (this._state == PipeState.Closed || (this._handle != null && this._handle.IsClosed))
			{
				throw Error.GetPipeNotOpen();
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x00056AA3 File Offset: 0x00054CA3
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x00056AAB File Offset: 0x00054CAB
		internal PipeState State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00056AB4 File Offset: 0x00054CB4
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x00056ABC File Offset: 0x00054CBC
		internal bool IsCurrentUserOnly
		{
			get
			{
				return this._isCurrentUserOnly;
			}
			set
			{
				this._isCurrentUserOnly = value;
			}
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.IO.Pipes.PipeSecurity" />, который инкапсулирует записи списка управления доступом (ACL) для канала, описываемого текущим объектом <see cref="T:System.IO.Pipes.PipeStream" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.IO.Pipes.PipeSecurity" />, который инкапсулирует записи списка управления доступом (ACL) для канала, описываемого текущим объектом <see cref="T:System.IO.Pipes.PipeStream" />.
		///       </returns>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Не удалось выполнить базовый вызов для установки сведений о безопасности.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Не удалось выполнить базовый вызов для установки сведений о безопасности.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Не удалось выполнить базовый вызов для установки сведений о безопасности.
		///           </exception>
		// Token: 0x060019E3 RID: 6627 RVA: 0x00056AC5 File Offset: 0x00054CC5
		public PipeSecurity GetAccessControl()
		{
			if (this.State == PipeState.Closed)
			{
				throw Error.GetPipeNotOpen();
			}
			return new PipeSecurity(this.SafePipeHandle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>
		///         Применяет записи списка управления доступом (ACL), заданные объектом <see cref="T:System.IO.Pipes.PipeSecurity" />, к каналу, заданному текущим объектом <see cref="T:System.IO.Pipes.PipeStream" />.
		///       </summary>
		/// <param name="pipeSecurity">
		///           Объект <see cref="T:System.IO.Pipes.PipeSecurity" />, задающий запись списка управления доступом (ACL), которую следует применить к текущему каналу.
		///         </param>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeSecurity" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Не удалось выполнить базовый вызов для установки сведений о безопасности.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Не удалось выполнить базовый вызов для установки сведений о безопасности.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Не удалось выполнить базовый вызов для установки сведений о безопасности.
		///           </exception>
		// Token: 0x060019E4 RID: 6628 RVA: 0x00056AE3 File Offset: 0x00054CE3
		public void SetAccessControl(PipeSecurity pipeSecurity)
		{
			if (pipeSecurity == null)
			{
				throw new ArgumentNullException("pipeSecurity");
			}
			this.CheckPipePropertyOperations();
			pipeSecurity.Persist(this.SafePipeHandle);
		}

		// Token: 0x04000C56 RID: 3158
		internal const bool CheckOperationsRequiresSetHandle = true;

		// Token: 0x04000C57 RID: 3159
		internal ThreadPoolBoundHandle _threadPoolBinding;

		// Token: 0x04000C58 RID: 3160
		internal const string AnonymousPipeName = "anonymous";

		// Token: 0x04000C59 RID: 3161
		private static readonly Task<int> s_zeroTask = Task.FromResult<int>(0);

		// Token: 0x04000C5A RID: 3162
		private SafePipeHandle _handle;

		// Token: 0x04000C5B RID: 3163
		private bool _canRead;

		// Token: 0x04000C5C RID: 3164
		private bool _canWrite;

		// Token: 0x04000C5D RID: 3165
		private bool _isAsync;

		// Token: 0x04000C5E RID: 3166
		private bool _isCurrentUserOnly;

		// Token: 0x04000C5F RID: 3167
		private bool _isMessageComplete;

		// Token: 0x04000C60 RID: 3168
		private bool _isFromExistingHandle;

		// Token: 0x04000C61 RID: 3169
		private bool _isHandleExposed;

		// Token: 0x04000C62 RID: 3170
		private PipeTransmissionMode _readMode;

		// Token: 0x04000C63 RID: 3171
		private PipeTransmissionMode _transmissionMode;

		// Token: 0x04000C64 RID: 3172
		private PipeDirection _pipeDirection;

		// Token: 0x04000C65 RID: 3173
		private int _outBufferSize;

		// Token: 0x04000C66 RID: 3174
		private PipeState _state;
	}
}
