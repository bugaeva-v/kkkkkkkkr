using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000016 RID: 22
	public interface App42CallBack
	{
		// Token: 0x060000EA RID: 234
		void OnSuccess(object response);

		// Token: 0x060000EB RID: 235
		void OnException(Exception ex);
	}
}
