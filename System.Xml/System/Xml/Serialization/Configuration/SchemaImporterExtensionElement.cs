using System;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;

namespace System.Xml.Serialization.Configuration
{
	/// <summary>
	///         Обрабатывает конфигурацию для <see cref="T:System.Xml.Serialization.XmlSchemaImporter" /> класса.
	///          Этот класс не наследуется.
	///       </summary>
	// Token: 0x02000318 RID: 792
	public sealed class SchemaImporterExtensionElement : ConfigurationElement
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionElement" />.
		///       </summary>
		// Token: 0x060020BC RID: 8380 RVA: 0x000D188C File Offset: 0x000CFA8C
		public SchemaImporterExtensionElement()
		{
			this.properties.Add(this.name);
			this.properties.Add(this.type);
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionElement" /> класса и указывает имя и тип расширения.
		///       </summary>
		/// <param name="name">
		///           Имя нового расширения.
		///            Имя должно быть уникальным.
		///         </param>
		/// <param name="type">
		///           Введите новое расширение, указанное в виде строки.
		///         </param>
		// Token: 0x060020BD RID: 8381 RVA: 0x000D190A File Offset: 0x000CFB0A
		public SchemaImporterExtensionElement(string name, string type) : this()
		{
			this.Name = name;
			base[this.type] = new SchemaImporterExtensionElement.TypeAndName(type);
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionElement" /> с использованием указанного имени и типа.
		///       </summary>
		/// <param name="name">
		///           Имя нового расширения.
		///            Имя должно быть уникальным.
		///         </param>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Нового расширения.
		///         </param>
		// Token: 0x060020BE RID: 8382 RVA: 0x000D192B File Offset: 0x000CFB2B
		public SchemaImporterExtensionElement(string name, Type type) : this()
		{
			this.Name = name;
			this.Type = type;
		}

		/// <summary>
		///         Возвращает или задает имя расширения.
		///       </summary>
		/// <returns>
		///         Имя модуля.
		///       </returns>
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x000D1941 File Offset: 0x000CFB41
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x000D1954 File Offset: 0x000CFB54
		[ConfigurationProperty("name", IsRequired = true, IsKey = true)]
		public string Name
		{
			get
			{
				return (string)base[this.name];
			}
			set
			{
				base[this.name] = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x000D1963 File Offset: 0x000CFB63
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return this.properties;
			}
		}

		/// <summary>
		///         Возвращает или задает тип расширения.
		///       </summary>
		/// <returns>
		///         Тип расширения.
		///       </returns>
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x000D196B File Offset: 0x000CFB6B
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x000D1983 File Offset: 0x000CFB83
		[TypeConverter(typeof(SchemaImporterExtensionElement.TypeTypeConverter))]
		[ConfigurationProperty("type", IsRequired = true, IsKey = false)]
		public Type Type
		{
			get
			{
				return ((SchemaImporterExtensionElement.TypeAndName)base[this.type]).type;
			}
			set
			{
				base[this.type] = new SchemaImporterExtensionElement.TypeAndName(value);
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x000D1997 File Offset: 0x000CFB97
		internal string Key
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x04001B6A RID: 7018
		private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04001B6B RID: 7019
		private readonly ConfigurationProperty name = new ConfigurationProperty("name", typeof(string), null, ConfigurationPropertyOptions.IsKey);

		// Token: 0x04001B6C RID: 7020
		private readonly ConfigurationProperty type = new ConfigurationProperty("type", typeof(Type), null, new SchemaImporterExtensionElement.TypeTypeConverter(), null, ConfigurationPropertyOptions.IsRequired);

		// Token: 0x02000319 RID: 793
		private class TypeAndName
		{
			// Token: 0x060020C5 RID: 8389 RVA: 0x000D199F File Offset: 0x000CFB9F
			public TypeAndName(string name)
			{
				this.type = Type.GetType(name, true, true);
				this.name = name;
			}

			// Token: 0x060020C6 RID: 8390 RVA: 0x000D19BC File Offset: 0x000CFBBC
			public TypeAndName(Type type)
			{
				this.type = type;
			}

			// Token: 0x060020C7 RID: 8391 RVA: 0x000D19CB File Offset: 0x000CFBCB
			public override int GetHashCode()
			{
				return this.type.GetHashCode();
			}

			// Token: 0x060020C8 RID: 8392 RVA: 0x000D19D8 File Offset: 0x000CFBD8
			public override bool Equals(object comparand)
			{
				return this.type.Equals(((SchemaImporterExtensionElement.TypeAndName)comparand).type);
			}

			// Token: 0x04001B6D RID: 7021
			public readonly Type type;

			// Token: 0x04001B6E RID: 7022
			public readonly string name;
		}

		// Token: 0x0200031A RID: 794
		private class TypeTypeConverter : TypeConverter
		{
			// Token: 0x060020C9 RID: 8393 RVA: 0x000D19F0 File Offset: 0x000CFBF0
			public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			{
				return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
			}

			// Token: 0x060020CA RID: 8394 RVA: 0x000D1A0E File Offset: 0x000CFC0E
			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
			{
				if (value is string)
				{
					return new SchemaImporterExtensionElement.TypeAndName((string)value);
				}
				return base.ConvertFrom(context, culture, value);
			}

			// Token: 0x060020CB RID: 8395 RVA: 0x000D1A30 File Offset: 0x000CFC30
			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
			{
				if (!(destinationType == typeof(string)))
				{
					return base.ConvertTo(context, culture, value, destinationType);
				}
				SchemaImporterExtensionElement.TypeAndName typeAndName = (SchemaImporterExtensionElement.TypeAndName)value;
				if (typeAndName.name != null)
				{
					return typeAndName.name;
				}
				return typeAndName.type.AssemblyQualifiedName;
			}
		}
	}
}
