using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x02000095 RID: 149
	public interface IProxyFactory
	{
		// Token: 0x0600022B RID: 555
		object GenerateProxy(ICallRouter callRouter, Type typeToProxy, [Nullable(new byte[]
		{
			2,
			0
		})] Type[] additionalInterfaces, [Nullable(2)] object[] constructorArguments);
	}
}
