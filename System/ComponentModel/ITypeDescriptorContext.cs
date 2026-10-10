using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет контекстную информацию о компоненте, например, его контейнер и дескриптор свойства.</summary>
	// Token: 0x020003BC RID: 956
	public interface ITypeDescriptorContext : IServiceProvider
	{
		/// <summary>Возвращает контейнер, представляющий это запрос <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <returns>Контейнер <see cref="T:System.ComponentModel.IContainer" /> с набором объектов для этого дескриптора <see cref="T:System.ComponentModel.TypeDescriptor" />; в противном случае — значение <see langword="null" />, если контейнер отсутствует или если дескриптор <see cref="T:System.ComponentModel.TypeDescriptor" /> не использует внешних объектов.</returns>
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001F1D RID: 7965
		IContainer Container { get; }

		/// <summary>Возвращает объект, связанный с этим запросом дескриптора типа.</summary>
		/// <returns>Объект, вызывающий метод для дескриптора <see cref="T:System.ComponentModel.TypeDescriptor" />; в противном случае — значение <see langword="null" />, если ответственный за вызов объект отсутствует.</returns>
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001F1E RID: 7966
		object Instance { get; }

		/// <summary>Возвращает <see cref="T:System.ComponentModel.PropertyDescriptor" />, связанный с заданным элементом контекста.</summary>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, описывающий данный элемент контекста; в противном случае — значение <see langword="null" />, если отсутствует дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, ответственный за вызов.</returns>
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001F1F RID: 7967
		PropertyDescriptor PropertyDescriptor { get; }

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanging" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект может быть изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F20 RID: 7968
		bool OnComponentChanging();

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanged" />.</summary>
		// Token: 0x06001F21 RID: 7969
		void OnComponentChanged();
	}
}
