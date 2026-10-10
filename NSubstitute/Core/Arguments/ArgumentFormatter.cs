using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000CB RID: 203
	public class ArgumentFormatter : IArgumentFormatter
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000355 RID: 853 RVA: 0x000087E7 File Offset: 0x000069E7
		internal static IArgumentFormatter Default { get; } = new ArgumentFormatter();

		// Token: 0x06000356 RID: 854 RVA: 0x000087F0 File Offset: 0x000069F0
		public string Format([Nullable(2)] object argument, bool highlight)
		{
			string text = this.Format(argument);
			if (!highlight)
			{
				return text;
			}
			return "*" + text + "*";
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000881C File Offset: 0x00006A1C
		private string Format([Nullable(2)] object arg)
		{
			string result;
			if (arg != null)
			{
				string text = arg as string;
				if (text == null)
				{
					if (ArgumentFormatter.<Format>g__HasDefaultToString|4_0(arg))
					{
						result = arg.GetType().GetNonMangledTypeName();
					}
					else
					{
						result = (arg.ToString() ?? string.Empty);
					}
				}
				else
				{
					string str = text;
					result = "\"" + str + "\"";
				}
			}
			else
			{
				result = "<null>";
			}
			return result;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00008892 File Offset: 0x00006A92
		[CompilerGenerated]
		internal static bool <Format>g__HasDefaultToString|4_0(object obj)
		{
			return obj.GetType().GetMethod("ToString", Type.EmptyTypes).DeclaringType == typeof(object);
		}
	}
}
