using System;
using NSubstitute.Core;

namespace NSubstitute.Callbacks
{
	// Token: 0x020000E4 RID: 228
	public class EndCallbackChain : Callback
	{
		// Token: 0x060003BB RID: 955 RVA: 0x000093C0 File Offset: 0x000075C0
		internal EndCallbackChain()
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000093C8 File Offset: 0x000075C8
		public Callback AndAlways(Action<CallInfo> doThis)
		{
			base.SetAlwaysDo(doThis);
			return this;
		}
	}
}
