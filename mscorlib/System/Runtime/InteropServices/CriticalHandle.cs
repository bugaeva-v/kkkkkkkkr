using System;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Runtime.InteropServices
{
	/// <summary>Представляет класс-оболочку для ресурсов обработчика.</summary>
	// Token: 0x02000715 RID: 1813
	[SecurityCritical]
	public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.CriticalHandle" /> с заданным значением недопустимого дескриптора.</summary>
		/// <param name="invalidHandleValue">Значение недопустимого дескриптора (обычно 0 или -1).</param>
		/// <exception cref="T:System.TypeLoadException">Производный класс находится в сборке без разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x060040C9 RID: 16585 RVA: 0x000E1674 File Offset: 0x000DF874
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected CriticalHandle(IntPtr invalidHandleValue)
		{
			this.handle = invalidHandleValue;
			this._isClosed = false;
		}

		/// <summary>Освобождает все ресурсы, связанные с дескриптором.</summary>
		// Token: 0x060040CA RID: 16586 RVA: 0x000E168C File Offset: 0x000DF88C
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		~CriticalHandle()
		{
			this.Dispose(false);
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x000E16BC File Offset: 0x000DF8BC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SecurityCritical]
		private void Cleanup()
		{
			if (this.IsClosed)
			{
				return;
			}
			this._isClosed = true;
			if (this.IsInvalid)
			{
				return;
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!this.ReleaseHandle())
			{
				CriticalHandle.FireCustomerDebugProbe();
			}
			Marshal.SetLastWin32Error(lastWin32Error);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x00004BF9 File Offset: 0x00002DF9
		private static void FireCustomerDebugProbe()
		{
		}

		/// <summary>Определяет дескриптор для заданного ранее существующего дескриптора.</summary>
		/// <param name="handle">Ранее существующий дескриптор для использования.</param>
		// Token: 0x060040CD RID: 16589 RVA: 0x000E16F4 File Offset: 0x000DF8F4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected void SetHandle(IntPtr handle)
		{
			this.handle = handle;
		}

		/// <summary>Возвращает значение, показывающее, является ли дескриптор закрытым.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор закрыт, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x000E16FD File Offset: 0x000DF8FD
		public bool IsClosed
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this._isClosed;
			}
		}

		/// <summary>При переопределении в производном классе возвращает значение, показывающее, допустимо ли значение дескриптора.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор действителен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060040CF RID: 16591
		public abstract bool IsInvalid { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get; }

		/// <summary>Помечает дескриптор для освобождения самого дескриптора и соответствующих ресурсов.</summary>
		// Token: 0x060040D0 RID: 16592 RVA: 0x000E1705 File Offset: 0x000DF905
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Runtime.InteropServices.CriticalHandle" />.</summary>
		// Token: 0x060040D1 RID: 16593 RVA: 0x000E1705 File Offset: 0x000DF905
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.Runtime.InteropServices.CriticalHandle" />, определяя, нужно ли выполнять обычную операцию удаления.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для обычной операции удаления и значение <see langword="false" /> для завершения работы с дескриптором.</param>
		// Token: 0x060040D2 RID: 16594 RVA: 0x000E170E File Offset: 0x000DF90E
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SecurityCritical]
		protected virtual void Dispose(bool disposing)
		{
			this.Cleanup();
		}

		/// <summary>Помечает дескриптор как недопустимый.</summary>
		// Token: 0x060040D3 RID: 16595 RVA: 0x000E1716 File Offset: 0x000DF916
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void SetHandleAsInvalid()
		{
			this._isClosed = true;
			GC.SuppressFinalize(this);
		}

		/// <summary>При переопределении в производном классе выполняет код, необходимый для освобождения дескриптора.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор освобождается успешно; в противном случае при катастрофическом сбое — значение <see langword="false" />. В таком случае создается управляемый помощник по отладке releaseHandleFailed.</returns>
		// Token: 0x060040D4 RID: 16596
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected abstract bool ReleaseHandle();

		/// <summary>Определяет инкапсулируемый дескриптор.</summary>
		// Token: 0x04002AF8 RID: 11000
		protected IntPtr handle;

		// Token: 0x04002AF9 RID: 11001
		private bool _isClosed;
	}
}
