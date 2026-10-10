using System;
using System.Runtime.CompilerServices;
using NSubstitute.Core;
using NSubstitute.Proxies.CastleDynamicProxy;

namespace NSubstitute.Proxies.DelegateProxy
{
	// Token: 0x0200003D RID: 61
	[Obsolete("This class is deprecated and will be removed in future versions of the product.")]
	public class DelegateProxyFactory : IProxyFactory
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00004013 File Offset: 0x00002213
		public DelegateProxyFactory(CastleDynamicProxyFactory objectProxyFactory)
		{
			if (objectProxyFactory == null)
			{
				throw new ArgumentNullException("objectProxyFactory");
			}
			this._castleObjectProxyFactory = objectProxyFactory;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004031 File Offset: 0x00002231
		public object GenerateProxy(ICallRouter callRouter, Type typeToProxy, [Nullable(new byte[]
		{
			2,
			0
		})] Type[] additionalInterfaces, [Nullable(2)] object[] constructorArguments)
		{
			return this._castleObjectProxyFactory.GenerateProxy(callRouter, typeToProxy, additionalInterfaces, constructorArguments);
		}

		// Token: 0x0400004D RID: 77
		private readonly CastleDynamicProxyFactory _castleObjectProxyFactory;
	}
}
