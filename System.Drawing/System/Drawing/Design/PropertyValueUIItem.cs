using System;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет информацию о свойствах, отображаемых в окне свойств, включая информацию, связанную с обработчиком событий, всплывающую информационную строку и значок для отображения свойства.</summary>
	// Token: 0x02000127 RID: 295
	public class PropertyValueUIItem
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Design.PropertyValueUIItem" />.</summary>
		/// <param name="uiItemImage">Отображаемый значок. Изображение должно иметь размер 8 x 8 пикселей.</param>
		/// <param name="handler">Обработчик, который должен быть активирован при двойном щелчке.</param>
		/// <param name="tooltip">Свойство <see cref="P:System.Drawing.Design.PropertyValueUIItem.ToolTip" /> для отображения свойства, сопоставленного данному объекту <see cref="T:System.Drawing.Design.PropertyValueUIItem" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="uiItemImage" /> или <paramref name="handler" /> — <see langword="null" />.</exception>
		// Token: 0x06000DA2 RID: 3490 RVA: 0x0001F02D File Offset: 0x0001D22D
		public PropertyValueUIItem(Image uiItemImage, PropertyValueUIItemInvokeHandler handler, string tooltip)
		{
			this.itemImage = uiItemImage;
			this.handler = handler;
			if (this.itemImage == null)
			{
				throw new ArgumentNullException("uiItemImage");
			}
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			this.tooltip = tooltip;
		}

		/// <summary>Возвращает или задает изображение из 8 x 8 пикселей для отрисовки в окне свойств.</summary>
		/// <returns>Изображение, которое должно быть использовано для значка свойства.</returns>
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0001F06B File Offset: 0x0001D26B
		public virtual Image Image
		{
			get
			{
				return this.itemImage;
			}
		}

		/// <summary>Возвращает обработчик, который вызывается при двойном щелчке данного элемента.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Design.PropertyValueUIItemInvokeHandler" />, определяющий обработчик событий для данного элемента пользовательского интерфейса.</returns>
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x0001F073 File Offset: 0x0001D273
		public virtual PropertyValueUIItemInvokeHandler InvokeHandler
		{
			get
			{
				return this.handler;
			}
		}

		/// <summary>Получает или задает информационную строку которая должна быть отображена для данного элемента.</summary>
		/// <returns>Строка, содержащая информационную строку, изображенную для данного элемента.</returns>
		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0001F07B File Offset: 0x0001D27B
		public virtual string ToolTip
		{
			get
			{
				return this.tooltip;
			}
		}

		/// <summary>Восстанавливает первоначальные параметры элемента пользовательского интерфейса.</summary>
		// Token: 0x06000DA6 RID: 3494 RVA: 0x000049FE File Offset: 0x00002BFE
		public virtual void Reset()
		{
		}

		// Token: 0x04000A9F RID: 2719
		private Image itemImage;

		// Token: 0x04000AA0 RID: 2720
		private PropertyValueUIItemInvokeHandler handler;

		// Token: 0x04000AA1 RID: 2721
		private string tooltip;
	}
}
