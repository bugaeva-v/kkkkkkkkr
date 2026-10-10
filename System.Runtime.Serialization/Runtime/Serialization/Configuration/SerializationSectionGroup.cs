using System;
using System.Configuration;

namespace System.Runtime.Serialization.Configuration
{
	/// <summary>Обрабатывает XML-элементы, используемые для настройки сериализации с помощью <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
	// Token: 0x020001A9 RID: 425
	public sealed class SerializationSectionGroup : ConfigurationSectionGroup
	{
		/// <summary>Возвращает конфигурацию сериализации для заданной конфигурации.</summary>
		/// <param name="config">Объект <see cref="T:System.Configuration.Configuration" />, представляющий извлекаемую конфигурацию.</param>
		/// <returns>Объект <see cref="T:System.Runtime.Serialization.Configuration.SerializationSectionGroup" />, представляющий раздел конфигурации.</returns>
		// Token: 0x06001563 RID: 5475 RVA: 0x0005468B File Offset: 0x0005288B
		public static SerializationSectionGroup GetSectionGroup(Configuration config)
		{
			if (config == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("config");
			}
			return (SerializationSectionGroup)config.SectionGroups["system.runtime.serialization"];
		}

		/// <summary>Возвращает объект <see cref="T:System.Runtime.Serialization.Configuration.DataContractSerializerSection" />, используемый для настройки коллекции известных типов.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Serialization.Configuration.DataContractSerializerSection" />, используемый для раздела конфигурации сериализации.</returns>
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x000546B0 File Offset: 0x000528B0
		public DataContractSerializerSection DataContractSerializer
		{
			get
			{
				return (DataContractSerializerSection)base.Sections["dataContractSerializer"];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Runtime.Serialization.Configuration.NetDataContractSerializerSection" />, используемый для настройки коллекции известных типов.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Serialization.Configuration.NetDataContractSerializerSection" />.</returns>
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x000546C7 File Offset: 0x000528C7
		public NetDataContractSerializerSection NetDataContractSerializer
		{
			get
			{
				return (NetDataContractSerializerSection)base.Sections["netDataContractSerializer"];
			}
		}
	}
}
