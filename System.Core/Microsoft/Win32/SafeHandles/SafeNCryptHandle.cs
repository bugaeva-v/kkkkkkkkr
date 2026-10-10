using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>
	///         Предоставляет безопасный дескриптор для использования объектами криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000016 RID: 22
	public abstract class SafeNCryptHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.SafeNCryptHandle" />.
		///       </summary>
		// Token: 0x06000043 RID: 67 RVA: 0x000023B3 File Offset: 0x000005B3
		protected SafeNCryptHandle() : base(true)
		{
		}

		/// <summary>
		///         Создает новый экземпляр класса <see cref="T:Microsoft.Win32.SafeHandles.SafeNCryptHandle" />.
		///       </summary>
		/// <param name="handle">
		///           Ранее существующий дескриптор для использования.
		///            Используя <see cref="F:System.IntPtr.Zero" />, возвращает недопустимый дескриптор.
		///         </param>
		/// <param name="parentHandle">
		///           Родительский дескриптор для <see cref="T:Microsoft.Win32.SafeHandles.SafeNCryptHandle" />.
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
		// Token: 0x06000044 RID: 68 RVA: 0x000023BC File Offset: 0x000005BC
		protected SafeNCryptHandle(IntPtr handle, SafeHandle parentHandle) : base(false)
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000023CA File Offset: 0x000005CA
		public override bool IsInvalid
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Освобождает дескриптор, используемый объектом криптографии следующего поколения (CNG).
		///       </summary>
		/// <returns>
		///         <see langword="true" />Если дескриптор освобождается успешно; в противном случае <see langword="false" />.
		///       </returns>
		// Token: 0x06000046 RID: 70 RVA: 0x000023D1 File Offset: 0x000005D1
		protected override bool ReleaseHandle()
		{
			return false;
		}

		/// <summary>
		///         Освобождает собственный дескриптор, используемый объектом криптографии следующего поколения (CNG).
		///       </summary>
		/// <returns>
		///         <see langword="true" />Если дескриптор освобождается успешно; в противном случае <see langword="false" />.
		///       </returns>
		// Token: 0x06000047 RID: 71
		protected abstract bool ReleaseNativeHandle();
	}
}
