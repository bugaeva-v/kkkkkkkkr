using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Указывает значения, разрешенные для выбора результатов транзакции.</summary>
	// Token: 0x02000055 RID: 85
	[ComVisible(false)]
	[Serializable]
	public enum TransactionVote
	{
		/// <summary>Отменяет текущую транзакцию.</summary>
		// Token: 0x040000AE RID: 174
		Abort = 1,
		/// <summary>Фиксирует текущую транзакцию.</summary>
		// Token: 0x040000AF RID: 175
		Commit = 0
	}
}
