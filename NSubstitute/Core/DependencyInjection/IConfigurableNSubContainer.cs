using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.DependencyInjection
{
	// Token: 0x020000C5 RID: 197
	public interface IConfigurableNSubContainer : INSubContainer, INSubResolver
	{
		// Token: 0x0600033E RID: 830
		IConfigurableNSubContainer Register<[Nullable(1)] TKey, TImpl>(NSubLifetime lifetime) where TImpl : TKey;

		// Token: 0x0600033F RID: 831
		IConfigurableNSubContainer Register<[Nullable(1)] TKey>(Func<INSubResolver, TKey> factory, NSubLifetime lifetime);

		// Token: 0x06000340 RID: 832
		IConfigurableNSubContainer Decorate<[Nullable(1)] TKey>(Func<TKey, INSubResolver, TKey> factory);
	}
}
