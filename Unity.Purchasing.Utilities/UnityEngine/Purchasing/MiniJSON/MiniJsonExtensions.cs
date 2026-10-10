using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.MiniJSON
{
	// Token: 0x02000014 RID: 20
	public static class MiniJsonExtensions
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000028AF File Offset: 0x00000AAF
		public static Dictionary<string, object> GetHash(this Dictionary<string, object> dic, string key)
		{
			return (Dictionary<string, object>)dic[key];
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000028C0 File Offset: 0x00000AC0
		public static T GetEnum<T>(this Dictionary<string, object> dic, string key)
		{
			if (dic.ContainsKey(key))
			{
				return (T)((object)Enum.Parse(typeof(T), dic[key].ToString(), true));
			}
			return default(T);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002901 File Offset: 0x00000B01
		public static string GetString(this Dictionary<string, object> dic, string key, string defaultValue = "")
		{
			if (dic.ContainsKey(key))
			{
				return dic[key].ToString();
			}
			return defaultValue;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000291A File Offset: 0x00000B1A
		public static long GetLong(this Dictionary<string, object> dic, string key)
		{
			if (dic.ContainsKey(key))
			{
				return long.Parse(dic[key].ToString());
			}
			return 0L;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000293C File Offset: 0x00000B3C
		public static List<string> GetStringList(this Dictionary<string, object> dic, string key)
		{
			if (dic.ContainsKey(key))
			{
				List<string> list = new List<string>();
				foreach (object obj in ((List<object>)dic[key]))
				{
					list.Add(obj.ToString());
				}
				return list;
			}
			return new List<string>();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000029B0 File Offset: 0x00000BB0
		public static bool GetBool(this Dictionary<string, object> dic, string key)
		{
			return dic.ContainsKey(key) && bool.Parse(dic[key].ToString());
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000029D0 File Offset: 0x00000BD0
		public static T Get<T>(this Dictionary<string, object> dic, string key)
		{
			if (dic.ContainsKey(key))
			{
				return (T)((object)dic[key]);
			}
			return default(T);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000029FC File Offset: 0x00000BFC
		public static string toJson(this Dictionary<string, object> obj)
		{
			return MiniJson.JsonEncode(obj);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002A04 File Offset: 0x00000C04
		public static string toJson(this Dictionary<string, string> obj)
		{
			return MiniJson.JsonEncode(obj);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002A0C File Offset: 0x00000C0C
		public static string toJson(this string[] array)
		{
			List<object> list = new List<object>();
			foreach (string item in array)
			{
				list.Add(item);
			}
			return MiniJson.JsonEncode(list);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002A40 File Offset: 0x00000C40
		public static List<object> ArrayListFromJson(this string json)
		{
			return MiniJson.JsonDecode(json) as List<object>;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002A4D File Offset: 0x00000C4D
		public static Dictionary<string, object> HashtableFromJson(this string json)
		{
			return MiniJson.JsonDecode(json) as Dictionary<string, object>;
		}
	}
}
