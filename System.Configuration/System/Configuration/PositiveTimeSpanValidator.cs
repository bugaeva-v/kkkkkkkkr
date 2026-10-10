using System;

namespace System.Configuration
{
	/// <summary>Выполняет проверку объекта <see cref="T:System.TimeSpan" />. Этот класс не наследуется.</summary>
	// Token: 0x02000056 RID: 86
	public class PositiveTimeSpanValidator : ConfigurationValidatorBase
	{
		/// <summary>Определяет, можно ли проверить тип объекта.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="type" /> соответствует объекту <see cref="T:System.TimeSpan" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002E0 RID: 736 RVA: 0x000087A7 File Offset: 0x000069A7
		public override bool CanValidate(Type type)
		{
			return type == typeof(TimeSpan);
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не удается разрешить с положительным значением <see cref="T:System.TimeSpan" />.</exception>
		// Token: 0x060002E1 RID: 737 RVA: 0x000087B9 File Offset: 0x000069B9
		public override void Validate(object value)
		{
			if ((TimeSpan)value <= new TimeSpan(0L))
			{
				throw new ArgumentException("The time span value must be positive");
			}
		}
	}
}
