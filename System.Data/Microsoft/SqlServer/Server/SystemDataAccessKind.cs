using System;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Описывает тип доступа к системным данным для определенного пользователем метода или функции.</summary>
	// Token: 0x02000058 RID: 88
	[Serializable]
	public enum SystemDataAccessKind
	{
		/// <summary>Метод или функция не выполняет доступ к системным данным.</summary>
		// Token: 0x04000546 RID: 1350
		None,
		/// <summary>Метод или функция читает системные данные.</summary>
		// Token: 0x04000547 RID: 1351
		Read
	}
}
