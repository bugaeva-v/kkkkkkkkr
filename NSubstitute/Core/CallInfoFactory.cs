using System;

namespace NSubstitute.Core
{
	// Token: 0x0200006A RID: 106
	public class CallInfoFactory : ICallInfoFactory
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00005966 File Offset: 0x00003B66
		public CallInfo Create(ICall call)
		{
			return new CallInfo(CallInfoFactory.GetArgumentsFromCall(call));
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005974 File Offset: 0x00003B74
		private static Argument[] GetArgumentsFromCall(ICall call)
		{
			Argument[] array = new Argument[call.GetOriginalArguments().Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new Argument(call, i);
			}
			return array;
		}
	}
}
