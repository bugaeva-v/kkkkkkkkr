using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App42Json
{
	// Token: 0x0200001A RID: 26
	public class App42JObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000053BE File Offset: 0x000035BE
		public static App42JObject nullJO
		{
			get
			{
				return new App42JObject(App42JObject.Type.NULL);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000053C6 File Offset: 0x000035C6
		public static App42JObject obj
		{
			get
			{
				return new App42JObject(App42JObject.Type.OBJECT);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000053CE File Offset: 0x000035CE
		public static App42JObject arr
		{
			get
			{
				return new App42JObject(App42JObject.Type.ARRAY);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000053D8 File Offset: 0x000035D8
		public App42JObject(App42JObject.Type t)
		{
			this.type = t;
			switch (t)
			{
			case App42JObject.Type.OBJECT:
				this.list = new ArrayList();
				this.keys = new ArrayList();
				return;
			case App42JObject.Type.ARRAY:
				this.list = new ArrayList();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000543D File Offset: 0x0000363D
		public App42JObject(bool b)
		{
			this.type = App42JObject.Type.BOOL;
			this.b = b;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00005469 File Offset: 0x00003669
		public App42JObject(float f)
		{
			this.type = App42JObject.Type.NUMBER;
			this.n = (double)f;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005498 File Offset: 0x00003698
		public App42JObject(Dictionary<string, string> dic)
		{
			this.type = App42JObject.Type.OBJECT;
			foreach (KeyValuePair<string, string> keyValuePair in dic)
			{
				this.keys.Add(keyValuePair.Key);
				this.list.Add(keyValuePair.Value);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005528 File Offset: 0x00003728
		public App42JObject()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005548 File Offset: 0x00003748
		public App42JObject(string str)
		{
			if (str != null)
			{
				if (str.Length <= 0)
				{
					return;
				}
				if (string.Compare(str, "true", StringComparison.OrdinalIgnoreCase) == 0)
				{
					this.type = App42JObject.Type.BOOL;
					this.b = true;
					return;
				}
				if (string.Compare(str, "false", StringComparison.OrdinalIgnoreCase) == 0)
				{
					this.type = App42JObject.Type.BOOL;
					this.b = false;
					return;
				}
				if (str == "null")
				{
					this.type = App42JObject.Type.NULL;
					return;
				}
				if (str[0] == '"')
				{
					this.type = App42JObject.Type.STRING;
					this.str = str.Substring(1, str.Length - 2);
					return;
				}
				try
				{
					this.n = Convert.ToDouble(str);
					this.type = App42JObject.Type.NUMBER;
					return;
				}
				catch (FormatException)
				{
					int num = 0;
					char c = str[0];
					if (c != '[')
					{
						if (c != '{')
						{
							this.type = App42JObject.Type.NULL;
							Debug.LogWarning("improper JSON formatting:" + str);
							return;
						}
						this.type = App42JObject.Type.OBJECT;
						this.keys = new ArrayList();
						this.list = new ArrayList();
					}
					else
					{
						this.type = App42JObject.Type.ARRAY;
						this.list = new ArrayList();
					}
					int num2 = 0;
					bool flag = false;
					bool flag2 = false;
					for (int i = 1; i < str.Length; i++)
					{
						if (str[i] == '\\')
						{
							i++;
						}
						else
						{
							if (str[i] == '"')
							{
								flag = !flag;
							}
							if (str[i] == '[' || str[i] == '{')
							{
								num2++;
							}
							if (num2 == 0 && !flag)
							{
								if (str[i] == ':' && !flag2)
								{
									flag2 = true;
									try
									{
										this.keys.Add(str.Substring(num + 2, i - num - 3));
									}
									catch
									{
										Debug.Log(string.Concat(new object[]
										{
											i,
											" - ",
											str.Length,
											" - ",
											str
										}));
									}
									num = i;
								}
								if (str[i] == ',')
								{
									flag2 = false;
									this.list.Add(new App42JObject(str.Substring(num + 1, i - num - 1)));
									num = i;
								}
								if (str[i] == ']' || str[i] == '}')
								{
									this.list.Add(new App42JObject(str.Substring(num + 1, i - num - 1)));
								}
							}
							if (str[i] == ']' || str[i] == '}')
							{
								num2--;
							}
						}
					}
					return;
				}
			}
			this.type = App42JObject.Type.NULL;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005828 File Offset: 0x00003A28
		public void AddField(bool val)
		{
			this.Add(new App42JObject(val));
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005836 File Offset: 0x00003A36
		public void AddField(float val)
		{
			this.Add(new App42JObject(val));
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005844 File Offset: 0x00003A44
		public void AddField(int val)
		{
			this.Add(new App42JObject((float)val));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00005853 File Offset: 0x00003A53
		public void Add(App42JObject obj)
		{
			if (obj != null)
			{
				if (this.type != App42JObject.Type.ARRAY)
				{
					this.type = App42JObject.Type.ARRAY;
					Debug.LogWarning("something went wrong, when adding object");
				}
				this.list.Add(obj);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000587F File Offset: 0x00003A7F
		public void AddField(string name, bool val)
		{
			this.AddField(name, new App42JObject(val));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000588E File Offset: 0x00003A8E
		public void AddField(string name, float val)
		{
			this.AddField(name, new App42JObject(val));
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000589D File Offset: 0x00003A9D
		public void AddField(string name, int val)
		{
			this.AddField(name, new App42JObject((float)val));
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000058B0 File Offset: 0x00003AB0
		public void AddField(string name, string val)
		{
			this.AddField(name, new App42JObject
			{
				type = App42JObject.Type.STRING,
				str = val
			});
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000058D9 File Offset: 0x00003AD9
		public void AddField(string name, App42JObject obj)
		{
			if (obj != null)
			{
				if (this.type != App42JObject.Type.OBJECT)
				{
					this.type = App42JObject.Type.OBJECT;
					Debug.LogWarning("something went wrong, when adding object");
				}
				this.keys.Add(name);
				this.list.Add(obj);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005912 File Offset: 0x00003B12
		public void SetField(string name, App42JObject obj)
		{
			if (this.HasField(name))
			{
				this.list.Remove(this[name]);
				this.keys.Remove(name);
			}
			this.AddField(name, obj);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005944 File Offset: 0x00003B44
		public App42JObject GetField(string name)
		{
			if (this.type == App42JObject.Type.OBJECT)
			{
				for (int i = 0; i < this.keys.Count; i++)
				{
					if ((string)this.keys[i] == name)
					{
						return (App42JObject)this.list[i];
					}
				}
			}
			return null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000599C File Offset: 0x00003B9C
		public bool HasField(string name)
		{
			if (this.type == App42JObject.Type.OBJECT)
			{
				for (int i = 0; i < this.keys.Count; i++)
				{
					if ((string)this.keys[i] == name)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000059E4 File Offset: 0x00003BE4
		public void Clear()
		{
			this.type = App42JObject.Type.NULL;
			this.list.Clear();
			this.keys.Clear();
			this.str = "";
			this.n = 0.0;
			this.b = false;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005A24 File Offset: 0x00003C24
		public App42JObject Copy()
		{
			return new App42JObject(this.print());
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005A31 File Offset: 0x00003C31
		public void Merge(App42JObject obj)
		{
			App42JObject.MergeRecur(this, obj);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005A3C File Offset: 0x00003C3C
		private static void MergeRecur(App42JObject left, App42JObject right)
		{
			if (right.type == App42JObject.Type.OBJECT)
			{
				for (int i = 0; i < right.list.Count; i++)
				{
					if (right.keys[i] != null)
					{
						string text = (string)right.keys[i];
						App42JObject app42JObject = (App42JObject)right.list[i];
						if (app42JObject.type == App42JObject.Type.ARRAY || app42JObject.type == App42JObject.Type.OBJECT)
						{
							if (left.HasField(text))
							{
								App42JObject.MergeRecur(left[text], app42JObject);
							}
							else
							{
								left.AddField(text, app42JObject);
							}
						}
						else if (left.HasField(text))
						{
							left.SetField(text, app42JObject);
						}
						else
						{
							left.AddField(text, app42JObject);
						}
					}
				}
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005AF2 File Offset: 0x00003CF2
		public string print()
		{
			return this.print(0);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005AFC File Offset: 0x00003CFC
		public string print(int depth)
		{
			if (depth++ > 1000)
			{
				Debug.Log("counter reached to max");
				return "";
			}
			string text = "";
			switch (this.type)
			{
			case App42JObject.Type.NULL:
				text = "null";
				break;
			case App42JObject.Type.STRING:
				text = "\"" + this.str + "\"";
				break;
			case App42JObject.Type.NUMBER:
				text += this.n;
				break;
			case App42JObject.Type.OBJECT:
				if (this.list.Count > 0)
				{
					text = "{";
					for (int i = 0; i < this.list.Count; i++)
					{
						string str = (string)this.keys[i];
						App42JObject app42JObject = (App42JObject)this.list[i];
						if (app42JObject != null)
						{
							text = text + "\"" + str + "\":";
							text = text + app42JObject.print(depth) + ",";
						}
					}
					text = text.Substring(0, text.Length - 1);
					text += "}";
				}
				else
				{
					text += "null";
				}
				break;
			case App42JObject.Type.ARRAY:
				if (this.list.Count > 0)
				{
					text = "[";
					foreach (object obj in this.list)
					{
						App42JObject app42JObject2 = (App42JObject)obj;
						if (app42JObject2 != null)
						{
							text = text + app42JObject2.print(depth) + ",";
						}
					}
					text = text.Substring(0, text.Length - 1);
					text += "]";
				}
				break;
			case App42JObject.Type.BOOL:
				if (this.b)
				{
					text += "true";
				}
				else
				{
					text += "false";
				}
				break;
			}
			return text;
		}

		// Token: 0x17000004 RID: 4
		public App42JObject this[int index]
		{
			get
			{
				return (App42JObject)this.list[index];
			}
		}

		// Token: 0x17000005 RID: 5
		public App42JObject this[string index]
		{
			get
			{
				return this.GetField(index);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005D18 File Offset: 0x00003F18
		public override string ToString()
		{
			return this.print();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005D20 File Offset: 0x00003F20
		public Dictionary<string, string> ToDictionary()
		{
			if (this.type == App42JObject.Type.OBJECT)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				int i = 0;
				while (i < this.list.Count)
				{
					App42JObject app42JObject = (App42JObject)this.list[i];
					switch (app42JObject.type)
					{
					case App42JObject.Type.STRING:
						dictionary.Add((string)this.keys[i], app42JObject.str);
						break;
					case App42JObject.Type.NUMBER:
						dictionary.Add((string)this.keys[i], string.Concat(app42JObject.n));
						break;
					case App42JObject.Type.OBJECT:
					case App42JObject.Type.ARRAY:
						goto IL_C1;
					case App42JObject.Type.BOOL:
						dictionary.Add((string)this.keys[i], string.Concat(app42JObject.b));
						break;
					default:
						goto IL_C1;
					}
					IL_E6:
					i++;
					continue;
					IL_C1:
					Debug.LogWarning("Removing object: " + (string)this.keys[i] + " when converting Dictionary");
					goto IL_E6;
				}
				return dictionary;
			}
			Debug.LogWarning("App42JObject dictionary warning");
			return null;
		}

		// Token: 0x0400005E RID: 94
		private const int MAX_DEPTH = 1000;

		// Token: 0x0400005F RID: 95
		public App42JObject parent;

		// Token: 0x04000060 RID: 96
		public App42JObject.Type type;

		// Token: 0x04000061 RID: 97
		public ArrayList list = new ArrayList();

		// Token: 0x04000062 RID: 98
		public ArrayList keys = new ArrayList();

		// Token: 0x04000063 RID: 99
		public string str;

		// Token: 0x04000064 RID: 100
		public double n;

		// Token: 0x04000065 RID: 101
		public bool b;

		// Token: 0x0200001B RID: 27
		public enum Type
		{
			// Token: 0x04000067 RID: 103
			NULL,
			// Token: 0x04000068 RID: 104
			STRING,
			// Token: 0x04000069 RID: 105
			NUMBER,
			// Token: 0x0400006A RID: 106
			OBJECT,
			// Token: 0x0400006B RID: 107
			ARRAY,
			// Token: 0x0400006C RID: 108
			BOOL
		}
	}
}
