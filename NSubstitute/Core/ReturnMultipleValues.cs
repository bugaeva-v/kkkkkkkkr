using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x0200009E RID: 158
	public class ReturnMultipleValues<T> : IReturn, ICallIndependentReturn
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0000693E File Offset: 0x00004B3E
		public ReturnMultipleValues([Nullable(new byte[]
		{
			0,
			2
		})] T[] values)
		{
			this._valuesToReturn = new ConcurrentQueue<T>(values);
			this._lastValue = values.Last<T>();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000695E File Offset: 0x00004B5E
		[NullableContext(2)]
		public object GetReturnValue()
		{
			return this.GetNext();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000696B File Offset: 0x00004B6B
		[return: Nullable(2)]
		public object ReturnFor(CallInfo info)
		{
			return this.GetReturnValue();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00006973 File Offset: 0x00004B73
		public Type TypeOrNull()
		{
			return typeof(T);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000697F File Offset: 0x00004B7F
		public bool CanBeAssignedTo(Type t)
		{
			return typeof(T).IsAssignableFrom(t);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00006994 File Offset: 0x00004B94
		[NullableContext(2)]
		private T GetNext()
		{
			T result;
			if (!this._valuesToReturn.TryDequeue(out result))
			{
				return this._lastValue;
			}
			return result;
		}

		// Token: 0x040000A2 RID: 162
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private readonly ConcurrentQueue<T> _valuesToReturn;

		// Token: 0x040000A3 RID: 163
		[Nullable(2)]
		private readonly T _lastValue;
	}
}
