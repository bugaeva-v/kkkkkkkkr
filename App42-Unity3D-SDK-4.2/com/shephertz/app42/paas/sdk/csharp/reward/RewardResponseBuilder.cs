using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.reward
{
	// Token: 0x02000096 RID: 150
	public class RewardResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00024EDC File Offset: 0x000230DC
		public Reward BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("rewards", json);
			if (serviceJSONObject == null)
			{
				Reward reward = new Reward();
				reward.SetStrResponse(json);
				reward.SetResponseSuccess(base.IsResponseSuccess(json));
				reward.SetTotalRecords(base.GetTotalRecords(json));
				return reward;
			}
			JSONNode rewardJSONObj = (JSONObject)serviceJSONObject["reward"];
			Reward reward2 = this.BuildRewardObject(rewardJSONObj);
			reward2.SetStrResponse(json);
			reward2.SetResponseSuccess(base.IsResponseSuccess(json));
			return reward2;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00024F58 File Offset: 0x00023158
		private Reward BuildRewardObject(JSONNode rewardJSONObj)
		{
			Reward reward = new Reward();
			base.BuildObjectFromJSONTree(reward, rewardJSONObj);
			return reward;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00024F74 File Offset: 0x00023174
		public IList<Reward> BuildArrayRewards(string json)
		{
			IList<Reward> list = new List<Reward>();
			JSONNode serviceJSONObject = base.GetServiceJSONObject("rewards", json);
			if (serviceJSONObject["reward"] != null && serviceJSONObject["reward"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)serviceJSONObject["reward"];
				Reward reward = new Reward();
				reward.SetStrResponse(json);
				reward.SetResponseSuccess(base.IsResponseSuccess(json));
				base.BuildObjectFromJSONTree(reward, jsonObj);
				list.Add(reward);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["reward"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode rewardJSONObj = (JSONObject)jsonarray[i];
					Reward reward2 = this.BuildRewardObject(rewardJSONObj);
					reward2.SetStrResponse(json);
					reward2.SetResponseSuccess(base.IsResponseSuccess(json));
					list.Add(reward2);
				}
			}
			return list;
		}
	}
}
