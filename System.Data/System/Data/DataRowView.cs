using System;
using System.ComponentModel;
using Unity;

namespace System.Data
{
	/// <summary>Представляет настроенное представление <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x020000C8 RID: 200
	public class DataRowView : ICustomTypeDescriptor, IEditableObject, IDataErrorInfo, INotifyPropertyChanged
	{
		// Token: 0x06000C26 RID: 3110 RVA: 0x0003236B File Offset: 0x0003056B
		internal DataRowView(DataView dataView, DataRow row)
		{
			this._dataView = dataView;
			this._row = row;
		}

		/// <summary>Возвращает значение,указывающее, идентичен ли текущий объект <see cref="T:System.Data.DataRowView" /> указанному объекту.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" /> для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="object" /> является объектом <see cref="T:System.Data.DataRowView" /> и возвращает ту же строку, что и текущий объект <see cref="T:System.Data.DataRowView" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000C27 RID: 3111 RVA: 0x00032381 File Offset: 0x00030581
		public override bool Equals(object other)
		{
			return this == other;
		}

		/// <summary>Возвращает хэш-код объекта <see cref="T:System.Data.DataRow" />.</summary>
		/// <returns>Хэш-код (32-битное целое число со знаком) имеет значение 1, которое представляет логическое значение <see langword="true" />, если значение этого экземпляра является ненулевым; в противном случае целое число имеет значение 0, которое представляет логическое значение <see langword="false" />.</returns>
		// Token: 0x06000C28 RID: 3112 RVA: 0x00032387 File Offset: 0x00030587
		public override int GetHashCode()
		{
			return this.Row.GetHashCode();
		}

		/// <summary>Получает объект <see cref="T:System.Data.DataView" />, которому принадлежит эта строка.</summary>
		/// <returns>Объект <see langword="DataView" />, которому принадлежит эта строка.</returns>
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00032394 File Offset: 0x00030594
		public DataView DataView
		{
			get
			{
				return this._dataView;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0003239C File Offset: 0x0003059C
		internal int ObjectID
		{
			get
			{
				return this._row._objectID;
			}
		}

		/// <summary>Возвращает или задает значение в указанном столбце.</summary>
		/// <param name="ndx">Указанный столбец.</param>
		/// <returns>Значение столбца.</returns>
		// Token: 0x1700020E RID: 526
		public object this[int ndx]
		{
			get
			{
				return this.Row[ndx, this.RowVersionDefault];
			}
			set
			{
				if (!this._dataView.AllowEdit && !this.IsNew)
				{
					throw ExceptionBuilder.CanNotEdit();
				}
				this.SetColumnValue(this._dataView.Table.Columns[ndx], value);
			}
		}

		/// <summary>Возвращает или задает значение в указанном столбце.</summary>
		/// <param name="property">Строка, содержащая указанный столбец.</param>
		/// <returns>Значение столбца.</returns>
		// Token: 0x1700020F RID: 527
		public object this[string property]
		{
			get
			{
				DataColumn dataColumn = this._dataView.Table.Columns[property];
				if (dataColumn != null)
				{
					return this.Row[dataColumn, this.RowVersionDefault];
				}
				if (this._dataView.Table.DataSet != null && this._dataView.Table.DataSet.Relations.Contains(property))
				{
					return this.CreateChildView(property);
				}
				throw ExceptionBuilder.PropertyNotFound(property, this._dataView.Table.TableName);
			}
			set
			{
				DataColumn dataColumn = this._dataView.Table.Columns[property];
				if (dataColumn == null)
				{
					throw ExceptionBuilder.SetFailed(property);
				}
				if (!this._dataView.AllowEdit && !this.IsNew)
				{
					throw ExceptionBuilder.CanNotEdit();
				}
				this.SetColumnValue(dataColumn, value);
			}
		}

		/// <summary>Возвращает сообщение об ошибке для свойства с заданным именем.</summary>
		/// <param name="colName">Имя свойства, для которого возвращается сообщение об ошибке.</param>
		/// <returns>Сообщение об ошибке для свойства. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x17000210 RID: 528
		string IDataErrorInfo.this[string colName]
		{
			get
			{
				return this.Row.GetColumnError(colName);
			}
		}

		/// <summary>Получает сообщение, описывающее все ошибки проверки объекта.</summary>
		/// <returns>Ошибка проверки в объекте.</returns>
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x000324DF File Offset: 0x000306DF
		string IDataErrorInfo.Error
		{
			get
			{
				return this.Row.RowError;
			}
		}

		/// <summary>Получает описание текущей версии объекта <see cref="T:System.Data.DataRow" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.DataRowVersion" />. Возможными значения для свойства <see cref="P:System.Data.DataRowView.RowVersion" /> являются <see langword="Default" />, <see langword="Original" />, <see langword="Current" /> и <see langword="Proposed" />.</returns>
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000324EC File Offset: 0x000306EC
		public DataRowVersion RowVersion
		{
			get
			{
				return this.RowVersionDefault & (DataRowVersion)(-1025);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000324FA File Offset: 0x000306FA
		private DataRowVersion RowVersionDefault
		{
			get
			{
				return this.Row.GetDefaultRowVersion(this._dataView.RowStateFilter);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00032512 File Offset: 0x00030712
		internal int GetRecord()
		{
			return this.Row.GetRecordFromVersion(this.RowVersionDefault);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00032525 File Offset: 0x00030725
		internal bool HasRecord()
		{
			return this.Row.HasVersion(this.RowVersionDefault);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00032538 File Offset: 0x00030738
		internal object GetColumnValue(DataColumn column)
		{
			return this.Row[column, this.RowVersionDefault];
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0003254C File Offset: 0x0003074C
		internal void SetColumnValue(DataColumn column, object value)
		{
			if (this._delayBeginEdit)
			{
				this._delayBeginEdit = false;
				this.Row.BeginEdit();
			}
			if (DataRowVersion.Original == this.RowVersionDefault)
			{
				throw ExceptionBuilder.SetFailed(column.ColumnName);
			}
			this.Row[column] = value;
		}

		/// <summary>Возвращает <see cref="T:System.Data.DataView" /> для дочернего объекта <see cref="T:System.Data.DataTable" /> с указанным <see cref="T:System.Data.DataRelation" /> и родительским объектом.</summary>
		/// <param name="relation">Объект <see cref="T:System.Data.DataRelation" />.</param>
		/// <param name="followParent">Родительский объект.</param>
		/// <returns>Объект <see cref="T:System.Data.DataView" /> для дочернего объекта <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x06000C37 RID: 3127 RVA: 0x0003259C File Offset: 0x0003079C
		public DataView CreateChildView(DataRelation relation, bool followParent)
		{
			if (relation == null || relation.ParentKey.Table != this.DataView.Table)
			{
				throw ExceptionBuilder.CreateChildView();
			}
			RelatedView relatedView;
			if (!followParent)
			{
				int record = this.GetRecord();
				object[] keyValues = relation.ParentKey.GetKeyValues(record);
				relatedView = new RelatedView(relation.ChildColumnsReference, keyValues);
			}
			else
			{
				relatedView = new RelatedView(this, relation.ParentKey, relation.ChildColumnsReference);
			}
			relatedView.SetIndex("", DataViewRowState.CurrentRows, null);
			relatedView.SetDataViewManager(this.DataView.DataViewManager);
			return relatedView;
		}

		/// <summary>Возвращает <see cref="T:System.Data.DataView" /> для дочернего объекта <see cref="T:System.Data.DataTable" /> с указанным дочерним объектом <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relation">Объект <see cref="T:System.Data.DataRelation" />.</param>
		/// <returns>Объект <see cref="T:System.Data.DataView" /> для дочернего объекта <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x06000C38 RID: 3128 RVA: 0x00032629 File Offset: 0x00030829
		public DataView CreateChildView(DataRelation relation)
		{
			return this.CreateChildView(relation, false);
		}

		/// <summary>Возвращает <see cref="T:System.Data.DataView" /> для дочернего объекта <see cref="T:System.Data.DataTable" /> с указанным именем <see cref="T:System.Data.DataRelation" /> и родительским объектом.</summary>
		/// <param name="relationName">Строка, содержащая имя <see cref="T:System.Data.DataRelation" />.</param>
		/// <param name="followParent">Родительский объект</param>
		/// <returns>Объект <see cref="T:System.Data.DataView" /> для дочернего объекта <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x06000C39 RID: 3129 RVA: 0x00032633 File Offset: 0x00030833
		public DataView CreateChildView(string relationName, bool followParent)
		{
			return this.CreateChildView(this.DataView.Table.ChildRelations[relationName], followParent);
		}

		/// <summary>Возвращает <see cref="T:System.Data.DataView" /> для дочернего объекта <see cref="T:System.Data.DataTable" /> с указанным именем дочернего объекта <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relationName">Строка, содержащая имя <see cref="T:System.Data.DataRelation" />.</param>
		/// <returns>Объект <see cref="T:System.Data.DataView" /> для дочернего объекта <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x06000C3A RID: 3130 RVA: 0x00032652 File Offset: 0x00030852
		public DataView CreateChildView(string relationName)
		{
			return this.CreateChildView(relationName, false);
		}

		/// <summary>Получает просматриваемый объект <see cref="T:System.Data.DataRow" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataRow" />, просматриваемый в <see cref="T:System.Data.DataRowView" />.</returns>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0003265C File Offset: 0x0003085C
		public DataRow Row
		{
			get
			{
				return this._row;
			}
		}

		/// <summary>Начинает процедуру изменения.</summary>
		// Token: 0x06000C3C RID: 3132 RVA: 0x00032664 File Offset: 0x00030864
		public void BeginEdit()
		{
			this._delayBeginEdit = true;
		}

		/// <summary>Отменяет процедуру изменения.</summary>
		// Token: 0x06000C3D RID: 3133 RVA: 0x00032670 File Offset: 0x00030870
		public void CancelEdit()
		{
			DataRow row = this.Row;
			if (this.IsNew)
			{
				this._dataView.FinishAddNew(false);
			}
			else
			{
				row.CancelEdit();
			}
			this._delayBeginEdit = false;
		}

		/// <summary>Фиксирует изменения в базовом <see cref="T:System.Data.DataRow" /> и заканчивает сеанс редактирования, который был начат с <see cref="M:System.Data.DataRowView.BeginEdit" />.  Используйте метод <see cref="M:System.Data.DataRowView.CancelEdit" /> для отмены изменений, внесенных в объект <see cref="T:System.Data.DataRow" />.</summary>
		// Token: 0x06000C3E RID: 3134 RVA: 0x000326A7 File Offset: 0x000308A7
		public void EndEdit()
		{
			if (this.IsNew)
			{
				this._dataView.FinishAddNew(true);
			}
			else
			{
				this.Row.EndEdit();
			}
			this._delayBeginEdit = false;
		}

		/// <summary>Указывает, является ли новым объект <see cref="T:System.Data.DataRowView" />.</summary>
		/// <returns>Значение <see langword="true" />, если строка является новой; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x000326D1 File Offset: 0x000308D1
		public bool IsNew
		{
			get
			{
				return this._row == this._dataView._addNewRow;
			}
		}

		/// <summary>Определяет, находится ли строка в режиме изменения.</summary>
		/// <returns>Значение <see langword="true" />, если строка находится в режиме изменения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000326E6 File Offset: 0x000308E6
		public bool IsEdit
		{
			get
			{
				return this.Row.HasVersion(DataRowVersion.Proposed) || this._delayBeginEdit;
			}
		}

		/// <summary>Удаляет строку.</summary>
		// Token: 0x06000C41 RID: 3137 RVA: 0x00032702 File Offset: 0x00030902
		public void Delete()
		{
			this._dataView.Delete(this.Row);
		}

		/// <summary>Событие, которое возникло, когда свойство <see cref="T:System.Data.DataRowView" /> было изменено.</summary>
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000C42 RID: 3138 RVA: 0x00032718 File Offset: 0x00030918
		// (remove) Token: 0x06000C43 RID: 3139 RVA: 0x00032750 File Offset: 0x00030950
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000C44 RID: 3140 RVA: 0x00032785 File Offset: 0x00030985
		internal void RaisePropertyChangedEvent(string propName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs(propName));
		}

		/// <summary>Возвращает коллекцию настраиваемых атрибутов для этого экземпляра компонента.</summary>
		/// <returns>AttributeCollection, содержащая атрибуты для данного объекта.</returns>
		// Token: 0x06000C45 RID: 3141 RVA: 0x0003279E File Offset: 0x0003099E
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return new AttributeCollection(null);
		}

		/// <summary>Возвращает имя класса для этого экземпляра компонента.</summary>
		/// <returns>Имя класса для этого экземпляра компонента.</returns>
		// Token: 0x06000C46 RID: 3142 RVA: 0x00003E32 File Offset: 0x00002032
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		/// <summary>Возвращает имя этого экземпляра компонента.</summary>
		/// <returns>Имя этого экземпляра компонента.</returns>
		// Token: 0x06000C47 RID: 3143 RVA: 0x00003E32 File Offset: 0x00002032
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		/// <summary>Возвращает преобразователь типов для этого экземпляра компонента.</summary>
		/// <returns>Преобразователь типов для этого экземпляра компонента.</returns>
		// Token: 0x06000C48 RID: 3144 RVA: 0x00003E32 File Offset: 0x00002032
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		/// <summary>Возвращает событие по умолчанию для этого экземпляра компонента.</summary>
		/// <returns>Событие по умолчанию для этого экземпляра компонента.</returns>
		// Token: 0x06000C49 RID: 3145 RVA: 0x00003E32 File Offset: 0x00002032
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		/// <summary>Возвращает свойство по умолчанию для этого экземпляра компонента.</summary>
		/// <returns>Свойство по умолчанию для этого экземпляра компонента.</returns>
		// Token: 0x06000C4A RID: 3146 RVA: 0x00003E32 File Offset: 0x00002032
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		/// <summary>Возвращает редактор указанного типа для этого экземпляра компонента.</summary>
		/// <param name="editorBaseType">Объект <see cref="T:System.Type" />, который представляет редактор для этого объекта.</param>
		/// <returns>Объект <see cref="T:System.Object" /> заданного типа, являющийся редактором для этого объекта, или <see langword="null" />, если редактор не найден.</returns>
		// Token: 0x06000C4B RID: 3147 RVA: 0x00003E32 File Offset: 0x00002032
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		/// <summary>Возвращает события для этого экземпляра компонента.</summary>
		/// <returns>События для этого экземпляра компонента.</returns>
		// Token: 0x06000C4C RID: 3148 RVA: 0x000327A6 File Offset: 0x000309A6
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return new EventDescriptorCollection(null);
		}

		/// <summary>Возвращает события для этого экземпляра компонента с заданными атрибутами.</summary>
		/// <param name="attributes">Атрибуты</param>
		/// <returns>События для этого экземпляра компонента.</returns>
		// Token: 0x06000C4D RID: 3149 RVA: 0x000327A6 File Offset: 0x000309A6
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return new EventDescriptorCollection(null);
		}

		/// <summary>Возвращает свойства для этого экземпляра компонента.</summary>
		/// <returns>Свойства для этого экземпляра компонента.</returns>
		// Token: 0x06000C4E RID: 3150 RVA: 0x000327AE File Offset: 0x000309AE
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		/// <summary>Возвращает свойства для этого экземпляра компонента с заданными атрибутами.</summary>
		/// <param name="attributes">Атрибуты.</param>
		/// <returns>Свойства для этого экземпляра компонента.</returns>
		// Token: 0x06000C4F RID: 3151 RVA: 0x000327B7 File Offset: 0x000309B7
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			if (this._dataView.Table == null)
			{
				return DataRowView.s_zeroPropertyDescriptorCollection;
			}
			return this._dataView.Table.GetPropertyDescriptorCollection(attributes);
		}

		/// <summary>Возвращает объект, содержащий свойство, описанное указанным дескриптором свойства.</summary>
		/// <param name="pd">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющий свойство, владельца которого требуется найти.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий владельца заданного свойства.</returns>
		// Token: 0x06000C50 RID: 3152 RVA: 0x00005696 File Offset: 0x00003896
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal DataRowView()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040007F3 RID: 2035
		private readonly DataView _dataView;

		// Token: 0x040007F4 RID: 2036
		private readonly DataRow _row;

		// Token: 0x040007F5 RID: 2037
		private bool _delayBeginEdit;

		// Token: 0x040007F6 RID: 2038
		private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection = new PropertyDescriptorCollection(null);
	}
}
