using System;
using System.ComponentModel;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет атрибут или дочерний элемент конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x02000029 RID: 41
	public sealed class ConfigurationProperty
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <param name="name">Имя сущности конфигурации.</param>
		/// <param name="type">Тип сущности конфигурации.</param>
		// Token: 0x06000164 RID: 356 RVA: 0x000062DB File Offset: 0x000044DB
		public ConfigurationProperty(string name, Type type) : this(name, type, ConfigurationProperty.NoDefaultValue, TypeDescriptor.GetConverter(type), new DefaultValidator(), ConfigurationPropertyOptions.None, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <param name="name">Имя сущности конфигурации.</param>
		/// <param name="type">Тип сущности конфигурации.</param>
		/// <param name="defaultValue">Значение по умолчанию сущности конфигурации.</param>
		// Token: 0x06000165 RID: 357 RVA: 0x000062F7 File Offset: 0x000044F7
		public ConfigurationProperty(string name, Type type, object defaultValue) : this(name, type, defaultValue, TypeDescriptor.GetConverter(type), new DefaultValidator(), ConfigurationPropertyOptions.None, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <param name="name">Имя сущности конфигурации.</param>
		/// <param name="type">Тип сущности конфигурации.</param>
		/// <param name="defaultValue">Значение по умолчанию сущности конфигурации.</param>
		/// <param name="options">Одно из значений перечисления <see cref="T:System.Configuration.ConfigurationPropertyOptions" />.</param>
		// Token: 0x06000166 RID: 358 RVA: 0x0000630F File Offset: 0x0000450F
		public ConfigurationProperty(string name, Type type, object defaultValue, ConfigurationPropertyOptions options) : this(name, type, defaultValue, TypeDescriptor.GetConverter(type), new DefaultValidator(), options, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <param name="name">Имя сущности конфигурации.</param>
		/// <param name="type">Тип сущности конфигурации.</param>
		/// <param name="defaultValue">Значение по умолчанию сущности конфигурации.</param>
		/// <param name="typeConverter">Тип применяемого преобразователя.</param>
		/// <param name="validator">Используемый проверяющий элемент управления.</param>
		/// <param name="options">Одно из значений перечисления <see cref="T:System.Configuration.ConfigurationPropertyOptions" />.</param>
		// Token: 0x06000167 RID: 359 RVA: 0x00006328 File Offset: 0x00004528
		public ConfigurationProperty(string name, Type type, object defaultValue, TypeConverter typeConverter, ConfigurationValidatorBase validator, ConfigurationPropertyOptions options) : this(name, type, defaultValue, typeConverter, validator, options, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <param name="name">Имя сущности конфигурации.</param>
		/// <param name="type">Тип сущности конфигурации.</param>
		/// <param name="defaultValue">Значение по умолчанию сущности конфигурации.</param>
		/// <param name="typeConverter">Тип применяемого преобразователя.</param>
		/// <param name="validator">Используемый проверяющий элемент управления.</param>
		/// <param name="options">Одно из значений перечисления <see cref="T:System.Configuration.ConfigurationPropertyOptions" />.</param>
		/// <param name="description">Описание сущности конфигурации.</param>
		// Token: 0x06000168 RID: 360 RVA: 0x0000633C File Offset: 0x0000453C
		public ConfigurationProperty(string name, Type type, object defaultValue, TypeConverter typeConverter, ConfigurationValidatorBase validator, ConfigurationPropertyOptions options, string description)
		{
			this.name = name;
			this.converter = ((typeConverter != null) ? typeConverter : TypeDescriptor.GetConverter(type));
			if (defaultValue != null)
			{
				if (defaultValue == ConfigurationProperty.NoDefaultValue)
				{
					TypeCode typeCode = Type.GetTypeCode(type);
					if (typeCode != TypeCode.Object)
					{
						if (typeCode != TypeCode.String)
						{
							defaultValue = Activator.CreateInstance(type);
						}
						else
						{
							defaultValue = string.Empty;
						}
					}
					else
					{
						defaultValue = null;
					}
				}
				else if (!type.IsAssignableFrom(defaultValue.GetType()))
				{
					if (!this.converter.CanConvertFrom(defaultValue.GetType()))
					{
						throw new ConfigurationErrorsException(string.Format("The default value for property '{0}' has a different type than the one of the property itself: expected {1} but was {2}", name, type, defaultValue.GetType()));
					}
					defaultValue = this.converter.ConvertFrom(defaultValue);
				}
			}
			this.default_value = defaultValue;
			this.flags = options;
			this.type = type;
			this.validation = ((validator != null) ? validator : new DefaultValidator());
			this.description = description;
		}

		/// <summary>Возвращает объект <see cref="T:System.ComponentModel.TypeConverter" />, используемый для преобразования указанного <see cref="T:System.Configuration.ConfigurationProperty" /> в XML-представление для записи в файл конфигурации.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.TypeConverter" />, используемый для преобразования указанного <see cref="T:System.Configuration.ConfigurationProperty" /> в XML представление для записи в файл конфигурации.</returns>
		/// <exception cref="T:System.Exception">Это значение <see cref="T:System.Configuration.ConfigurationProperty" /> не удается преобразовать.</exception>
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00006417 File Offset: 0x00004617
		public TypeConverter Converter
		{
			get
			{
				return this.converter;
			}
		}

		/// <summary>Возвращает значение по умолчанию для указанного свойства <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который может быть преобразован в тип, указанный свойством <see cref="P:System.Configuration.ConfigurationProperty.Type" />.</returns>
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000641F File Offset: 0x0000461F
		public object DefaultValue
		{
			get
			{
				return this.default_value;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли <see cref="T:System.Configuration.ConfigurationProperty" /> ключом для содержащего объекта <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>
		///   <see langword="true" />, если указанный объект <see cref="T:System.Configuration.ConfigurationProperty" /> является ключом содержащим элемент; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00006427 File Offset: 0x00004627
		public bool IsKey
		{
			get
			{
				return (this.flags & ConfigurationPropertyOptions.IsKey) > ConfigurationPropertyOptions.None;
			}
		}

		/// <summary>Возвращает значение, указывающее, требуется ли <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Configuration.ConfigurationProperty" /> требуется; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00006434 File Offset: 0x00004634
		public bool IsRequired
		{
			get
			{
				return (this.flags & ConfigurationPropertyOptions.IsRequired) > ConfigurationPropertyOptions.None;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли свойство коллекцией по умолчанию для элемента.</summary>
		/// <returns>
		///   <see langword="true" />, если свойство представляет коллекцию по умолчанию элемента; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00006441 File Offset: 0x00004641
		public bool IsDefaultCollection
		{
			get
			{
				return (this.flags & ConfigurationPropertyOptions.IsDefaultCollection) > ConfigurationPropertyOptions.None;
			}
		}

		/// <summary>Возвращает имя этого аспекта <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <returns>Имя <see cref="T:System.Configuration.ConfigurationProperty" />.</returns>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000644E File Offset: 0x0000464E
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Возвращает описание, связанное с объектом <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <returns>Значение <see langword="string" />, описывающее свойство.</returns>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00006456 File Offset: 0x00004656
		public string Description
		{
			get
			{
				return this.description;
			}
		}

		/// <summary>Возвращает тип этого объекта <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип указанного объекта <see cref="T:System.Configuration.ConfigurationProperty" />.</returns>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000645E File Offset: 0x0000465E
		public Type Type
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Configuration.ConfigurationValidatorAttribute" />, используемый для проверки этого объекта <see cref="T:System.Configuration.ConfigurationProperty" />.</summary>
		/// <returns>Проверяющий элемент управления <see cref="T:System.Configuration.ConfigurationValidatorBase" />, используемый для проверки указанного объекта <see cref="T:System.Configuration.ConfigurationProperty" />.</returns>
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00006466 File Offset: 0x00004666
		public ConfigurationValidatorBase Validator
		{
			get
			{
				return this.validation;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000646E File Offset: 0x0000466E
		internal object ConvertFromString(string value)
		{
			if (this.converter != null)
			{
				return this.converter.ConvertFromInvariantString(value);
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000648A File Offset: 0x0000468A
		internal string ConvertToString(object value)
		{
			if (this.converter != null)
			{
				return this.converter.ConvertToInvariantString(value);
			}
			throw new NotImplementedException();
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000064A6 File Offset: 0x000046A6
		internal bool IsElement
		{
			get
			{
				return typeof(ConfigurationElement).IsAssignableFrom(this.type);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000064BD File Offset: 0x000046BD
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000064C5 File Offset: 0x000046C5
		internal ConfigurationCollectionAttribute CollectionAttribute
		{
			get
			{
				return this.collectionAttribute;
			}
			set
			{
				this.collectionAttribute = value;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000064CE File Offset: 0x000046CE
		internal void Validate(object value)
		{
			if (this.validation != null)
			{
				this.validation.Validate(value);
			}
		}

		/// <summary>Указывает, требуется ли преобразование имени сборки для свойства конфигурации при сериализации для более ранней версии .NET Framework.</summary>
		/// <returns>Значение <see langword="true" />, если свойство требует преобразования имени сборки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000064F0 File Offset: 0x000046F0
		public bool IsAssemblyStringTransformationRequired
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>Указывает, требуется ли преобразование имени типа для свойства конфигурации при сериализации для более ранней версии .NET Framework.</summary>
		/// <returns>Значение <see langword="true" />, если свойство требует преобразования имени типа; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000650C File Offset: 0x0000470C
		public bool IsTypeStringTransformationRequired
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>Указывает, запрашивается ли во время сериализации родительский раздел конфигурации свойства конфигурации, чтобы определить, нужно ли выполнять сериализацию свойства конфигурации в формат XML.</summary>
		/// <returns>Значение <see langword="true" />, если нужно запрашивать родительский раздел конфигурации; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00006528 File Offset: 0x00004728
		public bool IsVersionCheckRequired
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		// Token: 0x0400009E RID: 158
		internal static readonly object NoDefaultValue = new object();

		// Token: 0x0400009F RID: 159
		private string name;

		// Token: 0x040000A0 RID: 160
		private Type type;

		// Token: 0x040000A1 RID: 161
		private object default_value;

		// Token: 0x040000A2 RID: 162
		private TypeConverter converter;

		// Token: 0x040000A3 RID: 163
		private ConfigurationValidatorBase validation;

		// Token: 0x040000A4 RID: 164
		private ConfigurationPropertyOptions flags;

		// Token: 0x040000A5 RID: 165
		private string description;

		// Token: 0x040000A6 RID: 166
		private ConfigurationCollectionAttribute collectionAttribute;
	}
}
