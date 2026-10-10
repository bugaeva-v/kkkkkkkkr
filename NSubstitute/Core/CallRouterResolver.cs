using System;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x0200006E RID: 110
	public class CallRouterResolver : ICallRouterResolver
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public ICallRouter ResolveFor(object substitute)
		{
			if (substitute != null)
			{
				ICallRouterProvider callRouterProvider = substitute as ICallRouterProvider;
				if (callRouterProvider == null)
				{
					Delegate @delegate = substitute as Delegate;
					if (@delegate != null)
					{
						ICallRouterProvider callRouterProvider2 = @delegate.Target as ICallRouterProvider;
						if (callRouterProvider2 != null)
						{
							return callRouterProvider2.GetCallRouter();
						}
					}
					throw new NotASubstituteException();
				}
				return callRouterProvider.GetCallRouter();
			}
			throw new NullSubstituteReferenceException();
		}
	}
}
