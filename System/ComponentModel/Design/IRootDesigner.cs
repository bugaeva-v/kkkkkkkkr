using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет поддержку технологий просмотра конструктора корневого уровня.</summary>
	// Token: 0x02000468 RID: 1128
	public interface IRootDesigner : IDesigner, IDisposable
	{
		/// <summary>Возвращает или устанавливает набор технологий, которые данный конструктор может поддерживать для отображения.</summary>
		/// <returns>Массив значений поддерживаемого типа <see cref="T:System.ComponentModel.Design.ViewTechnology" />.</returns>
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002468 RID: 9320
		ViewTechnology[] SupportedTechnologies { get; }

		/// <summary>Получает объект просмотра для заданной технологии просмотра.</summary>
		/// <param name="technology">
		///   <see cref="T:System.ComponentModel.Design.ViewTechnology" /> показывает определенную технологию просмотра.</param>
		/// <returns>Объект, отражающий представление для данного конструктора.</returns>
		/// <exception cref="T:System.ArgumentException">Указанная технология просмотра не поддерживается или не существует.</exception>
		// Token: 0x06002469 RID: 9321
		object GetView(ViewTechnology technology);
	}
}
