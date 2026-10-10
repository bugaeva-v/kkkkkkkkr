using System;

namespace System.Data
{
	/// <summary>Происходит, если целевой и исходный объекты <see langword="DataRow" /> имеют одинаковое значение первичного ключа и если свойство <see cref="P:System.Data.DataSet.EnforceConstraints" /> имеет значение true.</summary>
	// Token: 0x0200010E RID: 270
	public class MergeFailedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.MergeFailedEventArgs" /> с <see cref="T:System.Data.DataTable" /> и описанием конфликта слияния.</summary>
		/// <param name="table">Объект <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="conflict">Описание конфликта слияния.</param>
		// Token: 0x06000F82 RID: 3970 RVA: 0x0003EC03 File Offset: 0x0003CE03
		public MergeFailedEventArgs(DataTable table, string conflict)
		{
			this.Table = table;
			this.Conflict = conflict;
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.DataTable" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0003EC19 File Offset: 0x0003CE19
		public DataTable Table { get; }

		/// <summary>Возвращает описание конфликта слияния.</summary>
		/// <returns>Описание конфликта слияния.</returns>
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0003EC21 File Offset: 0x0003CE21
		public string Conflict { get; }
	}
}
