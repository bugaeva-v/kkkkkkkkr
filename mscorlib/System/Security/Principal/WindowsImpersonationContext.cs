using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity;

namespace System.Security.Principal
{
	/// <summary>Представляет пользователя Windows до операции олицетворения.</summary>
	// Token: 0x020004ED RID: 1261
	[ComVisible(true)]
	public class WindowsImpersonationContext : IDisposable
	{
		// Token: 0x0600326F RID: 12911 RVA: 0x000B9907 File Offset: 0x000B7B07
		internal WindowsImpersonationContext(IntPtr token)
		{
			this._token = WindowsImpersonationContext.DuplicateToken(token);
			if (!WindowsImpersonationContext.SetCurrentToken(token))
			{
				throw new SecurityException("Couldn't impersonate token.");
			}
			this.undo = false;
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Security.Principal.WindowsImpersonationContext" />.</summary>
		// Token: 0x06003270 RID: 12912 RVA: 0x000B9935 File Offset: 0x000B7B35
		[ComVisible(false)]
		public void Dispose()
		{
			if (!this.undo)
			{
				this.Undo();
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Principal.WindowsImpersonationContext" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06003271 RID: 12913 RVA: 0x000B9945 File Offset: 0x000B7B45
		[ComVisible(false)]
		protected virtual void Dispose(bool disposing)
		{
			if (!this.undo)
			{
				this.Undo();
			}
			if (disposing)
			{
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>Возвращает контекст пользователя пользователю Windows, представленному данным объектом.</summary>
		/// <exception cref="T:System.Security.SecurityException">Попытка использования данного метода для любых целей, кроме возврата удостоверения в исходное состояние.</exception>
		// Token: 0x06003272 RID: 12914 RVA: 0x000B995E File Offset: 0x000B7B5E
		public void Undo()
		{
			if (!WindowsImpersonationContext.RevertToSelf())
			{
				WindowsImpersonationContext.CloseToken(this._token);
				throw new SecurityException("Couldn't switch back to original token.");
			}
			WindowsImpersonationContext.CloseToken(this._token);
			this.undo = true;
			GC.SuppressFinalize(this);
		}

		// Token: 0x06003273 RID: 12915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CloseToken(IntPtr token);

		// Token: 0x06003274 RID: 12916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr DuplicateToken(IntPtr token);

		// Token: 0x06003275 RID: 12917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SetCurrentToken(IntPtr token);

		// Token: 0x06003276 RID: 12918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool RevertToSelf();

		// Token: 0x06003277 RID: 12919 RVA: 0x000173AD File Offset: 0x000155AD
		internal WindowsImpersonationContext()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002344 RID: 9028
		private IntPtr _token;

		// Token: 0x04002345 RID: 9029
		private bool undo;
	}
}
