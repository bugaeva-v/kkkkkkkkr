using System;

namespace System.Data.SqlClient
{
	/// <summary>Задает значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.ApplicationIntent" />. Возможными значениями являются <see langword="ReadWrite" /> и <see langword="ReadOnly" />.</summary>
	// Token: 0x02000186 RID: 390
	public enum ApplicationIntent
	{
		/// <summary>Тип рабочей нагрузки приложения при подключении к серверу: доступен для чтения и записи.</summary>
		// Token: 0x04000CA3 RID: 3235
		ReadWrite,
		/// <summary>Тип рабочей нагрузки приложения при подключении к серверу: доступен только для чтения.</summary>
		// Token: 0x04000CA4 RID: 3236
		ReadOnly
	}
}
