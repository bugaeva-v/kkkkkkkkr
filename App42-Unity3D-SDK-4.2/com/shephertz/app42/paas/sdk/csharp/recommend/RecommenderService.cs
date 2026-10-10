using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.recommend
{
	// Token: 0x02000090 RID: 144
	public class RecommenderService : App42Service
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x00020784 File Offset: 0x0001E984
		public RecommenderService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "recommend";
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000207B0 File Offset: 0x0001E9B0
		public void LoadPreferenceFile(string preferenceFilePath, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(preferenceFilePath, "PreferenceFilePath");
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> postParams = new Dictionary<string, string>();
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteMultipart("preferenceFile", preferenceFilePath, queryParams, postParams, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00020848 File Offset: 0x0001EA48
		public void LoadPreferenceFile(Stream stream, App42CallBack callBack)
		{
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> postParams = new Dictionary<string, string>();
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = Config.GetInstance().GetBaseURL() + this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", stream, queryParams, postParams, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000208E0 File Offset: 0x0001EAE0
		public void UserBasedNeighborhood(long userId, int size, int howMany, App42CallBack callBack)
		{
			Util.ValidateHowMany(howMany);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", string.Concat(userId));
			dictionary.Add("size", string.Concat(size));
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userBasedNeighborhood/",
				userId,
				"/",
				size,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000209F0 File Offset: 0x0001EBF0
		public void UserBasedThreshold(long userId, double threshold, int howMany, App42CallBack callBack)
		{
			Util.ValidateHowMany(howMany);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", string.Concat(userId));
			dictionary.Add("threshold", string.Concat(threshold));
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userBasedThreshold/",
				userId,
				"/",
				threshold,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00020B00 File Offset: 0x0001ED00
		public void UserBasedNeighborhoodBySimilarity(string recommenderSimilarity, long userId, int size, int howMany, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(recommenderSimilarity, "recommenderSimilarity");
			Util.ValidateHowMany(howMany);
			if (!RecommenderSimilarity.EUCLIDEAN_DISTANCE.ToString().Equals(recommenderSimilarity) && !RecommenderSimilarity.PEARSON_CORRELATION.ToString().Equals(recommenderSimilarity))
			{
				throw new App42Exception("Not a Valid RecommenderSimilarity");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", string.Concat(userId));
			dictionary.Add("similarity", recommenderSimilarity ?? "");
			dictionary.Add("howMany", string.Concat(howMany));
			dictionary.Add("size", string.Concat(size));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userBasedNeighborhood/",
				recommenderSimilarity,
				"/",
				userId,
				"/",
				size,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00020C70 File Offset: 0x0001EE70
		public void UserBasedThresholdBySimilarity(string recommenderSimilarity, long userId, double threshold, int howMany, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(recommenderSimilarity, "recommenderSimilarity");
			Util.ValidateHowMany(howMany);
			if (!RecommenderSimilarity.EUCLIDEAN_DISTANCE.ToString().Equals(recommenderSimilarity) && !RecommenderSimilarity.PEARSON_CORRELATION.ToString().Equals(recommenderSimilarity))
			{
				throw new App42Exception("Not a Valid RecommenderSimilarity");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", string.Concat(userId));
			dictionary.Add("similarity", recommenderSimilarity ?? "");
			dictionary.Add("threshold", string.Concat(threshold));
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userBasedThreshold/",
				recommenderSimilarity,
				"/",
				userId,
				"/",
				threshold,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00020DE0 File Offset: 0x0001EFE0
		public void ItemBased(long userId, int howMany, App42CallBack callBack)
		{
			Util.ValidateHowMany(howMany);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", string.Concat(userId));
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/itemBased/",
				userId,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00020EC4 File Offset: 0x0001F0C4
		public void SlopeOne(long userId, int howMany, App42CallBack callBack)
		{
			Util.ValidateHowMany(howMany);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", string.Concat(userId));
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/slopeOne/",
				userId,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00020FA8 File Offset: 0x0001F1A8
		public void UserBasedThresholdForAll(double threshold, int howMany, App42CallBack callBack)
		{
			Util.ValidateHowMany(howMany);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("threshold", string.Concat(threshold));
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userBasedThreshold/all/",
				threshold,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0002108C File Offset: 0x0001F28C
		public void UserBasedNeighborhoodBySimilarityForAll(string recommenderSimilarity, int size, int howMany, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(recommenderSimilarity, "recommenderSimilarity");
			Util.ValidateHowMany(howMany);
			if (!RecommenderSimilarity.EUCLIDEAN_DISTANCE.ToString().Equals(recommenderSimilarity) && !RecommenderSimilarity.PEARSON_CORRELATION.ToString().Equals(recommenderSimilarity))
			{
				throw new App42Exception("Not a Valid RecommenderSimilarity");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("size", string.Concat(size));
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userBasedNeighborhood/all/",
				size,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000211AC File Offset: 0x0001F3AC
		public void UserBasedThresholdBySimilarityForAll(string recommenderSimilarity, double threshold, int howMany, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(recommenderSimilarity, "recommenderSimilarity");
			Util.ValidateHowMany(howMany);
			if (!RecommenderSimilarity.EUCLIDEAN_DISTANCE.ToString().Equals(recommenderSimilarity) && !RecommenderSimilarity.PEARSON_CORRELATION.ToString().Equals(recommenderSimilarity))
			{
				throw new App42Exception("Not a Valid RecommenderSimilarity");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("threshold", string.Concat(threshold));
			dictionary.Add("howMany", string.Concat(howMany));
			dictionary.Add("similarity", recommenderSimilarity ?? "");
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userBasedThreshold/all/",
				recommenderSimilarity,
				"/",
				threshold,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000212F0 File Offset: 0x0001F4F0
		public void ItemBasedForAll(int howMany, App42CallBack callBack)
		{
			Util.ValidateHowMany(howMany);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/itemBased/all/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000213AC File Offset: 0x0001F5AC
		public void ItemBasedBySimilarityForAll(string recommenderSimilarity, int howMany, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(recommenderSimilarity, "recommenderSimilarity");
			Util.ValidateHowMany(howMany);
			if (!RecommenderSimilarity.EUCLIDEAN_DISTANCE.ToString().Equals(recommenderSimilarity) && !RecommenderSimilarity.PEARSON_CORRELATION.ToString().Equals(recommenderSimilarity))
			{
				throw new App42Exception("Not a Valid RecommenderSimilarity");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("howMany", string.Concat(howMany));
			dictionary.Add("similarity", recommenderSimilarity);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/itemBased/all/",
				recommenderSimilarity,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000214BC File Offset: 0x0001F6BC
		public void SlopeOneForAll(int howMany, App42CallBack callBack)
		{
			Util.ValidateHowMany(howMany);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("howMany", string.Concat(howMany));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/slopeOne/all/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00021578 File Offset: 0x0001F778
		public void ItemBasedBySimilarity(string recommenderSimilarity, long userId, int howMany, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(callBack, "callBack");
			Util.ThrowExceptionIfNullOrBlank(recommenderSimilarity, "recommenderSimilarity");
			Util.ValidateHowMany(howMany);
			if (!RecommenderSimilarity.EUCLIDEAN_DISTANCE.ToString().Equals(recommenderSimilarity) && !RecommenderSimilarity.PEARSON_CORRELATION.ToString().Equals(recommenderSimilarity))
			{
				throw new App42Exception("Not a Valid RecommenderSimilarity");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("howMany", string.Concat(howMany));
			dictionary.Add("userId", string.Concat(userId));
			dictionary.Add("similarity", recommenderSimilarity);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/itemBased/",
				recommenderSimilarity,
				"/",
				userId,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000216BC File Offset: 0x0001F8BC
		public void AddOrUpdatePreference(IList<PreferenceData> preferenceDataList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(preferenceDataList, "preferenceDataList");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			JSONArray jsonarray = new JSONArray();
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < preferenceDataList.Count; i++)
			{
				PreferenceData preferenceData = preferenceDataList[i];
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add("UserId", preferenceData.GetUserId());
				jsonobject.Add("itemId", preferenceData.GetItemId());
				jsonobject.Add("preference", preferenceData.GetPreference());
				jsonarray.Add(jsonobject);
			}
			App42Log.Console("preferenceDataArray" + jsonarray);
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"preference\":" + jsonarray.ToString() + "}");
			stringBuilder.Append("{\"preferences\":" + stringBuilder2 + "}");
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("{\"app42\":").Append(stringBuilder.ToString()).Append("}");
			App42Log.Console(" Json String : " + stringBuilder3.ToString());
			dictionary.Add("body", stringBuilder3.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			App42Log.Console("Recommender To String" + stringBuilder3.ToString());
			string url = this.version + "/" + this.resource + "/addOrUpdatePreference";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder3.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00021888 File Offset: 0x0001FA88
		public void UserBasedNeighborhoodForAll(int size, int howMany, App42CallBack callBack)
		{
			Util.ValidateHowMany(howMany);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("howMany", string.Concat(howMany));
			dictionary.Add("size", string.Concat(size));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/userBasedNeighborhood/all/",
				size,
				"/",
				howMany
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0002196C File Offset: 0x0001FB6C
		public void DeleteAllPreferences(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/deleteAllPreferences";
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
