using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет базовый словарь пар "ключ-значение", свойственный компоненту, через службу, которая может использоваться конструктором для хранения пользовательских данных.</summary>
	// Token: 0x0200045F RID: 1119
	public interface IDictionaryService
	{
		/// <summary>Получает ключ, соответствующий заданному значению.</summary>
		/// <param name="value">Значение для поиска в словаре.</param>
		/// <returns>Соответствующий ключ или значение <see langword="null" />, если ключ не существует.</returns>
		// Token: 0x06002442 RID: 9282
		object GetKey(object value);

		/// <summary>Возвращает значение, соответствующее указанному ключу.</summary>
		/// <param name="key">Ключ, для которого необходимо найти значение.</param>
		/// <returns>Соответствующее значение или <see langword="null" />, если значение не существует.</returns>
		// Token: 0x06002443 RID: 9283
		object GetValue(object key);

		/// <summary>Задает указанную пару "ключ-значение".</summary>
		/// <param name="key">Объект, используемый в качестве ключа, с которым необходимо сопоставить значение.</param>
		/// <param name="value">Хранимое значение.</param>
		// Token: 0x06002444 RID: 9284
		void SetValue(object key, object value);
	}
}
