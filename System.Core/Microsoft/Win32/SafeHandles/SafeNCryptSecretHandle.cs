using System;

namespace Microsoft.Win32.SafeHandles
{
	/// <summary>
	///         Предоставляет безопасный дескриптор, представляющий значение секретного соглашения (NCRYPT_SECRET_HANDLE).
	///       </summary>
	// Token: 0x02000019 RID: 25
	public sealed class SafeNCryptSecretHandle : SafeNCryptHandle
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000023D1 File Offset: 0x000005D1
		protected override bool ReleaseNativeHandle()
		{
			return false;
		}
	}
}
