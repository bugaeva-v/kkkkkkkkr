using System;
using System.Collections.Generic;

namespace System.Data
{
	/// <summary>Сравнивает два объекта <see cref="T:System.Data.DataRow" /> на эквивалентность путем использования сравнения на основе значений.</summary>
	/// <typeparam name="TRow">Тип сравниваемых объектов, обычно это <see cref="T:System.Data.DataRow" />.</typeparam>
	// Token: 0x02000006 RID: 6
	public sealed class DataRowComparer<TRow> : IEqualityComparer<TRow> where TRow : DataRow
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000021DF File Offset: 0x000003DF
		private DataRowComparer()
		{
		}

		/// <summary>Получает одноэлементный экземпляр класса <see cref="T:System.Data.DataRowComparer`1" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Data.DataRowComparer`1" />.</returns>
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000023D3 File Offset: 0x000005D3
		public static DataRowComparer<TRow> Default
		{
			get
			{
				return DataRowComparer<TRow>.s_instance;
			}
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Data.DataRow" /> путем использования сравнения по столбцам на основе значений.</summary>
		/// <param name="leftRow">Первый из сравниваемых объектов <see cref="T:System.Data.DataRow" />.</param>
		/// <param name="rightRow">Второй из сравниваемых объектов <see cref="T:System.Data.DataRow" />.</param>
		/// <returns>Значение <see langword="true" />, если два объекта <see cref="T:System.Data.DataRow" /> запросили наборы равных значений столбцов; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Один или оба исходных объекта <see cref="T:System.Data.DataRow" /> содержат <see langword="null" />.</exception>
		// Token: 0x06000017 RID: 23 RVA: 0x000023DC File Offset: 0x000005DC
		public bool Equals(TRow leftRow, TRow rightRow)
		{
			if (leftRow == rightRow)
			{
				return true;
			}
			if (leftRow == null || rightRow == null)
			{
				return false;
			}
			if (leftRow.RowState == DataRowState.Deleted || rightRow.RowState == DataRowState.Deleted)
			{
				throw DataSetUtil.InvalidOperation("The DataRowComparer does not work with DataRows that have been deleted since it only compares current values.");
			}
			int count = leftRow.Table.Columns.Count;
			if (count != rightRow.Table.Columns.Count)
			{
				return false;
			}
			for (int i = 0; i < count; i++)
			{
				if (!DataRowComparer.AreEqual(leftRow[i], rightRow[i]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает хэш-код указанного объекта <see cref="T:System.Data.DataRow" />.</summary>
		/// <param name="row">Строка <see cref="T:System.Data.DataRow" />, на основе которой следует вычислить хэш-код.</param>
		/// <returns>Возвращает значение <see cref="T:System.Int32" />, которое представляет хэш-код строки.</returns>
		/// <exception cref="T:System.ArgumentException">Исходные объекты <see cref="T:System.Data.DataRow" /> не принадлежат таблице <see cref="T:System.Data.DataTable" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исходные объекты <see cref="T:System.Data.DataRow" /> имеют значение <see langword="null" />.</exception>
		// Token: 0x06000018 RID: 24 RVA: 0x00002490 File Offset: 0x00000690
		public int GetHashCode(TRow row)
		{
			DataSetUtil.CheckArgumentNull<TRow>(row, "row");
			if (row.RowState == DataRowState.Deleted)
			{
				throw DataSetUtil.InvalidOperation("The DataRowComparer does not work with DataRows that have been deleted since it only compares current values.");
			}
			int result = 0;
			if (row.Table.Columns.Count > 0)
			{
				object obj = row[0];
				if (obj.GetType().IsArray)
				{
					Array array = obj as Array;
					if (array.Rank > 1)
					{
						result = obj.GetHashCode();
					}
					else if (array.Length > 0)
					{
						result = array.GetValue(array.GetLowerBound(0)).GetHashCode();
					}
				}
				else
				{
					ValueType valueType = obj as ValueType;
					if (valueType != null)
					{
						result = valueType.GetHashCode();
					}
					else
					{
						result = obj.GetHashCode();
					}
				}
			}
			return result;
		}

		// Token: 0x04000037 RID: 55
		private static DataRowComparer<TRow> s_instance = new DataRowComparer<TRow>();
	}
}
