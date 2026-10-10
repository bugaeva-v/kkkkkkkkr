using System;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Описывает тип доступа к пользовательским данным для определенного пользователем метода или функции.</summary>
	// Token: 0x02000057 RID: 87
	[Serializable]
	public enum DataAccessKind
	{
		/// <summary>Метод или функция не выполняет доступ к пользовательским данным.</summary>
		// Token: 0x04000543 RID: 1347
		None,
		/// <summary>Метод или функция читает пользовательские данные.</summary>
		// Token: 0x04000544 RID: 1348
		Read
	}
}
