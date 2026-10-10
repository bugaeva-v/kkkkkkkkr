using System;

namespace Microsoft.Win32
{
	/// <summary>Определяет идентификаторы, представляющие способ завершения текущего сеанса входа в систему.</summary>
	// Token: 0x02000122 RID: 290
	public enum SessionEndReasons
	{
		/// <summary>Пользователь выходит из системы и завершает текущий пользовательский сеанс. Операционная система продолжает работать.</summary>
		// Token: 0x040004D3 RID: 1235
		Logoff = 1,
		/// <summary>Операционная система завершает работу.</summary>
		// Token: 0x040004D4 RID: 1236
		SystemShutdown
	}
}
