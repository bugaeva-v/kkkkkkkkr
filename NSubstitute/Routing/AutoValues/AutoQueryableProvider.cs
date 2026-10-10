using System;
using System.Linq;
using System.Reflection;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x02000035 RID: 53
	public class AutoQueryableProvider : IAutoValueProvider
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00003C5D File Offset: 0x00001E5D
		public bool CanProvideValueFor(Type type)
		{
			return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(IQueryable<>);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003C83 File Offset: 0x00001E83
		public object GetValue(Type type)
		{
			if (!this.CanProvideValueFor(type))
			{
				throw new InvalidOperationException();
			}
			return Array.CreateInstance(type.GetGenericArguments()[0], 0).AsQueryable();
		}
	}
}
