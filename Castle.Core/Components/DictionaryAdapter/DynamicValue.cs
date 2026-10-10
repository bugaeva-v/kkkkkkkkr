using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000138 RID: 312
	public abstract class DynamicValue<T> : IDynamicValue<T>, IDynamicValue
	{
		// Token: 0x06000894 RID: 2196 RVA: 0x00016B08 File Offset: 0x00014D08
		object IDynamicValue.GetValue()
		{
			return this.Value;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000895 RID: 2197
		public abstract T Value { get; }

		// Token: 0x06000896 RID: 2198 RVA: 0x00016B18 File Offset: 0x00014D18
		public override string ToString()
		{
			T value = this.Value;
			if (value != null)
			{
				return value.ToString();
			}
			return base.ToString();
		}
	}
}
