using System;

namespace System.Data
{
	/// <summary>Предоставляет данные для метода <see cref="M:System.Data.DataTable.Clear" />.</summary>
	// Token: 0x020000CC RID: 204
	public sealed class DataTableClearEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DataTableClearEventArgs" />.</summary>
		/// <param name="dataTable">Объект <see cref="T:System.Data.DataTable" />, строки которого очищаются.</param>
		// Token: 0x06000C55 RID: 3157 RVA: 0x00032816 File Offset: 0x00030A16
		public DataTableClearEventArgs(DataTable dataTable)
		{
			this.Table = dataTable;
		}

		/// <summary>Возвращает таблицу, строки которой очищаются.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, строки которого очищаются.</returns>
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00032825 File Offset: 0x00030A25
		public DataTable Table { get; }

		/// <summary>Возвращает имя таблицы, строки которой очищаются.</summary>
		/// <returns>Значение <see cref="T:System.String" />, указывающее имя таблицы.</returns>
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0003282D File Offset: 0x00030A2D
		public string TableName
		{
			get
			{
				return this.Table.TableName;
			}
		}

		/// <summary>Возвращает пространство имен таблицы, строки которой очищаются.</summary>
		/// <returns>Значение <see cref="T:System.String" />, указывающее имя пространства имен.</returns>
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003283A File Offset: 0x00030A3A
		public string TableNamespace
		{
			get
			{
				return this.Table.Namespace;
			}
		}
	}
}
