using System;
using System.Collections;
using Unity;

namespace System.Data
{
	/// <summary>Представляет коллекцию строк для объекта <see cref="T:System.Data.DataTable" />.</summary>
	// Token: 0x020000C2 RID: 194
	public sealed class DataRowCollection : InternalDataCollectionBase
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x00031FFC File Offset: 0x000301FC
		internal DataRowCollection(DataTable table)
		{
			this._list = new DataRowCollection.DataRowTree();
			base..ctor();
			this._table = table;
		}

		/// <summary>Возвращает общее число объектов <see cref="T:System.Data.DataRow" /> в коллекции.</summary>
		/// <returns>Общее число объектов <see cref="T:System.Data.DataRow" /> в коллекции.</returns>
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00032016 File Offset: 0x00030216
		public override int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Возвращает строку по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс строки для возвращения.</param>
		/// <returns>Указанный <see cref="T:System.Data.DataRow" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение индекса больше числа элементов в коллекции.</exception>
		// Token: 0x1700020B RID: 523
		public DataRow this[int index]
		{
			get
			{
				return this._list[index];
			}
		}

		/// <summary>Добавляет заданный объект <see cref="T:System.Data.DataRow" /> в объект <see cref="T:System.Data.DataRowCollection" />.</summary>
		/// <param name="row">Добавляемый объект <see cref="T:System.Data.DataRow" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Строка имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Строка либо принадлежит другой таблице, либо уже принадлежит этой таблице.</exception>
		/// <exception cref="T:System.Data.ConstraintException">Добавление нарушает ограничение.</exception>
		/// <exception cref="T:System.Data.NoNullAllowedException">Добавление пытается поместить пустое значение в объект <see cref="T:System.Data.DataColumn" />, свойство <see cref="P:System.Data.DataColumn.AllowDBNull" /> которого имеет значение "false".</exception>
		// Token: 0x06000C06 RID: 3078 RVA: 0x00032031 File Offset: 0x00030231
		public void Add(DataRow row)
		{
			this._table.AddRow(row, -1);
		}

		/// <summary>Вставляет новую строку в коллекцию в указанное положение.</summary>
		/// <param name="row">Добавляемый объект <see cref="T:System.Data.DataRow" />.</param>
		/// <param name="pos">Отсчитываемое от нуля расположение в коллекции, куда необходимо добавить строку <see langword="DataRow" />.</param>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="pos" /> меньше 0.</exception>
		// Token: 0x06000C07 RID: 3079 RVA: 0x00032040 File Offset: 0x00030240
		public void InsertAt(DataRow row, int pos)
		{
			if (pos < 0)
			{
				throw ExceptionBuilder.RowInsertOutOfRange(pos);
			}
			if (pos >= this._list.Count)
			{
				this._table.AddRow(row, -1);
				return;
			}
			this._table.InsertRow(row, -1, pos);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00032078 File Offset: 0x00030278
		internal void DiffInsertAt(DataRow row, int pos)
		{
			if (pos < 0 || pos == this._list.Count)
			{
				this._table.AddRow(row, (pos > -1) ? (pos + 1) : -1);
				return;
			}
			if (this._table.NestedParentRelations.Length == 0)
			{
				this._table.InsertRow(row, pos + 1, (pos > this._list.Count) ? -1 : pos);
				return;
			}
			if (pos >= this._list.Count)
			{
				while (pos > this._list.Count)
				{
					this._list.Add(null);
					this._nullInList++;
				}
				this._table.AddRow(row, pos + 1);
				return;
			}
			if (this._list[pos] != null)
			{
				throw ExceptionBuilder.RowInsertTwice(pos, this._table.TableName);
			}
			this._list.RemoveAt(pos);
			this._nullInList--;
			this._table.InsertRow(row, pos + 1, pos);
		}

		/// <summary>Возвращает индекс указанного объекта <see cref="T:System.Data.DataRow" />.</summary>
		/// <param name="row">Объект <see langword="DataRow" />, который требуется найти.</param>
		/// <returns>Отсчитываемый от нуля индекс строки или значение -1, если строка не найдена в коллекции.</returns>
		// Token: 0x06000C09 RID: 3081 RVA: 0x00032172 File Offset: 0x00030372
		public int IndexOf(DataRow row)
		{
			if (row != null && row.Table == this._table && (row.RBTreeNodeId != 0 || row.RowState != DataRowState.Detached))
			{
				return this._list.IndexOf(row.RBTreeNodeId, row);
			}
			return -1;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000321AC File Offset: 0x000303AC
		internal DataRow AddWithColumnEvents(params object[] values)
		{
			DataRow dataRow = this._table.NewRow(-1);
			dataRow.ItemArray = values;
			this._table.AddRow(dataRow, -1);
			return dataRow;
		}

		/// <summary>Создает строку с использованием заданных параметров и добавляет его в <see cref="T:System.Data.DataRowCollection" />.</summary>
		/// <param name="values">Массив значений, который используются для создания новой строки.</param>
		/// <returns>Отсутствует.</returns>
		/// <exception cref="T:System.ArgumentException">Размер массива превышает число столбцов в таблице.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение не соответствует соответствующему типу столбца.</exception>
		/// <exception cref="T:System.Data.ConstraintException">Добавление строки нарушает ограничение.</exception>
		/// <exception cref="T:System.Data.NoNullAllowedException">Попытка поместить значение NULL в столбец, где <see cref="P:System.Data.DataColumn.AllowDBNull" /> имеет значение "false".</exception>
		// Token: 0x06000C0B RID: 3083 RVA: 0x000321DC File Offset: 0x000303DC
		public DataRow Add(params object[] values)
		{
			int record = this._table.NewRecordFromArray(values);
			DataRow dataRow = this._table.NewRow(record);
			this._table.AddRow(dataRow, -1);
			return dataRow;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00032211 File Offset: 0x00030411
		internal void ArrayAdd(DataRow row)
		{
			row.RBTreeNodeId = this._list.Add(row);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00032225 File Offset: 0x00030425
		internal void ArrayInsert(DataRow row, int pos)
		{
			row.RBTreeNodeId = this._list.Insert(pos, row);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0003223A File Offset: 0x0003043A
		internal void ArrayClear()
		{
			this._list.Clear();
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00032247 File Offset: 0x00030447
		internal void ArrayRemove(DataRow row)
		{
			if (row.RBTreeNodeId == 0)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.AttachedNodeWithZerorbTreeNodeId);
			}
			this._list.RBDelete(row.RBTreeNodeId);
			row.RBTreeNodeId = 0;
		}

		/// <summary>Возвращает строку, указанную значением первичного ключа.</summary>
		/// <param name="key">Значение первичного ключа <see cref="T:System.Data.DataRow" /> для поиска.</param>
		/// <returns>Объект <see cref="T:System.Data.DataRow" />, содержащий указанное значение первичного ключа; в противном случае — значение NULL, если значение первичного ключа не существует в <see cref="T:System.Data.DataRowCollection" />.</returns>
		/// <exception cref="T:System.Data.MissingPrimaryKeyException">Таблица не имеет первичного ключа.</exception>
		// Token: 0x06000C10 RID: 3088 RVA: 0x00032272 File Offset: 0x00030472
		public DataRow Find(object key)
		{
			return this._table.FindByPrimaryKey(key);
		}

		/// <summary>Возвращает строку, которая содержит указанные значения первичного ключа.</summary>
		/// <param name="keys">Массив значений первичного ключа для поиска. Тип массива — <see langword="Object" />.</param>
		/// <returns>Объект <see cref="T:System.Data.DataRow" />, содержащий указанные значения первичного ключа; в противном случае — значение NULL, если значение первичного ключа отсутствует в <see cref="T:System.Data.DataRowCollection" />.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Этому значению индекса не соответствуют никакие строки.</exception>
		/// <exception cref="T:System.Data.MissingPrimaryKeyException">Таблица не имеет первичного ключа.</exception>
		// Token: 0x06000C11 RID: 3089 RVA: 0x00032280 File Offset: 0x00030480
		public DataRow Find(object[] keys)
		{
			return this._table.FindByPrimaryKey(keys);
		}

		/// <summary>Удаляет все строки из коллекции.</summary>
		/// <exception cref="T:System.Data.InvalidConstraintException">Свойство <see cref="T:System.Data.ForeignKeyConstraint" /> применяется для объекта <see cref="T:System.Data.DataRowCollection" />.</exception>
		// Token: 0x06000C12 RID: 3090 RVA: 0x0003228E File Offset: 0x0003048E
		public void Clear()
		{
			this._table.Clear(false);
		}

		/// <summary>Возвращает значение, которое указывает, содержит ли первичный ключ любой из строк в коллекции указанное значение.</summary>
		/// <param name="key">Значение первичного ключа для проверки.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит <see cref="T:System.Data.DataRow" /> с указанным значением первичного ключа; в противном случае — значение<see langword="false" />.</returns>
		/// <exception cref="T:System.Data.MissingPrimaryKeyException">Таблица не имеет первичного ключа.</exception>
		// Token: 0x06000C13 RID: 3091 RVA: 0x0003229C File Offset: 0x0003049C
		public bool Contains(object key)
		{
			return this._table.FindByPrimaryKey(key) != null;
		}

		/// <summary>Возвращает значение, которое указывает, содержат ли столбцы первичного ключа любой из строк в коллекции значение, указанное в массиве объектов.</summary>
		/// <param name="keys">Массив значений первичного ключа для проверки.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.DataRowCollection" /> содержит <see cref="T:System.Data.DataRow" /> с указанным значением ключа; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Data.MissingPrimaryKeyException">Таблица не имеет первичного ключа.</exception>
		// Token: 0x06000C14 RID: 3092 RVA: 0x000322AD File Offset: 0x000304AD
		public bool Contains(object[] keys)
		{
			return this._table.FindByPrimaryKey(keys) != null;
		}

		/// <summary>Копирует все объекты <see cref="T:System.Data.DataRow" /> из этой коллекции в заданный целевой массив, начиная с указанного индекса.</summary>
		/// <param name="ar">Одномерный массив, в который копируются элементы из коллекции <see langword="DataRowCollection" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Индекс (отсчет с нуля) в массиве, с которого начинается копирование.</param>
		// Token: 0x06000C15 RID: 3093 RVA: 0x000322BE File Offset: 0x000304BE
		public override void CopyTo(Array ar, int index)
		{
			this._list.CopyTo(ar, index);
		}

		/// <summary>Копирует все объекты <see cref="T:System.Data.DataRow" /> из этой коллекции в заданный целевой массив, начиная с указанного индекса.</summary>
		/// <param name="array">Одномерный массив, в который копируются элементы из коллекции <see langword="DataRowCollection" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Индекс (отсчет с нуля) в массиве, с которого начинается копирование.</param>
		// Token: 0x06000C16 RID: 3094 RVA: 0x000322CD File Offset: 0x000304CD
		public void CopyTo(DataRow[] array, int index)
		{
			this._list.CopyTo(array, index);
		}

		/// <summary>Возвращает <see cref="T:System.Collections.IEnumerator" /> для этой коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" /> для коллекции.</returns>
		// Token: 0x06000C17 RID: 3095 RVA: 0x000322DC File Offset: 0x000304DC
		public override IEnumerator GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Data.DataRow" /> из коллекции.</summary>
		/// <param name="row">Объект <see cref="T:System.Data.DataRow" /> для удаления.</param>
		// Token: 0x06000C18 RID: 3096 RVA: 0x000322EC File Offset: 0x000304EC
		public void Remove(DataRow row)
		{
			if (row == null || row.Table != this._table || -1L == row.rowID)
			{
				throw ExceptionBuilder.RowOutOfRange();
			}
			if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
			{
				row.Delete();
			}
			if (row.RowState != DataRowState.Detached)
			{
				row.AcceptChanges();
			}
		}

		/// <summary>Удаляет строку по указанному индексу из коллекции.</summary>
		/// <param name="index">Индекс строки для удаления.</param>
		// Token: 0x06000C19 RID: 3097 RVA: 0x00032341 File Offset: 0x00030541
		public void RemoveAt(int index)
		{
			this.Remove(this[index]);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal DataRowCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040007E5 RID: 2021
		private readonly DataTable _table;

		// Token: 0x040007E6 RID: 2022
		private readonly DataRowCollection.DataRowTree _list;

		// Token: 0x040007E7 RID: 2023
		internal int _nullInList;

		// Token: 0x020000C3 RID: 195
		private sealed class DataRowTree : RBTree<DataRow>
		{
			// Token: 0x06000C1B RID: 3099 RVA: 0x00032350 File Offset: 0x00030550
			internal DataRowTree() : base(TreeAccessMethod.INDEX_ONLY)
			{
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x00032359 File Offset: 0x00030559
			protected override int CompareNode(DataRow record1, DataRow record2)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.CompareNodeInDataRowTree);
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x00032362 File Offset: 0x00030562
			protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2)
			{
				throw ExceptionBuilder.InternalRBTreeError(RBTreeError.CompareSateliteTreeNodeInDataRowTree);
			}
		}
	}
}
