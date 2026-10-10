using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет способ сгруппировать последовательность действий этапа разработки, что позволяет повысить производительность и дает возможность отменять действия большинства типов.</summary>
	// Token: 0x02000448 RID: 1096
	public abstract class DesignerTransaction : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerTransaction" /> без описания.</summary>
		// Token: 0x060023AB RID: 9131 RVA: 0x000811B5 File Offset: 0x0007F3B5
		protected DesignerTransaction() : this("")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerTransaction" /> с помощью указанного описания транзакции.</summary>
		/// <param name="description">Описание транзакции.</param>
		// Token: 0x060023AC RID: 9132 RVA: 0x000811C2 File Offset: 0x0007F3C2
		protected DesignerTransaction(string description)
		{
			this.Description = description;
		}

		/// <summary>Возвращает значение, определяющее, была ли отменена данная транзакция.</summary>
		/// <returns>Значение <see langword="true" />, если транзакция была отменена; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x000811D1 File Offset: 0x0007F3D1
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x000811D9 File Offset: 0x0007F3D9
		public bool Canceled { get; private set; }

		/// <summary>Возвращает значение, определяющее, была ли зафиксирована данная транзакция.</summary>
		/// <returns>Значение <see langword="true" />, если транзакция была зафиксирована; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x000811E2 File Offset: 0x0007F3E2
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x000811EA File Offset: 0x0007F3EA
		public bool Committed { get; private set; }

		/// <summary>Возвращает описание транзакции.</summary>
		/// <returns>Описание транзакции.</returns>
		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x000811F3 File Offset: 0x0007F3F3
		public string Description { get; }

		/// <summary>Отменяет транзакцию и пытается отменить все действия, выполненные событиями транзакции.</summary>
		// Token: 0x060023B2 RID: 9138 RVA: 0x000811FB File Offset: 0x0007F3FB
		public void Cancel()
		{
			if (!this.Canceled && !this.Committed)
			{
				this.Canceled = true;
				GC.SuppressFinalize(this);
				this._suppressedFinalization = true;
				this.OnCancel();
			}
		}

		/// <summary>Фиксирует транзакцию.</summary>
		// Token: 0x060023B3 RID: 9139 RVA: 0x00081227 File Offset: 0x0007F427
		public void Commit()
		{
			if (!this.Committed && !this.Canceled)
			{
				this.Committed = true;
				GC.SuppressFinalize(this);
				this._suppressedFinalization = true;
				this.OnCommit();
			}
		}

		/// <summary>Вызывает событие <see langword="Cancel" />.</summary>
		// Token: 0x060023B4 RID: 9140
		protected abstract void OnCancel();

		/// <summary>Фактически фиксирует транзакцию.</summary>
		// Token: 0x060023B5 RID: 9141
		protected abstract void OnCommit();

		/// <summary>Освобождает ресурсы, связанные с данным объектом. Этот метод фиксирует транзакцию, если она не была зафиксирована ранее.</summary>
		// Token: 0x060023B6 RID: 9142 RVA: 0x00081254 File Offset: 0x0007F454
		~DesignerTransaction()
		{
			this.Dispose(false);
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.ComponentModel.Design.DesignerTransaction" />.</summary>
		// Token: 0x060023B7 RID: 9143 RVA: 0x00081284 File Offset: 0x0007F484
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			if (!this._suppressedFinalization)
			{
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.Design.DesignerTransaction" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060023B8 RID: 9144 RVA: 0x0008129B File Offset: 0x0007F49B
		protected virtual void Dispose(bool disposing)
		{
			this.Cancel();
		}

		// Token: 0x040010BA RID: 4282
		private bool _suppressedFinalization;
	}
}
