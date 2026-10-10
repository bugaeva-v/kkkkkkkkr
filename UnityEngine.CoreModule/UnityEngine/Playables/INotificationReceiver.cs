using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000436 RID: 1078
	[RequiredByNativeCode]
	public interface INotificationReceiver
	{
		// Token: 0x06002585 RID: 9605
		[RequiredByNativeCode]
		void OnNotify(Playable origin, INotification notification, object context);
	}
}
