using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Google.MiniJSON
{
	// Token: 0x02000002 RID: 2
	public static class Json
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static object Deserialize(string json)
		{
			bool flag = json == null;
			object result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = Json.Parser.Parse(json);
			}
			return result;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002078 File Offset: 0x00000278
		public static string Serialize(object obj)
		{
			return Json.Serializer.Serialize(obj);
		}

		// Token: 0x02000003 RID: 3
		private sealed class Parser : IDisposable
		{
			// Token: 0x06000003 RID: 3 RVA: 0x00002090 File Offset: 0x00000290
			public static bool IsWordBreak(char c)
			{
				return char.IsWhiteSpace(c) || "{}[],:\"".IndexOf(c) != -1;
			}

			// Token: 0x06000004 RID: 4 RVA: 0x000020C0 File Offset: 0x000002C0
			public static bool IsHexDigit(char c)
			{
				return "0123456789ABCDEFabcdef".IndexOf(c) != -1;
			}

			// Token: 0x06000005 RID: 5 RVA: 0x000020E3 File Offset: 0x000002E3
			private Parser(string jsonString)
			{
				this.json = new StringReader(jsonString);
			}

			// Token: 0x06000006 RID: 6 RVA: 0x000020FC File Offset: 0x000002FC
			public static object Parse(string jsonString)
			{
				object result;
				using (Json.Parser parser = new Json.Parser(jsonString))
				{
					result = parser.ParseValue();
				}
				return result;
			}

			// Token: 0x06000007 RID: 7 RVA: 0x00002138 File Offset: 0x00000338
			public void Dispose()
			{
				this.json.Dispose();
				this.json = null;
			}

			// Token: 0x06000008 RID: 8 RVA: 0x00002150 File Offset: 0x00000350
			private Dictionary<string, object> ParseObject()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.json.Read();
				Json.Parser.TOKEN token;
				for (;;)
				{
					Json.Parser.TOKEN nextToken = this.NextToken;
					token = nextToken;
					if (token <= Json.Parser.TOKEN.CURLY_CLOSE)
					{
						break;
					}
					if (token != Json.Parser.TOKEN.COMMA)
					{
						if (token != Json.Parser.TOKEN.STRING)
						{
							goto Block_5;
						}
						string text = this.ParseString();
						bool flag = text == null;
						if (flag)
						{
							goto Block_6;
						}
						bool flag2 = this.NextToken != Json.Parser.TOKEN.COLON;
						if (flag2)
						{
							goto Block_7;
						}
						this.json.Read();
						Json.Parser.TOKEN nextToken2 = this.NextToken;
						object obj = this.ParseByToken(nextToken2);
						bool flag3 = obj == null && nextToken2 != Json.Parser.TOKEN.NULL;
						if (flag3)
						{
							goto Block_9;
						}
						dictionary[text] = obj;
					}
				}
				if (token == Json.Parser.TOKEN.NONE)
				{
					return null;
				}
				if (token == Json.Parser.TOKEN.CURLY_CLOSE)
				{
					return dictionary;
				}
				Block_5:
				goto IL_C5;
				Block_6:
				return null;
				Block_7:
				return null;
				Block_9:
				return null;
				IL_C5:
				return null;
			}

			// Token: 0x06000009 RID: 9 RVA: 0x00002234 File Offset: 0x00000434
			private List<object> ParseArray()
			{
				List<object> list = new List<object>();
				this.json.Read();
				bool flag = true;
				while (flag)
				{
					Json.Parser.TOKEN nextToken = this.NextToken;
					Json.Parser.TOKEN token = nextToken;
					Json.Parser.TOKEN token2 = token;
					if (token2 != Json.Parser.TOKEN.NONE)
					{
						if (token2 != Json.Parser.TOKEN.SQUARED_CLOSE)
						{
							if (token2 != Json.Parser.TOKEN.COMMA)
							{
								object obj = this.ParseByToken(nextToken);
								bool flag2 = obj == null && nextToken != Json.Parser.TOKEN.NULL;
								if (flag2)
								{
									return null;
								}
								list.Add(obj);
							}
						}
						else
						{
							flag = false;
						}
						continue;
					}
					return null;
				}
				return list;
			}

			// Token: 0x0600000A RID: 10 RVA: 0x000022C0 File Offset: 0x000004C0
			private object ParseValue()
			{
				Json.Parser.TOKEN nextToken = this.NextToken;
				return this.ParseByToken(nextToken);
			}

			// Token: 0x0600000B RID: 11 RVA: 0x000022E0 File Offset: 0x000004E0
			private object ParseByToken(Json.Parser.TOKEN token)
			{
				switch (token)
				{
				case Json.Parser.TOKEN.CURLY_OPEN:
					return this.ParseObject();
				case Json.Parser.TOKEN.SQUARED_OPEN:
					return this.ParseArray();
				case Json.Parser.TOKEN.STRING:
					return this.ParseString();
				case Json.Parser.TOKEN.NUMBER:
					return this.ParseNumber();
				case Json.Parser.TOKEN.TRUE:
					return true;
				case Json.Parser.TOKEN.FALSE:
					return false;
				case Json.Parser.TOKEN.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x0600000C RID: 12 RVA: 0x00002368 File Offset: 0x00000568
			private string ParseString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				this.json.Read();
				bool flag = true;
				while (flag)
				{
					bool flag2 = this.json.Peek() == -1;
					if (flag2)
					{
						break;
					}
					char nextChar = this.NextChar;
					char c = nextChar;
					char c2 = c;
					if (c2 != '"')
					{
						if (c2 != '\\')
						{
							stringBuilder.Append(nextChar);
						}
						else
						{
							bool flag3 = this.json.Peek() == -1;
							if (flag3)
							{
								flag = false;
							}
							else
							{
								nextChar = this.NextChar;
								char c3 = nextChar;
								char c4 = c3;
								if (c4 <= '\\')
								{
									if (c4 == '"' || c4 == '/' || c4 == '\\')
									{
										stringBuilder.Append(nextChar);
									}
								}
								else if (c4 <= 'f')
								{
									if (c4 != 'b')
									{
										if (c4 == 'f')
										{
											stringBuilder.Append('\f');
										}
									}
									else
									{
										stringBuilder.Append('\b');
									}
								}
								else if (c4 != 'n')
								{
									switch (c4)
									{
									case 'r':
										stringBuilder.Append('\r');
										break;
									case 't':
										stringBuilder.Append('\t');
										break;
									case 'u':
									{
										char[] array = new char[4];
										for (int i = 0; i < 4; i++)
										{
											array[i] = this.NextChar;
											bool flag4 = !Json.Parser.IsHexDigit(array[i]);
											if (flag4)
											{
												return null;
											}
										}
										stringBuilder.Append((char)Convert.ToInt32(new string(array), 16));
										break;
									}
									}
								}
								else
								{
									stringBuilder.Append('\n');
								}
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x0600000D RID: 13 RVA: 0x00002524 File Offset: 0x00000724
			private object ParseNumber()
			{
				string nextWord = this.NextWord;
				bool flag = nextWord.IndexOf('.') == -1 && nextWord.IndexOf('E') == -1 && nextWord.IndexOf('e') == -1;
				object result;
				if (flag)
				{
					long num;
					long.TryParse(nextWord, NumberStyles.Any, CultureInfo.InvariantCulture, out num);
					result = num;
				}
				else
				{
					double num2;
					double.TryParse(nextWord, NumberStyles.Any, CultureInfo.InvariantCulture, out num2);
					result = num2;
				}
				return result;
			}

			// Token: 0x0600000E RID: 14 RVA: 0x000025A0 File Offset: 0x000007A0
			private void EatWhitespace()
			{
				while (char.IsWhiteSpace(this.PeekChar))
				{
					this.json.Read();
					bool flag = this.json.Peek() == -1;
					if (flag)
					{
						break;
					}
				}
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600000F RID: 15 RVA: 0x000025E4 File Offset: 0x000007E4
			private char PeekChar
			{
				get
				{
					return Convert.ToChar(this.json.Peek());
				}
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000010 RID: 16 RVA: 0x00002608 File Offset: 0x00000808
			private char NextChar
			{
				get
				{
					return Convert.ToChar(this.json.Read());
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000011 RID: 17 RVA: 0x0000262C File Offset: 0x0000082C
			private string NextWord
			{
				get
				{
					StringBuilder stringBuilder = new StringBuilder();
					while (!Json.Parser.IsWordBreak(this.PeekChar))
					{
						stringBuilder.Append(this.NextChar);
						bool flag = this.json.Peek() == -1;
						if (flag)
						{
							break;
						}
					}
					return stringBuilder.ToString();
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000012 RID: 18 RVA: 0x00002684 File Offset: 0x00000884
			private Json.Parser.TOKEN NextToken
			{
				get
				{
					this.EatWhitespace();
					bool flag = this.json.Peek() == -1;
					Json.Parser.TOKEN result;
					if (flag)
					{
						result = Json.Parser.TOKEN.NONE;
					}
					else
					{
						char peekChar = this.PeekChar;
						char c = peekChar;
						if (c <= '[')
						{
							switch (c)
							{
							case '"':
								return Json.Parser.TOKEN.STRING;
							case '#':
							case '$':
							case '%':
							case '&':
							case '\'':
							case '(':
							case ')':
							case '*':
							case '+':
							case '.':
							case '/':
								break;
							case ',':
								this.json.Read();
								return Json.Parser.TOKEN.COMMA;
							case '-':
							case '0':
							case '1':
							case '2':
							case '3':
							case '4':
							case '5':
							case '6':
							case '7':
							case '8':
							case '9':
								return Json.Parser.TOKEN.NUMBER;
							case ':':
								return Json.Parser.TOKEN.COLON;
							default:
								if (c == '[')
								{
									return Json.Parser.TOKEN.SQUARED_OPEN;
								}
								break;
							}
						}
						else
						{
							if (c == ']')
							{
								this.json.Read();
								return Json.Parser.TOKEN.SQUARED_CLOSE;
							}
							if (c == '{')
							{
								return Json.Parser.TOKEN.CURLY_OPEN;
							}
							if (c == '}')
							{
								this.json.Read();
								return Json.Parser.TOKEN.CURLY_CLOSE;
							}
						}
						string nextWord = this.NextWord;
						string a = nextWord;
						if (!(a == "false"))
						{
							if (!(a == "true"))
							{
								if (!(a == "null"))
								{
									result = Json.Parser.TOKEN.NONE;
								}
								else
								{
									result = Json.Parser.TOKEN.NULL;
								}
							}
							else
							{
								result = Json.Parser.TOKEN.TRUE;
							}
						}
						else
						{
							result = Json.Parser.TOKEN.FALSE;
						}
					}
					return result;
				}
			}

			// Token: 0x04000001 RID: 1
			private const string WORD_BREAK = "{}[],:\"";

			// Token: 0x04000002 RID: 2
			private const string HEX_DIGIT = "0123456789ABCDEFabcdef";

			// Token: 0x04000003 RID: 3
			private StringReader json;

			// Token: 0x02000005 RID: 5
			private enum TOKEN
			{
				// Token: 0x04000006 RID: 6
				NONE,
				// Token: 0x04000007 RID: 7
				CURLY_OPEN,
				// Token: 0x04000008 RID: 8
				CURLY_CLOSE,
				// Token: 0x04000009 RID: 9
				SQUARED_OPEN,
				// Token: 0x0400000A RID: 10
				SQUARED_CLOSE,
				// Token: 0x0400000B RID: 11
				COLON,
				// Token: 0x0400000C RID: 12
				COMMA,
				// Token: 0x0400000D RID: 13
				STRING,
				// Token: 0x0400000E RID: 14
				NUMBER,
				// Token: 0x0400000F RID: 15
				TRUE,
				// Token: 0x04000010 RID: 16
				FALSE,
				// Token: 0x04000011 RID: 17
				NULL
			}
		}

		// Token: 0x02000004 RID: 4
		private sealed class Serializer
		{
			// Token: 0x06000013 RID: 19 RVA: 0x000027DF File Offset: 0x000009DF
			private Serializer()
			{
				this.builder = new StringBuilder();
			}

			// Token: 0x06000014 RID: 20 RVA: 0x000027F4 File Offset: 0x000009F4
			public static string Serialize(object obj)
			{
				Json.Serializer serializer = new Json.Serializer();
				serializer.SerializeValue(obj);
				return serializer.builder.ToString();
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00002820 File Offset: 0x00000A20
			private void SerializeValue(object value)
			{
				bool flag = value == null;
				if (flag)
				{
					this.builder.Append("null");
				}
				else
				{
					string str;
					bool flag2 = (str = (value as string)) != null;
					if (flag2)
					{
						this.SerializeString(str);
					}
					else
					{
						bool flag3 = value is bool;
						if (flag3)
						{
							this.builder.Append(((bool)value) ? "true" : "false");
						}
						else
						{
							IList anArray;
							bool flag4 = (anArray = (value as IList)) != null;
							if (flag4)
							{
								this.SerializeArray(anArray);
							}
							else
							{
								IDictionary obj;
								bool flag5 = (obj = (value as IDictionary)) != null;
								if (flag5)
								{
									this.SerializeObject(obj);
								}
								else
								{
									bool flag6 = value is char;
									if (flag6)
									{
										this.SerializeString(new string((char)value, 1));
									}
									else
									{
										this.SerializeOther(value);
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000016 RID: 22 RVA: 0x0000290C File Offset: 0x00000B0C
			private void SerializeObject(IDictionary obj)
			{
				bool flag = true;
				this.builder.Append('{');
				foreach (object obj2 in obj.Keys)
				{
					bool flag2 = !flag;
					if (flag2)
					{
						this.builder.Append(',');
					}
					this.SerializeString(obj2.ToString());
					this.builder.Append(':');
					this.SerializeValue(obj[obj2]);
					flag = false;
				}
				this.builder.Append('}');
			}

			// Token: 0x06000017 RID: 23 RVA: 0x000029C4 File Offset: 0x00000BC4
			private void SerializeArray(IList anArray)
			{
				this.builder.Append('[');
				bool flag = true;
				for (int i = 0; i < anArray.Count; i++)
				{
					object value = anArray[i];
					bool flag2 = !flag;
					if (flag2)
					{
						this.builder.Append(',');
					}
					this.SerializeValue(value);
					flag = false;
				}
				this.builder.Append(']');
			}

			// Token: 0x06000018 RID: 24 RVA: 0x00002A34 File Offset: 0x00000C34
			private void SerializeString(string str)
			{
				this.builder.Append('"');
				char[] array = str.ToCharArray();
				int i = 0;
				while (i < array.Length)
				{
					char c = array[i];
					char c2 = c;
					char c3 = c2;
					switch (c3)
					{
					case '\b':
						this.builder.Append("\\b");
						break;
					case '\t':
						this.builder.Append("\\t");
						break;
					case '\n':
						this.builder.Append("\\n");
						break;
					case '\v':
						goto IL_F3;
					case '\f':
						this.builder.Append("\\f");
						break;
					case '\r':
						this.builder.Append("\\r");
						break;
					default:
						if (c3 != '"')
						{
							if (c3 != '\\')
							{
								goto IL_F3;
							}
							this.builder.Append("\\\\");
						}
						else
						{
							this.builder.Append("\\\"");
						}
						break;
					}
					IL_14E:
					i++;
					continue;
					IL_F3:
					int num = Convert.ToInt32(c);
					bool flag = num >= 32 && num <= 126;
					if (flag)
					{
						this.builder.Append(c);
					}
					else
					{
						this.builder.Append("\\u");
						this.builder.Append(num.ToString("x4"));
					}
					goto IL_14E;
				}
				this.builder.Append('"');
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00002BB4 File Offset: 0x00000DB4
			private void SerializeOther(object value)
			{
				bool flag = value is float;
				if (flag)
				{
					this.builder.Append(((float)value).ToString("R", CultureInfo.InvariantCulture));
				}
				else
				{
					bool flag2 = value is int || value is uint || value is long || value is sbyte || value is byte || value is short || value is ushort || value is ulong;
					if (flag2)
					{
						this.builder.Append(value);
					}
					else
					{
						bool flag3 = value is double || value is decimal;
						if (flag3)
						{
							this.builder.Append(Convert.ToDouble(value).ToString("R", CultureInfo.InvariantCulture));
						}
						else
						{
							this.SerializeString(value.ToString());
						}
					}
				}
			}

			// Token: 0x04000004 RID: 4
			private StringBuilder builder;
		}
	}
}
