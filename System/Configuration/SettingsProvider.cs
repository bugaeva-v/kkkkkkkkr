using System;
using System.Configuration.Provider;

namespace System.Configuration
{
	/// <summary>Действует, как базовый класс для извлечения поставщиков пользовательских параметров в архитектуре параметров приложения.</summary>
	// Token: 0x020001D3 RID: 467
	public abstract class SettingsProvider : ProviderBase
	{
		/// <summary>Возвращает коллекцию значений свойства параметров для указанного экземпляра приложения и группы свойств параметров.</summary>
		/// <param name="context">
		///   <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		/// <param name="collection">Объект <see cref="T:System.Configuration.SettingsPropertyCollection" />, содержащий группу свойств параметров, значения которых необходимо извлечь.</param>
		/// <returns>
		///   <see cref="T:System.Configuration.SettingsPropertyValueCollection" />, содержащий значение для указанной группы свойств параметров.</returns>
		// Token: 0x06000C48 RID: 3144
		public abstract SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection);

		/// <summary>Задает значения указанной группы параметров свойства.</summary>
		/// <param name="context">
		///   <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		/// <param name="collection">Объект <see cref="T:System.Configuration.SettingsPropertyValueCollection" />, представляющий группу параметров свойств, которые необходимо задать.</param>
		// Token: 0x06000C49 RID: 3145
		public abstract void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection);

		/// <summary>Возвращает или задает имя работающего в данный момент приложения.</summary>
		/// <returns>Объект <see cref="T:System.String" /> , содержащее сокращенное имя приложения, которое не содержит полный путь или расширение, например, <c>SimpleAppSettings</c>.</returns>
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000C4A RID: 3146
		// (set) Token: 0x06000C4B RID: 3147
		public abstract string ApplicationName { get; set; }
	}
}
