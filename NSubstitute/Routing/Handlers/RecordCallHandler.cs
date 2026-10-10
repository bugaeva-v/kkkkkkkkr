using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000027 RID: 39
	public class RecordCallHandler : ICallHandler
	{
		// Token: 0x06000099 RID: 153 RVA: 0x0000371B File Offset: 0x0000191B
		public RecordCallHandler(ICallCollection callCollection, SequenceNumberGenerator generator)
		{
			this._callCollection = callCollection;
			this._generator = generator;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003731 File Offset: 0x00001931
		public RouteAction Handle(ICall call)
		{
			call.AssignSequenceNumber(this._generator.Next());
			this._callCollection.Add(call);
			return RouteAction.Continue();
		}

		// Token: 0x04000030 RID: 48
		private readonly ICallCollection _callCollection;

		// Token: 0x04000031 RID: 49
		private readonly SequenceNumberGenerator _generator;
	}
}
