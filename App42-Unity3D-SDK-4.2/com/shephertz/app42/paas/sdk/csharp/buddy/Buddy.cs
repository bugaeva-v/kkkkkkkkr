using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.buddy
{
	// Token: 0x0200002B RID: 43
	public class Buddy : App42Response
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00008BD0 File Offset: 0x00006DD0
		public string GetMessageId()
		{
			return this.messageId;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00008BD8 File Offset: 0x00006DD8
		public void SetMessageId(string messageId)
		{
			this.messageId = messageId;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00008BE1 File Offset: 0x00006DE1
		public IList<Buddy.Point> GetPointList()
		{
			return this.point;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00008BE9 File Offset: 0x00006DE9
		public void SetPointList(IList<Buddy.Point> point)
		{
			this.point = point;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008BF2 File Offset: 0x00006DF2
		public string GetGroupName()
		{
			return this.groupName;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008BFA File Offset: 0x00006DFA
		public void SetGroupName(string groupName)
		{
			this.groupName = groupName;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008C03 File Offset: 0x00006E03
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008C0B File Offset: 0x00006E0B
		public void SetOwnerName(string ownerName)
		{
			this.ownerName = ownerName;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00008C14 File Offset: 0x00006E14
		public string GetOwnerName()
		{
			return this.ownerName;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00008C1C File Offset: 0x00006E1C
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008C25 File Offset: 0x00006E25
		public string GetBuddyName()
		{
			return this.buddyName;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00008C2D File Offset: 0x00006E2D
		public void SetBuddyName(string buddyName)
		{
			this.buddyName = buddyName;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00008C36 File Offset: 0x00006E36
		public string GetMessage()
		{
			return this.message;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008C3E File Offset: 0x00006E3E
		public void SetMessage(string message)
		{
			this.message = message;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00008C47 File Offset: 0x00006E47
		public DateTime GetAcceptedOn()
		{
			return this.acceptedOn;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00008C4F File Offset: 0x00006E4F
		public void SetAcceptedOn(DateTime acceptedOn)
		{
			this.acceptedOn = acceptedOn;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00008C58 File Offset: 0x00006E58
		public DateTime GetSendedOn()
		{
			return this.sendedOn;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00008C60 File Offset: 0x00006E60
		public void SetSendedOn(DateTime sendedOn)
		{
			this.sendedOn = sendedOn;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00008C69 File Offset: 0x00006E69
		public override string ToString()
		{
			return base.GetStrResponse();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00008C71 File Offset: 0x00006E71
		public IList<Buddy> GetBuddyList()
		{
			return this.buddyList;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00008C79 File Offset: 0x00006E79
		public void SetBuddyList(IList<Buddy> buddyList)
		{
			this.buddyList = buddyList;
		}

		// Token: 0x0400008D RID: 141
		public string userName;

		// Token: 0x0400008E RID: 142
		public string buddyName;

		// Token: 0x0400008F RID: 143
		public string groupName;

		// Token: 0x04000090 RID: 144
		public string ownerName;

		// Token: 0x04000091 RID: 145
		public string message;

		// Token: 0x04000092 RID: 146
		public DateTime sendedOn;

		// Token: 0x04000093 RID: 147
		public DateTime acceptedOn;

		// Token: 0x04000094 RID: 148
		public string messageId;

		// Token: 0x04000095 RID: 149
		public IList<Buddy.Point> point = new List<Buddy.Point>();

		// Token: 0x04000096 RID: 150
		public IList<Buddy> buddyList = new List<Buddy>();

		// Token: 0x0200002C RID: 44
		public class Point
		{
			// Token: 0x060001A8 RID: 424 RVA: 0x00008CA0 File Offset: 0x00006EA0
			public Point(Buddy buddy)
			{
				buddy.point.Add(this);
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00008CB4 File Offset: 0x00006EB4
			public DateTime GetCreatedOn()
			{
				return this.createdOn;
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00008CBC File Offset: 0x00006EBC
			public void SetCreatedOn(DateTime createdOn)
			{
				this.createdOn = createdOn;
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00008CC5 File Offset: 0x00006EC5
			public double GetLatitude()
			{
				return this.latitude;
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00008CCD File Offset: 0x00006ECD
			public void SetLatitude(double latitude)
			{
				this.latitude = latitude;
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00008CD6 File Offset: 0x00006ED6
			public double GetLongitude()
			{
				return this.longitude;
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00008CDE File Offset: 0x00006EDE
			public void SetLongitude(double longitude)
			{
				this.longitude = longitude;
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00008CE7 File Offset: 0x00006EE7
			public string GetMarkerName()
			{
				return this.markerName;
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00008CEF File Offset: 0x00006EEF
			public void SetMarkerName(string markerName)
			{
				this.markerName = markerName;
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00008CF8 File Offset: 0x00006EF8
			public string GetBuddyName()
			{
				return this.buddyName;
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00008D00 File Offset: 0x00006F00
			public void SetBuddyName(string buddyName)
			{
				this.buddyName = buddyName;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00008D0C File Offset: 0x00006F0C
			public JSONNode GetJSONObject()
			{
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add("latitude", this.latitude);
				jsonobject.Add("longitude", this.longitude);
				jsonobject.Add("markerName", this.markerName);
				return jsonobject;
			}

			// Token: 0x04000097 RID: 151
			public double latitude;

			// Token: 0x04000098 RID: 152
			public double longitude;

			// Token: 0x04000099 RID: 153
			public string markerName;

			// Token: 0x0400009A RID: 154
			public DateTime createdOn;

			// Token: 0x0400009B RID: 155
			public string buddyName;
		}
	}
}
