using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001AD RID: 429
	public static class RealizableExtensions
	{
		// Token: 0x06000D24 RID: 3364 RVA: 0x0001FB4C File Offset: 0x0001DD4C
		public static IRealizable<T> RequireRealizable<T>(this IRealizableSource obj)
		{
			IRealizable<T> realizable = obj.AsRealizable<T>();
			if (realizable == null)
			{
				throw Error.NotRealizable<T>();
			}
			return realizable;
		}
	}
}
