using System;

namespace System.Collections.Generic
{
	// Token: 0x02000AC3 RID: 2755
	[Serializable]
	internal class ObjectComparer<T> : Comparer<T>
	{
		// Token: 0x06006282 RID: 25218 RVA: 0x00149D02 File Offset: 0x00147F02
		public override int Compare(T x, T y)
		{
			return Comparer.Default.Compare(x, y);
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x00149D1A File Offset: 0x00147F1A
		public override bool Equals(object obj)
		{
			return obj is ObjectComparer<T>;
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x00149C9A File Offset: 0x00147E9A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
