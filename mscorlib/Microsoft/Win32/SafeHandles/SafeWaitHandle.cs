using System;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Представляет класс-оболочку для дескриптора ожидания.</summary>
	// Token: 0x020000B7 RID: 183
	[SecurityCritical]
	public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x0001747F File Offset: 0x0001567F
		private SafeWaitHandle() : base(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.SafeWaitHandle" />.</summary>
		/// <param name="existingHandle">Объект <see cref="T:System.IntPtr" />, представляющий ранее существующий дескриптор для использования.</param>
		/// <param name="ownsHandle">Значение <see langword="true" />, чтобы надежно освободить маркер на стадии завершения; значение <see langword="false" />, чтобы предотвратить надежное освобождение (не рекомендуется).</param>
		// Token: 0x06000493 RID: 1171 RVA: 0x000174AE File Offset: 0x000156AE
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(existingHandle);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00017634 File Offset: 0x00015834
		[SecurityCritical]
		protected override bool ReleaseHandle()
		{
			NativeEventCalls.CloseEvent_internal(this.handle);
			return true;
		}
	}
}
