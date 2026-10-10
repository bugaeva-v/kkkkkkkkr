using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x0200009F RID: 159
	public class ReturnMultipleFuncsValues<T> : IReturn
	{
		// Token: 0x06000247 RID: 583 RVA: 0x000069B8 File Offset: 0x00004BB8
		public ReturnMultipleFuncsValues([Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})] Func<CallInfo, T>[] funcs)
		{
			this._funcsToReturn = new ConcurrentQueue<Func<CallInfo, T>>(funcs);
			this._lastFunc = funcs.Last<Func<CallInfo, T>>();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000069D8 File Offset: 0x00004BD8
		[return: Nullable(2)]
		public object ReturnFor(CallInfo info)
		{
			return this.GetNext(info);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000069E6 File Offset: 0x00004BE6
		public Type TypeOrNull()
		{
			return typeof(T);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000069F2 File Offset: 0x00004BF2
		public bool CanBeAssignedTo(Type t)
		{
			return typeof(T).IsAssignableFrom(t);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00006A04 File Offset: 0x00004C04
		[return: Nullable(2)]
		private T GetNext(CallInfo info)
		{
			Func<CallInfo, T> func;
			if (!this._funcsToReturn.TryDequeue(out func))
			{
				return this._lastFunc(info);
			}
			return func(info);
		}

		// Token: 0x040000A4 RID: 164
		[Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})]
		private readonly ConcurrentQueue<Func<CallInfo, T>> _funcsToReturn;

		// Token: 0x040000A5 RID: 165
		[Nullable(new byte[]
		{
			0,
			0,
			2
		})]
		private readonly Func<CallInfo, T> _lastFunc;
	}
}
