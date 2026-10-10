using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет функции, необходимые для сайтов.</summary>
	// Token: 0x0200036F RID: 879
	public interface ISite : IServiceProvider
	{
		/// <summary>Возвращает компонент, связанный с объектом интерфейсом <see cref="T:System.ComponentModel.ISite" /> при реализации классом.</summary>
		/// <returns>Экземпляр <see cref="T:System.ComponentModel.IComponent" />, связанный с объектом <see cref="T:System.ComponentModel.ISite" />.</returns>
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001D15 RID: 7445
		IComponent Component { get; }

		/// <summary>Возвращает интерфейс <see cref="T:System.ComponentModel.IContainer" />, при реализации классом связанный с интерфейсом <see cref="T:System.ComponentModel.ISite" />.</summary>
		/// <returns>Экземпляр <see cref="T:System.ComponentModel.IContainer" />, связанный с объектом <see cref="T:System.ComponentModel.ISite" />.</returns>
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001D16 RID: 7446
		IContainer Container { get; }

		/// <summary>Определяет, находится ли компонент в режиме разработки при реализации классом.</summary>
		/// <returns>Значение <see langword="true" />, если компонент находится в режиме разработки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001D17 RID: 7447
		bool DesignMode { get; }

		/// <summary>При реализации классом возвращает или задает имя компонента, связанного с интерфейсом <see cref="T:System.ComponentModel.ISite" />.</summary>
		/// <returns>Имя компонента, связанного с интерфейсом <see cref="T:System.ComponentModel.ISite" />; или значение <see langword="null" />, если компоненту не присвоено имя.</returns>
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001D18 RID: 7448
		// (set) Token: 0x06001D19 RID: 7449
		string Name { get; set; }
	}
}
