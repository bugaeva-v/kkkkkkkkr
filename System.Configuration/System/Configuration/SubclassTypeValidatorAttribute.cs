using System;

namespace System.Configuration
{
	/// <summary>Декларативно указывает платформе .NET Framework проверять свойство конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x0200006D RID: 109
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class SubclassTypeValidatorAttribute : ConfigurationValidatorAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SubclassTypeValidatorAttribute" />.</summary>
		/// <param name="baseClass">Тип базового класса.</param>
		// Token: 0x060003BC RID: 956 RVA: 0x0000A9C5 File Offset: 0x00008BC5
		public SubclassTypeValidatorAttribute(Type baseClass)
		{
			this.baseClass = baseClass;
		}

		/// <summary>Возвращает базовый тип проверяемого объекта.</summary>
		/// <returns>Базовый тип утверждаемого объекта.</returns>
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		public Type BaseClass
		{
			get
			{
				return this.baseClass;
			}
		}

		/// <summary>Получает экземпляр атрибута проверяющего элемента управления.</summary>
		/// <returns>Текущий экземпляр <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</returns>
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000A9DC File Offset: 0x00008BDC
		public override ConfigurationValidatorBase ValidatorInstance
		{
			get
			{
				if (this.instance == null)
				{
					this.instance = new SubclassTypeValidator(this.baseClass);
				}
				return this.instance;
			}
		}

		// Token: 0x04000154 RID: 340
		private Type baseClass;

		// Token: 0x04000155 RID: 341
		private ConfigurationValidatorBase instance;
	}
}
