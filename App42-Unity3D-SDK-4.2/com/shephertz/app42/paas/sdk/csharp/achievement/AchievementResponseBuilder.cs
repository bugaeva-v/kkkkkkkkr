using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.achievement
{
	// Token: 0x0200000A RID: 10
	internal class AchievementResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000030F0 File Offset: 0x000012F0
		public Achievement BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("achievements", json);
			if (serviceJSONObject == null)
			{
				Achievement achievement = new Achievement();
				achievement.SetStrResponse(json);
				achievement.SetResponseSuccess(base.IsResponseSuccess(json));
				achievement.SetTotalRecords(base.GetTotalRecords(json));
				return achievement;
			}
			JSONNode achievementJSONObject = (JSONObject)serviceJSONObject["achievement"];
			Achievement achievement2 = this.BuildAchievementObject(achievementJSONObject);
			achievement2.SetStrResponse(json);
			achievement2.SetResponseSuccess(base.IsResponseSuccess(json));
			return achievement2;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000316C File Offset: 0x0000136C
		private Achievement BuildAchievementObject(JSONNode achievementJSONObject)
		{
			Achievement achievement = new Achievement();
			base.BuildObjectFromJSONTree(achievement, achievementJSONObject);
			return achievement;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003188 File Offset: 0x00001388
		public IList<Achievement> BuildArrayResponse(string response)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("achievements", response);
			IList<Achievement> list = new List<Achievement>();
			if (serviceJSONObject["achievement"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["achievement"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode achievementJSONObject = (JSONObject)jsonarray[i];
					Achievement achievement = this.BuildAchievementObject(achievementJSONObject);
					achievement.SetStrResponse(response);
					achievement.SetResponseSuccess(base.IsResponseSuccess(response));
					list.Add(achievement);
				}
			}
			else
			{
				JSONNode achievementJSONObject2 = (JSONObject)serviceJSONObject["achievement"];
				Achievement achievement2 = this.BuildAchievementObject(achievementJSONObject2);
				achievement2.SetStrResponse(response);
				achievement2.SetResponseSuccess(base.IsResponseSuccess(response));
				list.Add(achievement2);
			}
			return list;
		}
	}
}
