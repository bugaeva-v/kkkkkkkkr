using System;

namespace System.Data
{
	/// <summary>Предоставляет данные для метода <see cref="M:System.Data.DataTable.NewRow" />.</summary>
	// Token: 0x020000CF RID: 207
	public sealed class DataTableNewRowEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Data.DataTableNewRowEventArgs" />.</summary>
		/// <param name="dataRow">Добавляемый объект <see cref="T:System.Data.DataRow" />.</param>
		// Token: 0x06000C8D RID: 3213 RVA: 0x0003374B File Offset: 0x0003194B
		public DataTableNewRowEventArgs(DataRow dataRow)
		{
			this.Row = dataRow;
		}

		/// <summary>Получает добавляемую строку.</summary>
		/// <returns>Добавляемый объект <see cref="T:System.Data.DataRow" />.</returns>
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0003375A File Offset: 0x0003195A
		public DataRow Row { get; }
	}
}
