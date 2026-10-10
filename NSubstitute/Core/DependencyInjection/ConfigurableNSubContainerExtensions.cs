using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.DependencyInjection
{
	// Token: 0x020000C6 RID: 198
	public static class ConfigurableNSubContainerExtensions
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00008481 File Offset: 0x00006681
		public static IConfigurableNSubContainer RegisterPerScope<[Nullable(1)] TKey, TImpl>(this IConfigurableNSubContainer container) where TImpl : TKey
		{
			return container.Register<TKey, TImpl>(NSubLifetime.PerScope);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000848A File Offset: 0x0000668A
		public static IConfigurableNSubContainer RegisterPerScope<[Nullable(1)] TKey>(this IConfigurableNSubContainer container, Func<INSubResolver, TKey> factory)
		{
			return container.Register<TKey>(factory, NSubLifetime.PerScope);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00008494 File Offset: 0x00006694
		public static IConfigurableNSubContainer RegisterSingleton<[Nullable(1)] TKey, TImpl>(this IConfigurableNSubContainer container) where TImpl : TKey
		{
			return container.Register<TKey, TImpl>(NSubLifetime.Singleton);
		}
	}
}
