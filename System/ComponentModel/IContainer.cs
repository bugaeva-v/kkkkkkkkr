using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет функции для контейнеров. Контейнеры являются объектами, которые логически содержат нуль или более компонентов.</summary>
	// Token: 0x0200036E RID: 878
	public interface IContainer : IDisposable
	{
		/// <summary>Добавляет указанный компонент <see cref="T:System.ComponentModel.IComponent" /> в конец списка контейнера <see cref="T:System.ComponentModel.IContainer" />.</summary>
		/// <param name="component">Добавляемый объект <see cref="T:System.ComponentModel.IComponent" />.</param>
		// Token: 0x06001D11 RID: 7441
		void Add(IComponent component);

		/// <summary>Добавляет указанный компонент <see cref="T:System.ComponentModel.IComponent" /> в конец списка в объект <see cref="T:System.ComponentModel.IContainer" /> и назначает компоненту имя.</summary>
		/// <param name="component">Добавляемый объект <see cref="T:System.ComponentModel.IComponent" />.</param>
		/// <param name="name">Назначаемое компоненту уникальное имя, в котором не учитывается регистр.  
		///
		/// или - 
		/// Значение <see langword="null" />, при котором компонент остается безымянным.</param>
		// Token: 0x06001D12 RID: 7442
		void Add(IComponent component, string name);

		/// <summary>Получает все компоненты в контейнере <see cref="T:System.ComponentModel.IContainer" />.</summary>
		/// <returns>Коллекция объектов <see cref="T:System.ComponentModel.IComponent" />, представляющая все компоненты в контейнере <see cref="T:System.ComponentModel.IContainer" />.</returns>
		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001D13 RID: 7443
		ComponentCollection Components { get; }

		/// <summary>Удаляет компонент из контейнера <see cref="T:System.ComponentModel.IContainer" />.</summary>
		/// <param name="component">Объект <see cref="T:System.ComponentModel.IComponent" /> для удаления.</param>
		// Token: 0x06001D14 RID: 7444
		void Remove(IComponent component);
	}
}
