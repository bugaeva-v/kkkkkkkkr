using System;
using System.ComponentModel;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет интерфейс для управления изображениями, подсказками и обработчиками событий для свойств компонентов, отображенных в обозревателе свойств.</summary>
	// Token: 0x02000121 RID: 289
	public interface IPropertyValueUIService
	{
		/// <summary>Происходит при изменении списка объектов <see cref="T:System.Drawing.Design.PropertyValueUIItem" />.</summary>
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000D72 RID: 3442
		// (remove) Token: 0x06000D73 RID: 3443
		event EventHandler PropertyUIValueItemsChanged;

		/// <summary>Добавляет указанный обработчик <see cref="T:System.Drawing.Design.PropertyValueUIHandler" /> в данную службу.</summary>
		/// <param name="newHandler">Добавляемый обработчик пользовательского интерфейса для значения свойства.</param>
		// Token: 0x06000D74 RID: 3444
		void AddPropertyValueUIHandler(PropertyValueUIHandler newHandler);

		/// <summary>Возвращает объекты <see cref="T:System.Drawing.Design.PropertyValueUIItem" />, которые соответствуют заданному контексту и характеристикам дескриптора свойства.</summary>
		/// <param name="context">Интерфейс <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для получения дополнительных сведений о контексте.</param>
		/// <param name="propDesc">Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, который указывает свойство, соответствующее возвращаемому свойству.</param>
		/// <returns>Массив объектов <see cref="T:System.Drawing.Design.PropertyValueUIItem" />, соответствующих заданным параметрам.</returns>
		// Token: 0x06000D75 RID: 3445
		PropertyValueUIItem[] GetPropertyUIValueItems(ITypeDescriptorContext context, PropertyDescriptor propDesc);

		/// <summary>Уведомляет реализацию <see cref="T:System.Drawing.Design.IPropertyValueUIService" /> об изменении глобального списка объектов <see cref="T:System.Drawing.Design.PropertyValueUIItem" />.</summary>
		// Token: 0x06000D76 RID: 3446
		void NotifyPropertyValueUIItemsChanged();

		/// <summary>Удаляет из службы пользовательского интерфейса значения свойства заданный обработчик <see cref="T:System.Drawing.Design.PropertyValueUIHandler" />.</summary>
		/// <param name="newHandler">Удаляемый обработчик.</param>
		// Token: 0x06000D77 RID: 3447
		void RemovePropertyValueUIHandler(PropertyValueUIHandler newHandler);
	}
}
