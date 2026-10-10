using System;
using System.Collections;
using System.ComponentModel;
using Unity;

namespace System.Data
{
	/// <summary>Содержит доступную только для чтения коллекцию объектов <see cref="T:System.Data.DataViewSetting" /> для каждого объекта <see cref="T:System.Data.DataTable" /> в <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x020000DD RID: 221
	public class DataViewSettingCollection : ICollection, IEnumerable
	{
		// Token: 0x06000DBD RID: 3517 RVA: 0x00037ADF File Offset: 0x00035CDF
		internal DataViewSettingCollection(DataViewManager dataViewManager)
		{
			this._list = new Hashtable();
			base..ctor();
			if (dataViewManager == null)
			{
				throw ExceptionBuilder.ArgumentNull("dataViewManager");
			}
			this._dataViewManager = dataViewManager;
		}

		/// <summary>Возвращает объекты <see cref="T:System.Data.DataViewSetting" /> указанного класса <see cref="T:System.Data.DataTable" /> из коллекции.</summary>
		/// <param name="table">Искомый объект <see cref="T:System.Data.DataTable" />.</param>
		/// <returns>Коллекция объектов <see cref="T:System.Data.DataViewSetting" />.</returns>
		// Token: 0x1700026A RID: 618
		public virtual DataViewSetting this[DataTable table]
		{
			get
			{
				if (table == null)
				{
					throw ExceptionBuilder.ArgumentNull("table");
				}
				DataViewSetting dataViewSetting = (DataViewSetting)this._list[table];
				if (dataViewSetting == null)
				{
					dataViewSetting = new DataViewSetting();
					this[table] = dataViewSetting;
				}
				return dataViewSetting;
			}
			set
			{
				if (table == null)
				{
					throw ExceptionBuilder.ArgumentNull("table");
				}
				value.SetDataViewManager(this._dataViewManager);
				value.SetDataTable(table);
				this._list[table] = value;
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00037B78 File Offset: 0x00035D78
		private DataTable GetTable(string tableName)
		{
			DataTable result = null;
			DataSet dataSet = this._dataViewManager.DataSet;
			if (dataSet != null)
			{
				result = dataSet.Tables[tableName];
			}
			return result;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00037BA4 File Offset: 0x00035DA4
		private DataTable GetTable(int index)
		{
			DataTable result = null;
			DataSet dataSet = this._dataViewManager.DataSet;
			if (dataSet != null)
			{
				result = dataSet.Tables[index];
			}
			return result;
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.DataViewSetting" /> класса <see cref="T:System.Data.DataTable" />, заданный по его имени.</summary>
		/// <param name="tableName">Имя объекта <see cref="T:System.Data.DataTable" />, который необходимо найти.</param>
		/// <returns>Коллекция объектов <see cref="T:System.Data.DataViewSetting" />.</returns>
		// Token: 0x1700026B RID: 619
		public virtual DataViewSetting this[string tableName]
		{
			get
			{
				DataTable table = this.GetTable(tableName);
				if (table != null)
				{
					return this[table];
				}
				return null;
			}
		}

		/// <summary>Возвращает объекты <see cref="T:System.Data.DataViewSetting" /> класса <see cref="T:System.Data.DataTable" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс объекта <see cref="T:System.Data.DataTable" />, который требуется найти.</param>
		/// <returns>Коллекция объектов <see cref="T:System.Data.DataViewSetting" />.</returns>
		// Token: 0x1700026C RID: 620
		public virtual DataViewSetting this[int index]
		{
			get
			{
				DataTable table = this.GetTable(index);
				if (table != null)
				{
					return this[table];
				}
				return null;
			}
			set
			{
				DataTable table = this.GetTable(index);
				if (table != null)
				{
					this[table] = value;
				}
			}
		}

		/// <summary>Копирует объекты коллекции в одномерный экземпляр класса <see cref="T:System.Array" />, начиная с указанного индекса.</summary>
		/// <param name="ar">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с которого требуется начать вставку.</param>
		// Token: 0x06000DC5 RID: 3525 RVA: 0x00037C38 File Offset: 0x00035E38
		public void CopyTo(Array ar, int index)
		{
			foreach (object value in this)
			{
				ar.SetValue(value, index++);
			}
		}

		/// <summary>Копирует объекты коллекции в одномерный экземпляр класса <see cref="T:System.Array" />, начиная с указанного индекса.</summary>
		/// <param name="ar">Одномерный объект <see cref="T:System.Array" />, являющийся целевым для значений, скопированных из коллекции.</param>
		/// <param name="index">Индекс в массиве, с которого требуется начать вставку.</param>
		// Token: 0x06000DC6 RID: 3526 RVA: 0x00037C68 File Offset: 0x00035E68
		public void CopyTo(DataViewSetting[] ar, int index)
		{
			foreach (object value in this)
			{
				ar.SetValue(value, index++);
			}
		}

		/// <summary>Возвращает количество объектов <see cref="T:System.Data.DataViewSetting" /> в коллекции <see cref="T:System.Data.DataViewSettingCollection" />.</summary>
		/// <returns>Количество объектов <see cref="T:System.Data.DataViewSetting" /> в коллекции.</returns>
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00037C98 File Offset: 0x00035E98
		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				DataSet dataSet = this._dataViewManager.DataSet;
				if (dataSet != null)
				{
					return dataSet.Tables.Count;
				}
				return 0;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" /> для коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06000DC8 RID: 3528 RVA: 0x00037CC1 File Offset: 0x00035EC1
		public IEnumerator GetEnumerator()
		{
			return new DataViewSettingCollection.DataViewSettingsEnumerator(this._dataViewManager);
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Data.DataViewSettingCollection" /> доступной только для чтения.</summary>
		/// <returns>Всегда возвращает <see langword="true" /> для указания коллекции только для чтения.</returns>
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00006D61 File Offset: 0x00004F61
		[Browsable(false)]
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение, определяющее, является ли доступ к коллекции <see cref="T:System.Data.DataViewSettingCollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Это свойство всегда имеет значение <see langword="false" />, если оно не переопределено производным классом.</returns>
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00006D64 File Offset: 0x00004F64
		[Browsable(false)]
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Data.DataViewSettingCollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Data.DataViewSettingCollection" />.</returns>
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00005696 File Offset: 0x00003896
		[Browsable(false)]
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00037CCE File Offset: 0x00035ECE
		internal void Remove(DataTable table)
		{
			this._list.Remove(table);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal DataViewSettingCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400085B RID: 2139
		private readonly DataViewManager _dataViewManager;

		// Token: 0x0400085C RID: 2140
		private readonly Hashtable _list;

		// Token: 0x020000DE RID: 222
		private sealed class DataViewSettingsEnumerator : IEnumerator
		{
			// Token: 0x06000DCE RID: 3534 RVA: 0x00037CDC File Offset: 0x00035EDC
			public DataViewSettingsEnumerator(DataViewManager dvm)
			{
				if (dvm.DataSet != null)
				{
					this._dataViewSettings = dvm.DataViewSettings;
					this._tableEnumerator = dvm.DataSet.Tables.GetEnumerator();
					return;
				}
				this._dataViewSettings = null;
				this._tableEnumerator = Array.Empty<DataTable>().GetEnumerator();
			}

			// Token: 0x06000DCF RID: 3535 RVA: 0x00037D31 File Offset: 0x00035F31
			public bool MoveNext()
			{
				return this._tableEnumerator.MoveNext();
			}

			// Token: 0x06000DD0 RID: 3536 RVA: 0x00037D3E File Offset: 0x00035F3E
			public void Reset()
			{
				this._tableEnumerator.Reset();
			}

			// Token: 0x17000271 RID: 625
			// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00037D4B File Offset: 0x00035F4B
			public object Current
			{
				get
				{
					return this._dataViewSettings[(DataTable)this._tableEnumerator.Current];
				}
			}

			// Token: 0x0400085D RID: 2141
			private DataViewSettingCollection _dataViewSettings;

			// Token: 0x0400085E RID: 2142
			private IEnumerator _tableEnumerator;
		}
	}
}
