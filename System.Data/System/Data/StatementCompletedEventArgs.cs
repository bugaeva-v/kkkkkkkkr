using System;

namespace System.Data
{
	/// <summary>Предоставляет дополнительные сведения для события <see cref="E:System.Data.SqlClient.SqlCommand.StatementCompleted" />.</summary>
	// Token: 0x02000133 RID: 307
	public sealed class StatementCompletedEventArgs : EventArgs
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Data.StatementCompletedEventArgs" />.</summary>
		/// <param name="recordCount">Указывает количество строк, на которые повлиял оператор, применение которого вызвало событие <see cref="E:System.Data.SqlClient.SqlCommand.StatementCompleted" />.</param>
		// Token: 0x060010A9 RID: 4265 RVA: 0x00045C00 File Offset: 0x00043E00
		public StatementCompletedEventArgs(int recordCount)
		{
			this.RecordCount = recordCount;
		}

		/// <summary>Указывает количество строк, на которые повлиял оператор, применение которого вызвало событие <see cref="E:System.Data.SqlClient.SqlCommand.StatementCompleted" />.</summary>
		/// <returns>Число обработанных строк.</returns>
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00045C0F File Offset: 0x00043E0F
		public int RecordCount { get; }
	}
}
