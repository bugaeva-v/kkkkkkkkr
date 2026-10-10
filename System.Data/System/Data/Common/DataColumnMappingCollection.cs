using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace System.Data.Common
{
	/// <summary>Содержит коллекцию объектов <see cref="T:System.Data.Common.DataColumnMapping" />.</summary>
	// Token: 0x02000380 RID: 896
	public sealed class DataColumnMappingCollection : MarshalByRefObject, IColumnMappingCollection, IList, ICollection, IEnumerable
	{
		/// <summary>Получает значение, определяющее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x00006D64 File Offset: 0x00004F64
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x00005696 File Offset: 0x00003896
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Collections.IList" /> доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x00006D64 File Offset: 0x00004F64
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, показывающее, имеет ли объект <see cref="T:System.Collections.IList" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06002A39 RID: 10809 RVA: 0x00006D64 File Offset: 0x00004F64
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		// Token: 0x1700071F RID: 1823
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this.ValidateType(value);
				this[index] = (DataColumnMapping)value;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.IColumnMapping" /> с указанным именем <see langword="SourceColumn" />.</summary>
		/// <param name="index">Индекс элемента.</param>
		/// <returns>Объект <see langword="IColumnMapping" /> с указанным именем <see langword="SourceColumn" />.</returns>
		// Token: 0x17000720 RID: 1824
		object IColumnMappingCollection.this[string index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this.ValidateType(value);
				this[index] = (DataColumnMapping)value;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.Common.DataColumnMapping" /> в коллекцию <see cref="T:System.Data.Common.DataColumnMappingCollection" /> с помощью имени исходного столбца и имени столбца <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="sourceColumnName">Зависящее от регистра имя исходного столбца.</param>
		/// <param name="dataSetColumnName">Имя столбца <see cref="T:System.Data.DataSet" />.</param>
		/// <returns>Объект ColumnMapping, который был добавлен в коллекцию.</returns>
		// Token: 0x06002A3E RID: 10814 RVA: 0x000B8C66 File Offset: 0x000B6E66
		IColumnMapping IColumnMappingCollection.Add(string sourceColumnName, string dataSetColumnName)
		{
			return this.Add(sourceColumnName, dataSetColumnName);
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DataColumnMapping" /> с заданным именем столбца <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSetColumnName">Независящее от регистра имя искомого столбца <see cref="T:System.Data.DataSet" />.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataColumnMapping" /> с заданным именем столбца <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x06002A3F RID: 10815 RVA: 0x000B8C70 File Offset: 0x000B6E70
		IColumnMapping IColumnMappingCollection.GetByDataSetColumn(string dataSetColumnName)
		{
			return this.GetByDataSetColumn(dataSetColumnName);
		}

		/// <summary>Возвращает количество объектов <see cref="T:System.Data.Common.DataColumnMapping" /> в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000B8C79 File Offset: 0x000B6E79
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

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000B8C90 File Offset: 0x000B6E90
		private Type ItemType
		{
			get
			{
				return typeof(DataColumnMapping);
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.Common.DataColumnMapping" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс объекта <see cref="T:System.Data.Common.DataColumnMapping" /> для поиска.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataColumnMapping" />, расположенный по указанному индексу.</returns>
		// Token: 0x17000723 RID: 1827
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataColumnMapping this[int index]
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

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем исходного столбца.</summary>
		/// <param name="sourceColumn">Зависящее от регистра имя исходного столбца.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем исходного столбца.</returns>
		// Token: 0x17000724 RID: 1828
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataColumnMapping this[string sourceColumn]
		{
			get
			{
				int index = this.RangeCheck(sourceColumn);
				return this._items[index];
			}
			set
			{
				int index = this.RangeCheck(sourceColumn);
				this.Replace(index, value);
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.Common.DataColumnMapping" /> в коллекцию.</summary>
		/// <param name="value">Объект <see langword="DataColumnMapping" /> для добавления в коллекцию.</param>
		/// <returns>Индекс объекта <see langword="DataColumnMapping" />, который был добавлен в коллекцию.</returns>
		/// <exception cref="T:System.InvalidCastException">Переданный объект не был объектом <see cref="T:System.Data.Common.DataColumnMapping" />.</exception>
		// Token: 0x06002A46 RID: 10822 RVA: 0x000B8D05 File Offset: 0x000B6F05
		public int Add(object value)
		{
			this.ValidateType(value);
			this.Add((DataColumnMapping)value);
			return this.Count - 1;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000B8D23 File Offset: 0x000B6F23
		private DataColumnMapping Add(DataColumnMapping value)
		{
			this.AddWithoutEvents(value);
			return value;
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.Common.DataColumnMapping" /> в коллекцию на основе заданного имени исходного столбца и имени столбца <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="sourceColumn">Зависящее от регистра имя исходного столбца для сопоставления.</param>
		/// <param name="dataSetColumn">Независящее от регистра имя столбца <see cref="T:System.Data.DataSet" /> для сопоставления.</param>
		/// <returns>Объект <see langword="DataColumnMapping" />, который был добавлен в коллекцию.</returns>
		// Token: 0x06002A48 RID: 10824 RVA: 0x000B8D2D File Offset: 0x000B6F2D
		public DataColumnMapping Add(string sourceColumn, string dataSetColumn)
		{
			return this.Add(new DataColumnMapping(sourceColumn, dataSetColumn));
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.Data.Common.DataColumnMapping" /> в конец коллекции.</summary>
		/// <param name="values">Массив объектов <see cref="T:System.Data.Common.DataColumnMapping" />, добавляемый в коллекцию.</param>
		// Token: 0x06002A49 RID: 10825 RVA: 0x000B8D3C File Offset: 0x000B6F3C
		public void AddRange(DataColumnMapping[] values)
		{
			this.AddEnumerableRange(values, false);
		}

		/// <summary>Копирует элементы указанного объекта <see cref="T:System.Array" /> в конец коллекции.</summary>
		/// <param name="values">Параметр <see cref="T:System.Array" /> для добавления в коллекцию.</param>
		// Token: 0x06002A4A RID: 10826 RVA: 0x000B8D3C File Offset: 0x000B6F3C
		public void AddRange(Array values)
		{
			this.AddEnumerableRange(values, false);
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000B8D48 File Offset: 0x000B6F48
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
						this.AddWithoutEvents(cloneable.Clone() as DataColumnMapping);
					}
					return;
				}
			}
			foreach (object obj2 in values)
			{
				DataColumnMapping value2 = (DataColumnMapping)obj2;
				this.AddWithoutEvents(value2);
			}
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x000B8E3C File Offset: 0x000B703C
		private void AddWithoutEvents(DataColumnMapping value)
		{
			this.Validate(-1, value);
			value.Parent = this;
			this.ArrayList().Add(value);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000B8E59 File Offset: 0x000B7059
		private List<DataColumnMapping> ArrayList()
		{
			if (this._items == null)
			{
				this._items = new List<DataColumnMapping>();
			}
			return this._items;
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Data.Common.DataColumnMapping" /> из коллекции.</summary>
		// Token: 0x06002A4E RID: 10830 RVA: 0x000B8E74 File Offset: 0x000B7074
		public void Clear()
		{
			if (0 < this.Count)
			{
				this.ClearWithoutEvents();
			}
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x000B8E88 File Offset: 0x000B7088
		private void ClearWithoutEvents()
		{
			if (this._items != null)
			{
				foreach (DataColumnMapping dataColumnMapping in this._items)
				{
					dataColumnMapping.Parent = null;
				}
				this._items.Clear();
			}
		}

		/// <summary>Возвращает значение, указывающее, существует ли объект <see cref="T:System.Data.Common.DataColumnMapping" /> с данным именем исходного столбца в коллекции.</summary>
		/// <param name="value">Зависящее от регистра имя исходного столбца объекта <see cref="T:System.Data.Common.DataColumnMapping" />.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем исходного столбца; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002A50 RID: 10832 RVA: 0x000B8EEC File Offset: 0x000B70EC
		public bool Contains(string value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Возвращает значение, указывающее, существует ли объект <see cref="T:System.Data.Common.DataColumnMapping" /> с данным объектом <see cref="T:System.Object" /> в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который является объектом <see cref="T:System.Data.Common.DataColumnMapping" />.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит указанный объект <see cref="T:System.Data.Common.DataColumnMapping" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Переданный объект не был объектом <see cref="T:System.Data.Common.DataColumnMapping" />.</exception>
		// Token: 0x06002A51 RID: 10833 RVA: 0x000B8EFB File Offset: 0x000B70FB
		public bool Contains(object value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Data.Common.DataColumnMappingCollection" /> в указанный массив.</summary>
		/// <param name="array">Массив <see cref="T:System.Array" />, в который копируются элементы <see cref="T:System.Data.Common.DataColumnMappingCollection" />.</param>
		/// <param name="index">Начальный индекс массива.</param>
		// Token: 0x06002A52 RID: 10834 RVA: 0x000B8F0A File Offset: 0x000B710A
		public void CopyTo(Array array, int index)
		{
			((ICollection)this.ArrayList()).CopyTo(array, index);
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Data.Common.DataColumnMappingCollection" /> в указанный массив <see cref="T:System.Data.Common.DataColumnMapping" />.</summary>
		/// <param name="array">Массив <see cref="T:System.Data.Common.DataColumnMapping" />, в который копируются элементы <see cref="T:System.Data.Common.DataColumnMappingCollection" />.</param>
		/// <param name="index">Индекс (с нуля) в <paramref name="array" />, с которого начинается копирование.</param>
		// Token: 0x06002A53 RID: 10835 RVA: 0x000B8F19 File Offset: 0x000B7119
		public void CopyTo(DataColumnMapping[] array, int index)
		{
			this.ArrayList().CopyTo(array, index);
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем столбца <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="value">Независящее от регистра имя искомого столбца <see cref="T:System.Data.DataSet" />.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем столбца <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x06002A54 RID: 10836 RVA: 0x000B8F28 File Offset: 0x000B7128
		public DataColumnMapping GetByDataSetColumn(string value)
		{
			int num = this.IndexOfDataSetColumn(value);
			if (0 > num)
			{
				throw ADP.ColumnsDataSetColumn(value);
			}
			return this._items[num];
		}

		/// <summary>Возвращает перечислитель, который может выполнять итерацию элементов коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06002A55 RID: 10837 RVA: 0x000B8F54 File Offset: 0x000B7154
		public IEnumerator GetEnumerator()
		{
			return this.ArrayList().GetEnumerator();
		}

		/// <summary>Возвращает расположение указанного объекта <see cref="T:System.Object" />, который является объектом <see cref="T:System.Data.Common.DataColumnMapping" /> в коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, являющийся объектом <see cref="T:System.Data.Common.DataColumnMapping" /> для поиска.</param>
		/// <returns>Отсчитываемое от нуля расположение указанного объекта <see cref="T:System.Object" />, который является объектом <see cref="T:System.Data.Common.DataColumnMapping" /> в коллекции.</returns>
		// Token: 0x06002A56 RID: 10838 RVA: 0x000B8F68 File Offset: 0x000B7168
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

		/// <summary>Возвращает местоположение объекта <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем исходного столбца.</summary>
		/// <param name="sourceColumn">Зависящее от регистра имя исходного столбца.</param>
		/// <returns>Отсчитываемое от нуля расположение объекта <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным зависящим от регистра именем исходного столбца.</returns>
		// Token: 0x06002A57 RID: 10839 RVA: 0x000B8FA4 File Offset: 0x000B71A4
		public int IndexOf(string sourceColumn)
		{
			if (!string.IsNullOrEmpty(sourceColumn))
			{
				int count = this.Count;
				for (int i = 0; i < count; i++)
				{
					if (ADP.SrcCompare(sourceColumn, this._items[i].SourceColumn) == 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Возвращает местоположение указанного объекта <see cref="T:System.Data.Common.DataColumnMapping" /> с заданным именем столбца <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSetColumn">Независящее от регистра имя столбца набора данных для поиска.</param>
		/// <returns>Отсчитываемое от нуля расположение указанного объекта <see cref="T:System.Data.Common.DataColumnMapping" /> с данным именем столбца <see langword="DataSet" /> или -1, если объект <see langword="DataColumnMapping" /> не существует в коллекции.</returns>
		// Token: 0x06002A58 RID: 10840 RVA: 0x000B8FE8 File Offset: 0x000B71E8
		public int IndexOfDataSetColumn(string dataSetColumn)
		{
			if (!string.IsNullOrEmpty(dataSetColumn))
			{
				int count = this.Count;
				for (int i = 0; i < count; i++)
				{
					if (ADP.DstCompare(dataSetColumn, this._items[i].DataSetColumn) == 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		/// <summary>Вставляет объект <see cref="T:System.Data.Common.DataColumnMapping" /> в коллекцию <see cref="T:System.Data.Common.DataColumnMappingCollection" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс вставляемого объекта <see cref="T:System.Data.Common.DataColumnMapping" />.</param>
		/// <param name="value">Объект <see cref="T:System.Data.Common.DataColumnMapping" />.</param>
		// Token: 0x06002A59 RID: 10841 RVA: 0x000B902C File Offset: 0x000B722C
		public void Insert(int index, object value)
		{
			this.ValidateType(value);
			this.Insert(index, (DataColumnMapping)value);
		}

		/// <summary>Вставляет объект <see cref="T:System.Data.Common.DataColumnMapping" /> в коллекцию <see cref="T:System.Data.Common.DataColumnMappingCollection" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс вставляемого объекта <see cref="T:System.Data.Common.DataColumnMapping" />.</param>
		/// <param name="value">Объект <see cref="T:System.Data.Common.DataColumnMapping" />.</param>
		// Token: 0x06002A5A RID: 10842 RVA: 0x000B9042 File Offset: 0x000B7242
		public void Insert(int index, DataColumnMapping value)
		{
			if (value == null)
			{
				throw ADP.ColumnsAddNullAttempt("value");
			}
			this.Validate(-1, value);
			value.Parent = this;
			this.ArrayList().Insert(index, value);
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x000B906E File Offset: 0x000B726E
		private void RangeCheck(int index)
		{
			if (index < 0 || this.Count <= index)
			{
				throw ADP.ColumnsIndexInt32(index, this);
			}
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000B9085 File Offset: 0x000B7285
		private int RangeCheck(string sourceColumn)
		{
			int num = this.IndexOf(sourceColumn);
			if (num < 0)
			{
				throw ADP.ColumnsIndexSource(sourceColumn);
			}
			return num;
		}

		/// <summary>Удаляет объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным индексом из коллекции.</summary>
		/// <param name="index">Индекс (отсчет с нуля) удаляемого объекта <see cref="T:System.Data.Common.DataColumnMapping" />.</param>
		/// <exception cref="T:System.IndexOutOfRangeException">Отсутствует объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным индексом.</exception>
		// Token: 0x06002A5D RID: 10845 RVA: 0x000B9099 File Offset: 0x000B7299
		public void RemoveAt(int index)
		{
			this.RangeCheck(index);
			this.RemoveIndex(index);
		}

		/// <summary>Удаляет из коллекции объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем исходного столбца.</summary>
		/// <param name="sourceColumn">Зависящее от регистра имя исходного столбца.</param>
		/// <exception cref="T:System.IndexOutOfRangeException">Отсутствует объект <see cref="T:System.Data.Common.DataColumnMapping" /> с указанным именем исходного столбца.</exception>
		// Token: 0x06002A5E RID: 10846 RVA: 0x000B90AC File Offset: 0x000B72AC
		public void RemoveAt(string sourceColumn)
		{
			int index = this.RangeCheck(sourceColumn);
			this.RemoveIndex(index);
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000B90C8 File Offset: 0x000B72C8
		private void RemoveIndex(int index)
		{
			this._items[index].Parent = null;
			this._items.RemoveAt(index);
		}

		/// <summary>Удаляет из коллекции объект <see cref="T:System.Object" />, который является объектом <see cref="T:System.Data.Common.DataColumnMapping" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, являющийся объектом <see cref="T:System.Data.Common.DataColumnMapping" /> для удаления.</param>
		/// <exception cref="T:System.InvalidCastException">Указанный объект не являлся объектом <see cref="T:System.Data.Common.DataColumnMapping" />.</exception>
		/// <exception cref="T:System.ArgumentException">Указанный объект отсутствует в коллекции.</exception>
		// Token: 0x06002A60 RID: 10848 RVA: 0x000B90E8 File Offset: 0x000B72E8
		public void Remove(object value)
		{
			this.ValidateType(value);
			this.Remove((DataColumnMapping)value);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Data.Common.DataColumnMapping" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.Common.DataColumnMapping" /> для удаления.</param>
		// Token: 0x06002A61 RID: 10849 RVA: 0x000B9100 File Offset: 0x000B7300
		public void Remove(DataColumnMapping value)
		{
			if (value == null)
			{
				throw ADP.ColumnsAddNullAttempt("value");
			}
			int num = this.IndexOf(value);
			if (-1 != num)
			{
				this.RemoveIndex(num);
				return;
			}
			throw ADP.CollectionRemoveInvalidObject(this.ItemType, this);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000B913B File Offset: 0x000B733B
		private void Replace(int index, DataColumnMapping newValue)
		{
			this.Validate(index, newValue);
			this._items[index].Parent = null;
			newValue.Parent = this;
			this._items[index] = newValue;
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000B916B File Offset: 0x000B736B
		private void ValidateType(object value)
		{
			if (value == null)
			{
				throw ADP.ColumnsAddNullAttempt("value");
			}
			if (!this.ItemType.IsInstanceOfType(value))
			{
				throw ADP.NotADataColumnMapping(value);
			}
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x000B9190 File Offset: 0x000B7390
		private void Validate(int index, DataColumnMapping value)
		{
			if (value == null)
			{
				throw ADP.ColumnsAddNullAttempt("value");
			}
			if (value.Parent != null)
			{
				if (this != value.Parent)
				{
					throw ADP.ColumnsIsNotParent(this);
				}
				if (index != this.IndexOf(value))
				{
					throw ADP.ColumnsIsParent(this);
				}
			}
			string text = value.SourceColumn;
			if (string.IsNullOrEmpty(text))
			{
				index = 1;
				do
				{
					text = "SourceColumn" + index.ToString(CultureInfo.InvariantCulture);
					index++;
				}
				while (-1 != this.IndexOf(text));
				value.SourceColumn = text;
				return;
			}
			this.ValidateSourceColumn(index, text);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x000B921C File Offset: 0x000B741C
		internal void ValidateSourceColumn(int index, string value)
		{
			int num = this.IndexOf(value);
			if (-1 != num && index != num)
			{
				throw ADP.ColumnsUniqueSourceColumn(value);
			}
		}

		/// <summary>Статический метод, который возвращает объект <see cref="T:System.Data.DataColumn" />, не создавая экземпляр объекта <see cref="T:System.Data.Common.DataColumnMappingCollection" />.</summary>
		/// <param name="columnMappings">
		///   <see cref="T:System.Data.Common.DataColumnMappingCollection" />.</param>
		/// <param name="sourceColumn">Зависящее от регистра имя столбца из источника данных.</param>
		/// <param name="dataType">Тип данных для сопоставляемого столбца.</param>
		/// <param name="dataTable">Экземпляр <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="mappingAction">Одно из значений <see cref="T:System.Data.MissingMappingAction" />.</param>
		/// <param name="schemaAction">Определяет действие, которое должно быть выполнено, если существующая схема <see cref="T:System.Data.DataSet" /> не соответствует входным данным.</param>
		/// <returns>Объект <see cref="T:System.Data.DataColumn" />.</returns>
		// Token: 0x06002A66 RID: 10854 RVA: 0x000B9240 File Offset: 0x000B7440
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static DataColumn GetDataColumn(DataColumnMappingCollection columnMappings, string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction)
		{
			if (columnMappings != null)
			{
				int num = columnMappings.IndexOf(sourceColumn);
				if (-1 != num)
				{
					return columnMappings._items[num].GetDataColumnBySchemaAction(dataTable, dataType, schemaAction);
				}
			}
			if (string.IsNullOrEmpty(sourceColumn))
			{
				throw ADP.InvalidSourceColumn("sourceColumn");
			}
			switch (mappingAction)
			{
			case MissingMappingAction.Passthrough:
				return DataColumnMapping.GetDataColumnBySchemaAction(sourceColumn, sourceColumn, dataTable, dataType, schemaAction);
			case MissingMappingAction.Ignore:
				return null;
			case MissingMappingAction.Error:
				throw ADP.MissingColumnMapping(sourceColumn);
			default:
				throw ADP.InvalidMissingMappingAction(mappingAction);
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DataColumnMapping" /> для указанного <see cref="T:System.Data.Common.DataColumnMappingCollection" />, имени исходного столбца и <see cref="T:System.Data.MissingMappingAction" />.</summary>
		/// <param name="columnMappings">
		///   <see cref="T:System.Data.Common.DataColumnMappingCollection" />.</param>
		/// <param name="sourceColumn">Зависящее от регистра имя исходного столбца для поиска.</param>
		/// <param name="mappingAction">Одно из значений <see cref="T:System.Data.MissingMappingAction" />.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DataColumnMapping" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для параметра <paramref name="mappingAction" /> было задано значение <see langword="Error" /> и не было указано сопоставление.</exception>
		// Token: 0x06002A67 RID: 10855 RVA: 0x000B92B8 File Offset: 0x000B74B8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static DataColumnMapping GetColumnMappingBySchemaAction(DataColumnMappingCollection columnMappings, string sourceColumn, MissingMappingAction mappingAction)
		{
			if (columnMappings != null)
			{
				int num = columnMappings.IndexOf(sourceColumn);
				if (-1 != num)
				{
					return columnMappings._items[num];
				}
			}
			if (string.IsNullOrEmpty(sourceColumn))
			{
				throw ADP.InvalidSourceColumn("sourceColumn");
			}
			switch (mappingAction)
			{
			case MissingMappingAction.Passthrough:
				return new DataColumnMapping(sourceColumn, sourceColumn);
			case MissingMappingAction.Ignore:
				return null;
			case MissingMappingAction.Error:
				throw ADP.MissingColumnMapping(sourceColumn);
			default:
				throw ADP.InvalidMissingMappingAction(mappingAction);
			}
		}

		// Token: 0x04001AD1 RID: 6865
		private List<DataColumnMapping> _items;
	}
}
