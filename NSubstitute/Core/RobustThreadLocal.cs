using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace NSubstitute.Core
{
	// Token: 0x020000B3 RID: 179
	internal class RobustThreadLocal<T>
	{
		// Token: 0x060002BD RID: 701 RVA: 0x00007365 File Offset: 0x00005565
		public RobustThreadLocal()
		{
			this._threadLocal = new ThreadLocal<T>();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00007378 File Offset: 0x00005578
		public RobustThreadLocal(Func<T> initialValueFactory)
		{
			this._initialValueFactory = initialValueFactory;
			this._threadLocal = new ThreadLocal<T>(initialValueFactory);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00007394 File Offset: 0x00005594
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000073E4 File Offset: 0x000055E4
		public T Value
		{
			get
			{
				T result;
				try
				{
					result = this._threadLocal.Value;
				}
				catch (ObjectDisposedException)
				{
					result = ((this._initialValueFactory != null) ? this._initialValueFactory() : default(T));
				}
				return result;
			}
			set
			{
				try
				{
					this._threadLocal.Value = value;
				}
				catch (ObjectDisposedException)
				{
				}
			}
		}

		// Token: 0x040000B6 RID: 182
		private readonly ThreadLocal<T> _threadLocal;

		// Token: 0x040000B7 RID: 183
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private readonly Func<T> _initialValueFactory;
	}
}
