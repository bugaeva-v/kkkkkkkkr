using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x020000B7 RID: 183
	public class SubstituteFactory : ISubstituteFactory
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x0000754C File Offset: 0x0000574C
		public SubstituteFactory(ISubstituteStateFactory substituteStateFactory, ICallRouterFactory callRouterFactory, IProxyFactory proxyFactory)
		{
			this._substituteStateFactory = substituteStateFactory;
			this._callRouterFactory = callRouterFactory;
			this._proxyFactory = proxyFactory;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00007569 File Offset: 0x00005769
		public object Create(Type[] typesToProxy, [Nullable(new byte[]
		{
			0,
			2
		})] object[] constructorArguments)
		{
			return this.Create(typesToProxy, constructorArguments, false);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00007574 File Offset: 0x00005774
		public object CreatePartial(Type[] typesToProxy, [Nullable(new byte[]
		{
			0,
			2
		})] object[] constructorArguments)
		{
			Type primaryProxyType = SubstituteFactory.GetPrimaryProxyType(typesToProxy);
			if (!SubstituteFactory.CanCallBaseImplementation(primaryProxyType))
			{
				throw new CanNotPartiallySubForInterfaceOrDelegateException(primaryProxyType);
			}
			return this.Create(typesToProxy, constructorArguments, true);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000075A0 File Offset: 0x000057A0
		private object Create(Type[] typesToProxy, [Nullable(new byte[]
		{
			0,
			2
		})] object[] constructorArguments, bool callBaseByDefault)
		{
			ISubstituteState substituteState = this._substituteStateFactory.Create(this);
			substituteState.CallBaseConfiguration.CallBaseByDefault = callBaseByDefault;
			Type primaryProxyType = SubstituteFactory.GetPrimaryProxyType(typesToProxy);
			bool canConfigureBaseCalls = callBaseByDefault || SubstituteFactory.CanCallBaseImplementation(primaryProxyType);
			ICallRouter callRouter = this._callRouterFactory.Create(substituteState, canConfigureBaseCalls);
			Type[] additionalInterfaces = (from x in typesToProxy
			where x != primaryProxyType
			select x).ToArray<Type>();
			return this._proxyFactory.GenerateProxy(callRouter, primaryProxyType, additionalInterfaces, constructorArguments);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00007628 File Offset: 0x00005828
		private static Type GetPrimaryProxyType(Type[] typesToProxy)
		{
			Type result;
			if ((result = typesToProxy.FirstOrDefault((Type t) => t.IsDelegate())) == null)
			{
				result = (typesToProxy.FirstOrDefault((Type t) => t.GetTypeInfo().IsClass) ?? typesToProxy.First<Type>());
			}
			return result;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00007690 File Offset: 0x00005890
		private static bool CanCallBaseImplementation(Type primaryProxyType)
		{
			bool flag = primaryProxyType.IsDelegate();
			return primaryProxyType.GetTypeInfo().IsClass && !flag;
		}

		// Token: 0x040000BF RID: 191
		private readonly ISubstituteStateFactory _substituteStateFactory;

		// Token: 0x040000C0 RID: 192
		private readonly ICallRouterFactory _callRouterFactory;

		// Token: 0x040000C1 RID: 193
		private readonly IProxyFactory _proxyFactory;
	}
}
