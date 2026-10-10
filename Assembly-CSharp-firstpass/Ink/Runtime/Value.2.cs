using System;

namespace Ink.Runtime
{
	// Token: 0x0200003B RID: 59
	internal abstract class Value<T> : Value
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00011D7E File Offset: 0x0000FF7E
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00011D86 File Offset: 0x0000FF86
		public T value { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00011D8F File Offset: 0x0000FF8F
		public override object valueObject
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00011D9C File Offset: 0x0000FF9C
		public Value(T val)
		{
			this.value = val;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00011DAC File Offset: 0x0000FFAC
		public override string ToString()
		{
			T value = this.value;
			return value.ToString();
		}
	}
}
