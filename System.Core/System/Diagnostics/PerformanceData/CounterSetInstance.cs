using System;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.PerformanceData
{
	/// <summary>
	///         Создает экземпляр логических счетчиков, определенных в классе <see cref="T:System.Diagnostics.PerformanceData.CounterSet" />.
	///       </summary>
	// Token: 0x02000391 RID: 913
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class CounterSetInstance : IDisposable
	{
		// Token: 0x06001B49 RID: 6985 RVA: 0x0000235B File Offset: 0x0000055B
		internal CounterSetInstance()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Извлекает коллекцию данных счетчиков для экземпляра набора счетчиков.
		///       </summary>
		/// <returns>
		///         Коллекция данных счетчиков, содержащаяся в экземпляре набора счетчиков.
		///       </returns>
		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0005A05A File Offset: 0x0005825A
		public CounterSetInstanceCounterDataSet Counters
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Освобождает все неуправляемые ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001B4B RID: 6987 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public void Dispose()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
