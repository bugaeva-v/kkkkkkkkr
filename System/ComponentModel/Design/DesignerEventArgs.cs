using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет данные для событий <see cref="E:System.ComponentModel.Design.IDesignerEventService.DesignerCreated" /> и <see cref="E:System.ComponentModel.Design.IDesignerEventService.DesignerDisposed" />.</summary>
	// Token: 0x02000451 RID: 1105
	public class DesignerEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerEventArgs" />.</summary>
		/// <param name="host">узел <see cref="T:System.ComponentModel.Design.IDesignerHost" /> документа.</param>
		// Token: 0x060023EE RID: 9198 RVA: 0x0008180E File Offset: 0x0007FA0E
		public DesignerEventArgs(IDesignerHost host)
		{
			this.Designer = host;
		}

		/// <summary>Возвращает хост документа.</summary>
		/// <returns>узел <see cref="T:System.ComponentModel.Design.IDesignerHost" /> документа.</returns>
		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0008181D File Offset: 0x0007FA1D
		public IDesignerHost Designer { get; }
	}
}
