using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x0200009D RID: 157
	public class ReturnValueFromFunc<T> : IReturn
	{
		// Token: 0x0600023C RID: 572 RVA: 0x000068A2 File Offset: 0x00004AA2
		public ReturnValueFromFunc([Nullable(new byte[]
		{
			2,
			0,
			2
		})] Func<CallInfo, T> funcToReturnValue)
		{
			this._funcToReturnValue = (funcToReturnValue ?? ReturnValueFromFunc<T>.ReturnNull());
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000068BA File Offset: 0x00004ABA
		[return: Nullable(2)]
		public object ReturnFor(CallInfo info)
		{
			return this._funcToReturnValue(info);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000068CD File Offset: 0x00004ACD
		public Type TypeOrNull()
		{
			return typeof(T);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000068D9 File Offset: 0x00004AD9
		public bool CanBeAssignedTo(Type t)
		{
			return typeof(T).IsAssignableFrom(t);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000068EC File Offset: 0x00004AEC
		[return: Nullable(new byte[]
		{
			0,
			0,
			2
		})]
		private static Func<CallInfo, T> ReturnNull()
		{
			if (typeof(T).GetTypeInfo().IsValueType)
			{
				throw new CannotReturnNullForValueType(typeof(T));
			}
			return (CallInfo x) => default(T);
		}

		// Token: 0x040000A1 RID: 161
		[Nullable(new byte[]
		{
			0,
			0,
			2
		})]
		private readonly Func<CallInfo, T> _funcToReturnValue;
	}
}
