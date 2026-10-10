using System;
using System.Collections.Generic;

namespace NSubstitute.Core
{
	// Token: 0x0200008C RID: 140
	public interface ICustomHandlers
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000214 RID: 532
		IReadOnlyCollection<ICallHandler> Handlers { get; }

		// Token: 0x06000215 RID: 533
		void AddCustomHandlerFactory(CallHandlerFactory factory);
	}
}
