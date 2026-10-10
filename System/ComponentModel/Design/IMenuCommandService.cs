using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет методы для управления общими командами конструктора и командами меню, доступными в режиме конструктора, а также методы для отображения некоторых типов контекстных меню.</summary>
	// Token: 0x02000465 RID: 1125
	public interface IMenuCommandService
	{
		/// <summary>Возвращает коллекцию команд конструктора, доступных в настоящий момент.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" />, содержащая доступные в текущий момент команды конструктора.</returns>
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002459 RID: 9305
		DesignerVerbCollection Verbs { get; }

		/// <summary>Добавляет в меню указанную стандартную команду меню.</summary>
		/// <param name="command">Добавляемый объект <see cref="T:System.ComponentModel.Design.MenuCommand" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Идентификатор <see cref="T:System.ComponentModel.Design.CommandID" /> указанной команды <see cref="T:System.ComponentModel.Design.MenuCommand" /> уже представлен в меню.</exception>
		// Token: 0x0600245A RID: 9306
		void AddCommand(MenuCommand command);

		/// <summary>Добавляет указанную команду конструктора в набор общих команд конструктора.</summary>
		/// <param name="verb">Добавляемый объект <see cref="T:System.ComponentModel.Design.DesignerVerb" />.</param>
		// Token: 0x0600245B RID: 9307
		void AddVerb(DesignerVerb verb);

		/// <summary>Осуществляет поиск указанного идентификатора команды и возвращает связанную с ним команду меню.</summary>
		/// <param name="commandID">Объект <see cref="T:System.ComponentModel.Design.CommandID" />, который требуется найти.</param>
		/// <returns>Команда <see cref="T:System.ComponentModel.Design.MenuCommand" />, связанная с идентификатором команды, или значение <see langword="null" />, если команда не найдена.</returns>
		// Token: 0x0600245C RID: 9308
		MenuCommand FindCommand(CommandID commandID);

		/// <summary>Вызывает команду меню или команду конструктора, соответствующую указанному идентификатору команды.</summary>
		/// <param name="commandID">Идентификатор <see cref="T:System.ComponentModel.Design.CommandID" /> команды, которую необходимо найти и выполнить.</param>
		/// <returns>Значение <see langword="true" />, если команда найдена и вызвана успешно; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600245D RID: 9309
		bool GlobalInvoke(CommandID commandID);

		/// <summary>Удаляет из меню указанную стандартную команду меню.</summary>
		/// <param name="command">Объект <see cref="T:System.ComponentModel.Design.MenuCommand" /> для удаления.</param>
		// Token: 0x0600245E RID: 9310
		void RemoveCommand(MenuCommand command);

		/// <summary>Удаляет указанную команду конструктора из коллекции глобальных команд конструктора.</summary>
		/// <param name="verb">Объект <see cref="T:System.ComponentModel.Design.DesignerVerb" /> для удаления.</param>
		// Token: 0x0600245F RID: 9311
		void RemoveVerb(DesignerVerb verb);

		/// <summary>Отображает указанное контекстное меню в заданном месте.</summary>
		/// <param name="menuID">Идентификатор <see cref="T:System.ComponentModel.Design.CommandID" /> отображаемого контекстного меню.</param>
		/// <param name="x">Координата по оси X, в которой отображается меню (в экранных координатах).</param>
		/// <param name="y">Координата по оси Y, в которой отображается меню (в экранных координатах).</param>
		// Token: 0x06002460 RID: 9312
		void ShowContextMenu(CommandID menuID, int x, int y);
	}
}
