using System;
using NSubstitute.Core;

namespace NSubstitute.Callbacks
{
	// Token: 0x020000E3 RID: 227
	public class ConfiguredCallback : EndCallbackChain
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x0000932B File Offset: 0x0000752B
		internal ConfiguredCallback()
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00009333 File Offset: 0x00007533
		public ConfiguredCallback Then(Action<CallInfo> doThis)
		{
			base.AddCallback(doThis);
			return this;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000933D File Offset: 0x0000753D
		public EndCallbackChain ThenKeepDoing(Action<CallInfo> doThis)
		{
			base.SetKeepDoing(doThis);
			return this;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00009347 File Offset: 0x00007547
		public EndCallbackChain ThenKeepThrowing<TException>(Func<CallInfo, TException> throwThis) where TException : Exception
		{
			return this.ThenKeepDoing(Callback.ToCallback<TException>(throwThis));
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00009358 File Offset: 0x00007558
		public EndCallbackChain ThenKeepThrowing<TException>(TException throwThis) where TException : Exception
		{
			return this.ThenKeepThrowing<TException>((CallInfo info) => throwThis);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00009384 File Offset: 0x00007584
		public ConfiguredCallback ThenThrow<TException>(Func<CallInfo, TException> throwThis) where TException : Exception
		{
			base.AddCallback(Callback.ToCallback<TException>(throwThis));
			return this;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00009394 File Offset: 0x00007594
		public ConfiguredCallback ThenThrow<TException>(TException exception) where TException : Exception
		{
			return this.ThenThrow<TException>((CallInfo _) => exception);
		}
	}
}
