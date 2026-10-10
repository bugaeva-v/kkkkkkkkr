using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс выбора компонентов для конструктора.</summary>
	// Token: 0x02000469 RID: 1129
	public interface ISelectionService
	{
		/// <summary>Получает объект, являющийся на данный момент основным выделенным объектом.</summary>
		/// <returns>Объект, являющийся на данный момент основным выделенным объектом.</returns>
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600246A RID: 9322
		object PrimarySelection { get; }

		/// <summary>Получает число выделенных объектов.</summary>
		/// <returns>Число выделенных объектов.</returns>
		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600246B RID: 9323
		int SelectionCount { get; }

		/// <summary>Возникает при изменении текущего выделения.</summary>
		// Token: 0x14000045 RID: 69
		// (add) Token: 0x0600246C RID: 9324
		// (remove) Token: 0x0600246D RID: 9325
		event EventHandler SelectionChanged;

		/// <summary>Возникает перед изменением текущего выделения.</summary>
		// Token: 0x14000046 RID: 70
		// (add) Token: 0x0600246E RID: 9326
		// (remove) Token: 0x0600246F RID: 9327
		event EventHandler SelectionChanging;

		/// <summary>Получает значение, показывающее, выделен ли указанный компонент в данный момент.</summary>
		/// <param name="component">Проверяемый компонент.</param>
		/// <returns>Значение <see langword="true" />, если компонент является частью текущего выбора пользователя; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002470 RID: 9328
		bool GetComponentSelected(object component);

		/// <summary>Возвращает коллекцию компонентов, выделенную в настоящий момент.</summary>
		/// <returns>Коллекция, представляющая текущий набор выделенных компонентов.</returns>
		// Token: 0x06002471 RID: 9329
		ICollection GetSelectedComponents();

		/// <summary>Выделяет заданную коллекцию компонентов.</summary>
		/// <param name="components">Коллекция выделяемых компонентов.</param>
		// Token: 0x06002472 RID: 9330
		void SetSelectedComponents(ICollection components);

		/// <summary>Выделяет компоненты из заданной коллекции компонентов, которые соответствуют указанному типу выделения.</summary>
		/// <param name="components">Коллекция выделяемых компонентов.</param>
		/// <param name="selectionType">Значение из перечисления <see cref="T:System.ComponentModel.Design.SelectionTypes" />. Значение по умолчанию: <see cref="F:System.ComponentModel.Design.SelectionTypes.Normal" />.</param>
		// Token: 0x06002473 RID: 9331
		void SetSelectedComponents(ICollection components, SelectionTypes selectionType);
	}
}
