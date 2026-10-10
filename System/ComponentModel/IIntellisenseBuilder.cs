using System;

namespace System.ComponentModel
{
	/// <summary>Обеспечивает интерфейс для упрощения возвращения имени сборщика и отображения сборщика.</summary>
	// Token: 0x020003B6 RID: 950
	public interface IIntellisenseBuilder
	{
		/// <summary>Возвращает локализованное имя.</summary>
		/// <returns>Локализованное имя.</returns>
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001F13 RID: 7955
		string Name { get; }

		/// <summary>Показывает сборщик.</summary>
		/// <param name="language">Служба языка, вызывающая сборщика.</param>
		/// <param name="value">Редактируемое выражение.</param>
		/// <param name="newValue">Новое значение.</param>
		/// <returns>Значение <see langword="true" />, если значение должно быть заменено параметром <paramref name="newValue" />; в противном случае — значение <see langword="false" /> (например при отмене пользователем).</returns>
		// Token: 0x06001F14 RID: 7956
		bool Show(string language, string value, ref string newValue);
	}
}
