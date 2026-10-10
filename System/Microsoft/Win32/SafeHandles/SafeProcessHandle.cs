using System;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Предоставляет управляемую оболочку для дескриптора процесса.</summary>
	// Token: 0x02000133 RID: 307
	[SuppressUnmanagedCodeSecurity]
	public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x00013B6C File Offset: 0x00011D6C
		internal SafeProcessHandle() : base(true)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00013B75 File Offset: 0x00011D75
		internal SafeProcessHandle(IntPtr handle) : base(true)
		{
			base.SetHandle(handle);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.SafeProcessHandle" /> на основе указанного дескриптора и указывает, необходимо ли освободить дескриптор на этапе завершения.</summary>
		/// <param name="existingHandle">Инкапсулируемый дескриптор.</param>
		/// <param name="ownsHandle">Значение <see langword="true" />, чтобы наверняка позволить <see cref="T:Microsoft.Win32.SafeHandles.SafeProcessHandle" /> освободить дескриптор на стадии завершения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600072A RID: 1834 RVA: 0x00013B85 File Offset: 0x00011D85
		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
		public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(existingHandle);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00013B95 File Offset: 0x00011D95
		internal void InitialSetHandle(IntPtr h)
		{
			this.handle = h;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00013B9E File Offset: 0x00011D9E
		protected override bool ReleaseHandle()
		{
			return NativeMethods.CloseProcess(this.handle);
		}

		// Token: 0x04000517 RID: 1303
		internal static SafeProcessHandle InvalidHandle = new SafeProcessHandle(IntPtr.Zero);
	}
}
