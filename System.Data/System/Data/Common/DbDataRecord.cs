using System;
using System.ComponentModel;

namespace System.Data.Common
{
	/// <summary>Реализует <see cref="T:System.Data.IDataRecord" /> и <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> и обеспечивает поддержку привязки данных для <see cref="T:System.Data.Common.DbEnumerator" />.</summary>
	// Token: 0x02000394 RID: 916
	public abstract class DbDataRecord : ICustomTypeDescriptor, IDataRecord
	{
		/// <summary>Указывает количество полей в текущей записи. Это свойство доступно только для чтения.</summary>
		/// <returns>Количество полей в текущей записи.</returns>
		/// <exception cref="T:System.NotSupportedException">Отсутствует подключение к источнику данных для чтения.</exception>
		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002C7A RID: 11386
		public abstract int FieldCount { get; }

		/// <summary>Указывает значение в заданном столбце в собственном формате с учетом порядкового номера столбца. Это свойство доступно только для чтения.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца в собственном формате.</returns>
		// Token: 0x17000790 RID: 1936
		public abstract object this[int i]
		{
			get;
		}

		/// <summary>Указывает значение в заданном столбце в собственном формате с учетом имени столбца. Это свойство доступно только для чтения.</summary>
		/// <param name="name">Имя столбца.</param>
		/// <returns>Значение указанного столбца в собственном формате.</returns>
		// Token: 0x17000791 RID: 1937
		public abstract object this[string name]
		{
			get;
		}

		/// <summary>Возвращает значение указанного столбца в виде логического значения.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>
		///   <see langword="true" />, если логическое значение представлено <see langword="true" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06002C7D RID: 11389
		public abstract bool GetBoolean(int i);

		/// <summary>Возвращает значение указанного столбца в виде байта.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C7E RID: 11390
		public abstract byte GetByte(int i);

		/// <summary>Возвращает значение указанного столбца в виде массива байтов.</summary>
		/// <param name="i">Порядковый номер столбца (от нуля).</param>
		/// <param name="dataIndex">Индекс в поле, с которого необходимо начать считывание.</param>
		/// <param name="buffer">Буфер, в который считывается поток байтов.</param>
		/// <param name="bufferIndex">Индекс для <paramref name="buffer" /> для запуска операции чтения.</param>
		/// <param name="length">Количество байтов, чтение которых необходимо выполнить.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C7F RID: 11391
		public abstract long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length);

		/// <summary>Возвращает значение указанного столбца в виде символа.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C80 RID: 11392
		public abstract char GetChar(int i);

		/// <summary>Возвращает значение указанного столбца в виде массива символов.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <param name="dataIndex">Буфер для копирования данных.</param>
		/// <param name="buffer">Максимальная длина для копирования в буфер.</param>
		/// <param name="bufferIndex">Точка для начала из буфера.</param>
		/// <param name="length">Точка для начала из исходных данных.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C81 RID: 11393
		public abstract long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length);

		/// <summary>В настоящее время не поддерживается.</summary>
		/// <param name="i">В настоящее время не поддерживается.</param>
		/// <returns>В настоящее время не поддерживается.</returns>
		// Token: 0x06002C82 RID: 11394 RVA: 0x000BEA7A File Offset: 0x000BCC7A
		public IDataReader GetData(int i)
		{
			return this.GetDbDataReader(i);
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DbDataReader" /> для запрошенного порядкового номера столбца, который можно переопределить реализацией, зависящей от поставщика.</summary>
		/// <param name="i">Порядковый номер столбца (от нуля).</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DbDataReader" />.</returns>
		// Token: 0x06002C83 RID: 11395 RVA: 0x00008E4B File Offset: 0x0000704B
		protected virtual DbDataReader GetDbDataReader(int i)
		{
			throw ADP.NotSupported();
		}

		/// <summary>Возвращает имя типа внутренних данных.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Имя типа внутренних данных.</returns>
		// Token: 0x06002C84 RID: 11396
		public abstract string GetDataTypeName(int i);

		/// <summary>Возвращает значение указанного столбца в виде объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C85 RID: 11397
		public abstract DateTime GetDateTime(int i);

		/// <summary>Возвращает значение указанного столбца в виде объекта <see cref="T:System.Decimal" />.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C86 RID: 11398
		public abstract decimal GetDecimal(int i);

		/// <summary>Возвращает значение заданного столбца в виде числа с плавающей запятой двойной точности.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C87 RID: 11399
		public abstract double GetDouble(int i);

		/// <summary>Возвращает тип данных объекта (<see cref="T:System.Type" />).</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Тип данных объекта (<see cref="T:System.Type" />).</returns>
		// Token: 0x06002C88 RID: 11400
		public abstract Type GetFieldType(int i);

		/// <summary>Возвращает значение заданного столбца в виде числа с плавающей запятой одинарной точности.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C89 RID: 11401
		public abstract float GetFloat(int i);

		/// <summary>Возвращает значение GUID указанного поля.</summary>
		/// <param name="i">Индекс поля, которое необходимо вернуть.</param>
		/// <returns>Значение GUID указанного поля.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Переданный индекс находился вне диапазона от 0 до значения <see cref="P:System.Data.IDataRecord.FieldCount" />.</exception>
		// Token: 0x06002C8A RID: 11402
		public abstract Guid GetGuid(int i);

		/// <summary>Возвращает значение указанного столбца в виде 16-разрядного целого числа со знаком.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C8B RID: 11403
		public abstract short GetInt16(int i);

		/// <summary>Возвращает значение указанного столбца в виде 32-разрядного целого числа со знаком.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C8C RID: 11404
		public abstract int GetInt32(int i);

		/// <summary>Возвращает значение указанного столбца в виде 64-разрядного целого числа со знаком.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C8D RID: 11405
		public abstract long GetInt64(int i);

		/// <summary>Возвращает имя заданного столбца.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Имя заданного столбца.</returns>
		// Token: 0x06002C8E RID: 11406
		public abstract string GetName(int i);

		/// <summary>Возвращает порядковый номер столбца, если известно его имя.</summary>
		/// <param name="name">Имя столбца.</param>
		/// <returns>Порядковый номер столбца.</returns>
		// Token: 0x06002C8F RID: 11407
		public abstract int GetOrdinal(string name);

		/// <summary>Возвращает значение указанного столбца в виде строки.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Значение указанного столбца.</returns>
		// Token: 0x06002C90 RID: 11408
		public abstract string GetString(int i);

		/// <summary>Возвращает значение указанного столбца в собственном формате.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>Возвращаемое значение.</returns>
		// Token: 0x06002C91 RID: 11409
		public abstract object GetValue(int i);

		/// <summary>Заполняет массив объектов значениями столбцов текущей записи.</summary>
		/// <param name="values">Массив <see cref="T:System.Object" />, в который нужно копировать поля атрибутов.</param>
		/// <returns>Число экземпляров <see cref="T:System.Object" /> в массиве.</returns>
		// Token: 0x06002C92 RID: 11410
		public abstract int GetValues(object[] values);

		/// <summary>Используется для обозначения несуществующих значений.</summary>
		/// <param name="i">Порядковый номер столбца.</param>
		/// <returns>
		///   <see langword="true" />, если указанный столбец эквивалентен <see cref="T:System.DBNull" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06002C93 RID: 11411
		public abstract bool IsDBNull(int i);

		/// <summary>Возвращает коллекцию настраиваемых атрибутов для этого экземпляра компонента.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.AttributeCollection" />, которая содержит атрибуты для этого объекта.</returns>
		// Token: 0x06002C94 RID: 11412 RVA: 0x0003279E File Offset: 0x0003099E
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return new AttributeCollection(null);
		}

		/// <summary>Возвращает имя класса для этого экземпляра компонента.</summary>
		/// <returns>Имя класса объекта или <see langword="null" />, если класс не имеет имени.</returns>
		// Token: 0x06002C95 RID: 11413 RVA: 0x00003E32 File Offset: 0x00002032
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		/// <summary>Возвращает имя этого экземпляра компонента.</summary>
		/// <returns>Имя объекта или <see langword="null" />, если объект не имеет имени.</returns>
		// Token: 0x06002C96 RID: 11414 RVA: 0x00003E32 File Offset: 0x00002032
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		/// <summary>Возвращает преобразователь типов для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.TypeConverter" />, который является преобразователем для данного объекта, или значение <see langword="null" /> в случае отсутствия <see cref="T:System.ComponentModel.TypeConverter" /> для данного объекта.</returns>
		// Token: 0x06002C97 RID: 11415 RVA: 0x00003E32 File Offset: 0x00002032
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		/// <summary>Возвращает событие по умолчанию для этого экземпляра компонента.</summary>
		/// <returns>Значение <see cref="T:System.ComponentModel.EventDescriptor" />, представляющее событие по умолчанию для этого объекта, или <see langword="null" />, если этот объект не имеет событий.</returns>
		// Token: 0x06002C98 RID: 11416 RVA: 0x00003E32 File Offset: 0x00002032
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		/// <summary>Возвращает свойство по умолчанию для этого экземпляра компонента.</summary>
		/// <returns>Значение <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющее свойство по умолчанию для данного объекта, или <see langword="null" />, если этот объект не имеет свойств.</returns>
		// Token: 0x06002C99 RID: 11417 RVA: 0x00003E32 File Offset: 0x00002032
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		/// <summary>Возвращает редактор указанного типа для этого экземпляра компонента.</summary>
		/// <param name="editorBaseType">Объект <see cref="T:System.Type" />, который представляет редактор для этого объекта.</param>
		/// <returns>Объект <see cref="T:System.Object" /> заданного типа, являющийся редактором для этого объекта, или <see langword="null" />, если редактор не найден.</returns>
		// Token: 0x06002C9A RID: 11418 RVA: 0x00003E32 File Offset: 0x00002032
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		/// <summary>Возвращает события для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />, представляющий события для этого экземпляра компонента.</returns>
		// Token: 0x06002C9B RID: 11419 RVA: 0x000327A6 File Offset: 0x000309A6
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return new EventDescriptorCollection(null);
		}

		/// <summary>Возвращает события для этого экземпляра компонента с помощью заданного массива атрибутов в качестве фильтра.</summary>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />, представляющий отфильтрованные события для этого экземпляра компонента.</returns>
		// Token: 0x06002C9C RID: 11420 RVA: 0x000327A6 File Offset: 0x000309A6
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return new EventDescriptorCollection(null);
		}

		/// <summary>Возвращает свойства для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, представляющий свойства для этого экземпляра компонента.</returns>
		// Token: 0x06002C9D RID: 11421 RVA: 0x000327AE File Offset: 0x000309AE
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		/// <summary>Возвращает свойства для этого экземпляра компонента с помощью массива атрибутов в качестве фильтра.</summary>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, представляющая отфильтрованные свойства для этого экземпляра компонента.</returns>
		// Token: 0x06002C9E RID: 11422 RVA: 0x000BEA83 File Offset: 0x000BCC83
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return new PropertyDescriptorCollection(null);
		}

		/// <summary>Возвращает объект, содержащий свойство, описанное указанным дескриптором свойства.</summary>
		/// <param name="pd">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющий свойство, владельца которого требуется найти.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий владельца заданного свойства.</returns>
		// Token: 0x06002C9F RID: 11423 RVA: 0x00005696 File Offset: 0x00003896
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}
	}
}
