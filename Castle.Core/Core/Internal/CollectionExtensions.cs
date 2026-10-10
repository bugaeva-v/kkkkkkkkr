using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Castle.Core.Internal
{
	// Token: 0x020000DF RID: 223
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class CollectionExtensions
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x00011BED File Offset: 0x0000FDED
		public static T Find<T>(this T[] items, Predicate<T> predicate)
		{
			return Array.Find<T>(items, predicate);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00011BF6 File Offset: 0x0000FDF6
		public static T[] FindAll<T>(this T[] items, Predicate<T> predicate)
		{
			return Array.FindAll<T>(items, predicate);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00011BFF File Offset: 0x0000FDFF
		public static bool IsNullOrEmpty(this IEnumerable @this)
		{
			return @this == null || !@this.GetEnumerator().MoveNext();
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00011C14 File Offset: 0x0000FE14
		public static int GetContentsHashCode<T>(IList<T> list)
		{
			if (list == null)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] != null)
				{
					int num2 = num;
					T t = list[i];
					num = num2 + t.GetHashCode();
				}
			}
			return num;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00011C60 File Offset: 0x0000FE60
		public static bool AreEquivalent<T>(IList<T> listA, IList<T> listB)
		{
			if (listA == null && listB == null)
			{
				return true;
			}
			if (listA == null || listB == null)
			{
				return false;
			}
			if (listA.Count != listB.Count)
			{
				return false;
			}
			List<T> list = listB.ToList<T>();
			for (int i = 0; i < listA.Count; i++)
			{
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (object.Equals(listA[i], list[j]))
					{
						flag = true;
						list.RemoveAt(j);
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}
	}
}
