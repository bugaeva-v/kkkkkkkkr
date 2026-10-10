using System;

namespace Ink.Runtime
{
	// Token: 0x0200003A RID: 58
	internal abstract class Value : Object
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000270 RID: 624
		public abstract ValueType valueType { get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000271 RID: 625
		public abstract bool isTruthy { get; }

		// Token: 0x06000272 RID: 626
		public abstract Value Cast(ValueType newType);

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000273 RID: 627
		public abstract object valueObject { get; }

		// Token: 0x06000274 RID: 628 RVA: 0x00011C9C File Offset: 0x0000FE9C
		public static Value Create(object val)
		{
			if (val is double)
			{
				val = (float)((double)val);
			}
			if (val is bool)
			{
				val = (((bool)val) ? 1 : 0);
			}
			if (val is int)
			{
				return new IntValue((int)val);
			}
			if (val is long)
			{
				return new IntValue((int)((long)val));
			}
			if (val is float)
			{
				return new FloatValue((float)val);
			}
			if (val is double)
			{
				return new FloatValue((float)((double)val));
			}
			if (val is string)
			{
				return new StringValue((string)val);
			}
			if (val is Path)
			{
				return new DivertTargetValue((Path)val);
			}
			if (val is InkList)
			{
				return new ListValue((InkList)val);
			}
			return null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00011D69 File Offset: 0x0000FF69
		internal override Object Copy()
		{
			return Value.Create(this.valueObject);
		}
	}
}
