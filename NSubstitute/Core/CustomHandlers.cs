using System;
using System.Collections.Generic;

namespace NSubstitute.Core
{
	// Token: 0x02000075 RID: 117
	public class CustomHandlers : ICustomHandlers
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000061F5 File Offset: 0x000043F5
		public IReadOnlyCollection<ICallHandler> Handlers
		{
			get
			{
				return this._handlers;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000061FD File Offset: 0x000043FD
		public CustomHandlers(ISubstituteState substituteState)
		{
			this._substituteState = substituteState;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00006217 File Offset: 0x00004417
		public void AddCustomHandlerFactory(CallHandlerFactory factory)
		{
			this._handlers.Add(factory(this._substituteState));
		}

		// Token: 0x04000092 RID: 146
		private readonly List<ICallHandler> _handlers = new List<ICallHandler>();

		// Token: 0x04000093 RID: 147
		private readonly ISubstituteState _substituteState;
	}
}
