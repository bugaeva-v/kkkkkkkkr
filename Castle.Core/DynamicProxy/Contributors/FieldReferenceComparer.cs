using System;
using System.Collections.Generic;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x0200009B RID: 155
	public class FieldReferenceComparer : IComparer<Type>
	{
		// Token: 0x060003D4 RID: 980 RVA: 0x0000E00B File Offset: 0x0000C20B
		public int Compare(Type x, Type y)
		{
			if (x == null)
			{
				throw new ArgumentNullException("x");
			}
			if (y == null)
			{
				throw new ArgumentNullException("y");
			}
			return string.CompareOrdinal(x.FullName, y.FullName);
		}
	}
}
