using System;
using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейсы, используемые внутренними структурами .NET, для поддержки корневых объектов конфигурации.</summary>
	// Token: 0x02000083 RID: 131
	[ComVisible(false)]
	public interface IInternalConfigRoot
	{
		/// <summary>Возвращает объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />, представляющий конфигурацию, определенную путем конфигурации.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />, представляющий конфигурацию, определенную <paramref name="configPath" />.</returns>
		// Token: 0x06000471 RID: 1137
		IInternalConfigRecord GetConfigRecord(string configPath);

		/// <summary>Возвращает <see cref="T:System.Object" />, представляющий данные в разделе файла конфигурации.</summary>
		/// <param name="section">Строка, представляющая раздел файла конфигурации.</param>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий данные в разделе файла конфигурации.</returns>
		// Token: 0x06000472 RID: 1138
		object GetSection(string section, string configPath);

		/// <summary>Возвращает значение, представляющее путь файла ближайшего предка конфигурации, который имеет данные конфигурации.</summary>
		/// <param name="configPath">Путь файла конфигурации.</param>
		/// <returns>Строка, представляющая путь файла ближайшего предка конфигурации, который имеет данные конфигурации.</returns>
		// Token: 0x06000473 RID: 1139
		string GetUniqueConfigPath(string configPath);

		/// <summary>Возвращает объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />, представляющий запись уникальной конфигурации для данного пути конфигурации.</summary>
		/// <param name="configPath">Путь файла конфигурации.</param>
		/// <returns>Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />, представляющий запись уникальной конфигурации для данного пути конфигурации.</returns>
		// Token: 0x06000474 RID: 1140
		IInternalConfigRecord GetUniqueConfigRecord(string configPath);

		/// <summary>Инициализирует объект конфигурации.</summary>
		/// <param name="host">Объект <see cref="T:System.Configuration.Internal.IInternalConfigHost" />.</param>
		/// <param name="isDesignTime">
		///   <see langword="true" /> в случае режима разработки; <see langword="false" /> в случае среды выполнения.</param>
		// Token: 0x06000475 RID: 1141
		void Init(IInternalConfigHost host, bool isDesignTime);

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация являться конфигурацией режима разработки.</summary>
		/// <returns>
		///   <see langword="true" /> в случае, если конфигурация является конфигурацией режима разработки; <see langword="false" /> в случае, если конфигурация не является конфигурацией режима разработки.</returns>
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000476 RID: 1142
		bool IsDesignTime { get; }

		/// <summary>Находит и удаляет записи конфигурации и все ее дочерние элементы для данного пути конфигурации.</summary>
		/// <param name="configPath">Путь файла конфигурации.</param>
		// Token: 0x06000477 RID: 1143
		void RemoveConfig(string configPath);

		/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Configuration.Internal.IInternalConfigRoot.ConfigChanged" /> объекта <see cref="T:System.Configuration.Internal.IInternalConfigRoot" />.</summary>
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000478 RID: 1144
		// (remove) Token: 0x06000479 RID: 1145
		event InternalConfigEventHandler ConfigChanged;

		/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Configuration.Internal.IInternalConfigRoot.ConfigRemoved" /> объекта <see cref="T:System.Configuration.Internal.IInternalConfigRoot" />.</summary>
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600047A RID: 1146
		// (remove) Token: 0x0600047B RID: 1147
		event InternalConfigEventHandler ConfigRemoved;
	}
}
