using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SqlClient
{
	/// <summary>Представляет коллекцию параметров, относящихся к <see cref="T:System.Data.SqlClient.SqlCommand" />, а также соответствующие им сопоставления со столбцами в <see cref="T:System.Data.DataSet" />. Этот класс не наследуется.</summary>
	// Token: 0x0200021C RID: 540
	public sealed class SqlParameterCollection : DbParameterCollection, ICollection, IEnumerable, IList, IDataParameterCollection
	{
		// Token: 0x06001A36 RID: 6710 RVA: 0x0005AE10 File Offset: 0x00059010
		internal SqlParameterCollection()
		{
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00079BBF File Offset: 0x00077DBF
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x00079BC7 File Offset: 0x00077DC7
		internal bool IsDirty
		{
			get
			{
				return this._isDirty;
			}
			set
			{
				this._isDirty = value;
			}
		}

		/// <summary>Возвращает значение, показывающее, имеет ли объект <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00079BD0 File Offset: 0x00077DD0
		public override bool IsFixedSize
		{
			get
			{
				return ((IList)this.InnerList).IsFixedSize;
			}
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00079BDD File Offset: 0x00077DDD
		public override bool IsReadOnly
		{
			get
			{
				return ((IList)this.InnerList).IsReadOnly;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.SqlClient.SqlParameter" /> по указанному индексу.</summary>
		/// <param name="index">Индекс получаемого параметра (отсчет с нуля).</param>
		/// <returns>Параметр <see cref="T:System.Data.SqlClient.SqlParameter" /> по указанному индексу.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Указанный индекс не существует.</exception>
		// Token: 0x170004EE RID: 1262
		public SqlParameter this[int index]
		{
			get
			{
				return (SqlParameter)this.GetParameter(index);
			}
			set
			{
				this.SetParameter(index, value);
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.SqlClient.SqlParameter" /> с указанным именем.</summary>
		/// <param name="parameterName">Имя получаемого параметра.</param>
		/// <returns>Параметр <see cref="T:System.Data.SqlClient.SqlParameter" /> с указанным именем.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Указанное значение <paramref name="parameterName" /> недопустимо.</exception>
		// Token: 0x170004EF RID: 1263
		public SqlParameter this[string parameterName]
		{
			get
			{
				return (SqlParameter)this.GetParameter(parameterName);
			}
			set
			{
				this.SetParameter(parameterName, value);
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="value">Параметр <see cref="T:System.Data.SqlClient.SqlParameter" /> для добавления в коллекцию.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlClient.SqlParameter" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="T:System.Data.SqlClient.SqlParameter" />, заданный в параметре <paramref name="value" />, уже добавлен в эту или другую коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Передан параметр, отличный от объекта <see cref="T:System.Data.SqlClient.SqlParameter" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение null.</exception>
		// Token: 0x06001A3F RID: 6719 RVA: 0x00079C1A File Offset: 0x00077E1A
		public SqlParameter Add(SqlParameter value)
		{
			this.Add(value);
			return value;
		}

		/// <summary>Добавляет значение в конец коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="value">Добавляемое значение. Используйте <see cref="F:System.DBNull.Value" /> вместо null для указания значения null.</param>
		/// <returns>Объект <see cref="T:System.Data.SqlClient.SqlParameter" />.</returns>
		// Token: 0x06001A40 RID: 6720 RVA: 0x00079C25 File Offset: 0x00077E25
		public SqlParameter AddWithValue(string parameterName, object value)
		{
			return this.Add(new SqlParameter(parameterName, value));
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> в соответствии с заданным именем и типом данных параметра.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="sqlDbType">Одно из значений <see cref="T:System.Data.SqlDbType" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlClient.SqlParameter" />.</returns>
		// Token: 0x06001A41 RID: 6721 RVA: 0x00079C34 File Offset: 0x00077E34
		public SqlParameter Add(string parameterName, SqlDbType sqlDbType)
		{
			return this.Add(new SqlParameter(parameterName, sqlDbType));
		}

		/// <summary>Добавляет <see cref="T:System.Data.SqlClient.SqlParameter" /> в <see cref="T:System.Data.SqlClient.SqlParameterCollection" />, задавая указанные имя параметра, <see cref="T:System.Data.SqlDbType" /> и размер.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="sqlDbType">
		///   <see cref="T:System.Data.SqlDbType" /> из <see cref="T:System.Data.SqlClient.SqlParameter" /> для добавления в коллекцию.</param>
		/// <param name="size">Размер <see cref="T:System.Int32" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlClient.SqlParameter" />.</returns>
		// Token: 0x06001A42 RID: 6722 RVA: 0x00079C43 File Offset: 0x00077E43
		public SqlParameter Add(string parameterName, SqlDbType sqlDbType, int size)
		{
			return this.Add(new SqlParameter(parameterName, sqlDbType, size));
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> в соответствии с заданным именем параметра, типом данных и длиной столбца.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="sqlDbType">Одно из значений <see cref="T:System.Data.SqlDbType" />.</param>
		/// <param name="size">Длина столбца.</param>
		/// <param name="sourceColumn">Имя исходного столбца (<see cref="P:System.Data.SqlClient.SqlParameter.SourceColumn" />), если этот <see cref="T:System.Data.SqlClient.SqlParameter" /> используется при вызове <see cref="Overload:System.Data.Common.DbDataAdapter.Update" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlClient.SqlParameter" />.</returns>
		// Token: 0x06001A43 RID: 6723 RVA: 0x00079C53 File Offset: 0x00077E53
		public SqlParameter Add(string parameterName, SqlDbType sqlDbType, int size, string sourceColumn)
		{
			return this.Add(new SqlParameter(parameterName, sqlDbType, size, sourceColumn));
		}

		/// <summary>Добавляет массив значений <see cref="T:System.Data.SqlClient.SqlParameter" /> в конец коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="values">Добавляемые значения <see cref="T:System.Data.SqlClient.SqlParameter" />.</param>
		// Token: 0x06001A44 RID: 6724 RVA: 0x00079C65 File Offset: 0x00077E65
		public void AddRange(SqlParameter[] values)
		{
			this.AddRange(values);
		}

		/// <summary>Определяет, находится ли заданное имя параметра в этой коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="value">Значение <see cref="T:System.String" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> содержит значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A45 RID: 6725 RVA: 0x00079C6E File Offset: 0x00077E6E
		public override bool Contains(string value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Определяет, находится ли заданный объект <see cref="T:System.Data.SqlClient.SqlParameter" /> в этой коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Data.SqlClient.SqlParameter" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> содержит значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A46 RID: 6726 RVA: 0x00079C7D File Offset: 0x00077E7D
		public bool Contains(SqlParameter value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Копирует все элементы текущей коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> в указанную коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" />, начиная с указанного индекса в коллекции назначения.</summary>
		/// <param name="array">Коллекция <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> — назначение для элементов, копируемых из текущей коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</param>
		/// <param name="index">32-разрядное целое число, представляющее индекс в коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />, с которого начинается копирование.</param>
		// Token: 0x06001A47 RID: 6727 RVA: 0x00079C8C File Offset: 0x00077E8C
		public void CopyTo(SqlParameter[] array, int index)
		{
			this.CopyTo(array, index);
		}

		/// <summary>Возвращает положение указанного объекта <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекции.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Data.SqlClient.SqlParameter" />.</param>
		/// <returns>Отсчитываемое от нуля расположение указанного объекта <see cref="T:System.Data.SqlClient.SqlParameter" />, который является объектом <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекции. Возвращает значение -1, если объект не существует в коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</returns>
		// Token: 0x06001A48 RID: 6728 RVA: 0x00079C96 File Offset: 0x00077E96
		public int IndexOf(SqlParameter value)
		{
			return this.IndexOf(value);
		}

		/// <summary>Вставляет объект <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> по указанному индексу.</summary>
		/// <param name="index">Индекс (отсчет с нуля), по которому необходимо вставить значение.</param>
		/// <param name="value">Объект <see cref="T:System.Data.SqlClient.SqlParameter" />, вставляемый в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</param>
		// Token: 0x06001A49 RID: 6729 RVA: 0x00079C9F File Offset: 0x00077E9F
		public void Insert(int index, SqlParameter value)
		{
			this.Insert(index, value);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00079CA9 File Offset: 0x00077EA9
		private void OnChange()
		{
			this.IsDirty = true;
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Data.SqlClient.SqlParameter" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.SqlClient.SqlParameter" />, который должен быть удален из коллекции.</param>
		/// <exception cref="T:System.InvalidCastException">Параметр не является объектом <see cref="T:System.Data.SqlClient.SqlParameter" />.</exception>
		/// <exception cref="T:System.SystemException">Параметр отсутствует в коллекции.</exception>
		// Token: 0x06001A4B RID: 6731 RVA: 0x00079CB2 File Offset: 0x00077EB2
		public void Remove(SqlParameter value)
		{
			this.Remove(value);
		}

		/// <summary>Возвращает целое число, которое содержит количество элементов в <see cref="T:System.Data.SqlClient.SqlParameterCollection" />. Только для чтения.</summary>
		/// <returns>Число элементов в коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> является значением типа Integer.</returns>
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x00079CBB File Offset: 0x00077EBB
		public override int Count
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x00079CD4 File Offset: 0x00077ED4
		private List<SqlParameter> InnerList
		{
			get
			{
				List<SqlParameter> list = this._items;
				if (list == null)
				{
					list = new List<SqlParameter>();
					this._items = list;
				}
				return list;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</returns>
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x00079CF9 File Offset: 0x00077EF9
		public override object SyncRoot
		{
			get
			{
				return ((ICollection)this.InnerList).SyncRoot;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />.</param>
		/// <returns>Индекс нового объекта <see cref="T:System.Data.SqlClient.SqlParameter" />.</returns>
		// Token: 0x06001A4F RID: 6735 RVA: 0x00079D06 File Offset: 0x00077F06
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Add(object value)
		{
			this.OnChange();
			this.ValidateType(value);
			this.Validate(-1, value);
			this.InnerList.Add((SqlParameter)value);
			return this.Count - 1;
		}

		/// <summary>Добавляет массив значений в конец коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="values">Добавляемые значения <see cref="T:System.Array" />.</param>
		// Token: 0x06001A50 RID: 6736 RVA: 0x00079D38 File Offset: 0x00077F38
		public override void AddRange(Array values)
		{
			this.OnChange();
			if (values == null)
			{
				throw ADP.ArgumentNull("values");
			}
			foreach (object value in values)
			{
				this.ValidateType(value);
			}
			foreach (object obj in values)
			{
				SqlParameter sqlParameter = (SqlParameter)obj;
				this.Validate(-1, sqlParameter);
				this.InnerList.Add(sqlParameter);
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00079DEC File Offset: 0x00077FEC
		private int CheckName(string parameterName)
		{
			int num = this.IndexOf(parameterName);
			if (num < 0)
			{
				throw ADP.ParametersSourceIndex(parameterName, this, SqlParameterCollection.s_itemType);
			}
			return num;
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Data.SqlClient.SqlParameter" /> из коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		// Token: 0x06001A52 RID: 6738 RVA: 0x00079E08 File Offset: 0x00078008
		public override void Clear()
		{
			this.OnChange();
			List<SqlParameter> innerList = this.InnerList;
			if (innerList != null)
			{
				foreach (SqlParameter sqlParameter in innerList)
				{
					sqlParameter.ResetParent();
				}
				innerList.Clear();
			}
		}

		/// <summary>Определяет, находится ли заданный объект <see cref="T:System.Object" /> в этой коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="value">Значение <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> содержит значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A53 RID: 6739 RVA: 0x00079E6C File Offset: 0x0007806C
		public override bool Contains(object value)
		{
			return -1 != this.IndexOf(value);
		}

		/// <summary>Копирует все элементы текущей коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> в указанный одномерный массив <see cref="T:System.Array" />, начиная с указанного индекса в массиве <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" /> — назначение для элементов, копируемых из текущей коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</param>
		/// <param name="index">32-разрядное целое число, представляющее индекс в коллекции <see cref="T:System.Array" />, с которого начинается копирование.</param>
		// Token: 0x06001A54 RID: 6740 RVA: 0x00079E7B File Offset: 0x0007807B
		public override void CopyTo(Array array, int index)
		{
			((ICollection)this.InnerList).CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</returns>
		// Token: 0x06001A55 RID: 6741 RVA: 0x00079E8A File Offset: 0x0007808A
		public override IEnumerator GetEnumerator()
		{
			return ((IEnumerable)this.InnerList).GetEnumerator();
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00079E97 File Offset: 0x00078097
		protected override DbParameter GetParameter(int index)
		{
			this.RangeCheck(index);
			return this.InnerList[index];
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00079EAC File Offset: 0x000780AC
		protected override DbParameter GetParameter(string parameterName)
		{
			int num = this.IndexOf(parameterName);
			if (num < 0)
			{
				throw ADP.ParametersSourceIndex(parameterName, this, SqlParameterCollection.s_itemType);
			}
			return this.InnerList[num];
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00079EE0 File Offset: 0x000780E0
		private static int IndexOf(IEnumerable items, string parameterName)
		{
			if (items != null)
			{
				int num = 0;
				foreach (object obj in items)
				{
					SqlParameter sqlParameter = (SqlParameter)obj;
					if (parameterName == sqlParameter.ParameterName)
					{
						return num;
					}
					num++;
				}
				num = 0;
				foreach (object obj2 in items)
				{
					SqlParameter sqlParameter2 = (SqlParameter)obj2;
					if (ADP.DstCompare(parameterName, sqlParameter2.ParameterName) == 0)
					{
						return num;
					}
					num++;
				}
				return -1;
			}
			return -1;
		}

		/// <summary>Возвращает положение заданного объекта <see cref="T:System.Data.SqlClient.SqlParameter" /> с указанным именем.</summary>
		/// <param name="parameterName">Имя искомого объекта <see cref="T:System.Data.SqlClient.SqlParameter" /> с учетом регистра.</param>
		/// <returns>Положение (отсчет с нуля) указанного объекта <see cref="T:System.Data.SqlClient.SqlParameter" /> с заданным именем с учетом регистра. Возвращает значение -1, если объект не существует в коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</returns>
		// Token: 0x06001A59 RID: 6745 RVA: 0x00079FAC File Offset: 0x000781AC
		public override int IndexOf(string parameterName)
		{
			return SqlParameterCollection.IndexOf(this.InnerList, parameterName);
		}

		/// <summary>Возвращает положение указанного объекта <see cref="T:System.Object" /> в коллекции.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Object" />.</param>
		/// <returns>Отсчитываемое от нуля расположение указанного объекта <see cref="T:System.Object" />, который является объектом <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекции. Возвращает значение -1, если объект не существует в коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</returns>
		// Token: 0x06001A5A RID: 6746 RVA: 0x00079FBC File Offset: 0x000781BC
		public override int IndexOf(object value)
		{
			if (value != null)
			{
				this.ValidateType(value);
				List<SqlParameter> innerList = this.InnerList;
				if (innerList != null)
				{
					int count = innerList.Count;
					for (int i = 0; i < count; i++)
					{
						if (value == innerList[i])
						{
							return i;
						}
					}
				}
			}
			return -1;
		}

		/// <summary>Вставляет объект <see cref="T:System.Object" /> в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" /> по указанному индексу.</summary>
		/// <param name="index">Индекс (отсчет с нуля), по которому необходимо вставить значение.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, вставляемый в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</param>
		// Token: 0x06001A5B RID: 6747 RVA: 0x00079FFD File Offset: 0x000781FD
		public override void Insert(int index, object value)
		{
			this.OnChange();
			this.ValidateType(value);
			this.Validate(-1, (SqlParameter)value);
			this.InnerList.Insert(index, (SqlParameter)value);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0007A02B File Offset: 0x0007822B
		private void RangeCheck(int index)
		{
			if (index < 0 || this.Count <= index)
			{
				throw ADP.ParametersMappingIndex(index, this);
			}
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Data.SqlClient.SqlParameter" /> из коллекции.</summary>
		/// <param name="value">Объект, который должен быть удален из коллекции.</param>
		// Token: 0x06001A5D RID: 6749 RVA: 0x0007A044 File Offset: 0x00078244
		public override void Remove(object value)
		{
			this.OnChange();
			this.ValidateType(value);
			int num = this.IndexOf(value);
			if (-1 != num)
			{
				this.RemoveIndex(num);
				return;
			}
			if (this != ((SqlParameter)value).CompareExchangeParent(null, this))
			{
				throw ADP.CollectionRemoveInvalidObject(SqlParameterCollection.s_itemType, this);
			}
		}

		/// <summary>Удаляет объект <see cref="T:System.Data.SqlClient.SqlParameter" /> с указанным индексом из коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="index">Индекс (отсчет с нуля) удаляемого объекта <see cref="T:System.Data.SqlClient.SqlParameter" />.</param>
		// Token: 0x06001A5E RID: 6750 RVA: 0x0007A08E File Offset: 0x0007828E
		public override void RemoveAt(int index)
		{
			this.OnChange();
			this.RangeCheck(index);
			this.RemoveIndex(index);
		}

		/// <summary>Удаляет объект <see cref="T:System.Data.SqlClient.SqlParameter" /> с указанным именем из коллекции <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="parameterName">Имя удаляемого объекта <see cref="T:System.Data.SqlClient.SqlParameter" />.</param>
		// Token: 0x06001A5F RID: 6751 RVA: 0x0007A0A4 File Offset: 0x000782A4
		public override void RemoveAt(string parameterName)
		{
			this.OnChange();
			int index = this.CheckName(parameterName);
			this.RemoveIndex(index);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0007A0C8 File Offset: 0x000782C8
		private void RemoveIndex(int index)
		{
			List<SqlParameter> innerList = this.InnerList;
			SqlParameter sqlParameter = innerList[index];
			innerList.RemoveAt(index);
			sqlParameter.ResetParent();
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0007A0F0 File Offset: 0x000782F0
		private void Replace(int index, object newValue)
		{
			List<SqlParameter> innerList = this.InnerList;
			this.ValidateType(newValue);
			this.Validate(index, newValue);
			SqlParameter sqlParameter = innerList[index];
			innerList[index] = (SqlParameter)newValue;
			sqlParameter.ResetParent();
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0007A12C File Offset: 0x0007832C
		protected override void SetParameter(int index, DbParameter value)
		{
			this.OnChange();
			this.RangeCheck(index);
			this.Replace(index, value);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0007A144 File Offset: 0x00078344
		protected override void SetParameter(string parameterName, DbParameter value)
		{
			this.OnChange();
			int num = this.IndexOf(parameterName);
			if (num < 0)
			{
				throw ADP.ParametersSourceIndex(parameterName, this, SqlParameterCollection.s_itemType);
			}
			this.Replace(num, value);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0007A178 File Offset: 0x00078378
		private void Validate(int index, object value)
		{
			if (value == null)
			{
				throw ADP.ParameterNull("value", this, SqlParameterCollection.s_itemType);
			}
			object obj = ((SqlParameter)value).CompareExchangeParent(this, null);
			if (obj != null)
			{
				if (this != obj)
				{
					throw ADP.ParametersIsNotParent(SqlParameterCollection.s_itemType, this);
				}
				if (index != this.IndexOf(value))
				{
					throw ADP.ParametersIsParent(SqlParameterCollection.s_itemType, this);
				}
			}
			string text = ((SqlParameter)value).ParameterName;
			if (text.Length == 0)
			{
				index = 1;
				do
				{
					text = "Parameter" + index.ToString(CultureInfo.CurrentCulture);
					index++;
				}
				while (-1 != this.IndexOf(text));
				((SqlParameter)value).ParameterName = text;
			}
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0007A219 File Offset: 0x00078419
		private void ValidateType(object value)
		{
			if (value == null)
			{
				throw ADP.ParameterNull("value", this, SqlParameterCollection.s_itemType);
			}
			if (!SqlParameterCollection.s_itemType.IsInstanceOfType(value))
			{
				throw ADP.InvalidParameterType(this, SqlParameterCollection.s_itemType, value);
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Data.SqlClient.SqlParameter" /> в коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</summary>
		/// <param name="parameterName">Имя объекта <see cref="T:System.Data.SqlClient.SqlParameter" />, добавляемого коллекцию.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlClient.SqlParameter" />.  
		/// Следует соблюдать осторожность при использовании перегруженной версии метода <see langword="SqlParameterCollection.Add" /> для задания целочисленных значений параметров. Поскольку данная перегруженная версия принимает параметр <paramref name="value" /> типа <see cref="T:System.Object" />, необходимо преобразовать целочисленное значение в тип <see cref="T:System.Object" />, когда значение равно нулю, как показано в следующем примере на C#.  
		/// parameters.Add("@pname", Convert.ToInt32(0));  
		/// Если такое преобразование не выполнено, компилятор предполагает, что осуществляется попытка вызова перегруженной версии <see langword="SqlParameterCollection.Add" /> (<see langword="string" />, <see langword="SqlDbType" />).</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="T:System.Data.SqlClient.SqlParameter" />, заданный в параметре <paramref name="value" />, уже добавлен в эту или другую коллекцию <see cref="T:System.Data.SqlClient.SqlParameterCollection" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение null.</exception>
		// Token: 0x06001A66 RID: 6758 RVA: 0x00079C25 File Offset: 0x00077E25
		public SqlParameter Add(string parameterName, object value)
		{
			return this.Add(new SqlParameter(parameterName, value));
		}

		// Token: 0x040010EF RID: 4335
		private bool _isDirty;

		// Token: 0x040010F0 RID: 4336
		private static Type s_itemType = typeof(SqlParameter);

		// Token: 0x040010F1 RID: 4337
		private List<SqlParameter> _items;
	}
}
