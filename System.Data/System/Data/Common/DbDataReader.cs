using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Common
{
	/// <summary>Считывает однопроходные потоки строк из источника данных.</summary>
	// Token: 0x02000392 RID: 914
	public abstract class DbDataReader : MarshalByRefObject, IDataReader, IDisposable, IDataRecord, IEnumerable, IAsyncDisposable
	{
		/// <summary>Возвращает значение, показывающее глубину вложенности для текущей строки.</summary>
		/// <returns>Глубина вложенности для текущей строки.</returns>
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002C40 RID: 11328
		public abstract int Depth { get; }

		/// <summary>Возвращает число столбцов в текущей строке.</summary>
		/// <returns>Число столбцов в текущей строке.</returns>
		/// <exception cref="T:System.NotSupportedException">Текущее подключение к экземпляру SQL Server отсутствует.</exception>
		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002C41 RID: 11329
		public abstract int FieldCount { get; }

		/// <summary>Возвращает значение, указывающее на то, что в модуле чтения данных <see cref="T:System.Data.Common.DbDataReader" /> содержится одна или несколько строк.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Data.Common.DbDataReader" /> содержит одну или несколько строк; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002C42 RID: 11330
		public abstract bool HasRows { get; }

		/// <summary>Возвращает значение, указывающее, закрыт ли модуль чтения <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Data.Common.DbDataReader" /> закрыт; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.SqlClient.SqlDataReader" /> закрыт.</exception>
		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002C43 RID: 11331
		public abstract bool IsClosed { get; }

		/// <summary>Возвращает число строк, которые были изменены, вставлены или удалены инструкцией SQL.</summary>
		/// <returns>Число измененных, вставленных или удаленных строк. Значение -1 для операторов SELECT; значение 0, если строки не изменены или при сбое инструкции.</returns>
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002C44 RID: 11332
		public abstract int RecordsAffected { get; }

		/// <summary>Возвращает число не скрытых полей в <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		/// <returns>Число не скрытых полей.</returns>
		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x000BE7B0 File Offset: 0x000BC9B0
		public virtual int VisibleFieldCount
		{
			get
			{
				return this.FieldCount;
			}
		}

		/// <summary>Возвращает значение указанного столбца как экземпляр <see cref="T:System.Object" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x1700078D RID: 1933
		public abstract object this[int ordinal]
		{
			get;
		}

		/// <summary>Возвращает значение указанного столбца как экземпляр <see cref="T:System.Object" />.</summary>
		/// <param name="name">Имя столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Столбец с указанным именем не найден.</exception>
		// Token: 0x1700078E RID: 1934
		public abstract object this[string name]
		{
			get;
		}

		/// <summary>Закрывает объект <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		// Token: 0x06002C48 RID: 11336 RVA: 0x00007EED File Offset: 0x000060ED
		public virtual void Close()
		{
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		// Token: 0x06002C49 RID: 11337 RVA: 0x000BE7B8 File Offset: 0x000BC9B8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает управляемые ресурсы, используемые объектом <see cref="T:System.Data.Common.DbDataReader" /> (при необходимости освобождает и неуправляемые ресурсы).</summary>
		/// <param name="disposing">Значение <see langword="true" />, чтобы освободить все ресурсы (управляемые и неуправляемые); значение <see langword="false" />, чтобы освободить только неуправляемые ресурсы.</param>
		// Token: 0x06002C4A RID: 11338 RVA: 0x000BE7C1 File Offset: 0x000BC9C1
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close();
			}
		}

		/// <summary>Возвращает имя типа данных заданного столбца.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Строка, представляющая имя типа данных.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C4B RID: 11339
		public abstract string GetDataTypeName(int ordinal);

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IEnumerator" />, который может использоваться для просмотра строк в модуле чтения данных.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IEnumerator" />, который может использоваться для просмотра строк в модуле чтения данных.</returns>
		// Token: 0x06002C4C RID: 11340
		[EditorBrowsable(EditorBrowsableState.Never)]
		public abstract IEnumerator GetEnumerator();

		/// <summary>Возвращает тип данных заданного столбца.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Тип данных заданного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C4D RID: 11341
		public abstract Type GetFieldType(int ordinal);

		/// <summary>Возвращает имя столбца, если известен его порядковый номер (от нуля).</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Имя заданного столбца.</returns>
		// Token: 0x06002C4E RID: 11342
		public abstract string GetName(int ordinal);

		/// <summary>Возвращает порядковый номер столбца, если известно его имя.</summary>
		/// <param name="name">Имя столбца.</param>
		/// <returns>Порядковый номер столбца (от нуля).</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Заданное имя недопустимо для имени столбца.</exception>
		// Token: 0x06002C4F RID: 11343
		public abstract int GetOrdinal(string name);

		/// <summary>Возвращает объект <see cref="T:System.Data.DataTable" />, описывающий метаданные столбцов модуля чтения данных <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, описывающий метаданные столбцов.</returns>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.SqlClient.SqlDataReader" /> закрыт.</exception>
		// Token: 0x06002C50 RID: 11344 RVA: 0x00087F51 File Offset: 0x00086151
		public virtual DataTable GetSchemaTable()
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает значение указанного столбца в виде логического значения.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C51 RID: 11345
		public abstract bool GetBoolean(int ordinal);

		/// <summary>Возвращает значение указанного столбца в виде байта.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C52 RID: 11346
		public abstract byte GetByte(int ordinal);

		/// <summary>Считывает поток байтов из указанного столбца, начиная с местоположения, указанного параметром <paramref name="dataOffset" />, в буфер, начиная с местоположения, указанного параметром <paramref name="bufferOffset" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <param name="dataOffset">Индекс в строке, с которого необходимо начать считывание.</param>
		/// <param name="buffer">Буфер, в который копируются данные.</param>
		/// <param name="bufferOffset">Индекс в буфере, куда будут копироваться данные.</param>
		/// <param name="length">Максимальное число считываемых символов.</param>
		/// <returns>Число фактически считанных байтов.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C53 RID: 11347
		public abstract long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length);

		/// <summary>Возвращает значение указанного столбца в виде одного символа.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C54 RID: 11348
		public abstract char GetChar(int ordinal);

		/// <summary>Считывает поток символов из указанного столбца, начиная с местоположения, указанного параметром <paramref name="dataOffset" />, в буфер, начиная с местоположения, указанного параметром <paramref name="bufferOffset" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <param name="dataOffset">Индекс в строке, с которого необходимо начать считывание.</param>
		/// <param name="buffer">Буфер, в который копируются данные.</param>
		/// <param name="bufferOffset">Индекс в буфере, куда будут копироваться данные.</param>
		/// <param name="length">Максимальное число считываемых символов.</param>
		/// <returns>Число фактически считанных символов.</returns>
		// Token: 0x06002C55 RID: 11349
		public abstract long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length);

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DbDataReader" /> для запрошенного порядкового номера столбца.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DbDataReader" />.</returns>
		// Token: 0x06002C56 RID: 11350 RVA: 0x000BE7CC File Offset: 0x000BC9CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DbDataReader GetData(int ordinal)
		{
			return this.GetDbDataReader(ordinal);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Data.IDataRecord.GetData(System.Int32)" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Экземпляр <see cref="T:System.Data.IDataReader" />, используемый, когда поле указывает на дополнительные удаленные структурированные данные.</returns>
		// Token: 0x06002C57 RID: 11351 RVA: 0x000BE7CC File Offset: 0x000BC9CC
		IDataReader IDataRecord.GetData(int ordinal)
		{
			return this.GetDbDataReader(ordinal);
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DbDataReader" /> для запрошенного порядкового номера столбца, который можно переопределить реализацией, зависящей от поставщика.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DbDataReader" />.</returns>
		// Token: 0x06002C58 RID: 11352 RVA: 0x00008E4B File Offset: 0x0000704B
		protected virtual DbDataReader GetDbDataReader(int ordinal)
		{
			throw ADP.NotSupported();
		}

		/// <summary>Возвращает значение указанного столбца в виде объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C59 RID: 11353
		public abstract DateTime GetDateTime(int ordinal);

		/// <summary>Возвращает значение указанного столбца в виде объекта <see cref="T:System.Decimal" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C5A RID: 11354
		public abstract decimal GetDecimal(int ordinal);

		/// <summary>Возвращает значение заданного столбца в виде числа с плавающей запятой двойной точности.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C5B RID: 11355
		public abstract double GetDouble(int ordinal);

		/// <summary>Возвращает значение заданного столбца в виде числа с плавающей запятой одинарной точности.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C5C RID: 11356
		public abstract float GetFloat(int ordinal);

		/// <summary>Возвращает значение заданного столбца в виде глобально-уникального идентификатора GUID.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C5D RID: 11357
		public abstract Guid GetGuid(int ordinal);

		/// <summary>Получает значение заданного столбца в виде 16-битового целого числа со знаком.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C5E RID: 11358
		public abstract short GetInt16(int ordinal);

		/// <summary>Возвращает значение указанного столбца в виде 32-разрядного целого числа со знаком.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C5F RID: 11359
		public abstract int GetInt32(int ordinal);

		/// <summary>Возвращает значение указанного столбца в виде 64-разрядного целого числа со знаком.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C60 RID: 11360
		public abstract long GetInt64(int ordinal);

		/// <summary>Возвращает тип поля заданного столбца, зависящий от поставщика.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Объект <see cref="T:System.Type" />, описывающий тип данных указанного столбца.</returns>
		// Token: 0x06002C61 RID: 11361 RVA: 0x000BE7D5 File Offset: 0x000BC9D5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual Type GetProviderSpecificFieldType(int ordinal)
		{
			return this.GetFieldType(ordinal);
		}

		/// <summary>Возвращает значение указанного столбца как экземпляр <see cref="T:System.Object" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C62 RID: 11362 RVA: 0x0006AE3E File Offset: 0x0006903E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual object GetProviderSpecificValue(int ordinal)
		{
			return this.GetValue(ordinal);
		}

		/// <summary>Возвращает из коллекции все столбцы атрибутов, зависящие от поставщика, для текущей строки.</summary>
		/// <param name="values">Массив объектов <see cref="T:System.Object" />, в который необходимо скопировать столбцы атрибутов.</param>
		/// <returns>Число экземпляров <see cref="T:System.Object" /> в массиве.</returns>
		// Token: 0x06002C63 RID: 11363 RVA: 0x000BE7DE File Offset: 0x000BC9DE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual int GetProviderSpecificValues(object[] values)
		{
			return this.GetValues(values);
		}

		/// <summary>Возвращает значение указанного столбца как экземпляр <see cref="T:System.String" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		/// <exception cref="T:System.InvalidCastException">Указанное приведение недопустимо.</exception>
		// Token: 0x06002C64 RID: 11364
		public abstract string GetString(int ordinal);

		/// <summary>Извлекает данные в виде <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="ordinal">Извлекает данные в виде <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Возвращаемый объект.</returns>
		/// <exception cref="T:System.InvalidOperationException">Соединение разъединяется или закрывается во время извлечения данных.  
		/// -или-
		/// Объект <see cref="T:System.Data.Common.DbDataReader" /> закрыт во время извлечения данных.  
		/// -или-
		/// Не существует данных, готовых для чтения (например, первый объект <see cref="M:System.Data.Common.DbDataReader.Read" /> не был вызван или вернул значение false).  
		/// -или-
		/// Сделана попытка чтения ранее считанного столбца в последовательном режиме.  
		/// -или-
		/// Выполнялась асинхронная операция. Относится ко всем методам Get* при работе в последовательном режиме, так как они могут вызываться при чтении потока.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Попытка чтения столбца, который не существует.</exception>
		/// <exception cref="T:System.InvalidCastException">Возвращаемый тип не был одним из указанных типов: binary, image, varbinary или udt.</exception>
		// Token: 0x06002C65 RID: 11365 RVA: 0x000BE7E8 File Offset: 0x000BC9E8
		public virtual Stream GetStream(int ordinal)
		{
			Stream result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				long num = 0L;
				byte[] array = new byte[4096];
				long bytes;
				do
				{
					bytes = this.GetBytes(ordinal, num, array, 0, array.Length);
					memoryStream.Write(array, 0, (int)bytes);
					num += bytes;
				}
				while (bytes > 0L);
				result = new MemoryStream(memoryStream.ToArray(), false);
			}
			return result;
		}

		/// <summary>Извлекает данные в виде <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="ordinal">Извлекает данные в виде <see cref="T:System.IO.TextReader" />.</param>
		/// <returns>Возвращаемый объект.</returns>
		/// <exception cref="T:System.InvalidOperationException">Соединение разъединяется или закрывается во время извлечения данных.  
		/// -или-
		/// Объект <see cref="T:System.Data.Common.DbDataReader" /> закрыт во время извлечения данных.  
		/// -или-
		/// Не существует данных, готовых для чтения (например, первый объект <see cref="M:System.Data.Common.DbDataReader.Read" /> не был вызван или вернул значение false).  
		/// -или-
		/// Сделана попытка чтения ранее считанного столбца в последовательном режиме.  
		/// -или-
		/// Выполнялась асинхронная операция. Относится ко всем методам Get* при работе в последовательном режиме, так как они могут вызываться при чтении потока.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Попытка чтения столбца, который не существует.</exception>
		/// <exception cref="T:System.InvalidCastException">Возвращаемый тип не был одним из указанных типов: char, nchar, ntext, nvarchar, text или varchar.</exception>
		// Token: 0x06002C66 RID: 11366 RVA: 0x000BE85C File Offset: 0x000BCA5C
		public virtual TextReader GetTextReader(int ordinal)
		{
			if (this.IsDBNull(ordinal))
			{
				return new StringReader(string.Empty);
			}
			return new StringReader(this.GetString(ordinal));
		}

		/// <summary>Возвращает значение указанного столбца как экземпляр <see cref="T:System.Object" />.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C67 RID: 11367
		public abstract object GetValue(int ordinal);

		/// <summary>Синхронно получает значение заданного столбца в виде типа.</summary>
		/// <param name="ordinal">Получаемый столбец.</param>
		/// <typeparam name="T">Синхронно получает значение заданного столбца в виде типа.</typeparam>
		/// <returns>Получаемый столбец.</returns>
		/// <exception cref="T:System.InvalidOperationException">Соединение разъединяется или закрывается во время извлечения данных.  
		/// -или- 
		/// Объект <see cref="T:System.Data.SqlClient.SqlDataReader" /> закрыт во время извлечения данных.  
		/// -или-
		/// Не существует данных, готовых для чтения (например, первый объект <see cref="M:System.Data.SqlClient.SqlDataReader.Read" /> не был вызван или вернул значение false).  
		/// -или-
		/// Сделана попытка чтения ранее считанного столбца в последовательном режиме.  
		/// -или-
		/// Выполнялась асинхронная операция. Относится ко всем методам Get* при работе в последовательном режиме, так как они могут вызываться при чтении потока.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Попытка чтения столбца, который не существует.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="T" /> не соответствует типу, возвращаемому SQL Server, или не может быть приведено.</exception>
		// Token: 0x06002C68 RID: 11368 RVA: 0x000BE87E File Offset: 0x000BCA7E
		public virtual T GetFieldValue<T>(int ordinal)
		{
			return (T)((object)this.GetValue(ordinal));
		}

		/// <summary>Асинхронно получает значение заданного столбца в виде типа.</summary>
		/// <param name="ordinal">Тип возвращаемого значения.</param>
		/// <typeparam name="T">Тип возвращаемого значения.</typeparam>
		/// <returns>Тип возвращаемого значения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Соединение разъединяется или закрывается во время извлечения данных.  
		/// -или-
		/// Объект <see cref="T:System.Data.Common.DbDataReader" /> закрыт во время извлечения данных.  
		/// -или-
		/// Не существует данных, готовых для чтения (например, первый объект <see cref="M:System.Data.Common.DbDataReader.Read" /> не был вызван или вернул значение false).  
		/// -или-
		/// Сделана попытка чтения ранее считанного столбца в последовательном режиме.  
		/// -или-
		/// Выполнялась асинхронная операция. Относится ко всем методам Get* при работе в последовательном режиме, так как они могут вызываться при чтении потока.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Попытка чтения столбца, который не существует.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="T" /> не соответствует типу, возвращаемому источником данных, или не может быть приведено.</exception>
		// Token: 0x06002C69 RID: 11369 RVA: 0x000BE88C File Offset: 0x000BCA8C
		public Task<T> GetFieldValueAsync<T>(int ordinal)
		{
			return this.GetFieldValueAsync<T>(ordinal, CancellationToken.None);
		}

		/// <summary>Асинхронно получает значение заданного столбца в виде типа.</summary>
		/// <param name="ordinal">Тип возвращаемого значения.</param>
		/// <param name="cancellationToken">Инструкция отмены, распространяющая уведомление о том, что операции должны быть отменены. Не гарантирует отмену. Параметр <see langword="CancellationToken.None" /> делает этот метод равным методу <see cref="M:System.Data.Common.DbDataReader.GetFieldValueAsync``1(System.Int32)" />. Возвращаемая задача должна быть помечена как отмененная.</param>
		/// <typeparam name="T">Тип возвращаемого значения.</typeparam>
		/// <returns>Тип возвращаемого значения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Соединение разъединяется или закрывается во время извлечения данных.  
		/// -или-
		/// Объект <see cref="T:System.Data.Common.DbDataReader" /> закрыт во время извлечения данных.  
		/// -или-
		/// Не существует данных, готовых для чтения (например, первый объект <see cref="M:System.Data.Common.DbDataReader.Read" /> не был вызван или вернул значение false).  
		/// -или-
		/// Сделана попытка чтения ранее считанного столбца в последовательном режиме.  
		/// -или-
		/// Выполнялась асинхронная операция. Относится ко всем методам Get* при работе в последовательном режиме, так как они могут вызываться при чтении потока.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Попытка чтения столбца, который не существует.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="T" /> не соответствует типу, возвращаемому источником данных, или не может быть приведено.</exception>
		// Token: 0x06002C6A RID: 11370 RVA: 0x000BE89C File Offset: 0x000BCA9C
		public virtual Task<T> GetFieldValueAsync<T>(int ordinal, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ADP.CreatedTaskWithCancellation<T>();
			}
			Task<T> result;
			try
			{
				result = Task.FromResult<T>(this.GetFieldValue<T>(ordinal));
			}
			catch (Exception exception)
			{
				result = Task.FromException<T>(exception);
			}
			return result;
		}

		/// <summary>Заполняет массив объектов значениями столбцов текущей строки.</summary>
		/// <param name="values">Массив объектов <see cref="T:System.Object" />, в который необходимо скопировать столбцы атрибутов.</param>
		/// <returns>Число экземпляров <see cref="T:System.Object" /> в массиве.</returns>
		// Token: 0x06002C6B RID: 11371
		public abstract int GetValues(object[] values);

		/// <summary>Возвращает значение, указывающее, содержатся ли в столбце несуществующие или отсутствующие значения.</summary>
		/// <param name="ordinal">Порядковый номер столбца (от нуля).</param>
		/// <returns>
		///   <see langword="true" />, если указанный столбец эквивалентен <see cref="T:System.DBNull" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06002C6C RID: 11372
		public abstract bool IsDBNull(int ordinal);

		/// <summary>Асинхронная версия метода <see cref="M:System.Data.Common.DbDataReader.IsDBNull(System.Int32)" />, который получает значение, указывающее, содержит ли столбец несуществующие или отсутствующие значения.</summary>
		/// <param name="ordinal">Извлекаемый столбец (отсчитываемый с нуля).</param>
		/// <returns>Значение <see langword="true" />, если значение указанного столбца эквивалентно <see langword="DBNull" />; в обратном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Соединение разъединяется или закрывается во время извлечения данных.  
		/// -или-
		/// Объект <see cref="T:System.Data.Common.DbDataReader" /> закрыт во время извлечения данных.  
		/// -или-
		/// Не существует данных, готовых для чтения (например, первый объект <see cref="M:System.Data.Common.DbDataReader.Read" /> не был вызван или вернул значение false).  
		/// -или-
		/// Попытка чтения ранее считанного столбца в последовательном режиме.  
		/// -или-
		/// Выполнялась асинхронная операция. Относится ко всем методам Get* при работе в последовательном режиме, так как они могут вызываться при чтении потока.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Попытка чтения столбца, который не существует.</exception>
		// Token: 0x06002C6D RID: 11373 RVA: 0x000BE8E4 File Offset: 0x000BCAE4
		public Task<bool> IsDBNullAsync(int ordinal)
		{
			return this.IsDBNullAsync(ordinal, CancellationToken.None);
		}

		/// <summary>Асинхронная версия метода <see cref="M:System.Data.Common.DbDataReader.IsDBNull(System.Int32)" />, который получает значение, указывающее, содержит ли столбец несуществующие или отсутствующие значения. При необходимости отправляет уведомление о том, что операции следует отменить.</summary>
		/// <param name="ordinal">Извлекаемый столбец (отсчитываемый с нуля).</param>
		/// <param name="cancellationToken">Инструкция отмены, распространяющая уведомление о том, что операции должны быть отменены. Не гарантирует отмену. Параметр <see langword="CancellationToken.None" /> делает этот метод равным методу <see cref="M:System.Data.Common.DbDataReader.IsDBNullAsync(System.Int32)" />. Возвращаемая задача должна быть помечена как отмененная.</param>
		/// <returns>Значение <see langword="true" />, если значение указанного столбца эквивалентно <see langword="DBNull" />; в обратном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Соединение разъединяется или закрывается во время извлечения данных.  
		/// -или-
		/// Объект <see cref="T:System.Data.Common.DbDataReader" /> закрыт во время извлечения данных.  
		/// -или-
		/// Не существует данных, готовых для чтения (например, первый объект <see cref="M:System.Data.Common.DbDataReader.Read" /> не был вызван или вернул значение false).  
		/// -или-
		/// Попытка чтения ранее считанного столбца в последовательном режиме.  
		/// -или- 
		/// Выполнялась асинхронная операция. Относится ко всем методам Get* при работе в последовательном режиме, так как они могут вызываться при чтении потока.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Попытка чтения столбца, который не существует.</exception>
		// Token: 0x06002C6E RID: 11374 RVA: 0x000BE8F4 File Offset: 0x000BCAF4
		public virtual Task<bool> IsDBNullAsync(int ordinal, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ADP.CreatedTaskWithCancellation<bool>();
			}
			Task<bool> result;
			try
			{
				result = (this.IsDBNull(ordinal) ? ADP.TrueTask : ADP.FalseTask);
			}
			catch (Exception exception)
			{
				result = Task.FromException<bool>(exception);
			}
			return result;
		}

		/// <summary>Перемещает модуль чтения данных к следующему результату при чтении результатов из пакета инструкций.</summary>
		/// <returns>Значение <see langword="true" />, если имеются и другие наборы результатов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002C6F RID: 11375
		public abstract bool NextResult();

		/// <summary>Перемещает модуль чтения к следующей записи в результирующем наборе.</summary>
		/// <returns>Значение <see langword="true" />, если имеются другие строки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002C70 RID: 11376
		public abstract bool Read();

		/// <summary>Асинхронная версия <see cref="M:System.Data.Common.DbDataReader.Read" />, которая перемещает модуль чтения к следующей записи в наборе результатов. Этот метод вызывает метод <see cref="M:System.Data.Common.DbDataReader.ReadAsync(System.Threading.CancellationToken)" /> с CancellationToken.None.</summary>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		// Token: 0x06002C71 RID: 11377 RVA: 0x000BE944 File Offset: 0x000BCB44
		public Task<bool> ReadAsync()
		{
			return this.ReadAsync(CancellationToken.None);
		}

		/// <summary>Это асинхронная версия метода <see cref="M:System.Data.Common.DbDataReader.Read" />.  Поставщики должны выполнить переопределение с помощью соответствующей реализации. При необходимости можно игнорировать cancellationToken.  
		/// Реализация по умолчанию вызывает синхронный метод <see cref="M:System.Data.Common.DbDataReader.Read" /> и возвращает завершенную задачу, блокируя вызывающий поток. Реализация по умолчанию возвращает отмененную задачу, если ей передается уже отмененный cancellationToken.  Исключения, создаваемые Read, будут связаны через возвращаемое свойство исключения задачи.  
		/// Не вызывайте другие методы и свойства объекта <see langword="DbDataReader" /> до тех пор, пока возвращаемая задача не будет завершена.</summary>
		/// <param name="cancellationToken">Инструкция отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		// Token: 0x06002C72 RID: 11378 RVA: 0x000BE954 File Offset: 0x000BCB54
		public virtual Task<bool> ReadAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ADP.CreatedTaskWithCancellation<bool>();
			}
			Task<bool> result;
			try
			{
				result = (this.Read() ? ADP.TrueTask : ADP.FalseTask);
			}
			catch (Exception exception)
			{
				result = Task.FromException<bool>(exception);
			}
			return result;
		}

		/// <summary>Асинхронная версия метода <see cref="M:System.Data.Common.DbDataReader.NextResult" />, который перемещает средство чтения к следующему результату при чтении результатов из пакета инструкций.  
		/// Вызывает <see cref="M:System.Data.Common.DbDataReader.NextResultAsync(System.Threading.CancellationToken)" /> с CancellationToken.None.</summary>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		// Token: 0x06002C73 RID: 11379 RVA: 0x000BE9A4 File Offset: 0x000BCBA4
		public Task<bool> NextResultAsync()
		{
			return this.NextResultAsync(CancellationToken.None);
		}

		/// <summary>Это асинхронная версия метода <see cref="M:System.Data.Common.DbDataReader.NextResult" />. Поставщики должны выполнить переопределение с помощью соответствующей реализации. При необходимости можно игнорировать <paramref name="cancellationToken" />.  
		/// Реализация по умолчанию вызывает синхронный метод <see cref="M:System.Data.Common.DbDataReader.NextResult" /> и возвращает завершенную задачу, блокируя вызывающий поток. Реализация по умолчанию возвращает отмененную задачу, если ей передается уже отмененный <paramref name="cancellationToken" />. Исключения, создаваемые <see cref="M:System.Data.Common.DbDataReader.NextResult" />, будут связаны через возвращаемое свойство исключения задачи.  
		/// Другие методы и свойства объекта DbDataReader не должны вызываться, когда возвращаемая задача еще не завершена.</summary>
		/// <param name="cancellationToken">Инструкция отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		// Token: 0x06002C74 RID: 11380 RVA: 0x000BE9B4 File Offset: 0x000BCBB4
		public virtual Task<bool> NextResultAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ADP.CreatedTaskWithCancellation<bool>();
			}
			Task<bool> result;
			try
			{
				result = (this.NextResult() ? ADP.TrueTask : ADP.FalseTask);
			}
			catch (Exception exception)
			{
				result = Task.FromException<bool>(exception);
			}
			return result;
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000BEA04 File Offset: 0x000BCC04
		public virtual Task CloseAsync()
		{
			Task result;
			try
			{
				this.Close();
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000BEA38 File Offset: 0x000BCC38
		public virtual ValueTask DisposeAsync()
		{
			this.Dispose();
			return default(ValueTask);
		}
	}
}
