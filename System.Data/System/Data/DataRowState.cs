using System;

namespace System.Data
{
	/// <summary>Получает состояние объекта <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x020000C6 RID: 198
	[Flags]
	public enum DataRowState
	{
		/// <summary>Строка была создана, но не является частью какой-либо <see cref="T:System.Data.DataRowCollection" />. Объект <see cref="T:System.Data.DataRow" /> имеет это состояние сразу после своего создания и перед добавлением в коллекцию, а также если он был удален из коллекции.</summary>
		// Token: 0x040007E9 RID: 2025
		Detached = 1,
		/// <summary>Строка не была изменена с момента последнего вызова <see cref="M:System.Data.DataRow.AcceptChanges" />.</summary>
		// Token: 0x040007EA RID: 2026
		Unchanged = 2,
		/// <summary>Строка была добавлена в коллекцию <see cref="T:System.Data.DataRowCollection" /> и метод <see cref="M:System.Data.DataRow.AcceptChanges" /> не был вызван.</summary>
		// Token: 0x040007EB RID: 2027
		Added = 4,
		/// <summary>Строка была удалена с помощью метода <see cref="M:System.Data.DataRow.Delete" /> объекта <see cref="T:System.Data.DataRow" />.</summary>
		// Token: 0x040007EC RID: 2028
		Deleted = 8,
		/// <summary>Строка была изменена и объект <see cref="M:System.Data.DataRow.AcceptChanges" /> не был вызван.</summary>
		// Token: 0x040007ED RID: 2029
		Modified = 16
	}
}
