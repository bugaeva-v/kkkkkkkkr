using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Указывает состояние транзакции.</summary>
	// Token: 0x02000054 RID: 84
	[ComVisible(false)]
	[Serializable]
	public enum TransactionStatus
	{
		/// <summary>Транзакция зафиксирована.</summary>
		// Token: 0x040000A8 RID: 168
		Commited,
		/// <summary>Транзакция не является ни зафиксированной, ни отмененной.</summary>
		// Token: 0x040000A9 RID: 169
		LocallyOk,
		/// <summary>Транзакции не используются в методе <see cref="M:System.EnterpriseServices.ServiceDomain.Enter(System.EnterpriseServices.ServiceConfig)" />.</summary>
		// Token: 0x040000AA RID: 170
		NoTransaction,
		/// <summary>Транзакция в процессе отмены.</summary>
		// Token: 0x040000AB RID: 171
		Aborting,
		/// <summary>Транзакция отменяется.</summary>
		// Token: 0x040000AC RID: 172
		Aborted
	}
}
