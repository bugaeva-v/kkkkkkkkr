using System;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x0200000D RID: 13
	public class ACL
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000039F3 File Offset: 0x00001BF3
		public ACL()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000039FB File Offset: 0x00001BFB
		public ACL(string userName, string permission)
		{
			this.user = userName;
			this.permission = permission;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003A11 File Offset: 0x00001C11
		public string GetUser()
		{
			return this.user;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003A19 File Offset: 0x00001C19
		public void SetUser(string userName)
		{
			this.user = userName;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003A22 File Offset: 0x00001C22
		public string GetPermission()
		{
			return this.permission;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003A2A File Offset: 0x00001C2A
		public void SetPermission(string permission)
		{
			this.permission = permission;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003A33 File Offset: 0x00001C33
		public override string ToString()
		{
			if (this.user != null && this.permission != null)
			{
				return "user : " + this.user + " permission : " + this.permission;
			}
			return base.ToString();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003A68 File Offset: 0x00001C68
		public JSONNode GetJSONObject()
		{
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add("user", this.user);
			jsonobject.Add("permission", this.permission);
			return jsonobject;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public bool equals(object obj)
		{
			if (obj == null || !(obj is ACL))
			{
				return false;
			}
			if (obj is ACL)
			{
				ACL acl = (ACL)obj;
				return acl.GetUser() != null && acl.GetPermission() != null && acl.GetUser().Equals(this.user) && acl.GetPermission().Equals(this.permission);
			}
			return false;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003B0C File Offset: 0x00001D0C
		public int hashCode()
		{
			string text = this.user + this.permission;
			return text.GetHashCode();
		}

		// Token: 0x04000027 RID: 39
		public string user;

		// Token: 0x04000028 RID: 40
		public string permission;
	}
}
