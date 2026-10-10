using System;

namespace UnityEngine
{
	// Token: 0x020001BB RID: 443
	public interface ILogHandler
	{
		// Token: 0x0600135E RID: 4958
		void LogFormat(LogType logType, Object context, string format, params object[] args);

		// Token: 0x0600135F RID: 4959
		void LogException(Exception exception, Object context);
	}
}
