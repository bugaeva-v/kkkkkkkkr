using System;
using System.ComponentModel;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Drawing.Design.ToolboxItem.ComponentsCreated" />, происходящего при добавлении компонентов на панель инструментов.</summary>
	// Token: 0x02000129 RID: 297
	public class ToolboxComponentsCreatedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.ToolboxComponentsCreatedEventArgs" />.</summary>
		/// <param name="components">Компоненты, которые нужно включить на панель инструментов.</param>
		// Token: 0x06000DAB RID: 3499 RVA: 0x0001F083 File Offset: 0x0001D283
		public ToolboxComponentsCreatedEventArgs(IComponent[] components)
		{
			this.comps = components;
		}

		/// <summary>Возвращает или задает массив, содержащий компоненты, добавляемые на панель инструментов.</summary>
		/// <returns>Массив объектов типа <see cref="T:System.ComponentModel.IComponent" />, определяющий компоненты, добавляемые на панель инструментов.</returns>
		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0001F092 File Offset: 0x0001D292
		public IComponent[] Components
		{
			get
			{
				return (IComponent[])this.comps.Clone();
			}
		}

		// Token: 0x04000AA2 RID: 2722
		private readonly IComponent[] comps;
	}
}
