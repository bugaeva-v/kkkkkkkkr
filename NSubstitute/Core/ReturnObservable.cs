using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x020000B1 RID: 177
	internal class ReturnObservable<T> : IObservable<T>
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x00007304 File Offset: 0x00005504
		public ReturnObservable() : this(default(T))
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00007320 File Offset: 0x00005520
		[NullableContext(2)]
		public ReturnObservable(T value)
		{
			this._value = value;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000732F File Offset: 0x0000552F
		public IDisposable Subscribe([Nullable(new byte[]
		{
			0,
			2
		})] IObserver<T> observer)
		{
			observer.OnNext(this._value);
			observer.OnCompleted();
			return EmptyDisposable.Instance;
		}

		// Token: 0x040000B4 RID: 180
		[Nullable(2)]
		private readonly T _value;
	}
}
