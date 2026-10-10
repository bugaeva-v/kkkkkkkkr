using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет абстрактный (<see langword="abstract" />) базовый класс для реализации поставщика лицензий.</summary>
	// Token: 0x020003C9 RID: 969
	public abstract class LicenseProvider
	{
		/// <summary>При переопределении в производном классе возвращает лицензию для экземпляра или типа компонента, когда задан контекст, а также приводит ли отказ в лицензии к исключению.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.LicenseContext" />, определяющий, где можно использовать лицензированный объект.</param>
		/// <param name="type">Объект <see cref="T:System.Type" />, который представляет компонент, запрашивающий лицензию.</param>
		/// <param name="instance">Запрашивающий лицензию объект.</param>
		/// <param name="allowExceptions">Значение <see langword="true" />, если исключение <see cref="T:System.ComponentModel.LicenseException" /> должно быть вызвано в случае, когда компоненту не может быть предоставлена лицензия; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Допустимый класс <see cref="T:System.ComponentModel.License" />.</returns>
		// Token: 0x06001F62 RID: 8034
		public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions);
	}
}
