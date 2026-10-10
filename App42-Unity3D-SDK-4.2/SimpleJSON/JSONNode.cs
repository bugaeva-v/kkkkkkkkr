using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x020000A1 RID: 161
	public abstract class JSONNode
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600068F RID: 1679
		public abstract JSONNodeType Tag { get; }

		// Token: 0x17000048 RID: 72
		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x000282B9 File Offset: 0x000264B9
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x000282C0 File Offset: 0x000264C0
		public virtual string Value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x000282C2 File Offset: 0x000264C2
		public virtual int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000282C5 File Offset: 0x000264C5
		public virtual bool IsNumber
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x000282C8 File Offset: 0x000264C8
		public virtual bool IsString
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000282CB File Offset: 0x000264CB
		public virtual bool IsBoolean
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x000282CE File Offset: 0x000264CE
		public virtual bool IsNull
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x000282D1 File Offset: 0x000264D1
		public virtual bool IsArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000282D4 File Offset: 0x000264D4
		public virtual bool IsObject
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x000282D7 File Offset: 0x000264D7
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x000282DA File Offset: 0x000264DA
		public virtual bool Inline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000282DC File Offset: 0x000264DC
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000282DE File Offset: 0x000264DE
		public virtual void Add(JSONNode aItem)
		{
			this.Add("", aItem);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000282EC File Offset: 0x000264EC
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000282EF File Offset: 0x000264EF
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000282F2 File Offset: 0x000264F2
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return aNode;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x000283A0 File Offset: 0x000265A0
		public virtual IEnumerable<JSONNode> Children
		{
			get
			{
				yield break;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x000285DC File Offset: 0x000267DC
		public IEnumerable<JSONNode> DeepChildren
		{
			get
			{
				foreach (JSONNode C in this.Children)
				{
					foreach (JSONNode D in C.DeepChildren)
					{
						yield return D;
					}
				}
				yield break;
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000285FC File Offset: 0x000267FC
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.WriteToStringBuilder(stringBuilder, 0, 0, JSONTextMode.Compact);
			return stringBuilder.ToString();
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00028620 File Offset: 0x00026820
		public virtual string ToString(int aIndent)
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.WriteToStringBuilder(stringBuilder, 0, aIndent, JSONTextMode.Indent);
			return stringBuilder.ToString();
		}

		// Token: 0x060006A8 RID: 1704
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		// Token: 0x060006A9 RID: 1705
		public abstract JSONNode.Enumerator GetEnumerator();

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00028643 File Offset: 0x00026843
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			get
			{
				return new JSONNode.LinqEnumerator(this);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0002864B File Offset: 0x0002684B
		public JSONNode.KeyEnumerator Keys
		{
			get
			{
				return new JSONNode.KeyEnumerator(this.GetEnumerator());
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00028658 File Offset: 0x00026858
		public JSONNode.ValueEnumerator Values
		{
			get
			{
				return new JSONNode.ValueEnumerator(this.GetEnumerator());
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00028668 File Offset: 0x00026868
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00028699 File Offset: 0x00026899
		public virtual double AsDouble
		{
			get
			{
				double result = 0.0;
				if (double.TryParse(this.Value, out result))
				{
					return result;
				}
				return 0.0;
			}
			set
			{
				this.Value = value.ToString();
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x000286A8 File Offset: 0x000268A8
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000286B1 File Offset: 0x000268B1
		public virtual int AsInt
		{
			get
			{
				return (int)this.AsDouble;
			}
			set
			{
				this.AsDouble = (double)value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x000286BB File Offset: 0x000268BB
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x000286C4 File Offset: 0x000268C4
		public virtual float AsFloat
		{
			get
			{
				return (float)this.AsDouble;
			}
			set
			{
				this.AsDouble = (double)value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000286D0 File Offset: 0x000268D0
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000286FE File Offset: 0x000268FE
		public virtual bool AsBool
		{
			get
			{
				bool result = false;
				if (bool.TryParse(this.Value, out result))
				{
					return result;
				}
				return !string.IsNullOrEmpty(this.Value);
			}
			set
			{
				this.Value = (value ? "true" : "false");
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00028715 File Offset: 0x00026915
		public virtual JSONArray AsArray
		{
			get
			{
				return this as JSONArray;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0002871D File Offset: 0x0002691D
		public virtual JSONObject AsObject
		{
			get
			{
				return this as JSONObject;
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00028725 File Offset: 0x00026925
		public static implicit operator JSONNode(string s)
		{
			return new JSONString(s);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0002872D File Offset: 0x0002692D
		public static implicit operator string(JSONNode d)
		{
			if (!(d == null))
			{
				return d.Value;
			}
			return null;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00028740 File Offset: 0x00026940
		public static implicit operator JSONNode(double n)
		{
			return new JSONNumber(n);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00028748 File Offset: 0x00026948
		public static implicit operator double(JSONNode d)
		{
			if (!(d == null))
			{
				return d.AsDouble;
			}
			return 0.0;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00028763 File Offset: 0x00026963
		public static implicit operator JSONNode(float n)
		{
			return new JSONNumber((double)n);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0002876C File Offset: 0x0002696C
		public static implicit operator float(JSONNode d)
		{
			if (!(d == null))
			{
				return d.AsFloat;
			}
			return 0f;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00028783 File Offset: 0x00026983
		public static implicit operator JSONNode(int n)
		{
			return new JSONNumber((double)n);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0002878C File Offset: 0x0002698C
		public static implicit operator int(JSONNode d)
		{
			if (!(d == null))
			{
				return d.AsInt;
			}
			return 0;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0002879F File Offset: 0x0002699F
		public static implicit operator JSONNode(bool b)
		{
			return new JSONBool(b);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000287A7 File Offset: 0x000269A7
		public static implicit operator bool(JSONNode d)
		{
			return !(d == null) && d.AsBool;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000287BA File Offset: 0x000269BA
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return aKeyValue.Value;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000287C4 File Offset: 0x000269C4
		public static bool operator ==(JSONNode a, object b)
		{
			if (object.ReferenceEquals(a, b))
			{
				return true;
			}
			bool flag = a is JSONNull || object.ReferenceEquals(a, null) || a is JSONLazyCreator;
			bool flag2 = b is JSONNull || object.ReferenceEquals(b, null) || b is JSONLazyCreator;
			return (flag && flag2) || (!flag && a.Equals(b));
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0002882C File Offset: 0x00026A2C
		public static bool operator !=(JSONNode a, object b)
		{
			return !(a == b);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00028838 File Offset: 0x00026A38
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00028841 File Offset: 0x00026A41
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00028849 File Offset: 0x00026A49
		internal static StringBuilder EscapeBuilder
		{
			get
			{
				if (JSONNode.m_EscapeBuilder == null)
				{
					JSONNode.m_EscapeBuilder = new StringBuilder();
				}
				return JSONNode.m_EscapeBuilder;
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00028864 File Offset: 0x00026A64
		internal static string Escape(string aText)
		{
			StringBuilder escapeBuilder = JSONNode.EscapeBuilder;
			escapeBuilder.Length = 0;
			if (escapeBuilder.Capacity < aText.Length + aText.Length / 10)
			{
				escapeBuilder.Capacity = aText.Length + aText.Length / 10;
			}
			int i = 0;
			while (i < aText.Length)
			{
				char c = aText[i];
				char c2 = c;
				switch (c2)
				{
				case '\b':
					escapeBuilder.Append("\\b");
					break;
				case '\t':
					escapeBuilder.Append("\\t");
					break;
				case '\n':
					escapeBuilder.Append("\\n");
					break;
				case '\v':
					goto IL_E8;
				case '\f':
					escapeBuilder.Append("\\f");
					break;
				case '\r':
					escapeBuilder.Append("\\r");
					break;
				default:
					if (c2 != '"')
					{
						if (c2 != '\\')
						{
							goto IL_E8;
						}
						escapeBuilder.Append("\\\\");
					}
					else
					{
						escapeBuilder.Append("\\\"");
					}
					break;
				}
				IL_122:
				i++;
				continue;
				IL_E8:
				if (c < ' ' || (JSONNode.forceASCII && c > '\u007f'))
				{
					ushort num = (ushort)c;
					escapeBuilder.Append("\\u").Append(num.ToString("X4"));
					goto IL_122;
				}
				escapeBuilder.Append(c);
				goto IL_122;
			}
			string result = escapeBuilder.ToString();
			escapeBuilder.Length = 0;
			return result;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000289B8 File Offset: 0x00026BB8
		private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
			if (quoted)
			{
				ctx.Add(tokenName, token);
				return;
			}
			string a = token.ToLower();
			if (a == "false" || a == "true")
			{
				ctx.Add(tokenName, a == "true");
				return;
			}
			if (a == "null")
			{
				ctx.Add(tokenName, null);
				return;
			}
			double num;
			if (double.TryParse(token, out num))
			{
				ctx.Add(tokenName, num);
				return;
			}
			ctx.Add(tokenName, token);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00028A4C File Offset: 0x00026C4C
		public static JSONNode Parse(string aJSON)
		{
			Stack<JSONNode> stack = new Stack<JSONNode>();
			JSONNode jsonnode = null;
			int i = 0;
			StringBuilder stringBuilder = new StringBuilder();
			string text = "";
			bool flag = false;
			bool flag2 = false;
			while (i < aJSON.Length)
			{
				char c = aJSON[i];
				if (c <= ',')
				{
					switch (c)
					{
					case '\t':
						break;
					case '\n':
					case '\r':
						goto IL_335;
					case '\v':
					case '\f':
						goto IL_327;
					default:
						switch (c)
						{
						case ' ':
							break;
						case '!':
							goto IL_327;
						case '"':
							flag = !flag;
							flag2 = (flag2 || flag);
							goto IL_335;
						default:
							if (c != ',')
							{
								goto IL_327;
							}
							if (flag)
							{
								stringBuilder.Append(aJSON[i]);
								goto IL_335;
							}
							if (stringBuilder.Length > 0 || flag2)
							{
								JSONNode.ParseElement(jsonnode, stringBuilder.ToString(), text, flag2);
							}
							text = "";
							stringBuilder.Length = 0;
							flag2 = false;
							goto IL_335;
						}
						break;
					}
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
					}
				}
				else if (c != ':')
				{
					switch (c)
					{
					case '[':
						if (flag)
						{
							stringBuilder.Append(aJSON[i]);
							goto IL_335;
						}
						stack.Push(new JSONArray());
						if (jsonnode != null)
						{
							jsonnode.Add(text, stack.Peek());
						}
						text = "";
						stringBuilder.Length = 0;
						jsonnode = stack.Peek();
						goto IL_335;
					case '\\':
						i++;
						if (flag)
						{
							char c2 = aJSON[i];
							char c3 = c2;
							if (c3 <= 'f')
							{
								if (c3 == 'b')
								{
									stringBuilder.Append('\b');
									goto IL_335;
								}
								if (c3 == 'f')
								{
									stringBuilder.Append('\f');
									goto IL_335;
								}
							}
							else
							{
								if (c3 == 'n')
								{
									stringBuilder.Append('\n');
									goto IL_335;
								}
								switch (c3)
								{
								case 'r':
									stringBuilder.Append('\r');
									goto IL_335;
								case 't':
									stringBuilder.Append('\t');
									goto IL_335;
								case 'u':
								{
									string s = aJSON.Substring(i + 1, 4);
									stringBuilder.Append((char)int.Parse(s, NumberStyles.AllowHexSpecifier));
									i += 4;
									goto IL_335;
								}
								}
							}
							stringBuilder.Append(c2);
							goto IL_335;
						}
						goto IL_335;
					case ']':
						break;
					default:
						switch (c)
						{
						case '{':
							if (flag)
							{
								stringBuilder.Append(aJSON[i]);
								goto IL_335;
							}
							stack.Push(new JSONObject());
							if (jsonnode != null)
							{
								jsonnode.Add(text, stack.Peek());
							}
							text = "";
							stringBuilder.Length = 0;
							jsonnode = stack.Peek();
							goto IL_335;
						case '|':
							goto IL_327;
						case '}':
							break;
						default:
							goto IL_327;
						}
						break;
					}
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
					}
					else
					{
						if (stack.Count == 0)
						{
							throw new Exception("JSON Parse: Too many closing brackets");
						}
						stack.Pop();
						if (stringBuilder.Length > 0 || flag2)
						{
							JSONNode.ParseElement(jsonnode, stringBuilder.ToString(), text, flag2);
							flag2 = false;
						}
						text = "";
						stringBuilder.Length = 0;
						if (stack.Count > 0)
						{
							jsonnode = stack.Peek();
						}
					}
				}
				else if (flag)
				{
					stringBuilder.Append(aJSON[i]);
				}
				else
				{
					text = stringBuilder.ToString();
					stringBuilder.Length = 0;
					flag2 = false;
				}
				IL_335:
				i++;
				continue;
				IL_327:
				stringBuilder.Append(aJSON[i]);
				goto IL_335;
			}
			if (flag)
			{
				throw new Exception("JSON Parse: Quotation marks seems to be messed up.");
			}
			return jsonnode;
		}

		// Token: 0x0400028C RID: 652
		public static bool forceASCII = false;

		// Token: 0x0400028D RID: 653
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		// Token: 0x020000A2 RID: 162
		public struct Enumerator
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060006CC RID: 1740 RVA: 0x00028DBE File Offset: 0x00026FBE
			public bool IsValid
			{
				get
				{
					return this.type != JSONNode.Enumerator.Type.None;
				}
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x00028DCC File Offset: 0x00026FCC
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				this.type = JSONNode.Enumerator.Type.Array;
				this.m_Object = default(Dictionary<string, JSONNode>.Enumerator);
				this.m_Array = aArrayEnum;
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x00028DE8 File Offset: 0x00026FE8
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				this.type = JSONNode.Enumerator.Type.Object;
				this.m_Object = aDictEnum;
				this.m_Array = default(List<JSONNode>.Enumerator);
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060006CF RID: 1743 RVA: 0x00028E04 File Offset: 0x00027004
			public KeyValuePair<string, JSONNode> Current
			{
				get
				{
					if (this.type == JSONNode.Enumerator.Type.Array)
					{
						return new KeyValuePair<string, JSONNode>(string.Empty, this.m_Array.Current);
					}
					if (this.type == JSONNode.Enumerator.Type.Object)
					{
						return this.m_Object.Current;
					}
					return new KeyValuePair<string, JSONNode>(string.Empty, null);
				}
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x00028E50 File Offset: 0x00027050
			public bool MoveNext()
			{
				if (this.type == JSONNode.Enumerator.Type.Array)
				{
					return this.m_Array.MoveNext();
				}
				return this.type == JSONNode.Enumerator.Type.Object && this.m_Object.MoveNext();
			}

			// Token: 0x0400028E RID: 654
			private JSONNode.Enumerator.Type type;

			// Token: 0x0400028F RID: 655
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			// Token: 0x04000290 RID: 656
			private List<JSONNode>.Enumerator m_Array;

			// Token: 0x020000A3 RID: 163
			private enum Type
			{
				// Token: 0x04000292 RID: 658
				None,
				// Token: 0x04000293 RID: 659
				Array,
				// Token: 0x04000294 RID: 660
				Object
			}
		}

		// Token: 0x020000A4 RID: 164
		public struct ValueEnumerator
		{
			// Token: 0x060006D1 RID: 1745 RVA: 0x00028E7D File Offset: 0x0002707D
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				this = new JSONNode.ValueEnumerator(new JSONNode.Enumerator(aArrayEnum));
			}

			// Token: 0x060006D2 RID: 1746 RVA: 0x00028E8B File Offset: 0x0002708B
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				this = new JSONNode.ValueEnumerator(new JSONNode.Enumerator(aDictEnum));
			}

			// Token: 0x060006D3 RID: 1747 RVA: 0x00028E99 File Offset: 0x00027099
			public ValueEnumerator(JSONNode.Enumerator aEnumerator)
			{
				this.m_Enumerator = aEnumerator;
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00028EA4 File Offset: 0x000270A4
			public JSONNode Current
			{
				get
				{
					KeyValuePair<string, JSONNode> keyValuePair = this.m_Enumerator.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x060006D5 RID: 1749 RVA: 0x00028EC4 File Offset: 0x000270C4
			public bool MoveNext()
			{
				return this.m_Enumerator.MoveNext();
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x00028ED1 File Offset: 0x000270D1
			public JSONNode.ValueEnumerator GetEnumerator()
			{
				return this;
			}

			// Token: 0x04000295 RID: 661
			private JSONNode.Enumerator m_Enumerator;
		}

		// Token: 0x020000A5 RID: 165
		public struct KeyEnumerator
		{
			// Token: 0x060006D7 RID: 1751 RVA: 0x00028ED9 File Offset: 0x000270D9
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				this = new JSONNode.KeyEnumerator(new JSONNode.Enumerator(aArrayEnum));
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x00028EE7 File Offset: 0x000270E7
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				this = new JSONNode.KeyEnumerator(new JSONNode.Enumerator(aDictEnum));
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x00028EF5 File Offset: 0x000270F5
			public KeyEnumerator(JSONNode.Enumerator aEnumerator)
			{
				this.m_Enumerator = aEnumerator;
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x060006DA RID: 1754 RVA: 0x00028F00 File Offset: 0x00027100
			public JSONNode Current
			{
				get
				{
					KeyValuePair<string, JSONNode> keyValuePair = this.m_Enumerator.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x00028F25 File Offset: 0x00027125
			public bool MoveNext()
			{
				return this.m_Enumerator.MoveNext();
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x00028F32 File Offset: 0x00027132
			public JSONNode.KeyEnumerator GetEnumerator()
			{
				return this;
			}

			// Token: 0x04000296 RID: 662
			private JSONNode.Enumerator m_Enumerator;
		}

		// Token: 0x020000A6 RID: 166
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IDisposable, IEnumerator, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			// Token: 0x060006DD RID: 1757 RVA: 0x00028F3A File Offset: 0x0002713A
			internal LinqEnumerator(JSONNode aNode)
			{
				this.m_Node = aNode;
				if (this.m_Node != null)
				{
					this.m_Enumerator = this.m_Node.GetEnumerator();
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x060006DE RID: 1758 RVA: 0x00028F68 File Offset: 0x00027168
			public KeyValuePair<string, JSONNode> Current
			{
				get
				{
					return this.m_Enumerator.Current;
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x060006DF RID: 1759 RVA: 0x00028F75 File Offset: 0x00027175
			object IEnumerator.Current
			{
				get
				{
					return this.m_Enumerator.Current;
				}
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x00028F87 File Offset: 0x00027187
			public bool MoveNext()
			{
				return this.m_Enumerator.MoveNext();
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x00028F94 File Offset: 0x00027194
			public void Dispose()
			{
				this.m_Node = null;
				this.m_Enumerator = default(JSONNode.Enumerator);
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x00028FA9 File Offset: 0x000271A9
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return new JSONNode.LinqEnumerator(this.m_Node);
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x00028FB6 File Offset: 0x000271B6
			public void Reset()
			{
				if (this.m_Node != null)
				{
					this.m_Enumerator = this.m_Node.GetEnumerator();
				}
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x00028FD7 File Offset: 0x000271D7
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new JSONNode.LinqEnumerator(this.m_Node);
			}

			// Token: 0x04000297 RID: 663
			private JSONNode m_Node;

			// Token: 0x04000298 RID: 664
			private JSONNode.Enumerator m_Enumerator;
		}
	}
}
