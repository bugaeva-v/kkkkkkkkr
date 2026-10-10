using System;

namespace System.Data.Common
{
	/// <summary>Предоставляет механизм для перечисления всех доступных экземпляров серверов баз данных в локальной сети.</summary>
	// Token: 0x02000395 RID: 917
	public abstract class DbDataSourceEnumerator
	{
		/// <summary>Получает объект <see cref="T:System.Data.DataTable" />, содержащий сведения обо всех видимых экземплярах сервера, представленных строго типизированным экземпляром этого класса.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий сведения обо всех видимых экземплярах связанного источника данных.</returns>
		// Token: 0x06002CA1 RID: 11425
		public abstract DataTable GetDataSources();
	}
}
