using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x0200011E RID: 286
	internal static class AndroidJavaObjectExtensions
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x0000BC18 File Offset: 0x00009E18
		internal static IEnumerable<T> Enumerate<T>(this AndroidJavaObject androidJavaList)
		{
			AndroidJavaObject androidJavaList2 = androidJavaList;
			int count = (androidJavaList2 != null) ? androidJavaList2.Call<int>("size", Array.Empty<object>()) : 0;
			return (from i in Enumerable.Range(0, count)
			select androidJavaList.Call<T>("get", new object[]
			{
				i
			})).ToList<T>();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000BC6C File Offset: 0x00009E6C
		internal static IEnumerable<AndroidJavaObject> Enumerate(this AndroidJavaObject androidJavaList)
		{
			return androidJavaList.Enumerate<AndroidJavaObject>();
		}
	}
}
