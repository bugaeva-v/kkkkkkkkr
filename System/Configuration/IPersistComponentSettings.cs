using System;

namespace System.Configuration
{
	/// <summary>Определяет стандартную функциональность для элементов управления или библиотек, которые хранят и извлекают параметры приложения.</summary>
	// Token: 0x020001B3 RID: 435
	public interface IPersistComponentSettings
	{
		/// <summary>Возвращает или задает значение, указывающее на то, должен ли элемент управления автоматически сохранять свойства параметров приложения.</summary>
		/// <returns>
		///   <see langword="true" />, если элемент управления должен автоматически сохранять свое состояние, иначе <see langword="false" />.</returns>
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000B80 RID: 2944
		// (set) Token: 0x06000B81 RID: 2945
		bool SaveSettings { get; set; }

		/// <summary>Возвращает или задает значение ключа параметров приложения для текущего экземпляра элемента управления.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая ключ параметров для текущего экземпляра элемента управления.</returns>
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000B82 RID: 2946
		// (set) Token: 0x06000B83 RID: 2947
		string SettingsKey { get; set; }

		/// <summary>Считывает параметры приложения элемента управления в их соответствующие свойства и обновляет состояние элемента управления.</summary>
		// Token: 0x06000B84 RID: 2948
		void LoadComponentSettings();

		/// <summary>Повторно загружает свойства параметров приложения элемента управления относительно значений по умолчанию.</summary>
		// Token: 0x06000B85 RID: 2949
		void ResetComponentSettings();

		/// <summary>Сохраняет свойства параметров приложения элемента управления.</summary>
		// Token: 0x06000B86 RID: 2950
		void SaveComponentSettings();
	}
}
