using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Data
{
	/// <summary>Определяет методы расширения для класса <see cref="T:System.Data.DataTable" />. <see cref="T:System.Data.DataTableExtensions" /> является статическим классом.</summary>
	// Token: 0x02000009 RID: 9
	public static class DataTableExtensions
	{
		/// <summary>Возвращает объект <see cref="T:System.Collections.Generic.IEnumerable`1" />, где универсальный параметр <paramref name="T" /> имеет значение <see cref="T:System.Data.DataRow" />. Этот объект может использоваться в выражении LINQ или запросе метода.</summary>
		/// <param name="source">Исходный объект <see cref="T:System.Data.DataTable" />, который требуется сделать перечисляемым.</param>
		/// <returns>Объект <see cref="T:System.Collections.Generic.IEnumerable`1" />, где универсальный параметр <paramref name="T" /> имеет значение <see cref="T:System.Data.DataRow" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исходный объект <see cref="T:System.Data.DataTable" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000027 RID: 39 RVA: 0x0000270C File Offset: 0x0000090C
		public static EnumerableRowCollection<DataRow> AsEnumerable(this DataTable source)
		{
			DataSetUtil.CheckArgumentNull<DataTable>(source, "source");
			return new EnumerableRowCollection<DataRow>(source);
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.DataTable" />, содержащий копии объектов <see cref="T:System.Data.DataRow" /> при заданном входном объекте <see cref="T:System.Collections.Generic.IEnumerable`1" /> и универсальном параметре <paramref name="T" />, равном <see cref="T:System.Data.DataRow" />.</summary>
		/// <param name="source">Исходная последовательность <see cref="T:System.Collections.Generic.IEnumerable`1" />.</param>
		/// <typeparam name="T">Тип объектов в исходной последовательности, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий входную последовательность как тип объектов <see cref="T:System.Data.DataRow" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исходная последовательность <see cref="T:System.Collections.Generic.IEnumerable`1" /> имеет значение <see langword="null" /> и создание новой таблицы невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.DataRow" /> в исходной последовательности находится в состоянии <see cref="F:System.Data.DataRowState.Deleted" />.  
		/// Исходная последовательность не содержит объектов <see cref="T:System.Data.DataRow" />.  
		/// Объект <see cref="T:System.Data.DataRow" /> в исходной последовательности имеет значение <see langword="null" />.</exception>
		// Token: 0x06000028 RID: 40 RVA: 0x00002720 File Offset: 0x00000920
		public static DataTable CopyToDataTable<T>(this IEnumerable<T> source) where T : DataRow
		{
			DataSetUtil.CheckArgumentNull<IEnumerable<T>>(source, "source");
			return DataTableExtensions.LoadTableFromEnumerable<T>(source, null, null, null);
		}

		/// <summary>Копирует объекты <see cref="T:System.Data.DataRow" /> в указанный объект <see cref="T:System.Data.DataTable" /> с заданным входным объектом <see cref="T:System.Collections.Generic.IEnumerable`1" />, где универсальный параметр <paramref name="T" /> имеет значение <see cref="T:System.Data.DataRow" />.</summary>
		/// <param name="source">Исходная последовательность <see cref="T:System.Collections.Generic.IEnumerable`1" />.</param>
		/// <param name="table">Назначение <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="options">Перечисление <see cref="T:System.Data.LoadOption" />, указывающее параметры загрузки <see cref="T:System.Data.DataTable" />.</param>
		/// <typeparam name="T">Тип объектов в исходной последовательности, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <exception cref="T:System.ArgumentException">Копируемые объекты <see cref="T:System.Data.DataRow" /> не соответствуют схеме объекта назначения <see cref="T:System.Data.DataTable" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исходная последовательность <see cref="T:System.Collections.Generic.IEnumerable`1" /> имеет значение <see langword="null" /> либо конечный объект <see cref="T:System.Data.DataTable" /> равен <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.DataRow" /> в исходной последовательности находится в состоянии <see cref="F:System.Data.DataRowState.Deleted" />.  
		/// Исходная последовательность не содержит объектов <see cref="T:System.Data.DataRow" />.  
		/// Объект <see cref="T:System.Data.DataRow" /> в исходной последовательности имеет значение <see langword="null" />.</exception>
		// Token: 0x06000029 RID: 41 RVA: 0x00002749 File Offset: 0x00000949
		public static void CopyToDataTable<T>(this IEnumerable<T> source, DataTable table, LoadOption options) where T : DataRow
		{
			DataSetUtil.CheckArgumentNull<IEnumerable<T>>(source, "source");
			DataSetUtil.CheckArgumentNull<DataTable>(table, "table");
			DataTableExtensions.LoadTableFromEnumerable<T>(source, table, new LoadOption?(options), null);
		}

		/// <summary>Копирует объекты <see cref="T:System.Data.DataRow" /> в указанный объект <see cref="T:System.Data.DataTable" /> с заданным входным объектом <see cref="T:System.Collections.Generic.IEnumerable`1" />, где универсальный параметр <paramref name="T" /> имеет значение <see cref="T:System.Data.DataRow" />.</summary>
		/// <param name="source">Исходная последовательность <see cref="T:System.Collections.Generic.IEnumerable`1" />.</param>
		/// <param name="table">Назначение <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="options">Перечисление <see cref="T:System.Data.LoadOption" />, указывающее параметры загрузки <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="errorHandler">Делегат <see cref="T:System.Data.FillErrorEventHandler" />, представляющий метод, который будет обрабатывать ошибки.</param>
		/// <typeparam name="T">Тип объектов в исходной последовательности, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <exception cref="T:System.ArgumentException">Копируемые объекты <see cref="T:System.Data.DataRow" /> не соответствуют схеме объекта назначения <see cref="T:System.Data.DataTable" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исходная последовательность <see cref="T:System.Collections.Generic.IEnumerable`1" /> имеет значение <see langword="null" /> либо конечный объект <see cref="T:System.Data.DataTable" /> равен <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Data.DataRow" /> в исходной последовательности находится в состоянии <see cref="F:System.Data.DataRowState.Deleted" />.  
		///
		/// или - 
		/// Исходная последовательность не содержит объектов <see cref="T:System.Data.DataRow" />.  
		///
		/// или - 
		/// Объект <see cref="T:System.Data.DataRow" /> в исходной последовательности имеет значение <see langword="null" />.</exception>
		// Token: 0x0600002A RID: 42 RVA: 0x00002770 File Offset: 0x00000970
		public static void CopyToDataTable<T>(this IEnumerable<T> source, DataTable table, LoadOption options, FillErrorEventHandler errorHandler) where T : DataRow
		{
			DataSetUtil.CheckArgumentNull<IEnumerable<T>>(source, "source");
			DataSetUtil.CheckArgumentNull<DataTable>(table, "table");
			DataTableExtensions.LoadTableFromEnumerable<T>(source, table, new LoadOption?(options), errorHandler);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002798 File Offset: 0x00000998
		private static DataTable LoadTableFromEnumerable<T>(IEnumerable<T> source, DataTable table, LoadOption? options, FillErrorEventHandler errorHandler) where T : DataRow
		{
			if (options != null)
			{
				LoadOption value = options.Value;
				if (value - LoadOption.OverwriteChanges > 2)
				{
					throw DataSetUtil.InvalidLoadOption(options.Value);
				}
			}
			using (IEnumerator<T> enumerator = source.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					DataTable dataTable = table;
					if (dataTable == null)
					{
						throw DataSetUtil.InvalidOperation("The source contains no DataRows.");
					}
					return dataTable;
				}
				else
				{
					if (table == null)
					{
						DataRow dataRow = enumerator.Current;
						if (dataRow == null)
						{
							throw DataSetUtil.InvalidOperation("The source contains a DataRow reference that is null.");
						}
						table = new DataTable
						{
							Locale = CultureInfo.CurrentCulture
						};
						foreach (object obj in dataRow.Table.Columns)
						{
							DataColumn dataColumn = (DataColumn)obj;
							table.Columns.Add(dataColumn.ColumnName, dataColumn.DataType);
						}
					}
					table.BeginLoadData();
					try
					{
						do
						{
							DataRow dataRow = enumerator.Current;
							if (dataRow != null)
							{
								object[] values = null;
								try
								{
									DataRowState rowState = dataRow.RowState;
									switch (rowState)
									{
									case DataRowState.Detached:
										if (!dataRow.HasVersion(DataRowVersion.Proposed))
										{
											throw DataSetUtil.InvalidOperation("The source contains a detached DataRow that cannot be copied to the DataTable.");
										}
										break;
									case DataRowState.Unchanged:
									case DataRowState.Added:
										break;
									case DataRowState.Detached | DataRowState.Unchanged:
										goto IL_172;
									default:
										if (rowState == DataRowState.Deleted)
										{
											throw DataSetUtil.InvalidOperation("The source contains a deleted DataRow that cannot be copied to the DataTable.");
										}
										if (rowState != DataRowState.Modified)
										{
											goto IL_172;
										}
										break;
									}
									values = dataRow.ItemArray;
									if (options != null)
									{
										table.LoadDataRow(values, options.Value);
									}
									else
									{
										table.LoadDataRow(values, true);
									}
									goto IL_1DA;
									IL_172:
									throw DataSetUtil.InvalidDataRowState(dataRow.RowState);
								}
								catch (Exception ex)
								{
									if (!DataSetUtil.IsCatchableExceptionType(ex))
									{
										throw;
									}
									FillErrorEventArgs fillErrorEventArgs = null;
									if (errorHandler != null)
									{
										fillErrorEventArgs = new FillErrorEventArgs(table, values)
										{
											Errors = ex
										};
										errorHandler(enumerator, fillErrorEventArgs);
									}
									if (fillErrorEventArgs == null)
									{
										throw;
									}
									if (!fillErrorEventArgs.Continue)
									{
										if ((fillErrorEventArgs.Errors ?? ex) == ex)
										{
											throw;
										}
										throw fillErrorEventArgs.Errors;
									}
								}
							}
							IL_1DA:;
						}
						while (enumerator.MoveNext());
					}
					finally
					{
						table.EndLoadData();
					}
				}
			}
			return table;
		}

		/// <summary>Создает и возвращает объект <see cref="T:System.Data.DataView" /> с поддержкой LINQ.</summary>
		/// <param name="table">Исходный объект <see cref="T:System.Data.DataTable" />, на основе которого создается объект <see cref="T:System.Data.DataView" /> с поддержкой LINQ.</param>
		/// <returns>Объект <see cref="T:System.Data.DataView" /> с поддержкой LINQ.</returns>
		// Token: 0x0600002C RID: 44 RVA: 0x00002A04 File Offset: 0x00000C04
		public static DataView AsDataView(this DataTable table)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Создает и возвращает объект <see cref="T:System.Data.DataView" /> с поддержкой LINQ, представляющий запрос LINQ to DataSet.</summary>
		/// <param name="source">Исходный запрос LINQ to DataSet, на основе которого создается объект <see cref="T:System.Data.DataView" /> с поддержкой LINQ.</param>
		/// <typeparam name="T">Тип объектов в исходной последовательности, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.DataView" /> с поддержкой LINQ.</returns>
		// Token: 0x0600002D RID: 45 RVA: 0x00002A04 File Offset: 0x00000C04
		public static DataView AsDataView<T>(this EnumerableRowCollection<T> source) where T : DataRow
		{
			throw new PlatformNotSupportedException();
		}
	}
}
