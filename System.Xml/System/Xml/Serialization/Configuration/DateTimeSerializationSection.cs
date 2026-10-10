using System;
using System.ComponentModel;
using System.Configuration;

namespace System.Xml.Serialization.Configuration
{
	/// <summary>
	///         Обрабатывает настройки сериализации XML <see cref="T:System.DateTime" /> экземпляров.
	///       </summary>
	// Token: 0x02000316 RID: 790
	public sealed class DateTimeSerializationSection : ConfigurationSection
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.Configuration.DateTimeSerializationSection" />.
		///       </summary>
		// Token: 0x060020B8 RID: 8376 RVA: 0x000D17FC File Offset: 0x000CF9FC
		public DateTimeSerializationSection()
		{
			this.properties.Add(this.mode);
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000D185C File Offset: 0x000CFA5C
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return this.properties;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, определяющее формат сериализации.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.Serialization.Configuration.DateTimeSerializationSection.DateTimeSerializationMode" />.
		///       </returns>
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x000D1864 File Offset: 0x000CFA64
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x000D1877 File Offset: 0x000CFA77
		[ConfigurationProperty("mode", DefaultValue = DateTimeSerializationSection.DateTimeSerializationMode.Roundtrip)]
		public DateTimeSerializationSection.DateTimeSerializationMode Mode
		{
			get
			{
				return (DateTimeSerializationSection.DateTimeSerializationMode)base[this.mode];
			}
			set
			{
				base[this.mode] = value;
			}
		}

		// Token: 0x04001B64 RID: 7012
		private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04001B65 RID: 7013
		private readonly ConfigurationProperty mode = new ConfigurationProperty("mode", typeof(DateTimeSerializationSection.DateTimeSerializationMode), DateTimeSerializationSection.DateTimeSerializationMode.Roundtrip, new EnumConverter(typeof(DateTimeSerializationSection.DateTimeSerializationMode)), null, ConfigurationPropertyOptions.None);

		/// <summary>
		///         Определяет формат сериализации XML объектов <see cref="T:System.DateTime" />.
		///       </summary>
		// Token: 0x02000317 RID: 791
		public enum DateTimeSerializationMode
		{
			/// <summary>
			///         Эквивалентно <see langword="Roundtrip" />.
			///       </summary>
			// Token: 0x04001B67 RID: 7015
			Default,
			/// <summary>
			///         Сериализатор анализирует отдельные экземпляры <see cref="T:System.DateTime" /> для определения формата сериализации: время в формате UTC, местное время или неопределенное время.
			///       </summary>
			// Token: 0x04001B68 RID: 7016
			Roundtrip,
			/// <summary>
			///         Он форматирует все объекты <see cref="T:System.DateTime" /> в формате местного времени.
			///          Это необходимо для совместимости версий 1.0 и 1.1.
			///       </summary>
			// Token: 0x04001B69 RID: 7017
			Local
		}
	}
}
