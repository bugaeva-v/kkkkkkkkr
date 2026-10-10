using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NSubstitute.Core
{
	// Token: 0x020000A8 RID: 168
	public class MethodFormatter : IMethodInfoFormatter
	{
		// Token: 0x06000287 RID: 647 RVA: 0x00006BB6 File Offset: 0x00004DB6
		public bool CanFormat(MethodInfo methodInfo)
		{
			return true;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00006BBC File Offset: 0x00004DBC
		public string Format(MethodInfo methodInfo, IEnumerable<string> arguments)
		{
			string text = string.Join(", ", arguments);
			return string.Concat(new string[]
			{
				methodInfo.Name,
				MethodFormatter.FormatGenericType(methodInfo),
				"(",
				text,
				")"
			});
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00006C08 File Offset: 0x00004E08
		private static string FormatGenericType(MethodInfo methodInfoOfCall)
		{
			if (!methodInfoOfCall.IsGenericMethod)
			{
				return string.Empty;
			}
			Type[] genericArguments = methodInfoOfCall.GetGenericArguments();
			return "<" + string.Join(", ", from x in genericArguments
			select x.GetNonMangledTypeName()) + ">";
		}
	}
}
