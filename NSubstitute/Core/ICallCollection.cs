using System;
using System.Collections.Generic;

namespace NSubstitute.Core
{
	// Token: 0x0200007F RID: 127
	public interface ICallCollection
	{
		// Token: 0x060001EF RID: 495
		void Add(ICall call);

		// Token: 0x060001F0 RID: 496
		void Delete(ICall call);

		// Token: 0x060001F1 RID: 497
		IEnumerable<ICall> AllCalls();

		// Token: 0x060001F2 RID: 498
		void Clear();
	}
}
