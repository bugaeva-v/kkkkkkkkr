using System;

namespace System.Configuration
{
	/// <summary>Служит базовым классом для типов атрибутов проверяющего элемента управления <see cref="N:System.Configuration" />.</summary>
	// Token: 0x02000036 RID: 54
	[AttributeUsage(AttributeTargets.Property)]
	public class ConfigurationValidatorAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationValidatorAttribute" />.</summary>
		// Token: 0x060001EC RID: 492 RVA: 0x000020A8 File Offset: 0x000002A8
		protected ConfigurationValidatorAttribute()
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Configuration.ConfigurationValidatorAttribute" />, используя указанный тип проверяющего элемента управления.</summary>
		/// <param name="validator">Тип проверяющего элемента управления для использования при создании экземпляра <see cref="T:System.Configuration.ConfigurationValidatorAttribute" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="validator" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="validator" /> не является производным объекта <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</exception>
		// Token: 0x060001ED RID: 493 RVA: 0x00007378 File Offset: 0x00005578
		public ConfigurationValidatorAttribute(Type validator)
		{
			this.validatorType = validator;
		}

		/// <summary>Получает экземпляр атрибута проверяющего элемента управления.</summary>
		/// <returns>Текущий <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</returns>
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00007387 File Offset: 0x00005587
		public virtual ConfigurationValidatorBase ValidatorInstance
		{
			get
			{
				if (this.instance == null)
				{
					this.instance = (ConfigurationValidatorBase)Activator.CreateInstance(this.validatorType);
				}
				return this.instance;
			}
		}

		/// <summary>Получает тип атрибута проверяющего элемента управления.</summary>
		/// <returns>
		///   <see cref="T:System.Type" /> экземпляра атрибута проверяющего элемента управления.</returns>
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000073AD File Offset: 0x000055AD
		public Type ValidatorType
		{
			get
			{
				return this.validatorType;
			}
		}

		// Token: 0x040000D5 RID: 213
		private Type validatorType;

		// Token: 0x040000D6 RID: 214
		private ConfigurationValidatorBase instance;
	}
}
