using System;

namespace System.Data.SqlClient
{
	/// <summary>Указывает значение для свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.PoolBlockingPeriod" />.</summary>
	// Token: 0x02000286 RID: 646
	public enum PoolBlockingPeriod
	{
		/// <summary>Период блокировки отключен для серверов Azure SQL Server, но включен для всех остальных серверов SQL Server.</summary>
		// Token: 0x040014BD RID: 5309
		Auto,
		/// <summary>Период блокировки включен для всех серверов SQL Server, в том числе для серверов Azure SQL Server.</summary>
		// Token: 0x040014BE RID: 5310
		AlwaysBlock,
		/// <summary>Период блокировки отключен для всех серверов SQL Server, в том числе для серверов Azure SQL Server.</summary>
		// Token: 0x040014BF RID: 5311
		NeverBlock
	}
}
