using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Предоставляет способ чтения потока строк данных из источника только в прямом порядке. Этот класс не наследуется.</summary>
	// Token: 0x02000162 RID: 354
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbDataReader : DbDataReader
	{
		// Token: 0x0600132B RID: 4907 RVA: 0x0005AD85 File Offset: 0x00058F85
		internal OleDbDataReader()
		{
		}

		/// <summary>Возвращает значение, указывающее глубину вложенности для текущей строки.</summary>
		/// <returns>Глубина вложенности для текущей строки.</returns>
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int Depth
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает число столбцов в текущей строке.</summary>
		/// <returns>Значение 0, если столбец отсутствует в допустимом наборе записей; в противном случае — количество столбцов в текущей записи. Значение по умолчанию — -1.</returns>
		/// <exception cref="T:System.NotSupportedException">Текущее подключение к источнику данных отсутствует.</exception>
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int FieldCount
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает значение, указывающее, содержит ли объект <see cref="T:System.Data.OleDb.OleDbDataReader" /> одну или несколько строк.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Data.OleDb.OleDbDataReader" /> содержит одну или несколько строк; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool HasRows
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Указывает, закрыто ли устройство считывания данных.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.OleDb.OleDbDataReader" /> закрыт; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool IsClosed
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает число строк, которые были изменены, вставлены или удалены инструкцией SQL.</summary>
		/// <returns>Число измененных, вставленных или удаленных строк. Значение 0, если строки не были затронуты или инструкция завершилась ошибкой. Значение -1 для инструкций SELECT.</returns>
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int RecordsAffected
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает число не скрытых полей в <see cref="T:System.Data.OleDb.OleDbDataReader" />.</summary>
		/// <returns>Число не скрытых полей.</returns>
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int VisibleFieldCount
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Закрывает объект <see cref="T:System.Data.OleDb.OleDbDataReader" />.</summary>
		// Token: 0x06001332 RID: 4914 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Close()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде логического значения.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001333 RID: 4915 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool GetBoolean(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде байта.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение заданного столбца в виде байта.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001334 RID: 4916 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override byte GetByte(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Считывает поток байтов из заданного смещения столбца в буфер в виде массива, начиная с заданного смещения буфера.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <param name="dataIndex">Индекс в поле, с которого необходимо начать считывание.</param>
		/// <param name="buffer">Буфер, в который считывается поток байтов.</param>
		/// <param name="bufferIndex">Индекс в <paramref name="buffer" />, с которого должна начинаться операция записи.</param>
		/// <param name="length">Максимальная длина для копирования в буфер.</param>
		/// <returns>Число фактически считанных байтов.</returns>
		// Token: 0x06001335 RID: 4917 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override long GetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде символа.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001336 RID: 4918 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override char GetChar(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Считывает поток символов из заданного смещения столбца в буфер в виде массива, начиная с заданного смещения буфера.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <param name="dataIndex">Индекс в строке, с которого начинается операция считывания.</param>
		/// <param name="buffer">Буфер, в который копируются данные.</param>
		/// <param name="bufferIndex">Индекс в <paramref name="buffer" />, с которого должна начинаться операция записи.</param>
		/// <param name="length">Число символов для чтения.</param>
		/// <returns>Число фактически считанных символов.</returns>
		// Token: 0x06001337 RID: 4919 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override long GetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.OleDb.OleDbDataReader" /> для запрошенного порядкового номера столбца.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbDataReader" />.</returns>
		// Token: 0x06001338 RID: 4920 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbDataReader GetData(int ordinal)
		{
			throw ADP.OleDb();
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbDataReader GetDbDataReader(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Получает имя исходного типа данных.</summary>
		/// <param name="index">Порядковый номер столбца (от нуля).</param>
		/// <returns>Имя типа внутренних данных. Дополнительные сведения см. в разделах Типы данных SQL Server или Типы данных Access.</returns>
		// Token: 0x0600133A RID: 4922 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string GetDataTypeName(int index)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x0600133B RID: 4923 RVA: 0x0005AD90 File Offset: 0x00058F90
		public override DateTime GetDateTime(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде объекта <see cref="T:System.Decimal" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x0600133C RID: 4924 RVA: 0x0005ADA4 File Offset: 0x00058FA4
		public override decimal GetDecimal(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Получает значение заданного столбца в виде числа двойной точности с плавающей запятой.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x0600133D RID: 4925 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override double GetDouble(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IEnumerator" />, который может использоваться для просмотра строк в модуле чтения данных.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IEnumerator" />, который может использоваться для просмотра строк в модуле чтения данных.</returns>
		// Token: 0x0600133E RID: 4926 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override IEnumerator GetEnumerator()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает тип <see cref="T:System.Type" />, который является типом данных объекта.</summary>
		/// <param name="index">Порядковый номер столбца (от нуля).</param>
		/// <returns>Тип данных объекта (<see cref="T:System.Type" />).</returns>
		// Token: 0x0600133F RID: 4927 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override Type GetFieldType(int index)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде числа с плавающей запятой с одиночной точностью.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001340 RID: 4928 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override float GetFloat(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение заданного столбца в виде глобального уникального идентификатора (GUID).</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001341 RID: 4929 RVA: 0x0005ADB8 File Offset: 0x00058FB8
		public override Guid GetGuid(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Получает значение заданного столбца в виде 16-битового целого числа со знаком.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001342 RID: 4930 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override short GetInt16(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде 32-разрядного целого числа со знаком.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001343 RID: 4931 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int GetInt32(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде 64-разрядного целого числа со знаком.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001344 RID: 4932 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override long GetInt64(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает имя заданного столбца.</summary>
		/// <param name="index">Порядковый номер столбца (от нуля).</param>
		/// <returns>Имя заданного столбца.</returns>
		// Token: 0x06001345 RID: 4933 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string GetName(int index)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает порядковый номер столбца при наличии заданного имени столбца.</summary>
		/// <param name="name">Имя столбца.</param>
		/// <returns>Порядковый номер столбца (от нуля).</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Заданное имя недопустимо для имени столбца.</exception>
		// Token: 0x06001346 RID: 4934 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int GetOrdinal(string name)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.DataTable" />, описывающий метаданные столбцов модуля чтения данных <see cref="T:System.Data.OleDb.OleDbDataReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, описывающий метаданные столбцов.</returns>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.OleDb.OleDbDataReader" /> закрыт.</exception>
		// Token: 0x06001347 RID: 4935 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override DataTable GetSchemaTable()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение заданного столбца в виде строки.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001348 RID: 4936 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string GetString(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в виде объекта <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06001349 RID: 4937 RVA: 0x0005ADCC File Offset: 0x00058FCC
		public TimeSpan GetTimeSpan(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Получает значение столбца с указанным порядковом номером в собственном формате.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Возвращаемое значение.</returns>
		// Token: 0x0600134A RID: 4938 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override object GetValue(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Заполняет массив объектов значениями столбцов текущей строки.</summary>
		/// <param name="values">Массив объектов <see cref="T:System.Object" />, в который необходимо скопировать столбцы атрибутов.</param>
		/// <returns>Число экземпляров <see cref="T:System.Object" /> в массиве.</returns>
		// Token: 0x0600134B RID: 4939 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int GetValues(object[] values)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение, указывающее, содержатся ли в столбце несуществующие или отсутствующие значения.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение <see langword="true" />, если значение указанного столбца эквивалентно <see cref="T:System.DBNull" />; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600134C RID: 4940 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool IsDBNull(int ordinal)
		{
			throw ADP.OleDb();
		}

		/// <summary>Перемещает модуль чтения данных к следующему результату при чтении результатов из пакета инструкций SQL.</summary>
		/// <returns>Значение <see langword="true" />, если имеются и другие наборы результатов, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600134D RID: 4941 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool NextResult()
		{
			throw ADP.OleDb();
		}

		/// <summary>Перемещает <see cref="T:System.Data.OleDb.OleDbDataReader" /> к следующей записи.</summary>
		/// <returns>Значение <see langword="true" />, если имеются другие строки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600134E RID: 4942 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool Read()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает значение указанного столбца в собственном формате при наличии заданного порядкового номера столбца.</summary>
		/// <param name="index">Порядковый номер столбца.</param>
		/// <returns>Значение заданного столбца в собственном формате.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x17000331 RID: 817
		public override object this[int index]
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Возвращает значение заданного столбца в собственном формате при наличии заданного имени столбца.</summary>
		/// <param name="name">Имя столбца.</param>
		/// <returns>Значение заданного столбца в собственном формате.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбец с указанным именем не найден.</exception>
		// Token: 0x17000332 RID: 818
		public override object this[string name]
		{
			get
			{
				throw ADP.OleDb();
			}
		}
	}
}
