using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

namespace App42Json
{
	// Token: 0x02000063 RID: 99
	public class JsonData : IJsonWrapper, IList, IOrderedDictionary, IDictionary, ICollection, IEnumerable, IEquatable<JsonData>
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00014B49 File Offset: 0x00012D49
		public int Count
		{
			get
			{
				return this.EnsureCollection().Count;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00014B56 File Offset: 0x00012D56
		public bool IsArray
		{
			get
			{
				return this.type == JsonType.Array;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00014B61 File Offset: 0x00012D61
		public bool IsBoolean
		{
			get
			{
				return this.type == JsonType.Boolean;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00014B6C File Offset: 0x00012D6C
		public bool IsDouble
		{
			get
			{
				return this.type == JsonType.Double;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00014B77 File Offset: 0x00012D77
		public bool IsInt
		{
			get
			{
				return this.type == JsonType.Int;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00014B82 File Offset: 0x00012D82
		public bool IsLong
		{
			get
			{
				return this.type == JsonType.Long;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00014B8D File Offset: 0x00012D8D
		public bool IsObject
		{
			get
			{
				return this.type == JsonType.Object;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00014B98 File Offset: 0x00012D98
		public bool IsString
		{
			get
			{
				return this.type == JsonType.String;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00014BA3 File Offset: 0x00012DA3
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00014BAB File Offset: 0x00012DAB
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.EnsureCollection().IsSynchronized;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00014BB8 File Offset: 0x00012DB8
		object ICollection.SyncRoot
		{
			get
			{
				return this.EnsureCollection().SyncRoot;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00014BC5 File Offset: 0x00012DC5
		bool IDictionary.IsFixedSize
		{
			get
			{
				return this.EnsureDictionary().IsFixedSize;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00014BD2 File Offset: 0x00012DD2
		bool IDictionary.IsReadOnly
		{
			get
			{
				return this.EnsureDictionary().IsReadOnly;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00014BE0 File Offset: 0x00012DE0
		ICollection IDictionary.Keys
		{
			get
			{
				this.EnsureDictionary();
				IList<string> list = new List<string>();
				foreach (KeyValuePair<string, JsonData> keyValuePair in this.object_list)
				{
					list.Add(keyValuePair.Key);
				}
				return (ICollection)list;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00014C48 File Offset: 0x00012E48
		ICollection IDictionary.Values
		{
			get
			{
				this.EnsureDictionary();
				IList<JsonData> list = new List<JsonData>();
				foreach (KeyValuePair<string, JsonData> keyValuePair in this.object_list)
				{
					list.Add(keyValuePair.Value);
				}
				return (ICollection)list;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00014CB0 File Offset: 0x00012EB0
		bool IJsonWrapper.IsArray
		{
			get
			{
				return this.IsArray;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00014CB8 File Offset: 0x00012EB8
		bool IJsonWrapper.IsBoolean
		{
			get
			{
				return this.IsBoolean;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00014CC0 File Offset: 0x00012EC0
		bool IJsonWrapper.IsDouble
		{
			get
			{
				return this.IsDouble;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00014CC8 File Offset: 0x00012EC8
		bool IJsonWrapper.IsInt
		{
			get
			{
				return this.IsInt;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00014CD0 File Offset: 0x00012ED0
		bool IJsonWrapper.IsLong
		{
			get
			{
				return this.IsLong;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00014CD8 File Offset: 0x00012ED8
		bool IJsonWrapper.IsObject
		{
			get
			{
				return this.IsObject;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00014CE0 File Offset: 0x00012EE0
		bool IJsonWrapper.IsString
		{
			get
			{
				return this.IsString;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00014CE8 File Offset: 0x00012EE8
		bool IList.IsFixedSize
		{
			get
			{
				return this.EnsureList().IsFixedSize;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00014CF5 File Offset: 0x00012EF5
		bool IList.IsReadOnly
		{
			get
			{
				return this.EnsureList().IsReadOnly;
			}
		}

		// Token: 0x17000029 RID: 41
		object IDictionary.this[object key]
		{
			get
			{
				return this.EnsureDictionary()[key];
			}
			set
			{
				if (!(key is string))
				{
					throw new ArgumentException("The key has to be a string");
				}
				JsonData value2 = this.ToJsonData(value);
				this[(string)key] = value2;
			}
		}

		// Token: 0x1700002A RID: 42
		object IOrderedDictionary.this[int idx]
		{
			get
			{
				this.EnsureDictionary();
				return this.object_list[idx].Value;
			}
			set
			{
				this.EnsureDictionary();
				JsonData value2 = this.ToJsonData(value);
				KeyValuePair<string, JsonData> keyValuePair = this.object_list[idx];
				this.inst_object[keyValuePair.Key] = value2;
				KeyValuePair<string, JsonData> value3 = new KeyValuePair<string, JsonData>(keyValuePair.Key, value2);
				this.object_list[idx] = value3;
			}
		}

		// Token: 0x1700002B RID: 43
		object IList.this[int index]
		{
			get
			{
				return this.EnsureList()[index];
			}
			set
			{
				this.EnsureList();
				JsonData value2 = this.ToJsonData(value);
				this[index] = value2;
			}
		}

		// Token: 0x1700002C RID: 44
		public JsonData this[string prop_name]
		{
			get
			{
				this.EnsureDictionary();
				return this.inst_object[prop_name];
			}
			set
			{
				this.EnsureDictionary();
				KeyValuePair<string, JsonData> keyValuePair = new KeyValuePair<string, JsonData>(prop_name, value);
				if (this.inst_object.ContainsKey(prop_name))
				{
					for (int i = 0; i < this.object_list.Count; i++)
					{
						if (this.object_list[i].Key == prop_name)
						{
							this.object_list[i] = keyValuePair;
							break;
						}
					}
				}
				else
				{
					this.object_list.Add(keyValuePair);
				}
				this.inst_object[prop_name] = value;
				this.json = null;
			}
		}

		// Token: 0x1700002D RID: 45
		public JsonData this[int index]
		{
			get
			{
				this.EnsureCollection();
				if (this.type == JsonType.Array)
				{
					return this.inst_array[index];
				}
				return this.object_list[index].Value;
			}
			set
			{
				this.EnsureCollection();
				if (this.type == JsonType.Array)
				{
					this.inst_array[index] = value;
				}
				else
				{
					KeyValuePair<string, JsonData> keyValuePair = this.object_list[index];
					KeyValuePair<string, JsonData> value2 = new KeyValuePair<string, JsonData>(keyValuePair.Key, value);
					this.object_list[index] = value2;
					this.inst_object[keyValuePair.Key] = value;
				}
				this.json = null;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00014F53 File Offset: 0x00013153
		public JsonData()
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00014F5B File Offset: 0x0001315B
		public JsonData(bool boolean)
		{
			this.type = JsonType.Boolean;
			this.inst_boolean = boolean;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00014F71 File Offset: 0x00013171
		public JsonData(double number)
		{
			this.type = JsonType.Double;
			this.inst_double = number;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00014F87 File Offset: 0x00013187
		public JsonData(int number)
		{
			this.type = JsonType.Int;
			this.inst_int = number;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00014F9D File Offset: 0x0001319D
		public JsonData(long number)
		{
			this.type = JsonType.Long;
			this.inst_long = number;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00014FB4 File Offset: 0x000131B4
		public JsonData(object obj)
		{
			if (obj is bool)
			{
				this.type = JsonType.Boolean;
				this.inst_boolean = (bool)obj;
				return;
			}
			if (obj is double)
			{
				this.type = JsonType.Double;
				this.inst_double = (double)obj;
				return;
			}
			if (obj is int)
			{
				this.type = JsonType.Int;
				this.inst_int = (int)obj;
				return;
			}
			if (obj is long)
			{
				this.type = JsonType.Long;
				this.inst_long = (long)obj;
				return;
			}
			if (obj is string)
			{
				this.type = JsonType.String;
				this.inst_string = (string)obj;
				return;
			}
			throw new ArgumentException("Unable to wrap the given object with JsonData");
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001505D File Offset: 0x0001325D
		public JsonData(string str)
		{
			this.type = JsonType.String;
			this.inst_string = str;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00015073 File Offset: 0x00013273
		public static implicit operator JsonData(bool data)
		{
			return new JsonData(data);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001507B File Offset: 0x0001327B
		public static implicit operator JsonData(double data)
		{
			return new JsonData(data);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00015083 File Offset: 0x00013283
		public static implicit operator JsonData(int data)
		{
			return new JsonData(data);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001508B File Offset: 0x0001328B
		public static implicit operator JsonData(long data)
		{
			return new JsonData(data);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00015093 File Offset: 0x00013293
		public static implicit operator JsonData(string data)
		{
			return new JsonData(data);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001509B File Offset: 0x0001329B
		public static explicit operator bool(JsonData data)
		{
			if (data.type != JsonType.Boolean)
			{
				throw new InvalidCastException("Instance of JsonData doesn't hold a double");
			}
			return data.inst_boolean;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000150B7 File Offset: 0x000132B7
		public static explicit operator double(JsonData data)
		{
			if (data.type != JsonType.Double)
			{
				throw new InvalidCastException("Instance of JsonData doesn't hold a double");
			}
			return data.inst_double;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000150D3 File Offset: 0x000132D3
		public static explicit operator int(JsonData data)
		{
			if (data.type != JsonType.Int)
			{
				throw new InvalidCastException("Instance of JsonData doesn't hold an int");
			}
			return data.inst_int;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000150EF File Offset: 0x000132EF
		public static explicit operator long(JsonData data)
		{
			if (data.type != JsonType.Long)
			{
				throw new InvalidCastException("Instance of JsonData doesn't hold an int");
			}
			return data.inst_long;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001510B File Offset: 0x0001330B
		public static explicit operator string(JsonData data)
		{
			if (data.type != JsonType.String)
			{
				throw new InvalidCastException("Instance of JsonData doesn't hold a string");
			}
			return data.inst_string;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00015127 File Offset: 0x00013327
		void ICollection.CopyTo(Array array, int index)
		{
			this.EnsureCollection().CopyTo(array, index);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00015138 File Offset: 0x00013338
		void IDictionary.Add(object key, object value)
		{
			JsonData value2 = this.ToJsonData(value);
			this.EnsureDictionary().Add(key, value2);
			KeyValuePair<string, JsonData> item = new KeyValuePair<string, JsonData>((string)key, value2);
			this.object_list.Add(item);
			this.json = null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0001517B File Offset: 0x0001337B
		void IDictionary.Clear()
		{
			this.EnsureDictionary().Clear();
			this.object_list.Clear();
			this.json = null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001519A File Offset: 0x0001339A
		bool IDictionary.Contains(object key)
		{
			return this.EnsureDictionary().Contains(key);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000151A8 File Offset: 0x000133A8
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return ((IOrderedDictionary)this).GetEnumerator();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000151B0 File Offset: 0x000133B0
		void IDictionary.Remove(object key)
		{
			this.EnsureDictionary().Remove(key);
			for (int i = 0; i < this.object_list.Count; i++)
			{
				if (this.object_list[i].Key == (string)key)
				{
					this.object_list.RemoveAt(i);
					break;
				}
			}
			this.json = null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00015215 File Offset: 0x00013415
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.EnsureCollection().GetEnumerator();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00015222 File Offset: 0x00013422
		bool IJsonWrapper.GetBoolean()
		{
			if (this.type != JsonType.Boolean)
			{
				throw new InvalidOperationException("JsonData instance doesn't hold a boolean");
			}
			return this.inst_boolean;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001523E File Offset: 0x0001343E
		double IJsonWrapper.GetDouble()
		{
			if (this.type != JsonType.Double)
			{
				throw new InvalidOperationException("JsonData instance doesn't hold a double");
			}
			return this.inst_double;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0001525A File Offset: 0x0001345A
		int IJsonWrapper.GetInt()
		{
			if (this.type != JsonType.Int)
			{
				throw new InvalidOperationException("JsonData instance doesn't hold an int");
			}
			return this.inst_int;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00015276 File Offset: 0x00013476
		long IJsonWrapper.GetLong()
		{
			if (this.type != JsonType.Long)
			{
				throw new InvalidOperationException("JsonData instance doesn't hold a long");
			}
			return this.inst_long;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00015292 File Offset: 0x00013492
		string IJsonWrapper.GetString()
		{
			if (this.type != JsonType.String)
			{
				throw new InvalidOperationException("JsonData instance doesn't hold a string");
			}
			return this.inst_string;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000152AE File Offset: 0x000134AE
		void IJsonWrapper.SetBoolean(bool val)
		{
			this.type = JsonType.Boolean;
			this.inst_boolean = val;
			this.json = null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000152C5 File Offset: 0x000134C5
		void IJsonWrapper.SetDouble(double val)
		{
			this.type = JsonType.Double;
			this.inst_double = val;
			this.json = null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000152DC File Offset: 0x000134DC
		void IJsonWrapper.SetInt(int val)
		{
			this.type = JsonType.Int;
			this.inst_int = val;
			this.json = null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000152F3 File Offset: 0x000134F3
		void IJsonWrapper.SetLong(long val)
		{
			this.type = JsonType.Long;
			this.inst_long = val;
			this.json = null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001530A File Offset: 0x0001350A
		void IJsonWrapper.SetString(string val)
		{
			this.type = JsonType.String;
			this.inst_string = val;
			this.json = null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00015321 File Offset: 0x00013521
		string IJsonWrapper.ToJson()
		{
			return this.ToJson();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00015329 File Offset: 0x00013529
		void IJsonWrapper.ToJson(JsonWriter writer)
		{
			this.ToJson(writer);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00015332 File Offset: 0x00013532
		int IList.Add(object value)
		{
			return this.Add(value);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001533B File Offset: 0x0001353B
		void IList.Clear()
		{
			this.EnsureList().Clear();
			this.json = null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0001534F File Offset: 0x0001354F
		bool IList.Contains(object value)
		{
			return this.EnsureList().Contains(value);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0001535D File Offset: 0x0001355D
		int IList.IndexOf(object value)
		{
			return this.EnsureList().IndexOf(value);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0001536B File Offset: 0x0001356B
		void IList.Insert(int index, object value)
		{
			this.EnsureList().Insert(index, value);
			this.json = null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00015381 File Offset: 0x00013581
		void IList.Remove(object value)
		{
			this.EnsureList().Remove(value);
			this.json = null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00015396 File Offset: 0x00013596
		void IList.RemoveAt(int index)
		{
			this.EnsureList().RemoveAt(index);
			this.json = null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000153AB File Offset: 0x000135AB
		IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
		{
			this.EnsureDictionary();
			return new OrderedDictionaryEnumerator(this.object_list.GetEnumerator());
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000153C4 File Offset: 0x000135C4
		void IOrderedDictionary.Insert(int idx, object key, object value)
		{
			string text = (string)key;
			JsonData value2 = this.ToJsonData(value);
			this[text] = value2;
			KeyValuePair<string, JsonData> item = new KeyValuePair<string, JsonData>(text, value2);
			this.object_list.Insert(idx, item);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00015400 File Offset: 0x00013600
		void IOrderedDictionary.RemoveAt(int idx)
		{
			this.EnsureDictionary();
			this.inst_object.Remove(this.object_list[idx].Key);
			this.object_list.RemoveAt(idx);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00015440 File Offset: 0x00013640
		private ICollection EnsureCollection()
		{
			if (this.type == JsonType.Array)
			{
				return (ICollection)this.inst_array;
			}
			if (this.type == JsonType.Object)
			{
				return (ICollection)this.inst_object;
			}
			throw new InvalidOperationException("The JsonData instance has to be initialized first");
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00015478 File Offset: 0x00013678
		private IDictionary EnsureDictionary()
		{
			if (this.type == JsonType.Object)
			{
				return (IDictionary)this.inst_object;
			}
			if (this.type != JsonType.None)
			{
				throw new InvalidOperationException("Instance of JsonData is not a dictionary");
			}
			this.type = JsonType.Object;
			this.inst_object = new Dictionary<string, JsonData>();
			this.object_list = new List<KeyValuePair<string, JsonData>>();
			return (IDictionary)this.inst_object;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000154D8 File Offset: 0x000136D8
		private IList EnsureList()
		{
			if (this.type == JsonType.Array)
			{
				return (IList)this.inst_array;
			}
			if (this.type != JsonType.None)
			{
				throw new InvalidOperationException("Instance of JsonData is not a list");
			}
			this.type = JsonType.Array;
			this.inst_array = new List<JsonData>();
			return (IList)this.inst_array;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0001552A File Offset: 0x0001372A
		private JsonData ToJsonData(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			if (obj is JsonData)
			{
				return (JsonData)obj;
			}
			return new JsonData(obj);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00015548 File Offset: 0x00013748
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
			if (obj.IsString)
			{
				writer.Write(obj.GetString());
				return;
			}
			if (obj.IsBoolean)
			{
				writer.Write(obj.GetBoolean());
				return;
			}
			if (obj.IsDouble)
			{
				writer.Write(obj.GetDouble());
				return;
			}
			if (obj.IsInt)
			{
				writer.Write(obj.GetInt());
				return;
			}
			if (obj.IsLong)
			{
				writer.Write(obj.GetLong());
				return;
			}
			if (obj.IsArray)
			{
				writer.WriteArrayStart();
				foreach (object obj2 in obj)
				{
					JsonData.WriteJson((JsonData)obj2, writer);
				}
				writer.WriteArrayEnd();
				return;
			}
			if (obj.IsObject)
			{
				writer.WriteObjectStart();
				foreach (object obj3 in obj)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj3;
					writer.WritePropertyName((string)dictionaryEntry.Key);
					JsonData.WriteJson((JsonData)dictionaryEntry.Value, writer);
				}
				writer.WriteObjectEnd();
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00015698 File Offset: 0x00013898
		public int Add(object value)
		{
			JsonData value2 = this.ToJsonData(value);
			this.json = null;
			return this.EnsureList().Add(value2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000156C0 File Offset: 0x000138C0
		public void Clear()
		{
			if (this.IsObject)
			{
				((IDictionary)this).Clear();
				return;
			}
			if (this.IsArray)
			{
				((IList)this).Clear();
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000156E0 File Offset: 0x000138E0
		public bool Equals(JsonData x)
		{
			if (x == null)
			{
				return false;
			}
			if (x.type != this.type)
			{
				return false;
			}
			switch (this.type)
			{
			case JsonType.None:
				return true;
			case JsonType.Object:
				return this.inst_object.Equals(x.inst_object);
			case JsonType.Array:
				return this.inst_array.Equals(x.inst_array);
			case JsonType.String:
				return this.inst_string.Equals(x.inst_string);
			case JsonType.Int:
				return this.inst_int.Equals(x.inst_int);
			case JsonType.Long:
				return this.inst_long.Equals(x.inst_long);
			case JsonType.Double:
				return this.inst_double.Equals(x.inst_double);
			case JsonType.Boolean:
				return this.inst_boolean.Equals(x.inst_boolean);
			default:
				return false;
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000157B5 File Offset: 0x000139B5
		public JsonType GetJsonType()
		{
			return this.type;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000157C0 File Offset: 0x000139C0
		public void SetJsonType(JsonType type)
		{
			if (this.type == type)
			{
				return;
			}
			switch (type)
			{
			case JsonType.Object:
				this.inst_object = new Dictionary<string, JsonData>();
				this.object_list = new List<KeyValuePair<string, JsonData>>();
				break;
			case JsonType.Array:
				this.inst_array = new List<JsonData>();
				break;
			case JsonType.String:
				this.inst_string = null;
				break;
			case JsonType.Int:
				this.inst_int = 0;
				break;
			case JsonType.Long:
				this.inst_long = 0L;
				break;
			case JsonType.Double:
				this.inst_double = 0.0;
				break;
			case JsonType.Boolean:
				this.inst_boolean = false;
				break;
			}
			this.type = type;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00015864 File Offset: 0x00013A64
		public string ToJson()
		{
			if (this.json != null)
			{
				return this.json;
			}
			StringWriter stringWriter = new StringWriter();
			JsonData.WriteJson(this, new JsonWriter(stringWriter)
			{
				Validate = false
			});
			this.json = stringWriter.ToString();
			return this.json;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000158B0 File Offset: 0x00013AB0
		public void ToJson(JsonWriter writer)
		{
			bool validate = writer.Validate;
			writer.Validate = false;
			JsonData.WriteJson(this, writer);
			writer.Validate = validate;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000158DC File Offset: 0x00013ADC
		public override string ToString()
		{
			switch (this.type)
			{
			case JsonType.Object:
				return "JsonData object";
			case JsonType.Array:
				return "JsonData array";
			case JsonType.String:
				return this.inst_string;
			case JsonType.Int:
				return this.inst_int.ToString();
			case JsonType.Long:
				return this.inst_long.ToString();
			case JsonType.Double:
				return this.inst_double.ToString();
			case JsonType.Boolean:
				return this.inst_boolean.ToString();
			default:
				return "Uninitialized JsonData";
			}
		}

		// Token: 0x0400018D RID: 397
		private IList<JsonData> inst_array;

		// Token: 0x0400018E RID: 398
		private bool inst_boolean;

		// Token: 0x0400018F RID: 399
		private double inst_double;

		// Token: 0x04000190 RID: 400
		private int inst_int;

		// Token: 0x04000191 RID: 401
		private long inst_long;

		// Token: 0x04000192 RID: 402
		private IDictionary<string, JsonData> inst_object;

		// Token: 0x04000193 RID: 403
		private string inst_string;

		// Token: 0x04000194 RID: 404
		private string json;

		// Token: 0x04000195 RID: 405
		private JsonType type;

		// Token: 0x04000196 RID: 406
		private IList<KeyValuePair<string, JsonData>> object_list;
	}
}
