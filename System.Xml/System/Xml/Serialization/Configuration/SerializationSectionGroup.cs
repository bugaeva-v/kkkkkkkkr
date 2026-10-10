using System;
using System.Configuration;

namespace System.Xml.Serialization.Configuration
{
	/// <summary>
	///         Обрабатывает элементы XML, используемые для настройки сериализации XML.
	///       </summary>
	// Token: 0x0200031D RID: 797
	public sealed class SerializationSectionGroup : ConfigurationSectionGroup
	{
		/// <summary>
		///         Возвращает объект, представляющий раздел, содержащий элементы конфигурации для <see cref="T:System.Xml.Serialization.XmlSchemaImporter" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionsSection" /> Представляющий <see langword="schemaImporterExtenstion" /> элемент в файле конфигурации.
		///       </returns>
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000D1EE0 File Offset: 0x000D00E0
		[ConfigurationProperty("schemaImporterExtensions")]
		public SchemaImporterExtensionsSection SchemaImporterExtensions
		{
			get
			{
				return (SchemaImporterExtensionsSection)base.Sections["schemaImporterExtensions"];
			}
		}

		/// <summary>
		///         Возвращает объект, представляющий <see cref="T:System.DateTime" /> элемент конфигурации сериализации.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.Configuration.DateTimeSerializationSection" /> Объект, который представляет элемент конфигурации.
		///       </returns>
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000D1EF7 File Offset: 0x000D00F7
		[ConfigurationProperty("dateTimeSerialization")]
		public DateTimeSerializationSection DateTimeSerialization
		{
			get
			{
				return (DateTimeSerializationSection)base.Sections["dateTimeSerialization"];
			}
		}

		/// <summary>
		///         Возвращает объект, представляющий группу конфигурации для <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.Configuration.XmlSerializerSection" /> Представляющий <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </returns>
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x000D1F0E File Offset: 0x000D010E
		public XmlSerializerSection XmlSerializer
		{
			get
			{
				return (XmlSerializerSection)base.Sections["xmlSerializer"];
			}
		}
	}
}
