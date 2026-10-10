using System;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейс, используемый платформой .NET Framework, для поддержки инициализации свойств конфигурации.</summary>
	// Token: 0x0200007C RID: 124
	public interface IConfigSystem
	{
		/// <summary>Возвращает узел конфигурации.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.Internal.IInternalConfigHost" />, который используется платформой .NET Framework для инициализации свойств конфигурации приложения.</returns>
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000429 RID: 1065
		IInternalConfigHost Host { get; }

		/// <summary>Возвращает корень иерархии конфигурации.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.Internal.IInternalConfigRoot" />.</returns>
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600042A RID: 1066
		IInternalConfigRoot Root { get; }

		/// <summary>Инициализирует объект конфигурации.</summary>
		/// <param name="typeConfigHost">Тип узла конфигурации.</param>
		/// <param name="hostInitParams">Массив параметров узла конфигурации.</param>
		// Token: 0x0600042B RID: 1067
		void Init(Type typeConfigHost, params object[] hostInitParams);
	}
}
