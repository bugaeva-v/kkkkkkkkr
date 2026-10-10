using System;

namespace Castle.Core.Internal
{
	// Token: 0x020000ED RID: 237
	internal static class TypeExtensions
	{
		// Token: 0x0600064C RID: 1612 RVA: 0x0001255F File Offset: 0x0001075F
		public static string GetBestName(this Type type)
		{
			return type.FullName ?? type.Name;
		}
	}
}
