using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс для получения ссылок на объекты проекта по имени или типу, для получения имени заданного объекта, а также для поиска родительского объекта для заданного объекта в проекте конструктора.</summary>
	// Token: 0x02000466 RID: 1126
	public interface IReferenceService
	{
		/// <summary>Получает компонент, содержащий заданный компонент.</summary>
		/// <param name="reference">Объект, для которого загружается родительский компонент.</param>
		/// <returns>Базовый интерфейс <see cref="T:System.ComponentModel.IComponent" />, содержащий заданный объект, или значение <see langword="null" />, если родительского компонента не существует.</returns>
		// Token: 0x06002461 RID: 9313
		IComponent GetComponent(object reference);

		/// <summary>Получает ссылку на компонент, имя которого соответствует заданному имени.</summary>
		/// <param name="name">Имя компонента, на который возвращается ссылка.</param>
		/// <returns>Объект, на который ссылается указанное имя, или значение <see langword="null" />, если ссылка не найдена.</returns>
		// Token: 0x06002462 RID: 9314
		object GetReference(string name);

		/// <summary>Получает имя указанного компонента.</summary>
		/// <param name="reference">Объект, имя которого должно быть возвращено.</param>
		/// <returns>Имя объекта, на который осуществляется ссылка, или значение <see langword="null" />, если ссылка на объект недопустима.</returns>
		// Token: 0x06002463 RID: 9315
		string GetName(object reference);

		/// <summary>Получает все доступные ссылки на компоненты проекта.</summary>
		/// <returns>Массив всех объектов со ссылками, доступными в классе <see cref="T:System.ComponentModel.Design.IReferenceService" />.</returns>
		// Token: 0x06002464 RID: 9316
		object[] GetReferences();

		/// <summary>Получает все доступные ссылки на компоненты заданного типа.</summary>
		/// <param name="baseType">Тип объекта, на экземпляры которого возвращаются ссылки.</param>
		/// <returns>Массив всех доступных объектов заданного типа.</returns>
		// Token: 0x06002465 RID: 9317
		object[] GetReferences(Type baseType);
	}
}
