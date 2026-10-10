using System;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.upload
{
	// Token: 0x020000C0 RID: 192
	public class UploadResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x0002FEE4 File Offset: 0x0002E0E4
		public Upload BuildResponse(string json)
		{
			Upload upload = new Upload();
			upload.SetStrResponse(json);
			upload.SetResponseSuccess(base.IsResponseSuccess(json));
			upload.SetTotalRecords(base.GetTotalRecords(json));
			JSONNode serviceJSONObject = base.GetServiceJSONObject("upload", json);
			if (serviceJSONObject == null)
			{
				return upload;
			}
			JSONNode jsonnode = (JSONObject)serviceJSONObject["files"];
			if (jsonnode["file"] is JSONObject)
			{
				JSONNode jsonObj = (JSONObject)jsonnode["file"];
				Upload.File obj = new Upload.File(upload);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			else
			{
				JSONArray jsonarray = (JSONArray)jsonnode["file"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					Upload.File obj2 = new Upload.File(upload);
					JSONNode jsonObj2 = (JSONObject)jsonarray[i];
					base.BuildObjectFromJSONTree(obj2, jsonObj2);
				}
			}
			return upload;
		}
	}
}
