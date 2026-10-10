using System;

namespace System.Data
{
	/// <summary>Задает тип SQL запроса для использования в классах <see cref="T:System.Data.OleDb.OleDbRowUpdatedEventArgs" />, <see cref="T:System.Data.OleDb.OleDbRowUpdatingEventArgs" />, <see cref="T:System.Data.SqlClient.SqlRowUpdatedEventArgs" /> или <see cref="T:System.Data.SqlClient.SqlRowUpdatingEventArgs" />.</summary>
	// Token: 0x02000135 RID: 309
	public enum StatementType
	{
		/// <summary>SQL-запрос, являющийся оператором SELECT.</summary>
		// Token: 0x04000A46 RID: 2630
		Select,
		/// <summary>SQL-запрос, являющийся оператором INSERT.</summary>
		// Token: 0x04000A47 RID: 2631
		Insert,
		/// <summary>SQL-запрос, являющийся оператором UPDATE.</summary>
		// Token: 0x04000A48 RID: 2632
		Update,
		/// <summary>SQL-запрос, являющийся оператором DELETE.</summary>
		// Token: 0x04000A49 RID: 2633
		Delete,
		/// <summary>SQL-запрос, являющийся пакетным оператором.</summary>
		// Token: 0x04000A4A RID: 2634
		Batch
	}
}
