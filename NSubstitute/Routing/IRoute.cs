using System;
using System.Runtime.CompilerServices;
using NSubstitute.Core;

namespace NSubstitute.Routing
{
	// Token: 0x02000019 RID: 25
	public interface IRoute
	{
		// Token: 0x06000069 RID: 105
		[return: Nullable(2)]
		object Handle(ICall call);
	}
}
