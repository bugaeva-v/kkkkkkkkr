using System;
using System.Collections;
using App42Json;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.app42Event
{
	// Token: 0x02000042 RID: 66
	internal class EventResponse : App42CallBack
	{
		// Token: 0x0600028A RID: 650 RVA: 0x0000E8A6 File Offset: 0x0000CAA6
		public EventResponse(App42CallBack callback)
		{
			this.eventCallback = callback;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000E8B5 File Offset: 0x0000CAB5
		internal EventResponse()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
		public void OnSuccess(object response)
		{
			JsonData jsonData = JsonMapper.ToObject(response.ToString());
			JsonData jsonData2 = jsonData["app42"]["response"];
			IDictionary dictionary = jsonData2;
			string strResponse;
			if (dictionary.Contains("user"))
			{
				JsonData jsonData3 = jsonData2["user"];
				string text = (string)jsonData3["hasProperties"];
				string text2 = jsonData3["installProperties"].ToJson();
				string text3 = (string)jsonData3["app42_userUpdatedOn"];
				if (text != null && Convert.ToBoolean(text))
				{
					App42Log.Console("Saving InstallProperties : " + text2);
					Local.Save("_oldInstallProps" + App42API.loggedInUser, text2);
				}
				else
				{
					App42Log.Console("InstallProperties Not Found For Current LoggedIn User.");
					Local.Save("_oldInstallProps" + App42API.loggedInUser, Local.Fetch("_newInstallProps"));
				}
				if (text3 != null)
				{
					App42Log.Console("Updating UpdatedOn : " + text3);
					Local.Save("_lastUserUpdatedOn" + App42API.loggedInUser, text3);
				}
				strResponse = "{\"app42\":{\"response\":{\"success\":true}}}";
			}
			else
			{
				App42Log.Console("Updating User_UpdatedOn in Offline Mode");
				Local.Save("_lastUserUpdatedOn" + App42API.loggedInUser, Util.GetUTCFormattedTimestamp());
				strResponse = response.ToString();
			}
			if (this.eventCallback != null)
			{
				App42Response app42Response = new App42Response();
				app42Response.SetStrResponse(strResponse);
				app42Response.SetResponseSuccess(true);
				this.eventCallback.OnSuccess(app42Response);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000EA34 File Offset: 0x0000CC34
		public void OnException(Exception exception1)
		{
			if (this.eventCallback != null)
			{
				this.eventCallback.OnException(exception1);
			}
			App42Log.Console("Internal Exception In EventServiceUtils" + exception1.ToString());
		}

		// Token: 0x040000D5 RID: 213
		private App42CallBack eventCallback;
	}
}
