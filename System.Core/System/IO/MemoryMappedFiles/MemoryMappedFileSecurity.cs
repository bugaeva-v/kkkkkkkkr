using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using Microsoft.Win32.SafeHandles;

namespace System.IO.MemoryMappedFiles
{
	/// <summary>
	///         Представляет разрешения, которые могут быть предоставлены для доступа к файлам и операций в памяти файлов.
	///       </summary>
	// Token: 0x02000337 RID: 823
	public class MemoryMappedFileSecurity : ObjectSecurity<MemoryMappedFileRights>
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileSecurity" />.
		///       </summary>
		// Token: 0x060018D6 RID: 6358 RVA: 0x000539E9 File Offset: 0x00051BE9
		public MemoryMappedFileSecurity() : base(false, ResourceType.KernelObject)
		{
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x000539F3 File Offset: 0x00051BF3
		[SecuritySafeCritical]
		internal MemoryMappedFileSecurity(SafeMemoryMappedFileHandle safeHandle, AccessControlSections includeSections) : base(false, ResourceType.KernelObject, safeHandle, includeSections)
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000539FF File Offset: 0x00051BFF
		[SecuritySafeCritical]
		internal void PersistHandle(SafeHandle handle)
		{
			base.Persist(handle);
		}
	}
}
