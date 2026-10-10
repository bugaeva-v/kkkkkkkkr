using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>
	///         Предоставляет безопасный дескриптор, представляющий ключ (NCRYPT_KEY_HANDLE).
	///       </summary>
	// Token: 0x02000017 RID: 23
	public sealed class SafeNCryptKeyHandle : SafeNCryptHandle
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle" />.
		///       </summary>
		// Token: 0x06000048 RID: 72 RVA: 0x000023D4 File Offset: 0x000005D4
		public SafeNCryptKeyHandle()
		{
		}

		/// <summary>
		///         Создает новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle" />.
		///       </summary>
		/// <param name="handle">
		///           Ранее существующий дескриптор для использования.
		///            Используя <see cref="F:System.IntPtr.Zero" />, возвращает недопустимый дескриптор.
		///         </param>
		/// <param name="parentHandle">
		///           Родительский дескриптор для <see cref="T:Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="parentHandle" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="parentHandle" /> закрыт.
		///
		///             -или-
		///
		///             <paramref name="parentHandle" /> недопустим.
		///           </exception>
		// Token: 0x06000049 RID: 73 RVA: 0x000023DC File Offset: 0x000005DC
		public SafeNCryptKeyHandle(IntPtr handle, SafeHandle parentHandle) : base(handle, parentHandle)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000023D1 File Offset: 0x000005D1
		protected override bool ReleaseNativeHandle()
		{
			return false;
		}
	}
}
