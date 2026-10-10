using System;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>
	///         Предоставляет поток анонимного канала, поддерживающий синхронные и асинхронные операции чтения и записи на стороне клиента.
	///       </summary>
	// Token: 0x0200033D RID: 829
	public sealed class AnonymousPipeClientStream : PipeStream
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> класса заданное строковое представление дескриптора канала.
		///       </summary>
		/// <param name="pipeHandleAsString">
		///           Строка, представляющая дескриптор канала.
		///         </param>
		/// <exception cref="T:System.IO.IOException">
		///             <paramref name="pipeHandleAsString" /> не допустимого дескриптора канала.
		///           </exception>
		// Token: 0x0600191D RID: 6429 RVA: 0x00054331 File Offset: 0x00052531
		public AnonymousPipeClientStream(string pipeHandleAsString) : this(PipeDirection.In, pipeHandleAsString)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> с указанным направлением канала и строковое представление дескриптора канала.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///
		///           Анонимные каналы можно только в одном направлении, поэтому <paramref name="direction" /> нельзя установить равным <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///         </param>
		/// <param name="pipeHandleAsString">
		///           Строка, представляющая дескриптор канала.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="pipeHandleAsString" /> имеет недопустимый дескриптор.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="pipeHandleAsString" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Параметру <paramref name="direction" /> задается значение <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///           </exception>
		// Token: 0x0600191E RID: 6430 RVA: 0x0005433C File Offset: 0x0005253C
		public AnonymousPipeClientStream(PipeDirection direction, string pipeHandleAsString) : base(direction, 0)
		{
			if (direction == PipeDirection.InOut)
			{
				throw new NotSupportedException("Anonymous pipes can only be in one direction.");
			}
			if (pipeHandleAsString == null)
			{
				throw new ArgumentNullException("pipeHandleAsString");
			}
			long value = 0L;
			if (!long.TryParse(pipeHandleAsString, out value))
			{
				throw new ArgumentException("Invalid handle.", "pipeHandleAsString");
			}
			SafePipeHandle safePipeHandle = new SafePipeHandle((IntPtr)value, true);
			if (safePipeHandle.IsInvalid)
			{
				throw new ArgumentException("Invalid handle.", "pipeHandleAsString");
			}
			this.Init(direction, safePipeHandle);
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> класс из указанного дескриптора.
		///       </summary>
		/// <param name="direction">
		///           Одно из значений перечисления, определяющее направление канала.
		///
		///           Анонимные каналы можно только в одном направлении, поэтому <paramref name="direction" /> нельзя установить равным <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.
		///         </param>
		/// <param name="safePipeHandle">
		///           Безопасный дескриптор для канала, который <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> инкапсулируется объектом.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="safePipeHandle " />не является допустимым дескриптором.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="safePipeHandle" /> имеет значение <see langword="null" />.
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
		// Token: 0x0600191F RID: 6431 RVA: 0x000543B8 File Offset: 0x000525B8
		public AnonymousPipeClientStream(PipeDirection direction, SafePipeHandle safePipeHandle) : base(direction, 0)
		{
			if (direction == PipeDirection.InOut)
			{
				throw new NotSupportedException("Anonymous pipes can only be in one direction.");
			}
			if (safePipeHandle == null)
			{
				throw new ArgumentNullException("safePipeHandle");
			}
			if (safePipeHandle.IsInvalid)
			{
				throw new ArgumentException("Invalid handle.", "safePipeHandle");
			}
			this.Init(direction, safePipeHandle);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0005440A File Offset: 0x0005260A
		private void Init(PipeDirection direction, SafePipeHandle safePipeHandle)
		{
			base.ValidateHandleIsPipe(safePipeHandle);
			base.InitializeHandle(safePipeHandle, true, false);
			base.State = PipeState.Connected;
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы и выполняет другие операции очистки перед <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> экземпляр будет утилизирован во время сборки мусора.
		///       </summary>
		// Token: 0x06001921 RID: 6433 RVA: 0x00054424 File Offset: 0x00052624
		~AnonymousPipeClientStream()
		{
			this.Dispose(false);
		}

		/// <summary>
		///         Возвращает режим передачи, поддерживаемый текущим каналом.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.IO.Pipes.PipeTransmissionMode" /> Поддерживаемый текущим каналом.
		///       </returns>
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x000023D1 File Offset: 0x000005D1
		public override PipeTransmissionMode TransmissionMode
		{
			get
			{
				return PipeTransmissionMode.Byte;
			}
		}

		/// <summary>
		///         Задает режим чтения для <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> объекта.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.IO.Pipes.PipeTransmissionMode" /> Для <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> объектов.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Недопустимый режим передачи.
		///              Для анонимных каналов, только <see cref="F:System.IO.Pipes.PipeTransmissionMode.Byte" /> поддерживается.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Режим передачи <see cref="F:System.IO.Pipes.PipeTransmissionMode.Message" />.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Подключение разорвано или другой ошибки ввода-вывода.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Канал закрыт.
		///           </exception>
		// Token: 0x17000453 RID: 1107
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x00054454 File Offset: 0x00052654
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
	}
}
