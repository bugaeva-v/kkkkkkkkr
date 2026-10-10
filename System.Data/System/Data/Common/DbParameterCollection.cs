using System;
using System.Collections;
using System.ComponentModel;

namespace System.Data.Common
{
	/// <summary>Базовый класс для коллекции параметров, относящихся к <see cref="T:System.Data.Common.DbCommand" />.</summary>
	// Token: 0x0200039C RID: 924
	public abstract class DbParameterCollection : MarshalByRefObject, IDataParameterCollection, IList, ICollection, IEnumerable
	{
		/// <summary>Указывает количество элементов в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002CD7 RID: 11479
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public abstract int Count { get; }

		/// <summary>Указывает, имеет ли коллекция фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x00006D64 File Offset: 0x00004F64
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Указывает, является ли коллекция доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция доступна только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x00006D64 File Offset: 0x00004F64
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Указывает, является ли коллекция синхронизированной.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция синхронизирована; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x00006D64 File Offset: 0x00004F64
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Указывает объект <see cref="T:System.Object" />, который следует использовать для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который следует использовать для синхронизации доступа к коллекции <see cref="T:System.Data.Common.DbParameterCollection" />.</returns>
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002CDB RID: 11483
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public abstract object SyncRoot { get; }

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		// Token: 0x170007A8 RID: 1960
		object IList.this[int index]
		{
			get
			{
				return this.GetParameter(index);
			}
			set
			{
				this.SetParameter(index, (DbParameter)value);
			}
		}

		/// <summary>Возвращает или задает параметр по указанному индексу.</summary>
		/// <param name="parameterName">Имя получаемого параметра.</param>
		/// <returns>Элемент <see cref="T:System.Object" />, расположенный по указанному индексу.</returns>
		// Token: 0x170007A9 RID: 1961
		object IDataParameterCollection.this[string parameterName]
		{
			get
			{
				return this.GetParameter(parameterName);
			}
			set
			{
				this.SetParameter(parameterName, (DbParameter)value);
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.Common.DbParameter" /> с заданным индексом.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс параметра.</param>
		/// <returns>Параметр <see cref="T:System.Data.Common.DbParameter" /> по указанному индексу.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Указанный индекс не существует.</exception>
		// Token: 0x170007AA RID: 1962
		public DbParameter this[int index]
		{
			get
			{
				return this.GetParameter(index);
			}
			set
			{
				this.SetParameter(index, value);
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.Common.DbParameter" /> с заданным именем.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <returns>Параметр <see cref="T:System.Data.Common.DbParameter" /> с указанным именем.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Указанный индекс не существует.</exception>
		// Token: 0x170007AB RID: 1963
		public DbParameter this[string parameterName]
		{
			get
			{
				return this.GetParameter(parameterName);
			}
			set
			{
				this.SetParameter(parameterName, value);
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Data.Common.DbParameter" /> в коллекцию <see cref="T:System.Data.Common.DbParameterCollection" />.</summary>
		/// <param name="value">
		///   <see cref="P:System.Data.Common.DbParameter.Value" /> из <see cref="T:System.Data.Common.DbParameter" /> для добавления в коллекцию.</param>
		/// <returns>Индекс объекта <see cref="T:System.Data.Common.DbParameter" /> в коллекции.</returns>
		// Token: 0x06002CE4 RID: 11492
		public abstract int Add(object value);

		/// <summary>Добавляет массив элементов с заданными значениями в <see cref="T:System.Data.Common.DbParameterCollection" />.</summary>
		/// <param name="values">Массив значений типа <see cref="T:System.Data.Common.DbParameter" />, добавляемый в коллекцию.</param>
		// Token: 0x06002CE5 RID: 11493
		public abstract void AddRange(Array values);

		/// <summary>Указывает, содержится ли в коллекции объект <see cref="T:System.Data.Common.DbParameter" /> с указанным <see cref="P:System.Data.Common.DbParameter.Value" />.</summary>
		/// <param name="value">Значение <see cref="P:System.Data.Common.DbParameter.Value" /> параметра <see cref="T:System.Data.Common.DbParameter" />, которое нужно найти в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если элемент <see cref="T:System.Data.Common.DbParameter" /> присутствует в коллекции, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002CE6 RID: 11494
		public abstract bool Contains(object value);

		/// <summary>Указывает, содержится ли в коллекции объект <see cref="T:System.Data.Common.DbParameter" /> с указанным именем.</summary>
		/// <param name="value">Имя параметра <see cref="T:System.Data.Common.DbParameter" />, которое следует искать в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если элемент <see cref="T:System.Data.Common.DbParameter" /> присутствует в коллекции, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002CE7 RID: 11495
		public abstract bool Contains(string value);

		/// <summary>Копирует массив экземпляров в коллекцию, начиная с указанного индекса.</summary>
		/// <param name="array">Массив элементов для копирования в коллекцию.</param>
		/// <param name="index">Индекс в коллекции для копирования элементов.</param>
		// Token: 0x06002CE8 RID: 11496
		public abstract void CopyTo(Array array, int index);

		/// <summary>Удаляет все значения <see cref="T:System.Data.Common.DbParameter" /> из <see cref="T:System.Data.Common.DbParameterCollection" />.</summary>
		// Token: 0x06002CE9 RID: 11497
		public abstract void Clear();

		/// <summary>Предоставляет метод <see cref="M:System.Collections.IEnumerable.GetEnumerator" />, который поддерживает простую итерацию по коллекции с помощью поставщика данных .NET Framework.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06002CEA RID: 11498
		[EditorBrowsable(EditorBrowsableState.Never)]
		public abstract IEnumerator GetEnumerator();

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DbParameter" /> по указанному индексу в коллекции.</summary>
		/// <param name="index">Индекс объекта <see cref="T:System.Data.Common.DbParameter" /> в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DbParameter" /> по указанному индексу в коллекции.</returns>
		// Token: 0x06002CEB RID: 11499
		protected abstract DbParameter GetParameter(int index);

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DbParameter" /> с заданным именем.</summary>
		/// <param name="parameterName">Имя <see cref="T:System.Data.Common.DbParameter" /> в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DbParameter" /> с заданным именем.</returns>
		// Token: 0x06002CEC RID: 11500
		protected abstract DbParameter GetParameter(string parameterName);

		/// <summary>Возвращает индекс указанного объекта <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.Common.DbParameter" /> в коллекции.</param>
		/// <returns>Индекс указанного объекта <see cref="T:System.Data.Common.DbParameter" />.</returns>
		// Token: 0x06002CED RID: 11501
		public abstract int IndexOf(object value);

		/// <summary>Возвращает индекс объекта <see cref="T:System.Data.Common.DbParameter" /> с заданным именем.</summary>
		/// <param name="parameterName">Имя объекта <see cref="T:System.Data.Common.DbParameter" /> в коллекции.</param>
		/// <returns>Индекс объекта <see cref="T:System.Data.Common.DbParameter" /> с заданным именем.</returns>
		// Token: 0x06002CEE RID: 11502
		public abstract int IndexOf(string parameterName);

		/// <summary>Вставляет указанный индекс объекта <see cref="T:System.Data.Common.DbParameter" /> с указанным именем в коллекцию по указанному индексу.</summary>
		/// <param name="index">Индекс, по которому нужно вставить объект <see cref="T:System.Data.Common.DbParameter" />.</param>
		/// <param name="value">Объект <see cref="T:System.Data.Common.DbParameter" />, который нужно вставить в коллекцию.</param>
		// Token: 0x06002CEF RID: 11503
		public abstract void Insert(int index, object value);

		/// <summary>Удаляет указанный объект <see cref="T:System.Data.Common.DbParameter" /> из коллекции.</summary>
		/// <param name="value">Удаляемый объект <see cref="T:System.Data.Common.DbParameter" />.</param>
		// Token: 0x06002CF0 RID: 11504
		public abstract void Remove(object value);

		/// <summary>Удаляет объект <see cref="T:System.Data.Common.DbParameter" /> в указанной позиции из коллекции.</summary>
		/// <param name="index">Индекс, где находится объект <see cref="T:System.Data.Common.DbParameter" />.</param>
		// Token: 0x06002CF1 RID: 11505
		public abstract void RemoveAt(int index);

		/// <summary>Удаляет объект <see cref="T:System.Data.Common.DbParameter" /> с указанным именем из коллекции.</summary>
		/// <param name="parameterName">Имя удаляемого объекта <see cref="T:System.Data.Common.DbParameter" />.</param>
		// Token: 0x06002CF2 RID: 11506
		public abstract void RemoveAt(string parameterName);

		/// <summary>Задает новое значение для объекта <see cref="T:System.Data.Common.DbParameter" /> по указанному индексу.</summary>
		/// <param name="index">Индекс, где находится объект <see cref="T:System.Data.Common.DbParameter" />.</param>
		/// <param name="value">Новое значение <see cref="T:System.Data.Common.DbParameter" />.</param>
		// Token: 0x06002CF3 RID: 11507
		protected abstract void SetParameter(int index, DbParameter value);

		/// <summary>Назначает новое значение объекту <see cref="T:System.Data.Common.DbParameter" /> с указанным именем.</summary>
		/// <param name="parameterName">Имя объекта <see cref="T:System.Data.Common.DbParameter" /> в коллекции.</param>
		/// <param name="value">Новое значение <see cref="T:System.Data.Common.DbParameter" />.</param>
		// Token: 0x06002CF4 RID: 11508
		protected abstract void SetParameter(string parameterName, DbParameter value);
	}
}
