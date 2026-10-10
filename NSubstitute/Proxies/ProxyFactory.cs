using System;
using System.Runtime.CompilerServices;
using NSubstitute.Core;

namespace NSubstitute.Proxies
{
	// Token: 0x0200003C RID: 60
	[Obsolete("This class is deprecated and will be removed in future versions of the product.")]
	public class ProxyFactory : IProxyFactory
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00003FD2 File Offset: 0x000021D2
		public ProxyFactory(IProxyFactory delegateFactory, IProxyFactory dynamicProxyFactory)
		{
			this._delegateFactory = delegateFactory;
			this._dynamicProxyFactory = dynamicProxyFactory;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003FE8 File Offset: 0x000021E8
		public object GenerateProxy(ICallRouter callRouter, Type typeToProxy, [Nullable(new byte[]
		{
			2,
			0
		})] Type[] additionalInterfaces, [Nullable(2)] object[] constructorArguments)
		{
			if (!typeToProxy.IsDelegate())
			{
				return this._dynamicProxyFactory.GenerateProxy(callRouter, typeToProxy, additionalInterfaces, constructorArguments);
			}
			return this._delegateFactory.GenerateProxy(callRouter, typeToProxy, additionalInterfaces, constructorArguments);
		}

		// Token: 0x0400004B RID: 75
		private readonly IProxyFactory _delegateFactory;

		// Token: 0x0400004C RID: 76
		private readonly IProxyFactory _dynamicProxyFactory;
	}
}
