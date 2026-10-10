using System;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>Представляет безопасный дескриптор для реестра Windows.</summary>
	// Token: 0x020000B1 RID: 177
	public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000478 RID: 1144 RVA: 0x0001749E File Offset: 0x0001569E
		protected override bool ReleaseHandle()
		{
			return Interop.Advapi32.RegCloseKey(this.handle) == 0;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001747F File Offset: 0x0001567F
		internal SafeRegistryHandle() : base(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.SafeRegistryHandle" />.</summary>
		/// <param name="preexistingHandle">Объект, представляющий уже существовавший ранее дескриптор для использования.</param>
		/// <param name="ownsHandle">Значение <see langword="true" />, чтобы надежно освободить дескриптор на стадии завершения; значение <see langword="false" />, чтобы запретить надежное освобождение.</param>
		// Token: 0x0600047A RID: 1146 RVA: 0x000174AE File Offset: 0x000156AE
		public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(preexistingHandle);
		}
	}
}
