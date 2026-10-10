using System;
using System.Collections;

namespace System.Data.SqlClient
{
	/// <summary>Коллекция объектов <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />, наследующих от <see cref="T:System.Collections.CollectionBase" />.</summary>
	// Token: 0x020001AA RID: 426
	public sealed class SqlBulkCopyColumnMappingCollection : CollectionBase
	{
		// Token: 0x06001503 RID: 5379 RVA: 0x000604BA File Offset: 0x0005E6BA
		internal SqlBulkCopyColumnMappingCollection()
		{
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000604C2 File Offset: 0x0005E6C2
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x000604CA File Offset: 0x0005E6CA
		internal bool ReadOnly { get; set; }

		/// <summary>Возвращает объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс объекта <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />, который требуется найти.</param>
		/// <returns>Объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />.</returns>
		// Token: 0x17000398 RID: 920
		public SqlBulkCopyColumnMapping this[int index]
		{
			get
			{
				return (SqlBulkCopyColumnMapping)base.List[index];
			}
		}

		/// <summary>Добавляет заданное сопоставление в <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMappingCollection" />.</summary>
		/// <param name="bulkCopyColumnMapping">Объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> добавляемого в коллекцию сопоставления.</param>
		/// <returns>Объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />.</returns>
		// Token: 0x06001507 RID: 5383 RVA: 0x000604E8 File Offset: 0x0005E6E8
		public SqlBulkCopyColumnMapping Add(SqlBulkCopyColumnMapping bulkCopyColumnMapping)
		{
			this.AssertWriteAccess();
			if ((string.IsNullOrEmpty(bulkCopyColumnMapping.SourceColumn) && bulkCopyColumnMapping.SourceOrdinal == -1) || (string.IsNullOrEmpty(bulkCopyColumnMapping.DestinationColumn) && bulkCopyColumnMapping.DestinationOrdinal == -1))
			{
				throw SQL.BulkLoadNonMatchingColumnMapping();
			}
			base.InnerList.Add(bulkCopyColumnMapping);
			return bulkCopyColumnMapping;
		}

		/// <summary>Создает новый <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> и добавляет его в коллекцию, используя имена исходного столбца и столбца назначения.</summary>
		/// <param name="sourceColumn">Имя исходного столбца в источнике данных.</param>
		/// <param name="destinationColumn">Имя целевого столбца в таблице назначения.</param>
		/// <returns>Сопоставление столбцов.</returns>
		// Token: 0x06001508 RID: 5384 RVA: 0x0006053B File Offset: 0x0005E73B
		public SqlBulkCopyColumnMapping Add(string sourceColumn, string destinationColumn)
		{
			this.AssertWriteAccess();
			return this.Add(new SqlBulkCopyColumnMapping(sourceColumn, destinationColumn));
		}

		/// <summary>Создает новый <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> и добавляет его в коллекцию, используя порядковый номер исходного столбца и строку для столбца назначения.</summary>
		/// <param name="sourceColumnIndex">Порядковый номер исходного столбца в источнике данных.</param>
		/// <param name="destinationColumn">Имя целевого столбца в таблице назначения.</param>
		/// <returns>Сопоставление столбцов.</returns>
		// Token: 0x06001509 RID: 5385 RVA: 0x00060550 File Offset: 0x0005E750
		public SqlBulkCopyColumnMapping Add(int sourceColumnIndex, string destinationColumn)
		{
			this.AssertWriteAccess();
			return this.Add(new SqlBulkCopyColumnMapping(sourceColumnIndex, destinationColumn));
		}

		/// <summary>Создает новый <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> и добавляет его в коллекцию, используя имя исходного столбца и порядковый номер столбца назначения.</summary>
		/// <param name="sourceColumn">Имя исходного столбца в источнике данных.</param>
		/// <param name="destinationColumnIndex">Порядковый номер целевого столбца в таблице назначения.</param>
		/// <returns>Сопоставление столбцов.</returns>
		// Token: 0x0600150A RID: 5386 RVA: 0x00060565 File Offset: 0x0005E765
		public SqlBulkCopyColumnMapping Add(string sourceColumn, int destinationColumnIndex)
		{
			this.AssertWriteAccess();
			return this.Add(new SqlBulkCopyColumnMapping(sourceColumn, destinationColumnIndex));
		}

		/// <summary>Создает новый <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> и добавляет его в коллекцию, используя порядковые номера исходного столбца и столбца назначения.</summary>
		/// <param name="sourceColumnIndex">Порядковый номер исходного столбца в источнике данных.</param>
		/// <param name="destinationColumnIndex">Порядковый номер целевого столбца в таблице назначения.</param>
		/// <returns>Сопоставление столбцов.</returns>
		// Token: 0x0600150B RID: 5387 RVA: 0x0006057A File Offset: 0x0005E77A
		public SqlBulkCopyColumnMapping Add(int sourceColumnIndex, int destinationColumnIndex)
		{
			this.AssertWriteAccess();
			return this.Add(new SqlBulkCopyColumnMapping(sourceColumnIndex, destinationColumnIndex));
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0006058F File Offset: 0x0005E78F
		private void AssertWriteAccess()
		{
			if (this.ReadOnly)
			{
				throw SQL.BulkLoadMappingInaccessible();
			}
		}

		/// <summary>Удаляет содержимое коллекции.</summary>
		// Token: 0x0600150D RID: 5389 RVA: 0x0006059F File Offset: 0x0005E79F
		public new void Clear()
		{
			this.AssertWriteAccess();
			base.Clear();
		}

		/// <summary>Получает значение, указывающее, существует ли конкретный объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> в коллекции.</summary>
		/// <param name="value">Допустимый объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />.</param>
		/// <returns>
		///   <see langword="true" />, если указанное сопоставление присутствует в коллекции; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600150E RID: 5390 RVA: 0x000605AD File Offset: 0x0005E7AD
		public bool Contains(SqlBulkCopyColumnMapping value)
		{
			return base.InnerList.Contains(value);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMappingCollection" /> в массив элементов <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> начиная с определенного индекса.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />, в который копируются элементы целевые элементы из <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMappingCollection" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x0600150F RID: 5391 RVA: 0x000605BB File Offset: 0x0005E7BB
		public void CopyTo(SqlBulkCopyColumnMapping[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000605CC File Offset: 0x0005E7CC
		internal void CreateDefaultMapping(int columnCount)
		{
			for (int i = 0; i < columnCount; i++)
			{
				base.InnerList.Add(new SqlBulkCopyColumnMapping(i, i));
			}
		}

		/// <summary>Возвращает индекс указанного объекта <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />.</param>
		/// <returns>Индекс (с нуля) сопоставления столбцов или -1, если данное сопоставление столбцов не найдено в коллекции.</returns>
		// Token: 0x06001511 RID: 5393 RVA: 0x000605F8 File Offset: 0x0005E7F8
		public int IndexOf(SqlBulkCopyColumnMapping value)
		{
			return base.InnerList.IndexOf(value);
		}

		/// <summary>Вставляет новый объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> по указанному индексу.</summary>
		/// <param name="index">Целочисленное значение расположения в <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMappingCollection" />, по которому вставляется новый <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />.</param>
		/// <param name="value">Объект, который необходимо вставить в коллекцию <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />.</param>
		// Token: 0x06001512 RID: 5394 RVA: 0x00060606 File Offset: 0x0005E806
		public void Insert(int index, SqlBulkCopyColumnMapping value)
		{
			this.AssertWriteAccess();
			base.InnerList.Insert(index, value);
		}

		/// <summary>Удаляет заданный элемент <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" /> из <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMappingCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />, удаляемый из коллекции.</param>
		// Token: 0x06001513 RID: 5395 RVA: 0x0006061B File Offset: 0x0005E81B
		public void Remove(SqlBulkCopyColumnMapping value)
		{
			this.AssertWriteAccess();
			base.InnerList.Remove(value);
		}

		/// <summary>Удаляет из коллекции сопоставление с заданным индексом.</summary>
		/// <param name="index">Начинающийся с нуля индекс объекта <see cref="T:System.Data.SqlClient.SqlBulkCopyColumnMapping" />, удаляемого из коллекции.</param>
		// Token: 0x06001514 RID: 5396 RVA: 0x0006062F File Offset: 0x0005E82F
		public new void RemoveAt(int index)
		{
			this.AssertWriteAccess();
			base.RemoveAt(index);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00060640 File Offset: 0x0005E840
		internal void ValidateCollection()
		{
			foreach (object obj in base.InnerList)
			{
				SqlBulkCopyColumnMapping sqlBulkCopyColumnMapping = (SqlBulkCopyColumnMapping)obj;
				SqlBulkCopyColumnMappingCollection.MappingSchema mappingSchema = (sqlBulkCopyColumnMapping.SourceOrdinal != -1) ? ((sqlBulkCopyColumnMapping.DestinationOrdinal != -1) ? SqlBulkCopyColumnMappingCollection.MappingSchema.OrdinalsOrdinals : SqlBulkCopyColumnMappingCollection.MappingSchema.OrdinalsNames) : ((sqlBulkCopyColumnMapping.DestinationOrdinal != -1) ? SqlBulkCopyColumnMappingCollection.MappingSchema.NemesOrdinals : SqlBulkCopyColumnMappingCollection.MappingSchema.NamesNames);
				if (this._mappingSchema == SqlBulkCopyColumnMappingCollection.MappingSchema.Undefined)
				{
					this._mappingSchema = mappingSchema;
				}
				else if (this._mappingSchema != mappingSchema)
				{
					throw SQL.BulkLoadMappingsNamesOrOrdinalsOnly();
				}
			}
		}

		// Token: 0x04000D5D RID: 3421
		private SqlBulkCopyColumnMappingCollection.MappingSchema _mappingSchema;

		// Token: 0x020001AB RID: 427
		private enum MappingSchema
		{
			// Token: 0x04000D60 RID: 3424
			Undefined,
			// Token: 0x04000D61 RID: 3425
			NamesNames,
			// Token: 0x04000D62 RID: 3426
			NemesOrdinals,
			// Token: 0x04000D63 RID: 3427
			OrdinalsNames,
			// Token: 0x04000D64 RID: 3428
			OrdinalsOrdinals
		}
	}
}
