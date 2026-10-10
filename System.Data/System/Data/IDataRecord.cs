using System;

namespace System.Data
{
	/// <summary>Предоставляет доступ к значениям столбцов в каждой строке для <see langword="DataReader" />. Реализация осуществляют поставщики данных .NET Framework, которые обращаются к реляционным базам данных.</summary>
	// Token: 0x02000102 RID: 258
	public interface IDataRecord
	{
		/// <summary>Возвращает число столбцов в текущей строке.</summary>
		/// <returns>Если отсутствует в допустимом наборе записей 0. В противном случае — число столбцов в текущей записи. Значение по умолчанию — -1.</returns>
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000F2C RID: 3884
		int FieldCount { get; }

		/// <summary>Возвращает столбец, находящийся по указанному индексу.</summary>
		/// <param name="i">Отсчитываемый от нуля индекс возвращаемого столбца.</param>
		/// <returns>Столбец, находящийся по указанному индексу, например <see cref="T:System.Object" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x1700029B RID: 667
		object this[int i]
		{
			get;
		}

		/// <summary>Возвращает столбец с указанным именем.</summary>
		/// <param name="name">Имя столбца, который нужно найти.</param>
		/// <returns>Столбец с указанным именем в качестве <see cref="T:System.Object" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбец с указанным именем не найден.</exception>
		// Token: 0x1700029C RID: 668
		object this[string name]
		{
			get;
		}

		/// <summary>Возвращает имя для поля, которое необходимо найти.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Имя поля или пустая строка (""), если возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F2F RID: 3887
		string GetName(int i);

		/// <summary>Возвращает сведения о типе данных для указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Сведения о типе данных для указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F30 RID: 3888
		string GetDataTypeName(int i);

		/// <summary>Возвращает сведения <see cref="T:System.Type" /> о типе <see cref="T:System.Object" />, который будет возвращен из <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)" />.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Сведения <see cref="T:System.Type" /> о типе <see cref="T:System.Object" />, который будет возвращен из <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F31 RID: 3889
		Type GetFieldType(int i);

		/// <summary>Возвращает значение указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>
		///   <see cref="T:System.Object" /> — будет содержать возвращаемое значение поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F32 RID: 3890
		object GetValue(int i);

		/// <summary>Заполняет массив объектов значениями столбцов текущей записи.</summary>
		/// <param name="values">Массив <see cref="T:System.Object" />, в который нужно копировать поля атрибутов.</param>
		/// <returns>Число экземпляров <see cref="T:System.Object" /> в массиве.</returns>
		// Token: 0x06000F33 RID: 3891
		int GetValues(object[] values);

		/// <summary>Возвращает индекс именованного поля.</summary>
		/// <param name="name">Имя искомого поля.</param>
		/// <returns>Индекс именованного поля.</returns>
		// Token: 0x06000F34 RID: 3892
		int GetOrdinal(string name);

		/// <summary>Возвращает значение указанного столбца в виде логического значения.</summary>
		/// <param name="i">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение столбца.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F35 RID: 3893
		bool GetBoolean(int i);

		/// <summary>Возвращает 8-битное целое число без знака для указанного столбца.</summary>
		/// <param name="i">Порядковый номер столбца (от нуля).</param>
		/// <returns>8-битное целое число без знака для указанного столбца.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F36 RID: 3894
		byte GetByte(int i);

		/// <summary>Считывает поток байтов из указанного смещения столбца в буфер в виде массива, начиная с заданного смещения буфера.</summary>
		/// <param name="i">Порядковый номер столбца (от нуля).</param>
		/// <param name="fieldOffset">Индекс в поле, с которого необходимо начать считывание.</param>
		/// <param name="buffer">Буфер, в который считывается поток байтов.</param>
		/// <param name="bufferoffset">Индекс для <paramref name="buffer" /> для запуска операции чтения.</param>
		/// <param name="length">Количество байтов, чтение которых необходимо выполнить.</param>
		/// <returns>Число фактически считанных байтов.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F37 RID: 3895
		long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length);

		/// <summary>Возвращает значение символа для указанного столбца.</summary>
		/// <param name="i">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение символа указанного столбца.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F38 RID: 3896
		char GetChar(int i);

		/// <summary>Считывает поток символов из указанного смещения столбца в буфер как массив, начиная с заданного смещения буфера.</summary>
		/// <param name="i">Порядковый номер столбца (от нуля).</param>
		/// <param name="fieldoffset">Индекс в строке, с которого начинается операция считывания.</param>
		/// <param name="buffer">Буфер, в который считывается поток байтов.</param>
		/// <param name="bufferoffset">Индекс для <paramref name="buffer" /> для запуска операции чтения.</param>
		/// <param name="length">Количество байтов, чтение которых необходимо выполнить.</param>
		/// <returns>Число фактически считанных символов.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F39 RID: 3897
		long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length);

		/// <summary>Возвращает значение GUID указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Значение GUID указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F3A RID: 3898
		Guid GetGuid(int i);

		/// <summary>Возвращает 16-битное целое число со знаком для указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>16-битное целое число со знаком для указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F3B RID: 3899
		short GetInt16(int i);

		/// <summary>Возвращает 32-битное целое число со знаком для указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>32-битное целое число со знаком для указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F3C RID: 3900
		int GetInt32(int i);

		/// <summary>Возвращает 64-битное целое число со знаком для указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>64-битное целое число со знаком для указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F3D RID: 3901
		long GetInt64(int i);

		/// <summary>Возвращает число с плавающей запятой одиночной точности для указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Число с плавающей запятой одиночной точности для указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F3E RID: 3902
		float GetFloat(int i);

		/// <summary>Возвращает число с плавающей запятой двойной точности для указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Число с плавающей запятой двойной точности для указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F3F RID: 3903
		double GetDouble(int i);

		/// <summary>Получает значение строки заданного ключа.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Значение строки заданного ключа.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F40 RID: 3904
		string GetString(int i);

		/// <summary>Возвращает числовое значение с фиксированным расположением для указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Числовое значение с фиксированным расположением для указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F41 RID: 3905
		decimal GetDecimal(int i);

		/// <summary>Возвращает значение даты и времени для указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Значение даты и времени данных для указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F42 RID: 3906
		DateTime GetDateTime(int i);

		/// <summary>Возвращает <see cref="T:System.Data.IDataReader" /> для указанного порядкового номера столбца.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>
		///   <see cref="T:System.Data.IDataReader" /> для указанного порядкового номера столбца.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F43 RID: 3907
		IDataReader GetData(int i);

		/// <summary>Возвращает логическое значение, показывающее, имеет ли указанное поле значение null.</summary>
		/// <param name="i">Индекс поля, которое необходимо найти.</param>
		/// <returns>Значение <see langword="true" />, если для указанного поля задано значение null. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06000F44 RID: 3908
		bool IsDBNull(int i);
	}
}
