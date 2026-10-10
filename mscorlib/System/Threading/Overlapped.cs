using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Threading
{
	/// <summary>Предоставляет управляемое представление структуры OVERLAPPED Win32, включая методы для передачи данных из экземпляра <see cref="T:System.Threading.Overlapped" /> в структуру <see cref="T:System.Threading.NativeOverlapped" />.</summary>
	// Token: 0x020002F5 RID: 757
	[ComVisible(true)]
	public class Overlapped
	{
		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Threading.Overlapped" />.</summary>
		// Token: 0x060020F4 RID: 8436 RVA: 0x0000259F File Offset: 0x0000079F
		public Overlapped()
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Threading.Overlapped" /> с заданной позицией класса, с 32-разрядным дескриптором, который получает сигналы, когда операции ввода-вывода завершаются и интерфейсом, через который возвращаются результаты операции.</summary>
		/// <param name="offsetLo">Младшее слово позиции файла, с которого начинается перемещение данных.</param>
		/// <param name="offsetHi">Старшее слово позиции файла, с которого начинается перемещение данных.</param>
		/// <param name="hEvent">Дескриптор события, которое задается сигнальным состоянием при завершении операции вывода-ввода.</param>
		/// <param name="ar">Объект, реализующий интерфейс <see cref="T:System.IAsyncResult" /> и предоставляющий сведения о состоянии операций ввода-вывода.</param>
		// Token: 0x060020F5 RID: 8437 RVA: 0x00076F91 File Offset: 0x00075191
		[Obsolete("Not 64bit compatible.  Please use the constructor that takes IntPtr for the event handle")]
		public Overlapped(int offsetLo, int offsetHi, int hEvent, IAsyncResult ar)
		{
			this.offsetL = offsetLo;
			this.offsetH = offsetHi;
			this.evt = hEvent;
			this.ares = ar;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Threading.Overlapped" /> с заданной позицией класса, с дескриптором, который получает сигналы, когда операции ввода-вывода завершаются и интерфейсом, через который возвращаются результаты операции.</summary>
		/// <param name="offsetLo">Младшее слово позиции файла, с которого начинается перемещение данных.</param>
		/// <param name="offsetHi">Старшее слово позиции файла, с которого начинается перемещение данных.</param>
		/// <param name="hEvent">Дескриптор события, которое задается сигнальным состоянием при завершении операции вывода-ввода.</param>
		/// <param name="ar">Объект, реализующий интерфейс <see cref="T:System.IAsyncResult" /> и предоставляющий сведения о состоянии операций ввода-вывода.</param>
		// Token: 0x060020F6 RID: 8438 RVA: 0x00076FB6 File Offset: 0x000751B6
		public Overlapped(int offsetLo, int offsetHi, IntPtr hEvent, IAsyncResult ar)
		{
			this.offsetL = offsetLo;
			this.offsetH = offsetHi;
			this.evt_ptr = hEvent;
			this.ares = ar;
		}

		/// <summary>Освобождает неуправляемую память, связанную с собственной совмещенной структурой, выделенной методом <see cref="Overload:System.Threading.Overlapped.Pack" />.</summary>
		/// <param name="nativeOverlappedPtr">Освобождаемый указатель структуры <see cref="T:System.Threading.NativeOverlapped" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="nativeOverlappedPtr" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060020F7 RID: 8439 RVA: 0x00076FDB File Offset: 0x000751DB
		[CLSCompliant(false)]
		public unsafe static void Free(NativeOverlapped* nativeOverlappedPtr)
		{
			if ((IntPtr)((void*)nativeOverlappedPtr) == IntPtr.Zero)
			{
				throw new ArgumentNullException("nativeOverlappedPtr");
			}
			Marshal.FreeHGlobal((IntPtr)((void*)nativeOverlappedPtr));
		}

		/// <summary>Распаковывает заданную неуправляемую структуру <see cref="T:System.Threading.NativeOverlapped" /> в управляемый объект <see cref="T:System.Threading.Overlapped" />.</summary>
		/// <param name="nativeOverlappedPtr">Неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />.</param>
		/// <returns>Объект <see cref="T:System.Threading.Overlapped" />, содержащий распакованную информацию из собственной структуры.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="nativeOverlappedPtr" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060020F8 RID: 8440 RVA: 0x00077008 File Offset: 0x00075208
		[CLSCompliant(false)]
		public unsafe static Overlapped Unpack(NativeOverlapped* nativeOverlappedPtr)
		{
			if ((IntPtr)((void*)nativeOverlappedPtr) == IntPtr.Zero)
			{
				throw new ArgumentNullException("nativeOverlappedPtr");
			}
			return new Overlapped
			{
				offsetL = nativeOverlappedPtr->OffsetLow,
				offsetH = nativeOverlappedPtr->OffsetHigh,
				evt = (int)nativeOverlappedPtr->EventHandle
			};
		}

		/// <summary>Помещает текущий экземпляр в структуру <see cref="T:System.Threading.NativeOverlapped" />, определяющую делегата, вызываемого при завершении асинхронной операции ввода-вывода.</summary>
		/// <param name="iocb">Делегат <see cref="T:System.Threading.IOCompletionCallback" />, который представляет метод обратного вызова, когда асинхронная операция ввода-вывода завершается.</param>
		/// <returns>Неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Threading.Overlapped" /> уже упакован.</exception>
		// Token: 0x060020F9 RID: 8441 RVA: 0x00077060 File Offset: 0x00075260
		[MonoTODO("Security - we need to propagate the call stack")]
		[Obsolete("Use Pack(iocb, userData) instead")]
		[CLSCompliant(false)]
		public unsafe NativeOverlapped* Pack(IOCompletionCallback iocb)
		{
			NativeOverlapped* ptr = (NativeOverlapped*)((void*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NativeOverlapped))));
			ptr->OffsetLow = this.offsetL;
			ptr->OffsetHigh = this.offsetH;
			ptr->EventHandle = (IntPtr)this.evt;
			return ptr;
		}

		/// <summary>Помещает текущий экземпляр в структуру <see cref="T:System.Threading.NativeOverlapped" />, определяющую делегата, вызываемого при завершении асинхронной операции ввода-вывода, и управляемый объект, который служит буфером.</summary>
		/// <param name="iocb">Делегат <see cref="T:System.Threading.IOCompletionCallback" />, который представляет метод обратного вызова, когда асинхронная операция ввода-вывода завершается.</param>
		/// <param name="userData">Объект или массив объектов, представляющие буфер ввода или вывода для данной операции. Каждый объект представляет буфер, например, массив байтов.</param>
		/// <returns>Неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Threading.Overlapped" /> уже упакован.</exception>
		// Token: 0x060020FA RID: 8442 RVA: 0x000770B4 File Offset: 0x000752B4
		[ComVisible(false)]
		[CLSCompliant(false)]
		[MonoTODO("handle userData")]
		public unsafe NativeOverlapped* Pack(IOCompletionCallback iocb, object userData)
		{
			NativeOverlapped* ptr = (NativeOverlapped*)((void*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NativeOverlapped))));
			ptr->OffsetLow = this.offsetL;
			ptr->OffsetHigh = this.offsetH;
			ptr->EventHandle = this.evt_ptr;
			return ptr;
		}

		/// <summary>Помещает текущий экземпляр в структуру <see cref="T:System.Threading.NativeOverlapped" />, определяющую делегата, вызываемого при завершении асинхронной операции ввода-вывода. Не передает вызывающий стек.</summary>
		/// <param name="iocb">Делегат <see cref="T:System.Threading.IOCompletionCallback" />, который представляет метод обратного вызова, когда асинхронная операция ввода-вывода завершается.</param>
		/// <returns>Неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Threading.Overlapped" /> уже упакован.</exception>
		// Token: 0x060020FB RID: 8443 RVA: 0x00077100 File Offset: 0x00075300
		[Obsolete("Use UnsafePack(iocb, userData) instead")]
		[CLSCompliant(false)]
		[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
		public unsafe NativeOverlapped* UnsafePack(IOCompletionCallback iocb)
		{
			return this.Pack(iocb);
		}

		/// <summary>Упаковывает текущий экземпляр в структуру <see cref="T:System.Threading.NativeOverlapped" />, определяющую вызываемого делегата, когда асинхронная операция вывода-ввода завершается и управляемый объект, который служит буфером. Не передает вызывающий стек.</summary>
		/// <param name="iocb">Делегат <see cref="T:System.Threading.IOCompletionCallback" />, который представляет метод обратного вызова, когда асинхронная операция ввода-вывода завершается.</param>
		/// <param name="userData">Объект или массив объектов, представляющие буфер ввода или вывода для данной операции. Каждый объект представляет буфер, например, массив байтов.</param>
		/// <returns>Неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Threading.Overlapped" /> уже упакован.</exception>
		// Token: 0x060020FC RID: 8444 RVA: 0x00077109 File Offset: 0x00075309
		[ComVisible(false)]
		[CLSCompliant(false)]
		public unsafe NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData)
		{
			return this.Pack(iocb, userData);
		}

		/// <summary>Получает или задает объект, который предоставляет сведения о состоянии операции ввода-вывода.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.IAsyncResult" />.</returns>
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x00077113 File Offset: 0x00075313
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x0007711B File Offset: 0x0007531B
		public IAsyncResult AsyncResult
		{
			get
			{
				return this.ares;
			}
			set
			{
				this.ares = value;
			}
		}

		/// <summary>Получает или задает 32-разрядный целочисленный дескриптор для события синхронизации, которое переводится в сигнальное состояние при завершении операции вывода-ввода.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее дескриптор события синхронизации.</returns>
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x00077124 File Offset: 0x00075324
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x0007712C File Offset: 0x0007532C
		[Obsolete("Not 64bit compatible.  Use EventHandleIntPtr instead.")]
		public int EventHandle
		{
			get
			{
				return this.evt;
			}
			set
			{
				this.evt = value;
			}
		}

		/// <summary>Получает или задает дескриптор для события синхронизации, которое переводится в сигнальное состояние при завершении операции вывода-ввода.</summary>
		/// <returns>Объект <see cref="T:System.IntPtr" />, представляющий дескриптор события.</returns>
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x00077135 File Offset: 0x00075335
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x0007713D File Offset: 0x0007533D
		[ComVisible(false)]
		public IntPtr EventHandleIntPtr
		{
			get
			{
				return this.evt_ptr;
			}
			set
			{
				this.evt_ptr = value;
			}
		}

		/// <summary>Получает или задает старшее слово позиции файла, с которой начинается передача данных. Позиция в файле — это смещение в байтах от начала файла.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее старшее слово позиции файла.</returns>
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x00077146 File Offset: 0x00075346
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x0007714E File Offset: 0x0007534E
		public int OffsetHigh
		{
			get
			{
				return this.offsetH;
			}
			set
			{
				this.offsetH = value;
			}
		}

		/// <summary>Получает или задает младшее слово позиции файла, с которой начинается передача данных. Позиция в файле — это смещение в байтах от начала файла.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее младшее слово позиции файла.</returns>
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x00077157 File Offset: 0x00075357
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x0007715F File Offset: 0x0007535F
		public int OffsetLow
		{
			get
			{
				return this.offsetL;
			}
			set
			{
				this.offsetL = value;
			}
		}

		// Token: 0x04001B72 RID: 7026
		private IAsyncResult ares;

		// Token: 0x04001B73 RID: 7027
		private int offsetL;

		// Token: 0x04001B74 RID: 7028
		private int offsetH;

		// Token: 0x04001B75 RID: 7029
		private int evt;

		// Token: 0x04001B76 RID: 7030
		private IntPtr evt_ptr;
	}
}
