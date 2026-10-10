using System;
using System.Collections;
using System.Collections.Specialized;

namespace App42Json
{
	// Token: 0x0200005B RID: 91
	public interface IJsonWrapper : IList, IOrderedDictionary, IDictionary, ICollection, IEnumerable
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000356 RID: 854
		bool IsArray { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000357 RID: 855
		bool IsBoolean { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000358 RID: 856
		bool IsDouble { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000359 RID: 857
		bool IsInt { get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600035A RID: 858
		bool IsLong { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600035B RID: 859
		bool IsObject { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600035C RID: 860
		bool IsString { get; }

		// Token: 0x0600035D RID: 861
		bool GetBoolean();

		// Token: 0x0600035E RID: 862
		double GetDouble();

		// Token: 0x0600035F RID: 863
		int GetInt();

		// Token: 0x06000360 RID: 864
		JsonType GetJsonType();

		// Token: 0x06000361 RID: 865
		long GetLong();

		// Token: 0x06000362 RID: 866
		string GetString();

		// Token: 0x06000363 RID: 867
		void SetBoolean(bool val);

		// Token: 0x06000364 RID: 868
		void SetDouble(double val);

		// Token: 0x06000365 RID: 869
		void SetInt(int val);

		// Token: 0x06000366 RID: 870
		void SetJsonType(JsonType type);

		// Token: 0x06000367 RID: 871
		void SetLong(long val);

		// Token: 0x06000368 RID: 872
		void SetString(string val);

		// Token: 0x06000369 RID: 873
		string ToJson();

		// Token: 0x0600036A RID: 874
		void ToJson(JsonWriter writer);
	}
}
