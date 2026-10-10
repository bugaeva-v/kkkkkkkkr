using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000E1 RID: 225
	internal static class ListExtension
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x0000A1F7 File Offset: 0x000083F7
		internal static AndroidJavaObject ToJava<T>(this List<T> values)
		{
			return ListExtension.ToJavaArray<T>(values);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000A200 File Offset: 0x00008400
		private static AndroidJavaObject ToJavaArray<T>(List<T> values)
		{
			AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.util.ArrayList", Array.Empty<object>());
			foreach (T t in values)
			{
				androidJavaObject.Call<bool>("add", new object[]
				{
					t
				});
			}
			return androidJavaObject;
		}
	}
}
