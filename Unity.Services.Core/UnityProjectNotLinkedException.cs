using System;

namespace Unity.Services.Core
{
	// Token: 0x02000009 RID: 9
	internal class UnityProjectNotLinkedException : ServicesInitializationException
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002228 File Offset: 0x00000428
		public UnityProjectNotLinkedException()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002230 File Offset: 0x00000430
		public UnityProjectNotLinkedException(string message) : base(message)
		{
		}
	}
}
