using System;

namespace System.Data
{
	/// <summary>Представляет открытое подключение к источнику данных и реализуется поставщиками данных платформы NET Framework, которые имеют доступ к реляционным базам данных.</summary>
	// Token: 0x02000104 RID: 260
	public interface IDbConnection : IDisposable
	{
		/// <summary>Получает или задает строку, используемую для открытия базы данных.</summary>
		/// <returns>Строка, содержащая параметры подключения.</returns>
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000F59 RID: 3929
		// (set) Token: 0x06000F5A RID: 3930
		string ConnectionString { get; set; }

		/// <summary>Получает время ожидания при попытке установки подключения, по истечении которого попытка подключения завершается и создается ошибка.</summary>
		/// <returns>Время (в секундах), в течение которого должно производиться ожидание открытия соединения. Значение по умолчанию - 15 секунды.</returns>
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000F5B RID: 3931
		int ConnectionTimeout { get; }

		/// <summary>Получает имя текущей базы данных или базы данных, которая будет использоваться после открытия подключения.</summary>
		/// <returns>Имя текущей базы данных или базы данных, которая будет использоваться после открытия подключения. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000F5C RID: 3932
		string Database { get; }

		/// <summary>Возвращает текущее состояние подключения.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Data.ConnectionState" />.</returns>
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000F5D RID: 3933
		ConnectionState State { get; }

		/// <summary>Начинает транзакцию базы данных.</summary>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		// Token: 0x06000F5E RID: 3934
		IDbTransaction BeginTransaction();

		/// <summary>Начинает транзакцию базы данных с указанным значением <see cref="T:System.Data.IsolationLevel" />.</summary>
		/// <param name="il">Одно из значений перечисления <see cref="T:System.Data.IsolationLevel" />.</param>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		// Token: 0x06000F5F RID: 3935
		IDbTransaction BeginTransaction(IsolationLevel il);

		/// <summary>Закрывает соединение с базой данных.</summary>
		// Token: 0x06000F60 RID: 3936
		void Close();

		/// <summary>Изменяет текущую базу данных для открытого объекта <see langword="Connection" />.</summary>
		/// <param name="databaseName">Имя базы данных, которая предназначена для использования вместо текущей базы данных.</param>
		// Token: 0x06000F61 RID: 3937
		void ChangeDatabase(string databaseName);

		/// <summary>Создает и возвращает объект Command, связанный с подключением.</summary>
		/// <returns>Объект Command, связанный с подключением.</returns>
		// Token: 0x06000F62 RID: 3938
		IDbCommand CreateCommand();

		/// <summary>Устанавливает подключение к базе данных с параметрами, указанными в свойстве <see langword="ConnectionString" /> объекта Connection для определенного поставщика.</summary>
		// Token: 0x06000F63 RID: 3939
		void Open();
	}
}
