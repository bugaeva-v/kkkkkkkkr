using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет данные для события <see cref="P:System.ComponentModel.Design.IDesignerEventService.ActiveDesigner" />.</summary>
	// Token: 0x0200043C RID: 1084
	public class ActiveDesignerEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.ActiveDesignerEventArgs" />.</summary>
		/// <param name="oldDesigner">Документ, который перестает быть активным.</param>
		/// <param name="newDesigner">Документ, который становится активным.</param>
		// Token: 0x0600237A RID: 9082 RVA: 0x00080FBD File Offset: 0x0007F1BD
		public ActiveDesignerEventArgs(IDesignerHost oldDesigner, IDesignerHost newDesigner)
		{
			this.OldDesigner = oldDesigner;
			this.NewDesigner = newDesigner;
		}

		/// <summary>Возвращает документ, который перестает быть активным.</summary>
		/// <returns>узел <see cref="T:System.ComponentModel.Design.IDesignerHost" />, представляющий документ, который перестает быть активным.</returns>
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x00080FD3 File Offset: 0x0007F1D3
		public IDesignerHost OldDesigner { get; }

		/// <summary>Возвращает документ, который становится активным.</summary>
		/// <returns>узел <see cref="T:System.ComponentModel.Design.IDesignerHost" />, представляющий документ, который становится активным.</returns>
		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00080FDB File Offset: 0x0007F1DB
		public IDesignerHost NewDesigner { get; }
	}
}
