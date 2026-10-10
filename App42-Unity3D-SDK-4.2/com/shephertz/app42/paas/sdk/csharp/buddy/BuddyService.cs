using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.geo;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.buddy
{
	// Token: 0x0200002E RID: 46
	public class BuddyService : App42Service
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x00008F9B File Offset: 0x0000719B
		public BuddyService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "buddy";
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00008FC8 File Offset: 0x000071C8
		public void SendFriendRequest(string userName, string buddyName, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(buddyName, "BuddyName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"buddyName\":\"" + buddyName + "\",");
			stringBuilder.Append("\"message\":\"" + message + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000090FC File Offset: 0x000072FC
		public void GetFriendRequest(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000091BC File Offset: 0x000073BC
		public void AcceptFriendRequest(string userName, string buddyName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(buddyName, "BuddyName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"buddyName\":\"" + buddyName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000092D8 File Offset: 0x000074D8
		public void RejectFriendRequest(string userName, string buddyName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(buddyName, "BuddyName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("buddyName", buddyName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/userName/",
				userName,
				"/buddyName/",
				buddyName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000093AC File Offset: 0x000075AC
		public void GetAllFriends(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/friends/",
				userName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000946C File Offset: 0x0000766C
		public void CreateGroupByUser(string userName, string groupName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(groupName, "GroupName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"groupName\":\"" + groupName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/group";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000958C File Offset: 0x0000778C
		public void AddFriendToGroup(string userName, string groupName, IList<string> friends, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(groupName, "GroupName");
			Util.ThrowExceptionIfNullOrBlank(friends, "FriendList");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < friends.Count; i++)
			{
				string text = friends[i];
				jsonarray.Add(text.ToString());
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"groupName\":\"" + groupName + "\",");
			stringBuilder.Append("\"friends\":{\"friend\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/group/friends";
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00009720 File Offset: 0x00007920
		public void BlockUser(string userName, string buddyName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(buddyName, "BuddyName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"buddyName\":\"" + buddyName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/block";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00009840 File Offset: 0x00007A40
		public void UnblockUser(string userName, string buddyName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(buddyName, "BuddyName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"buddyName\":\"" + buddyName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/unblock";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00009960 File Offset: 0x00007B60
		public void BlockFriendRequest(string userName, string buddyName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(buddyName, "BuddyName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("buddyName", buddyName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/block/userName/",
				userName,
				"/buddyName/",
				buddyName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00009A34 File Offset: 0x00007C34
		public void GetAllGroups(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/groupall/",
				userName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00009AF4 File Offset: 0x00007CF4
		public void GetAllFriendsInGroup(string userName, string ownerName, string groupName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(ownerName, "OwnerName");
			Util.ThrowExceptionIfNullOrBlank(groupName, "GroupName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("ownerName", ownerName);
			dictionary.Add("groupName", groupName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/friends/",
				userName,
				"/group/",
				ownerName,
				"/",
				groupName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00009C00 File Offset: 0x00007E00
		public void CheckedInGeoLocation(string userName, GeoPoint point, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(point, "Point");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"points\":{\"point\":" + point.GetJSONObject() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/checkedIn";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009D24 File Offset: 0x00007F24
		public void GetFriendsByLocation(string userName, double latitude, double longitude, double maxDistance, int max, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(latitude, "Latitude");
			Util.ThrowExceptionIfNullOrBlank(longitude, "Longitude");
			Util.ThrowExceptionIfNullOrBlank(maxDistance, "MaxDistance");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("maxDistance", string.Concat(maxDistance));
			dictionary.Add("latitude", string.Concat(latitude));
			dictionary.Add("longitude", string.Concat(longitude));
			dictionary.Add("max", string.Concat(max));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/friends/location/",
				userName,
				"/",
				maxDistance,
				"/",
				latitude,
				"/",
				longitude,
				"/",
				max
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009EC4 File Offset: 0x000080C4
		public void SendMessageToGroup(string userName, string ownerName, string groupName, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(ownerName, "OwnerName");
			Util.ThrowExceptionIfNullOrBlank(groupName, "groupName");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"ownerName\":\"" + ownerName + "\",");
			stringBuilder.Append("\"message\":\"" + message + "\",");
			stringBuilder.Append("\"groupName\":\"" + groupName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/groupmessage";
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000A03C File Offset: 0x0000823C
		public void SendMessageToFriend(string userName, string buddyName, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(buddyName, "buddyName");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"message\":\"" + message + "\",");
			stringBuilder.Append("\"buddyName\":\"" + buddyName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/friendmessage";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000A168 File Offset: 0x00008368
		public void SendMessageToFriends(string userName, string message, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(message, "message");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\",");
			stringBuilder.Append("\"message\":\"" + message + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"buddy\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/messageAll";
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000A280 File Offset: 0x00008480
		public void GetAllMessages(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/message/",
				userName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000A340 File Offset: 0x00008540
		public void GetAllMessagesFromBuddy(string userName, string buddyName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("buddyName", buddyName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/buddyMessage/",
				userName,
				"/",
				buddyName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000A41C File Offset: 0x0000861C
		public void GetAllMessagesFromGroup(string userName, string groupOwner, string groupName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(groupOwner, "groupOwner");
			Util.ThrowExceptionIfNullOrBlank(groupName, "groupName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("ownerName", groupOwner);
			dictionary.Add("groupName", groupName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/groupMassaage/",
				groupOwner,
				"/",
				groupName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000A528 File Offset: 0x00008728
		public void UnFriend(string userName, string buddyName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(buddyName, "BuddyName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("buddyName", buddyName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/unfriend/userName/",
				userName,
				"/buddyName/",
				buddyName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000A5FC File Offset: 0x000087FC
		public void DeleteMessageById(string userName, string messageId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(messageId, "MessageId");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			App42Log.SetDebug(true);
			JSONArray jsonarray = new JSONArray();
			jsonarray.Add(messageId);
			dictionary2.Add("messageIds", jsonarray.ToString());
			dictionary.Add("messageIds", jsonarray.ToString());
			dictionary2.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteMessageById/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000A6F4 File Offset: 0x000088F4
		public void DeleteMessageByIds(string userName, IList<string> messageIds, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(messageIds, "MessageIds");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			App42Log.SetDebug(true);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < messageIds.Count; i++)
			{
				string text = messageIds[i];
				jsonarray.Add(text.ToString());
			}
			dictionary2.Add("messageIds", jsonarray.ToString());
			dictionary.Add("messageIds", jsonarray.ToString());
			dictionary2.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteMessageById/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, dictionary, dictionary2, dictionary3, callBack);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000A810 File Offset: 0x00008A10
		public void DeleteAllMessages(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/deleteAllMessages/",
				userName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		public void GetBlockedBuddyList(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/blockedList/",
				userName
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
