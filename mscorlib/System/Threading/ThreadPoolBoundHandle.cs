using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Unity;

namespace System.Threading
{
	/// <summary>Представляет дескриптор ввода-вывода, который привязан к системному пулу потоков и позволяет низкоуровневым компонентам получать уведомления для асинхронных операций ввода-вывода.</summary>
	// Token: 0x020002B5 RID: 693
	public sealed class ThreadPoolBoundHandle : IDisposable, IDeferredDisposable
	{
		// Token: 0x06001E53 RID: 7763 RVA: 0x000175B9 File Offset: 0x000157B9
		static ThreadPoolBoundHandle()
		{
			if (!Environment.IsRunningOnWindows)
			{
				throw new PlatformNotSupportedException();
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00070522 File Offset: 0x0006E722
		private ThreadPoolBoundHandle(SafeHandle handle, SafeThreadPoolIOHandle threadPoolHandle)
		{
			this._threadPoolHandle = threadPoolHandle;
			this._handle = handle;
		}

		/// <summary>Получает связанный дескриптор операционной системы.</summary>
		/// <returns>Объект, содержащий связанный дескриптор операционной системы.</returns>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x00070538 File Offset: 0x0006E738
		public SafeHandle Handle
		{
			get
			{
				return this._handle;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Threading.ThreadPoolBoundHandle" /> для указанного дескриптора, который привязан к системному пулу потоков.</summary>
		/// <param name="handle">Объект, содержащий дескриптор операционной системы. Дескриптор должен быть открыт для перекрывающегося ввода-вывода в неуправляемом коде.</param>
		/// <returns>Объект <see cref="T:System.Threading.ThreadPoolBoundHandle" /> для <paramref name="handle" />, который привязан к системному пулу.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="handle" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Объект <paramref name="handle" /> был удален.  
		///
		/// или - 
		/// <paramref name="handle" /> не ссылается на допустимый дескриптор ввода-вывода.  
		///
		/// или - 
		/// <paramref name="handle" /> ссылается на дескриптор, который не был открыт для перекрывающегося ввода-вывода.  
		///
		/// или - 
		/// <paramref name="handle" /> ссылается на дескриптор, который уже привязан.</exception>
		// Token: 0x06001E56 RID: 7766 RVA: 0x00070540 File Offset: 0x0006E740
		public static ThreadPoolBoundHandle BindHandle(SafeHandle handle)
		{
			if (handle == null)
			{
				throw new ArgumentNullException("handle");
			}
			if (handle.IsClosed || handle.IsInvalid)
			{
				throw new ArgumentException("'handle' has been disposed or is an invalid handle.", "handle");
			}
			IntPtr pfnio = AddrofIntrinsics.AddrOf<Interop.NativeIoCompletionCallback>(new Interop.NativeIoCompletionCallback(ThreadPoolBoundHandle.OnNativeIOCompleted));
			SafeThreadPoolIOHandle safeThreadPoolIOHandle = Interop.mincore.CreateThreadpoolIo(handle, pfnio, IntPtr.Zero, IntPtr.Zero);
			if (!safeThreadPoolIOHandle.IsInvalid)
			{
				return new ThreadPoolBoundHandle(handle, safeThreadPoolIOHandle);
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 6)
			{
				throw new ArgumentException("'handle' has been disposed or is an invalid handle.", "handle");
			}
			if (lastWin32Error == 87)
			{
				throw new ArgumentException("'handle' has already been bound to the thread pool, or was not opened for asynchronous I/O.", "handle");
			}
			throw Win32Marshal.GetExceptionForWin32Error(lastWin32Error, "");
		}

		/// <summary>Возвращает неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />, обозначая делегат, вызываемый после завершения асинхронной операции ввода-вывода, предоставляемый пользователем объект, предоставляющий контекст, и управляемые объекты, которые служат в качестве буфера.</summary>
		/// <param name="callback">Делегат, который представляет метод обратного вызова, вызываемый после завершения асинхронной операции ввода-вывода.</param>
		/// <param name="state">Предоставляемый пользователем объект, отличающий этот экземпляр <see cref="T:System.Threading.NativeOverlapped" /> от других экземпляров <see cref="T:System.Threading.NativeOverlapped" />.</param>
		/// <param name="pinData">Объект или массив объектов, представляющих входной или выходной буфер для операции, или <see langword="null" />. Каждый объект представляет буфер, такой массив байтов.</param>
		/// <returns>Неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="callback" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Этот метод был вызван после удаления объекта <see cref="T:System.Threading.ThreadPoolBoundHandle" />.</exception>
		// Token: 0x06001E57 RID: 7767 RVA: 0x000705E8 File Offset: 0x0006E7E8
		[CLSCompliant(false)]
		public unsafe NativeOverlapped* AllocateNativeOverlapped(IOCompletionCallback callback, object state, object pinData)
		{
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			this.AddRef();
			NativeOverlapped* result;
			try
			{
				Win32ThreadPoolNativeOverlapped* ptr = Win32ThreadPoolNativeOverlapped.Allocate(callback, state, pinData, null);
				ptr->Data._boundHandle = this;
				Interop.mincore.StartThreadpoolIo(this._threadPoolHandle);
				result = Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(ptr);
			}
			catch
			{
				this.Release();
				throw;
			}
			return result;
		}

		/// <summary>Возвращает неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" /> с помощью состояния обратного вызова и буферов, связанных с указанным объектом <see cref="T:System.Threading.PreAllocatedOverlapped" />.</summary>
		/// <param name="preAllocated">Объект, из которого создается указатель <see cref="T:System.Threading.NativeOverlapped" />.</param>
		/// <returns>Неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="preAllocated" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="preAllocated" /> сейчас используется для другой операции ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Этот метод был вызван после удаления <see cref="T:System.Threading.ThreadPoolBoundHandle" />.  
		///
		/// или - 
		/// Этот метод был вызван после удаления <paramref name="preAllocated" />.</exception>
		// Token: 0x06001E58 RID: 7768 RVA: 0x0007064C File Offset: 0x0006E84C
		[CLSCompliant(false)]
		public unsafe NativeOverlapped* AllocateNativeOverlapped(PreAllocatedOverlapped preAllocated)
		{
			if (preAllocated == null)
			{
				throw new ArgumentNullException("preAllocated");
			}
			bool flag = false;
			bool flag2 = false;
			NativeOverlapped* result;
			try
			{
				flag = this.AddRef();
				flag2 = preAllocated.AddRef();
				Win32ThreadPoolNativeOverlapped.OverlappedData data = preAllocated._overlapped->Data;
				if (data._boundHandle != null)
				{
					throw new ArgumentException("'preAllocated' is already in use.", "preAllocated");
				}
				data._boundHandle = this;
				Interop.mincore.StartThreadpoolIo(this._threadPoolHandle);
				result = Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(preAllocated._overlapped);
			}
			catch
			{
				if (flag2)
				{
					preAllocated.Release();
				}
				if (flag)
				{
					this.Release();
				}
				throw;
			}
			return result;
		}

		/// <summary>Освобождает память, связанную со структурой <see cref="T:System.Threading.NativeOverlapped" />, выделенной с помощью метода <see cref="Overload:System.Threading.ThreadPoolBoundHandle.AllocateNativeOverlapped" />.</summary>
		/// <param name="overlapped">Неуправляемый указатель на освобождаемую структуру <see cref="T:System.Threading.NativeOverlapped" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="overlapped" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Этот метод был вызван после удаления объекта <see cref="T:System.Threading.ThreadPoolBoundHandle" />.</exception>
		// Token: 0x06001E59 RID: 7769 RVA: 0x000706E4 File Offset: 0x0006E8E4
		[CLSCompliant(false)]
		public unsafe void FreeNativeOverlapped(NativeOverlapped* overlapped)
		{
			if (overlapped == null)
			{
				throw new ArgumentNullException("overlapped");
			}
			Win32ThreadPoolNativeOverlapped* overlapped2 = Win32ThreadPoolNativeOverlapped.FromNativeOverlapped(overlapped);
			Win32ThreadPoolNativeOverlapped.OverlappedData overlappedData = ThreadPoolBoundHandle.GetOverlappedData(overlapped2, this);
			if (!overlappedData._completed)
			{
				Interop.mincore.CancelThreadpoolIo(this._threadPoolHandle);
				this.Release();
			}
			overlappedData._boundHandle = null;
			overlappedData._completed = false;
			if (overlappedData._preAllocated != null)
			{
				overlappedData._preAllocated.Release();
				return;
			}
			Win32ThreadPoolNativeOverlapped.Free(overlapped2);
		}

		/// <summary>Возвращает предоставляемый пользователем объект, который был указан при выделении экземпляра <see cref="T:System.Threading.NativeOverlapped" /> путем вызова метода <see cref="M:System.Threading.ThreadPoolBoundHandle.AllocateNativeOverlapped(System.Threading.IOCompletionCallback,System.Object,System.Object)" />.</summary>
		/// <param name="overlapped">Неуправляемый указатель на структуру <see cref="T:System.Threading.NativeOverlapped" />, из которой следует получить связанный предоставляемый пользователем объект.</param>
		/// <returns>Предоставляемый пользователем объект, отличающий этот экземпляр <see cref="T:System.Threading.NativeOverlapped" /> от других экземпляров <see cref="T:System.Threading.NativeOverlapped" />, или <see langword="null" />, если объект не был указан при выделении экземпляра путем вызова метода <see cref="Overload:System.Threading.ThreadPoolBoundHandle.AllocateNativeOverlapped" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="overlapped" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001E5A RID: 7770 RVA: 0x00070751 File Offset: 0x0006E951
		[CLSCompliant(false)]
		public unsafe static object GetNativeOverlappedState(NativeOverlapped* overlapped)
		{
			if (overlapped == null)
			{
				throw new ArgumentNullException("overlapped");
			}
			return ThreadPoolBoundHandle.GetOverlappedData(Win32ThreadPoolNativeOverlapped.FromNativeOverlapped(overlapped), null)._state;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00070774 File Offset: 0x0006E974
		private unsafe static Win32ThreadPoolNativeOverlapped.OverlappedData GetOverlappedData(Win32ThreadPoolNativeOverlapped* overlapped, ThreadPoolBoundHandle expectedBoundHandle)
		{
			Win32ThreadPoolNativeOverlapped.OverlappedData data = overlapped->Data;
			if (data._boundHandle == null)
			{
				throw new ArgumentException("'overlapped' has already been freed.", "overlapped");
			}
			if (expectedBoundHandle != null && data._boundHandle != expectedBoundHandle)
			{
				throw new ArgumentException("'overlapped' was not allocated by this ThreadPoolBoundHandle instance.", "overlapped");
			}
			return data;
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000707C0 File Offset: 0x0006E9C0
		[NativeCallable(CallingConvention = CallingConvention.StdCall)]
		private unsafe static void OnNativeIOCompleted(IntPtr instance, IntPtr context, IntPtr overlappedPtr, uint ioResult, UIntPtr numberOfBytesTransferred, IntPtr ioPtr)
		{
			ThreadPoolCallbackWrapper threadPoolCallbackWrapper = ThreadPoolCallbackWrapper.Enter();
			Win32ThreadPoolNativeOverlapped* ptr = (Win32ThreadPoolNativeOverlapped*)((void*)overlappedPtr);
			ThreadPoolBoundHandle boundHandle = ptr->Data._boundHandle;
			if (boundHandle == null)
			{
				throw new InvalidOperationException("'overlapped' has already been freed.");
			}
			boundHandle.Release();
			Win32ThreadPoolNativeOverlapped.CompleteWithCallback(ioResult, (uint)numberOfBytesTransferred, ptr);
			threadPoolCallbackWrapper.Exit(true);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0007080E File Offset: 0x0006EA0E
		private bool AddRef()
		{
			return this._lifetime.AddRef(this);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0007081C File Offset: 0x0006EA1C
		private void Release()
		{
			this._lifetime.Release(this);
		}

		/// <summary>Высвобождает все неуправляемые ресурсы, используемые экземпляром <see cref="T:System.Threading.ThreadPoolBoundHandle" />.</summary>
		// Token: 0x06001E5F RID: 7775 RVA: 0x0007082A File Offset: 0x0006EA2A
		public void Dispose()
		{
			this._lifetime.Dispose(this);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00070840 File Offset: 0x0006EA40
		~ThreadPoolBoundHandle()
		{
			if (!Environment.IsRunningOnWindows)
			{
				throw new PlatformNotSupportedException();
			}
			if (!Environment.HasShutdownStarted)
			{
				this.Dispose();
			}
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00070880 File Offset: 0x0006EA80
		void IDeferredDisposable.OnFinalRelease(bool disposed)
		{
			if (disposed)
			{
				this._threadPoolHandle.Dispose();
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000173AD File Offset: 0x000155AD
		internal ThreadPoolBoundHandle()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001AA0 RID: 6816
		private readonly SafeHandle _handle;

		// Token: 0x04001AA1 RID: 6817
		private readonly SafeThreadPoolIOHandle _threadPoolHandle;

		// Token: 0x04001AA2 RID: 6818
		private DeferredDisposableLifetime<ThreadPoolBoundHandle> _lifetime;
	}
}
