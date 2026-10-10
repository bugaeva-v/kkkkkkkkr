using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200002D RID: 45
	internal static class LevelPlayJson
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00006067 File Offset: 0x00004267
		public static object Deserialize(string json)
		{
			if (json == null)
			{
				return null;
			}
			return LevelPlayJson.Parser.Parse(json);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00006074 File Offset: 0x00004274
		public static string Serialize(object obj)
		{
			return LevelPlayJson.Serializer.Serialize(obj);
		}

		// Token: 0x02000056 RID: 86
		private sealed class Parser : IDisposable
		{
			// Token: 0x06000293 RID: 659 RVA: 0x00006700 File Offset: 0x00004900
			private Parser(string jsonString)
			{
				this.json = new StringReader(jsonString);
			}

			// Token: 0x06000294 RID: 660 RVA: 0x00006714 File Offset: 0x00004914
			public static object Parse(string jsonString)
			{
				if (string.IsNullOrWhiteSpace(jsonString))
				{
					return null;
				}
				object result;
				using (LevelPlayJson.Parser parser = new LevelPlayJson.Parser(jsonString))
				{
					result = parser.ParseValue();
				}
				return result;
			}

			// Token: 0x06000295 RID: 661 RVA: 0x00006758 File Offset: 0x00004958
			public void Dispose()
			{
				this.json.Dispose();
				this.json = null;
			}

			// Token: 0x06000296 RID: 662 RVA: 0x0000676C File Offset: 0x0000496C
			private Dictionary<string, object> ParseObject()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.json.Read();
				for (;;)
				{
					LevelPlayJson.Parser.TOKEN nextToken = this.NextToken;
					if (nextToken == LevelPlayJson.Parser.TOKEN.NONE)
					{
						break;
					}
					if (nextToken == LevelPlayJson.Parser.TOKEN.CURLY_CLOSE)
					{
						return dictionary;
					}
					if (nextToken != LevelPlayJson.Parser.TOKEN.COMMA)
					{
						string text = this.ParseString();
						if (text == null)
						{
							goto Block_4;
						}
						if (this.NextToken != LevelPlayJson.Parser.TOKEN.COLON)
						{
							goto Block_5;
						}
						this.json.Read();
						dictionary[text] = this.ParseValue();
					}
				}
				return null;
				Block_4:
				return null;
				Block_5:
				return null;
			}

			// Token: 0x06000297 RID: 663 RVA: 0x000067D4 File Offset: 0x000049D4
			private List<object> ParseArray()
			{
				List<object> list = new List<object>();
				this.json.Read();
				bool flag = true;
				while (flag)
				{
					LevelPlayJson.Parser.TOKEN nextToken = this.NextToken;
					if (nextToken == LevelPlayJson.Parser.TOKEN.NONE)
					{
						return null;
					}
					if (nextToken != LevelPlayJson.Parser.TOKEN.SQUARED_CLOSE)
					{
						if (nextToken != LevelPlayJson.Parser.TOKEN.COMMA)
						{
							object item = this.ParseByToken(nextToken);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x06000298 RID: 664 RVA: 0x00006824 File Offset: 0x00004A24
			private object ParseValue()
			{
				LevelPlayJson.Parser.TOKEN nextToken = this.NextToken;
				return this.ParseByToken(nextToken);
			}

			// Token: 0x06000299 RID: 665 RVA: 0x00006840 File Offset: 0x00004A40
			private object ParseByToken(LevelPlayJson.Parser.TOKEN token)
			{
				switch (token)
				{
				case LevelPlayJson.Parser.TOKEN.CURLY_OPEN:
					return this.ParseObject();
				case LevelPlayJson.Parser.TOKEN.SQUARED_OPEN:
					return this.ParseArray();
				case LevelPlayJson.Parser.TOKEN.STRING:
					return this.ParseString();
				case LevelPlayJson.Parser.TOKEN.NUMBER:
					return this.ParseNumber();
				case LevelPlayJson.Parser.TOKEN.TRUE:
					return true;
				case LevelPlayJson.Parser.TOKEN.FALSE:
					return false;
				case LevelPlayJson.Parser.TOKEN.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x0600029A RID: 666 RVA: 0x000068B0 File Offset: 0x00004AB0
			private string ParseString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				this.json.Read();
				bool flag = true;
				while (flag)
				{
					if (this.json.Peek() == -1)
					{
						break;
					}
					char nextChar = this.NextChar;
					if (nextChar != '"')
					{
						if (nextChar != '\\')
						{
							stringBuilder.Append(nextChar);
						}
						else if (this.json.Peek() == -1)
						{
							flag = false;
						}
						else
						{
							nextChar = this.NextChar;
							if (nextChar <= '\\')
							{
								if (nextChar == '"' || nextChar == '/' || nextChar == '\\')
								{
									stringBuilder.Append(nextChar);
								}
							}
							else if (nextChar <= 'f')
							{
								if (nextChar != 'b')
								{
									if (nextChar == 'f')
									{
										stringBuilder.Append('\f');
									}
								}
								else
								{
									stringBuilder.Append('\b');
								}
							}
							else if (nextChar != 'n')
							{
								switch (nextChar)
								{
								case 'r':
									stringBuilder.Append('\r');
									break;
								case 't':
									stringBuilder.Append('\t');
									break;
								case 'u':
								{
									StringBuilder stringBuilder2 = new StringBuilder();
									for (int i = 0; i < 4; i++)
									{
										stringBuilder2.Append(this.NextChar);
									}
									stringBuilder.Append((char)Convert.ToInt32(stringBuilder2.ToString(), 16));
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
					else
					{
						flag = false;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x0600029B RID: 667 RVA: 0x00006A04 File Offset: 0x00004C04
			private object ParseNumber()
			{
				string nextWord = this.NextWord;
				if (nextWord.IndexOf('.') == -1)
				{
					long num;
					long.TryParse(nextWord, NumberStyles.Any, CultureInfo.InvariantCulture, out num);
					return num;
				}
				double num2;
				double.TryParse(nextWord, NumberStyles.Any, CultureInfo.InvariantCulture, out num2);
				return num2;
			}

			// Token: 0x0600029C RID: 668 RVA: 0x00006A56 File Offset: 0x00004C56
			private void EatWhitespace()
			{
				while (" \t\n\r".IndexOf(this.PeekChar) != -1)
				{
					this.json.Read();
					if (this.json.Peek() == -1)
					{
						break;
					}
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600029D RID: 669 RVA: 0x00006A87 File Offset: 0x00004C87
			private char PeekChar
			{
				get
				{
					return Convert.ToChar(this.json.Peek());
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x0600029E RID: 670 RVA: 0x00006A99 File Offset: 0x00004C99
			private char NextChar
			{
				get
				{
					return Convert.ToChar(this.json.Read());
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x0600029F RID: 671 RVA: 0x00006AAC File Offset: 0x00004CAC
			private string NextWord
			{
				get
				{
					StringBuilder stringBuilder = new StringBuilder();
					while (" \t\n\r{}[],:\"".IndexOf(this.PeekChar) == -1)
					{
						stringBuilder.Append(this.NextChar);
						if (this.json.Peek() == -1)
						{
							break;
						}
					}
					return stringBuilder.ToString();
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x00006AF8 File Offset: 0x00004CF8
			private LevelPlayJson.Parser.TOKEN NextToken
			{
				get
				{
					this.EatWhitespace();
					if (this.json.Peek() == -1)
					{
						return LevelPlayJson.Parser.TOKEN.NONE;
					}
					char peekChar = this.PeekChar;
					if (peekChar <= '[')
					{
						switch (peekChar)
						{
						case '"':
							return LevelPlayJson.Parser.TOKEN.STRING;
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
							return LevelPlayJson.Parser.TOKEN.COMMA;
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
							return LevelPlayJson.Parser.TOKEN.NUMBER;
						case ':':
							return LevelPlayJson.Parser.TOKEN.COLON;
						default:
							if (peekChar == '[')
							{
								return LevelPlayJson.Parser.TOKEN.SQUARED_OPEN;
							}
							break;
						}
					}
					else
					{
						if (peekChar == ']')
						{
							this.json.Read();
							return LevelPlayJson.Parser.TOKEN.SQUARED_CLOSE;
						}
						if (peekChar == '{')
						{
							return LevelPlayJson.Parser.TOKEN.CURLY_OPEN;
						}
						if (peekChar == '}')
						{
							this.json.Read();
							return LevelPlayJson.Parser.TOKEN.CURLY_CLOSE;
						}
					}
					string nextWord = this.NextWord;
					if (nextWord == "false")
					{
						return LevelPlayJson.Parser.TOKEN.FALSE;
					}
					if (nextWord == "true")
					{
						return LevelPlayJson.Parser.TOKEN.TRUE;
					}
					if (!(nextWord == "null"))
					{
						return LevelPlayJson.Parser.TOKEN.NONE;
					}
					return LevelPlayJson.Parser.TOKEN.NULL;
				}
			}

			// Token: 0x0400012D RID: 301
			private const string WHITE_SPACE = " \t\n\r";

			// Token: 0x0400012E RID: 302
			private const string WORD_BREAK = " \t\n\r{}[],:\"";

			// Token: 0x0400012F RID: 303
			private StringReader json;

			// Token: 0x02000060 RID: 96
			private enum TOKEN
			{
				// Token: 0x04000139 RID: 313
				NONE,
				// Token: 0x0400013A RID: 314
				CURLY_OPEN,
				// Token: 0x0400013B RID: 315
				CURLY_CLOSE,
				// Token: 0x0400013C RID: 316
				SQUARED_OPEN,
				// Token: 0x0400013D RID: 317
				SQUARED_CLOSE,
				// Token: 0x0400013E RID: 318
				COLON,
				// Token: 0x0400013F RID: 319
				COMMA,
				// Token: 0x04000140 RID: 320
				STRING,
				// Token: 0x04000141 RID: 321
				NUMBER,
				// Token: 0x04000142 RID: 322
				TRUE,
				// Token: 0x04000143 RID: 323
				FALSE,
				// Token: 0x04000144 RID: 324
				NULL
			}
		}

		// Token: 0x02000057 RID: 87
		private sealed class Serializer
		{
			// Token: 0x060002A1 RID: 673 RVA: 0x00006C1A File Offset: 0x00004E1A
			private Serializer()
			{
				this.builder = new StringBuilder();
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x00006C2D File Offset: 0x00004E2D
			public static string Serialize(object obj)
			{
				LevelPlayJson.Serializer serializer = new LevelPlayJson.Serializer();
				serializer.SerializeValue(obj);
				return serializer.builder.ToString();
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x00006C48 File Offset: 0x00004E48
			private void SerializeValue(object value)
			{
				if (value == null)
				{
					this.builder.Append("null");
					return;
				}
				string str;
				if ((str = (value as string)) != null)
				{
					this.SerializeString(str);
					return;
				}
				if (value is bool)
				{
					this.builder.Append(value.ToString().ToLower());
					return;
				}
				IList anArray;
				if ((anArray = (value as IList)) != null)
				{
					this.SerializeArray(anArray);
					return;
				}
				IDictionary obj;
				if ((obj = (value as IDictionary)) != null)
				{
					this.SerializeObject(obj);
					return;
				}
				if (value is char)
				{
					this.SerializeString(value.ToString());
					return;
				}
				this.SerializeOther(value);
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x00006CDC File Offset: 0x00004EDC
			private void SerializeObject(IDictionary obj)
			{
				bool flag = true;
				this.builder.Append('{');
				foreach (object obj2 in obj.Keys)
				{
					if (!flag)
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

			// Token: 0x060002A5 RID: 677 RVA: 0x00006D84 File Offset: 0x00004F84
			private void SerializeArray(IList anArray)
			{
				this.builder.Append('[');
				bool flag = true;
				foreach (object value in anArray)
				{
					if (!flag)
					{
						this.builder.Append(',');
					}
					this.SerializeValue(value);
					flag = false;
				}
				this.builder.Append(']');
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x00006E04 File Offset: 0x00005004
			private void SerializeString(string str)
			{
				this.builder.Append('"');
				char[] array = str.ToCharArray();
				int i = 0;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
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
						goto IL_DD;
					case '\f':
						this.builder.Append("\\f");
						break;
					case '\r':
						this.builder.Append("\\r");
						break;
					default:
						if (c != '"')
						{
							if (c != '\\')
							{
								goto IL_DD;
							}
							this.builder.Append("\\\\");
						}
						else
						{
							this.builder.Append("\\\"");
						}
						break;
					}
					IL_123:
					i++;
					continue;
					IL_DD:
					int num = Convert.ToInt32(c);
					if (num >= 32 && num <= 126)
					{
						this.builder.Append(c);
						goto IL_123;
					}
					this.builder.Append("\\u" + Convert.ToString(num, 16).PadLeft(4, '0'));
					goto IL_123;
				}
				this.builder.Append('"');
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x00006F50 File Offset: 0x00005150
			private void SerializeOther(object value)
			{
				if (value is float || value is int || value is uint || value is long || value is double || value is sbyte || value is byte || value is short || value is ushort || value is ulong || value is decimal)
				{
					this.builder.Append(value.ToString());
					return;
				}
				this.SerializeString(value.ToString());
			}

			// Token: 0x04000130 RID: 304
			private StringBuilder builder;
		}
	}
}
