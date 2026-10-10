using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Threading;

namespace System.Data
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Data.DataRelation" /> для <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x020000B9 RID: 185
	[DefaultEvent("CollectionChanged")]
	[DefaultProperty("Table")]
	public abstract class DataRelationCollection : InternalDataCollectionBase
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0002F6F9 File Offset: 0x0002D8F9
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.DataRelation" /> по указанному индексу.</summary>
		/// <param name="index">Индекс для поиска (индексация ведется от нуля).</param>
		/// <returns>Отношение <see cref="T:System.Data.DataRelation" /> или значение null, если указанное отношение <see cref="T:System.Data.DataRelation" /> не существует.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение индекса больше числа элементов в коллекции.</exception>
		// Token: 0x170001EC RID: 492
		public abstract DataRelation this[int index]
		{
			get;
		}

		/// <summary>Получает объект <see cref="T:System.Data.DataRelation" />, указанный именем.</summary>
		/// <param name="name">Имя отношения для поиска.</param>
		/// <returns>Именованное отношение <see cref="T:System.Data.DataRelation" /> или значение null, если указанное отношение <see cref="T:System.Data.DataRelation" /> не существует.</returns>
		// Token: 0x170001ED RID: 493
		public abstract DataRelation this[string name]
		{
			get;
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.DataRelation" /> в коллекцию <see cref="T:System.Data.DataRelationCollection" />.</summary>
		/// <param name="relation">Параметр <see langword="DataRelation" /> для добавления в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="relation" /> имеет нулевое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Соотношение уже принадлежит данной коллекции, или оно принадлежит другой коллекции.</exception>
		/// <exception cref="T:System.Data.DuplicateNameException">Коллекция уже содержит отношение с указанным именем. (Сравнение выполняется без учета регистра).</exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">Отношение перешло в недопустимое состояние со времени создания.</exception>
		// Token: 0x06000B58 RID: 2904 RVA: 0x0002F704 File Offset: 0x0002D904
		public void Add(DataRelation relation)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int>("<ds.DataRelationCollection.Add|API> {0}, relation={1}", this.ObjectID, (relation != null) ? relation.ObjectID : 0);
			try
			{
				if (this._inTransition != relation)
				{
					this._inTransition = relation;
					try
					{
						this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, relation));
						this.AddCore(relation);
						this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, relation));
					}
					finally
					{
						this._inTransition = null;
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Копирует элементы указанного массива <see cref="T:System.Data.DataRelation" /> в конец коллекции.</summary>
		/// <param name="relations">Массив объектов <see cref="T:System.Data.DataRelation" />, добавляемый в коллекцию.</param>
		// Token: 0x06000B59 RID: 2905 RVA: 0x0002F798 File Offset: 0x0002D998
		public virtual void AddRange(DataRelation[] relations)
		{
			if (relations != null)
			{
				foreach (DataRelation dataRelation in relations)
				{
					if (dataRelation != null)
					{
						this.Add(dataRelation);
					}
				}
			}
		}

		/// <summary>Создает <see cref="T:System.Data.DataRelation" /> с указанным именем и массивами родительских и дочерних столбцов и добавляет их к коллекции.</summary>
		/// <param name="name">Имя создаваемого элемента <see langword="DataRelation" />.</param>
		/// <param name="parentColumns">Массив родительских объектов <see cref="T:System.Data.DataColumn" />.</param>
		/// <param name="childColumns">Массив дочерних объектов <see langword="DataColumn" />.</param>
		/// <returns>Созданный <see langword="DataRelation" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Имя отношения имеет нулевое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Соотношение уже принадлежит данной коллекции, или оно принадлежит другой коллекции.</exception>
		/// <exception cref="T:System.Data.DuplicateNameException">Коллекция уже содержит отношение с тем же именем. (Сравнение выполняется без учета регистра).</exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">Отношение перешло в недопустимое состояние со времени создания.</exception>
		// Token: 0x06000B5A RID: 2906 RVA: 0x0002F7C8 File Offset: 0x0002D9C8
		public virtual DataRelation Add(string name, DataColumn[] parentColumns, DataColumn[] childColumns)
		{
			DataRelation dataRelation = new DataRelation(name, parentColumns, childColumns);
			this.Add(dataRelation);
			return dataRelation;
		}

		/// <summary>Создает <see cref="T:System.Data.DataRelation" /> с указанным именем, массивами родительских и дочерних столбцов и значение, указывающее, создавать ли ограничения, и добавляет их к коллекции.</summary>
		/// <param name="name">Имя создаваемого элемента <see langword="DataRelation" />.</param>
		/// <param name="parentColumns">Массив родительских объектов <see cref="T:System.Data.DataColumn" />.</param>
		/// <param name="childColumns">Массив дочерних объектов <see langword="DataColumn" />.</param>
		/// <param name="createConstraints">
		///   <see langword="true" /> для создания ограничения; в противном случае — <see langword="false" />.</param>
		/// <returns>Созданное соотношение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Имя отношения имеет нулевое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Соотношение уже принадлежит данной коллекции, или оно принадлежит другой коллекции.</exception>
		/// <exception cref="T:System.Data.DuplicateNameException">Коллекция уже содержит отношение с тем же именем. (Сравнение выполняется без учета регистра).</exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">Отношение перешло в недопустимое состояние со времени создания.</exception>
		// Token: 0x06000B5B RID: 2907 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		public virtual DataRelation Add(string name, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints)
		{
			DataRelation dataRelation = new DataRelation(name, parentColumns, childColumns, createConstraints);
			this.Add(dataRelation);
			return dataRelation;
		}

		/// <summary>Создает <see cref="T:System.Data.DataRelation" /> с указанными родительским и дочерним столбцами и добавляет их к коллекции.</summary>
		/// <param name="parentColumns">Родительские столбцы отношения.</param>
		/// <param name="childColumns">Дочерние столбцы отношения.</param>
		/// <returns>Созданное соотношение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="relation" /> имеет значение null.</exception>
		/// <exception cref="T:System.ArgumentException">Соотношение уже принадлежит данной коллекции, или оно принадлежит другой коллекции.</exception>
		/// <exception cref="T:System.Data.DuplicateNameException">Коллекция уже содержит отношение с тем же именем. (Сравнение выполняется без учета регистра).</exception>
		/// <exception cref="T:System.Data.InvalidConstraintException">Отношение перешло в недопустимое состояние со времени создания.</exception>
		// Token: 0x06000B5C RID: 2908 RVA: 0x0002F808 File Offset: 0x0002DA08
		public virtual DataRelation Add(DataColumn[] parentColumns, DataColumn[] childColumns)
		{
			DataRelation dataRelation = new DataRelation(null, parentColumns, childColumns);
			this.Add(dataRelation);
			return dataRelation;
		}

		/// <summary>Создает отношение <see cref="T:System.Data.DataRelation" /> с указанным именем и родительским и дочерним столбцами и добавляет их к коллекции.</summary>
		/// <param name="name">Имя отношения.</param>
		/// <param name="parentColumn">Родительский столбец отношения.</param>
		/// <param name="childColumn">Дочерний столбец отношения.</param>
		/// <returns>Созданное соотношение.</returns>
		// Token: 0x06000B5D RID: 2909 RVA: 0x0002F828 File Offset: 0x0002DA28
		public virtual DataRelation Add(string name, DataColumn parentColumn, DataColumn childColumn)
		{
			DataRelation dataRelation = new DataRelation(name, parentColumn, childColumn);
			this.Add(dataRelation);
			return dataRelation;
		}

		/// <summary>Создает отношение <see cref="T:System.Data.DataRelation" /> с указанным именем, родительскими и дочерними столбцами, с необязательными ограничениями в соответствии со значением параметра <paramref name="createConstraints" />, затем добавляет это отношение в коллекцию.</summary>
		/// <param name="name">Имя отношения.</param>
		/// <param name="parentColumn">Родительский столбец отношения.</param>
		/// <param name="childColumn">Дочерний столбец отношения.</param>
		/// <param name="createConstraints">
		///   <see langword="true" /> для создания ограничений; в противном случае — <see langword="false" />. (Значением по умолчанию является <see langword="true" />).</param>
		/// <returns>Созданное соотношение.</returns>
		// Token: 0x06000B5E RID: 2910 RVA: 0x0002F848 File Offset: 0x0002DA48
		public virtual DataRelation Add(string name, DataColumn parentColumn, DataColumn childColumn, bool createConstraints)
		{
			DataRelation dataRelation = new DataRelation(name, parentColumn, childColumn, createConstraints);
			this.Add(dataRelation);
			return dataRelation;
		}

		/// <summary>Создает <see cref="T:System.Data.DataRelation" /> с указанными родительским и дочерним столбцами и добавляет их к коллекции.</summary>
		/// <param name="parentColumn">Родительский столбец отношения.</param>
		/// <param name="childColumn">Дочерний столбец отношения.</param>
		/// <returns>Созданное соотношение.</returns>
		// Token: 0x06000B5F RID: 2911 RVA: 0x0002F868 File Offset: 0x0002DA68
		public virtual DataRelation Add(DataColumn parentColumn, DataColumn childColumn)
		{
			DataRelation dataRelation = new DataRelation(null, parentColumn, childColumn);
			this.Add(dataRelation);
			return dataRelation;
		}

		/// <summary>Выполняет проверку таблицы.</summary>
		/// <param name="relation">Отношение для проверки.</param>
		/// <exception cref="T:System.ArgumentNullException">Значением отношения является null.</exception>
		/// <exception cref="T:System.ArgumentException">Соотношение уже принадлежит данной коллекции, или оно принадлежит другой коллекции.</exception>
		/// <exception cref="T:System.Data.DuplicateNameException">Коллекция уже содержит отношение с тем же именем. (Сравнение выполняется без учета регистра).</exception>
		// Token: 0x06000B60 RID: 2912 RVA: 0x0002F888 File Offset: 0x0002DA88
		protected virtual void AddCore(DataRelation relation)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataRelationCollection.AddCore|INFO> {0}, relation={1}", this.ObjectID, (relation != null) ? relation.ObjectID : 0);
			if (relation == null)
			{
				throw ExceptionBuilder.ArgumentNull("relation");
			}
			relation.CheckState();
			DataSet dataSet = this.GetDataSet();
			if (relation.DataSet == dataSet)
			{
				throw ExceptionBuilder.RelationAlreadyInTheDataSet();
			}
			if (relation.DataSet != null)
			{
				throw ExceptionBuilder.RelationAlreadyInOtherDataSet();
			}
			if (relation.ChildTable.Locale.LCID != relation.ParentTable.Locale.LCID || relation.ChildTable.CaseSensitive != relation.ParentTable.CaseSensitive)
			{
				throw ExceptionBuilder.CaseLocaleMismatch();
			}
			if (relation.Nested)
			{
				relation.CheckNamespaceValidityForNestedRelations(relation.ParentTable.Namespace);
				relation.ValidateMultipleNestedRelations();
				DataTable parentTable = relation.ParentTable;
				int elementColumnCount = parentTable.ElementColumnCount;
				parentTable.ElementColumnCount = elementColumnCount + 1;
			}
		}

		/// <summary>Происходит при изменении коллекции.</summary>
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000B61 RID: 2913 RVA: 0x0002F962 File Offset: 0x0002DB62
		// (remove) Token: 0x06000B62 RID: 2914 RVA: 0x0002F990 File Offset: 0x0002DB90
		public event CollectionChangeEventHandler CollectionChanged
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.add_CollectionChanged|API> {0}", this.ObjectID);
				this._onCollectionChangedDelegate = (CollectionChangeEventHandler)Delegate.Combine(this._onCollectionChangedDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.remove_CollectionChanged|API> {0}", this.ObjectID);
				this._onCollectionChangedDelegate = (CollectionChangeEventHandler)Delegate.Remove(this._onCollectionChangedDelegate, value);
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000B63 RID: 2915 RVA: 0x0002F9BE File Offset: 0x0002DBBE
		// (remove) Token: 0x06000B64 RID: 2916 RVA: 0x0002F9EC File Offset: 0x0002DBEC
		internal event CollectionChangeEventHandler CollectionChanging
		{
			add
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.add_CollectionChanging|INFO> {0}", this.ObjectID);
				this._onCollectionChangingDelegate = (CollectionChangeEventHandler)Delegate.Combine(this._onCollectionChangingDelegate, value);
			}
			remove
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.remove_CollectionChanging|INFO> {0}", this.ObjectID);
				this._onCollectionChangingDelegate = (CollectionChangeEventHandler)Delegate.Remove(this._onCollectionChangingDelegate, value);
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0002FA1A File Offset: 0x0002DC1A
		internal string AssignName()
		{
			string result = this.MakeName(this._defaultNameIndex);
			this._defaultNameIndex++;
			return result;
		}

		/// <summary>Удаляет отношения из коллекции.</summary>
		// Token: 0x06000B66 RID: 2918 RVA: 0x0002FA38 File Offset: 0x0002DC38
		public virtual void Clear()
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<ds.DataRelationCollection.Clear|API> {0}", this.ObjectID);
			try
			{
				int count = this.Count;
				this.OnCollectionChanging(InternalDataCollectionBase.s_refreshEventArgs);
				for (int i = count - 1; i >= 0; i--)
				{
					this._inTransition = this[i];
					this.RemoveCore(this._inTransition);
				}
				this.OnCollectionChanged(InternalDataCollectionBase.s_refreshEventArgs);
				this._inTransition = null;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		/// <summary>Проверяет, существует ли в коллекции <see cref="T:System.Data.DataRelation" /> с указанным именем (без учета регистра).</summary>
		/// <param name="name">Имя отношения для поиска.</param>
		/// <returns>
		///   <see langword="true" />, если отношение с указанным именем существует; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000B67 RID: 2919 RVA: 0x0002FAC4 File Offset: 0x0002DCC4
		public virtual bool Contains(string name)
		{
			return this.InternalIndexOf(name) >= 0;
		}

		/// <summary>Копирует коллекцию объектов <see cref="T:System.Data.DataRelation" />, начиная с указанного индекса.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.Data.DataRelation" />, в который следует скопировать коллекцию.</param>
		/// <param name="index">Начальный индекс.</param>
		// Token: 0x06000B68 RID: 2920 RVA: 0x0002FAD4 File Offset: 0x0002DCD4
		public void CopyTo(DataRelation[] array, int index)
		{
			if (array == null)
			{
				throw ExceptionBuilder.ArgumentNull("array");
			}
			if (index < 0)
			{
				throw ExceptionBuilder.ArgumentOutOfRange("index");
			}
			ArrayList list = this.List;
			if (array.Length - index < list.Count)
			{
				throw ExceptionBuilder.InvalidOffsetLength();
			}
			for (int i = 0; i < list.Count; i++)
			{
				array[index + i] = (DataRelation)list[i];
			}
		}

		/// <summary>Возвращает индекс указанного объекта <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relation">Отношение, которое нужно найти.</param>
		/// <returns>Начинающийся с нуля индекс отношения или значение -1, если отношение не найдено в коллекции.</returns>
		// Token: 0x06000B69 RID: 2921 RVA: 0x0002FB3C File Offset: 0x0002DD3C
		public virtual int IndexOf(DataRelation relation)
		{
			int count = this.List.Count;
			for (int i = 0; i < count; i++)
			{
				if (relation == (DataRelation)this.List[i])
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Получает индекс ограничения <see cref="T:System.Data.DataRelation" />, заданного по имени.</summary>
		/// <param name="relationName">Имя отношения для поиска.</param>
		/// <returns>Индекс (индексация ведется от нуля) отношения с заданным именем или -1, если отношение не существует в коллекции.</returns>
		// Token: 0x06000B6A RID: 2922 RVA: 0x0002FB78 File Offset: 0x0002DD78
		public virtual int IndexOf(string relationName)
		{
			int num = this.InternalIndexOf(relationName);
			if (num >= 0)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0002FB94 File Offset: 0x0002DD94
		internal int InternalIndexOf(string name)
		{
			int num = -1;
			if (name != null && 0 < name.Length)
			{
				int count = this.List.Count;
				for (int i = 0; i < count; i++)
				{
					DataRelation dataRelation = (DataRelation)this.List[i];
					int num2 = base.NamesEqual(dataRelation.RelationName, name, false, this.GetDataSet().Locale);
					if (num2 == 1)
					{
						return i;
					}
					if (num2 == -1)
					{
						num = ((num == -1) ? i : -2);
					}
				}
			}
			return num;
		}

		/// <summary>Этот метод поддерживает инфраструктуру .NET Framework и не предназначен для использования непосредственно из программного кода.</summary>
		/// <returns>Набор данных DataSet, на который указывает ссылка.</returns>
		// Token: 0x06000B6C RID: 2924
		protected abstract DataSet GetDataSet();

		// Token: 0x06000B6D RID: 2925 RVA: 0x0002FC0C File Offset: 0x0002DE0C
		private string MakeName(int index)
		{
			if (index != 1)
			{
				return "Relation" + index.ToString(CultureInfo.InvariantCulture);
			}
			return "Relation1";
		}

		/// <summary>Вызывает событие <see cref="E:System.Data.DataRelationCollection.CollectionChanged" />.</summary>
		/// <param name="ccevent">Объект <see cref="T:System.ComponentModel.CollectionChangeEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000B6E RID: 2926 RVA: 0x0002FC2E File Offset: 0x0002DE2E
		protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
			if (this._onCollectionChangedDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.OnCollectionChanged|INFO> {0}", this.ObjectID);
				this._onCollectionChangedDelegate(this, ccevent);
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.Data.DataRelationCollection.CollectionChanged" />.</summary>
		/// <param name="ccevent">Объект <see cref="T:System.ComponentModel.CollectionChangeEventArgs" />, содержащий данные события.</param>
		// Token: 0x06000B6F RID: 2927 RVA: 0x0002FC5A File Offset: 0x0002DE5A
		protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
			if (this._onCollectionChangingDelegate != null)
			{
				DataCommonEventSource.Log.Trace<int>("<ds.DataRelationCollection.OnCollectionChanging|INFO> {0}", this.ObjectID);
				this._onCollectionChangingDelegate(this, ccevent);
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0002FC88 File Offset: 0x0002DE88
		internal void RegisterName(string name)
		{
			DataCommonEventSource.Log.Trace<int, string>("<ds.DataRelationCollection.RegisterName|INFO> {0}, name='{1}'", this.ObjectID, name);
			CultureInfo locale = this.GetDataSet().Locale;
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				if (base.NamesEqual(name, this[i].RelationName, true, locale) != 0)
				{
					throw ExceptionBuilder.DuplicateRelation(this[i].RelationName);
				}
			}
			if (base.NamesEqual(name, this.MakeName(this._defaultNameIndex), true, locale) != 0)
			{
				this._defaultNameIndex++;
			}
		}

		/// <summary>Проверяет, может ли быть удалено из коллекции указанное <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relation">Отношение для выполнения проверки.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Data.DataRelation" /> может быть удалено; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000B71 RID: 2929 RVA: 0x0002FD18 File Offset: 0x0002DF18
		public virtual bool CanRemove(DataRelation relation)
		{
			return relation != null && relation.DataSet == this.GetDataSet();
		}

		/// <summary>Удаляет указанное отношение из коллекции.</summary>
		/// <param name="relation">Отношение для удаления.</param>
		/// <exception cref="T:System.ArgumentNullException">Имя отношения имеет нулевое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Отношение не принадлежит коллекции.</exception>
		// Token: 0x06000B72 RID: 2930 RVA: 0x0002FD30 File Offset: 0x0002DF30
		public void Remove(DataRelation relation)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataRelationCollection.Remove|API> {0}, relation={1}", this.ObjectID, (relation != null) ? relation.ObjectID : 0);
			if (this._inTransition == relation)
			{
				return;
			}
			this._inTransition = relation;
			try
			{
				this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Remove, relation));
				this.RemoveCore(relation);
				this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, relation));
			}
			finally
			{
				this._inTransition = null;
			}
		}

		/// <summary>Удаляет отношение с указанным индексом из коллекции.</summary>
		/// <param name="index">Индекс столбца для удаления.</param>
		/// <exception cref="T:System.ArgumentException">Коллекция не содержит отношение с указанным индексом.</exception>
		// Token: 0x06000B73 RID: 2931 RVA: 0x0002FDAC File Offset: 0x0002DFAC
		public void RemoveAt(int index)
		{
			DataRelation dataRelation = this[index];
			if (dataRelation == null)
			{
				throw ExceptionBuilder.RelationOutOfRange(index);
			}
			this.Remove(dataRelation);
		}

		/// <summary>Отношение с указанным именем удаляется из коллекции.</summary>
		/// <param name="name">Имя столбца для удаления.</param>
		/// <exception cref="T:System.IndexOutOfRangeException">В коллекции нет отношения с указанным именем.</exception>
		// Token: 0x06000B74 RID: 2932 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		public void Remove(string name)
		{
			DataRelation dataRelation = this[name];
			if (dataRelation == null)
			{
				throw ExceptionBuilder.RelationNotInTheDataSet(name);
			}
			this.Remove(dataRelation);
		}

		/// <summary>Выполняет проверку указанного объекта <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relation">Объект <see langword="DataRelation" /> для проверки.</param>
		/// <exception cref="T:System.ArgumentNullException">Коллекция не содержит отношение с указанным индексом.</exception>
		/// <exception cref="T:System.ArgumentException">Указанное отношение не принадлежит данной коллекции, или оно принадлежит другой коллекции.</exception>
		// Token: 0x06000B75 RID: 2933 RVA: 0x0002FE00 File Offset: 0x0002E000
		protected virtual void RemoveCore(DataRelation relation)
		{
			DataCommonEventSource.Log.Trace<int, int>("<ds.DataRelationCollection.RemoveCore|INFO> {0}, relation={1}", this.ObjectID, (relation != null) ? relation.ObjectID : 0);
			if (relation == null)
			{
				throw ExceptionBuilder.ArgumentNull("relation");
			}
			DataSet dataSet = this.GetDataSet();
			if (relation.DataSet != dataSet)
			{
				throw ExceptionBuilder.RelationNotInTheDataSet(relation.RelationName);
			}
			if (relation.Nested)
			{
				DataTable parentTable = relation.ParentTable;
				int elementColumnCount = parentTable.ElementColumnCount;
				parentTable.ElementColumnCount = elementColumnCount - 1;
				relation.ParentTable.Columns.UnregisterName(relation.ChildTable.TableName);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0002FE90 File Offset: 0x0002E090
		internal void UnregisterName(string name)
		{
			DataCommonEventSource.Log.Trace<int, string>("<ds.DataRelationCollection.UnregisterName|INFO> {0}, name='{1}'", this.ObjectID, name);
			if (base.NamesEqual(name, this.MakeName(this._defaultNameIndex - 1), true, this.GetDataSet().Locale) != 0)
			{
				do
				{
					this._defaultNameIndex--;
				}
				while (this._defaultNameIndex > 1 && !this.Contains(this.MakeName(this._defaultNameIndex - 1)));
			}
		}

		// Token: 0x040007B9 RID: 1977
		private DataRelation _inTransition;

		// Token: 0x040007BA RID: 1978
		private int _defaultNameIndex = 1;

		// Token: 0x040007BB RID: 1979
		private CollectionChangeEventHandler _onCollectionChangedDelegate;

		// Token: 0x040007BC RID: 1980
		private CollectionChangeEventHandler _onCollectionChangingDelegate;

		// Token: 0x040007BD RID: 1981
		private static int s_objectTypeCount;

		// Token: 0x040007BE RID: 1982
		private readonly int _objectID = Interlocked.Increment(ref DataRelationCollection.s_objectTypeCount);

		// Token: 0x020000BA RID: 186
		internal sealed class DataTableRelationCollection : DataRelationCollection
		{
			// Token: 0x06000B78 RID: 2936 RVA: 0x0002FF22 File Offset: 0x0002E122
			internal DataTableRelationCollection(DataTable table, bool fParentCollection)
			{
				if (table == null)
				{
					throw ExceptionBuilder.RelationTableNull();
				}
				this._table = table;
				this._fParentCollection = fParentCollection;
				this._relations = new ArrayList();
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0002FF4C File Offset: 0x0002E14C
			protected override ArrayList List
			{
				get
				{
					return this._relations;
				}
			}

			// Token: 0x06000B7A RID: 2938 RVA: 0x0002FF54 File Offset: 0x0002E154
			private void EnsureDataSet()
			{
				if (this._table.DataSet == null)
				{
					throw ExceptionBuilder.RelationTableWasRemoved();
				}
			}

			// Token: 0x06000B7B RID: 2939 RVA: 0x0002FF69 File Offset: 0x0002E169
			protected override DataSet GetDataSet()
			{
				this.EnsureDataSet();
				return this._table.DataSet;
			}

			// Token: 0x170001EF RID: 495
			public override DataRelation this[int index]
			{
				get
				{
					if (index >= 0 && index < this._relations.Count)
					{
						return (DataRelation)this._relations[index];
					}
					throw ExceptionBuilder.RelationOutOfRange(index);
				}
			}

			// Token: 0x170001F0 RID: 496
			public override DataRelation this[string name]
			{
				get
				{
					int num = base.InternalIndexOf(name);
					if (num == -2)
					{
						throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
					}
					if (num >= 0)
					{
						return (DataRelation)this.List[num];
					}
					return null;
				}
			}

			// Token: 0x14000019 RID: 25
			// (add) Token: 0x06000B7E RID: 2942 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
			// (remove) Token: 0x06000B7F RID: 2943 RVA: 0x00030020 File Offset: 0x0002E220
			internal event CollectionChangeEventHandler RelationPropertyChanged;

			// Token: 0x06000B80 RID: 2944 RVA: 0x00030055 File Offset: 0x0002E255
			internal void OnRelationPropertyChanged(CollectionChangeEventArgs ccevent)
			{
				if (!this._fParentCollection)
				{
					this._table.UpdatePropertyDescriptorCollectionCache();
				}
				CollectionChangeEventHandler relationPropertyChanged = this.RelationPropertyChanged;
				if (relationPropertyChanged == null)
				{
					return;
				}
				relationPropertyChanged(this, ccevent);
			}

			// Token: 0x06000B81 RID: 2945 RVA: 0x0003007C File Offset: 0x0002E27C
			private void AddCache(DataRelation relation)
			{
				this._relations.Add(relation);
				if (!this._fParentCollection)
				{
					this._table.UpdatePropertyDescriptorCollectionCache();
				}
			}

			// Token: 0x06000B82 RID: 2946 RVA: 0x000300A0 File Offset: 0x0002E2A0
			protected override void AddCore(DataRelation relation)
			{
				if (this._fParentCollection)
				{
					if (relation.ChildTable != this._table)
					{
						throw ExceptionBuilder.ChildTableMismatch();
					}
				}
				else if (relation.ParentTable != this._table)
				{
					throw ExceptionBuilder.ParentTableMismatch();
				}
				this.GetDataSet().Relations.Add(relation);
				this.AddCache(relation);
			}

			// Token: 0x06000B83 RID: 2947 RVA: 0x000300F5 File Offset: 0x0002E2F5
			public override bool CanRemove(DataRelation relation)
			{
				if (!base.CanRemove(relation))
				{
					return false;
				}
				if (this._fParentCollection)
				{
					if (relation.ChildTable != this._table)
					{
						return false;
					}
				}
				else if (relation.ParentTable != this._table)
				{
					return false;
				}
				return true;
			}

			// Token: 0x06000B84 RID: 2948 RVA: 0x0003012C File Offset: 0x0002E32C
			private void RemoveCache(DataRelation relation)
			{
				for (int i = 0; i < this._relations.Count; i++)
				{
					if (relation == this._relations[i])
					{
						this._relations.RemoveAt(i);
						if (!this._fParentCollection)
						{
							this._table.UpdatePropertyDescriptorCollectionCache();
						}
						return;
					}
				}
				throw ExceptionBuilder.RelationDoesNotExist();
			}

			// Token: 0x06000B85 RID: 2949 RVA: 0x00030184 File Offset: 0x0002E384
			protected override void RemoveCore(DataRelation relation)
			{
				if (this._fParentCollection)
				{
					if (relation.ChildTable != this._table)
					{
						throw ExceptionBuilder.ChildTableMismatch();
					}
				}
				else if (relation.ParentTable != this._table)
				{
					throw ExceptionBuilder.ParentTableMismatch();
				}
				this.GetDataSet().Relations.Remove(relation);
				this.RemoveCache(relation);
			}

			// Token: 0x040007BF RID: 1983
			private readonly DataTable _table;

			// Token: 0x040007C0 RID: 1984
			private readonly ArrayList _relations;

			// Token: 0x040007C1 RID: 1985
			private readonly bool _fParentCollection;
		}

		// Token: 0x020000BB RID: 187
		internal sealed class DataSetRelationCollection : DataRelationCollection
		{
			// Token: 0x06000B86 RID: 2950 RVA: 0x000301D9 File Offset: 0x0002E3D9
			internal DataSetRelationCollection(DataSet dataSet)
			{
				if (dataSet == null)
				{
					throw ExceptionBuilder.RelationDataSetNull();
				}
				this._dataSet = dataSet;
				this._relations = new ArrayList();
			}

			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x06000B87 RID: 2951 RVA: 0x000301FC File Offset: 0x0002E3FC
			protected override ArrayList List
			{
				get
				{
					return this._relations;
				}
			}

			// Token: 0x06000B88 RID: 2952 RVA: 0x00030204 File Offset: 0x0002E404
			public override void AddRange(DataRelation[] relations)
			{
				if (this._dataSet._fInitInProgress)
				{
					this._delayLoadingRelations = relations;
					return;
				}
				if (relations != null)
				{
					foreach (DataRelation dataRelation in relations)
					{
						if (dataRelation != null)
						{
							base.Add(dataRelation);
						}
					}
				}
			}

			// Token: 0x06000B89 RID: 2953 RVA: 0x00030247 File Offset: 0x0002E447
			public override void Clear()
			{
				base.Clear();
				if (this._dataSet._fInitInProgress && this._delayLoadingRelations != null)
				{
					this._delayLoadingRelations = null;
				}
			}

			// Token: 0x06000B8A RID: 2954 RVA: 0x0003026B File Offset: 0x0002E46B
			protected override DataSet GetDataSet()
			{
				return this._dataSet;
			}

			// Token: 0x170001F2 RID: 498
			public override DataRelation this[int index]
			{
				get
				{
					if (index >= 0 && index < this._relations.Count)
					{
						return (DataRelation)this._relations[index];
					}
					throw ExceptionBuilder.RelationOutOfRange(index);
				}
			}

			// Token: 0x170001F3 RID: 499
			public override DataRelation this[string name]
			{
				get
				{
					int num = base.InternalIndexOf(name);
					if (num == -2)
					{
						throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
					}
					if (num >= 0)
					{
						return (DataRelation)this.List[num];
					}
					return null;
				}
			}

			// Token: 0x06000B8D RID: 2957 RVA: 0x000302DC File Offset: 0x0002E4DC
			protected override void AddCore(DataRelation relation)
			{
				base.AddCore(relation);
				if (relation.ChildTable.DataSet != this._dataSet || relation.ParentTable.DataSet != this._dataSet)
				{
					throw ExceptionBuilder.ForeignRelation();
				}
				relation.CheckState();
				if (relation.Nested)
				{
					relation.CheckNestedRelations();
				}
				if (relation._relationName.Length == 0)
				{
					relation._relationName = base.AssignName();
				}
				else
				{
					base.RegisterName(relation._relationName);
				}
				DataKey childKey = relation.ChildKey;
				for (int i = 0; i < this._relations.Count; i++)
				{
					if (childKey.ColumnsEqual(((DataRelation)this._relations[i]).ChildKey) && relation.ParentKey.ColumnsEqual(((DataRelation)this._relations[i]).ParentKey))
					{
						throw ExceptionBuilder.RelationAlreadyExists();
					}
				}
				this._relations.Add(relation);
				((DataRelationCollection.DataTableRelationCollection)relation.ParentTable.ChildRelations).Add(relation);
				((DataRelationCollection.DataTableRelationCollection)relation.ChildTable.ParentRelations).Add(relation);
				relation.SetDataSet(this._dataSet);
				relation.ChildKey.GetSortIndex().AddRef();
				if (relation.Nested)
				{
					relation.ChildTable.CacheNestedParent();
				}
				ForeignKeyConstraint foreignKeyConstraint = relation.ChildTable.Constraints.FindForeignKeyConstraint(relation.ParentColumnsReference, relation.ChildColumnsReference);
				if (relation._createConstraints && foreignKeyConstraint == null)
				{
					relation.ChildTable.Constraints.Add(foreignKeyConstraint = new ForeignKeyConstraint(relation.ParentColumnsReference, relation.ChildColumnsReference));
					try
					{
						foreignKeyConstraint.ConstraintName = relation.RelationName;
					}
					catch (Exception e) when (ADP.IsCatchableExceptionType(e))
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e);
					}
				}
				UniqueConstraint parentKeyConstraint = relation.ParentTable.Constraints.FindKeyConstraint(relation.ParentColumnsReference);
				relation.SetParentKeyConstraint(parentKeyConstraint);
				relation.SetChildKeyConstraint(foreignKeyConstraint);
			}

			// Token: 0x06000B8E RID: 2958 RVA: 0x000304E0 File Offset: 0x0002E6E0
			protected override void RemoveCore(DataRelation relation)
			{
				base.RemoveCore(relation);
				this._dataSet.OnRemoveRelationHack(relation);
				relation.SetDataSet(null);
				relation.ChildKey.GetSortIndex().RemoveRef();
				if (relation.Nested)
				{
					relation.ChildTable.CacheNestedParent();
				}
				for (int i = 0; i < this._relations.Count; i++)
				{
					if (relation == this._relations[i])
					{
						this._relations.RemoveAt(i);
						((DataRelationCollection.DataTableRelationCollection)relation.ParentTable.ChildRelations).Remove(relation);
						((DataRelationCollection.DataTableRelationCollection)relation.ChildTable.ParentRelations).Remove(relation);
						if (relation.Nested)
						{
							relation.ChildTable.CacheNestedParent();
						}
						base.UnregisterName(relation.RelationName);
						relation.SetParentKeyConstraint(null);
						relation.SetChildKeyConstraint(null);
						return;
					}
				}
				throw ExceptionBuilder.RelationDoesNotExist();
			}

			// Token: 0x06000B8F RID: 2959 RVA: 0x000305C4 File Offset: 0x0002E7C4
			internal void FinishInitRelations()
			{
				if (this._delayLoadingRelations == null)
				{
					return;
				}
				for (int i = 0; i < this._delayLoadingRelations.Length; i++)
				{
					DataRelation dataRelation = this._delayLoadingRelations[i];
					if (dataRelation._parentColumnNames == null || dataRelation._childColumnNames == null)
					{
						base.Add(dataRelation);
					}
					else
					{
						int num = dataRelation._parentColumnNames.Length;
						DataColumn[] array = new DataColumn[num];
						DataColumn[] array2 = new DataColumn[num];
						for (int j = 0; j < num; j++)
						{
							if (dataRelation._parentTableNamespace == null)
							{
								array[j] = this._dataSet.Tables[dataRelation._parentTableName].Columns[dataRelation._parentColumnNames[j]];
							}
							else
							{
								array[j] = this._dataSet.Tables[dataRelation._parentTableName, dataRelation._parentTableNamespace].Columns[dataRelation._parentColumnNames[j]];
							}
							if (dataRelation._childTableNamespace == null)
							{
								array2[j] = this._dataSet.Tables[dataRelation._childTableName].Columns[dataRelation._childColumnNames[j]];
							}
							else
							{
								array2[j] = this._dataSet.Tables[dataRelation._childTableName, dataRelation._childTableNamespace].Columns[dataRelation._childColumnNames[j]];
							}
						}
						base.Add(new DataRelation(dataRelation._relationName, array, array2, false)
						{
							Nested = dataRelation._nested
						});
					}
				}
				this._delayLoadingRelations = null;
			}

			// Token: 0x040007C3 RID: 1987
			private readonly DataSet _dataSet;

			// Token: 0x040007C4 RID: 1988
			private readonly ArrayList _relations;

			// Token: 0x040007C5 RID: 1989
			private DataRelation[] _delayLoadingRelations;
		}
	}
}
