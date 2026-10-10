using System;

namespace System.Configuration
{
	/// <summary>Обеспечивает проверку объекта. Этот класс не наследуется.</summary>
	// Token: 0x0200003D RID: 61
	public sealed class DefaultValidator : ConfigurationValidatorBase
	{
		/// <summary>Определяет, можно ли проверить объект по типу.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>
		///   <see langword="true" /> для всех проверяемых типов.</returns>
		// Token: 0x06000220 RID: 544 RVA: 0x00004919 File Offset: 0x00002B19
		public override bool CanValidate(Type type)
		{
			return true;
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		// Token: 0x06000221 RID: 545 RVA: 0x000023B9 File Offset: 0x000005B9
		public override void Validate(object value)
		{
		}
	}
}
