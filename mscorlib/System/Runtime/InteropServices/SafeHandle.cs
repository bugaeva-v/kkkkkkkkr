using System;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace System.Runtime.InteropServices
{
	/// <summary>Представляет класс-оболочку для дескрипторов операционной системы. Этот класс должен наследоваться.</summary>
	// Token: 0x0200071D RID: 1821
	[SecurityCritical]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.SafeHandle" /> с заданным значением недопустимого дескриптора.</summary>
		/// <param name="invalidHandleValue">Значение недопустимого дескриптора (обычно 0 или -1).  Реализация <see cref="P:System.Runtime.InteropServices.SafeHandle.IsInvalid" /> должна возвращать <see langword="true" /> для этого значения.</param>
		/// <param name="ownsHandle">Значение <see langword="true" />, если нужно надежно разрешить <see cref="T:System.Runtime.InteropServices.SafeHandle" /> освободить дескриптор на стадии завершения; в противном случае — значение <see langword="false" /> (не рекомендуется).</param>
		/// <exception cref="T:System.TypeLoadException">Производный класс находится в сборке без разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x060040ED RID: 16621 RVA: 0x000E17EC File Offset: 0x000DF9EC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
		{
			this.handle = invalidHandleValue;
			this._state = 4;
			this._ownsHandle = ownsHandle;
			if (!ownsHandle)
			{
				GC.SuppressFinalize(this);
			}
			this._fullyInitialized = true;
		}

		/// <summary>Освобождает все ресурсы, связанные с дескриптором.</summary>
		// Token: 0x060040EE RID: 16622 RVA: 0x000E181C File Offset: 0x000DFA1C
		[SecuritySafeCritical]
		~SafeHandle()
		{
			this.Dispose(false);
		}

		/// <summary>Определяет дескриптор для заданного ранее существующего дескриптора.</summary>
		/// <param name="handle">Ранее существующий дескриптор для использования.</param>
		// Token: 0x060040EF RID: 16623 RVA: 0x000E184C File Offset: 0x000DFA4C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected void SetHandle(IntPtr handle)
		{
			this.handle = handle;
		}

		/// <summary>Возвращает значение поля <see cref="F:System.Runtime.InteropServices.SafeHandle.handle" />.</summary>
		/// <returns>Указатель <see langword="IntPtr" />, представляющий значение поля <see cref="F:System.Runtime.InteropServices.SafeHandle.handle" />. Если дескриптор был помечен как недопустимый с помощью <see cref="M:System.Runtime.InteropServices.SafeHandle.SetHandleAsInvalid" />, этот метод, тем не менее, возвращает исходное значение дескриптора, которое может быть устаревшим.</returns>
		// Token: 0x060040F0 RID: 16624 RVA: 0x000E1855 File Offset: 0x000DFA55
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public IntPtr DangerousGetHandle()
		{
			return this.handle;
		}

		/// <summary>Возвращает значение, показывающее, является ли дескриптор закрытым.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор закрыт, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x000E185D File Offset: 0x000DFA5D
		public bool IsClosed
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return (this._state & 1) == 1;
			}
		}

		/// <summary>При переопределении в производном классе возвращает значение, показывающее, допустимо ли значение дескриптора.</summary>
		/// <returns>Значение <see langword="true" />, если значение дескриптора является неправильным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060040F2 RID: 16626
		public abstract bool IsInvalid { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get; }

		/// <summary>Помечает дескриптор для освобождения самого дескриптора и соответствующих ресурсов.</summary>
		// Token: 0x060040F3 RID: 16627 RVA: 0x000E186A File Offset: 0x000DFA6A
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает все ресурсы, используемые классом <see cref="T:System.Runtime.InteropServices.SafeHandle" />.</summary>
		// Token: 0x060040F4 RID: 16628 RVA: 0x000E186A File Offset: 0x000DFA6A
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.Runtime.InteropServices.SafeHandle" />, определяя, нужно ли выполнять обычную операцию удаления.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для обычной операции удаления и значение <see langword="false" /> для завершения работы с дескриптором.</param>
		// Token: 0x060040F5 RID: 16629 RVA: 0x000E1873 File Offset: 0x000DFA73
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.InternalDispose();
				return;
			}
			this.InternalFinalize();
		}

		/// <summary>При переопределении в производном классе выполняет код, необходимый для освобождения дескриптора.</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор освобождается успешно; в противном случае при катастрофическом сбое — значение <see langword="false" />. В таком случае создается управляемый помощник по отладке releaseHandleFailed.</returns>
		// Token: 0x060040F6 RID: 16630
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected abstract bool ReleaseHandle();

		/// <summary>Помечает дескриптор как больше не используемый.</summary>
		// Token: 0x060040F7 RID: 16631 RVA: 0x000E1888 File Offset: 0x000DFA88
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void SetHandleAsInvalid()
		{
			try
			{
			}
			finally
			{
				int state;
				int value;
				do
				{
					state = this._state;
					value = (state | 1);
				}
				while (Interlocked.CompareExchange(ref this._state, value, state) != state);
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>Вручную увеличивает счетчик ссылок для экземпляров <see cref="T:System.Runtime.InteropServices.SafeHandle" />.</summary>
		/// <param name="success">Значение <see langword="true" />, если счетчик ссылок был успешно увеличен; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060040F8 RID: 16632 RVA: 0x000E18CC File Offset: 0x000DFACC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void DangerousAddRef(ref bool success)
		{
			try
			{
			}
			finally
			{
				if (!this._fullyInitialized)
				{
					throw new InvalidOperationException();
				}
				for (;;)
				{
					int state = this._state;
					if ((state & 1) != 0)
					{
						break;
					}
					int value = state + 4;
					if (Interlocked.CompareExchange(ref this._state, value, state) == state)
					{
						goto Block_5;
					}
				}
				throw new ObjectDisposedException(null, "Safe handle has been closed");
				Block_5:
				success = true;
			}
		}

		/// <summary>Вручную уменьшает счетчик ссылок для экземпляра <see cref="T:System.Runtime.InteropServices.SafeHandle" />.</summary>
		// Token: 0x060040F9 RID: 16633 RVA: 0x000E192C File Offset: 0x000DFB2C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void DangerousRelease()
		{
			this.DangerousReleaseInternal(false);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x000E1935 File Offset: 0x000DFB35
		private void InternalDispose()
		{
			if (!this._fullyInitialized)
			{
				throw new InvalidOperationException();
			}
			this.DangerousReleaseInternal(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x000E1952 File Offset: 0x000DFB52
		private void InternalFinalize()
		{
			if (this._fullyInitialized)
			{
				this.DangerousReleaseInternal(true);
			}
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x000E1964 File Offset: 0x000DFB64
		private void DangerousReleaseInternal(bool dispose)
		{
			try
			{
			}
			finally
			{
				if (!this._fullyInitialized)
				{
					throw new InvalidOperationException();
				}
				bool flag;
				for (;;)
				{
					int state = this._state;
					if (dispose && (state & 2) != 0)
					{
						break;
					}
					if ((state & 2147483644) == 0)
					{
						goto Block_6;
					}
					flag = ((state & 2147483644) == 4 && (state & 1) == 0 && this._ownsHandle && !this.IsInvalid);
					int num = state - 4;
					if ((state & 2147483644) == 4)
					{
						num |= 1;
					}
					if (dispose)
					{
						num |= 2;
					}
					if (Interlocked.CompareExchange(ref this._state, num, state) == state)
					{
						goto IL_9A;
					}
				}
				flag = false;
				goto IL_9A;
				Block_6:
				throw new ObjectDisposedException(null, "Safe handle has been closed");
				IL_9A:
				if (flag)
				{
					this.ReleaseHandle();
				}
			}
		}

		/// <summary>Определяет инкапсулируемый дескриптор.</summary>
		// Token: 0x04002B02 RID: 11010
		protected IntPtr handle;

		// Token: 0x04002B03 RID: 11011
		private int _state;

		// Token: 0x04002B04 RID: 11012
		private bool _ownsHandle;

		// Token: 0x04002B05 RID: 11013
		private bool _fullyInitialized;

		// Token: 0x04002B06 RID: 11014
		private const int RefCount_Mask = 2147483644;

		// Token: 0x04002B07 RID: 11015
		private const int RefCount_One = 4;

		// Token: 0x0200071E RID: 1822
		private enum State
		{
			// Token: 0x04002B09 RID: 11017
			Closed = 1,
			// Token: 0x04002B0A RID: 11018
			Disposed
		}
	}
}
