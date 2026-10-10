using System;

namespace System.Configuration
{
	/// <summary>Описательно инструктирует платформу .NET Framework о создании экземпляра свойства конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x0200002A RID: 42
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class ConfigurationPropertyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationPropertyAttribute" />.</summary>
		/// <param name="name">Имя определенного объекта <see cref="T:System.Configuration.ConfigurationProperty" />.</param>
		// Token: 0x0600017C RID: 380 RVA: 0x00006543 File Offset: 0x00004743
		public ConfigurationPropertyAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>Получает или задает значение, указывающее, является ли данное свойство ключевым для декорированного свойства элемента.</summary>
		/// <returns>
		///   <see langword="true" />, если данное свойство является ключевым для элемента коллекции, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000655D File Offset: 0x0000475D
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000656A File Offset: 0x0000476A
		public bool IsKey
		{
			get
			{
				return (this.flags & ConfigurationPropertyOptions.IsKey) > ConfigurationPropertyOptions.None;
			}
			set
			{
				if (value)
				{
					this.flags |= ConfigurationPropertyOptions.IsKey;
					return;
				}
				this.flags &= ~ConfigurationPropertyOptions.IsKey;
			}
		}

		/// <summary>Получает или задает значение, указывающее, является ли данная коллекция коллекцией свойств по умолчанию для декорированного свойства конфигурации.</summary>
		/// <returns>
		///   <see langword="true" />, если свойство представляет коллекцию по умолчанию элемента, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000658D File Offset: 0x0000478D
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000659A File Offset: 0x0000479A
		public bool IsDefaultCollection
		{
			get
			{
				return (this.flags & ConfigurationPropertyOptions.IsDefaultCollection) > ConfigurationPropertyOptions.None;
			}
			set
			{
				if (value)
				{
					this.flags |= ConfigurationPropertyOptions.IsDefaultCollection;
					return;
				}
				this.flags &= ~ConfigurationPropertyOptions.IsDefaultCollection;
			}
		}

		/// <summary>Получает или задает значение по умолчанию для декорированного свойства.</summary>
		/// <returns>Объект, представляющий значение по умолчанию декорированного свойства элемента конфигурации.</returns>
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000065BD File Offset: 0x000047BD
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000065C5 File Offset: 0x000047C5
		public object DefaultValue
		{
			get
			{
				return this.default_value;
			}
			set
			{
				this.default_value = value;
			}
		}

		/// <summary>Получает или задает <see cref="T:System.Configuration.ConfigurationPropertyOptions" /> для декорированного свойства элемента конфигурации.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Configuration.ConfigurationPropertyOptions" />, связанных с данным свойством.</returns>
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000065CE File Offset: 0x000047CE
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000065D6 File Offset: 0x000047D6
		public ConfigurationPropertyOptions Options
		{
			get
			{
				return this.flags;
			}
			set
			{
				this.flags = value;
			}
		}

		/// <summary>Получает имя декорированного свойства элемента конфигурации.</summary>
		/// <returns>Имя декорированного свойства элемента конфигурации.</returns>
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000065DF File Offset: 0x000047DF
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Получает или задает значение, указывающее, требуется ли декорированное свойство элемента.</summary>
		/// <returns>
		///   <see langword="true" />, если свойство требуется, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000065E7 File Offset: 0x000047E7
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000065F4 File Offset: 0x000047F4
		public bool IsRequired
		{
			get
			{
				return (this.flags & ConfigurationPropertyOptions.IsRequired) > ConfigurationPropertyOptions.None;
			}
			set
			{
				if (value)
				{
					this.flags |= ConfigurationPropertyOptions.IsRequired;
					return;
				}
				this.flags &= ~ConfigurationPropertyOptions.IsRequired;
			}
		}

		// Token: 0x040000A7 RID: 167
		private string name;

		// Token: 0x040000A8 RID: 168
		private object default_value = ConfigurationProperty.NoDefaultValue;

		// Token: 0x040000A9 RID: 169
		private ConfigurationPropertyOptions flags;
	}
}
