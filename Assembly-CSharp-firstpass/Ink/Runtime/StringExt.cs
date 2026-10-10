using System;
using System.Collections.Generic;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x02000037 RID: 55
	internal static class StringExt
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00011BF0 File Offset: 0x0000FDF0
		public static string Join<T>(string separator, List<T> objects)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			foreach (T t in objects)
			{
				if (!flag)
				{
					stringBuilder.Append(separator);
				}
				stringBuilder.Append(t.ToString());
				flag = false;
			}
			return stringBuilder.ToString();
		}
	}
}
