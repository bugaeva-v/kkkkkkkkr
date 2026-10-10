using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000046 RID: 70
	public class MethodFinder
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00008EAC File Offset: 0x000070AC
		public static MethodInfo[] GetAllInstanceMethods(Type type, BindingFlags flags)
		{
			if ((flags & ~(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)) != BindingFlags.Default)
			{
				throw new ArgumentException("MethodFinder only supports the Public, NonPublic, and Instance binding flags.", "flags");
			}
			object obj = MethodFinder.lockObject;
			MethodInfo[] array;
			lock (obj)
			{
				if (!MethodFinder.cachedMethodInfosByType.TryGetValue(type, out array))
				{
					array = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Distinct(MethodSignatureComparer.Instance).ToArray<MethodInfo>();
					MethodFinder.cachedMethodInfosByType.Add(type, array);
				}
			}
			return MethodFinder.MakeFilteredCopy(array, flags & (BindingFlags.Public | BindingFlags.NonPublic));
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00008F38 File Offset: 0x00007138
		private static MethodInfo[] MakeFilteredCopy(MethodInfo[] methodsInCache, BindingFlags visibilityFlags)
		{
			if ((visibilityFlags & ~(BindingFlags.Public | BindingFlags.NonPublic)) != BindingFlags.Default)
			{
				throw new ArgumentException("Only supports BindingFlags.Public and NonPublic.", "visibilityFlags");
			}
			bool flag = (visibilityFlags & BindingFlags.Public) == BindingFlags.Public;
			bool flag2 = (visibilityFlags & BindingFlags.NonPublic) == BindingFlags.NonPublic;
			List<MethodInfo> list = new List<MethodInfo>(methodsInCache.Length);
			foreach (MethodInfo methodInfo in methodsInCache)
			{
				if ((methodInfo.IsPublic && flag) || (!methodInfo.IsPublic && flag2))
				{
					list.Add(methodInfo);
				}
			}
			return list.ToArray();
		}

		// Token: 0x04000093 RID: 147
		private static readonly Dictionary<Type, MethodInfo[]> cachedMethodInfosByType = new Dictionary<Type, MethodInfo[]>();

		// Token: 0x04000094 RID: 148
		private static readonly object lockObject = new object();
	}
}
