using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.geo
{
	// Token: 0x02000053 RID: 83
	public class GeoService : App42Service
	{
		// Token: 0x06000310 RID: 784 RVA: 0x00010F3A File Offset: 0x0000F13A
		public GeoService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "geo";
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00010F68 File Offset: 0x0000F168
		public void CreateGeoPoints(string geoStorageName, IList<GeoPoint> geoPointsList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(geoStorageName, "Geo Storage Name");
			Util.ThrowExceptionIfNullOrBlank(geoPointsList, "Geo Points List");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"storageName\":\"" + geoStorageName + "\",");
			JSONArray jsonarray = new JSONArray();
			foreach (GeoPoint geoPoint in geoPointsList)
			{
				App42Log.Console(" Geo Points JSON " + geoPoint.GetJSONObject());
				jsonarray.Add(JSONNode.Parse(string.Concat(geoPoint.GetJSONObject())));
			}
			stringBuilder.Append("\"points\":{\"point\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"geo\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/createGeoPoints";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000110E8 File Offset: 0x0000F2E8
		public void GetNearByPoint(string storageName, double lat, double lng, int resultLimit, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(storageName, "Geo Storage Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("storageName", storageName);
			dictionary.Add("lat", string.Concat(lat));
			dictionary.Add("lng", string.Concat(lng));
			dictionary.Add("resultLimit", string.Concat(resultLimit));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/getNearByPoint/storageName/",
				storageName,
				"/lat/",
				lat,
				"/lng/",
				lng,
				"/limit/",
				resultLimit
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00011218 File Offset: 0x0000F418
		public void GetNearByPointsByMaxDistance(string storageName, double lat, double lng, double distanceInKM, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(storageName, "Geo Storage Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("storageName", storageName);
			dictionary.Add("lat", string.Concat(lat));
			dictionary.Add("lng", string.Concat(lng));
			dictionary.Add("distanceInKM", string.Concat(distanceInKM));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/getNearByPoints/storageName/",
				storageName,
				"/lat/",
				lat,
				"/lng/",
				lng,
				"/distanceInKM/",
				distanceInKM
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00011348 File Offset: 0x0000F548
		public void GetPointsWithInCircle(string storageName, double lat, double lng, double radiusInKM, int resultLimit, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(storageName, "Geo Storage Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("storageName", storageName);
			dictionary.Add("lat", string.Concat(lat));
			dictionary.Add("lng", string.Concat(lng));
			dictionary.Add("resultLimit", string.Concat(resultLimit));
			dictionary.Add("radiusInKM", string.Concat(radiusInKM));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/getPointsWithInCircle/storageName/",
				storageName,
				"/lat/",
				lat,
				"/lng/",
				lng,
				"/radiusInKM/",
				radiusInKM,
				"/limit/",
				resultLimit
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public void GetAllStorage(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/storage";
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00011534 File Offset: 0x0000F734
		public void DeleteStorage(string storageName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(storageName, "Geo Storage Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("storageName", storageName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/storage/",
				storageName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000115E4 File Offset: 0x0000F7E4
		public void GetAllPoints(string storageName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(storageName, "Geo Storage Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("storageName", storageName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/points/",
				storageName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00011694 File Offset: 0x0000F894
		public void GetAllStorageByPaging(int max, int offset, App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/",
				max,
				"/",
				offset
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00011780 File Offset: 0x0000F980
		public void DeleteGeoPoints(string geoStorageName, IList<GeoPoint> geoPointsList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(geoStorageName, "Geo Storage Name");
			Util.ThrowExceptionIfNullOrBlank(geoPointsList, "Geo Points List");
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"storageName\":\"" + geoStorageName + "\",");
			JSONArray jsonarray = new JSONArray();
			foreach (GeoPoint geoPoint in geoPointsList)
			{
				App42Log.Console(" Geo Points JSON " + geoPoint.GetJSONObject());
				jsonarray.Add(JSONNode.Parse(string.Concat(geoPoint.GetJSONObject())));
			}
			stringBuilder.Append("\"points\":{\"point\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"geo\":{\"storage\":").Append(stringBuilder.ToString()).Append("}}}}");
			dictionary.Add("geoPoints", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/points/",
				geoStorageName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, dictionary, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0001190C File Offset: 0x0000FB0C
		public void GetAllPointsByPaging(string storageName, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(storageName, "Geo Storage Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("storageName", storageName);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/points/",
				storageName,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
