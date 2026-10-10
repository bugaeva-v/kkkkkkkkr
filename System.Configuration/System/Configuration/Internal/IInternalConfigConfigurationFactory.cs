using System;
using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейсы, используемые внутренним режимом разработки API для создания объекта <see cref="T:System.Configuration.Configuration" />.</summary>
	// Token: 0x02000080 RID: 128
	[ComVisible(false)]
	public interface IInternalConfigConfigurationFactory
	{
		/// <summary>Создает и инициализирует объект <see cref="T:System.Configuration.Configuration" />.</summary>
		/// <param name="typeConfigHost">
		///   <see cref="T:System.Type" /> создаваемого объекта <see cref="T:System.Configuration.Configuration" />.</param>
		/// <param name="hostInitConfigurationParams">Массив параметров <see cref="T:System.Object" />, который содержит параметры, которые применены к созданному объекту <see cref="T:System.Configuration.Configuration" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.Configuration" />.</returns>
		// Token: 0x0600043E RID: 1086
		Configuration Create(Type typeConfigHost, params object[] hostInitConfigurationParams);

		/// <summary>Нормализует вложенный путь расположения пути к файлу конфигурации.</summary>
		/// <param name="subPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <param name="errorInfo">Экземпляр <see cref="T:System.Configuration.Internal.IConfigErrorInfo" /> или <see langword="null" />.</param>
		/// <returns>Строка нормализованного вложенного пути.</returns>
		// Token: 0x0600043F RID: 1087
		string NormalizeLocationSubPath(string subPath, IConfigErrorInfo errorInfo);
	}
}
