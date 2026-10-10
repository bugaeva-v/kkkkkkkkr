using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace System.Data.Common
{
	/// <summary>Коллекция объектов <see cref="T:System.Data.Common.DataTableMapping" />. Этот класс не наследуется.</summary>
	// Token: 0x02000387 RID: 903
	[ListBindable(false)]
	public sealed class DataTableMappingCollection : MarshalByRefObject, ITableMappingCollection, IList, ICollection, IEnumerable
	{
		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x00006D64 File Offset: 0x00004F64
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x00005696 File Offset: 0x00003896
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IList" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x00006D64 File Offset: 0x00004F64
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IList" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x00006D64 File Offset: 0x00004F64
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает или задает элемент, расположенный в коллекции по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс получаемого или задаваемого элемента.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		// Token: 0x17000733 RID: 1843
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this.ValidateType(value);
				this[index] = (DataTableMapping)value;
			}
		}

		/// <summary>Возвращает или задает экземпляр класса <see cref="T:System.Data.ITableMapping" /> с указанным именем <see cref="P:System.Data.ITableMapping.SourceTable" />.</summary>
		/// <param name="index">Имя <see langword="SourceTable" /> объекта <see cref="T:System.Data.ITableMapping" />.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Data.ITableMapping" /> с указанным именем <see langword="SourceTable" />.</returns>
		// Token: 0x17000734 RID: 1844
		object ITableMappingCollection.this[string index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this.ValidateType(value);
				this[index] = (DataTableMapping)value;
			}
		}

		/// <summary>Добавляет сопоставление таблицы в коллекцию.</summary>
		/// <param name="sourceTableName">Имя исходной таблицы с учетом регистра.</param>
		/// <param name="dataSetTableName">Имя таблицы <see cref="T:System.Data.DataSet" />.</param>
		/// <returns>Ссылка на вновь сопоставленный объект <see cref="T:System.Data.ITableMapping" />.</returns>
		// Token: 0x06002AD9 RID: 10969 RVA: 0x000BA367 File Offset: 0x000B8567
		ITableMapping ITableMappingCollection.Add(string sourceTableName, string dataSetTableName)
		{
			return this.Add(sourceTableName, dataSetTableName);
		}

		/// <summary>Получает объект TableMapping с указанным именем таблицы <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSetTableName">Имя таблицы <see langword="DataSet" /> в коллекции.</param>
		/// <returns>Объект TableMapping с указанным именем таблицы <see langword="DataSet" />.</returns>
		// Token: 0x06002ADA RID: 10970 RVA: 0x000BA371 File Offset: 0x000B8571
		ITableMapping ITableMappingCollection.GetByDataSetTable(string dataSetTableName)
		{
			return this.GetByDataSetTable(dataSetTableName);
		}

		/// <summary>Возвращает количество объектов <see cref="T:System.Data.Common.DataTableMapping" /> в коллекции.</summary>
		/// <returns>Количество объектов <see langword="DataTableMapping" /> в коллекции.</returns>
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000BA37A File Offset: 0x000B857A
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Count
		{
			get
			{
				if (this._items == null)
				{
					return 0;
				}
				return this._items.Count;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x000BA391 File Offset: 0x000B8591
		private Type ItemType
		{
			get
			{
				return typeof(DataTableMapping);
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.Common.DataTableMapping" /> по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) объекта <see cref="T:System.Data.Common.DataTableMapping" /> для возвращения.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataTableMapping" />, расположенный по указанному индексу.</returns>
		// Token: 0x17000737 RID: 1847
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataTableMapping this[int index]
		{
			get
			{
				this.RangeCheck(index);
				return this._items[index];
			}
			set
			{
				this.RangeCheck(index);
				this.Replace(index, value);
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем исходной таблицы.</summary>
		/// <param name="sourceTable">Имя исходной таблицы с учетом регистра.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем исходной таблицы.</returns>
		// Token: 0x17000738 RID: 1848
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataTableMapping this[string sourceTable]
		{
			get
			{
				int index = this.RangeCheck(sourceTable);
				return this._items[index];
			}
			set
			{
				int index = this.RangeCheck(sourceTable);
				this.Replace(index, value);
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Object" />, являющийся сопоставлением таблиц в коллекции.</summary>
		/// <param name="value">Объект <see langword="DataTableMapping" /> для добавления в коллекцию.</param>
		/// <returns>Индекс объекта <see langword="DataTableMapping" />, который был добавлен к коллекции.</returns>
		/// <exception cref="T:System.InvalidCastException">Переданный объект не был объектом <see cref="T:System.Data.Common.DataTableMapping" />.</exception>
		// Token: 0x06002AE1 RID: 10977 RVA: 0x000BA405 File Offset: 0x000B8605
		public int Add(object value)
		{
			this.ValidateType(value);
			this.Add((DataTableMapping)value);
			return this.Count - 1;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000BA423 File Offset: 0x000B8623
		private DataTableMapping Add(DataTableMapping value)
		{
			this.AddWithoutEvents(value);
			return value;
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.Data.Common.DataTableMapping" /> в конец коллекции.</summary>
		/// <param name="values">Массив объектов <see cref="T:System.Data.Common.DataTableMapping" />, добавляемый в коллекцию.</param>
		// Token: 0x06002AE3 RID: 10979 RVA: 0x000BA42D File Offset: 0x000B862D
		public void AddRange(DataTableMapping[] values)
		{
			this.AddEnumerableRange(values, false);
		}

		/// <summary>Копирует элементы указанного объекта <see cref="T:System.Array" /> в конец коллекции.</summary>
		/// <param name="values">Массив значений типа <see cref="T:System.Array" />, добавляемый в коллекцию.</param>
		// Token: 0x06002AE4 RID: 10980 RVA: 0x000BA42D File Offset: 0x000B862D
		public void AddRange(Array values)
		{
			this.AddEnumerableRange(values, false);
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000BA438 File Offset: 0x000B8638
		private void AddEnumerableRange(IEnumerable values, bool doClone)
		{
			if (values == null)
			{
				throw ADP.ArgumentNull("values");
			}
			foreach (object value in values)
			{
				this.ValidateType(value);
			}
			if (doClone)
			{
				using (IEnumerator enumerator = values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						ICloneable cloneable = (ICloneable)obj;
						this.AddWithoutEvents(cloneable.Clone() as DataTableMapping);
					}
					return;
				}
			}
			foreach (object obj2 in values)
			{
				DataTableMapping value2 = (DataTableMapping)obj2;
				this.AddWithoutEvents(value2);
			}
		}

		/// <summary>Добавляет <see cref="T:System.Data.Common.DataTableMapping" /> к коллекции для данного имени исходной таблицы и имени таблицы <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="sourceTable">Имя исходной таблицы для сопоставления, определяемое с учетом регистра.</param>
		/// <param name="dataSetTable">Имя таблицы <see cref="T:System.Data.DataSet" /> для сопоставления, определяемое без учета регистра.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataTableMapping" />, который был добавлен в коллекцию.</returns>
		// Token: 0x06002AE6 RID: 10982 RVA: 0x000BA52C File Offset: 0x000B872C
		public DataTableMapping Add(string sourceTable, string dataSetTable)
		{
			return this.Add(new DataTableMapping(sourceTable, dataSetTable));
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000BA53B File Offset: 0x000B873B
		private void AddWithoutEvents(DataTableMapping value)
		{
			this.Validate(-1, value);
			value.Parent = this;
			this.ArrayList().Add(value);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000BA558 File Offset: 0x000B8758
		private List<DataTableMapping> ArrayList()
		{
			List<DataTableMapping> result;
			if ((result = this._items) == null)
			{
				result = (this._items = new List<DataTableMapping>());
			}
			return result;
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Data.Common.DataTableMapping" /> из коллекции.</summary>
		// Token: 0x06002AE9 RID: 10985 RVA: 0x000BA57D File Offset: 0x000B877D
		public void Clear()
		{
			if (0 < this.Count)
			{
				this.ClearWithoutEvents();
			}
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000BA590 File Offset: 0x000B8790
		private void ClearWithoutEvents()
		{
			if (this._items != null)
			{
				foreach (DataTableMapping dataTableMapping in this._items)
				{
					dataTableMapping.Parent = null;
				}
				this._items.Clear();
			}
		}

		/// <summary>Получает значение, показывающее, существует ли объект <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем исходной таблицы в коллекции.</summary>
		/// <param name="value">Имя исходной таблицы, содержащей объект <see cref="T:System.Data.Common.DataTableMapping" />, определяемое с учетом регистра.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит объект <see cref="T:System.Data.Common.DataTableMapping" /> с этим именем исходной таблицы; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002AEB RID: 10987 RVA: 0x000BA5F4 File Offset: 0x000B87F4
		public bool Contains(string value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Получает значение, показывающее, существует ли данный объект <see cref="T:System.Data.Common.DataTableMapping" /> в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который является объектом <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект <see cref="T:System.Data.Common.DataTableMapping" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002AEC RID: 10988 RVA: 0x000BA603 File Offset: 0x000B8803
		public bool Contains(object value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Data.Common.DataTableMappingCollection" /> в указанный массив.</summary>
		/// <param name="array">Массив <see cref="T:System.Array" />, в который копируются элементы <see cref="T:System.Data.Common.DataTableMappingCollection" />.</param>
		/// <param name="index">Начальный индекс массива.</param>
		// Token: 0x06002AED RID: 10989 RVA: 0x000BA612 File Offset: 0x000B8812
		public void CopyTo(Array array, int index)
		{
			((ICollection)this.ArrayList()).CopyTo(array, index);
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Data.Common.DataTableMapping" /> в указанный массив.</summary>
		/// <param name="array">Объект <see cref="T:System.Data.Common.DataTableMapping" />, в который копируются элементы <see cref="T:System.Data.Common.DataTableMappingCollection" />.</param>
		/// <param name="index">Начальный индекс массива.</param>
		// Token: 0x06002AEE RID: 10990 RVA: 0x000BA621 File Offset: 0x000B8821
		public void CopyTo(DataTableMapping[] array, int index)
		{
			this.ArrayList().CopyTo(array, index);
		}

		/// <summary>Получает объект <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем таблицы <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSetTable">Имя таблицы <see cref="T:System.Data.DataSet" /> для поиска, определяемое без учета регистра.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем таблицы <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x06002AEF RID: 10991 RVA: 0x000BA630 File Offset: 0x000B8830
		public DataTableMapping GetByDataSetTable(string dataSetTable)
		{
			int num = this.IndexOfDataSetTable(dataSetTable);
			if (0 > num)
			{
				throw ADP.TablesDataSetTable(dataSetTable);
			}
			return this._items[num];
		}

		/// <summary>Возвращает перечислитель, который может выполнять итерацию элементов коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06002AF0 RID: 10992 RVA: 0x000BA65C File Offset: 0x000B885C
		public IEnumerator GetEnumerator()
		{
			return this.ArrayList().GetEnumerator();
		}

		/// <summary>Получает местоположение указанного объекта <see cref="T:System.Data.Common.DataTableMapping" /> в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который является объектом <see cref="T:System.Data.Common.DataTableMapping" /> для поиска.</param>
		/// <returns>Местоположение (с нуля) указанного объекта <see cref="T:System.Data.Common.DataTableMapping" /> в коллекции.</returns>
		// Token: 0x06002AF1 RID: 10993 RVA: 0x000BA670 File Offset: 0x000B8870
		public int IndexOf(object value)
		{
			if (value != null)
			{
				this.ValidateType(value);
				for (int i = 0; i < this.Count; i++)
				{
					if (this._items[i] == value)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Получает расположение объекта <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем исходной таблицы.</summary>
		/// <param name="sourceTable">Имя исходной таблицы с учетом регистра.</param>
		/// <returns>Местоположение (с нуля) объекта <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем исходной таблицы.</returns>
		// Token: 0x06002AF2 RID: 10994 RVA: 0x000BA6AC File Offset: 0x000B88AC
		public int IndexOf(string sourceTable)
		{
			if (!string.IsNullOrEmpty(sourceTable))
			{
				for (int i = 0; i < this.Count; i++)
				{
					string sourceTable2 = this._items[i].SourceTable;
					if (sourceTable2 != null && ADP.SrcCompare(sourceTable, sourceTable2) == 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Получает расположение объекта <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем таблицы <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSetTable">Имя таблицы <see langword="DataSet" /> для поиска, определяемое без учета регистра.</param>
		/// <returns>Местоположение (с нуля) объекта <see cref="T:System.Data.Common.DataTableMapping" /> с данным именем таблицы <see cref="T:System.Data.DataSet" />; -1, если объект <see cref="T:System.Data.Common.DataTableMapping" /> не существует в коллекции.</returns>
		// Token: 0x06002AF3 RID: 10995 RVA: 0x000BA6F4 File Offset: 0x000B88F4
		public int IndexOfDataSetTable(string dataSetTable)
		{
			if (!string.IsNullOrEmpty(dataSetTable))
			{
				for (int i = 0; i < this.Count; i++)
				{
					string dataSetTable2 = this._items[i].DataSetTable;
					if (dataSetTable2 != null && ADP.DstCompare(dataSetTable, dataSetTable2) == 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Вставляет объект <see cref="T:System.Data.Common.DataTableMapping" /> в коллекцию <see cref="T:System.Data.Common.DataTableMappingCollection" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс вставляемого объекта <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		// Token: 0x06002AF4 RID: 10996 RVA: 0x000BA73B File Offset: 0x000B893B
		public void Insert(int index, object value)
		{
			this.ValidateType(value);
			this.Insert(index, (DataTableMapping)value);
		}

		/// <summary>Вставляет объект <see cref="T:System.Data.Common.DataTableMapping" /> в коллекцию <see cref="T:System.Data.Common.DataTableMappingCollection" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс вставляемого объекта <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		// Token: 0x06002AF5 RID: 10997 RVA: 0x000BA751 File Offset: 0x000B8951
		public void Insert(int index, DataTableMapping value)
		{
			if (value == null)
			{
				throw ADP.TablesAddNullAttempt("value");
			}
			this.Validate(-1, value);
			value.Parent = this;
			this.ArrayList().Insert(index, value);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000BA77D File Offset: 0x000B897D
		private void RangeCheck(int index)
		{
			if (index < 0 || this.Count <= index)
			{
				throw ADP.TablesIndexInt32(index, this);
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000BA794 File Offset: 0x000B8994
		private int RangeCheck(string sourceTable)
		{
			int num = this.IndexOf(sourceTable);
			if (num < 0)
			{
				throw ADP.TablesSourceIndex(sourceTable);
			}
			return num;
		}

		/// <summary>Удаляет объект <see cref="T:System.Data.Common.DataTableMapping" />, находящийся по указанному индексу, из коллекции.</summary>
		/// <param name="index">Индекс (отсчет с нуля) удаляемого объекта <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		/// <exception cref="T:System.IndexOutOfRangeException">Объект <see cref="T:System.Data.Common.DataTableMapping" /> не существует по указанному индексу.</exception>
		// Token: 0x06002AF8 RID: 11000 RVA: 0x000BA7A8 File Offset: 0x000B89A8
		public void RemoveAt(int index)
		{
			this.RangeCheck(index);
			this.RemoveIndex(index);
		}

		/// <summary>Удаляет из коллекции объект <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем исходной таблицы.</summary>
		/// <param name="sourceTable">Имя исходной таблицы для поиска, определяемое с учетом регистра.</param>
		/// <exception cref="T:System.IndexOutOfRangeException">Не существует объект <see cref="T:System.Data.Common.DataTableMapping" /> с указанным именем исходной таблицы.</exception>
		// Token: 0x06002AF9 RID: 11001 RVA: 0x000BA7B8 File Offset: 0x000B89B8
		public void RemoveAt(string sourceTable)
		{
			int index = this.RangeCheck(sourceTable);
			this.RemoveIndex(index);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000BA7D4 File Offset: 0x000B89D4
		private void RemoveIndex(int index)
		{
			this._items[index].Parent = null;
			this._items.RemoveAt(index);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Data.Common.DataTableMapping" /> из коллекции.</summary>
		/// <param name="value">Удаляемый объект <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		/// <exception cref="T:System.InvalidCastException">Указанный объект не являлся объектом <see cref="T:System.Data.Common.DataTableMapping" />.</exception>
		/// <exception cref="T:System.ArgumentException">Указанный объект отсутствует в коллекции.</exception>
		// Token: 0x06002AFB RID: 11003 RVA: 0x000BA7F4 File Offset: 0x000B89F4
		public void Remove(object value)
		{
			this.ValidateType(value);
			this.Remove((DataTableMapping)value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Data.Common.DataTableMapping" /> из коллекции.</summary>
		/// <param name="value">Удаляемый объект <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		// Token: 0x06002AFC RID: 11004 RVA: 0x000BA80C File Offset: 0x000B8A0C
		public void Remove(DataTableMapping value)
		{
			if (value == null)
			{
				throw ADP.TablesAddNullAttempt("value");
			}
			int num = this.IndexOf(value);
			if (-1 != num)
			{
				this.RemoveIndex(num);
				return;
			}
			throw ADP.CollectionRemoveInvalidObject(this.ItemType, this);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000BA847 File Offset: 0x000B8A47
		private void Replace(int index, DataTableMapping newValue)
		{
			this.Validate(index, newValue);
			this._items[index].Parent = null;
			newValue.Parent = this;
			this._items[index] = newValue;
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000BA877 File Offset: 0x000B8A77
		private void ValidateType(object value)
		{
			if (value == null)
			{
				throw ADP.TablesAddNullAttempt("value");
			}
			if (!this.ItemType.IsInstanceOfType(value))
			{
				throw ADP.NotADataTableMapping(value);
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000BA89C File Offset: 0x000B8A9C
		private void Validate(int index, DataTableMapping value)
		{
			if (value == null)
			{
				throw ADP.TablesAddNullAttempt("value");
			}
			if (value.Parent != null)
			{
				if (this != value.Parent)
				{
					throw ADP.TablesIsNotParent(this);
				}
				if (index != this.IndexOf(value))
				{
					throw ADP.TablesIsParent(this);
				}
			}
			string text = value.SourceTable;
			if (string.IsNullOrEmpty(text))
			{
				index = 1;
				do
				{
					text = "SourceTable" + index.ToString(CultureInfo.InvariantCulture);
					index++;
				}
				while (-1 != this.IndexOf(text));
				value.SourceTable = text;
				return;
			}
			this.ValidateSourceTable(index, text);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000BA928 File Offset: 0x000B8B28
		internal void ValidateSourceTable(int index, string value)
		{
			int num = this.IndexOf(value);
			if (-1 != num && index != num)
			{
				throw ADP.TablesUniqueSourceTable(value);
			}
		}

		/// <summary>Получает объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем исходной таблицы и именем таблицы <see cref="T:System.Data.DataSet" /> с помощью заданного <see cref="T:System.Data.MissingMappingAction" />.</summary>
		/// <param name="tableMappings">Коллекция <see cref="T:System.Data.Common.DataTableMappingCollection" /> для поиска.</param>
		/// <param name="sourceTable">Имя сопоставленной исходной таблицы, определяемое с учетом регистра.</param>
		/// <param name="dataSetTable">Имя сопоставленной таблицы <see cref="T:System.Data.DataSet" /> без учета регистра.</param>
		/// <param name="mappingAction">Одно из значений <see cref="T:System.Data.MissingMappingAction" />.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataTableMapping" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для параметра <paramref name="mappingAction" /> было задано значение <see langword="Error" /> и не было указано сопоставление.</exception>
		// Token: 0x06002B01 RID: 11009 RVA: 0x000BA94C File Offset: 0x000B8B4C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static DataTableMapping GetTableMappingBySchemaAction(DataTableMappingCollection tableMappings, string sourceTable, string dataSetTable, MissingMappingAction mappingAction)
		{
			if (tableMappings != null)
			{
				int num = tableMappings.IndexOf(sourceTable);
				if (-1 != num)
				{
					return tableMappings._items[num];
				}
			}
			if (string.IsNullOrEmpty(sourceTable))
			{
				throw ADP.InvalidSourceTable("sourceTable");
			}
			switch (mappingAction)
			{
			case MissingMappingAction.Passthrough:
				return new DataTableMapping(sourceTable, dataSetTable);
			case MissingMappingAction.Ignore:
				return null;
			case MissingMappingAction.Error:
				throw ADP.MissingTableMapping(sourceTable);
			default:
				throw ADP.InvalidMissingMappingAction(mappingAction);
			}
		}

		// Token: 0x04001B15 RID: 6933
		private List<DataTableMapping> _items;
	}
}
