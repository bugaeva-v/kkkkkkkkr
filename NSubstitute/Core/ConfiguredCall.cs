using System;

namespace NSubstitute.Core
{
	// Token: 0x02000074 RID: 116
	public class ConfiguredCall
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x000061D7 File Offset: 0x000043D7
		public ConfiguredCall(Action<Action<CallInfo>> addAction)
		{
			this._addAction = addAction;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000061E6 File Offset: 0x000043E6
		public ConfiguredCall AndDoes(Action<CallInfo> action)
		{
			this._addAction(action);
			return this;
		}

		// Token: 0x04000091 RID: 145
		private readonly Action<Action<CallInfo>> _addAction;
	}
}
