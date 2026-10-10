using System;
using System.Globalization;

namespace Ink.Runtime
{
	// Token: 0x0200003D RID: 61
	internal class FloatValue : Value<float>
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00011E44 File Offset: 0x00010044
		public override ValueType valueType
		{
			get
			{
				return ValueType.Float;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00011E47 File Offset: 0x00010047
		public override bool isTruthy
		{
			get
			{
				return base.value != 0f;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00011E59 File Offset: 0x00010059
		public FloatValue(float val) : base(val)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00011E62 File Offset: 0x00010062
		public FloatValue() : this(0f)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00011E70 File Offset: 0x00010070
		public override Value Cast(ValueType newType)
		{
			if (newType == this.valueType)
			{
				return this;
			}
			if (newType == ValueType.Int)
			{
				return new IntValue((int)base.value);
			}
			if (newType == ValueType.String)
			{
				return new StringValue(base.value.ToString(CultureInfo.InvariantCulture) ?? "");
			}
			throw new Exception("Unexpected type cast of Value to new ValueType");
		}
	}
}
