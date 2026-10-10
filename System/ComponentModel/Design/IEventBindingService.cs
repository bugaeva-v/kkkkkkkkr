using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет службу регистрации обработчиков событий для событий в компонентах.</summary>
	// Token: 0x02000460 RID: 1120
	public interface IEventBindingService
	{
		/// <summary>Создает уникальное имя для метода обработчика событий заданного компонента и события.</summary>
		/// <param name="component">Экземпляр компонента, с которым связано событие.</param>
		/// <param name="e">Событие, для которого должно быть создано имя.</param>
		/// <returns>Рекомендованное имя метода обработчика событий для данного события.</returns>
		// Token: 0x06002445 RID: 9285
		string CreateUniqueMethodName(IComponent component, EventDescriptor e);

		/// <summary>Возвращает коллекцию методов обработчика событий, обладающих сигнатурой метода, совместимой с заданным событием.</summary>
		/// <param name="e">Событие, для которого необходимо получить совместимые методы обработчика событий.</param>
		/// <returns>Коллекция строк.</returns>
		// Token: 0x06002446 RID: 9286
		ICollection GetCompatibleMethods(EventDescriptor e);

		/// <summary>Возвращает дескриптор <see cref="T:System.ComponentModel.EventDescriptor" /> для события, которое представлено заданным дескриптором свойств, если он отражает событие.</summary>
		/// <param name="property">Свойство, представляющее событие.</param>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.EventDescriptor" /> для события, представляемого свойством, или значение <see langword="null" />, если свойство не представляет событие.</returns>
		// Token: 0x06002447 RID: 9287
		EventDescriptor GetEvent(PropertyDescriptor property);

		/// <summary>Преобразует набор дескрипторов событий в набор дескрипторов свойств.</summary>
		/// <param name="events">События для преобразования в свойства.</param>
		/// <returns>Массив объектов <see cref="T:System.ComponentModel.PropertyDescriptor" />, описывающих набор событий.</returns>
		// Token: 0x06002448 RID: 9288
		PropertyDescriptorCollection GetEventProperties(EventDescriptorCollection events);

		/// <summary>Преобразует один дескриптор событий в дескриптор свойств.</summary>
		/// <param name="e">Преобразуемое событие.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, описывающий событие.</returns>
		// Token: 0x06002449 RID: 9289
		PropertyDescriptor GetEventProperty(EventDescriptor e);

		/// <summary>Отображает код пользователя для конструктора.</summary>
		/// <returns>Значение <see langword="true" />, если код отображается; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600244A RID: 9290
		bool ShowCode();

		/// <summary>Отображает код пользователя для конструктора в заданной строке.</summary>
		/// <param name="lineNumber">Номер строки для размещения курсора.</param>
		/// <returns>Значение <see langword="true" />, если код отображается; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600244B RID: 9291
		bool ShowCode(int lineNumber);

		/// <summary>Отображает код пользователя для заданного события.</summary>
		/// <param name="component">Компонент, с которым связано событие.</param>
		/// <param name="e">Отображаемое событие.</param>
		/// <returns>Значение <see langword="true" />, если код отображается; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600244C RID: 9292
		bool ShowCode(IComponent component, EventDescriptor e);
	}
}
