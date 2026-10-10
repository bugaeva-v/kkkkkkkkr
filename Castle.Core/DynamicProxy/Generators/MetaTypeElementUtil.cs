using System;
using System.Reflection;
using System.Text;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000045 RID: 69
	internal static class MetaTypeElementUtil
	{
		// Token: 0x0600022D RID: 557 RVA: 0x00008DA8 File Offset: 0x00006FA8
		public static string CreateNameForExplicitImplementation(Type sourceType, string name)
		{
			string @namespace = sourceType.Namespace;
			if (sourceType.GetTypeInfo().IsGenericType)
			{
				StringBuilder stringBuilder = new StringBuilder();
				if (@namespace != null)
				{
					stringBuilder.Append(@namespace);
					stringBuilder.Append('.');
				}
				stringBuilder.AppendNameOf(sourceType);
				stringBuilder.Append('.');
				stringBuilder.Append(name);
				return stringBuilder.ToString();
			}
			if (@namespace != null)
			{
				return string.Concat(new string[]
				{
					@namespace,
					".",
					sourceType.Name,
					".",
					name
				});
			}
			return sourceType.Name + "." + name;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008E44 File Offset: 0x00007044
		private static void AppendNameOf(this StringBuilder nameBuilder, Type type)
		{
			nameBuilder.Append(type.Name);
			if (type.GetTypeInfo().IsGenericType)
			{
				nameBuilder.Append('[');
				Type[] genericArguments = type.GetGenericArguments();
				int i = 0;
				int num = genericArguments.Length;
				while (i < num)
				{
					if (i > 0)
					{
						nameBuilder.Append(',');
					}
					nameBuilder.AppendNameOf(genericArguments[i]);
					i++;
				}
				nameBuilder.Append(']');
			}
		}
	}
}
