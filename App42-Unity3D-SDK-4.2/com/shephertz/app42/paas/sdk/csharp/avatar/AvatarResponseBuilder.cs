using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.avatar
{
	// Token: 0x02000023 RID: 35
	public class AvatarResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00006C30 File Offset: 0x00004E30
		public Avatar BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("avatars", json);
			if (serviceJSONObject == null)
			{
				Avatar avatar = new Avatar();
				avatar.SetStrResponse(json);
				avatar.SetResponseSuccess(base.IsResponseSuccess(json));
				avatar.SetTotalRecords(base.GetTotalRecords(json));
				return avatar;
			}
			JSONNode avatarJSONObject = (JSONObject)serviceJSONObject["avatar"];
			Avatar avatar2 = this.BuildAvatarObject(avatarJSONObject);
			avatar2.SetStrResponse(json);
			avatar2.SetResponseSuccess(base.IsResponseSuccess(json));
			return avatar2;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006CAC File Offset: 0x00004EAC
		private Avatar BuildAvatarObject(JSONNode avatarJSONObject)
		{
			Avatar avatar = new Avatar();
			base.BuildObjectFromJSONTree(avatar, avatarJSONObject);
			return avatar;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006CC8 File Offset: 0x00004EC8
		public IList<Avatar> BuildArrayResponse(string response)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("avatars", response);
			IList<Avatar> list = new List<Avatar>();
			if (serviceJSONObject["avatar"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["avatar"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode avatarJSONObject = (JSONObject)jsonarray[i];
					Avatar avatar = this.BuildAvatarObject(avatarJSONObject);
					avatar.SetStrResponse(response);
					avatar.SetResponseSuccess(base.IsResponseSuccess(response));
					list.Add(avatar);
				}
			}
			else
			{
				JSONNode avatarJSONObject2 = (JSONObject)serviceJSONObject["avatar"];
				Avatar avatar2 = this.BuildAvatarObject(avatarJSONObject2);
				avatar2.SetStrResponse(response);
				avatar2.SetResponseSuccess(base.IsResponseSuccess(response));
				list.Add(avatar2);
			}
			return list;
		}
	}
}
