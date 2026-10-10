using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет базовую оболочку для построения настраиваемого конструктора.</summary>
	// Token: 0x02000459 RID: 1113
	public interface IDesigner : IDisposable
	{
		/// <summary>Возвращает базовый компонент, создаваемый данным конструктором.</summary>
		/// <returns>Класс <see cref="T:System.ComponentModel.IComponent" />, показывающий основной компонент, создаваемый данным конструктором.</returns>
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600240F RID: 9231
		IComponent Component { get; }

		/// <summary>Получает коллекцию команд времени разработки, поддерживаемых конструктором.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" />, содержащий поддерживаемые конструктором команды, либо значение <see langword="null" />, если в компоненте отсутствуют команды.</returns>
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002410 RID: 9232
		DesignerVerbCollection Verbs { get; }

		/// <summary>Выполняет действие по умолчанию для конструктора.</summary>
		// Token: 0x06002411 RID: 9233
		void DoDefaultAction();

		/// <summary>Инициализирует конструктор, используя заданный компонент.</summary>
		/// <param name="component">Компонент для связи с данным конструктором.</param>
		// Token: 0x06002412 RID: 9234
		void Initialize(IComponent component);
	}
}
