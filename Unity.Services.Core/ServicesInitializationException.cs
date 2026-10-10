using System;

namespace Unity.Services.Core
{
	// Token: 0x02000007 RID: 7
	public class ServicesInitializationException : Exception
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000220D File Offset: 0x0000040D
		public ServicesInitializationException()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002215 File Offset: 0x00000415
		public ServicesInitializationException(string message) : base(message)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000221E File Offset: 0x0000041E
		public ServicesInitializationException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
