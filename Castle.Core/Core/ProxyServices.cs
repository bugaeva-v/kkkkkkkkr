using System;
using System.Reflection;

namespace Castle.Core
{
	// Token: 0x020000B1 RID: 177
	public static class ProxyServices
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x0000F848 File Offset: 0x0000DA48
		public static bool IsDynamicProxy(Type type)
		{
			string fullName = type.GetTypeInfo().Assembly.FullName;
			return fullName.StartsWith("DynamicAssemblyProxyGen", StringComparison.Ordinal) || fullName.StartsWith("DynamicProxyGenAssembly2", StringComparison.Ordinal);
		}
	}
}
