using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000139 RID: 313
	public class DynamicValueDelegate<T> : DynamicValue<T>
	{
		// Token: 0x06000898 RID: 2200 RVA: 0x00016B50 File Offset: 0x00014D50
		public DynamicValueDelegate(Func<T> dynamicDelegate)
		{
			this.dynamicDelegate = dynamicDelegate;
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00016B5F File Offset: 0x00014D5F
		public override T Value
		{
			get
			{
				return this.dynamicDelegate();
			}
		}

		// Token: 0x040001F7 RID: 503
		private readonly Func<T> dynamicDelegate;
	}
}
