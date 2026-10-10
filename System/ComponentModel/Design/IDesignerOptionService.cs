using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет доступ к параметрам конструктора, расположенным в среде разработки Visual Studio в меню Сервис под пунктом Параметры.</summary>
	// Token: 0x0200045E RID: 1118
	public interface IDesignerOptionService
	{
		/// <summary>Возвращает значение указанного параметра конструктора Windows Forms.</summary>
		/// <param name="pageName">Имя страницы, определяющей этот параметр.</param>
		/// <param name="valueName">Имя свойства параметра.</param>
		/// <returns>Значение заданного параметра.</returns>
		// Token: 0x06002440 RID: 9280
		object GetOptionValue(string pageName, string valueName);

		/// <summary>Устанавливает значение указанного параметра конструктора Windows Forms.</summary>
		/// <param name="pageName">Имя страницы, определяющей этот параметр.</param>
		/// <param name="valueName">Имя свойства параметра.</param>
		/// <param name="value">Новое значение.</param>
		// Token: 0x06002441 RID: 9281
		void SetOptionValue(string pageName, string valueName, object value);
	}
}
