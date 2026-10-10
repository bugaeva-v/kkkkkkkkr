using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x02000034 RID: 52
	public class AutoObservableProvider : IAutoValueProvider
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00003B7D File Offset: 0x00001D7D
		public AutoObservableProvider(Lazy<IReadOnlyCollection<IAutoValueProvider>> autoValueProviders)
		{
			this._autoValueProviders = autoValueProviders;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003B8C File Offset: 0x00001D8C
		public bool CanProvideValueFor(Type type)
		{
			return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(IObservable<>);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[return: Nullable(2)]
		public object GetValue(Type type)
		{
			if (!this.CanProvideValueFor(type))
			{
				throw new InvalidOperationException();
			}
			Type innerType = type.GetGenericArguments()[0];
			IAutoValueProvider autoValueProvider = this._autoValueProviders.Value.FirstOrDefault((IAutoValueProvider vp) => vp.CanProvideValueFor(innerType));
			object obj = (autoValueProvider == null) ? AutoObservableProvider.GetDefault(type) : autoValueProvider.GetValue(innerType);
			return Activator.CreateInstance(typeof(ReturnObservable<>).MakeGenericType(new Type[]
			{
				innerType
			}), new object[]
			{
				obj
			});
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003C46 File Offset: 0x00001E46
		[return: Nullable(2)]
		private static object GetDefault(Type type)
		{
			if (!type.GetTypeInfo().IsValueType)
			{
				return null;
			}
			return Activator.CreateInstance(type);
		}

		// Token: 0x04000048 RID: 72
		private readonly Lazy<IReadOnlyCollection<IAutoValueProvider>> _autoValueProviders;
	}
}
