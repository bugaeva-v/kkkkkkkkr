using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace App42Json
{
	// Token: 0x02000073 RID: 115
	public class JsonWriter
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00017B30 File Offset: 0x00015D30
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00017B38 File Offset: 0x00015D38
		public int IndentValue
		{
			get
			{
				return this.indent_value;
			}
			set
			{
				this.indentation = this.indentation / this.indent_value * value;
				this.indent_value = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00017B56 File Offset: 0x00015D56
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00017B5E File Offset: 0x00015D5E
		public bool PrettyPrint
		{
			get
			{
				return this.pretty_print;
			}
			set
			{
				this.pretty_print = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00017B67 File Offset: 0x00015D67
		public TextWriter TextWriter
		{
			get
			{
				return this.writer;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00017B6F File Offset: 0x00015D6F
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00017B77 File Offset: 0x00015D77
		public bool Validate
		{
			get
			{
				return this.validate;
			}
			set
			{
				this.validate = value;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00017B8C File Offset: 0x00015D8C
		public JsonWriter()
		{
			this.inst_string_builder = new StringBuilder();
			this.writer = new StringWriter(this.inst_string_builder);
			this.Init();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00017BB6 File Offset: 0x00015DB6
		public JsonWriter(StringBuilder sb) : this(new StringWriter(sb))
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00017BC4 File Offset: 0x00015DC4
		public JsonWriter(TextWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			this.writer = writer;
			this.Init();
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00017BE8 File Offset: 0x00015DE8
		private void DoValidation(Condition cond)
		{
			if (!this.context.ExpectingValue)
			{
				this.context.Count++;
			}
			if (!this.validate)
			{
				return;
			}
			if (this.has_reached_end)
			{
				throw new JsonException("A complete JSON symbol has already been written");
			}
			switch (cond)
			{
			case Condition.InArray:
				if (!this.context.InArray)
				{
					throw new JsonException("Can't close an array here");
				}
				break;
			case Condition.InObject:
				if (!this.context.InObject || this.context.ExpectingValue)
				{
					throw new JsonException("Can't close an object here");
				}
				break;
			case Condition.NotAProperty:
				if (this.context.InObject && !this.context.ExpectingValue)
				{
					throw new JsonException("Expected a property");
				}
				break;
			case Condition.Property:
				if (!this.context.InObject || this.context.ExpectingValue)
				{
					throw new JsonException("Can't add a property here");
				}
				break;
			case Condition.Value:
				if (!this.context.InArray && (!this.context.InObject || !this.context.ExpectingValue))
				{
					throw new JsonException("Can't add a value here");
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00017D10 File Offset: 0x00015F10
		private void Init()
		{
			this.has_reached_end = false;
			this.hex_seq = new char[4];
			this.indentation = 0;
			this.indent_value = 4;
			this.pretty_print = false;
			this.validate = true;
			this.ctx_stack = new Stack<WriterContext>();
			this.context = new WriterContext();
			this.ctx_stack.Push(this.context);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00017D74 File Offset: 0x00015F74
		private static void IntToHex(int n, char[] hex)
		{
			for (int i = 0; i < 4; i++)
			{
				int num = n % 16;
				if (num < 10)
				{
					hex[3 - i] = (char)(48 + num);
				}
				else
				{
					hex[3 - i] = (char)(65 + (num - 10));
				}
				n >>= 4;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00017DB5 File Offset: 0x00015FB5
		private void Indent()
		{
			if (this.pretty_print)
			{
				this.indentation += this.indent_value;
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00017DD4 File Offset: 0x00015FD4
		private void Put(string str)
		{
			if (this.pretty_print && !this.context.ExpectingValue)
			{
				for (int i = 0; i < this.indentation; i++)
				{
					this.writer.Write(' ');
				}
			}
			this.writer.Write(str);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00017E20 File Offset: 0x00016020
		private void PutNewline()
		{
			this.PutNewline(true);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00017E2C File Offset: 0x0001602C
		private void PutNewline(bool add_comma)
		{
			if (add_comma && !this.context.ExpectingValue && this.context.Count > 1)
			{
				this.writer.Write(',');
			}
			if (this.pretty_print && !this.context.ExpectingValue)
			{
				this.writer.Write('\n');
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00017E88 File Offset: 0x00016088
		private void PutString(string str)
		{
			this.Put(string.Empty);
			this.writer.Write('"');
			int length = str.Length;
			int i = 0;
			while (i < length)
			{
				char c = str[i];
				switch (c)
				{
				case '\b':
					this.writer.Write("\\b");
					break;
				case '\t':
					this.writer.Write("\\t");
					break;
				case '\n':
					this.writer.Write("\\n");
					break;
				case '\v':
					goto IL_E4;
				case '\f':
					this.writer.Write("\\f");
					break;
				case '\r':
					this.writer.Write("\\r");
					break;
				default:
					if (c != '"' && c != '\\')
					{
						goto IL_E4;
					}
					this.writer.Write('\\');
					this.writer.Write(str[i]);
					break;
				}
				IL_141:
				i++;
				continue;
				IL_E4:
				if (str[i] >= ' ' && str[i] <= '~')
				{
					this.writer.Write(str[i]);
					goto IL_141;
				}
				JsonWriter.IntToHex((int)str[i], this.hex_seq);
				this.writer.Write("\\u");
				this.writer.Write(this.hex_seq);
				goto IL_141;
			}
			this.writer.Write('"');
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00017FEE File Offset: 0x000161EE
		private void Unindent()
		{
			if (this.pretty_print)
			{
				this.indentation -= this.indent_value;
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001800B File Offset: 0x0001620B
		public override string ToString()
		{
			if (this.inst_string_builder == null)
			{
				return string.Empty;
			}
			return this.inst_string_builder.ToString();
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00018028 File Offset: 0x00016228
		public void Reset()
		{
			this.has_reached_end = false;
			this.ctx_stack.Clear();
			this.context = new WriterContext();
			this.ctx_stack.Push(this.context);
			if (this.inst_string_builder != null)
			{
				this.inst_string_builder.Remove(0, this.inst_string_builder.Length);
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00018083 File Offset: 0x00016283
		public void Write(bool boolean)
		{
			this.DoValidation(Condition.Value);
			this.PutNewline();
			this.Put(boolean ? "true" : "false");
			this.context.ExpectingValue = false;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000180B3 File Offset: 0x000162B3
		public void Write(decimal number)
		{
			this.DoValidation(Condition.Value);
			this.PutNewline();
			this.Put(Convert.ToString(number, JsonWriter.number_format));
			this.context.ExpectingValue = false;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000180E0 File Offset: 0x000162E0
		public void Write(double number)
		{
			this.DoValidation(Condition.Value);
			this.PutNewline();
			string text = Convert.ToString(number, JsonWriter.number_format);
			this.Put(text);
			if (text.IndexOf('.') == -1 && text.IndexOf('E') == -1)
			{
				this.writer.Write(".0");
			}
			this.context.ExpectingValue = false;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001813F File Offset: 0x0001633F
		public void Write(int number)
		{
			this.DoValidation(Condition.Value);
			this.PutNewline();
			this.Put(Convert.ToString(number, JsonWriter.number_format));
			this.context.ExpectingValue = false;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001816B File Offset: 0x0001636B
		public void Write(long number)
		{
			this.DoValidation(Condition.Value);
			this.PutNewline();
			this.Put(Convert.ToString(number, JsonWriter.number_format));
			this.context.ExpectingValue = false;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00018197 File Offset: 0x00016397
		public void Write(string str)
		{
			this.DoValidation(Condition.Value);
			this.PutNewline();
			if (str == null)
			{
				this.Put("null");
			}
			else
			{
				this.PutString(str);
			}
			this.context.ExpectingValue = false;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000181C9 File Offset: 0x000163C9
		public void Write(ulong number)
		{
			this.DoValidation(Condition.Value);
			this.PutNewline();
			this.Put(Convert.ToString(number, JsonWriter.number_format));
			this.context.ExpectingValue = false;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000181F8 File Offset: 0x000163F8
		public void WriteArrayEnd()
		{
			this.DoValidation(Condition.InArray);
			this.PutNewline(false);
			this.ctx_stack.Pop();
			if (this.ctx_stack.Count == 1)
			{
				this.has_reached_end = true;
			}
			else
			{
				this.context = this.ctx_stack.Peek();
				this.context.ExpectingValue = false;
			}
			this.Unindent();
			this.Put("]");
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00018264 File Offset: 0x00016464
		public void WriteArrayStart()
		{
			this.DoValidation(Condition.NotAProperty);
			this.PutNewline();
			this.Put("[");
			this.context = new WriterContext();
			this.context.InArray = true;
			this.ctx_stack.Push(this.context);
			this.Indent();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000182B8 File Offset: 0x000164B8
		public void WriteObjectEnd()
		{
			this.DoValidation(Condition.InObject);
			this.PutNewline(false);
			this.ctx_stack.Pop();
			if (this.ctx_stack.Count == 1)
			{
				this.has_reached_end = true;
			}
			else
			{
				this.context = this.ctx_stack.Peek();
				this.context.ExpectingValue = false;
			}
			this.Unindent();
			this.Put("}");
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00018324 File Offset: 0x00016524
		public void WriteObjectStart()
		{
			this.DoValidation(Condition.NotAProperty);
			this.PutNewline();
			this.Put("{");
			this.context = new WriterContext();
			this.context.InObject = true;
			this.ctx_stack.Push(this.context);
			this.Indent();
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00018378 File Offset: 0x00016578
		public void WritePropertyName(string property_name)
		{
			this.DoValidation(Condition.Property);
			this.PutNewline();
			this.PutString(property_name);
			if (this.pretty_print)
			{
				if (property_name.Length > this.context.Padding)
				{
					this.context.Padding = property_name.Length;
				}
				for (int i = this.context.Padding - property_name.Length; i >= 0; i--)
				{
					this.writer.Write(' ');
				}
				this.writer.Write(": ");
			}
			else
			{
				this.writer.Write(':');
			}
			this.context.ExpectingValue = true;
		}

		// Token: 0x040001F1 RID: 497
		private static NumberFormatInfo number_format = NumberFormatInfo.InvariantInfo;

		// Token: 0x040001F2 RID: 498
		private WriterContext context;

		// Token: 0x040001F3 RID: 499
		private Stack<WriterContext> ctx_stack;

		// Token: 0x040001F4 RID: 500
		private bool has_reached_end;

		// Token: 0x040001F5 RID: 501
		private char[] hex_seq;

		// Token: 0x040001F6 RID: 502
		private int indentation;

		// Token: 0x040001F7 RID: 503
		private int indent_value;

		// Token: 0x040001F8 RID: 504
		private StringBuilder inst_string_builder;

		// Token: 0x040001F9 RID: 505
		private bool pretty_print;

		// Token: 0x040001FA RID: 506
		private bool validate;

		// Token: 0x040001FB RID: 507
		private TextWriter writer;
	}
}
