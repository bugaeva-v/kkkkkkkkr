using System;

namespace Ink.Runtime
{
	// Token: 0x0200003C RID: 60
	internal class IntValue : Value<int>
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00011DCD File Offset: 0x0000FFCD
		public override ValueType valueType
		{
			get
			{
				return ValueType.Int;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00011DD0 File Offset: 0x0000FFD0
		public override bool isTruthy
		{
			get
			{
				return base.value != 0;
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00011DDB File Offset: 0x0000FFDB
		public IntValue(int intVal) : base(intVal)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		public IntValue() : this(0)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		public override Value Cast(ValueType newType)
		{
			if (newType == this.valueType)
			{
				return this;
			}
			if (newType == ValueType.Float)
			{
				return new FloatValue((float)base.value);
			}
			if (newType == ValueType.String)
			{
				return new StringValue(base.value.ToString() ?? "");
			}
			throw new Exception("Unexpected type cast of Value to new ValueType");
		}
	}
}
