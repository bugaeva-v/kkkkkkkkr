using System;
using System.ComponentModel.Design;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Drawing.Design.ToolboxItem.ComponentsCreating" />, происходящего при добавлении компонентов на панель инструментов.</summary>
	// Token: 0x0200012B RID: 299
	public class ToolboxComponentsCreatingEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.ToolboxComponentsCreatingEventArgs" />.</summary>
		/// <param name="host">Хост-узел конструктора, создающего запрос.</param>
		// Token: 0x06000DB1 RID: 3505 RVA: 0x0001F0A4 File Offset: 0x0001D2A4
		public ToolboxComponentsCreatingEventArgs(IDesignerHost host)
		{
			this.host = host;
		}

		/// <summary>Получает или задает экземпляр <see cref="T:System.ComponentModel.Design.IDesignerHost" />, выдавший запрос для создания компонентов панели инструментов.</summary>
		/// <returns>Интерфейс <see cref="T:System.ComponentModel.Design.IDesignerHost" />, выдавший запрос для создания компонентов панели инструментов, либо значение <see langword="null" />, если для элемента панели инструментов не был предоставлен хост-узел конструктора.</returns>
		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0001F0B3 File Offset: 0x0001D2B3
		public IDesignerHost DesignerHost
		{
			get
			{
				return this.host;
			}
		}

		// Token: 0x04000AA3 RID: 2723
		private readonly IDesignerHost host;
	}
}
