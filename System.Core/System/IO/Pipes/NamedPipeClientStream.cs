using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>
	///         Предоставляет <see cref="T:System.IO.Stream" /> вокруг именованного канала, поддерживающий синхронные и асинхронные операции чтения и записи.
	///       </summary>
	// Token: 0x02000341 RID: 833
	public sealed class NamedPipeClientStream : PipeStream
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x000547DC File Offset: 0x000529DC
		private bool TryConnect(int timeout, CancellationToken cancellationToken)
		{
			Interop.Kernel32.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(this._inheritability);
			int num = (int)(this._pipeOptions & ~PipeOptions.CurrentUserOnly);
			if (this._impersonationLevel != TokenImpersonationLevel.None)
			{
				num |= 1048576;
				num |= this._impersonationLevel - TokenImpersonationLevel.Anonymous << 16;
			}
			int num2 = this._access;
			if ((PipeDirection.In & this._direction) != (PipeDirection)0)
			{
				num2 |= int.MinValue;
			}
			if ((PipeDirection.Out & this._direction) != (PipeDirection)0)
			{
				num2 |= 1073741824;
			}
			SafePipeHandle safePipeHandle = Interop.Kernel32.CreateNamedPipeClient(this._normalizedPipePath, num2, FileShare.None, ref secAttrs, FileMode.Open, num, IntPtr.Zero);
			if (safePipeHandle.IsInvalid)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 231 && lastWin32Error != 2)
				{
					throw Win32Marshal.GetExceptionForWin32Error(lastWin32Error, "");
				}
				if (!Interop.Kernel32.WaitNamedPipe(this._normalizedPipePath, timeout))
				{
					lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 2 || lastWin32Error == 121)
					{
						return false;
					}
					throw Win32Marshal.GetExceptionForWin32Error(lastWin32Error, "");
				}
				else
				{
					safePipeHandle = Interop.Kernel32.CreateNamedPipeClient(this._normalizedPipePath, num2, FileShare.None, ref secAttrs, FileMode.Open, num, IntPtr.Zero);
					if (safePipeHandle.IsInvalid)
					{
						lastWin32Error = Marshal.GetLastWin32Error();
						if (lastWin32Error == 231)
						{
							return false;
						}
						throw Win32Marshal.GetExceptionForWin32Error(lastWin32Error, "");
					}
				}
			}
			base.InitializeHandle(safePipeHandle, false, (this._pipeOptions & PipeOptions.Asynchronous) > PipeOptions.None);
			base.State = PipeState.Connected;
			this.ValidateRemotePipeUser();
			return true;
		}

		/// <summary>
		///         Получает число экземпляров сервера с одинаковым именем канала.
		///       </summary>
		/// <returns>
		///         Число экземпляров сервера с одинаковым именем канала.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Дескриптор канала не был задан.
		///
		///             -или-
		///
		///             Текущий <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> объект еще не подключались к <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> объекта.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Канал разорван или возникла ошибка ввода-вывода.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Основной дескриптор канала закрыт.
		///           </exception>
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x00054924 File Offset: 0x00052B24
		public int NumberOfServerInstances
		{
			get
			{
				this.CheckPipePropertyOperations();
				int result;
				if (!Interop.Kernel32.GetNamedPipeHandleState(base.InternalHandle, IntPtr.Zero, out result, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 0))
				{
					throw base.WinIOError(Marshal.GetLastWin32Error());
				}
				return result;
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00054968 File Offset: 0x00052B68
		private void ValidateRemotePipeUser()
		{
			if (!base.IsCurrentUserOnly)
			{
				return;
			}
			IdentityReference owner = base.GetAccessControl().GetOwner(typeof(SecurityIdentifier));
			using (WindowsIdentity current = WindowsIdentity.GetCurrent())
			{
				SecurityIdentifier owner2 = current.Owner;
				if (owner != owner2)
				{
					base.State = PipeState.Closed;
					throw new UnauthorizedAccessException("Could not connect to the pipe because it was not owned by the current user.");
				}
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> класса с заданным именем канала.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="pipeName" /> имеет значение «anonymous».
		///           </exception>
		// Token: 0x0600193B RID: 6459 RVA: 0x000549D8 File Offset: 0x00052BD8
		public NamedPipeClientStream(string pipeName) : this(".", pipeName, PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> класса с заданными именами канала и сервера.
		///       </summary>
		/// <param name="serverName">
		///           Имя удаленного компьютера, к которому нужно подключиться, или значение ".", чтобы указать локальный компьютер.
		///         </param>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="pipeName" /> или <paramref name="serverName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> или <paramref name="serverName" /> является строкой нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="pipeName" /> имеет значение «anonymous».
		///           </exception>
		// Token: 0x0600193C RID: 6460 RVA: 0x000549EA File Offset: 0x00052BEA
		public NamedPipeClientStream(string serverName, string pipeName) : this(serverName, pipeName, PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> класса с заданными именами канала и сервера и указанным направлением канала.
		///       </summary>
		/// <param name="serverName">
		///           Имя удаленного компьютера, к которому нужно подключиться, или значение ".", чтобы указать локальный компьютер.
		///         </param>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="pipeName" /> или <paramref name="serverName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> или <paramref name="serverName" /> является строкой нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="pipeName" /> имеет значение «anonymous».
		///
		///             -или-
		///
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///           </exception>
		// Token: 0x0600193D RID: 6461 RVA: 0x000549F8 File Offset: 0x00052BF8
		public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction) : this(serverName, pipeName, direction, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> класса с заданными именами канала и сервера, направлением канала и параметрами канала.
		///       </summary>
		/// <param name="serverName">
		///           Имя удаленного компьютера, к которому нужно подключиться, или значение ".", чтобы указать локальный компьютер.
		///         </param>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="pipeName" /> или <paramref name="serverName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> или <paramref name="serverName" /> является строкой нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="pipeName" /> имеет значение «anonymous».
		///
		///             -или-
		///
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///           </exception>
		// Token: 0x0600193E RID: 6462 RVA: 0x00054A06 File Offset: 0x00052C06
		public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options) : this(serverName, pipeName, direction, options, TokenImpersonationLevel.None, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> класса с заданными именами канала и сервера и указанным направлением канала, параметрами канала и уровнем олицетворения безопасности.
		///       </summary>
		/// <param name="serverName">
		///           Имя удаленного компьютера, к которому нужно подключиться, или значение ".", чтобы указать локальный компьютер.
		///         </param>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <param name="impersonationLevel">
		///           Одно из значений перечисления, определяющее уровень олицетворения безопасности.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="pipeName" /> или <paramref name="serverName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> или <paramref name="serverName" /> является строкой нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="pipeName" /> имеет значение «anonymous».
		///
		///             -или-
		///
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///
		///             -или-
		///
		///             <paramref name="impersonationLevel" /> не является допустимым значением <see cref="T:System.Security.Principal.TokenImpersonationLevel" />.
		///           </exception>
		// Token: 0x0600193F RID: 6463 RVA: 0x00054A15 File Offset: 0x00052C15
		public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel) : this(serverName, pipeName, direction, options, impersonationLevel, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> класса с заданными именами канала и сервера и указанным направлением канала, параметрами канала, уровнем олицетворения безопасности и режимом.
		///       </summary>
		/// <param name="serverName">
		///           Имя удаленного компьютера, к которому нужно подключиться, или значение ".", чтобы указать локальный компьютер.
		///         </param>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <param name="impersonationLevel">
		///           Одно из значений перечисления, определяющее уровень олицетворения безопасности.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, будет ли базовый дескриптор наследоваться дочерними процессами.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="pipeName" /> или <paramref name="serverName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> или <paramref name="serverName" /> является строкой нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="pipeName" /> имеет значение «anonymous».
		///
		///             -или-
		///
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///
		///             -или-
		///
		///             <paramref name="impersonationLevel" /> не является допустимым значением <see cref="T:System.Security.Principal.TokenImpersonationLevel" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым значением <see cref="T:System.IO.HandleInheritability" />.
		///           </exception>
		// Token: 0x06001940 RID: 6464 RVA: 0x00054A28 File Offset: 0x00052C28
		public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability) : base(direction, 0)
		{
			if (pipeName == null)
			{
				throw new ArgumentNullException("pipeName");
			}
			if (serverName == null)
			{
				throw new ArgumentNullException("serverName", "serverName cannot be null. Use \\\".\\\" for current machine.");
			}
			if (pipeName.Length == 0)
			{
				throw new ArgumentException("pipeName cannot be an empty string.");
			}
			if (serverName.Length == 0)
			{
				throw new ArgumentException("serverName cannot be an empty string.  Use \\\\\\\".\\\\\\\" for current machine.");
			}
			if ((options & (PipeOptions)536870911) != PipeOptions.None)
			{
				throw new ArgumentOutOfRangeException("options", "options contains an invalid flag.");
			}
			if (impersonationLevel < TokenImpersonationLevel.None || impersonationLevel > TokenImpersonationLevel.Delegation)
			{
				throw new ArgumentOutOfRangeException("impersonationLevel", "TokenImpersonationLevel.None, TokenImpersonationLevel.Anonymous, TokenImpersonationLevel.Identification, TokenImpersonationLevel.Impersonation or TokenImpersonationLevel.Delegation required.");
			}
			if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
			{
				throw new ArgumentOutOfRangeException("inheritability", "HandleInheritability.None or HandleInheritability.Inheritable required.");
			}
			if ((options & PipeOptions.CurrentUserOnly) != PipeOptions.None)
			{
				base.IsCurrentUserOnly = true;
			}
			this._normalizedPipePath = PipeStream.GetPipePath(serverName, pipeName);
			this._direction = direction;
			this._inheritability = inheritability;
			this._impersonationLevel = impersonationLevel;
			this._pipeOptions = options;
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> класс для указанного дескриптора канала с указанным направлением канала.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="isAsync">
		///           Значение <see langword="true" />, если дескриптор открыт асинхронно; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <param name="isConnected">
		///           <see langword="true" /> Чтобы указать, что канал подключен; в противном случае — <see langword="false" />.
		///         </param>
		/// <param name="safePipeHandle">
		///           Безопасный дескриптор для канала, который <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> инкапсулируется объектом.
		///         </param>
		/// <exception cref="T:System.IO.IOException">
		///             <paramref name="safePipeHandle" /> не является допустимым дескриптором.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="safePipeHandle" /> не является допустимым дескриптором.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="safePipeHandle" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Поток закрыт.
		///           </exception>
		// Token: 0x06001941 RID: 6465 RVA: 0x00054B10 File Offset: 0x00052D10
		public NamedPipeClientStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle) : base(direction, 0)
		{
			if (safePipeHandle == null)
			{
				throw new ArgumentNullException("safePipeHandle");
			}
			if (safePipeHandle.IsInvalid)
			{
				throw new ArgumentException("Invalid handle.", "safePipeHandle");
			}
			base.ValidateHandleIsPipe(safePipeHandle);
			base.InitializeHandle(safePipeHandle, true, isAsync);
			if (isConnected)
			{
				base.State = PipeState.Connected;
			}
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы и выполняет другие операции очистки перед <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> экземпляр будет утилизирован во время сборки мусора.
		///       </summary>
		// Token: 0x06001942 RID: 6466 RVA: 0x00054B6C File Offset: 0x00052D6C
		~NamedPipeClientStream()
		{
			this.Dispose(false);
		}

		/// <summary>
		///         Подключается к ожидающему серверу с бесконечным значением тайм-аута.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Клиент уже подключен.
		///           </exception>
		// Token: 0x06001943 RID: 6467 RVA: 0x00054B9C File Offset: 0x00052D9C
		public void Connect()
		{
			this.Connect(-1);
		}

		/// <summary>
		///         Устанавливает подключение к ожидающему серверу в рамках заданного периода ожидания.
		///       </summary>
		/// <param name="timeout">
		///           Количество миллисекунд, определяющее время ожидания соединения с сервером.
		///         </param>
		/// <exception cref="T:System.TimeoutException">
		///             Не удалось подключиться к серверу в указанном <paramref name="timeout" /> период.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="timeout" /> меньше 0 и не задано значение <see cref="F:System.Threading.Timeout.Infinite" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Клиент уже подключен.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Данный сервер подключен к другому клиенту и истечения времени ожидания.
		///           </exception>
		// Token: 0x06001944 RID: 6468 RVA: 0x00054BA5 File Offset: 0x00052DA5
		public void Connect(int timeout)
		{
			this.CheckConnectOperationsClient();
			if (timeout < 0 && timeout != -1)
			{
				throw new ArgumentOutOfRangeException("timeout", "Timeout must be non-negative or equal to -1 (Timeout.Infinite)");
			}
			this.ConnectInternal(timeout, CancellationToken.None, Environment.TickCount);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00054BD8 File Offset: 0x00052DD8
		private void ConnectInternal(int timeout, CancellationToken cancellationToken, int startTime)
		{
			int num = 0;
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				cancellationToken.ThrowIfCancellationRequested();
				int num2 = timeout - num;
				if (cancellationToken.CanBeCanceled && num2 > 50)
				{
					num2 = 50;
				}
				if (this.TryConnect(num2, cancellationToken))
				{
					break;
				}
				spinWait.SpinOnce();
				if (timeout != -1 && (num = Environment.TickCount - startTime) >= timeout)
				{
					goto Block_5;
				}
			}
			return;
			Block_5:
			throw new TimeoutException();
		}

		/// <summary>
		///         Асинхронно подключается к ожидающему серверу с бесконечным периодом тайм-аута.
		///       </summary>
		/// <returns>
		///         Задача, представляющая асинхронную операцию подключения.
		///       </returns>
		// Token: 0x06001946 RID: 6470 RVA: 0x00054C32 File Offset: 0x00052E32
		public Task ConnectAsync()
		{
			return this.ConnectAsync(-1, CancellationToken.None);
		}

		/// <summary>
		///         Асинхронно подключается к ожидающему серверу с указанным периодом тайм-аута.
		///       </summary>
		/// <param name="timeout">
		///           Количество миллисекунд, определяющее время ожидания соединения с сервером.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную операцию подключения.
		///       </returns>
		// Token: 0x06001947 RID: 6471 RVA: 0x00054C40 File Offset: 0x00052E40
		public Task ConnectAsync(int timeout)
		{
			return this.ConnectAsync(timeout, CancellationToken.None);
		}

		/// <summary>
		///         Асинхронно подключается к ожидающему серверу и отслеживает запросы отмены.
		///       </summary>
		/// <param name="cancellationToken">
		///           Токен для отслеживания запросов отмены.
		///            Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную операцию подключения.
		///       </returns>
		// Token: 0x06001948 RID: 6472 RVA: 0x00054C4E File Offset: 0x00052E4E
		public Task ConnectAsync(CancellationToken cancellationToken)
		{
			return this.ConnectAsync(-1, cancellationToken);
		}

		/// <summary>
		///         Асинхронно подключается к ожидающему серверу с указанным периодом тайм-аута и отслеживает запросы отмены.
		///       </summary>
		/// <param name="timeout">
		///           Количество миллисекунд, определяющее время ожидания соединения с сервером.
		///         </param>
		/// <param name="cancellationToken">
		///           Токен для отслеживания запросов отмены.
		///            Значение по умолчанию — <see cref="P:System.Threading.CancellationToken.None" />.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную операцию подключения.
		///       </returns>
		// Token: 0x06001949 RID: 6473 RVA: 0x00054C58 File Offset: 0x00052E58
		public Task ConnectAsync(int timeout, CancellationToken cancellationToken)
		{
			this.CheckConnectOperationsClient();
			if (timeout < 0 && timeout != -1)
			{
				throw new ArgumentOutOfRangeException("timeout", "Timeout must be non-negative or equal to -1 (Timeout.Infinite)");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			int startTime = Environment.TickCount;
			return Task.Run(delegate()
			{
				this.ConnectInternal(timeout, cancellationToken, startTime);
			}, cancellationToken);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00054CE3 File Offset: 0x00052EE3
		protected internal override void CheckPipePropertyOperations()
		{
			base.CheckPipePropertyOperations();
			if (base.State == PipeState.WaitingToConnect)
			{
				throw new InvalidOperationException("Pipe hasn't been connected yet.");
			}
			if (base.State == PipeState.Broken)
			{
				throw new IOException("Pipe is broken.");
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00054D12 File Offset: 0x00052F12
		private void CheckConnectOperationsClient()
		{
			if (base.State == PipeState.Connected)
			{
				throw new InvalidOperationException("Already in a connected state.");
			}
			if (base.State == PipeState.Closed)
			{
				throw Error.GetPipeNotOpen();
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeClientStream" /> класса с заданными именами канала и сервера и параметрами канала, уровнем олицетворения безопасности и режимом.
		///       </summary>
		/// <param name="serverName">
		///           Имя удаленного компьютера, к которому нужно подключиться, или значение ".", чтобы указать локальный компьютер.
		///         </param>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="desiredAccessRights">
		///           Одно из значений перечисления, задающее требуемые права доступа для канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <param name="impersonationLevel">
		///           Одно из значений перечисления, определяющее уровень олицетворения безопасности.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, будет ли базовый дескриптор наследоваться дочерними процессами.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="pipeName" /> или <paramref name="serverName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> или <paramref name="serverName" /> является строкой нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="pipeName" /> имеет значение «anonymous».
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///
		///             -или-
		///
		///             <paramref name="impersonationLevel" /> не является допустимым значением <see cref="T:System.Security.Principal.TokenImpersonationLevel" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым значением <see cref="T:System.IO.HandleInheritability" />.
		///           </exception>
		// Token: 0x0600194C RID: 6476 RVA: 0x00054D37 File Offset: 0x00052F37
		public NamedPipeClientStream(string serverName, string pipeName, PipeAccessRights desiredAccessRights, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability) : this(serverName, pipeName, (PipeDirection)(desiredAccessRights & (PipeAccessRights.ReadData | PipeAccessRights.WriteData)), options, impersonationLevel, inheritability)
		{
			if ((desiredAccessRights & ~(PipeAccessRights.ReadData | PipeAccessRights.WriteData | PipeAccessRights.ReadAttributes | PipeAccessRights.WriteAttributes | PipeAccessRights.ReadExtendedAttributes | PipeAccessRights.WriteExtendedAttributes | PipeAccessRights.CreateNewInstance | PipeAccessRights.Delete | PipeAccessRights.ReadPermissions | PipeAccessRights.ChangePermissions | PipeAccessRights.TakeOwnership | PipeAccessRights.Synchronize | PipeAccessRights.AccessSystemSecurity)) != (PipeAccessRights)0)
			{
				throw new ArgumentOutOfRangeException("desiredAccessRights", "Invalid PipeAccessRights flag.");
			}
			this._access = (int)desiredAccessRights;
		}

		// Token: 0x04000C12 RID: 3090
		private const int CancellationCheckInterval = 50;

		// Token: 0x04000C13 RID: 3091
		private readonly string _normalizedPipePath;

		// Token: 0x04000C14 RID: 3092
		private readonly TokenImpersonationLevel _impersonationLevel;

		// Token: 0x04000C15 RID: 3093
		private readonly PipeOptions _pipeOptions;

		// Token: 0x04000C16 RID: 3094
		private readonly HandleInheritability _inheritability;

		// Token: 0x04000C17 RID: 3095
		private readonly PipeDirection _direction;

		// Token: 0x04000C18 RID: 3096
		private int _access;
	}
}
