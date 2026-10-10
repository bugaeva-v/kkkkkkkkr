using System;

namespace System.Configuration
{
	/// <summary>Предоставляет динамическую проверку объекта.</summary>
	// Token: 0x0200000C RID: 12
	public sealed class CallbackValidator : ConfigurationValidatorBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.CallbackValidator" />.</summary>
		/// <param name="type">Тип объекта, подлежащего проверке.</param>
		/// <param name="callback">
		///   <see cref="T:System.Configuration.ValidatorCallback" /> используется, как делегат.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600001A RID: 26 RVA: 0x000022C6 File Offset: 0x000004C6
		public CallbackValidator(Type type, ValidatorCallback callback)
		{
			this.type = type;
			this.callback = callback;
		}

		/// <summary>Определяет, можно ли проверить тип объекта.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>
		///   <see langword="true" /> если параметр <see langword="type" /> совпадает с типом, используемым в качестве первого параметра, при создании экземпляра <see cref="T:System.Configuration.CallbackValidator" />; иначе, <see langword="false" />.</returns>
		// Token: 0x0600001B RID: 27 RVA: 0x000022DC File Offset: 0x000004DC
		public override bool CanValidate(Type type)
		{
			return type == this.type;
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		// Token: 0x0600001C RID: 28 RVA: 0x000022EA File Offset: 0x000004EA
		public override void Validate(object value)
		{
			this.callback(value);
		}

		// Token: 0x0400002F RID: 47
		private Type type;

		// Token: 0x04000030 RID: 48
		private ValidatorCallback callback;
	}
}
