using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>
	///         Предоставляет поток для анонимного канала, поддерживающий синхронные и асинхронные операции чтения и записи.
	///       </summary>
	// Token: 0x0200033E RID: 830
	public sealed class AnonymousPipeServerStream : PipeStream
	{
		// Token: 0x06001924 RID: 6436 RVA: 0x00054483 File Offset: 0x00052683
		private void Create(PipeDirection direction, HandleInheritability inheritability, int bufferSize)
		{
			this.Create(direction, inheritability, bufferSize, null);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00054490 File Offset: 0x00052690
		private void Create(PipeDirection direction, HandleInheritability inheritability, int bufferSize, PipeSecurity pipeSecurity)
		{
			GCHandle gchandle = default(GCHandle);
			SafePipeHandle safePipeHandle;
			bool flag;
			try
			{
				Interop.Kernel32.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(inheritability, pipeSecurity, ref gchandle);
				if (direction == PipeDirection.In)
				{
					flag = Interop.Kernel32.CreatePipe(out safePipeHandle, out this._clientHandle, ref secAttrs, bufferSize);
				}
				else
				{
					flag = Interop.Kernel32.CreatePipe(out this._clientHandle, out safePipeHandle, ref secAttrs, bufferSize);
				}
			}
			finally
			{
				if (gchandle.IsAllocated)
				{
					gchandle.Free();
				}
			}
			if (!flag)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			SafePipeHandle handle;
			flag = Interop.Kernel32.DuplicateHandle(Interop.Kernel32.GetCurrentProcess(), safePipeHandle, Interop.Kernel32.GetCurrentProcess(), out handle, 0U, false, 2U);
			if (!flag)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			safePipeHandle.Dispose();
			base.InitializeHandle(handle, false, false);
			base.State = PipeState.Connected;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" />.
		///       </summary>
		// Token: 0x06001926 RID: 6438 RVA: 0x00054544 File Offset: 0x00052744
		public AnonymousPipeServerStream() : this(PipeDirection.Out, HandleInheritability.None, 0)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> класса с указанным направлением канала.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///
		///           Анонимные каналы можно только в одном направлении, поэтому <paramref name="direction" /> нельзя установить равным <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///         </param>
		/// <exception cref="T:System.NotSupportedException">
		///             Параметру <paramref name="direction" /> задается значение <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///           </exception>
		// Token: 0x06001927 RID: 6439 RVA: 0x0005454F File Offset: 0x0005274F
		public AnonymousPipeServerStream(PipeDirection direction) : this(direction, HandleInheritability.None, 0)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> класса с режимом указанный канал направлением и режимом наследования.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///
		///           Анонимные каналы можно только в одном направлении, поэтому <paramref name="direction" /> нельзя установить равным <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли базовый дескриптор наследоваться дочерними процессами.
		///            Необходимо указать либо <see cref="F:System.IO.HandleInheritability.None" /> или <see cref="F:System.IO.HandleInheritability.Inheritable" />.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="inheritability" /> не установлено значение <see cref="F:System.IO.HandleInheritability.None" /> или <see cref="F:System.IO.HandleInheritability.Inheritable" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Параметру <paramref name="direction" /> задается значение <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///           </exception>
		// Token: 0x06001928 RID: 6440 RVA: 0x0005455A File Offset: 0x0005275A
		public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability) : this(direction, inheritability, 0)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> класс из дескрипторов указанный канал.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///
		///           Анонимные каналы можно только в одном направлении, поэтому <paramref name="direction" /> нельзя установить равным <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///         </param>
		/// <param name="serverSafePipeHandle">
		///           Безопасный дескриптор для канала, который <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> инкапсулируется объектом.
		///         </param>
		/// <param name="clientSafePipeHandle">
		///           Безопасный дескриптор для <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> объекта.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="serverSafePipeHandle" /> или <paramref name="clientSafePipeHandle" /> неправильный дескриптор.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="serverSafePipeHandle" /> или <paramref name="clientSafePipeHandle" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Параметру <paramref name="direction" /> задается значение <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Произошла ошибка ввода-вывода, например ошибка диска.
		///
		///             -или-
		///
		///             Поток закрыт.
		///           </exception>
		// Token: 0x06001929 RID: 6441 RVA: 0x00054568 File Offset: 0x00052768
		public AnonymousPipeServerStream(PipeDirection direction, SafePipeHandle serverSafePipeHandle, SafePipeHandle clientSafePipeHandle) : base(direction, 0)
		{
			if (direction == PipeDirection.InOut)
			{
				throw new NotSupportedException("Anonymous pipes can only be in one direction.");
			}
			if (serverSafePipeHandle == null)
			{
				throw new ArgumentNullException("serverSafePipeHandle");
			}
			if (clientSafePipeHandle == null)
			{
				throw new ArgumentNullException("clientSafePipeHandle");
			}
			if (serverSafePipeHandle.IsInvalid)
			{
				throw new ArgumentException("Invalid handle.", "serverSafePipeHandle");
			}
			if (clientSafePipeHandle.IsInvalid)
			{
				throw new ArgumentException("Invalid handle.", "clientSafePipeHandle");
			}
			base.ValidateHandleIsPipe(serverSafePipeHandle);
			base.ValidateHandleIsPipe(clientSafePipeHandle);
			base.InitializeHandle(serverSafePipeHandle, true, false);
			this._clientHandle = clientSafePipeHandle;
			this._clientHandleExposed = true;
			base.State = PipeState.Connected;
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> класса с указанным направлением канала, режимом и размер буфера.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///
		///           Анонимные каналы можно только в одном направлении, поэтому <paramref name="direction" /> нельзя установить равным <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли базовый дескриптор наследоваться дочерними процессами.
		///            Необходимо указать либо <see cref="F:System.IO.HandleInheritability.None" /> или <see cref="F:System.IO.HandleInheritability.Inheritable" />.
		///         </param>
		/// <param name="bufferSize">
		///           Размер буфера.
		///            Это значение должно быть больше или равно 0.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="inheritability" /> не установлено значение <see cref="F:System.IO.HandleInheritability.None" /> или <see cref="F:System.IO.HandleInheritability.Inheritable" />.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="bufferSize" /> меньше 0.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Параметру <paramref name="direction" /> задается значение <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///           </exception>
		// Token: 0x0600192A RID: 6442 RVA: 0x00054604 File Offset: 0x00052804
		public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize) : base(direction, bufferSize)
		{
			if (direction == PipeDirection.InOut)
			{
				throw new NotSupportedException("Anonymous pipes can only be in one direction.");
			}
			if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
			{
				throw new ArgumentOutOfRangeException("inheritability", "HandleInheritability.None or HandleInheritability.Inheritable required.");
			}
			this.Create(direction, inheritability, bufferSize);
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы и выполняет другие операции очистки перед <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> экземпляр будет утилизирован во время сборки мусора.
		///       </summary>
		// Token: 0x0600192B RID: 6443 RVA: 0x00054640 File Offset: 0x00052840
		~AnonymousPipeServerStream()
		{
			this.Dispose(false);
		}

		/// <summary>
		///         Получает подключенный <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> дескриптором объекта в виде строки.
		///       </summary>
		/// <returns>
		///         Строка, представляющая подключенные <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> дескриптором объекта.
		///       </returns>
		// Token: 0x0600192C RID: 6444 RVA: 0x00054670 File Offset: 0x00052870
		public string GetClientHandleAsString()
		{
			this._clientHandleExposed = true;
			GC.SuppressFinalize(this._clientHandle);
			return this._clientHandle.DangerousGetHandle().ToString();
		}

		/// <summary>
		///         Возвращает безопасный дескриптор для <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> объект, который в настоящее время подключен к <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> объекта.
		///       </summary>
		/// <returns>
		///         Дескриптор для <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> объект, который в настоящее время подключен к <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> объекта.
		///       </returns>
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x000546A2 File Offset: 0x000528A2
		public SafePipeHandle ClientSafePipeHandle
		{
			get
			{
				this._clientHandleExposed = true;
				return this._clientHandle;
			}
		}

		/// <summary>
		///         Закрывает локальную копию <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> дескриптором объекта.
		///       </summary>
		// Token: 0x0600192E RID: 6446 RVA: 0x000546B1 File Offset: 0x000528B1
		public void DisposeLocalCopyOfClientHandle()
		{
			if (this._clientHandle != null && !this._clientHandle.IsClosed)
			{
				this._clientHandle.Dispose();
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000546D4 File Offset: 0x000528D4
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._clientHandleExposed && this._clientHandle != null && !this._clientHandle.IsClosed)
				{
					this._clientHandle.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>
		///         Возвращает режим передачи, поддерживаемый текущим каналом.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.IO.Pipes.PipeTransmissionMode" /> Поддерживаемый текущим каналом.
		///       </returns>
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000023D1 File Offset: 0x000005D1
		public override PipeTransmissionMode TransmissionMode
		{
			get
			{
				return PipeTransmissionMode.Byte;
			}
		}

		/// <summary>
		///         Задает режим чтения для <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> объекта.
		///          Анонимные каналы, режимом передачи необходимо <see cref="F:System.IO.Pipes.PipeTransmissionMode.Byte" />.
		///       </summary>
		/// <returns>
		///         Режим чтения для <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> объекта.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Недопустимый режим передачи.
		///              Для анонимных каналов, только <see cref="F:System.IO.Pipes.PipeTransmissionMode.Byte" /> поддерживается.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Значение свойства <see cref="F:System.IO.Pipes.PipeTransmissionMode.Message" />, который не поддерживается для анонимных каналов.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Подключение разорвано или другой ошибки ввода-вывода.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		// Token: 0x17000456 RID: 1110
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x00054454 File Offset: 0x00052654
		public override PipeTransmissionMode ReadMode
		{
			set
			{
				this.CheckPipePropertyOperations();
				if (value < PipeTransmissionMode.Byte || value > PipeTransmissionMode.Message)
				{
					throw new ArgumentOutOfRangeException("value", "For named pipes, transmission mode can be TransmissionMode.Byte or PipeTransmissionMode.Message. For anonymous pipes, transmission mode can be TransmissionMode.Byte.");
				}
				if (value == PipeTransmissionMode.Message)
				{
					throw new NotSupportedException("Anonymous pipes do not support PipeTransmissionMode.Message ReadMode.");
				}
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.AnonymousPipeServerStream" /> класса с указанным направлением канала, режимом, размером буфера и безопасности канала.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///
		///           Анонимные каналы можно только в одном направлении, поэтому <paramref name="direction" /> нельзя установить равным <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли базовый дескриптор наследоваться дочерними процессами.
		///         </param>
		/// <param name="bufferSize">
		///           Размер буфера.
		///            Это значение должно быть больше или равно 0.
		///         </param>
		/// <param name="pipeSecurity">
		///           Объект, определяющий правила управления доступом и аудита безопасности для канала.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="inheritability" /> не установлено значение <see cref="F:System.IO.HandleInheritability.None" /> или <see cref="F:System.IO.HandleInheritability.Inheritable" />.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="bufferSize" /> меньше 0.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Параметру <paramref name="direction" /> задается значение <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///           </exception>
		// Token: 0x06001932 RID: 6450 RVA: 0x00054724 File Offset: 0x00052924
		public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize, PipeSecurity pipeSecurity) : base(direction, bufferSize)
		{
			if (direction == PipeDirection.InOut)
			{
				throw new NotSupportedException("Anonymous pipes can only be in one direction.");
			}
			if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
			{
				throw new ArgumentOutOfRangeException("inheritability", "HandleInheritability.None or HandleInheritability.Inheritable required.");
			}
			this.Create(direction, inheritability, bufferSize, pipeSecurity);
		}

		// Token: 0x04000C0F RID: 3087
		private SafePipeHandle _clientHandle;

		// Token: 0x04000C10 RID: 3088
		private bool _clientHandleExposed;
	}
}
