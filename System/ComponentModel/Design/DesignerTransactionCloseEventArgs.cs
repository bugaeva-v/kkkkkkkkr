using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет данные для событий <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosed" /> и <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosing" />.</summary>
	// Token: 0x02000449 RID: 1097
	public class DesignerTransactionCloseEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerTransactionCloseEventArgs" />, используя заданное значение, указывающее, вызывал ли конструктор метод <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" /> для транзакции.</summary>
		/// <param name="commit">Значение, определяющее, была ли зафиксирована данная транзакция.</param>
		// Token: 0x060023B9 RID: 9145 RVA: 0x000812A3 File Offset: 0x0007F4A3
		[Obsolete("This constructor is obsolete. Use DesignerTransactionCloseEventArgs(bool, bool) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public DesignerTransactionCloseEventArgs(bool commit) : this(commit, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerTransactionCloseEventArgs" />.</summary>
		/// <param name="commit">Значение, определяющее, была ли зафиксирована данная транзакция.</param>
		/// <param name="lastTransaction">
		///   <see langword="true" />, если это последняя транзакция, которая должна быть закрыта; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060023BA RID: 9146 RVA: 0x000812AD File Offset: 0x0007F4AD
		public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction)
		{
			this.TransactionCommitted = commit;
			this.LastTransaction = lastTransaction;
		}

		/// <summary>Указывает, вызывал ли конструктор метод <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" /> для транзакции.</summary>
		/// <returns>Значение <see langword="true" /> если конструктор вызывал метод <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" /> для транзакции, в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x000812C3 File Offset: 0x0007F4C3
		public bool TransactionCommitted { get; }

		/// <summary>Возвращает значение, указывающее, является ли данная транзакция последней, которая должна быть закрыта.</summary>
		/// <returns>
		///   <see langword="true" />, если это последняя транзакция, которая должна быть закрыта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000812CB File Offset: 0x0007F4CB
		public bool LastTransaction { get; }
	}
}
