using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200002D RID: 45
	public static class AttributesToAvoidReplicating
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00005EEC File Offset: 0x000040EC
		public static void Add(Type attribute)
		{
			object obj = AttributesToAvoidReplicating.lockObject;
			lock (obj)
			{
				AttributesToAvoidReplicating.attributes = new List<Type>(AttributesToAvoidReplicating.attributes)
				{
					attribute
				};
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005F3C File Offset: 0x0000413C
		public static void Add<T>()
		{
			AttributesToAvoidReplicating.Add(typeof(T));
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005F4D File Offset: 0x0000414D
		public static bool Contains(Type attribute)
		{
			return AttributesToAvoidReplicating.attributes.Contains(attribute);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005F5C File Offset: 0x0000415C
		internal static bool ShouldAvoid(Type attribute)
		{
			return AttributesToAvoidReplicating.attributes.Any((Type attr) => attr.GetTypeInfo().IsAssignableFrom(attribute.GetTypeInfo()));
		}

		// Token: 0x04000066 RID: 102
		private static readonly object lockObject = new object();

		// Token: 0x04000067 RID: 103
		private static IList<Type> attributes = new List<Type>
		{
			typeof(ComImportAttribute),
			typeof(MarshalAsAttribute),
			typeof(TypeIdentifierAttribute),
			typeof(SecurityAttribute)
		};
	}
}
