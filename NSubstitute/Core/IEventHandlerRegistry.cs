using System;
using System.Collections.Generic;

namespace NSubstitute.Core
{
	// Token: 0x0200008F RID: 143
	public interface IEventHandlerRegistry
	{
		// Token: 0x06000218 RID: 536
		void Add(string eventName, object handler);

		// Token: 0x06000219 RID: 537
		void Remove(string eventName, object handler);

		// Token: 0x0600021A RID: 538
		IEnumerable<object> GetHandlers(string eventName);
	}
}
