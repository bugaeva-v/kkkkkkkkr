using System;
using System.Globalization;

namespace Ink.Runtime
{
	// Token: 0x0200003E RID: 62
	internal class StringValue : Value<string>
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00011EC8 File Offset: 0x000100C8
		public override ValueType valueType
		{
			get
			{
				return ValueType.String;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00011ECB File Offset: 0x000100CB
		public override bool isTruthy
		{
			get
			{
				return base.value.Length > 0;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00011EDB File Offset: 0x000100DB
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00011EE3 File Offset: 0x000100E3
		public bool isNewline { get; private set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00011EEC File Offset: 0x000100EC
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00011EF4 File Offset: 0x000100F4
		public bool isInlineWhitespace { get; private set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00011EFD File Offset: 0x000100FD
		public bool isNonWhitespace
		{
			get
			{
				return !this.isNewline && !this.isInlineWhitespace;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00011F14 File Offset: 0x00010114
		public StringValue(string str) : base(str)
		{
			this.isNewline = (base.value == "\n");
			this.isInlineWhitespace = true;
			foreach (char c in base.value)
			{
				if (c != ' ' && c != '\t')
				{
					this.isInlineWhitespace = false;
					return;
				}
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00011F77 File Offset: 0x00010177
		public StringValue() : this("")
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00011F84 File Offset: 0x00010184
		public override Value Cast(ValueType newType)
		{
			if (newType == this.valueType)
			{
				return this;
			}
			if (newType == ValueType.Int)
			{
				int intVal;
				if (int.TryParse(base.value, out intVal))
				{
					return new IntValue(intVal);
				}
				return null;
			}
			else
			{
				if (newType != ValueType.Float)
				{
					throw new Exception("Unexpected type cast of Value to new ValueType");
				}
				float val;
				if (float.TryParse(base.value, NumberStyles.Float, CultureInfo.InvariantCulture, out val))
				{
					return new FloatValue(val);
				}
				return null;
			}
		}
	}
}
