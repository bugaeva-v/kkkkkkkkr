using System;

namespace System.Configuration
{
	/// <summary>Действует как базовый класс для создания проверочного класса, служащего для проверки значения объекта.</summary>
	// Token: 0x02000037 RID: 55
	public abstract class ConfigurationValidatorBase
	{
		/// <summary>Определяет, можно ли проверить объект по типу.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="type" /> соответствует ожидаемому <see langword="type" />, в противном случае — <see langword="false" />.</returns>
		// Token: 0x060001F1 RID: 497 RVA: 0x000023BB File Offset: 0x000005BB
		public virtual bool CanValidate(Type type)
		{
			return false;
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		// Token: 0x060001F2 RID: 498
		public abstract void Validate(object value);
	}
}
