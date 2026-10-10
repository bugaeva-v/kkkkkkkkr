using System;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.abTest
{
	// Token: 0x02000006 RID: 6
	internal class ABTestResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002460 File Offset: 0x00000660
		public ABTest BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("abtest", json);
			ABTest abtest = this.BuildABTestObject(serviceJSONObject);
			abtest.SetStrResponse(json);
			abtest.SetResponseSuccess(base.IsResponseSuccess(json));
			return abtest;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002498 File Offset: 0x00000698
		private ABTest BuildABTestObject(JSONNode abTestJSONObj)
		{
			ABTest abtest = new ABTest();
			base.BuildObjectFromJSONTree(abtest, abTestJSONObj);
			if (abTestJSONObj["variant"] != null)
			{
				JSONNode jsonObj = (JSONObject)abTestJSONObj["variant"];
				ABTest.Variant obj = new ABTest.Variant(abtest);
				base.BuildObjectFromJSONTree(obj, jsonObj);
			}
			return abtest;
		}
	}
}
