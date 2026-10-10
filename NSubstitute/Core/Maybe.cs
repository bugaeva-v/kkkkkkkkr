using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x020000A6 RID: 166
	public struct Maybe<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x0600027B RID: 635 RVA: 0x00006A63 File Offset: 0x00004C63
		public Maybe(T value)
		{
			this = default(Maybe<T>);
			this.value = value;
			this.hasValue = true;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00006A7A File Offset: 0x00004C7A
		public bool HasValue()
		{
			return this.hasValue;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00006A84 File Offset: 0x00004C84
		public Maybe<T> OrElse(Func<Maybe<T>> other)
		{
			return this.Fold<Maybe<T>>(other, (T _) => this);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public Maybe<T> OrElse(Maybe<T> other)
		{
			return this.OrElse(() => other);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00006AE4 File Offset: 0x00004CE4
		public T ValueOr(Func<T> other)
		{
			return this.Fold<T>(other, (T x) => x);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00006B0C File Offset: 0x00004D0C
		public T ValueOr(T other)
		{
			return this.ValueOr(() => other);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00006B38 File Offset: 0x00004D38
		[NullableContext(2)]
		public T ValueOrDefault()
		{
			return this.ValueOr(default(T));
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00006B54 File Offset: 0x00004D54
		public TResult Fold<TResult>(Func<TResult> handleNoValue, Func<T, TResult> handleValue)
		{
			if (!this.HasValue())
			{
				return handleNoValue();
			}
			return handleValue(this.value);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00006B71 File Offset: 0x00004D71
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			if (this.hasValue)
			{
				yield return this.value;
			}
			yield break;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00006B85 File Offset: 0x00004D85
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		// Token: 0x040000A9 RID: 169
		private readonly bool hasValue;

		// Token: 0x040000AA RID: 170
		private readonly T value;
	}
}
