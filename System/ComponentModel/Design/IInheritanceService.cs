using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет методы, указывающие компоненты компонента.</summary>
	// Token: 0x02000464 RID: 1124
	public interface IInheritanceService
	{
		/// <summary>Выполняет поиск в заданном компоненте полей, которые реализуют интерфейс <see cref="T:System.ComponentModel.IComponent" />, а также добавляет каждое из них в заданный контейнер, сохраняя уровень наследования каждого поля, которое может быть извлечено с использованием метода <see cref="M:System.ComponentModel.Design.IInheritanceService.GetInheritanceAttribute(System.ComponentModel.IComponent)" />.</summary>
		/// <param name="component">Объект <see cref="T:System.ComponentModel.IComponent" />, в котором будет выполнен поиск. Поиск начинается с данного компонента.</param>
		/// <param name="container">Интерфейс <see cref="T:System.ComponentModel.IContainer" />, в который будут добавлены компоненты.</param>
		// Token: 0x06002457 RID: 9303
		void AddInheritedComponents(IComponent component, IContainer container);

		/// <summary>Возвращает атрибут наследования для заданного компонента.</summary>
		/// <param name="component">Интерфейс <see cref="T:System.ComponentModel.IComponent" />, для которого должен быть извлечен атрибут наследования.</param>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.InheritanceAttribute" />, который описывает уровень наследования заданного компонента.</returns>
		// Token: 0x06002458 RID: 9304
		InheritanceAttribute GetInheritanceAttribute(IComponent component);
	}
}
