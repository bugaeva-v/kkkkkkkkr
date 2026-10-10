using System;

namespace System.Configuration
{
	/// <summary>Проверяет, является ли объект производным классом указанного типа.</summary>
	// Token: 0x0200006C RID: 108
	public sealed class SubclassTypeValidator : ConfigurationValidatorBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SubclassTypeValidator" />.</summary>
		/// <param name="baseClass">Проверяемый базовый класс от противного.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="baseClass" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060003B9 RID: 953 RVA: 0x0000A975 File Offset: 0x00008B75
		public SubclassTypeValidator(Type baseClass)
		{
			this.baseClass = baseClass;
		}

		/// <summary>Определяет, можно ли проверить объект по типу.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="type" /> совпадает с проверяемым типом, иначе, <see langword="false" />.</returns>
		// Token: 0x060003BA RID: 954 RVA: 0x0000A984 File Offset: 0x00008B84
		public override bool CanValidate(Type type)
		{
			return type == typeof(Type);
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="value" /> не является типом <see cref="T:System.Type" />, который может быть производным от класса <paramref name="baseClass" />, как определено в конструкторе.</exception>
		// Token: 0x060003BB RID: 955 RVA: 0x0000A998 File Offset: 0x00008B98
		public override void Validate(object value)
		{
			Type c = (Type)value;
			if (!this.baseClass.IsAssignableFrom(c))
			{
				throw new ArgumentException("The value must be a subclass");
			}
		}

		// Token: 0x04000153 RID: 339
		private Type baseClass;
	}
}
