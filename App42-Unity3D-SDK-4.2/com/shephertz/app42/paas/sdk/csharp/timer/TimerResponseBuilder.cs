using System;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.timer
{
	// Token: 0x020000BC RID: 188
	public class TimerResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x0002F82C File Offset: 0x0002DA2C
		public Timer BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("timer", json);
			if (serviceJSONObject == null)
			{
				Timer timer = new Timer();
				timer.SetStrResponse(json);
				timer.SetResponseSuccess(base.IsResponseSuccess(json));
				timer.SetTotalRecords(base.GetTotalRecords(json));
				return timer;
			}
			Timer timer2 = this.BuildTimerObject(serviceJSONObject);
			timer2.SetStrResponse(json);
			timer2.SetResponseSuccess(base.IsResponseSuccess(json));
			return timer2;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0002F898 File Offset: 0x0002DA98
		private Timer BuildTimerObject(JSONNode timerJSONObj)
		{
			Timer timer = new Timer();
			base.BuildObjectFromJSONTree(timer, timerJSONObj);
			return timer;
		}
	}
}
