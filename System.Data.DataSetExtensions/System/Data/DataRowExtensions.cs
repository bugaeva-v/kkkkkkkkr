using System;

namespace System.Data
{
	/// <summary>Определяет методы расширения для класса <see cref="T:System.Data.DataRow" />. Этот класс является статическим.</summary>
	// Token: 0x02000007 RID: 7
	public static class DataRowExtensions
	{
		/// <summary>Обеспечивает строго типизированный доступ к каждому значению столбца в указанной строке. Метод <see cref="M:System.Data.DataRowExtensions.Field``1(System.Data.DataRow,System.String)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="columnName">Имя столбца, значение которого следует возвратить.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип возвращаемого значения для этого столбца.</typeparam>
		/// <returns>Значение типа <paramref name="T" /> столбца <see cref="T:System.Data.DataColumn" />, определенного именем <paramref name="columnName" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбец, определенный именем <paramref name="columnName" />, не находится в таблице <see cref="T:System.Data.DataTable" />, частью которой является строка <see cref="T:System.Data.DataRow" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Значение <see langword="null" /> было назначено типу, не поддерживающему значения null.</exception>
		// Token: 0x0600001A RID: 26 RVA: 0x00002553 File Offset: 0x00000753
		public static T Field<T>(this DataRow row, string columnName)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			return DataRowExtensions.UnboxT<T>.s_unbox(row[columnName]);
		}

		/// <summary>Обеспечивает строго типизированный доступ к каждому значению столбца в указанной строке. Метод <see cref="M:System.Data.DataRowExtensions.Field``1(System.Data.DataRow,System.Data.DataColumn)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="column">Объект входа <see cref="T:System.Data.DataColumn" />, в котором указывается столбец, значение которого следует возвратить.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип возвращаемого значения для этого столбца.</typeparam>
		/// <returns>Значение типа <paramref name="T" /> столбца <see cref="T:System.Data.DataColumn" />, определенного именем <paramref name="column" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбец, определенный именем <paramref name="column" />, не находится в таблице <see cref="T:System.Data.DataTable" />, частью которой является строка <see cref="T:System.Data.DataRow" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Значение null было назначено типу, не поддерживающему значения null.</exception>
		// Token: 0x0600001B RID: 27 RVA: 0x00002571 File Offset: 0x00000771
		public static T Field<T>(this DataRow row, DataColumn column)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			return DataRowExtensions.UnboxT<T>.s_unbox(row[column]);
		}

		/// <summary>Обеспечивает строго типизированный доступ к каждому значению столбца в указанной строке. Метод <see cref="M:System.Data.DataRowExtensions.Field``1(System.Data.DataRow,System.Int32)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="columnIndex">Индекс столбца.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип возвращаемого значения для этого столбца.</typeparam>
		/// <returns>Значение типа <paramref name="T" /> столбца <see cref="T:System.Data.DataColumn" />, определенного именем <paramref name="columnIndex" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбца, определенного именем <paramref name="ordinal" />, не существует в таблице <see cref="T:System.Data.DataTable" />, частью которой является строка <see cref="T:System.Data.DataRow" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Значение null было назначено типу, не поддерживающему значения null.</exception>
		// Token: 0x0600001C RID: 28 RVA: 0x0000258F File Offset: 0x0000078F
		public static T Field<T>(this DataRow row, int columnIndex)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			return DataRowExtensions.UnboxT<T>.s_unbox(row[columnIndex]);
		}

		/// <summary>Обеспечивает строго типизированный доступ к каждому значению столбца в указанной строке. Метод <see cref="M:System.Data.DataRowExtensions.Field``1(System.Data.DataRow,System.Int32,System.Data.DataRowVersion)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="columnIndex">Порядковый номер (начинающийся с нуля) столбца, значение которого следует возвратить.</param>
		/// <param name="version">Перечисление <see cref="T:System.Data.DataRowVersion" />, которое определяет версию возвращаемого значения столбца, например: версия <see langword="Current" /> или <see langword="Original" />.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип возвращаемого значения для этого столбца.</typeparam>
		/// <returns>Значение типа <paramref name="T" /> столбца <see cref="T:System.Data.DataColumn" />, определенного параметрами <paramref name="ordinal" /> и <paramref name="version" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбца, определенного именем <paramref name="ordinal" />, не существует в таблице <see cref="T:System.Data.DataTable" />, частью которой является строка <see cref="T:System.Data.DataRow" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Значение null было назначено типу, не поддерживающему значения null.</exception>
		// Token: 0x0600001D RID: 29 RVA: 0x000025AD File Offset: 0x000007AD
		public static T Field<T>(this DataRow row, int columnIndex, DataRowVersion version)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			return DataRowExtensions.UnboxT<T>.s_unbox(row[columnIndex, version]);
		}

		/// <summary>Обеспечивает строго типизированный доступ к каждому значению столбца в указанной строке. Метод <see cref="M:System.Data.DataRowExtensions.Field``1(System.Data.DataRow,System.String,System.Data.DataRowVersion)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="columnName">Имя столбца, значение которого следует возвратить.</param>
		/// <param name="version">Перечисление <see cref="T:System.Data.DataRowVersion" />, которое определяет версию возвращаемого значения столбца, например: версия <see langword="Current" /> или <see langword="Original" />.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип возвращаемого значения для этого столбца.</typeparam>
		/// <returns>Значение типа <paramref name="T" /> столбца <see cref="T:System.Data.DataColumn" />, определенного параметрами <paramref name="columnName" /> и <paramref name="version" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбца, определенного именем <paramref name="columnName" />, не существует в таблице <see cref="T:System.Data.DataTable" />, частью которой является строка <see cref="T:System.Data.DataRow" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Значение null было назначено типу, не поддерживающему значения null.</exception>
		// Token: 0x0600001E RID: 30 RVA: 0x000025CC File Offset: 0x000007CC
		public static T Field<T>(this DataRow row, string columnName, DataRowVersion version)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			return DataRowExtensions.UnboxT<T>.s_unbox(row[columnName, version]);
		}

		/// <summary>Обеспечивает строго типизированный доступ к каждому значению столбца в указанной строке. Метод <see cref="M:System.Data.DataRowExtensions.Field``1(System.Data.DataRow,System.Data.DataColumn,System.Data.DataRowVersion)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="column">Объект входа <see cref="T:System.Data.DataColumn" />, в котором указывается столбец, значение которого следует возвратить.</param>
		/// <param name="version">Перечисление <see cref="T:System.Data.DataRowVersion" />, которое определяет версию возвращаемого значения столбца, например: версия <see langword="Current" /> или <see langword="Original" />.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип возвращаемого значения для этого столбца.</typeparam>
		/// <returns>Значение типа <paramref name="T" /> столбца <see cref="T:System.Data.DataColumn" />, определенного параметрами <paramref name="column" /> и <paramref name="version" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбца, определенного именем <paramref name="column" />, не существует в таблице <see cref="T:System.Data.DataTable" />, частью которой является строка <see cref="T:System.Data.DataRow" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Значение null было назначено типу, не поддерживающему значения null.</exception>
		// Token: 0x0600001F RID: 31 RVA: 0x000025EB File Offset: 0x000007EB
		public static T Field<T>(this DataRow row, DataColumn column, DataRowVersion version)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			return DataRowExtensions.UnboxT<T>.s_unbox(row[column, version]);
		}

		/// <summary>Задает новое значение для указанного столбца в вызванном методе <see cref="T:System.Data.DataRow" />. Метод <see cref="M:System.Data.DataRowExtensions.SetField``1(System.Data.DataRow,System.Int32,``0)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="columnIndex">Порядковый номер (начинающийся с нуля) столбца, значение которого следует задать.</param>
		/// <param name="value">Значение новой строки для указанного столбца, имеющее тип <paramref name="T" />.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип значения для этого столбца.</typeparam>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">Происходит при попытке установить значение в удаленной строке.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Аргумент <paramref name="ordinal" /> вне диапазона.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		// Token: 0x06000020 RID: 32 RVA: 0x0000260A File Offset: 0x0000080A
		public static void SetField<T>(this DataRow row, int columnIndex, T value)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			row[columnIndex] = (value ?? DBNull.Value);
		}

		/// <summary>Задает новое значение для указанного столбца в <see cref="T:System.Data.DataRow" />. Метод <see cref="M:System.Data.DataRowExtensions.SetField``1(System.Data.DataRow,System.String,``0)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="columnName">Имя столбца, значение которого следует задать.</param>
		/// <param name="value">Значение новой строки для указанного столбца, имеющее тип <paramref name="T" />.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип значения для этого столбца.</typeparam>
		/// <exception cref="T:System.ArgumentException">Не удается найти столбец, указанный по значению <paramref name="columnName" />.</exception>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">Происходит при попытке установить значение в удаленной строке.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		// Token: 0x06000021 RID: 33 RVA: 0x0000262D File Offset: 0x0000082D
		public static void SetField<T>(this DataRow row, string columnName, T value)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			row[columnName] = (value ?? DBNull.Value);
		}

		/// <summary>Задает новое значение для указанного столбца в <see cref="T:System.Data.DataRow" />. Метод <see cref="M:System.Data.DataRowExtensions.SetField``1(System.Data.DataRow,System.Data.DataColumn,``0)" /> также поддерживает типы, допускающие значения null.</summary>
		/// <param name="row">Входной объект <see cref="T:System.Data.DataRow" />, действующий для метода расширения как экземпляр <see langword="this" />.</param>
		/// <param name="column">Входящий столбец <see cref="T:System.Data.DataColumn" /> определяет, какое значение строки следует извлечь.</param>
		/// <param name="value">Значение новой строки для указанного столбца, имеющее тип <paramref name="T" />.</param>
		/// <typeparam name="T">Общий параметр, в котором указывается тип значения для этого столбца.</typeparam>
		/// <exception cref="T:System.ArgumentException">Не удается найти столбец, указанный по значению <paramref name="column" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значением параметра <paramref name="column" /> является NULL.</exception>
		/// <exception cref="T:System.Data.DeletedRowInaccessibleException">Происходит при попытке установить значение в удаленной строке.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип значений соответствующего столбца не должен быть приведен к типу, заданному параметром универсального типа <paramref name="T" />.</exception>
		// Token: 0x06000022 RID: 34 RVA: 0x00002650 File Offset: 0x00000850
		public static void SetField<T>(this DataRow row, DataColumn column, T value)
		{
			DataSetUtil.CheckArgumentNull<DataRow>(row, "row");
			row[column] = (value ?? DBNull.Value);
		}

		// Token: 0x02000008 RID: 8
		private static class UnboxT<T>
		{
			// Token: 0x06000023 RID: 35 RVA: 0x00002674 File Offset: 0x00000874
			private static Converter<object, T> Create()
			{
				if (default(T) == null)
				{
					return new Converter<object, T>(DataRowExtensions.UnboxT<T>.ReferenceOrNullableField);
				}
				return new Converter<object, T>(DataRowExtensions.UnboxT<T>.ValueField);
			}

			// Token: 0x06000024 RID: 36 RVA: 0x000026AC File Offset: 0x000008AC
			private static T ReferenceOrNullableField(object value)
			{
				if (DBNull.Value != value)
				{
					return (T)((object)value);
				}
				return default(T);
			}

			// Token: 0x06000025 RID: 37 RVA: 0x000026D1 File Offset: 0x000008D1
			private static T ValueField(object value)
			{
				if (DBNull.Value == value)
				{
					throw DataSetUtil.InvalidCast(string.Format("Cannot cast DBNull. Value to type '{0}'. Please use a nullable type.", typeof(T).ToString()));
				}
				return (T)((object)value);
			}

			// Token: 0x04000038 RID: 56
			internal static readonly Converter<object, T> s_unbox = DataRowExtensions.UnboxT<T>.Create();
		}
	}
}
