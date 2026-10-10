using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.user
{
	// Token: 0x020000C9 RID: 201
	public class UserService : App42Service
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x00032A1B File Offset: 0x00030C1B
		public UserService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "user";
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00032A48 File Offset: 0x00030C48
		public void CreateUser(string uName, string pwd, string emailAddress, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(pwd, "Password");
			Util.ThrowExceptionIfNullOrBlank(emailAddress, "EmailAddress");
			Util.ThrowExceptionIfEmailNotValid(emailAddress, "EmailAddress");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"email\":\"" + emailAddress + "\",");
			stringBuilder.Append("\"password\":\"" + pwd + "\",");
			stringBuilder.Append("\"userName\":\"" + uName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00032B7C File Offset: 0x00030D7C
		public void GetUser(string userName, App42CallBack callBack)
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
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00032C2C File Offset: 0x00030E2C
		public void GetAllUsers(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00032CB0 File Offset: 0x00030EB0
		public void UpdateEmail(string uName, string emailAddress, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(emailAddress, "EmailAddress");
			Util.ThrowExceptionIfEmailNotValid(emailAddress, "EmailAddress");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + uName + "\",");
			stringBuilder.Append("\"email\":\"" + emailAddress + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00032DC0 File Offset: 0x00030FC0
		public void DeleteUser(string userName, App42CallBack callBack)
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
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00032E70 File Offset: 0x00031070
		public void CreateOrUpdateProfile(User userObj, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userObj, "User");
			Util.ThrowExceptionIfNullOrBlank(userObj.GetUserName(), "UserName");
			Util.ThrowExceptionIfNullOrBlank(userObj.GetProfile(), "Profile Data");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder = this.CreateProfileJSON(userObj);
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"profileData\":" + stringBuilder.ToString() + ",");
			stringBuilder2.Append("\"userName\":\"" + userObj.GetUserName() + "\"}");
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("{\"app42\":{\"user\":").Append(stringBuilder2.ToString()).Append("}}");
			App42Log.Console("Created JSOn for Profile : " + stringBuilder3);
			dictionary.Add("body", stringBuilder3.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/profile";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder3.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00032FBC File Offset: 0x000311BC
		private StringBuilder CreateProfileJSON(User userObj)
		{
			StringBuilder stringBuilder = new StringBuilder();
			User.Profile profile = userObj.GetProfile();
			string b = "null";
			stringBuilder.Append("{\"firstName\":\"" + profile.GetFirstName() + "\",");
			stringBuilder.Append("\"lastName\":\"" + profile.GetLastName() + "\",");
			if (profile.GetSex() == b)
			{
				stringBuilder.Append("\"sex\":" + profile.GetSex() + ",");
			}
			else
			{
				stringBuilder.Append("\"sex\":\"" + profile.GetSex() + "\",");
			}
			if (profile.GetMobile() == b)
			{
				stringBuilder.Append("\"mobile\":" + profile.GetMobile() + ",");
			}
			else
			{
				stringBuilder.Append("\"mobile\":\"" + profile.GetMobile() + "\",");
			}
			if (profile.GetLine1() == b)
			{
				stringBuilder.Append("\"line1\":" + profile.GetLine1() + ",");
			}
			else
			{
				stringBuilder.Append("\"line1\":\"" + profile.GetLine1() + "\",");
			}
			if (profile.GetLine2() == b)
			{
				stringBuilder.Append("\"line2\":" + profile.GetLine2() + ",");
			}
			else
			{
				stringBuilder.Append("\"line2\":\"" + profile.GetLine2() + "\",");
			}
			if (profile.GetCity() == b)
			{
				stringBuilder.Append("\"city\":" + profile.GetCity() + ",");
			}
			else
			{
				stringBuilder.Append("\"city\":\"" + profile.GetCity() + "\",");
			}
			if (profile.GetState() == b)
			{
				stringBuilder.Append("\"state\":" + profile.GetState() + ",");
			}
			else
			{
				stringBuilder.Append("\"state\":\"" + profile.GetState() + "\",");
			}
			if (profile.GetCountry() == b)
			{
				stringBuilder.Append("\"country\":" + profile.GetCountry() + ",");
			}
			else
			{
				stringBuilder.Append("\"country\":\"" + profile.GetCountry() + "\",");
			}
			if (profile.GetPincode() == b)
			{
				stringBuilder.Append("\"pincode\":" + profile.GetPincode() + ",");
			}
			else
			{
				stringBuilder.Append("\"pincode\":\"" + profile.GetPincode() + "\",");
			}
			if (profile.GetHomeLandLine() == b)
			{
				stringBuilder.Append("\"homeLandLine\":" + profile.GetHomeLandLine() + ",");
			}
			else
			{
				stringBuilder.Append("\"homeLandLine\":\"" + profile.GetHomeLandLine() + "\",");
			}
			if (profile.GetOfficeLandLine() == b)
			{
				stringBuilder.Append("\"officeLandLine\":" + profile.GetOfficeLandLine() + ",");
			}
			else
			{
				stringBuilder.Append("\"officeLandLine\":\"" + profile.GetOfficeLandLine() + "\",");
			}
			if (profile.GetDateOfBirth().ToString() == b)
			{
				stringBuilder.Append("\"dateOfBirth\":" + profile.GetDateOfBirth() + "}");
			}
			else
			{
				stringBuilder.Append("\"dateOfBirth\":\"" + Util.GetUTCFormattedTimestamp(userObj.GetProfile().GetDateOfBirth()) + "\"}");
			}
			return stringBuilder;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0003334C File Offset: 0x0003154C
		public void Authenticate(string uName, string pwd, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(pwd, "Password");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"password\":\"" + pwd + "\",");
			stringBuilder.Append("\"userName\":\"" + uName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/authenticate";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00033454 File Offset: 0x00031654
		public void LockUser(string uName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + uName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/lock";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0003353C File Offset: 0x0003173C
		public void UnlockUser(string uName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "UserName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + uName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/unlock";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00033624 File Offset: 0x00031824
		public void ChangeUserPassword(string uName, string oldPwd, string newPwd, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(oldPwd, "oldPwd");
			Util.ThrowExceptionIfNullOrBlank(newPwd, "newPwd");
			if (oldPwd.Equals(newPwd))
			{
				throw new App42Exception("Old password and new password are same");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + uName + "\",");
			stringBuilder.Append("\"oldPassword\":\"" + oldPwd + "\",");
			stringBuilder.Append("\"newPassword\":\"" + newPwd + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/changeUserPassword";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0003375C File Offset: 0x0003195C
		public void GetLockedUsers(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/locked";
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000337E8 File Offset: 0x000319E8
		public void GetLockedUsersCount(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			string url = this.version + "/" + this.resource + "/count/locked";
			dictionary2.Add("signature", value);
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00033864 File Offset: 0x00031A64
		public void GetUserByEmailId(string emailId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfEmailNotValid(emailId, "EmailId");
			Util.ThrowExceptionIfNullOrBlank(emailId, "EmailId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("emailId", emailId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/email/",
				emailId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00033920 File Offset: 0x00031B20
		public void CreateUser(string uName, string pwd, string emailAddress, IList<string> roleList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(pwd, "Password");
			Util.ThrowExceptionIfNullOrBlank(emailAddress, "EmailAddress");
			Util.ThrowExceptionIfEmailNotValid(emailAddress, "EmailAddress");
			Util.ThrowExceptionIfNullOrBlank(roleList, "RoleList");
			if (roleList.Count == 0)
			{
				throw new App42Exception("RoleList cannot be empty.Please assign atleast one role");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"email\":\"" + emailAddress + "\",");
			stringBuilder.Append("\"password\":\"" + pwd + "\",");
			stringBuilder.Append("\"userName\":\"" + uName + "\",");
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < roleList.Count; i++)
			{
				string text = roleList[i];
				jsonarray.Add(text.ToString());
			}
			stringBuilder.Append("\"roles\":{\"role\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/role";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00033ACC File Offset: 0x00031CCC
		public void AssignRoles(string uName, IList<string> roleList, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(roleList, "RoleList");
			if (roleList.Count == 0)
			{
				throw new App42Exception("RoleList cannot be empty.Please assign atleast one role");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + uName + "\",");
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < roleList.Count; i++)
			{
				string text = roleList[i];
				jsonarray.Add(text.ToString());
			}
			stringBuilder.Append("\"roles\":{\"role\":" + jsonarray.ToString() + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string text2 = this.version + "/" + this.resource + "/assignrole";
			App42Log.Console("resourceURL" + text2);
			RESTConnectorWWW.GetInstance().ExecutePost(text2, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00033C38 File Offset: 0x00031E38
		public void GetRolesByUser(string userName, App42CallBack callBack)
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
				userName,
				"/roles"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00033CF0 File Offset: 0x00031EF0
		public void GetUsersByRole(string role, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(role, "Role");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("role", role);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/role/",
				role
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00033DB0 File Offset: 0x00031FB0
		public void GetLockedUsers(int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
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
				"/locked/",
				max,
				"/",
				offset
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00033EA4 File Offset: 0x000320A4
		public void GetAllUsers(int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
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

		// Token: 0x060008B7 RID: 2231 RVA: 0x00033F98 File Offset: 0x00032198
		public void GetAllUsersCount(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/count/all";
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00034014 File Offset: 0x00032214
		public void GetUsersByProfileData(User.Profile profileData, App42CallBack callBack)
		{
			string text = this.FillParamsWithProfileData(profileData);
			App42Log.Console("PARAMETERS " + text);
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string text2 = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/profile/",
				text
			});
			App42Log.Console("TEST RL" + text2);
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(text2, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000340F0 File Offset: 0x000322F0
		private string FillParamsWithProfileData(User.Profile profileData)
		{
			string text = "";
			if (profileData.GetCity() != null && !profileData.GetCity().Equals(""))
			{
				text = text + "city:" + profileData.GetCity() + "!";
			}
			if (profileData.GetCountry() != null && !profileData.GetCountry().Equals(""))
			{
				text = text + "country:" + profileData.GetCountry() + "!";
			}
			if (!profileData.GetDateOfBirth().Equals(DateTime.MinValue))
			{
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					"date_of_birth:",
					profileData.GetDateOfBirth(),
					"!"
				});
			}
			if (profileData.GetFirstName() != null && !profileData.GetFirstName().Equals(""))
			{
				text = text + "first_name:" + profileData.GetFirstName() + "!";
			}
			if (profileData.GetLastName() != null && !profileData.GetLastName().Equals(""))
			{
				text = text + "last_name:" + profileData.GetLastName() + "!";
			}
			if (profileData.GetHomeLandLine() != null && !profileData.GetHomeLandLine().Equals(""))
			{
				text = text + "home_land_line:" + profileData.GetHomeLandLine() + "!";
			}
			if (profileData.GetLine1() != null && !profileData.GetLine1().Equals(""))
			{
				text = text + "line1:" + profileData.GetLine1() + "!";
			}
			if (profileData.GetLine2() != null && !profileData.GetLine2().Equals(""))
			{
				text = text + "line2:" + profileData.GetLine2() + "!";
			}
			if (profileData.GetMobile() != null && !profileData.GetMobile().Equals(""))
			{
				text = text + "mobile:" + profileData.GetMobile() + "!";
			}
			if (profileData.GetOfficeLandLine() != null && !profileData.GetOfficeLandLine().Equals(""))
			{
				text = text + "office_land_line:" + profileData.GetOfficeLandLine() + "!";
			}
			if (profileData.GetPincode() != null && !profileData.GetPincode().Equals(""))
			{
				text = text + "pincode:" + profileData.GetPincode() + "!";
			}
			if (profileData.GetSex() != null && !profileData.GetSex().Equals(""))
			{
				text = text + "sex:" + profileData.GetSex() + "!";
			}
			if (profileData.GetState() != null && !profileData.GetState().Equals(""))
			{
				text = text + "state:" + profileData.GetState() + "!";
			}
			return text;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00034398 File Offset: 0x00032598
		public void RevokeRole(string userName, string role, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(role, "Role");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userName", userName);
			dictionary.Add("role", role);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				userName,
				"/revoke/",
				role
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0003446C File Offset: 0x0003266C
		public void RevokeAllRoles(string userName, App42CallBack callBack)
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
				userName,
				"/revoke"
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00034524 File Offset: 0x00032724
		public void ResetUserPassword(string userName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userName, "User Name");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + userName + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/resetAppUserPassword";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00034620 File Offset: 0x00032820
		public void Logout(string sessionId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(sessionId, "SessionId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"id\":\"" + sessionId + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"session\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder2.ToString());
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/session";
			App42API.RemoveLocalSession();
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00034718 File Offset: 0x00032918
		public void CreateUserWithProfile(string uName, string pwd, string emailAddress, User.Profile profile, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(uName, "UserName");
			Util.ThrowExceptionIfNullOrBlank(pwd, "Password");
			Util.ThrowExceptionIfNullOrBlank(emailAddress, "EmailAddress");
			Util.ThrowExceptionIfNullOrBlank(profile, "profile");
			Util.ThrowExceptionIfEmailNotValid(emailAddress, "EmailAddress");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"email\":\"" + emailAddress + "\",");
			stringBuilder.Append("\"password\":\"" + pwd + "\",");
			stringBuilder.Append("\"userName\":\"" + uName + "\",");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"firstName\":\"" + profile.GetFirstName() + "\",");
			stringBuilder2.Append("\"lastName\":\"" + profile.GetLastName() + "\",");
			stringBuilder2.Append("\"sex\":\"" + profile.GetSex() + "\",");
			stringBuilder2.Append("\"mobile\":\"" + profile.GetMobile() + "\",");
			stringBuilder2.Append("\"line1\":\"" + profile.GetLine1() + "\",");
			stringBuilder2.Append("\"line2\":\"" + profile.GetLine2() + "\",");
			stringBuilder2.Append("\"city\":\"" + profile.GetCity() + "\",");
			stringBuilder2.Append("\"state\":\"" + profile.GetState() + "\",");
			stringBuilder2.Append("\"country\":\"" + profile.GetCountry() + "\",");
			stringBuilder2.Append("\"pincode\":\"" + profile.GetPincode() + "\",");
			stringBuilder2.Append("\"homeLandLine\":\"" + profile.GetHomeLandLine() + "\",");
			stringBuilder2.Append("\"officeLandLine\":\"" + profile.GetOfficeLandLine() + "\",");
			if (profile.GetDateOfBirth() != DateTime.MinValue)
			{
				stringBuilder2.Append("\"dateOfBirth\":\"" + Util.GetUTCFormattedTimestamp(profile.GetDateOfBirth()) + "\"}");
			}
			else
			{
				stringBuilder2.Append("\"dateOfBirth\": null}");
			}
			stringBuilder.Append("\"profileData\":" + stringBuilder2.ToString() + "}");
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("{\"app42\":{\"user\":").Append(stringBuilder.ToString()).Append("}}");
			App42Log.Console(" Json String : " + stringBuilder3.ToString());
			dictionary.Add("body", stringBuilder3.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/userwithprofile";
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder3.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00034A44 File Offset: 0x00032C44
		public void GetUsersByGroup(IList<string> users, App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < users.Count; i++)
			{
				string text = users[i];
				jsonarray.Add(text.ToString());
			}
			dictionary2.Add("userList", jsonarray.ToString());
			string url = this.version + "/" + this.resource + "/groupusers";
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00034B18 File Offset: 0x00032D18
		public void AddJSONObject(string collectionName, Dictionary<string, object> obj)
		{
			this.dbName = App42API.GetDbName();
			this.collectionName = collectionName;
			this.jsonObject = Util.ConvertDictionaryToJson(obj);
		}
	}
}
