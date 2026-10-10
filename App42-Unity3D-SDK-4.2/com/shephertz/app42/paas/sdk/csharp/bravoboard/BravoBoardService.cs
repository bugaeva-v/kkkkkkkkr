using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.bravoboard
{
	// Token: 0x0200002A RID: 42
	public class BravoBoardService : App42Service
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00007D54 File Offset: 0x00005F54
		public BravoBoardService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "bravoboard";
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007D80 File Offset: 0x00005F80
		public void PostActivityWithItemId(string userID, string itemID, string comment, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userID, "User Id");
			Util.ThrowExceptionIfNullOrBlank(itemID, "Item Id");
			Util.ThrowExceptionIfNullOrBlank(comment, "Comment");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userId\":\"" + userID + "\",");
			stringBuilder.Append("\"itemId\":\"" + itemID + "\",");
			stringBuilder.Append("\"comment\":\"" + comment + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"bravo\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console("Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/comment";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007EC4 File Offset: 0x000060C4
		public void PostActivityWithItemId(string userID, string itemID, string comment, string tagName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userID, "User Id");
			Util.ThrowExceptionIfNullOrBlank(itemID, "Item Id");
			Util.ThrowExceptionIfNullOrBlank(comment, "Comment");
			Util.ThrowExceptionIfNullOrBlank(tagName, "Tag Name");
			base.SetOtherMetaHeaders(new Dictionary<string, string>
			{
				{
					"tag",
					tagName
				}
			});
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userId\":\"" + userID + "\",");
			stringBuilder.Append("\"itemId\":\"" + itemID + "\",");
			stringBuilder.Append("\"comment\":\"" + comment + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"bravo\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console("Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/comment";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00008030 File Offset: 0x00006230
		public void PostActivity(string userID, string comment, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userID, "User Id");
			Util.ThrowExceptionIfNullOrBlank(comment, "Comment");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string id = Util.GetID();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userId\":\"" + userID + "\",");
			stringBuilder.Append("\"itemId\":\"" + id + "\",");
			stringBuilder.Append("\"comment\":\"" + comment + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"bravo\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console("Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/comment";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00008170 File Offset: 0x00006370
		public void PostActivity(string userID, string comment, string tagName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userID, "User Id");
			Util.ThrowExceptionIfNullOrBlank(comment, "Comment");
			base.SetOtherMetaHeaders(new Dictionary<string, string>
			{
				{
					"tag",
					tagName
				}
			});
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string id = Util.GetID();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userId\":\"" + userID + "\",");
			stringBuilder.Append("\"itemId\":\"" + id + "\",");
			stringBuilder.Append("\"comment\":\"" + comment + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"bravo\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console("Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/comment";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000082CC File Offset: 0x000064CC
		public void GetActivityByItem(string itemId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(itemId, "Item Id");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("itemId", itemId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/comment/item/",
				itemId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000838C File Offset: 0x0000658C
		public void GetActivityByItem(string itemId, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(itemId, "ItemId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("itemId", itemId);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/comment/item/",
				itemId,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000084A0 File Offset: 0x000066A0
		public void GetActivityCountByItem(string itemId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(itemId, "ItemId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("itemId", itemId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/comment/item/",
				itemId,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00008558 File Offset: 0x00006758
		public void GetActivityCountByTag(string tagName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(tagName, "TagName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("tagName", tagName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/comment/tag/",
				tagName,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00008610 File Offset: 0x00006810
		public void GetActivityByTag(string tagName, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(tagName, "tagName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("tagName", tagName);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/comment/paging/tag/",
				tagName,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00008724 File Offset: 0x00006924
		public void AddTagToActivity(string tag, string activityId, string userId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(activityId, "ActivityId");
			Util.ThrowExceptionIfNullOrBlank(tag, "Tag");
			Util.ThrowExceptionIfNullOrBlank(userId, "UserId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"tag\":\"" + tag + "\",");
			stringBuilder.Append("\"commentId\":\"" + activityId + "\",");
			stringBuilder.Append("\"userId\":\"" + userId + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"bravo\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/addtagtocomment";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00008850 File Offset: 0x00006A50
		public void DeleteActivityById(string activityId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(activityId, "ActivityId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("commentId", activityId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteComment/",
				activityId
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00008900 File Offset: 0x00006B00
		public void DeleteTag(string activityId, string userId, string tagName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(activityId, "ActivityId");
			Util.ThrowExceptionIfNullOrBlank(userId, "User Id");
			Util.ThrowExceptionIfNullOrBlank(tagName, "Tag Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("commentId", activityId);
			dictionary.Add("userId", userId);
			dictionary.Add("tagName", tagName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteTag/",
				activityId,
				"/",
				userId,
				"/",
				tagName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000089FC File Offset: 0x00006BFC
		public void GetActivityByUser(string userId, int max, int offset, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userId, "userId");
			Util.ValidateMax(max);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", userId);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/activities/",
				userId,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008B18 File Offset: 0x00006D18
		public void GetActivityCountByUser(string userId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userId, "userId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", userId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/activity/userId/",
				userId,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
