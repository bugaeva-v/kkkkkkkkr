using System;

namespace System.Data
{
	/// <summary>Тип делегата для обработчиков событий, относящихся к событию <see cref="E:System.Data.SqlClient.SqlCommand.StatementCompleted" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Данные для события.</param>
	// Token: 0x02000134 RID: 308
	// (Invoke) Token: 0x060010AC RID: 4268
	public delegate void StatementCompletedEventHandler(object sender, StatementCompletedEventArgs e);
}
