using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000060 RID: 96
	public static class StrongNameUtil
	{
		// Token: 0x060002EF RID: 751 RVA: 0x0000B820 File Offset: 0x00009A20
		[SecuritySafeCritical]
		static StrongNameUtil()
		{
			try
			{
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
				StrongNameUtil.CanStrongNameAssembly = true;
			}
			catch (SecurityException)
			{
				StrongNameUtil.CanStrongNameAssembly = false;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000B870 File Offset: 0x00009A70
		public static bool IsAssemblySigned(this Assembly assembly)
		{
			object obj = StrongNameUtil.lockObject;
			bool result;
			lock (obj)
			{
				bool flag2;
				if (!StrongNameUtil.signedAssemblyCache.TryGetValue(assembly, out flag2))
				{
					flag2 = assembly.ContainsPublicKey();
					StrongNameUtil.signedAssemblyCache.Add(assembly, flag2);
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		private static bool ContainsPublicKey(this Assembly assembly)
		{
			return assembly.FullName != null && !assembly.FullName.Contains("PublicKeyToken=null");
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000B8EF File Offset: 0x00009AEF
		public static bool IsAnyTypeFromUnsignedAssembly(IEnumerable<Type> types)
		{
			return types.Any((Type t) => !t.GetTypeInfo().Assembly.IsAssemblySigned());
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000B916 File Offset: 0x00009B16
		public static bool IsAnyTypeFromUnsignedAssembly(Type baseType, IEnumerable<Type> interfaces)
		{
			return (baseType != null && !baseType.GetTypeInfo().Assembly.IsAssemblySigned()) || StrongNameUtil.IsAnyTypeFromUnsignedAssembly(interfaces);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000B93B File Offset: 0x00009B3B
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000B942 File Offset: 0x00009B42
		public static bool CanStrongNameAssembly { get; set; }

		// Token: 0x040000C3 RID: 195
		private static readonly IDictionary<Assembly, bool> signedAssemblyCache = new Dictionary<Assembly, bool>();

		// Token: 0x040000C4 RID: 196
		private static readonly object lockObject = new object();
	}
}
