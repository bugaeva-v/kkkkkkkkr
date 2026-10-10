using System;

namespace System.Threading
{
	/// <summary>Представляет предварительно выделенное состояние для собственных перекрывающихся операций ввода-вывода.</summary>
	// Token: 0x020002B9 RID: 697
	public sealed class PreAllocatedOverlapped : IDisposable, IDeferredDisposable
	{
		// Token: 0x06001E70 RID: 7792 RVA: 0x000175B9 File Offset: 0x000157B9
		static PreAllocatedOverlapped()
		{
			if (!Environment.IsRunningOnWindows)
			{
				throw new PlatformNotSupportedException();
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.PreAllocatedOverlapped" /> и указывает делегат, вызываемый по завершении каждой асинхронной операции ввода-вывода, предоставляемый пользователем объект, предоставляющий контекст, и управляемые объекты, которые служат в качестве буфера.</summary>
		/// <param name="callback">Делегат, который представляет метод обратного вызова, вызываемый после завершения каждой асинхронной операции ввода-вывода.</param>
		/// <param name="state">Предоставляемый пользователем объект, отличающий экземпляр <see cref="T:System.Threading.NativeOverlapped" />, полученный из этого объекта, от других экземпляров <see cref="T:System.Threading.NativeOverlapped" />. Это значение может быть равно <see langword="null" />.</param>
		/// <param name="pinData">Объект или массив объектов, представляющих входной или выходной буфер для операций. Каждый объект представляет буфер, такой массив байтов. Это значение может быть равно <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="callback" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Этот метод был вызван после удаления <see cref="T:System.Threading.ThreadPoolBoundHandle" />.</exception>
		// Token: 0x06001E71 RID: 7793 RVA: 0x00070CC3 File Offset: 0x0006EEC3
		[CLSCompliant(false)]
		public PreAllocatedOverlapped(IOCompletionCallback callback, object state, object pinData)
		{
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			this._overlapped = Win32ThreadPoolNativeOverlapped.Allocate(callback, state, pinData, this);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00070CE8 File Offset: 0x0006EEE8
		internal bool AddRef()
		{
			return this._lifetime.AddRef(this);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00070CF6 File Offset: 0x0006EEF6
		internal void Release()
		{
			this._lifetime.Release(this);
		}

		/// <summary>Освобождает ресурсы, связанные с данным экземпляром <see cref="T:System.Threading.PreAllocatedOverlapped" />.</summary>
		// Token: 0x06001E74 RID: 7796 RVA: 0x00070D04 File Offset: 0x0006EF04
		public void Dispose()
		{
			this._lifetime.Dispose(this);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, прежде чем текущий экземпляр будет удален при сборке мусора.</summary>
		// Token: 0x06001E75 RID: 7797 RVA: 0x00070D18 File Offset: 0x0006EF18
		~PreAllocatedOverlapped()
		{
			if (!Environment.HasShutdownStarted)
			{
				this.Dispose();
			}
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00070D4C File Offset: 0x0006EF4C
		unsafe void IDeferredDisposable.OnFinalRelease(bool disposed)
		{
			if (this._overlapped != null)
			{
				if (disposed)
				{
					Win32ThreadPoolNativeOverlapped.Free(this._overlapped);
					return;
				}
				*Win32ThreadPoolNativeOverlapped.ToNativeOverlapped(this._overlapped) = default(NativeOverlapped);
			}
		}

		// Token: 0x04001AB6 RID: 6838
		internal unsafe readonly Win32ThreadPoolNativeOverlapped* _overlapped;

		// Token: 0x04001AB7 RID: 6839
		private DeferredDisposableLifetime<PreAllocatedOverlapped> _lifetime;
	}
}
