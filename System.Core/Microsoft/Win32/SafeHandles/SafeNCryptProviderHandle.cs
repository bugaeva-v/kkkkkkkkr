using System;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>
	///         Предоставляет безопасный дескриптор, представляющий поставщика хранилища ключей (NCRYPT_PROV_HANDLE).
	///       </summary>
	// Token: 0x02000018 RID: 24
	public sealed class SafeNCryptProviderHandle : SafeNCryptHandle
	{
		// Token: 0x0600004C RID: 76 RVA: 0x000023D1 File Offset: 0x000005D1
		protected override bool ReleaseNativeHandle()
		{
			return false;
		}
	}
}
