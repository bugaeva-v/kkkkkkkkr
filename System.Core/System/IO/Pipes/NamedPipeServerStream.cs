using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>
	///         Предоставляет <see cref="T:System.IO.Stream" /> в именованном канале, поддерживая синхронные и асинхронные чтения и записи операций.
	///       </summary>
	// Token: 0x02000343 RID: 835
	public sealed class NamedPipeServerStream : PipeStream
	{
		// Token: 0x0600194F RID: 6479 RVA: 0x00054D8C File Offset: 0x00052F8C
		private void Create(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, HandleInheritability inheritability)
		{
			this.Create(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, null, inheritability, (PipeAccessRights)0);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00054DB0 File Offset: 0x00052FB0
		private void Create(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability, PipeAccessRights additionalAccessRights)
		{
			string fullPath = Path.GetFullPath("\\\\.\\pipe\\" + pipeName);
			if (string.Equals(fullPath, "\\\\.\\pipe\\anonymous", StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentOutOfRangeException("pipeName", "The pipeName \\\"anonymous\\\" is reserved.");
			}
			if (base.IsCurrentUserOnly)
			{
				using (WindowsIdentity current = WindowsIdentity.GetCurrent())
				{
					SecurityIdentifier owner = current.Owner;
					PipeAccessRule rule = new PipeAccessRule(owner, PipeAccessRights.FullControl, AccessControlType.Allow);
					pipeSecurity = new PipeSecurity();
					pipeSecurity.AddAccessRule(rule);
					pipeSecurity.SetOwner(owner);
				}
				options &= ~PipeOptions.CurrentUserOnly;
			}
			int openMode = (int)(direction | ((maxNumberOfServerInstances == 1) ? ((PipeDirection)524288) : ((PipeDirection)0)) | (PipeDirection)options | (PipeDirection)additionalAccessRights);
			int pipeMode = (int)((int)transmissionMode << 2 | (int)transmissionMode << 1);
			if (maxNumberOfServerInstances == -1)
			{
				maxNumberOfServerInstances = 255;
			}
			GCHandle gchandle = default(GCHandle);
			try
			{
				Interop.Kernel32.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(inheritability, pipeSecurity, ref gchandle);
				SafePipeHandle safePipeHandle = Interop.Kernel32.CreateNamedPipe(fullPath, openMode, pipeMode, maxNumberOfServerInstances, outBufferSize, inBufferSize, 0, ref secAttrs);
				if (safePipeHandle.IsInvalid)
				{
					throw Win32Marshal.GetExceptionForLastWin32Error("");
				}
				base.InitializeHandle(safePipeHandle, false, (options & PipeOptions.Asynchronous) > PipeOptions.None);
			}
			finally
			{
				if (gchandle.IsAllocated)
				{
					gchandle.Free();
				}
			}
		}

		/// <summary>
		///         Ожидает клиента для подключения к этому <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> объекта.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Подключение канала уже установлено.
		///
		///             -или-
		///
		///             Дескриптор канала не был задан.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Подключение канала разорвано.
		///           </exception>
		// Token: 0x06001951 RID: 6481 RVA: 0x00054EEC File Offset: 0x000530EC
		public void WaitForConnection()
		{
			this.CheckConnectOperationsServerWithHandle();
			if (base.IsAsync)
			{
				this.WaitForConnectionCoreAsync(CancellationToken.None).GetAwaiter().GetResult();
				return;
			}
			if (!Interop.Kernel32.ConnectNamedPipe(base.InternalHandle, IntPtr.Zero))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 535)
				{
					throw Win32Marshal.GetExceptionForWin32Error(lastWin32Error, "");
				}
				if (lastWin32Error == 535 && base.State == PipeState.Connected)
				{
					throw new InvalidOperationException("Already in a connected state.");
				}
			}
			base.State = PipeState.Connected;
		}

		/// <summary>
		///         Асинхронно ожидает подключения клиента к данному объекту <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> и отслеживает запросы отмены.
		///       </summary>
		/// <param name="cancellationToken">
		///           Токен для отслеживания запросов отмены.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную операцию ожидания.
		///       </returns>
		// Token: 0x06001952 RID: 6482 RVA: 0x00054F70 File Offset: 0x00053170
		public Task WaitForConnectionAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (!base.IsAsync)
			{
				return Task.Factory.StartNew(delegate(object s)
				{
					((NamedPipeServerStream)s).WaitForConnection();
				}, this, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			return this.WaitForConnectionCoreAsync(cancellationToken);
		}

		/// <summary>
		///         Отсоединяет текущее подключение.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Еще были сделаны подключений по каналу.
		///
		///             -или-
		///
		///             Подключенный канал уже был отключен.
		///
		///             -или-
		///
		///             Дескриптор канала не был задан.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		// Token: 0x06001953 RID: 6483 RVA: 0x00054FCE File Offset: 0x000531CE
		public void Disconnect()
		{
			this.CheckDisconnectOperations();
			if (!Interop.Kernel32.DisconnectNamedPipe(base.InternalHandle))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			base.State = PipeState.Disconnected;
		}

		/// <summary>
		///         Возвращает имя пользователя клиента на другом конце канала.
		///       </summary>
		/// <returns>
		///         Имя пользователя клиента на другом конце канала.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Еще были сделаны подключений по каналу.
		///
		///             -или-
		///
		///             Подключенный канал уже был отключен.
		///
		///             -или-
		///
		///             Дескриптор канала не был задан.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Подключение канала разорвано.
		///
		///             -или-
		///
		///             Имя пользователя клиента имеет длину более 19 знаков.
		///           </exception>
		// Token: 0x06001954 RID: 6484 RVA: 0x00054FF8 File Offset: 0x000531F8
		public string GetImpersonationUserName()
		{
			base.CheckWriteOperations();
			StringBuilder stringBuilder = new StringBuilder(514);
			if (!Interop.Kernel32.GetNamedPipeHandleState(base.InternalHandle, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Capacity))
			{
				throw base.WinIOError(Marshal.GetLastWin32Error());
			}
			return stringBuilder.ToString();
		}

		/// <summary>
		///         Вызывает делегата во время выполнения олицетворения клиента.
		///       </summary>
		/// <param name="impersonationWorker">
		///           Делегат, определяющий метод, который необходимо вызвать.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Еще были сделаны подключений по каналу.
		///
		///             -или-
		///
		///             Подключенный канал уже был отключен.
		///
		///             -или-
		///
		///             Дескриптор канала не был задан.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Подключение канала разорвано.
		///
		///             -или-
		///
		///             Ошибка ввода/вывода.
		///           </exception>
		// Token: 0x06001955 RID: 6485 RVA: 0x00055050 File Offset: 0x00053250
		public void RunAsClient(PipeStreamImpersonationWorker impersonationWorker)
		{
			base.CheckWriteOperations();
			NamedPipeServerStream.ExecuteHelper executeHelper = new NamedPipeServerStream.ExecuteHelper(impersonationWorker, base.InternalHandle);
			RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(NamedPipeServerStream.tryCode, NamedPipeServerStream.cleanupCode, executeHelper);
			if (executeHelper._impersonateErrorCode != 0)
			{
				throw base.WinIOError(executeHelper._impersonateErrorCode);
			}
			if (executeHelper._revertImpersonateErrorCode != 0)
			{
				throw base.WinIOError(executeHelper._revertImpersonateErrorCode);
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000550AC File Offset: 0x000532AC
		private static void ImpersonateAndTryCode(object helper)
		{
			NamedPipeServerStream.ExecuteHelper executeHelper = (NamedPipeServerStream.ExecuteHelper)helper;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				if (Interop.Advapi32.ImpersonateNamedPipeClient(executeHelper._handle))
				{
					executeHelper._mustRevert = true;
				}
				else
				{
					executeHelper._impersonateErrorCode = Marshal.GetLastWin32Error();
				}
			}
			if (executeHelper._mustRevert)
			{
				executeHelper._userCode();
			}
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0005510C File Offset: 0x0005330C
		private static void RevertImpersonationOnBackout(object helper, bool exceptionThrown)
		{
			NamedPipeServerStream.ExecuteHelper executeHelper = (NamedPipeServerStream.ExecuteHelper)helper;
			if (executeHelper._mustRevert && !Interop.Advapi32.RevertToSelf())
			{
				executeHelper._revertImpersonateErrorCode = Marshal.GetLastWin32Error();
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0005513C File Offset: 0x0005333C
		private Task WaitForConnectionCoreAsync(CancellationToken cancellationToken)
		{
			this.CheckConnectOperationsServerWithHandle();
			if (!base.IsAsync)
			{
				throw new InvalidOperationException("Pipe is not opened in asynchronous mode.");
			}
			ConnectionCompletionSource connectionCompletionSource = new ConnectionCompletionSource(this);
			if (!Interop.Kernel32.ConnectNamedPipe(base.InternalHandle, connectionCompletionSource.Overlapped))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 535)
				{
					if (lastWin32Error != 997)
					{
						connectionCompletionSource.ReleaseResources();
						throw Win32Marshal.GetExceptionForWin32Error(lastWin32Error, "");
					}
				}
				else
				{
					connectionCompletionSource.ReleaseResources();
					if (base.State == PipeState.Connected)
					{
						throw new InvalidOperationException("Already in a connected state.");
					}
					connectionCompletionSource.SetCompletedSynchronously();
					return Task.CompletedTask;
				}
			}
			connectionCompletionSource.RegisterForCancellation(cancellationToken);
			return connectionCompletionSource.Task;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x000551D9 File Offset: 0x000533D9
		private void CheckConnectOperationsServerWithHandle()
		{
			if (base.InternalHandle == null)
			{
				throw new InvalidOperationException("Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?");
			}
			this.CheckConnectOperationsServer();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> класса с заданным именем канала.
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
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (»:»).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Операционной системой является Windows Millennium Edition, Windows 98 или Windows 95 не поддерживаются.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x0600195A RID: 6490 RVA: 0x000551F4 File Offset: 0x000533F4
		public NamedPipeServerStream(string pipeName) : this(pipeName, PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> класса с заданным именем канала и направлением канала.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="pipeName" /> имеет значение «anonymous».
		///
		///             -или-
		///
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (»:»).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Операционной системой является Windows Millennium Edition, Windows 98 или Windows 95 не поддерживаются.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x0600195B RID: 6491 RVA: 0x00055210 File Offset: 0x00053410
		public NamedPipeServerStream(string pipeName, PipeDirection direction) : this(pipeName, direction, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> с заданными именем и направлением канала, а также максимальным количеством экземпляров сервера.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="maxNumberOfServerInstances">
		///           Максимальное число экземпляров сервера с одинаковыми именами.
		///            Для этого значения можно передать <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Для <paramref name="pipeName" /> задано значение anonymous.
		///
		///             -или-
		///
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///
		///             -или-
		///
		///             Требуется неотрицательное число.
		///
		///             -или-
		///
		///             Для параметра <paramref name="maxNumberofServerInstances" /> задано значение меньше -1 или больше 254 (значение -1 представляет собой <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />).
		///
		///             -или-
		///
		///             Требуется параметр <see cref="F:System.IO.HandleInheritability.None" /> или <see cref="F:System.IO.HandleInheritability.Inheritable" />.
		///
		///             -или-
		///
		///             Права доступа ограничены флагами <see cref="F:System.IO.Pipes.PipeAccessRights.ChangePermissions" />, <see cref="F:System.IO.Pipes.PipeAccessRights.TakeOwnership" /> и <see cref="F:System.IO.Pipes.PipeAccessRights.AccessSystemSecurity" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (":").
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Используется неподдерживаемая операционная система: Windows Millennium Edition, Windows 98 или Windows 95.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x0600195C RID: 6492 RVA: 0x0005522C File Offset: 0x0005342C
		public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances) : this(pipeName, direction, maxNumberOfServerInstances, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> класса с заданным именем канала, направлением канала, максимальным количеством экземпляров сервера и режимом передачи.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="maxNumberOfServerInstances">
		///           Максимальное число экземпляров сервера с одинаковыми именами.
		///            Можно передать <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> для этого значения.
		///         </param>
		/// <param name="transmissionMode">
		///           Одно из значений перечисления, определяющее режим передачи канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
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
		///             <paramref name="maxNumberofServerInstances" /> меньше -1 или больше, чем 254 (-1 указывает <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (»:»).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Операционной системой является Windows Millennium Edition, Windows 98 или Windows 95 не поддерживаются.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x0600195D RID: 6493 RVA: 0x00055248 File Offset: 0x00053448
		public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode) : this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, PipeOptions.None, 0, 0, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> класса с заданным именем канала, направлением канала, максимальное число экземпляров сервера, режимом передачи и параметрами канала.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="maxNumberOfServerInstances">
		///           Максимальное число экземпляров сервера с одинаковыми именами.
		///            Можно передать <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> для этого значения.
		///         </param>
		/// <param name="transmissionMode">
		///           Одно из значений перечисления, определяющее режим передачи канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
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
		///             <paramref name="maxNumberofServerInstances" /> меньше -1 или больше, чем 254 (-1 указывает <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (»:»).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Операционной системой является Windows Millennium Edition, Windows 98 или Windows 95 не поддерживаются.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x0600195E RID: 6494 RVA: 0x00055264 File Offset: 0x00053464
		public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options) : this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, 0, 0, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> класса с заданным именем канала, направлением канала, максимальное число экземпляров сервера, режимом передачи, параметрами канала и рекомендуемыми, входного и выходного буферов.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="maxNumberOfServerInstances">
		///           Максимальное число экземпляров сервера с одинаковыми именами.
		///            Можно передать <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> для этого значения.
		///         </param>
		/// <param name="transmissionMode">
		///           Одно из значений перечисления, определяющее режим передачи канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <param name="inBufferSize">
		///           Положительное значение больше 0, указывающее размер входного буфера.
		///         </param>
		/// <param name="outBufferSize">
		///           Положительное значение больше 0, указывающее размер выходного буфера.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
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
		///             <paramref name="maxNumberofServerInstances" /> меньше -1 или больше, чем 254 (-1 указывает <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///
		///             -или-
		///
		///             <paramref name="inBufferSize" /> является отрицательным значением.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (»:»).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Операционной системой является Windows Millennium Edition, Windows 98 или Windows 95 не поддерживаются.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x0600195F RID: 6495 RVA: 0x00055284 File Offset: 0x00053484
		public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize) : this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, HandleInheritability.None)
		{
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x000552A4 File Offset: 0x000534A4
		private NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, HandleInheritability inheritability) : base(direction, transmissionMode, outBufferSize)
		{
			if (pipeName == null)
			{
				throw new ArgumentNullException("pipeName");
			}
			if (pipeName.Length == 0)
			{
				throw new ArgumentException("pipeName cannot be an empty string.");
			}
			if ((options & (PipeOptions)536870911) != PipeOptions.None)
			{
				throw new ArgumentOutOfRangeException("options", "options contains an invalid flag.");
			}
			if (inBufferSize < 0)
			{
				throw new ArgumentOutOfRangeException("inBufferSize", "Non negative number is required.");
			}
			if ((maxNumberOfServerInstances < 1 || maxNumberOfServerInstances > 254) && maxNumberOfServerInstances != -1)
			{
				throw new ArgumentOutOfRangeException("maxNumberOfServerInstances", "maxNumberOfServerInstances must either be a value between 1 and 254, or NamedPipeServerStream.MaxAllowedServerInstances (to obtain the maximum number allowed by system resources).");
			}
			if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
			{
				throw new ArgumentOutOfRangeException("inheritability", "HandleInheritability.None or HandleInheritability.Inheritable required.");
			}
			if ((options & PipeOptions.CurrentUserOnly) != PipeOptions.None)
			{
				base.IsCurrentUserOnly = true;
			}
			this.Create(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, inheritability);
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> класс из указанного дескриптора канала.
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
		///           Безопасный дескриптор для канала, который <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> инкапсулируется объектом.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="direction" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeDirection" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="safePipeHandle" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="safePipeHandle" /> имеет недопустимый дескриптор.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             <paramref name="safePipeHandle" /> не допустимого дескриптора канала.
		///
		///             -или-
		///
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x06001961 RID: 6497 RVA: 0x0005536C File Offset: 0x0005356C
		public NamedPipeServerStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle) : base(direction, PipeTransmissionMode.Byte, 0)
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
		///         Освобождает неуправляемые ресурсы и выполняет другие операции очистки перед <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> экземпляр будет утилизирован во время сборки мусора.
		///       </summary>
		// Token: 0x06001962 RID: 6498 RVA: 0x000553C8 File Offset: 0x000535C8
		~NamedPipeServerStream()
		{
			this.Dispose(false);
		}

		/// <summary>
		///         Асинхронно ожидает подключения к этому клиента <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> объекта.
		///       </summary>
		/// <returns>
		///         Задача, представляющая асинхронную операцию ожидания.
		///       </returns>
		// Token: 0x06001963 RID: 6499 RVA: 0x000553F8 File Offset: 0x000535F8
		public Task WaitForConnectionAsync()
		{
			return this.WaitForConnectionAsync(CancellationToken.None);
		}

		/// <summary>
		///         Начинает асинхронную операцию ожидания подключения клиента.
		///       </summary>
		/// <param name="callback">
		///           Метод, вызываемый, когда клиент подключается к <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> объекта.
		///         </param>
		/// <param name="state">
		///           Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного асинхронного запроса от других запросов.
		///         </param>
		/// <returns>
		///         Объект, ссылающийся на асинхронный запрос.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал не был открыт асинхронно.
		///
		///             -или-
		///
		///             Подключение канала уже установлено.
		///
		///             -или-
		///
		///             Дескриптор канала не был задан.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Подключение канала разорвано.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		// Token: 0x06001964 RID: 6500 RVA: 0x00055405 File Offset: 0x00053605
		public IAsyncResult BeginWaitForConnection(AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.WaitForConnectionAsync(), callback, state);
		}

		/// <summary>
		///         Заканчивает асинхронную операцию, чтобы ждать подключения клиента.
		///       </summary>
		/// <param name="asyncResult">
		///           Отложенный асинхронный запрос.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Канал не был открыт асинхронно.
		///
		///             -или-
		///
		///             Дескриптор канала не был задан.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Подключение канала разорвано.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		// Token: 0x06001965 RID: 6501 RVA: 0x00055414 File Offset: 0x00053614
		public void EndWaitForConnection(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0005541C File Offset: 0x0005361C
		private void CheckConnectOperationsServer()
		{
			if (base.State == PipeState.Closed)
			{
				throw Error.GetPipeNotOpen();
			}
			if (base.InternalHandle != null && base.InternalHandle.IsClosed)
			{
				throw Error.GetPipeNotOpen();
			}
			if (base.State == PipeState.Broken)
			{
				throw new IOException("Pipe is broken.");
			}
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0005545C File Offset: 0x0005365C
		private void CheckDisconnectOperations()
		{
			if (base.State == PipeState.WaitingToConnect)
			{
				throw new InvalidOperationException("Pipe hasn't been connected yet.");
			}
			if (base.State == PipeState.Disconnected)
			{
				throw new InvalidOperationException("Already in a disconnected state.");
			}
			if (base.InternalHandle == null)
			{
				throw new InvalidOperationException("Pipe handle has not been set.  Did your PipeStream implementation call InitializeHandle?");
			}
			if (base.State == PipeState.Closed || (base.InternalHandle != null && base.InternalHandle.IsClosed))
			{
				throw Error.GetPipeNotOpen();
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> именем класса канала, направлением канала, максимальным количеством экземпляров сервера, режимом передачи, параметрами канала, рекомендуемыми входного и выходного буферов размеры и режимом безопасности канала.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="maxNumberOfServerInstances">
		///           Максимальное число экземпляров сервера с одинаковыми именами.
		///            Можно передать <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> для этого значения.
		///         </param>
		/// <param name="transmissionMode">
		///           Одно из значений перечисления, определяющее режим передачи канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <param name="inBufferSize">
		///           Положительное значение больше 0, указывающее размер входного буфера.
		///         </param>
		/// <param name="outBufferSize">
		///           Положительное значение больше 0, указывающее размер выходного буфера.
		///         </param>
		/// <param name="pipeSecurity">
		///           Объект, определяющий правила управления доступом и аудита безопасности для канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
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
		///             <paramref name="maxNumberofServerInstances" />  меньше -1 или больше, чем 254 (-1 указывает <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///
		///             -или-
		///
		///             <paramref name="inBufferSize" /> является отрицательным значением.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (»:»).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Операционной системой является Windows Millennium Edition, Windows 98 или Windows 95 не поддерживаются.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x06001968 RID: 6504 RVA: 0x000554C8 File Offset: 0x000536C8
		public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity) : this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, HandleInheritability.None)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> класса с заданным именем канала, направлением канала, максимальное число экземпляров сервера, режимом передачи, параметрами канала, рекомендуемыми входного и выходного буферов, безопасности канала и режимом.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="maxNumberOfServerInstances">
		///           Максимальное число экземпляров сервера с одинаковыми именами.
		///            Можно передать <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> для этого значения.
		///         </param>
		/// <param name="transmissionMode">
		///           Одно из значений перечисления, определяющее режим передачи канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <param name="inBufferSize">
		///           Положительное значение больше 0, указывающее размер входного буфера.
		///         </param>
		/// <param name="outBufferSize">
		///           Положительное значение больше 0, указывающее размер выходного буфера.
		///         </param>
		/// <param name="pipeSecurity">
		///           Объект, определяющий правила управления доступом и аудита безопасности для канала.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли базовый дескриптор наследоваться дочерними процессами.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
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
		///             <paramref name="maxNumberofServerInstances" /> меньше -1 или больше, чем 254 (-1 указывает <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///
		///             -или-
		///
		///             <paramref name="inBufferSize" /> является отрицательным значением.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым значением <see cref="T:System.IO.HandleInheritability" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (»:»).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Операционной системой является Windows Millennium Edition, Windows 98 или Windows 95 не поддерживаются.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x06001969 RID: 6505 RVA: 0x000554E8 File Offset: 0x000536E8
		public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability) : this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, inheritability)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.NamedPipeServerStream" /> именем класса канала, направлением канала, максимальным количеством экземпляров сервера, режимом передачи, параметрами канала, рекомендуемыми входного и выходного буферов размеры, безопасности канала, режимом и правами доступа к каналу.
		///       </summary>
		/// <param name="pipeName">
		///           Имя канала.
		///         </param>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///         </param>
		/// <param name="maxNumberOfServerInstances">
		///           Максимальное число экземпляров сервера с одинаковыми именами.
		///            Можно передать <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> для этого значения.
		///         </param>
		/// <param name="transmissionMode">
		///           Одно из значений перечисления, определяющее режим передачи канала.
		///         </param>
		/// <param name="options">
		///           Одно из значений перечисления, определяющее способ открытия или создания канала.
		///         </param>
		/// <param name="inBufferSize">
		///           Размер входного буфера.
		///         </param>
		/// <param name="outBufferSize">
		///           Размер выходного буфера.
		///         </param>
		/// <param name="pipeSecurity">
		///           Объект, определяющий правила управления доступом и аудита безопасности для канала.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли базовый дескриптор наследоваться дочерними процессами.
		///         </param>
		/// <param name="additionalAccessRights">
		///           Одно из значений перечисления, задающее права доступа для канала.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeName" /> представляет собой строку нулевой длины.
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
		///             <paramref name="maxNumberofServerInstances" /> меньше -1 или больше, чем 254 (-1 указывает <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)
		///
		///             -или-
		///
		///             <paramref name="options" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeOptions" />.
		///
		///             -или-
		///
		///             <paramref name="inBufferSize" /> является отрицательным значением.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым значением <see cref="T:System.IO.HandleInheritability" />.
		///
		///             -или-
		///
		///             <paramref name="additionalAccessRights" /> не является допустимым значением <see cref="T:System.IO.Pipes.PipeAccessRights" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <paramref name="pipeName" /> содержит двоеточие (»:»).
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Операционной системой является Windows Millennium Edition, Windows 98 или Windows 95 не поддерживаются.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Превышено максимальное число экземпляров сервера.
		///           </exception>
		// Token: 0x0600196A RID: 6506 RVA: 0x00055508 File Offset: 0x00053708
		public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability, PipeAccessRights additionalAccessRights) : base(direction, transmissionMode, outBufferSize)
		{
			if (pipeName == null)
			{
				throw new ArgumentNullException("pipeName");
			}
			if (pipeName.Length == 0)
			{
				throw new ArgumentException("pipeName cannot be an empty string.");
			}
			if ((options & (PipeOptions)1073741823) != PipeOptions.None)
			{
				throw new ArgumentOutOfRangeException("options", "options contains an invalid flag.");
			}
			if (inBufferSize < 0)
			{
				throw new ArgumentOutOfRangeException("inBufferSize", "Non negative number is required.");
			}
			if ((maxNumberOfServerInstances < 1 || maxNumberOfServerInstances > 254) && maxNumberOfServerInstances != -1)
			{
				throw new ArgumentOutOfRangeException("maxNumberOfServerInstances", "maxNumberOfServerInstances must either be a value between 1 and 254, or NamedPipeServerStream.MaxAllowedServerInstances (to obtain the maximum number allowed by system resources).");
			}
			if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
			{
				throw new ArgumentOutOfRangeException("inheritability", "HandleInheritability.None or HandleInheritability.Inheritable required.");
			}
			if ((additionalAccessRights & ~(PipeAccessRights.ChangePermissions | PipeAccessRights.TakeOwnership | PipeAccessRights.AccessSystemSecurity)) != (PipeAccessRights)0)
			{
				throw new ArgumentOutOfRangeException("additionalAccessRights", "additionalAccessRights is limited to the PipeAccessRights.ChangePermissions, PipeAccessRights.TakeOwnership, and PipeAccessRights.AccessSystemSecurity flags when creating NamedPipeServerStreams.");
			}
			this.Create(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, pipeSecurity, inheritability, additionalAccessRights);
		}

		// Token: 0x04000C1D RID: 3101
		private static RuntimeHelpers.TryCode tryCode = new RuntimeHelpers.TryCode(NamedPipeServerStream.ImpersonateAndTryCode);

		// Token: 0x04000C1E RID: 3102
		private static RuntimeHelpers.CleanupCode cleanupCode = new RuntimeHelpers.CleanupCode(NamedPipeServerStream.RevertImpersonationOnBackout);

		/// <summary>
		///         Представляет максимальное число экземпляров сервера, допускаемое системными ресурсами.
		///       </summary>
		// Token: 0x04000C1F RID: 3103
		public const int MaxAllowedServerInstances = -1;

		// Token: 0x02000344 RID: 836
		internal class ExecuteHelper
		{
			// Token: 0x0600196C RID: 6508 RVA: 0x000555FF File Offset: 0x000537FF
			internal ExecuteHelper(PipeStreamImpersonationWorker userCode, SafePipeHandle handle)
			{
				this._userCode = userCode;
				this._handle = handle;
			}

			// Token: 0x04000C20 RID: 3104
			internal PipeStreamImpersonationWorker _userCode;

			// Token: 0x04000C21 RID: 3105
			internal SafePipeHandle _handle;

			// Token: 0x04000C22 RID: 3106
			internal bool _mustRevert;

			// Token: 0x04000C23 RID: 3107
			internal int _impersonateErrorCode;

			// Token: 0x04000C24 RID: 3108
			internal int _revertImpersonateErrorCode;
		}
	}
}
