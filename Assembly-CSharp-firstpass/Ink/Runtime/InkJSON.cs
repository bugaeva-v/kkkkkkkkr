using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x02000028 RID: 40
	internal static class InkJSON
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00009C63 File Offset: 0x00007E63
		public static string DictionaryToText(Dictionary<string, object> rootObject)
		{
			return new InkJSON.Writer(rootObject).ToString();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00009C70 File Offset: 0x00007E70
		public static Dictionary<string, object> TextToDictionary(string text)
		{
			return new InkJSON.Reader(text).ToDictionary();
		}

		// Token: 0x02000067 RID: 103
		private class Reader
		{
			// Token: 0x060002EE RID: 750 RVA: 0x00012E2D File Offset: 0x0001102D
			public Reader(string text)
			{
				this._text = text;
				this._offset = 0;
				this.SkipWhitespace();
				this._rootObject = this.ReadObject();
			}

			// Token: 0x060002EF RID: 751 RVA: 0x00012E55 File Offset: 0x00011055
			public Dictionary<string, object> ToDictionary()
			{
				return (Dictionary<string, object>)this._rootObject;
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x00012E62 File Offset: 0x00011062
			private bool IsNumberChar(char c)
			{
				return (c >= '0' && c <= '9') || c == '.' || c == '-' || c == '+';
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x00012E80 File Offset: 0x00011080
			private object ReadObject()
			{
				char c = this._text[this._offset];
				if (c == '{')
				{
					return this.ReadDictionary();
				}
				if (c == '[')
				{
					return this.ReadArray();
				}
				if (c == '"')
				{
					return this.ReadString();
				}
				if (this.IsNumberChar(c))
				{
					return this.ReadNumber();
				}
				if (this.TryRead("true"))
				{
					return true;
				}
				if (this.TryRead("false"))
				{
					return false;
				}
				if (this.TryRead("null"))
				{
					return null;
				}
				throw new Exception("Unhandled object type in JSON: " + this._text.Substring(this._offset, 30));
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x00012F2C File Offset: 0x0001112C
			private Dictionary<string, object> ReadDictionary()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.Expect("{");
				this.SkipWhitespace();
				if (this.TryRead("}"))
				{
					return dictionary;
				}
				do
				{
					this.SkipWhitespace();
					string text = this.ReadString();
					this.Expect(text != null, "dictionary key");
					this.SkipWhitespace();
					this.Expect(":");
					this.SkipWhitespace();
					object obj = this.ReadObject();
					this.Expect(obj != null, "dictionary value");
					dictionary[text] = obj;
					this.SkipWhitespace();
				}
				while (this.TryRead(","));
				this.Expect("}");
				return dictionary;
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x00012FD0 File Offset: 0x000111D0
			private List<object> ReadArray()
			{
				List<object> list = new List<object>();
				this.Expect("[");
				this.SkipWhitespace();
				if (this.TryRead("]"))
				{
					return list;
				}
				do
				{
					this.SkipWhitespace();
					object item = this.ReadObject();
					list.Add(item);
					this.SkipWhitespace();
				}
				while (this.TryRead(","));
				this.Expect("]");
				return list;
			}

			// Token: 0x060002F4 RID: 756 RVA: 0x00013038 File Offset: 0x00011238
			private string ReadString()
			{
				this.Expect("\"");
				int offset = this._offset;
				while (this._offset < this._text.Length)
				{
					char c = this._text[this._offset];
					if (c == '\\')
					{
						this._offset++;
					}
					else if (c == '"')
					{
						break;
					}
					this._offset++;
				}
				this.Expect("\"");
				return this._text.Substring(offset, this._offset - offset - 1).Replace("\\\\", "\\").Replace("\\\"", "\"").Replace("\\r", "").Replace("\\n", "\n");
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x00013104 File Offset: 0x00011304
			private object ReadNumber()
			{
				int offset = this._offset;
				bool flag = false;
				while (this._offset < this._text.Length)
				{
					char c = this._text[this._offset];
					if (c == '.')
					{
						flag = true;
					}
					if (!this.IsNumberChar(c))
					{
						break;
					}
					this._offset++;
				}
				string s = this._text.Substring(offset, this._offset - offset);
				int num2;
				if (flag)
				{
					float num;
					if (float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out num))
					{
						return num;
					}
				}
				else if (int.TryParse(s, out num2))
				{
					return num2;
				}
				throw new Exception("Failed to parse number value");
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x000131B0 File Offset: 0x000113B0
			private bool TryRead(string textToRead)
			{
				if (this._offset + textToRead.Length > this._text.Length)
				{
					return false;
				}
				for (int i = 0; i < textToRead.Length; i++)
				{
					if (textToRead[i] != this._text[this._offset + i])
					{
						return false;
					}
				}
				this._offset += textToRead.Length;
				return true;
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0001321C File Offset: 0x0001141C
			private void Expect(string expectedStr)
			{
				if (!this.TryRead(expectedStr))
				{
					this.Expect(false, expectedStr);
				}
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x0001322F File Offset: 0x0001142F
			private void Expect(bool condition, string message = null)
			{
				if (!condition)
				{
					if (message == null)
					{
						message = "Unexpected token";
					}
					else
					{
						message = "Expected " + message;
					}
					message = message + " at offset " + this._offset.ToString();
					throw new Exception(message);
				}
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0001326C File Offset: 0x0001146C
			private void SkipWhitespace()
			{
				while (this._offset < this._text.Length)
				{
					char c = this._text[this._offset];
					if (c != ' ' && c != '\t' && c != '\n' && c != '\r')
					{
						break;
					}
					this._offset++;
				}
			}

			// Token: 0x04000228 RID: 552
			private string _text;

			// Token: 0x04000229 RID: 553
			private int _offset;

			// Token: 0x0400022A RID: 554
			private object _rootObject;
		}

		// Token: 0x02000068 RID: 104
		private class Writer
		{
			// Token: 0x060002FA RID: 762 RVA: 0x000132C2 File Offset: 0x000114C2
			public Writer(object rootObject)
			{
				this._sb = new StringBuilder();
				this.WriteObject(rootObject);
			}

			// Token: 0x060002FB RID: 763 RVA: 0x000132DC File Offset: 0x000114DC
			private void WriteObject(object obj)
			{
				if (obj is int)
				{
					this._sb.Append((int)obj);
					return;
				}
				if (obj is float)
				{
					string text = ((float)obj).ToString(CultureInfo.InvariantCulture);
					this._sb.Append(text);
					if (!text.Contains("."))
					{
						this._sb.Append(".0");
						return;
					}
					return;
				}
				else
				{
					if (obj is bool)
					{
						this._sb.Append(((bool)obj) ? "true" : "false");
						return;
					}
					if (obj == null)
					{
						this._sb.Append("null");
						return;
					}
					if (obj is string)
					{
						string text2 = (string)obj;
						text2 = text2.Replace("\\", "\\\\");
						text2 = text2.Replace("\"", "\\\"");
						text2 = text2.Replace("\n", "\\n");
						text2 = text2.Replace("\r", "");
						this._sb.AppendFormat("\"{0}\"", text2);
						return;
					}
					if (obj is Dictionary<string, object>)
					{
						this.WriteDictionary((Dictionary<string, object>)obj);
						return;
					}
					if (obj is List<object>)
					{
						this.WriteList((List<object>)obj);
						return;
					}
					throw new Exception("ink's SimpleJson writer doesn't currently support this object: " + ((obj != null) ? obj.ToString() : null));
				}
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0001343C File Offset: 0x0001163C
			private void WriteDictionary(Dictionary<string, object> dict)
			{
				this._sb.Append("{");
				bool flag = true;
				foreach (KeyValuePair<string, object> keyValuePair in dict)
				{
					if (!flag)
					{
						this._sb.Append(",");
					}
					this._sb.Append("\"");
					this._sb.Append(keyValuePair.Key);
					this._sb.Append("\":");
					this.WriteObject(keyValuePair.Value);
					flag = false;
				}
				this._sb.Append("}");
			}

			// Token: 0x060002FD RID: 765 RVA: 0x00013500 File Offset: 0x00011700
			private void WriteList(List<object> list)
			{
				this._sb.Append("[");
				bool flag = true;
				foreach (object obj in list)
				{
					if (!flag)
					{
						this._sb.Append(",");
					}
					this.WriteObject(obj);
					flag = false;
				}
				this._sb.Append("]");
			}

			// Token: 0x060002FE RID: 766 RVA: 0x00013588 File Offset: 0x00011788
			public override string ToString()
			{
				return this._sb.ToString();
			}

			// Token: 0x0400022B RID: 555
			private StringBuilder _sb;
		}
	}
}
